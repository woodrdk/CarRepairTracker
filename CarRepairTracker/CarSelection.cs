using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRepairTracker
{
    public partial class frmCarSelection : Form
    {
        public frmCarSelection()
        {
            InitializeComponent();
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void frmCarSelection_Load(object sender, EventArgs e)
        {
            for (int i = 2020; i > 1900; i--)
            {
                cbYear.Items.Add(i);
            }
        }
    }
}
