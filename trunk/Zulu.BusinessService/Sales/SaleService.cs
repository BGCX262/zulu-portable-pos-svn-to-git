using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Util;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Products;
using Zulu.BusinessService.Settings;

namespace Zulu.BusinessService.Sales
{
	public partial class SaleService : ISaleService
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
		public SaleService(ZuluDataContext context)
        {
            this._context = context;
        }

        #endregion

		#region Sale

		/// <summary>
		/// Get the new voucher number
		/// </summary>
		/// <returns>The new voucher number.</returns>
		public string GetNewVoucherNumber()
		{
			string BaseVoucherNumber = ApplicationSetting.BaseVoucherNumber;
			var sale = new Sale();

			var sales = _context.Sales.OrderByDescending(c => c.CreatedOn).Take(10).ToList();

			if (sales != null && sales.Count > 0)
			{
				sale = sales.OrderBy(c => c.CreatedOn).LastOrDefault(c => c.VoucherNumber.Contains(BaseVoucherNumber));
			}

			int intReceiptNumber = 0;

			if (sale == null || sale.SaleID == 0)
				return BaseVoucherNumber + "0001";

			string receiptNumber = sale.VoucherNumber.Substring(sale.VoucherNumber.Count() - 4);
			int.TryParse(receiptNumber, out intReceiptNumber);

			intReceiptNumber = intReceiptNumber + 1;

			return BaseVoucherNumber + intReceiptNumber.ToString("0000");
		}

		/// <summary>
		/// Get sale by saleID
		/// </summary>
		/// <param name="saleID">The object of Sale Identifier</param>
		/// <returns>Sale object regarding to the sale Identifier</returns>
		public Sale GetSalebySaleID(int saleID)
		{
			return _context.Sales.FirstOrDefault(c => c.SaleID == saleID);
		}

        public List<Sale> GetSalesByCounterNumber(int CounterNumber)
        {
			DateTime startDate = new DateTime(2013,6,24);
			DateTime endDate = new DateTime(2013, 6, 26);
            if (CounterNumber == 0)
				return _context.Sales.Where(c => c.CreatedOn > startDate && c.CreatedOn < endDate).ToList();

			return _context.Sales.Where(c => c.CounterNumber == CounterNumber && c.CreatedOn > startDate && c.CreatedOn < endDate).ToList();
        }

		/// <summary>
		/// Get all sale
		/// </summary>
		/// <returns>All the record from Sale table</returns>
		public List<Sale> GetAllSale()
		{
			return _context.Sales.ToList();
		}

		/// <summary>
		/// Get all sale
		/// </summary>
		/// <param name="startDate">The start of for sale query</</param>
		/// <param name="endDate">The end of for sale query</param>
		/// <returns>All the record from Sale table</returns>
		public List<Sale> GetAllSale(DateTime startDate, DateTime endDate)
		{
			return _context.Sales.Where(c => c.CreatedOn >= startDate && c.CreatedOn <= endDate).ToList();
		}

		/// <summary>
		/// Save Sale Voucher
		/// </summary>
		/// <param name="sale">The object of Sale</param>
		public void SaveSaleVoucher(Sale sale)
		{
			Sale existingData = GetSalebySaleID(sale.SaleID);

			if (existingData == null)
			{
				sale.CreatedOn = DateTime.Now;
				_context.Sales.AddObject(sale);
			}
			else
			{
				existingData.VoucherNumber = sale.VoucherNumber;
				existingData.SellerID = sale.SellerID;
				existingData.CounterNumber = sale.CounterNumber;
				existingData.CreatedOn = sale.CreatedOn;
				existingData.SaleTotalQuantity = sale.SaleTotalQuantity;
				existingData.SaleStatus = sale.SaleStatus;
				existingData.SaleTotal = sale.SaleTotal;
                existingData.GiftVoucherAmount = sale.GiftVoucherAmount;

				if (!_context.IsAttached(existingData))
					_context.Sales.Attach(existingData);
			}
			_context.SaveChanges();
		}

		/// <summary>
		/// Save Sale Voucher
		/// </summary>
		/// <param name="saleID">The Sale Identifier.</param>
		/// <param name="saleProducts">The Sale Products.</param>
        public void SaveSaleDetails(int saleID, List<SaleProduct> saleProducts)
        {
            var existingSaleProductVariants = GetSaleProductVariantBySaleID(saleID);
            var sale = GetSalebySaleID(saleID);

            if (sale.SaleStatus == 2)
                IoC.Resolve<IProductService>().UpdateSaleStock(saleProducts);

            if (existingSaleProductVariants != null || existingSaleProductVariants.Count > 0)
            {
                foreach (var existingProductVariant in existingSaleProductVariants)
                {
                    var saleProductVariant = saleProducts.FirstOrDefault(c => c.SaleProductID == existingProductVariant.SaleProductID);

                    if (saleProductVariant.Quantity != existingProductVariant.Quantity)
                        UpdateSaleProductQuantity(saleProductVariant.SaleProductID, (int)saleProductVariant.Quantity);

                    saleProducts.Remove(saleProductVariant);
                }
            }

            foreach (var saleProduct in saleProducts)
            {
                _context.SaleProducts.AddObject(saleProduct);
                Product product = IoC.Resolve<IProductService>().GetProductByBarcode(saleProduct.ProductBarcode);
            }
            _context.SaveChanges();
        }

        /// <summary>
        /// Get Barcode and Sale
        /// </summary>
        /// <param name="barcode">The barcode of the product.</param>
        /// <param name="saleProductSupports">The Sale Product support collection.</param>
        /// <returns>Current sale product support</returns>
        public SaleProductSupport GetBarcodeAndSale(string barcode)
        {
            Product product = IoC.Resolve<IProductService>().GetProductByBarcode(barcode);
            List<SaleProductSupport> saleProductSupports = new List<SaleProductSupport>();
            SaleProductSupport saleProductSupport = new SaleProductSupport();
            int quantity = 1; int price = ApplicationSetting.Price;

            if (product == null)
                return null;

            if (ZuluContext.Current.SaleProductSupports != null && ZuluContext.Current.SaleProductSupports.Count != 0)
            {
                saleProductSupports = ZuluContext.Current.SaleProductSupports;
                var tempSaleproductSupport = saleProductSupports.FirstOrDefault(c => c.ProductBarcode == barcode);

                if (tempSaleproductSupport != null)
                {
                    quantity = quantity + tempSaleproductSupport.Quantity;
                    ZuluContext.Current.SaleProductSupports.Remove(tempSaleproductSupport);
                }
            }
            else
                ZuluContext.Current.SaleProductSupports = new List<SaleProductSupport>();

            saleProductSupport.ProductBarcode = barcode;
            saleProductSupport.ProductName = product.Name;
            saleProductSupport.UnitPrice = price;
            saleProductSupport.Quantity = quantity;

            ZuluContext.Current.SaleProductSupports.Add(saleProductSupport);

            return saleProductSupport;
        }

         ///<summary>
         ///Save Sale Voucher
         ///</summary>
         ///<param name="saleID">The Sale Identifier.</param>
         ///<param name="saleProducts">The Sale Products.</param>
        public void SaveSaleDetails(SaleProduct saleproduct)
        {
            SaleProduct existingData = GetSaleProductByID(saleproduct.SaleProductID);

            if (existingData == null)
            {
                //saleproduct.CreatedOn = DateTime.Now;
                _context.SaleProducts.AddObject(saleproduct);
            }
            else
            {
                existingData.SaleID = saleproduct.SaleID;
                existingData.ProductBarcode = saleproduct.ProductBarcode;
                existingData.ProductName = saleproduct.ProductName;
                existingData.Quantity = saleproduct.Quantity;
                existingData.UnitPrice = saleproduct.UnitPrice;
                existingData.TotalCost = saleproduct.TotalCost;

                if (!_context.IsAttached(existingData))
                    _context.SaleProducts.Attach(existingData);
            }
            _context.SaveChanges();
        }

		/// <summary>
		/// Get Sale Product Variant By sale product variant identifier
		/// </summary>
		/// <param name="saleProductVariantID">The Sale Product Variant Identifier.</param>
		/// <returns>The object of Sale Product Variant</returns>
		public SaleProduct GetSaleProductByID(int saleProductID)
		{
			return _context.SaleProducts.FirstOrDefault(c => c.SaleProductID == saleProductID);
		}

		/// <summary>
		/// Save Sale Voucher
		/// </summary>
		/// <param name="saleID">The Sale Identifier.</param>
		/// <returns>The collection of Sale Product Variants</returns>
		public List<SaleProduct> GetSaleProductVariantBySaleID(int saleID)
		{
			return _context.SaleProducts.Where(c => c.SaleID == saleID).ToList();
		}

        /// <summary>
		/// Save Sale Voucher
		/// </summary>
		/// <param name="saleID">The Sale Identifier.</param>
		/// <returns>The collection of Sale Product Variants</returns>
		private void UpdateSaleProductQuantity(int saleProductVariantID, int quantity)
		{
			var SaleProductVariant = GetSaleProductByID(saleProductVariantID);

			if(SaleProductVariant != null)
				throw new ArgumentNullException("Sale");

			SaleProductVariant.Quantity = SaleProductVariant.Quantity - quantity;

			if (!_context.IsAttached(SaleProductVariant))
				_context.SaleProducts.Attach(SaleProductVariant);

			_context.SaveChanges();
		}

        /// <summary>
        /// Save Gift Voucher Amount
        /// </summary>
        /// <param name="saleID">The Sale Identifier.</param>
        /// <param name="giftVoucherAmount">The amount of the gift voucher.</param>
        public void SaveGiftVoucherAmount(int saleID, decimal giftVoucherAmount)
        {
            Sale existingData = GetSalebySaleID(saleID);
            existingData.GiftVoucherAmount = giftVoucherAmount;

            if (!_context.IsAttached(existingData))
                _context.Sales.Attach(existingData);

            _context.SaveChanges();
        }

        
        public List<SaleProductSupport> GetSaleProductListSupportByCounter(int counterNumber)
        {
            List<SaleProductSupport> saleProductSupports = new List<SaleProductSupport>();
            List<Sale> sales = GetSalesByCounterNumber(counterNumber);
            List<SaleProduct> allSaleProducts = _context.SaleProducts.ToList();

            foreach (var sale in sales)
            {
                var saleProducts = allSaleProducts.Where(c => c.SaleID == sale.SaleID).ToList();
                foreach(var saleProduct in saleProducts)
                {
                    SaleProductSupport saleProductSupport = new SaleProductSupport();
                    saleProductSupport.ProductBarcode = saleProduct.ProductBarcode;
                    saleProductSupport.ProductName = saleProduct.ProductName;
					saleProductSupport.UnitPrice = (int) saleProduct.UnitPrice;

                    var existingSaleProductSupport = saleProductSupports.FirstOrDefault(c => c.ProductBarcode == saleProduct.ProductBarcode);

                    if (existingSaleProductSupport != null)
                    {
                        saleProductSupports.Remove(existingSaleProductSupport);
                        saleProductSupport.Quantity = existingSaleProductSupport.Quantity + int.Parse(saleProduct.Quantity.ToString());
                    }
                    else
                        saleProductSupport.Quantity = int.Parse(saleProduct.Quantity.ToString());
                    
                    saleProductSupports.Add(saleProductSupport);
                }
            }
            return saleProductSupports;
        }

 		#endregion
    }
}
