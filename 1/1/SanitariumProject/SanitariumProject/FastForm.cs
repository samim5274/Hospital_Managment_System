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
    public partial class FastForm : Form
    {
        public FastForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var obj = new MotherForm();
            obj.Closed += (s, args) => this.Close();
            obj.Show();
        }
    }
}
