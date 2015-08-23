using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Zulu.BusinessService.Settings;
using PortablePointOfSale.Controls;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Util;
using Zulu.BusinessService;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Zulu.BusinessService.Sales;
using ProtablePointOfSale.ReportForm;


namespace PortablePointOfSale.Sales
{
    public partial class frmSaleVoucher : BaseZuluFormControl
    {
        string _Barcode;
        //public List<Stock> GridData = new List<Stock>();
        private List<SaleProduct> saleProducts { get; set; }
        string _DelBarcode;
        int _Quantity = 0;

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

        public string DelBarcode
        {
            get
            {
                return _DelBarcode;
            }
            set
            {
                _DelBarcode = value;
            }
        }

        public int Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                _Quantity = value;
            }
        }

        public frmSaleVoucher()
        {
            InitializeComponent();

            pnlSaleVoucher.Width = 1024;
            int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            if (DeltaWidth > 0)
            {
                pnlSaleVoucher.Left = Convert.ToInt32(DeltaWidth / 2);
            }
            else
            {
                pnlSaleVoucher.Left = 0;
            }
        }

        private void NewVoucher()
        {
            lblVoucherNo.Text = string.Empty;
            lblVoucherNo.Text = SaleService.GetNewVoucherNumber();

            ZuluContext.Current.SaleProductSupports = new List<SaleProductSupport>();

            lblTotalAmount.Text = "00";
            lblDiscount.Text = "00";
            lblTax.Text = "00";
            lblNetAmount.Text = "00";
            grdSaleProducts.DataSource = null;

            CleanText();

            ReadOnly(false);

            txtBarcode.Focus();
        }

        private void PendingVoucher() //Fucntion Key F9
        {
            Sale sale = new Sale();
            sale.SaleStatus = 1;
        }

        private void PrintVoucher() //Function Key F11
        {
                Sale sale = new Sale();
                int totalQuantity = 0;
                List<SaleProduct> saleProducts = new List<SaleProduct>();

                if(txtBarcode.Text.Length > 0)
                    AddSaleProducts(int.Parse(spnQty.Text.ToString()));

                sale.VoucherNumber = lblVoucherNo.Text;
                sale.SellerID = ZuluContext.Current.CurrentUser.UserID;
                sale.CounterNumber = int.Parse(ApplicationSetting.ClientID);
                sale.SaleTotal = int.Parse(lblTotalAmount.Text.Replace(",", ""));
                sale.GiftVoucherAmount = 0;

                foreach (var loopSaleProductSupport in ZuluContext.Current.SaleProductSupports)
                {
                    totalQuantity = totalQuantity + loopSaleProductSupport.Quantity;
                }

                sale.SaleTotalQuantity = totalQuantity;
                sale.SaleStatus = 2;

                SaleService.SaveSaleVoucher(sale);

                foreach (var loopSaleProductSupport in ZuluContext.Current.SaleProductSupports)
                {
                    SaleProduct saleProduct = new SaleProduct();
                    saleProduct.SaleID = sale.SaleID;
                    saleProduct.ProductBarcode = loopSaleProductSupport.ProductBarcode;
                    saleProduct.ProductName = loopSaleProductSupport.ProductName;
                    saleProduct.Quantity = loopSaleProductSupport.Quantity;
                    saleProduct.UnitPrice = loopSaleProductSupport.UnitPrice;
                    saleProduct.TotalCost = loopSaleProductSupport.TotalCost;

                    saleProducts.Add(saleProduct);
                }

                SaleService.SaveSaleDetails(sale.SaleID, saleProducts);
            
            frmSaleReceived ReceivedForm = new frmSaleReceived(sale, lblNetAmount.Text);

            NewVoucher();
            ReceivedForm.ShowDialog();
        }

        private void DeleteItem(string DeletedBarcode) //Function Key Ctrl + Del
        {
            var saleProductSupport = ZuluContext.Current.SaleProductSupports.FirstOrDefault(c => c.ProductBarcode == DeletedBarcode);

            if (saleProductSupport != null)
                ZuluContext.Current.SaleProductSupports.Remove(saleProductSupport);

            grdSaleProducts.DataSource = null;
            grdSaleProducts.DataSource = ZuluContext.Current.SaleProductSupports;
        }

        private void DeleteVoc() //Function Key Shift + Del
        {

        }

        private void SaleTotalRefresh() //Function Key F7
        {

        }

        private void frmSaleVoucher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
                SaleTotalRefresh();
            if (e.KeyCode == Keys.F9)
                PendingVoucher();
            if (e.KeyCode == Keys.F11)
                PrintVoucher();
            if (((Control.ModifierKeys & Keys.Shift) == Keys.Control) && (e.KeyCode == Keys.Delete))
                DeleteVoc();
            if (((Control.ModifierKeys & Keys.Control) == Keys.Control) && (e.KeyCode == Keys.Delete))
                DeleteItem(DelBarcode);
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            PrintVoucher();
        }

        private void frmSaleVoucher_Load(object sender, EventArgs e)
        {
            ReadOnly(true);

            lblSaleInfo.Text = "Total Sale Information of Counter " + ApplicationSetting.ClientID;
			NewVoucher();
        }

        private void AddSaleProducts(int quantity)
        {
            int Total = 0;
            grdSaleProducts.DataSource = null;

            SaleProductSupport saleProductSupport = new SaleProductSupport();

            saleProductSupport.ProductBarcode = Barcode;
            saleProductSupport.ProductName = txtProduct.Text;
            saleProductSupport.Quantity = quantity;
            saleProductSupport.UnitPrice = ZuluHelper.GetIntValue(spnUnitPrice.EditValue.ToString());

            var existingsaleProductSupport = ZuluContext.Current.SaleProductSupports.FirstOrDefault(c => c.ProductBarcode == Barcode);

            if (existingsaleProductSupport != null)
                ZuluContext.Current.SaleProductSupports.Remove(existingsaleProductSupport);

            ZuluContext.Current.SaleProductSupports.Add(saleProductSupport);

            if (ZuluContext.Current.SaleProductSupports != null && ZuluContext.Current.SaleProductSupports.Count != 0)
            {
                grdSaleProducts.DataSource = ZuluContext.Current.SaleProductSupports;

                foreach (var loopSaleProductSupport in ZuluContext.Current.SaleProductSupports)
                {
                    Total = Total + loopSaleProductSupport.TotalCost;
                }
                lblTotalAmount.Text = Total.ToString("#,##");
                lblNetAmount.Text = Total.ToString("#,##");
            }
        }

        private void spnQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && spnQty.Text.Length > 0)
            {
                if (spnQty.Text.Length > 4)
                {
                    string barcode = spnQty.Text;
                    barcode = barcode.Replace(",", "");

                    if (Barcode == barcode)
                    {
                        spnQty.EditValue = 1;
                        txtBarcode.Text = barcode;
                        BarcodeReceiver(barcode);
                    }
                    else
                    {
                        AddSaleProducts(Quantity);
                        BarcodeReceiver(barcode);
                    }
                    e.Handled = true;
                }
                else
                {
                    AddSaleProducts(int.Parse(spnQty.Text.ToString()));

                    CleanText();
                    txtBarcode.Focus();
                }
            }
        }

        private void CleanText()
        {
            txtBarcode.Text = string.Empty;
            txtProduct.Text = string.Empty;
            spnUnitPrice.EditValue = 0;
            spnQty.EditValue = 1;
            spnTotal.EditValue = 0;
        }

        private void BarcodeReceiver(string barcode)
        {
            SaleProductSupport saleProductSupport = new SaleProductSupport();
            Barcode = barcode;

            saleProductSupport = SaleService.GetBarcodeAndSale(barcode);

            if (saleProductSupport == null)
                MessageBox.Show("Your product is not valid.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtProduct.Text = saleProductSupport.ProductName;
            spnUnitPrice.EditValue = ApplicationSetting.Price;
            spnTotal.EditValue = saleProductSupport.TotalCost;
            spnQty.EditValue = saleProductSupport.Quantity;
            spnQty.Focus();
            spnQty.SelectionStart = 0;
            spnQty.SelectionLength = spnQty.Text.Length;
            Quantity = saleProductSupport.Quantity; 
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtBarcode.Text.Length > 0)
                BarcodeReceiver(txtBarcode.Text);
        }

        private void spnQty_EditValueChanged(object sender, EventArgs e)
        {
            spnTotal.EditValue = ZuluHelper.GetIntValue(spnQty.EditValue.ToString()) * ZuluHelper.GetIntValue(spnUnitPrice.EditValue.ToString());
        }

        private void ReadOnly(bool status)
        {
            if (status == true)
            {
                txtBarcode.Properties.ReadOnly = true;
                spnQty.Properties.ReadOnly = true;
            }
            else
            {
                txtBarcode.Properties.ReadOnly = false;
                spnQty.Properties.ReadOnly = false;
            }

        }

        private void grdSaleProductsView_RowClick(object sender, RowClickEventArgs e)
        {
            if (grdSaleProductsView.DataRowCount > 0)
            {
                var delRow = grdSaleProductsView.GetRow(grdSaleProductsView.FocusedRowHandle) as SaleProductSupport;

                DelBarcode = delRow.ProductBarcode;       

                txtBarcode.Focus();
            }
        }

        private void cmdDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteItem(DelBarcode);
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            SaleTotalRefresh();
        }
    }
}
