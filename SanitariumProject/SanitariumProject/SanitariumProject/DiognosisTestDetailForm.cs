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
                MessageBox.Show("Save Succeesed");
                ClearText();
                FillGrid();
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

        private void btnScarch_Click(object sender, EventArgs e)
        {
            if (txtScarch.Text == "")
            {
                MessageBox.Show("Plase write the test id",@"Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
                    btnSave.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Data not found.Please try another test id.",@"Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Test Name",new Font("Arial",14,FontStyle.Regular ), Brushes.Black, new Point(65,218));
            e.Graphics.DrawString(":", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 218));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------", 
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 250));

            e.Graphics.DrawString("Department", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(65, 318));
            e.Graphics.DrawString(":", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 318));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 350));

            e.Graphics.DrawString("Category", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(65, 418));
            e.Graphics.DrawString(":", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 418));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 450));

            e.Graphics.DrawString("Subcategory", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(65, 518));
            e.Graphics.DrawString(":", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 518));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 550));

            e.Graphics.DrawString("Group", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(65, 618));
            e.Graphics.DrawString(":", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 618));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 650));

            e.Graphics.DrawString("Specimen", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(65, 718));
            e.Graphics.DrawString(":", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 718));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 750));

            e.Graphics.DrawString("Room", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(65, 818));
            e.Graphics.DrawString(":", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 818));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 850));

            e.Graphics.DrawString("Cost", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(65, 918));
            e.Graphics.DrawString(":", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 918));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 950));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
