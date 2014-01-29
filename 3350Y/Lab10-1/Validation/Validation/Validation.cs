using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Validation
{
    public partial class Validation : Form
    {
        public Validation()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }


        private void Validation_Load(object sender, System.EventArgs e)
        {
            //username exists
            string userName = tbUserName.Text;
            if (userName.Length > 0)
                errorProvider1.SetError(tbUserName, "");
            else
                errorProvider1.SetError(tbUserName, "The username is invalid");

            //pasword is long
            if (tbNewPassword.Text.Length >= 6)
                errorProvider2.SetError(tbNewPassword, "");
            else
                errorProvider2.SetError(tbNewPassword, "Your password must be 6 characters or longer");

            //pasword is the same
            if (tbNewPassword.Text == tbConfirmPassword.Text)
                errorProvider3.SetError(tbConfirmPassword, "");
            else
                errorProvider3.SetError(tbConfirmPassword, "Passwords must match");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(tbUserName).Length > 0)
            {
                MessageBox.Show("Username is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

                
            }
            else if (errorProvider2.GetError(tbNewPassword).Length > 0)
            {
                MessageBox.Show("Your password must be 6 characters or longer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (errorProvider3.GetError(tbConfirmPassword).Length > 0)
            {
                MessageBox.Show("Passwords must match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Success", "Valid", MessageBoxButtons.OK, MessageBoxIcon.None);
                Close();
            }
        }
    }
}