using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using PortablePointOfSale.Controls;
using Zulu.BusinessService.Sales;
using Zulu.BusinessService.Data;
using ProtablePointOfSale.ReportForm;
using Microsoft.Reporting.WinForms;
using Zulu.BusinessService;
using System.Drawing.Printing;

namespace PortablePointOfSale.Sales
{
    public partial class frmSaleReceived : BaseZuluFormControl
    {
        private Sale _sale;
        private int _quantity;

        public Sale sale
        {
            get
            {
                return _sale;
            }
            set
            {
                _sale = value;
            }
        }

        public frmSaleReceived(Sale PSale, string TotalCost)
        {
            InitializeComponent();

            sale = PSale;

            lblTotalCost.Text = TotalCost;
            spnGiftVoucher.EditValue = 0;
            spnCash.EditValue = 0;
            lblChange.Text = TotalCost;
            lblTotalQuintity.Text = Quantity.ToString();
        }

        public int Quantity
        {
            get 
            {
                return int.Parse(sale.SaleTotalQuantity.ToString());
            }
        }
        		
        private void frmSaleReceived_Load(object sender, EventArgs e)
        {
            spnGiftVoucher.Focus();
            spnGiftVoucher.SelectionStart = 0;
            spnGiftVoucher.SelectionLength = spnGiftVoucher.Text.Length;
        }

        private void spnGiftVoucher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                decimal TotalCost = decimal.Parse(lblTotalCost.Text.ToString().Replace(",", ""));
                decimal GiftVoucher = spnGiftVoucher.Value;
                decimal expectedCash = TotalCost - GiftVoucher;
                decimal Change = 0;

                if (expectedCash < 0)
                {
                    MessageBox.Show("Customer has to spend " + expectedCash.ToString().Replace("-", "") + " to meet with the gift voucher!");

                    spnGiftVoucher.Focus();
                    spnGiftVoucher.SelectionStart = 0;
                    spnGiftVoucher.SelectionLength = spnCash.Text.Length;
                }
                else
                {
                    spnCash.EditValue = expectedCash;
                    if (Change > 0)
                    {
                        lblChange.Text = Change.ToString("#,##");
                    }
                    else
                    {
                        lblChange.Text = "0";
                    }

                    spnCash.Focus();
                    spnCash.SelectionStart = 0;
                    spnCash.SelectionLength = spnCash.Text.Length; 
                }                           
            }
        }

        private void spnCash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal TotalCost = decimal.Parse(lblTotalCost.Text.ToString().Replace(",", ""));
                decimal GiftVoucher = spnGiftVoucher.Value;
                decimal Cash = spnCash.Value;

                if ((GiftVoucher + Cash) >= TotalCost)
                {
                    decimal Change = TotalCost - (GiftVoucher + Cash);

                    if (Change > 0)
                    {
                        lblChange.Text = Change.ToString("#,##");
                    }
                    else
                    {
                        lblChange.Text = "0";
                    }

                    Print();
                }
                else
                {
                    MessageBox.Show("Please check your enter amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    spnCash.Focus();
                    spnCash.SelectionStart = 0;
                    spnCash.SelectionLength = spnCash.Text.Length;
                }
            }
        }

        private void Print()
        {
            SaleService.SaveGiftVoucherAmount(sale.SaleID, decimal.Parse(spnGiftVoucher.Text));

            frmPrint ReportForm = new frmPrint();
            
            //frmPrint ReportForm = new frmPrint(sale, sale.SaleProducts.ToList());

            ReportDataSource rdsSaleProduct = new ReportDataSource("SaleProduct", sale.SaleProducts.ToList());

            ReportParameter VoucherNumber = new ReportParameter("VoucherNumber", sale.VoucherNumber.ToString());
            ReportParameter SellerID = new ReportParameter("SellerID", sale.SellerID.ToString());
            ReportParameter CounterID = new ReportParameter("CounterID", sale.CounterNumber.ToString());
            ReportParameter Total = new ReportParameter("Total", sale.SaleTotal.ToString());

            ReportForm.rptViewer.RefreshReport();

            ReportForm.rptViewer.Reset();
            ReportForm.rptViewer.ProcessingMode = ProcessingMode.Local;
            ReportForm.rptViewer.LocalReport.ReportPath = "Reports\\rptVoucher.rdlc";
            ReportForm.rptViewer.LocalReport.DataSources.Clear();
            ReportForm.rptViewer.LocalReport.SetParameters(new ReportParameter[] { VoucherNumber });
            ReportForm.rptViewer.LocalReport.SetParameters(new ReportParameter[] { SellerID });
            ReportForm.rptViewer.LocalReport.SetParameters(new ReportParameter[] { CounterID });
            ReportForm.rptViewer.LocalReport.SetParameters(new ReportParameter[] { Total });
            ReportForm.rptViewer.LocalReport.DataSources.Add(rdsSaleProduct);

            ReportForm.rptViewer.LocalReport.Refresh();

            ReportForm.rptViewer.RefreshReport();

            ZuluContext.Current.SaleProductSupports = new List<SaleProductSupport>();

            Margins margins = new Margins(0,0,0,0);
            ReportForm.printForm.PrinterSettings.DefaultPageSettings.Margins = margins;

            ReportForm.ShowDialog();

            PrinterSettings printerSettings = new PrinterSettings();
            PaperSize pSize = new PaperSize("Voucher", 3, 10);
            printerSettings.MaximumPage = 1;
            DialogResult PResult = ReportForm.rptViewer.PrintDialog(printerSettings);

            if (PResult == DialogResult.OK)
                ReportForm.Close();
            
           
            //ReportForm.printForm.Print(ReportForm, Microsoft.VisualBasic.PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeClientAreaOnly);

            //ReportForm.Close();          
            //ReportForm.ShowDialog();

            this.Close();
        }

        private void spnCash_ValueChanged(object sender, EventArgs e)
        {
            if (spnGiftVoucher.Value >= 0 && spnCash.Value >= 0)
            {
                decimal TotalCost = decimal.Parse(lblTotalCost.Text.ToString().Replace(",", ""));
                decimal Cash = decimal.Parse(spnCash.EditValue.ToString().Replace(",", ""));

                decimal Change = TotalCost - (Cash + spnGiftVoucher.Value);

                lblChange.Text = Change.ToString("#,##");
            }
        }      
        
    
    }
}
