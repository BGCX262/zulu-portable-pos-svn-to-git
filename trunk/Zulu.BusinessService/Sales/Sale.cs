using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Sales;

namespace Zulu.BusinessService.Data
{
	public partial class Sale
	{
		#region CustomProperties

		/// <summary>
		/// Gets the Member Object by Using Seller Identifier 
		/// </summary>
		public User Seller
		{
			get
			{
				return IoC.Resolve<IUserService>().GetUserByID((int)this.SellerID);
			}
		}

		#endregion

        public decimal CashAmount
        {
            get
            {
                decimal cashAmount = 0;

                if(SaleTotal != null && GiftVoucherAmount != null)
                    cashAmount = decimal.Parse(SaleTotal.ToString()) - decimal.Parse(GiftVoucherAmount.ToString());

                return cashAmount;
            }
        }
	}
}
