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
    public partial class MarketiongOfficerDetailForm : Form
    {
        public MarketiongOfficerDetailForm()
        {
            InitializeComponent();
        }

        private void MarketiongOfficerDetailForm_Load(object sender, EventArgs e)
        {
            FillGender();
            ClearText();
        }

        private void ClearText()
        {
            txtMarketionOfcerName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtArea.Text = string.Empty;
            cbxGender.Text = string.Empty;
        }

        private void FillGender()
        {
            var obj = new Manager();
            var list = obj.GetAllGender();
            cbxGender.DisplayMember = "Gender";
            cbxGender.ValueMember = "Id";
            cbxGender.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtArea.Text == "" || txtMarketionOfcerName.Text == "")
            {
                MessageBox.Show("Fill the information and try again.");
            }
            else
            {
                var objDb = new SANITARIUMEntities();
                var objTb = new MarketingInfo();

                objTb.Name = txtMarketionOfcerName.Text.Trim();
                objTb.Address = txtAddress.Text.Trim();
                objTb.Phone = Convert.ToInt32(txtPhone.Text.Trim());
                objTb.Area = txtArea.Text.Trim();
                objTb.GenderId = Convert.ToInt32(cbxGender.SelectedValue);

                objDb.AddToMarketingInfoes(objTb);
                objDb.SaveChanges();
                MessageBox.Show("Data has been save successfully.");
                ClearText();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
