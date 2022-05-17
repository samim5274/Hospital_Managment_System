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
    public partial class ReferDetailForm : Form
    {
        public ReferDetailForm()
        {
            InitializeComponent();
        }

        private void ReferDetailForm_Load(object sender, EventArgs e)
        {
            FillGender();
            FillMarketingOfficer();
        }

        private void FillMarketingOfficer()
        {
            var obj = new Manager();
            var list = obj.GetAllMarketiongOfficer();
            cbxMarOfficer.DisplayMember = "Name";
            cbxMarOfficer.ValueMember = "Id";
            cbxMarOfficer.DataSource = list;
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
            if (txtReferName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Some inforamtion are messing. Please fill the all inforamtion and try again.");
            }
            else
            {
                var objDb = new SANITARIUMEntities();
                var objTb = new ReferInfo();

                objTb.Name = txtReferName.Text.Trim();
                objTb.Address = txtAddress.Text.Trim();
                objTb.Phone = Convert.ToInt32(txtPhone.Text.Trim());
                objTb.GenderId = Convert.ToInt32(cbxGender.SelectedValue);
                objTb.MarketingOfficerId = Convert.ToInt32(cbxMarOfficer.SelectedValue);

                objDb.AddToReferInfoes(objTb);
                objDb.SaveChanges();
                MessageBox.Show("Refer Inforamtion save successfully.");
            }
        }
    }
}
