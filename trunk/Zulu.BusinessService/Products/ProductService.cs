using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Infrastructure;
using LINQtoCSV;
using System.IO;

namespace Zulu.BusinessService.Products
{
	public partial class ProductService	: IProductService
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
		public ProductService(ZuluDataContext context)
        {
            this._context = context;
        }

		public ProductService()
		{
			
		}

        #endregion

		#region Product

		/// <summary>
		/// Get Product By ID. 
		/// </summary>
		/// <param name="productID">The product identifier</param>
		/// <returns>Product</returns>
		public Product GetProductByID(int productID)
		{
			return _context.Products.FirstOrDefault(c => c.ProductID == productID);
		}

		/// <summary>
		/// Get all products. 
		/// </summary>
		/// <returns>The list of all Products.</returns>
		public List<Product> GetAllProducts()
		{
			return _context.Products.ToList();
		}

		/// <summary>
		/// Get Product By Barcode. 
		/// </summary>
		/// <param name="barcode">The product barcode</param>
		/// <returns>Product</returns>
		public Product GetProductByBarcode(string barcode)
        {
			Product product = _context.Products.FirstOrDefault(c => c.Barcode == barcode);

            if (product != null)
                return product;

            return GetProductByID(7021);
        }

		/// <summary>
		/// Bulk Insert Products 
		/// </summary>
		/// <param name="products">The list of products.</param>
		public void BulkInsertProducts(List<Product> products)
		{
			List<Product> existingProducts = GetAllProducts();

			foreach (var product in products)
			{
				Product existingProduct = existingProducts.FirstOrDefault(c => c.Barcode == product.Barcode);

				if(existingProduct == null || existingProduct.ProductID == 0)
					_context.Products.AddObject(product);
			}

			_context.SaveChanges();
		}

		/// <summary>
		/// UpdateSaleStock
		/// </summary>
		/// <param name="products">The list of products.</param>
		public void UpdateSaleStock(List<SaleProduct> saleProducts)
		{
			foreach (var saleProduct in saleProducts)
			{
				Product product = GetProductByBarcode(saleProduct.ProductBarcode);

				if (product != null && product.ProductID != 0)
				{
					product.Quantity = product.Quantity - saleProduct.Quantity;

					if (!_context.IsAttached(product))
						_context.Products.Attach(product);
				}
			}
			_context.SaveChanges();
		}

		/// <summary>
		/// Import all the products from CSV 
		/// </summary>
		/// <param name="srProductInCSV">The stream reader value of product CSV</param>
		/// <returns>Product</returns>
		public int ImportCSVProduct(StreamReader srProductInCSV)
		{
			List<Product> existingproducts = GetAllProducts();
			List<Manufacturer> manufacturers = GetAllManufacturers();
			int recordAdded = 0; int totalQuantities = 0;
			List<Product> products = new List<Product>();
			List<ProductInCSV> missingProducts = new List<ProductInCSV>();

			CsvFileDescription inputFileDescription = new CsvFileDescription
			{
				SeparatorChar = ',',
				FirstLineHasColumnNames = true
			};

			CsvContext cc = new CsvContext();
			
			IEnumerable<ProductInCSV> rawCSVProducts = cc.Read<ProductInCSV>(srProductInCSV, inputFileDescription);

			var csvProducts = (from p in rawCSVProducts
								   select p).ToList();
			
			foreach (var csvProduct in csvProducts)
			{
				Product existingproduct = new Product();

				if(	existingproducts != null && existingproducts.Count > 0)
					existingproduct = existingproducts.FirstOrDefault(c => c.Barcode == csvProduct.BarCode);

				if (existingproduct == null || existingproduct.ProductID == 0)
				{
					if (csvProduct.BarCode != null && csvProduct.Origin != null)
					{
						Product product = new Product();
						product.Name = csvProduct.ProductFullName;
						product.Barcode = csvProduct.BarCode;
						product.ManufacturerID = manufacturers.FirstOrDefault(c => c.Name == csvProduct.Origin.Trim().ToLowerInvariant()).ManufacturerID;

						int quantities = 0;
						int.TryParse(csvProduct.Quantities, out quantities);

						if (quantities > 10)
						{
							product.Quantity = 10;
							product.RemainingQuantity = quantities - 10;
						}
						else
						{
							product.Quantity = quantities;
							product.RemainingQuantity = 0;
						}

						products.Add(product);

						totalQuantities = totalQuantities + quantities;

						recordAdded++;
					}
					else
					{
						missingProducts.Add(csvProduct);
					}
				}
			}
			BulkInsertProducts(products);
			return recordAdded; 
		}

		// <summary>
		/// Stock Update 
		/// </summary>
		/// <param name="barcode">The barcode of the stock</param>
		/// <param name="quantity">The quantity of the product to update</param>
		/// <returns>Product</returns>
		public Product StockUpdate(string barcode, int quantity)
		{
			Product product = GetProductByBarcode(barcode);

			if (product != null && product.ProductID != 0)
			{
				product.Quantity = product.Quantity + quantity;

				if (!_context.IsAttached(product))
					_context.Products.Attach(product);
			}
			_context.SaveChanges();
			return product;
		}

		#endregion

		#region Manufacturer

		/// <summary>
		/// Get Manufacturer By ID. Firstly look from the project cache and get from the database 
		/// </summary>
		/// <param name="manufacturerID">The manufacturer identifier</param>
		/// <returns>Manufacturer</returns>
		public Manufacturer GetManufacturerByID(int manufacturerID)
		{
			if (manufacturerID == 0)
				return null;

			return _context.Manufacturers.FirstOrDefault(c => c.ManufacturerID == manufacturerID);
		}

		/// <summary>
		/// Get Manufacturer By name. Firstly look from the project cache and get from the database 
		/// </summary>
		/// <param name="manufacturerName">The manufacturer name</param>
		/// <returns>Manufacturer</returns>
		public Manufacturer GetManufacturerByName(string manufacturerName)
		{
			if (string.IsNullOrEmpty(manufacturerName))
				return null;

			return _context.Manufacturers.FirstOrDefault(c => c.Name == manufacturerName);
		}

		/// <summary>
		/// Get All manufacturers from the database
		/// </summary>
		/// <returns>Manufacturers</returns>
		public List<Manufacturer> GetAllManufacturers()
		{
			return _context.Manufacturers.ToList();
		}

		/// <summary>
		/// Save Manufacturers use for both Insert and Update 
		/// </summary>
		/// <param name="Manufacturer">The manufacturer.</param>
		public bool SaveManufacturer(Manufacturer manufacturer)
		{
			Manufacturer existingData = new Manufacturer();

			existingData = GetManufacturerByName(manufacturer.Name);

			if (existingData != null && existingData.ManufacturerID != manufacturer.ManufacturerID)
			{
				if (existingData.ManufacturerID != 0)
					return false;
			}

			existingData = GetManufacturerByID(manufacturer.ManufacturerID);

			if (existingData == null)
			{
				_context.Manufacturers.AddObject(manufacturer);
			}
			else
			{
				existingData.Name = manufacturer.Name;
				existingData.Description = manufacturer.Description;

				if (!_context.IsAttached(existingData))
					_context.Manufacturers.Attach(existingData);
			}
			_context.SaveChanges();

			return true;
		}
		#endregion
	}
}
