using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService.Data;
using Zulu.BusinessService;
using PortablePointOfSale.Controls;

namespace PortablePointOfSale.Users
{
    public partial class frmUsers : BaseZuluFormControl
    {
        string UserID;

        public frmUsers()
        {
            InitializeComponent();
            //pnlUsers.Height = Screen.PrimaryScreen.WorkingArea.Height;
            pnlUsers.Width = 1024;
            int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            if (DeltaWidth > 0)
            {
                pnlUsers.Left = Convert.ToInt32(DeltaWidth / 2);
            }
            else
            {
                pnlUsers.Left = 0;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Length > 0)
            {
                if (txtFullName.Text.Length > 0)
                {
                    User user = new User();

					UserService.InsertUser(txtUserID.Text.ToString(), "password", txtFullName.Text.ToString());

                    grdUsers.DataSource = UserService.GetAllUsers();

                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Please, fill the full name up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFullName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please, fill the product name up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserID.Focus();
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            if (grdView.DataRowCount < 1)
            {
                txtUserID.Enabled = true;
                txtFullName.Enabled = true;
            }

            UserID = string.Empty;
            txtFullName.Text = string.Empty;
            txtUserID.Text = string.Empty;
            txtUserID.Tag = string.Empty;
            txtUserID.Enabled = true;

            txtUserID.Focus();
        }

		//private void grdView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
		//{
		//    if (grdView.DataRowCount > 0)
		//    {
		//        var urRow = grdView.GetRow(grdView.FocusedRowHandle) as User;

		//        UserID = urRow.UserID.ToString();
		//        txtUserID.Text = urRow.Username.ToString();
		//        txtUserID.Enabled = false;
		//        txtFullName.Text = urRow.Fullname.ToString();
		//    }
		//}

        private void cmdResetPassword_Click(object sender, EventArgs e)
        {
            //Users.frmResetPassword PasswordResetForm = new Users.frmPasswordReset();
            
            //PasswordResetForm.CurUserID = UserID;
            //PasswordResetForm.ShowDialog();
        }

		private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		private void frmUsers_Load_1(object sender, EventArgs e)
		{
			var AllUser = UserService.GetAllUsers();

			grdUsers.DataSource = AllUser;

			ClearForm();
		}
    }
}
