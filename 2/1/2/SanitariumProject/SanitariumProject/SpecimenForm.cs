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
    public partial class SpecimenForm : Form
    {
        public SpecimenForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSpeciName.Text == "")
            {
                MessageBox.Show("Text box is empty");
            }
            else
            {
                var dbobj = new SANITARIUMEntities();
                var tbobj = new SpecimenInfo();

                tbobj.SpecimenName = txtSpeciName.Text.Trim();

                dbobj.AddToSpecimenInfoes(tbobj);
                dbobj.SaveChanges();
                MessageBox.Show("Saved Succeed");
                FillSpecimenName();
                ClearText();
            }
        }

        private void SpecimenForm_Load(object sender, EventArgs e)
        {
            FillSpecimenName();
            ClearText();
        }

        private void ClearText()
        {
            txtSpeciName.Text = string.Empty;
        }

        private void FillSpecimenName()
        {
            var obj = new Manager();
            var list = obj.GetAllSpecimenName();
            cbxSpeciName.DisplayMember = "SpecimenName";
            cbxSpeciName.ValueMember = "Id";
            cbxSpeciName.DataSource = list;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxSpeciName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSpeciName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
