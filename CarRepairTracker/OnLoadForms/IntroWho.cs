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

        String who;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            who = cbWho.Text;
            /*
             * cbWho.Visible = false;
             * lblWho.Visible = false;
             * btnSubmit.Visible = false;
            */
            pnlWho.Visible = false;

            if (lblCarOfWho.SelectedItem == null)
            {
                // make the add car form run
            }

            scDisplay.Visible = true;
            lblWhoPicked.Text = "Welcome " + who + " what would you like to do today? ";
        }

        private void lblCarOfWho_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
