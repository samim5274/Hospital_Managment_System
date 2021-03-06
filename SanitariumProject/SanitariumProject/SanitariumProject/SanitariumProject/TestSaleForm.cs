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
    public partial class TestSaleForm : Form
    {
        public TestSaleForm()
        {
            InitializeComponent();
        }

        private void TestSaleForm_Load(object sender, EventArgs e)
        {
            FillGender();
            FillAgeStatus();
            FillDoctor();
            FillRefer();
            FillTest();
            FillDiscountAuthor();
        }

        private void FillDiscountAuthor()
        {
            var obj = new Manager();
            var list = obj.GetAllDisAuthor();
            cbxDisAuthor.DisplayMember = "Name";
            cbxDisAuthor.ValueMember = "Id";
            cbxDisAuthor.DataSource = list;
        }

        private void FillTest()
        {
            var obj = new Manager();
            var list = obj.GetAllTest();
            cbxTextName.DisplayMember = "TestName";
            cbxTextName.ValueMember = "Id";
            cbxTextName.DataSource = list;
        }

        private void FillRefer()
        {
            var obj = new Manager();
            var list = obj.GetAllRefer();
            cbxRefer.DisplayMember = "Name";
            cbxRefer.ValueMember = "Id";
            cbxRefer.DataSource = list;
        }

        private void FillDoctor()
        {
            var obj = new Manager();
            var list = obj.GetAllDoctor();
            cbxDoctor.DisplayMember = "Name";
            cbxDoctor.ValueMember = "Id";
            cbxDoctor.DataSource = list;
        }

        private void FillAgeStatus()
        {
            var obj = new Manager();
            var list = obj.GetAllAgeStatus();
            cbxAgeStatus.DisplayMember = "AgeStatus";
            cbxAgeStatus.ValueMember = "Id";
            cbxAgeStatus.DataSource = list;
        }

        private void FillGender()
        {
            var obj = new Manager();
            var list = obj.GetAllGender();
            cbxGender.DisplayMember = "Gender";
            cbxGender.ValueMember = "Id";
            cbxGender.DataSource = list;
        }

        private void btnDrAdd_Click(object sender, EventArgs e)
        {
            var obj = new DoctorDetailForm();
            obj.ShowDialog();
        }

        private void btnDrLoad_Click(object sender, EventArgs e)
        {
            FillDoctor();
        }

        private void btnRefAdd_Click(object sender, EventArgs e)
        {
            var obj = new ReferDetailForm();
            obj.ShowDialog();
        }

        private void btnRefLoad_Click(object sender, EventArgs e)
        {
            FillRefer();
        }

        private void btnTestAdd_Click(object sender, EventArgs e)
        {
            var obj = new DiognosisTestDetailForm();
            obj.ShowDialog();
        }

        private void btnTestLoad_Click(object sender, EventArgs e)
        {
            FillTest();
        }
    }
}
