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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCatName.Text == "")
            {
                MessageBox.Show("Text box is empty");
            }
            else
            {
                var dbobj = new SANITARIUMEntities();
                var tbobj = new CategoryInfo();

                tbobj.CategoryName = txtCatName.Text.Trim();

                dbobj.AddToCategoryInfoes(tbobj);
                dbobj.SaveChanges();
                MessageBox.Show("Save Succeed");
                FilCategory();
                ClearText();
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            FilCategory();
            ClearText();
        }

        private void ClearText()
        {
            txtCatName.Text = string.Empty;
        }

        private void FilCategory()
        {
            var obj = new Manager();
            var list = obj.GetAllCategory();
            cbxCatName.DisplayMember = "CategoryName";
            cbxCatName.ValueMember = "Id";
            cbxCatName.DataSource = list;
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
