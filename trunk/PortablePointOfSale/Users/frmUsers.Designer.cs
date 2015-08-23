using PortablePointOfSale.Controls;
namespace PortablePointOfSale.Users
{
    partial class frmUsers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lblExit = new System.Windows.Forms.LinkLabel();
			this.pnlUsers = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cmdResetPassword = new DevExpress.XtraEditors.SimpleButton();
			this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
			this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFullName = new DevExpress.XtraEditors.TextEdit();
			this.txtUserID = new DevExpress.XtraEditors.TextEdit();
			this.grdUsers = new DevExpress.XtraGrid.GridControl();
			this.grdView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColUserID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColUserName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColFullName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemChkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.pnlUsers.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(1028, 32);
			this.panel1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.label1.Location = new System.Drawing.Point(469, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 26);
			this.label1.TabIndex = 8;
			this.label1.Text = "User Setup";
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
			this.lblExit.Location = new System.Drawing.Point(988, 9);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(32, 18);
			this.lblExit.TabIndex = 1;
			this.lblExit.TabStop = true;
			this.lblExit.Text = "E&xit";
			this.lblExit.VisitedLinkColor = System.Drawing.Color.Orange;
			this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
			// 
			// pnlUsers
			// 
			this.pnlUsers.Controls.Add(this.panel2);
			this.pnlUsers.Controls.Add(this.label3);
			this.pnlUsers.Controls.Add(this.label2);
			this.pnlUsers.Controls.Add(this.txtFullName);
			this.pnlUsers.Controls.Add(this.txtUserID);
			this.pnlUsers.Controls.Add(this.grdUsers);
			this.pnlUsers.Location = new System.Drawing.Point(1, 33);
			this.pnlUsers.Name = "pnlUsers";
			this.pnlUsers.Size = new System.Drawing.Size(1024, 729);
			this.pnlUsers.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cmdResetPassword);
			this.panel2.Controls.Add(this.cmdNew);
			this.panel2.Controls.Add(this.cmdSave);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 684);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1024, 45);
			this.panel2.TabIndex = 28;
			// 
			// cmdResetPassword
			// 
			this.cmdResetPassword.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdResetPassword.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.cmdResetPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdResetPassword.Appearance.Options.UseBackColor = true;
			this.cmdResetPassword.Appearance.Options.UseBorderColor = true;
			this.cmdResetPassword.Appearance.Options.UseFont = true;
			this.cmdResetPassword.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.cmdResetPassword.Image = ((System.Drawing.Image)(resources.GetObject("cmdResetPassword.Image")));
			this.cmdResetPassword.Location = new System.Drawing.Point(11, 5);
			this.cmdResetPassword.Name = "cmdResetPassword";
			this.cmdResetPassword.Size = new System.Drawing.Size(164, 35);
			this.cmdResetPassword.TabIndex = 3;
			this.cmdResetPassword.Text = "Reset Password";
			this.cmdResetPassword.Click += new System.EventHandler(this.cmdResetPassword_Click);
			// 
			// cmdNew
			// 
			this.cmdNew.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdNew.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.cmdNew.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdNew.Appearance.Options.UseBackColor = true;
			this.cmdNew.Appearance.Options.UseBorderColor = true;
			this.cmdNew.Appearance.Options.UseFont = true;
			this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.cmdNew.Image = ((System.Drawing.Image)(resources.GetObject("cmdNew.Image")));
			this.cmdNew.Location = new System.Drawing.Point(786, 5);
			this.cmdNew.Name = "cmdNew";
			this.cmdNew.Size = new System.Drawing.Size(111, 35);
			this.cmdNew.TabIndex = 0;
			this.cmdNew.Text = "New";
			this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
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
			this.cmdSave.Location = new System.Drawing.Point(903, 5);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(111, 35);
			this.cmdSave.TabIndex = 0;
			this.cmdSave.Text = "Save";
			this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 21);
			this.label3.TabIndex = 26;
			this.label3.Text = "Full Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 21);
			this.label2.TabIndex = 25;
			this.label2.Text = "Login Name";
			// 
			// txtFullName
			// 
			this.txtFullName.Location = new System.Drawing.Point(133, 89);
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFullName.Properties.Appearance.Options.UseFont = true;
			this.txtFullName.Size = new System.Drawing.Size(250, 28);
			this.txtFullName.TabIndex = 2;
			// 
			// txtUserID
			// 
			this.txtUserID.Location = new System.Drawing.Point(133, 44);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserID.Properties.Appearance.Options.UseFont = true;
			this.txtUserID.Size = new System.Drawing.Size(250, 28);
			this.txtUserID.TabIndex = 1;
			// 
			// grdUsers
			// 
			this.grdUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.grdUsers.Location = new System.Drawing.Point(11, 156);
			this.grdUsers.MainView = this.grdView;
			this.grdUsers.Name = "grdUsers";
			this.grdUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemChkIsActive});
			this.grdUsers.Size = new System.Drawing.Size(1003, 516);
			this.grdUsers.TabIndex = 21;
			this.grdUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdView});
			// 
			// grdView
			// 
			this.grdView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.grdView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
			this.grdView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grdView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Silver;
			this.grdView.Appearance.HeaderPanel.Options.UseBackColor = true;
			this.grdView.Appearance.HeaderPanel.Options.UseBorderColor = true;
			this.grdView.Appearance.HeaderPanel.Options.UseFont = true;
			this.grdView.Appearance.HeaderPanel.Options.UseForeColor = true;
			this.grdView.Appearance.VertLine.BorderColor = System.Drawing.Color.Silver;
			this.grdView.Appearance.VertLine.Options.UseBorderColor = true;
			this.grdView.BestFitMaxRowCount = 6;
			this.grdView.ColumnPanelRowHeight = 35;
			this.grdView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColUserID,
            this.gridColUserName,
            this.gridColFullName,
            this.gridColIsActive});
			this.grdView.FixedLineWidth = 1;
			this.grdView.GridControl = this.grdUsers;
			this.grdView.Name = "grdView";
			this.grdView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.grdView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.grdView.OptionsBehavior.AutoPopulateColumns = false;
			this.grdView.OptionsBehavior.AutoSelectAllInEditor = false;
			this.grdView.OptionsBehavior.AutoUpdateTotalSummary = false;
			this.grdView.OptionsBehavior.Editable = false;
			this.grdView.OptionsCustomization.AllowColumnMoving = false;
			this.grdView.OptionsCustomization.AllowColumnResizing = false;
			this.grdView.OptionsCustomization.AllowGroup = false;
			this.grdView.OptionsCustomization.AllowQuickHideColumns = false;
			this.grdView.OptionsDetail.EnableMasterViewMode = false;
			this.grdView.OptionsMenu.EnableColumnMenu = false;
			this.grdView.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.grdView.OptionsView.EnableAppearanceEvenRow = true;
			this.grdView.OptionsView.ShowGroupPanel = false;
			this.grdView.PaintStyleName = "UltraFlat";
			this.grdView.RowHeight = 28;
			// 
			// gridColUserID
			// 
			this.gridColUserID.Caption = "UserID";
			this.gridColUserID.FieldName = "User ID";
			this.gridColUserID.Name = "gridColUserID";
			// 
			// gridColUserName
			// 
			this.gridColUserName.Caption = "Login Name";
			this.gridColUserName.FieldName = "Username";
			this.gridColUserName.Name = "gridColUserName";
			this.gridColUserName.OptionsColumn.AllowEdit = false;
			this.gridColUserName.OptionsColumn.AllowFocus = false;
			this.gridColUserName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
			this.gridColUserName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColUserName.OptionsColumn.AllowMove = false;
			this.gridColUserName.OptionsColumn.AllowShowHide = false;
			this.gridColUserName.OptionsColumn.AllowSize = false;
			this.gridColUserName.OptionsColumn.ShowInCustomizationForm = false;
			this.gridColUserName.OptionsColumn.ShowInExpressionEditor = false;
			this.gridColUserName.OptionsFilter.AllowAutoFilter = false;
			this.gridColUserName.OptionsFilter.AllowFilter = false;
			this.gridColUserName.Visible = true;
			this.gridColUserName.VisibleIndex = 0;
			this.gridColUserName.Width = 161;
			// 
			// gridColFullName
			// 
			this.gridColFullName.Caption = "Full Name";
			this.gridColFullName.FieldName = "Full Name";
			this.gridColFullName.Name = "gridColFullName";
			this.gridColFullName.OptionsColumn.AllowEdit = false;
			this.gridColFullName.OptionsColumn.AllowFocus = false;
			this.gridColFullName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
			this.gridColFullName.OptionsColumn.AllowIncrementalSearch = false;
			this.gridColFullName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColFullName.OptionsColumn.AllowMove = false;
			this.gridColFullName.OptionsColumn.AllowShowHide = false;
			this.gridColFullName.OptionsColumn.AllowSize = false;
			this.gridColFullName.OptionsFilter.AllowAutoFilter = false;
			this.gridColFullName.OptionsFilter.AllowFilter = false;
			this.gridColFullName.Visible = true;
			this.gridColFullName.VisibleIndex = 1;
			this.gridColFullName.Width = 300;
			// 
			// gridColIsActive
			// 
			this.gridColIsActive.Caption = "Is Active";
			this.gridColIsActive.ColumnEdit = this.repositoryItemChkIsActive;
			this.gridColIsActive.FieldName = "Active";
			this.gridColIsActive.Name = "gridColIsActive";
			this.gridColIsActive.OptionsColumn.AllowEdit = false;
			this.gridColIsActive.OptionsColumn.AllowMove = false;
			this.gridColIsActive.Visible = true;
			this.gridColIsActive.VisibleIndex = 2;
			this.gridColIsActive.Width = 125;
			// 
			// repositoryItemChkIsActive
			// 
			this.repositoryItemChkIsActive.AutoHeight = false;
			this.repositoryItemChkIsActive.Name = "repositoryItemChkIsActive";
			// 
			// frmUsers
			// 
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.ClientSize = new System.Drawing.Size(1028, 768);
			this.Controls.Add(this.pnlUsers);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmUsers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmUsers_Load_1);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.pnlUsers.ResumeLayout(false);
			this.pnlUsers.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lblExit;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl grdUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView grdView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColUserName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColFullName;
        private DevExpress.XtraEditors.TextEdit txtUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton cmdResetPassword;
        private DevExpress.XtraEditors.SimpleButton cmdSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColUserID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColIsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemChkIsActive;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
    }
}
