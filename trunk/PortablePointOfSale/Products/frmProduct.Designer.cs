namespace PortablePointOfSale.Products
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.LinkLabel();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.lueBarcode = new DevExpress.XtraEditors.LookUpEdit();
            this.spnCurQty = new DevExpress.XtraEditors.SpinEdit();
            this.spnQty = new DevExpress.XtraEditors.SpinEdit();
            this.cmdAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProduct = new DevExpress.XtraEditors.TextEdit();
            this.grdProduct = new DevExpress.XtraGrid.GridControl();
            this.grdProductView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColProductUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColCreatedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemChkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCurQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 32);
            this.panel1.TabIndex = 10;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblHeader.Location = new System.Drawing.Point(654, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(109, 26);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Stock Editor";
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
            this.lblExit.Location = new System.Drawing.Point(1004, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(32, 18);
            this.lblExit.TabIndex = 1;
            this.lblExit.TabStop = true;
            this.lblExit.Text = "E&xit";
            this.lblExit.VisitedLinkColor = System.Drawing.Color.Orange;
            this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked_1);
            // 
            // pnlProduct
            // 
            this.pnlProduct.Controls.Add(this.txtBarcode);
            this.pnlProduct.Controls.Add(this.lueBarcode);
            this.pnlProduct.Controls.Add(this.spnCurQty);
            this.pnlProduct.Controls.Add(this.spnQty);
            this.pnlProduct.Controls.Add(this.cmdAdd);
            this.pnlProduct.Controls.Add(this.label2);
            this.pnlProduct.Controls.Add(this.label3);
            this.pnlProduct.Controls.Add(this.label1);
            this.pnlProduct.Controls.Add(this.label8);
            this.pnlProduct.Controls.Add(this.txtProduct);
            this.pnlProduct.Controls.Add(this.grdProduct);
            this.pnlProduct.Location = new System.Drawing.Point(0, 33);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(1025, 730);
            this.pnlProduct.TabIndex = 1;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(26, 54);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Properties.Appearance.Options.UseFont = true;
            this.txtBarcode.Properties.AutoHeight = false;
            this.txtBarcode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtBarcode.Size = new System.Drawing.Size(258, 28);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // lueBarcode
            // 
            this.lueBarcode.Location = new System.Drawing.Point(26, 54);
            this.lueBarcode.Name = "lueBarcode";
            this.lueBarcode.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.lueBarcode.Properties.Appearance.Options.UseFont = true;
            this.lueBarcode.Properties.AutoSearchColumnIndex = 1;
            this.lueBarcode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lueBarcode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBarcode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Barcode", "Barcode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Product Name")});
            this.lueBarcode.Properties.DisplayMember = "Barcode";
            this.lueBarcode.Properties.NullText = "";
            this.lueBarcode.Properties.ValueMember = "Name";
            this.lueBarcode.Size = new System.Drawing.Size(258, 28);
            this.lueBarcode.TabIndex = 0;
            this.lueBarcode.Visible = false;
            this.lueBarcode.EditValueChanged += new System.EventHandler(this.lueBarcode_EditValueChanged);
            this.lueBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lueBarcode_KeyDown);
            this.lueBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lueBarcode_KeyPress);
            this.lueBarcode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lueBarcode_PreviewKeyDown);
            // 
            // spnCurQty
            // 
            this.spnCurQty.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnCurQty.Location = new System.Drawing.Point(748, 54);
            this.spnCurQty.Name = "spnCurQty";
            this.spnCurQty.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnCurQty.Properties.Appearance.Options.UseFont = true;
            this.spnCurQty.Properties.AutoHeight = false;
            this.spnCurQty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.spnCurQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.spnCurQty.Properties.DisplayFormat.FormatString = "n0";
            this.spnCurQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnCurQty.Properties.EditFormat.FormatString = "n0";
            this.spnCurQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnCurQty.Properties.Mask.EditMask = "n0";
            this.spnCurQty.Properties.ReadOnly = true;
            this.spnCurQty.Size = new System.Drawing.Size(105, 28);
            this.spnCurQty.TabIndex = 1;
            this.spnCurQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spnQty_KeyDown);
            this.spnCurQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.spnQty_KeyUp);
            // 
            // spnQty
            // 
            this.spnQty.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnQty.Location = new System.Drawing.Point(854, 54);
            this.spnQty.Name = "spnQty";
            this.spnQty.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnQty.Properties.Appearance.Options.UseFont = true;
            this.spnQty.Properties.AutoHeight = false;
            this.spnQty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.spnQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.spnQty.Properties.DisplayFormat.FormatString = "n0";
            this.spnQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnQty.Properties.EditFormat.FormatString = "n0";
            this.spnQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spnQty.Properties.Mask.EditMask = "n0";
            this.spnQty.Size = new System.Drawing.Size(121, 28);
            this.spnQty.TabIndex = 1;
            this.spnQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spnQty_KeyDown);
            this.spnQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.spnQty_KeyUp);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdAdd.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.cmdAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Appearance.Options.UseBackColor = true;
            this.cmdAdd.Appearance.Options.UseBorderColor = true;
            this.cmdAdd.Appearance.Options.UseFont = true;
            this.cmdAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdAdd.Image = ((System.Drawing.Image)(resources.GetObject("cmdAdd.Image")));
            this.cmdAdd.Location = new System.Drawing.Point(978, 53);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(35, 30);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.TabStop = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Barcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(851, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Add Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(748, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Qty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(282, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "Product";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(285, 54);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.Properties.Appearance.Options.UseFont = true;
            this.txtProduct.Properties.AutoHeight = false;
            this.txtProduct.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtProduct.Properties.ReadOnly = true;
            this.txtProduct.Size = new System.Drawing.Size(462, 28);
            this.txtProduct.TabIndex = 10;
            // 
            // grdProduct
            // 
            this.grdProduct.Location = new System.Drawing.Point(12, 101);
            this.grdProduct.MainView = this.grdProductView;
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemChkIsActive,
            this.repositoryItemSpinEdit1});
            this.grdProduct.Size = new System.Drawing.Size(1001, 615);
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
            this.gridColProductUnit,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
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
            this.grdProductView.Click += new System.EventHandler(this.grdProductView_Click);
            // 
            // grdColProductID
            // 
            this.grdColProductID.Caption = "ProductID";
            this.grdColProductID.FieldName = "ProductID";
            this.grdColProductID.Name = "grdColProductID";
            // 
            // gridColName
            // 
            this.gridColName.Caption = "Barcode";
            this.gridColName.FieldName = "Barcode";
            this.gridColName.Name = "gridColName";
            this.gridColName.OptionsColumn.AllowEdit = false;
            this.gridColName.OptionsColumn.AllowFocus = false;
            this.gridColName.Visible = true;
            this.gridColName.VisibleIndex = 0;
            this.gridColName.Width = 180;
            // 
            // gridColProductUnit
            // 
            this.gridColProductUnit.Caption = "Product Name";
            this.gridColProductUnit.FieldName = "ProductName";
            this.gridColProductUnit.Name = "gridColProductUnit";
            this.gridColProductUnit.OptionsColumn.AllowEdit = false;
            this.gridColProductUnit.OptionsColumn.AllowFocus = false;
            this.gridColProductUnit.Visible = true;
            this.gridColProductUnit.VisibleIndex = 1;
            this.gridColProductUnit.Width = 422;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Qty";
            this.gridColumn1.ColumnEdit = this.repositoryItemSpinEdit1;
            this.gridColumn1.FieldName = "Quantity";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 97;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.repositoryItemSpinEdit1.DisplayFormat.FormatString = "n0";
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditFormat.FormatString = "n0";
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.Mask.EditMask = "n0";
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Added Qty";
            this.gridColumn2.ColumnEdit = this.repositoryItemSpinEdit1;
            this.gridColumn2.FieldName = "AddedQuantity";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 138;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Total Qty";
            this.gridColumn4.ColumnEdit = this.repositoryItemSpinEdit1;
            this.gridColumn4.FieldName = "TotalQuantity";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 149;
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
            // frmProduct
            // 
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CancelButton = this.lblExit;
            this.ClientSize = new System.Drawing.Size(1044, 788);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.Click += new System.EventHandler(this.frmProduct_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCurQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lblExit;
        private System.Windows.Forms.Panel pnlProduct;
        private DevExpress.XtraGrid.GridControl grdProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView grdProductView;
        private DevExpress.XtraGrid.Columns.GridColumn grdColProductID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemChkIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCreatedOn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColName;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtProduct;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColProductUnit;
        private DevExpress.XtraEditors.SpinEdit spnQty;
        private DevExpress.XtraEditors.SimpleButton cmdAdd;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LookUpEdit lueBarcode;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.TextEdit txtBarcode;
        private DevExpress.XtraEditors.SpinEdit spnCurQty;
        private System.Windows.Forms.Label label3;
    }
}
