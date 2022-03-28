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
    public partial class GroupForm : Form
    {
        public GroupForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtGrpName.Text == "")
            {
                MessageBox.Show("Text box is empty");
            }
            else
            {
                var dbobj = new SANITARIUMEntities();
                var tbobj = new GroupInfo();

                tbobj.GroupName = txtGrpName.Text.Trim();

                dbobj.AddToGroupInfoes(tbobj);
                dbobj.SaveChanges();
                MessageBox.Show("Saved Succeed");
                FillGroup();
                ClearText();
            }
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            FillGroup();
            ClearText();
        }

        private void ClearText()
        {
            txtGrpName.Text = string.Empty;
        }

        private void FillGroup()
        {
            var obj = new Manager();
            var list = obj.GetAllGroupt();
            cbxGrpName.DisplayMember = "GroupName";
            cbxGrpName.ValueMember = "Id";
            cbxGrpName.DataSource = list;
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
