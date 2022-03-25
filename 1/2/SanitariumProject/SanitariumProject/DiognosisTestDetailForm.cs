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
    public partial class DiognosisTestDetailForm : Form
    {
        public DiognosisTestDetailForm()
        {
            InitializeComponent();
        }

        private void DiognosisTestDetailForm_Load(object sender, EventArgs e)
        {
            FillDepartment();
            FillCategory();
            FillSubcategory();
            FillGroup();
            FillSpecimen();
            ClearText();
        }


        private void ClearText()
        {
            txtTestName.Text = string.Empty;
            txtRoom.Text = string.Empty;
            txtCost.Text = string.Empty;
            cbxSubCatName.SelectedValue = string.Empty;
            cbxSpeciName.SelectedValue = string.Empty;
            cbxGrpName.SelectedValue = string.Empty;
            cbxDepName.SelectedValue = string.Empty;
            cbxCatName.SelectedValue = string.Empty;
        }

        private void FillDepartment()
        {
            var obj = new Manager();
            var list = obj.GetAllDepartment();
            cbxDepName.DisplayMember = "DepartmentName";
            cbxDepName.ValueMember = "Id";
            cbxDepName.DataSource = list;
        }

        private void FillCategory()
        {
            var obj = new Manager();
            var list = obj.GetAllCategory();
            cbxCatName.DisplayMember = "CategoryName";
            cbxCatName.ValueMember = "Id";
            cbxCatName.DataSource = list;
        }

        private void FillSubcategory()
        {
            var obj = new Manager();
            var list = obj.GettAllCategory();
            cbxSubCatName.DisplayMember = "CategoryName";
            cbxSubCatName.ValueMember = "Id";
            cbxSubCatName.DataSource = list;
        }

        private void FillGroup()
        {
            var obj = new Manager();
            var list = obj.GetAllGroupt();
            cbxGrpName.DisplayMember = "GroupName";
            cbxGrpName.ValueMember = "Id";
            cbxGrpName.DataSource = list;
        }

        private void FillSpecimen()
        {
            var obj = new Manager();
            var list = obj.GetAllSpecimenName();
            cbxSpeciName.DisplayMember = "SpecimenName";
            cbxSpeciName.ValueMember = "Id";
            cbxSpeciName.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTestName.Text == "" && txtCost.Text == "" && txtRoom.Text == "")
            {
                MessageBox.Show("Some value is messing.please chick the all iteam and then save.Thank you.");
            }
            else
            {
                var dbobj = new SANITARIUMEntities();
                var tbobj = new DignosticTestDetail();

                tbobj.TestName = txtTestName.Text.Trim();
                tbobj.DepartmentId = Convert.ToInt32(cbxDepName.SelectedValue);
                tbobj.CategoryId = Convert.ToInt32(cbxCatName.SelectedValue);
                tbobj.SubCategoryId = Convert.ToInt32(cbxSubCatName.SelectedValue);
                tbobj.GroupId = Convert.ToInt32(cbxGrpName.SelectedValue);
                tbobj.SpecimenId = Convert.ToInt32(cbxSpeciName.SelectedValue);
                tbobj.TestCost = Convert.ToInt32(txtCost.Text.Trim());
                tbobj.RoomNo = Convert.ToInt32(txtRoom.Text.Trim());

                dbobj.AddToDignosticTestDetails(tbobj);
                dbobj.SaveChanges();
                MessageBox.Show("Save Succeesed");
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
