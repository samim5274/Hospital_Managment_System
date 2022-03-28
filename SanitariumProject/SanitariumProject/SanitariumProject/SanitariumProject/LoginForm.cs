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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ClearText();
            //this.ActiveControl = btnLogin;
        }

        private void ClearText()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter the username and passeord.",@"Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                using (var context = new SANITARIUMEntities())
                {
                    var q = from log in context.UserInfoes
                            where log.Username == txtUsername.Text &&
                                  log.Password == txtPassword.Text
                            select log;
                    if (q.SingleOrDefault() != null)
                    {
                        txtUsername.Text = txtPassword.Text = string.Empty;
                        var obj = new FastForm();
                        this.Hide();
                        obj.Closed += (s, args) => this.Close();
                        obj.Show();
                    }
                    else
                    {
                        MessageBox.Show("username and password is wrong.please try again", @"Message",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
