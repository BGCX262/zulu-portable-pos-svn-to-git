using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService.Settings
{
	/// <summary>
	/// Represents ApplicationSetting
	/// </summary>
	public partial class ApplicationSetting
	{
		/// <summary>
		/// Gets the price from the setting table
		/// </summary>
		public static int Price
		{
			get
			{
				int price = 0;
				Setting setting = new Setting();

				setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.Price");

				if (setting == null || setting.SettingID == 0)
					setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.Price", "1800", "1800");

				int.TryParse(setting.Value, out price);

				return price;
			}
		}

		/// <summary>
		/// Gets the client ID from the config file
		/// </summary>
		public static string ClientID
		{
			get
			{
				return ConfigurationManager.AppSettings["ClientID"];
			}
		}

		/// <summary>
		/// Gets the short date of today
		/// </summary>
		public static string TodayShortDate
		{
			get
			{
				return System.DateTime.Now.ToString("ddMMyy");
			}
		}

		/// <summary>
		/// Gets the base voucher number
		/// </summary>
		public static string BaseVoucherNumber
		{
			get
			{
				return "0000" + TodayShortDate + ClientID;
			}

		}
	}
}
