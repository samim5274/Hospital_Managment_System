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
    public partial class SubCategoryForm : Form
    {
        public SubCategoryForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSubCatName.Text == "")
            {
                MessageBox.Show("Text box is empty");
            }
            else
            {
                var dbobj = new SANITARIUMEntities();
                var tbobj = new SubCategoryInfo();

                tbobj.SubCategoryName = txtSubCatName.Text.Trim();
                tbobj.CategoryId = Convert.ToInt32(cbxSubCatName.SelectedValue);

                dbobj.AddToSubCategoryInfoes(tbobj);
                dbobj.SaveChanges();
                MessageBox.Show("Save Succeed");
                FillSubcategory();
                ClearText();
            }
        }

        private void SubCategoryForm_Load(object sender, EventArgs e)
        {
            FillSubcategory();
            ClearText();
        }

        private void ClearText()
        {
            txtSubCatName.Text = string.Empty;
            cbxSubCatName.SelectedValue = string.Empty;
        }

        private void FillSubcategory()
        {
            var obj = new Manager();
            var list = obj.GettAllCategory();
            cbxSubCatName.DisplayMember = "CategoryName";
            cbxSubCatName.ValueMember = "Id";
            cbxSubCatName.DataSource = list;
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
