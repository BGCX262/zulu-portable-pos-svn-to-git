namespace PortablePointOfSale.Sales
{
    partial class frmSaleList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.LinkLabel();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dateTo = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFrom = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVoucherNo = new DevExpress.XtraEditors.TextEdit();
            this.grdProduct = new DevExpress.XtraGrid.GridControl();
            this.grdProductView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColVoucherNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColCreatedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemChkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdDelete = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new PortablePointOfSale.Controls.BaseZuluButtonControl();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 32);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(654, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sale List";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.ActiveLinkColor = System.Drawing.Color.Crimson;
            this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Orange;
            this.lblExit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblExit.LinkColor = System.Drawing.Color.Orange;
            this.lblExit.Location = new System.Drawing.Point(1344, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(32, 18);
            this.lblExit.TabIndex = 1;
            this.lblExit.TabStop = true;
            this.lblExit.Text = "E&xit";
            this.lblExit.VisitedLinkColor = System.Drawing.Color.Orange;
            //this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
            // 
            // pnlProduct
            // 
            this.pnlProduct.Controls.Add(this.simpleButton2);
            this.pnlProduct.Controls.Add(this.dateTo);
            this.pnlProduct.Controls.Add(this.label3);
            this.pnlProduct.Controls.Add(this.dateFrom);
            this.pnlProduct.Controls.Add(this.label2);
            this.pnlProduct.Controls.Add(this.label8);
            this.pnlProduct.Controls.Add(this.txtVoucherNo);
            this.pnlProduct.Controls.Add(this.grdProduct);
            this.pnlProduct.Controls.Add(this.panel3);
            this.pnlProduct.Location = new System.Drawing.Point(181, 33);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(1024, 729);
            this.pnlProduct.TabIndex = 14;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(823, 37);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(88, 70);
            this.simpleButton2.TabIndex = 54;
            this.simpleButton2.TabStop = false;
            this.simpleButton2.Text = "Search";
            // 
            // dateTo
            // 
            this.dateTo.EditValue = null;
            this.dateTo.Location = new System.Drawing.Point(564, 79);
            this.dateTo.Name = "dateTo";
            this.dateTo.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.dateTo.Properties.Appearance.Options.UseFont = true;
            this.dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateTo.Size = new System.Drawing.Size(244, 28);
            this.dateTo.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "To";
            // 
            // dateFrom
            // 
            this.dateFrom.EditValue = null;
            this.dateFrom.Location = new System.Drawing.Point(564, 36);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.dateFrom.Properties.Appearance.Options.UseFont = true;
            this.dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateFrom.Size = new System.Drawing.Size(244, 28);
            this.dateFrom.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "Voucher No.";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(156, 55);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucherNo.Properties.Appearance.Options.UseFont = true;
            this.txtVoucherNo.Size = new System.Drawing.Size(277, 28);
            this.txtVoucherNo.TabIndex = 47;
            // 
            // grdProduct
            // 
            this.grdProduct.Location = new System.Drawing.Point(12, 137);
            this.grdProduct.MainView = this.grdProductView;
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemChkIsActive});
            this.grdProduct.Size = new System.Drawing.Size(1001, 534);
            this.grdProduct.TabIndex = 6;
            this.grdProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdProductView});
            // 
            // grdProductView
            // 
            this.grdProductView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.grdProductView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.grdProductView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdProductView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.grdProductView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdProductView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grdProductView.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdProductView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grdProductView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColProductID,
            this.gridColName,
            this.gridColVoucherNo,
            this.gridColAmount,
            this.gridColDiscount,
            this.gridColTotalAmount,
            this.gridColCreatedOn});
            this.grdProductView.GridControl = this.grdProduct;
            this.grdProductView.Name = "grdProductView";
            this.grdProductView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdProductView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdProductView.OptionsCustomization.AllowColumnMoving = false;
            this.grdProductView.OptionsCustomization.AllowColumnResizing = false;
            this.grdProductView.OptionsView.EnableAppearanceEvenRow = true;
            this.grdProductView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdProductView.OptionsView.ShowGroupPanel = false;
            this.grdProductView.PaintStyleName = "UltraFlat";
            this.grdProductView.RowHeight = 28;
            this.grdProductView.ViewCaptionHeight = 38;
            // 
            // grdColProductID
            // 
            this.grdColProductID.Caption = "ProductID";
            this.grdColProductID.FieldName = "ProductID";
            this.grdColProductID.Name = "grdColProductID";
            // 
            // gridColName
            // 
            this.gridColName.Caption = "Date";
            this.gridColName.FieldName = "Name";
            this.gridColName.Name = "gridColName";
            this.gridColName.Visible = true;
            this.gridColName.VisibleIndex = 0;
            this.gridColName.Width = 167;
            // 
            // gridColVoucherNo
            // 
            this.gridColVoucherNo.Caption = "Voucher Number";
            this.gridColVoucherNo.Name = "gridColVoucherNo";
            this.gridColVoucherNo.Visible = true;
            this.gridColVoucherNo.VisibleIndex = 1;
            this.gridColVoucherNo.Width = 273;
            // 
            // gridColAmount
            // 
            this.gridColAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColAmount.Caption = "Amount";
            this.gridColAmount.Name = "gridColAmount";
            this.gridColAmount.Visible = true;
            this.gridColAmount.VisibleIndex = 2;
            this.gridColAmount.Width = 150;
            // 
            // gridColDiscount
            // 
            this.gridColDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColDiscount.Caption = "Discount";
            this.gridColDiscount.Name = "gridColDiscount";
            this.gridColDiscount.Visible = true;
            this.gridColDiscount.VisibleIndex = 3;
            this.gridColDiscount.Width = 166;
            // 
            // gridColTotalAmount
            // 
            this.gridColTotalAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColTotalAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColTotalAmount.Caption = "Total Amount";
            this.gridColTotalAmount.Name = "gridColTotalAmount";
            this.gridColTotalAmount.Visible = true;
            this.gridColTotalAmount.VisibleIndex = 4;
            this.gridColTotalAmount.Width = 230;
            // 
            // gridColCreatedOn
            // 
            this.gridColCreatedOn.Caption = "CreatedOn";
            this.gridColCreatedOn.FieldName = "CreatedOn";
            this.gridColCreatedOn.Name = "gridColCreatedOn";
            // 
            // repositoryItemChkIsActive
            // 
            this.repositoryItemChkIsActive.AutoHeight = false;
            this.repositoryItemChkIsActive.Name = "repositoryItemChkIsActive";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdDelete);
            this.panel3.Controls.Add(this.cmdNew);
            this.panel3.Controls.Add(this.cmdSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 684);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 45);
            this.panel3.TabIndex = 4;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdDelete.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.cmdDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Appearance.ForeColor = System.Drawing.Color.Red;
            this.cmdDelete.Appearance.Options.UseBackColor = true;
            this.cmdDelete.Appearance.Options.UseBorderColor = true;
            this.cmdDelete.Appearance.Options.UseFont = true;
            this.cmdDelete.Appearance.Options.UseForeColor = true;
            this.cmdDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmdDelete.Image")));
            this.cmdDelete.Location = new System.Drawing.Point(903, 5);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(111, 35);
            this.cmdDelete.TabIndex = 9;
            this.cmdDelete.Text = "Return";
            // 
            // cmdNew
            // 
            this.cmdNew.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdNew.Appearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Appearance.Options.UseBackColor = true;
            this.cmdNew.Appearance.Options.UseBorderColor = true;
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.buttonID = null;
            this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdNew.Image = ((System.Drawing.Image)(resources.GetObject("cmdNew.Image")));
            this.cmdNew.Location = new System.Drawing.Point(669, 5);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(111, 35);
            this.cmdNew.TabIndex = 7;
            this.cmdNew.TabStop = false;
            this.cmdNew.Text = "New (F9)";
            // 
            // cmdSave
            // 
            this.cmdSave.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdSave.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.cmdSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Appearance.Options.UseBackColor = true;
            this.cmdSave.Appearance.Options.UseBorderColor = true;
            this.cmdSave.Appearance.Options.UseFont = true;
            this.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
            this.cmdSave.Location = new System.Drawing.Point(786, 5);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(111, 35);
            this.cmdSave.TabIndex = 8;
            this.cmdSave.TabStop = false;
            this.cmdSave.Text = "View (F8)";
            // 
            // frmSaleList
            // 
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSaleList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lblExit;
        private System.Windows.Forms.Panel pnlProduct;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.DateEdit dateTo;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtVoucherNo;
        private DevExpress.XtraGrid.GridControl grdProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView grdProductView;
        private DevExpress.XtraGrid.Columns.GridColumn grdColProductID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColVoucherNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColAmount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCreatedOn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemChkIsActive;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton cmdDelete;
        private Controls.BaseZuluButtonControl cmdNew;
        private DevExpress.XtraEditors.SimpleButton cmdSave;
    }
}
