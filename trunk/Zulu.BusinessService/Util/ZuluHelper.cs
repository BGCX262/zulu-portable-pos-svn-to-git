using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Zulu.BusinessService.Infrastructure;
using System.Security.Cryptography;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService.Util
{
    public class ZuluHelper
    {
		public static string ApplicationPath
		{
			get
			{
				return System.AppDomain.CurrentDomain.BaseDirectory.ToString();
			}
		}

		/// <summary>
		/// Returns the intenger value
		/// </summary>
		public static int GetIntValue(string ChangeString)
		{
			int IntValue = 0;
			int.TryParse(ChangeString, out IntValue);
			return IntValue;
		}

        /// <summary>
        /// Verifies that a string is in valid e-mail format
        /// </summary>
        /// <param name="email">Email to verify</param>
        /// <returns>true if the string is a valid e-mail address and false if it's not</returns>
        public static bool IsValidEmail(string email)
        {
            bool result = false;
            if (String.IsNullOrEmpty(email))
                return result;
            email = email.Trim();
            result = Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            return result;
        }

        public static string EnsureNotNull(string str)
        {
            if (str == null)
                return string.Empty;

            return str;
        }

		/// <summary>
		/// Ensure that a string doesn't exceed maximum allowed length
		/// </summary>
		/// <param name="str">Input string</param>
		/// <param name="maxLength">Maximum length</param>
		/// <returns>Input string if its lengh is OK; otherwise, truncated input string</returns>
		public static string EnsureMaximumLength(string str, int maxLength)
		{
			if (String.IsNullOrEmpty(str))
				return str;

			if (str.Length > maxLength)
				return str.Substring(0, maxLength);
			else
				return str;
		}

		public static bool ButtonTest()
		{
			return false;
		}

		/// <summary>
		/// Verifies that a string is Empty or not
		/// </summary>
		/// <param name="str">String to verify</param>
		/// <returns>True if the string is empty.</returns>
		public static bool CheckStringIsEmptyOrNull(string str)
		{
			if (str == null)
				return true;
			if (str.Trim() == string.Empty)
				return true;

			return false;
		}

		/// <summary>
		/// Returns the content type based on the given file extension
		/// </summary>
		public static string GetContentType(string fileExtension)
		{
			var mimeTypes = new Dictionary<String, String>
            {
                {".bmp", "image/bmp"},
                {".gif", "image/gif"},
                {".jpeg", "image/jpeg"},
                {".jpg", "image/jpeg"},
                {".png", "image/png"},
                {".tif", "image/tiff"},
                {".tiff", "image/tiff"},
                {".doc", "application/msword"},
                {".docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document"},
                {".pdf", "application/pdf"},
                {".ppt", "application/vnd.ms-powerpoint"},
                {".pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation"},
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".xls", "application/vnd.ms-excel"},
                {".csv", "text/csv"},
                {".xml", "text/xml"},
                {".txt", "text/plain"},
                {".zip", "application/zip"},
                {".ogg", "application/ogg"},
                {".mp3", "audio/mpeg"},
                {".wma", "audio/x-ms-wma"},
                {".wav", "audio/x-wav"},
                {".wmv", "audio/x-ms-wmv"},
                {".swf", "application/x-shockwave-flash"},
                {".avi", "video/avi"},
                {".mp4", "video/mp4"},
                {".mpeg", "video/mpeg"},
                {".mpg", "video/mpeg"},
                {".qt", "video/quicktime"}
            };

			// if the file type is not recognized, return "application/octet-stream" so the browser will simply download it
			return mimeTypes.ContainsKey(fileExtension) ? mimeTypes[fileExtension] : "application/octet-stream";
		}
    }
}
