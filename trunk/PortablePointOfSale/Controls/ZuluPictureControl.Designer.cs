namespace PortablePointOfSale.Controls
{
	partial class ZuluPictureControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.picBox = new DevExpress.XtraEditors.PictureEdit();
			this.lblDescription = new System.Windows.Forms.Label();
			this.txtPicturePath = new DevExpress.XtraEditors.TextEdit();
			this.baseZuluButtonControl1 = new PortablePointOfSale.Controls.BaseZuluButtonControl();
			((System.ComponentModel.ISupportInitialize)(this.picBox.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPicturePath.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// picBox
			// 
			this.picBox.Location = new System.Drawing.Point(135, 48);
			this.picBox.Name = "picBox";
			this.picBox.Size = new System.Drawing.Size(102, 91);
			this.picBox.TabIndex = 63;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescription.Location = new System.Drawing.Point(9, 14);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(0, 15);
			this.lblDescription.TabIndex = 62;
			// 
			// txtPicturePath
			// 
			this.txtPicturePath.Location = new System.Drawing.Point(135, 11);
			this.txtPicturePath.Name = "txtPicturePath";
			this.txtPicturePath.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPicturePath.Properties.Appearance.Options.UseFont = true;
			this.txtPicturePath.Size = new System.Drawing.Size(240, 28);
			this.txtPicturePath.TabIndex = 61;
			//this.txtPicturePath.Click += new System.EventHandler(this.txtPicturePath_Click);
			// 
			// baseZuluButtonControl1
			// 
			this.baseZuluButtonControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.baseZuluButtonControl1.Appearance.Options.UseFont = true;
			this.baseZuluButtonControl1.buttonID = null;
			this.baseZuluButtonControl1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
			this.baseZuluButtonControl1.Location = new System.Drawing.Point(375, 11);
			this.baseZuluButtonControl1.Name = "baseZuluButtonControl1";
			this.baseZuluButtonControl1.Size = new System.Drawing.Size(30, 29);
			this.baseZuluButtonControl1.TabIndex = 64;
			this.baseZuluButtonControl1.Text = "...";
			// 
			// ZuluPictureControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.Controls.Add(this.baseZuluButtonControl1);
			this.Controls.Add(this.picBox);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.txtPicturePath);
			this.Name = "ZuluPictureControl";
			this.Size = new System.Drawing.Size(461, 155);
			((System.ComponentModel.ISupportInitialize)(this.picBox.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPicturePath.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private BaseZuluButtonControl baseZuluButtonControl1;
		private DevExpress.XtraEditors.PictureEdit picBox;
		private System.Windows.Forms.Label lblDescription;
		private DevExpress.XtraEditors.TextEdit txtPicturePath;
	}
}
