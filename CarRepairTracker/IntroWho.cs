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
    public partial class IntroWho : Form
    {
        public IntroWho()
        {
            InitializeComponent();
        }

   
            
        
        private void cbWho_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void IntroWho_Load(object sender, EventArgs e)
        {

            cbWho.Items.Add("Anthony McCann");
            cbWho.Items.Add("Rob Wood");
        }
    }
}
