using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Zulu.BusinessService.Util;
using PortablePointOfSale.Controls;
using Zulu.BusinessService.Sales;

namespace ProtablePointOfSale.ReportForm
{
    public partial class frmCryReport : BaseZuluFormControl
    {
        public frmCryReport()
        {
            InitializeComponent();

            //BindReport();
        }

        private void frmCryReport_Load(object sender, EventArgs e)
        {
            BindReport();
        }

        private void BindReport()
        {
            ReportDocument report = new ReportDocument();
            report.Load(ZuluHelper.ApplicationPath + "Reports\\CrystalReport1.rpt");

            List<SaleProductSupport> saleProductSupports = new List<SaleProductSupport>();
            saleProductSupports = SaleService.GetSaleProductListSupportByCounter(0);

            report.SetDataSource(saleProductSupports);
            crystalReportViewer1.ReportSource = report;

        }
    }
}
