namespace ProtablePointOfSale.ReportForm
{
    partial class frmPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrint));
            this.SaleProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.printForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SaleProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SaleProductBindingSource
            // 
            this.SaleProductBindingSource.DataSource = typeof(Zulu.BusinessService.Data.SaleProduct);
            // 
            // rptViewer
            // 
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SaleReport";
            reportDataSource1.Value = this.SaleProductBindingSource;
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewer.LocalReport.ReportEmbeddedResource = "ProtablePointOfSale.Report1.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(0, 0);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.Size = new System.Drawing.Size(809, 437);
            this.rptViewer.TabIndex = 0;
            // 
            // printForm
            // 
            this.printForm.DocumentName = "document";
            this.printForm.Form = this;
            this.printForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm.PrinterSettings")));
            this.printForm.PrintFileName = "Reports/rptVoucher.rdlc";
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 437);
            this.Controls.Add(this.rptViewer);
            this.Name = "frmPrint";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaleProductBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

		public Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private System.Windows.Forms.BindingSource SaleProductBindingSource;
        public Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm;



    }
}