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
    public partial class DoctorDetailForm : Form
    {
        public DoctorDetailForm()
        {
            InitializeComponent();
        }

        private void DoctorDetailForm_Load(object sender, EventArgs e)
        {
            FillDorctor();
            FillGender();
            ClearText();
        }


        private void ClearText()
        {
            txtDoctorName.Text = string.Empty;
            txtDegree.Text= string.Empty;
            txtDesignation.Text = string.Empty;
            txtaddress.Text= string.Empty;
            txtPhone.Text= string.Empty;
            txtFee.Text= string.Empty;
            cbxGender.SelectedValue = string.Empty;

        }

        private void FillGender()
        {
            var obj = new Manager();
            var list = obj.GetAllGender();
            cbxGender.DisplayMember = "Gender";
            cbxGender.ValueMember = "Id";
            cbxGender.DataSource = list;
        }

        private void FillDorctor()
        {
            var obj = new Manager();
            var list = obj.GettAllDoctors();
            cbxDoctorName.DisplayMember = "Name";
            cbxDoctorName.ValueMember = "Id";
            cbxDoctorName.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDoctorName.Text == "" || txtFee.Text == "" || txtPhone.Text =="" || txtDegree.Text == "" )
            {
                MessageBox.Show("Some information is null.Please fill the informtion.Thank You!");
            }
            else
            {
                var objDb = new SANITARIUMEntities();
                var objTb = new DoctorInfo();

                objTb.Name = txtDoctorName.Text.Trim();
                objTb.Degree = txtDegree.Text.Trim();
                objTb.Designation = txtDesignation.Text.Trim();
                objTb.Address = txtaddress.Text.Trim();
                objTb.Phone = Convert.ToInt32(txtPhone.Text.Trim());
                objTb.Fee = Convert.ToInt32(txtFee.Text.Trim());
                objTb.GenderId = Convert.ToInt32(cbxGender.SelectedValue);

                objDb.AddToDoctorInfoes(objTb);
                objDb.SaveChanges();
                MessageBox.Show("Doctor info add successfully!");
                FillDorctor();
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
