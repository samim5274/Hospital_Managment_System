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
    public partial class DayWiseSaleReportForm : Form
    {
        public DayWiseSaleReportForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var SD = Convert.ToDateTime(dtpSD.Value);
            var ED = Convert.ToDateTime(dtpED.Value);

            var mngr = new Manager();


        }
    }
}
