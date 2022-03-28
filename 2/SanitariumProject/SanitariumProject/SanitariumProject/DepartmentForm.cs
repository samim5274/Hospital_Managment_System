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
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDepName.Text == "")
                {
                    MessageBox.Show("Text box is empty");
                }
                else
                {
                    var objDb = new SANITARIUMEntities();
                    var objTB = new DepartmentInfo();

                    objTB.DepartmentName = txtDepName.Text.Trim();

                    objDb.AddToDepartmentInfoes(objTB);
                    objDb.SaveChanges();
                    MessageBox.Show("Saved succeed");
                    FillDepartment();
                    ClearTextBox();
                }
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            FillDepartment();
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            txtDepName.Text = string.Empty;
        }

        private void FillDepartment()
        {
            var obj = new Manager();
            var list = obj.GetAllDepartment();
            cbxDepName.DisplayMember = "DepartmentName";
            cbxDepName.ValueMember = "Id";
            cbxDepName.DataSource = list;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
