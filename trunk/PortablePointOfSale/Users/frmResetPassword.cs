using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PortablePointOfSale.Controls;

namespace ProtablePointOfSale.Users
{
    public partial class frmResetPassword : BaseZuluFormControl
    {

        public string CurUserID;

        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void cmdResetPassword_Click(object sender, EventArgs e)
        {
            if (CurUserID.Length > 0)
            {
                if (txtNewPassword.Text == txtreenterpass.Text)
                {
                    //UserService.ResetPassword(CurUserID, txtNewPassword.Text.ToString());

                    var user = UserService.GetUserByID(int.Parse(CurUserID));

                    MessageBox.Show("Successfull reset password of " + user.Fullname + ".", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Not same your password.", "Information");
                }
            }
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
        {
            txtNewPassword.Focus();
        }
    }
}
