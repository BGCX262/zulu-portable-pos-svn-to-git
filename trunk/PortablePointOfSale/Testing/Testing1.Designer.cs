namespace PortablePointOfSale.Testing
{
	partial class Testing1
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
			this.zpcTesting = new PortablePointOfSale.Controls.ZuluPictureControl();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// zpcTesting
			// 
			this.zpcTesting.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.zpcTesting.Location = new System.Drawing.Point(17, 13);
			this.zpcTesting.Name = "zpcTesting";
			this.zpcTesting.Size = new System.Drawing.Size(461, 155);
			this.zpcTesting.TabIndex = 0;
			this.zpcTesting.Text = "Test Picture";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(428, 280);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Testing1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 374);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.zpcTesting);
			this.Name = "Testing1";
			this.Text = "Testing1";
			this.Load += new System.EventHandler(this.Testing1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.ZuluPictureControl zpcTesting;
		private System.Windows.Forms.Button button1;


	}
}