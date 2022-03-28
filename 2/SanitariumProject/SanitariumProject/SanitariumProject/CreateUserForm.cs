using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SanitariumProject
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill up the username and password!");
            }
            else
            {
                var dbobj = new SANITARIUMEntities();
                var tbobj = new UserInfo();

                tbobj.Username = txtUsername.Text.Trim();
                tbobj.Password = txtPassword.Text.Trim();

                dbobj.AddToUserInfoes(tbobj);
                dbobj.SaveChanges();
                MessageBox.Show("User Create Successfully.");
                ClearText();
            }
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            ClearText();
        }

        private void ClearText()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
