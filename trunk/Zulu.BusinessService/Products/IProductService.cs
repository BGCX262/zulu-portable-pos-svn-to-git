using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Data;
using System.IO;

namespace Zulu.BusinessService.Products
{
	public partial interface IProductService
	{
		#region Product

		/// <summary>
		/// Get Product By ID. 
		/// </summary>
		/// <param name="productID">The product identifier</param>
		/// <returns>Product</returns>
		Product GetProductByID(int productID);

		/// <summary>
		/// Get all products. 
		/// </summary>
		/// <returns>The list of all Products.</returns>
		List<Product> GetAllProducts();

		/// <summary>
		/// Get Product By Barcode. 
		/// </summary>
		/// <param name="barcode">The product barcode</param>
		/// <returns>Product</returns>
		Product GetProductByBarcode(string barcode);

		/// <summary>
		/// Bulk Insert Products 
		/// </summary>
		/// <param name="products">The list of products.</param>
		void BulkInsertProducts(List<Product> products);

		/// <summary>
		/// UpdateSaleStock
		/// </summary>
		/// <param name="products">The list of products.</param>
		void UpdateSaleStock(List<SaleProduct> saleProducts);

		/// <summary>
		/// Import all the products from CSV 
		/// </summary>
		/// <param name="srProductInCSV">The stream reader value of product CSV</param>
		/// <returns>Product</returns>
		int ImportCSVProduct(StreamReader srProductInCSV);

		// <summary>
		/// Stock Update 
		/// </summary>
		/// <param name="barcode">The barcode of the stock</param>
		/// <param name="quantity">The quantity of the product to update</param>
		Product StockUpdate(string barcode, int quantity);

		#endregion

		#region Manufacturer

		/// <summary>
		/// Get Manufacturer By ID. Firstly look from the project cache and get from the database 
		/// </summary>
		/// <param name="manufacturerID">The manufacturer identifier</param>
		/// <returns>Manufacturer</returns>
		Manufacturer GetManufacturerByID(int manufacturerID);

		/// <summary>
		/// Get Manufacturer By name. Firstly look from the project cache and get from the database 
		/// </summary>
		/// <param name="manufacturerName">The manufacturer name</param>
		/// <returns>Manufacturer</returns>
		Manufacturer GetManufacturerByName(string manufacturerName);

		/// <summary>
		/// Get All manufacturers from the database
		/// </summary>
		/// <returns>Manufacturers</returns>
		List<Manufacturer> GetAllManufacturers();

		/// <summary>
		/// Save Manufacturers use for both Insert and Update 
		/// </summary>
		/// <param name="Manufacturer">The manufacturer.</param>
		bool SaveManufacturer(Manufacturer manufacturer);



		#endregion


	}
}
