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
    public partial class DiognosisTestDetailForm2 : Form
    {
        public DiognosisTestDetailForm2()
        {
            InitializeComponent();
        }

        private void DiognosisTestDetailForm2_Load(object sender, EventArgs e)
        {
            FillDepartment();
            FillCategory();
            FillSubCategory();
            FillGroup();
            FillSpecimen();
            ClearText();
            FillGrid();
        }

        private void FillGrid()
        {
            var obj = new Manager();
            var list = obj.GetAllGrid();
            dgvTestName.DataSource = list;
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
            txtScarch.Text = string.Empty;
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

        private void FillSubCategory()
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTestName.Text == "" || txtCost.Text == "" || txtRoom.Text == "")
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
                MessageBox.Show("Save Succeesed.");
                ClearText();
                FillGrid();
            }
        }

        private void btnScarch_Click(object sender, EventArgs e)
        {
            if (txtScarch.Text == "")
            {
                MessageBox.Show("Plase write the test id", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var dbobj = new SANITARIUMEntities();
                    var tbobj =
                        dbobj.DignosticTestDetails.ToList().Where(x => x.Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();

                    txtTestName.Text = tbobj.TestName.Trim();
                    cbxDepName.SelectedValue = tbobj.DepartmentId;
                    cbxCatName.SelectedValue = tbobj.CategoryId;
                    cbxSubCatName.SelectedValue = tbobj.SubCategoryId;
                    cbxGrpName.SelectedValue = tbobj.GroupId;
                    cbxSpeciName.SelectedValue = tbobj.SpecimenId;
                    txtCost.Text = tbobj.TestCost.ToString();
                    txtRoom.Text = tbobj.RoomNo.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Data not found.Please try another test id.", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtScarch.Text == "")
            {
                MessageBox.Show("Please fast scarch the test id.Then you can edit the test valu.Thank you.");
            }
            else
            {
                var dbobj = new SANITARIUMEntities();
                var tbobj =
                    dbobj.DignosticTestDetails.ToList().Where(x => x.Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();

                tbobj.TestName = txtTestName.Text.Trim();
                tbobj.DepartmentId = Convert.ToInt32(cbxDepName.SelectedValue);
                tbobj.CategoryId = Convert.ToInt32(cbxCatName.SelectedValue);
                tbobj.SubCategoryId = Convert.ToInt32(cbxSubCatName.SelectedValue);
                tbobj.GroupId = Convert.ToInt32(cbxGrpName.SelectedValue);
                tbobj.SpecimenId = Convert.ToInt32(cbxSpeciName.SelectedValue);
                tbobj.TestCost = Convert.ToInt32(txtCost.Text.Trim());
                tbobj.RoomNo = Convert.ToInt32(txtRoom.Text.Trim());

                dbobj.SaveChanges();
                MessageBox.Show("Edit Successfully.");
                ClearText();
                FillGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You cann't delete the test.Thank You");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Hospital Management System", new Font("Arial", 38, FontStyle.Bold), Brushes.Black, new Point(40, 30));
            e.Graphics.DrawString("Dhaka,Bangladesh-1750", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(270, 90));
            e.Graphics.DrawString("Phone: +88017 6216 4746, +88015 3302 1557", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(160, 120));
            e.Graphics.DrawString("Dignostic Test Detail", new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(240, 160));
            e.Graphics.DrawString("Test Id :  " + txtScarch.Text.Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(40, 170));
            e.Graphics.DrawString("Date / Time :  " + dtpDateToday.Value, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(90, 600));

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 198));

            e.Graphics.DrawString("Test Name", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(65, 218));
            e.Graphics.DrawString(":", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 218));
            //e.Graphics.DrawString("|", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(550, 218));
            e.Graphics.DrawString(txtTestName.Text.Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(218, 218));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 240));

            e.Graphics.DrawString("Department", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(65, 260));
            e.Graphics.DrawString(":", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 260));
            //e.Graphics.DrawString("|", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(550, 260));
            e.Graphics.DrawString(cbxDepName.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(218, 260));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 282));

            e.Graphics.DrawString("Category", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(65, 302));
            e.Graphics.DrawString(":", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 302));
            //e.Graphics.DrawString("|", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(550, 302));
            e.Graphics.DrawString(cbxCatName.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(218, 302));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 324));

            e.Graphics.DrawString("Subcategory", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(65, 344));
            e.Graphics.DrawString(":", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 344));
            //e.Graphics.DrawString("|", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(550, 344));
            e.Graphics.DrawString(cbxSubCatName.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(218, 344));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 366));

            e.Graphics.DrawString("Group", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(65, 386));
            e.Graphics.DrawString(":", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 386));
            //e.Graphics.DrawString("|", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(550, 386));
            e.Graphics.DrawString(cbxGrpName.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(218, 386));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 408));

            e.Graphics.DrawString("Specimen", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(65, 428));
            e.Graphics.DrawString(":", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 428));
            //e.Graphics.DrawString("|", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(550, 428));
            e.Graphics.DrawString(cbxSpeciName.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(218, 428));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 450));

            e.Graphics.DrawString("Room", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(65, 470));
            e.Graphics.DrawString(":", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 470));
            //e.Graphics.DrawString("|", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(550, 470));
            e.Graphics.DrawString(txtRoom.Text.Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(218, 470));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 492));

            e.Graphics.DrawString("Cost", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(65, 512));
            e.Graphics.DrawString(":", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 512));
            //e.Graphics.DrawString("|", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(550, 512));
            e.Graphics.DrawString(txtCost.Text.Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(218, 512));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 534));
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxCatName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxSubCatName.Text = cbxCatName.Text;
        }
    }
}
