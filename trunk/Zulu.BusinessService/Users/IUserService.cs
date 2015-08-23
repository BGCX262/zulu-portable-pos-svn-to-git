using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService.Data
{
	public partial interface IUserService
	{
		#region User

		/// <summary>
		/// Get user by User ID 
		/// </summary>
		/// <param name="userID">The user identifier</param>
		/// <returns>User</returns>
		User GetUserByID(int userID);

		/// <summary>
		/// Get user by Username 
		/// </summary>
		/// <param name="username">The username</param>
		/// <returns>User</returns>
		User GetUserByUserName(string UserName);

		/// <summary>
		/// Get user by Username 
		/// </summary>
		/// <returns>The list of users</returns>
		List<User> GetAllUsers();

		/// <summary>
		/// Get user by Username 
		/// </summary>
		/// <param name="username">The username</param>
		/// <param name="password">Password</param>
		/// <param name="fullname">Full Name</param>
		void InsertUser(string username, string password, string fullname);

		/// <summary>
		/// Verify User 
		/// </summary>
		/// <param name="username">The username</param>
		/// <param name="password">Password</param>
		/// <rereturns>Verified or Not</rereturns>
		bool VerifyUser(string userName, string password);

		/// <summary>
		/// Change password
		/// </summary>
		/// <param name="username">The username</param>
		/// <param name="oldPassword">oldPassword</param>
		/// <param name="newPassword">newPassword</param>
		/// <rereturns>Password change successful or not</rereturns>
		bool ChangePassword(string username, string oldPassword, string newPassword);

		/// <summary>
		/// Reset password
		/// </summary>
		/// <param name="username">The username</param>
		/// <param name="newPassword">newPassword</param>
		/// <rereturns>Reset password successful or not</rereturns>
		bool ResetPassword(string username, string newPassword);

		#endregion


	}
}
