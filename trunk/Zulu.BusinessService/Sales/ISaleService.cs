using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService.Sales
{
	public partial interface ISaleService
	{
		#region Sale

		/// <summary>
		/// Get the new voucher number
		/// </summary>
		/// <returns>The new voucher number.</returns>
		string GetNewVoucherNumber();

		/// <summary>
		/// Get sale by saleID
		/// </summary>
		/// <param name="saleID">The object of Sale Identifier</param>
		/// <returns>Sale object regarding to the sale Identifier</returns>
		Sale GetSalebySaleID(int saleID);

		/// <summary>
		/// Get all sale
		/// </summary>
		/// <returns>All the record from Sale table</returns>
		List<Sale> GetAllSale();

		/// <summary>
		/// Get all sale
		/// </summary>
		/// <param name="startDate">The start of for sale query</</param>
		/// <param name="endDate">The end of for sale query</param>
		/// <returns>All the record from Sale table</returns>
		List<Sale> GetAllSale(DateTime startDate, DateTime endDate);

		/// <summary>
		/// Get the new voucher number
		/// </summary>
		/// <param name="Sale">The object of Sale</param>
		void SaveSaleVoucher(Sale sale);
		
		/// <summary>
		/// Save Sale Voucher
		/// </summary>
		/// <param name="saleID">The Sale Identifier.</param>
		/// <param name="saleProductVariants">The Sale Product Variants.</param>
		void SaveSaleDetails(int saleID, List<SaleProduct> saleProductVariants);

        /// <summary>
        /// Save Sale Voucher
        /// </summary>
        /// <param name="saleID">The Sale Identifier.</param>
        /// <param name="saleProductVariants">The Sale Product Variants.</param>
        void SaveSaleDetails(SaleProduct saleproduct);

		/// <summary>
		/// Save Sale Voucher
		/// </summary>
		/// <param name="saleID">The Sale Identifier.</param>
		/// <returns>The collection of Sale Product Variants</returns>
		List<SaleProduct> GetSaleProductVariantBySaleID(int saleID);

        /// <summary>
        /// Get Barcode and Sale
        /// </summary>
        /// <param name="barcode">The barcode of the product.</param>
        /// <param name="saleProductSupports">The Sale Product support collection.</param>
        /// <returns>Current sale product support</returns>
        SaleProductSupport GetBarcodeAndSale(string barcode);

        /// <summary>
        /// Save Gift Voucher Amount
        /// </summary>
        /// <param name="saleID">The Sale Identifier.</param>
        /// <param name="giftVoucherAmount">The amount of the gift voucher.</param>
        void SaveGiftVoucherAmount(int saleID, decimal giftVoucherAmount);

        /// <summary>
        /// Get Sales by Counter Number
        /// </summary>
        /// <param name="CounterNumber">The Counter Number.</param>
        /// <returns>List of sales regarding to that counter number.</returns>
        List<Sale> GetSalesByCounterNumber(int CounterNumber);

        List<SaleProductSupport> GetSaleProductListSupportByCounter(int counterNumber);
		#endregion
	}
}
