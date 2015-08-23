using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PortablePointOfSale.Controls;
using Zulu.BusinessService;
using Zulu.BusinessService.Data;
//using Zulu.BusinessService.Logs;
using Zulu.BusinessService.Settings;
using PortablePointOfSale.Products;
using PortablePointOfSale.Sales;
using ProtablePointOfSale.ReportForm;
using Microsoft.Reporting.WinForms;
using Zulu.BusinessService.Sales;

namespace ProtablePointOfSale.Main
{
    public partial class frmMain : BaseZuluFormControl
    {
        public frmMain()
        {
            InitializeComponent();

            //pnlMain.Height = Screen.PrimaryScreen.WorkingArea.Height;
            pnlMain.Width = 1024;
            int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            if (DeltaWidth > 0)
            {
                pnlMain.Left = Convert.ToInt32(DeltaWidth / 2);
            }
            else
            {
                pnlMain.Left = 0;
            }
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin LoginForm = new frmLogin();

            if (LoginForm.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.TopMost = false;

                //string imageLocation = MediaService.GetMediaUrl(int.Parse(ZuluContext.Current.CurrentUser.PictureID.ToString()), 102);
                //Bitmap bitmap = new Bitmap(imageLocation);

                //picUser.Image = bitmap;
                lblCurrentUserName.Text = ZuluContext.Current.CurrentUser.Fullname;
                
                //ApplicationSetting AppSetting = new ApplicationSetting();
                //lblBrandID.Text = AppSetting.ComapanyName;
                //lblAddress1.Text = AppSetting.Address1;
                //lblAddress2.Text = AppSetting.Address2;
                //lblPhone.Text = AppSetting.Phone;
                //lblEmail.Text = AppSetting.Email;
            }
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh : mm : ss tt");
            lblDate.Text = DateTime.Now.ToString("D");
        }

        private void cmdProducts_Click(object sender, EventArgs e)
        {
            frmProduct ProductForm = new frmProduct();
            ProductForm.ShowDialog();
        }

        private void cmdSale_Click(object sender, EventArgs e)
        {
            frmSaleVoucher SaleVoucherForm = new frmSaleVoucher();
            SaleVoucherForm.ShowDialog();
        }

        private void cmdCashTramsactionReport_Click(object sender, EventArgs e)
        {
            if (cboCounter.Text == "Counter 1")
                CashTransaction(1);
            if (cboCounter.Text == "Counter 2")
                CashTransaction(2);
            if (cboCounter.Text == "Counter 3")
                CashTransaction(3);
            if (cboCounter.Text == "Counter 4")
                CashTransaction(4);
            if (cboCounter.Text == "All Counter")
                CashTransaction(0);
        }

        private void CashTransaction(int counterNo)
        {
            List<Sale> sales = new List<Sale>();
            decimal GiftVoucherTotal = 0;
            decimal CashTotal = 0;
            decimal Total = 0;
            int TotalQuantity = 0;

            sales = SaleService.GetSalesByCounterNumber(counterNo);

            foreach (var sale in sales)
            {
                GiftVoucherTotal += (decimal)sale.GiftVoucherAmount;
                CashTotal += (decimal)sale.CashAmount;
                Total += (decimal)sale.SaleTotal;
                TotalQuantity += (int)sale.SaleTotalQuantity;
            }
            

            frmReports ReportForm = new frmReports();
            ReportDataSource rdsSales = new ReportDataSource("Sales", sales);

			ReportParameter rpGiftVoucherTotal = new ReportParameter();
			if(GiftVoucherTotal > 0)
				rpGiftVoucherTotal = new ReportParameter("GiftVoucherTotal", GiftVoucherTotal.ToString("#,##"));
			else
				rpGiftVoucherTotal = new ReportParameter("GiftVoucherTotal", "0.00");

            ReportParameter rpCashTotal = new ReportParameter("CashTotal", CashTotal.ToString("#,##"));
            ReportParameter rpTotal = new ReportParameter("Total", Total.ToString("#,##"));
            ReportParameter rpTotalQuantity = new ReportParameter("TotalQuantity", TotalQuantity.ToString("#,##"));

            ReportForm.rptViewer.RefreshReport();

            ReportForm.rptViewer.Reset();
            ReportForm.rptViewer.ProcessingMode = ProcessingMode.Local;
            ReportForm.rptViewer.LocalReport.ReportPath = "Reports\\rptCashTransaction.rdlc";
            ReportForm.rptViewer.LocalReport.DataSources.Clear();
            ReportForm.rptViewer.LocalReport.DataSources.Add(rdsSales);
            ReportForm.rptViewer.LocalReport.SetParameters(new ReportParameter[] { rpGiftVoucherTotal });
            ReportForm.rptViewer.LocalReport.SetParameters(new ReportParameter[] { rpCashTotal });
            ReportForm.rptViewer.LocalReport.SetParameters(new ReportParameter[] { rpTotal });
            ReportForm.rptViewer.LocalReport.SetParameters(new ReportParameter[] { rpTotalQuantity });
            ReportForm.rptViewer.LocalReport.Refresh();

            ReportForm.rptViewer.RefreshReport();

            ReportForm.ShowDialog();

            this.Close();
        }

        private void cmdSaleProduct_Click(object sender, EventArgs e)
        {
            if (cboCounter.Text == "Counter 1")
                SaleProduct(1);
            if (cboCounter.Text == "Counter 2")
                SaleProduct(2);
            if (cboCounter.Text == "Counter 3")
                SaleProduct(3);
            if (cboCounter.Text == "Counter 4")
                SaleProduct(4);
            if (cboCounter.Text == "All Counter")
                SaleProduct(0);
        }
         

        private void SaleProduct(int counterNo)
        {
            List<SaleProductSupport> saleProductSupports = new List<SaleProductSupport>();
			int totalQuantity = 0;
			decimal totalCost = 0; 

            saleProductSupports = SaleService.GetSaleProductListSupportByCounter(counterNo);

			foreach (var saleProductSupport in saleProductSupports)
			{
				totalQuantity += saleProductSupport.Quantity;
				totalCost += saleProductSupport.TotalCost;
			}

            ReportParameter CounterID = new ReportParameter("CounterNo", counterNo.ToString());
			ReportParameter TotalQuantity = new ReportParameter("TotalQuantity", totalQuantity.ToString());
			ReportParameter TotalCost = new ReportParameter("TotalCost", totalCost.ToString());

            frmReports ReportForm = new frmReports();
            ReportDataSource rdsSales = new ReportDataSource("SaleProductSupport", saleProductSupports);

            ReportForm.rptViewer.RefreshReport();

            ReportForm.rptViewer.Reset();
            ReportForm.rptViewer.ProcessingMode = ProcessingMode.Local;
            ReportForm.rptViewer.LocalReport.ReportPath = "Reports\\rptSaleProductReport.rdlc";
            ReportForm.rptViewer.LocalReport.DataSources.Clear();
            ReportForm.rptViewer.LocalReport.SetParameters(new ReportParameter[] { CounterID });
            ReportForm.rptViewer.LocalReport.SetParameters(new ReportParameter[] { TotalQuantity });
			ReportForm.rptViewer.LocalReport.SetParameters(new ReportParameter[] { TotalCost });
            ReportForm.rptViewer.LocalReport.DataSources.Add(rdsSales);
            ReportForm.rptViewer.LocalReport.Refresh();

            ReportForm.rptViewer.RefreshReport();

            ReportForm.ShowDialog();

            this.Close();
        }
    }
}
