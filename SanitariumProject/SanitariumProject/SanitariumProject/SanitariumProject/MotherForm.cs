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
    public partial class MotherForm : Form
    {
        public MotherForm()
        {
            InitializeComponent();
        }

        private void departmentDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DepartmentForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void groupDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new GroupForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void categoryDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new CategoryForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void specimenDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new SpecimenForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void subCategoryDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new SubCategoryForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void saleOfTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DiognosisTestDetailForm2();
            obj.MdiParent = this;
            obj.Show();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new CreateUserForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void testSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new TestSaleForm();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
