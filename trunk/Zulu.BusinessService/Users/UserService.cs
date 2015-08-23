using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Data;
using System.Security.Cryptography;
using Zulu.BusinessService.Infrastructure;

namespace Zulu.BusinessService.Data
{
	public partial class UserService : IUserService
	{
		#region Fields

        /// <summary>
        /// Object context
        /// </summary>
        private readonly ZuluDataContext _context;


        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="context">Object context</param>
		public UserService(ZuluDataContext context)
        {
            this._context = context;
        }

        #endregion

		#region User

		/// <summary>
		/// Get user by User ID 
		/// </summary>
		/// <param name="userID">The user identifier</param>
		/// <returns>User</returns>
		public User GetUserByID(int userID)
		{
			return _context.Users.FirstOrDefault(c => c.UserID == userID);
		}

		/// <summary>
		/// Get user by Username 
		/// </summary>
		/// <param name="username">The username</param>
		/// <returns>User</returns>
		public User GetUserByUserName(string UserName)
		{
			return _context.Users.FirstOrDefault(c => c.Username == UserName);
		}

		/// <summary>
		/// Get user by Username 
		/// </summary>
		/// <returns>The list of users</returns>
		public List<User> GetAllUsers()
		{
			return _context.Users.ToList();
		}

		/// <summary>
		/// Get user by Username 
		/// </summary>
		/// <param name="username">The username</param>
		/// <param name="password">Password</param>
		/// <param name="fullname">Full Name</param>
		public void InsertUser(string username, string password, string fullname)
		{
			string saltKey = CreateSalt(7);

			User user = new User();
			user.Username = username;
			user.Salt = saltKey;
			user.Fullname = fullname;
			user.PasswordHash = GetSHA1HashData(password, saltKey);

			_context.Users.AddObject(user);
			_context.SaveChanges();
		}

		/// <summary>
		/// Verify User 
		/// </summary>
		/// <param name="username">The username</param>
		/// <param name="password">Password</param>
		/// <rereturns>Verified or Not</rereturns>
		public bool VerifyUser(string userName, string password)
		{
			User user = GetUserByUserName(userName);

			if (user == null)
				return false;

			string passwordHash = GetSHA1HashData(password, user.Salt);
			bool validate = passwordHash == user.PasswordHash;
			
			if (validate)
				ZuluContext.Current.CurrentUser = user;
			
			return validate;
		}

		/// <summary>
		/// Change password
		/// </summary>
		/// <param name="username">The username</param>
		/// <param name="oldPassword">oldPassword</param>
		/// <param name="newPassword">newPassword</param>
		/// <rereturns>Password change successful or not</rereturns>
		public bool ChangePassword(string username, string oldPassword, string newPassword)
		{
			User user = GetUserByUserName(username);

			if (user == null)
				return false;

			string passwordHash = GetSHA1HashData(oldPassword, user.Salt);
			bool validate = passwordHash == user.PasswordHash;

			if (validate)
			{
				string saltKey = CreateSalt(7);

				user.Salt = saltKey;
				user.PasswordHash = GetSHA1HashData(newPassword, saltKey);

				if (!_context.IsAttached(user))
					_context.Users.Attach(user);

				return true;
			}

			return false;
		}

		/// <summary>
		/// Reset password
		/// </summary>
		/// <param name="username">The username</param>
		/// <param name="newPassword">newPassword</param>
		/// <rereturns>Reset password successful or not</rereturns>
		public bool ResetPassword(string username, string newPassword)
		{
			User user = GetUserByUserName(username);
			
			if (user == null)
				return false;
			try
			{
				string saltKey = CreateSalt(7);
				//Getting Encrypted password
				user.Salt = saltKey;
				user.PasswordHash = GetSHA1HashData(newPassword, saltKey);
				if (!_context.IsAttached(user))
					_context.Users.Attach(user);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		#endregion

		#region Custom Methods

		private string GetSHA1HashData(string password, string salt)
		{
			string dataToHash = password + salt;

			SHA1 sha1 = SHA1.Create();
			byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(dataToHash));
			StringBuilder returnValue = new StringBuilder();

			for (int i = 0; i < hashData.Length; i++)
			{
				returnValue.Append(hashData[i].ToString());
			}

			return returnValue.ToString();
		}

		private string CreateSalt(int size)
		{
			var provider = new RNGCryptoServiceProvider();
			byte[] data = new byte[size];
			provider.GetBytes(data);
			return Convert.ToBase64String(data);
		}

		#endregion
	}
}
