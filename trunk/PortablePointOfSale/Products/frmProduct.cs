using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Util;
using Zulu.BusinessService;
using PortablePointOfSale.Controls;

namespace PortablePointOfSale.Products
{
	public partial class frmProduct : BaseZuluFormControl
	{
		string _Barcode;
		public List<Stock> GridData = new List<Stock>();


		public string Barcode
		{
			get
			{
				return _Barcode;
			}
			set
			{
				_Barcode = value;
			}
		}

		public frmProduct()
		{
			InitializeComponent();

			//pnlProduct.Height = Screen.PrimaryScreen.WorkingArea.Height;
			pnlProduct.Width = 1024;
			int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

			lblHeader.Left = Convert.ToInt32((Screen.PrimaryScreen.WorkingArea.Width - lblHeader.Width) / 2);

			if (DeltaWidth > 0)
			{
				pnlProduct.Left = Convert.ToInt32(DeltaWidth / 2);
			}
			else
			{
				pnlProduct.Left = 0;
			}
		}

		private void lueBarcode_EditValueChanged(object sender, EventArgs e)
		{
            //Barcode = lueBarcode.Text.ToString();

            //Product product = new Product();
            //product = ProductService.GetProductByBarcode(Barcode);

            //txtProduct.Text = product.Name;
		}

		private void cmdAdd_Click(object sender, EventArgs e)
		{
			AddQty();
		}

		private void CleanForm()
		{
            txtBarcode.Text = string.Empty;

			txtProduct.Text = string.Empty;
            spnCurQty.EditValue = 0;
			spnQty.EditValue = 0;

            txtBarcode.Focus();
		}

		private void AddQty()
		{
			if (ZuluHelper.GetIntValue(spnQty.EditValue.ToString()) > 0)
			{
                if (txtBarcode.Text.Length > 0)
                {
                    var CurProduct = ProductService.GetProductByBarcode(Barcode);

					var curStock = GridData.FirstOrDefault(c => c.Barcode == Barcode);

					if (curStock != null)
						GridData.Remove(curStock);

                    ProductService.StockUpdate(Barcode, ZuluHelper.GetIntValue(spnQty.EditValue.ToString()));

                    int TotalQty = ZuluHelper.GetIntValue(CurProduct.Quantity.ToString()) + ZuluHelper.GetIntValue(spnQty.EditValue.ToString());

                    Stock stock = new Stock();

                    stock.Barcode = Barcode;
                    stock.ProductName = txtProduct.Text;
                    stock.Quantity = ZuluHelper.GetIntValue(CurProduct.Quantity.ToString());
                    stock.AddedQuantity = ZuluHelper.GetIntValue(spnQty.EditValue.ToString());
                    stock.TotalQuantity = ZuluHelper.GetIntValue(CurProduct.Quantity.ToString()) + ZuluHelper.GetIntValue(spnQty.EditValue.ToString());

                    GridData.Add(stock);

                    grdProduct.DataSource = null;

                    grdProduct.DataSource = GridData;
                    
                    CleanForm();
                }
                else
                {
                    MessageBox.Show("Plase enter your add product.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtBarcode.Focus();
                    txtBarcode.SelectionStart = 0;
                    txtBarcode.SelectionLength = txtBarcode.Text.Length;
                }
			}
			else
			{
				MessageBox.Show("Plase enter your add quantity.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                spnQty.Focus();
                spnQty.SelectionStart = 0;
                spnQty.SelectionLength = spnQty.Text.Length;
			}
		}
		 
		private void lueBarcode_KeyDown(object sender, KeyEventArgs e)
		{
            //if (e.KeyCode == Keys.Enter)
            //{
            //    e.Handled = false;

            //    spnQty.Focus();
            //    spnQty.SelectionStart = 0;
            //    spnQty.SelectionLength = spnQty.Text.Length;
            //}
		}

		private void lueBarcode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				e.Handled = false;

                spnQty.Focus();
				spnQty.SelectionStart = 0;
				spnQty.SelectionLength = spnQty.Text.Length;
			}
		}
	
		private void lblExit_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            //lueBarcode.Properties.DataSource = ProductService.GetAllProducts();

            txtProduct.Text = string.Empty;
            spnQty.EditValue = 0;
        }

        private void lueBarcode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    spnQty.Focus();
        }

        private void spnQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (spnQty.Text.Length > 4)
                {
                    //lueBarcode.Text = spnQty.Text;
                    //lueBarcode.SelectionStart = 4;

                    string barcode = spnQty.Text;
                    spnQty.EditValue = 0;

                    barcode = barcode.Replace(",", "");

                    txtBarcode.Text = barcode;
                    //txtBarcode.SelectionStart = 4;
                    //txtBarcode.Focus();

                    Barcode = txtBarcode.Text.ToString();

                    Product product = new Product();
                    product = ProductService.GetProductByBarcode(Barcode);

                    if (product == null)
                    {
                        MessageBox.Show("Your product is not valid.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtBarcode.Focus();
                        txtBarcode.SelectionStart = 0;
                        txtBarcode.SelectionLength = txtBarcode.Text.Length;
                    }
                    else
                    {
                        txtProduct.Text = product.Name;
                        spnCurQty.EditValue = product.Quantity;

                        spnQty.Focus();
                        spnQty.SelectionStart = 0;
                        spnQty.SelectionLength = spnQty.Text.Length;
                    }
                }
                else
                {
                    AddQty();
                }
            }
        }

        private void grdProductView_Click(object sender, EventArgs e)
        {
            //lueBarcode.Focus();
            txtBarcode.Focus();
        }

        private void frmProduct_Click(object sender, EventArgs e)
        {
            //lueBarcode.Focus();
            txtBarcode.Focus();
        }

        private void spnQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }            
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter) 
            {
                Barcode = txtBarcode.Text.ToString();

                Product product = new Product();
                product = ProductService.GetProductByBarcode(Barcode);

                if (product == null)
                {
                    MessageBox.Show("Your product is not valid.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtBarcode.Focus();
                    txtBarcode.SelectionStart = 0;
                    txtBarcode.SelectionLength = txtBarcode.Text.Length;
                }
                else
                {
                    txtProduct.Text = product.Name;
                    spnCurQty.EditValue = product.Quantity;

                    e.Handled = false;

                    spnQty.Focus();
                    spnQty.SelectionStart = 0;
                    spnQty.SelectionLength = spnQty.Text.Length;
                }
            }          
            
        }
	}

	public class Stock
	{
		public string Barcode { get; set; }
		public string ProductName { get; set; }
		public int Quantity { get; set; }
		public int AddedQuantity { get; set; }
		public int TotalQuantity { get; set; }
	}
}