using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService;
using Microsoft.Reporting.WinForms;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Sales;

namespace ProtablePointOfSale.ReportForm
{
    public partial class frmPrint : Form
    {
        private Sale _sale;
        //private List<SaleProduct> _saleProducts;

        //public Sale sale
        //{
        //    get
        //    {
        //        return _sale;
        //    }
        //    set
        //    {
        //        _sale = value;
        //    }
        //}

        //public List<SaleProduct> saleProducts
        //{
        //    get
        //    {
        //        return _saleProducts;
        //    }
        //    set
        //    {
        //        _saleProducts = value;
        //    }
        //}


        //public frmPrint()
        //{
        //    //sale = PSale;
        //    //saleProducts = PSaleProducts;
        //     //public frmPrint(Sale PSale, List<SaleProduct> PSaleProducts)
            
        //    InitializeComponent();
        //}

        public frmPrint()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            //List<Sale> sales = new List<Sale>();
            //sales.Add(sale);
            //ReportDataSource rdsSaleProduct = new ReportDataSource("SaleProduct", saleProducts);

            //ReportParameter VoucherNumber = new ReportParameter("VoucherNumber", sale.VoucherNumber.ToString());
            //ReportParameter SellerID = new ReportParameter("SellerID", sale.SellerID.ToString());
            //ReportParameter CounterID = new ReportParameter("CounterID", sale.CounterNumber.ToString());
            //ReportParameter Total = new ReportParameter("Total", sale.SaleTotal.ToString());

            //rptViewer.RefreshReport();

            //rptViewer.Reset();
            //rptViewer.ProcessingMode = ProcessingMode.Local;
            //rptViewer.LocalReport.ReportPath = "Reports\\rptVoucher.rdlc";
            //rptViewer.LocalReport.DataSources.Clear();
            //rptViewer.LocalReport.SetParameters(new ReportParameter[] { VoucherNumber });
            //rptViewer.LocalReport.SetParameters(new ReportParameter[] { SellerID });
            //rptViewer.LocalReport.SetParameters(new ReportParameter[] { CounterID });
            //rptViewer.LocalReport.SetParameters(new ReportParameter[] { Total });
            //rptViewer.LocalReport.DataSources.Add(rdsSaleProduct);
            //rptViewer.LocalReport.Refresh();

            //rptViewer.RefreshReport();


            //this.rptViewer.RefreshReport();

            //ZuluContext.Current.SaleProductSupports = new List<SaleProductSupport>();
        }
    }
}
