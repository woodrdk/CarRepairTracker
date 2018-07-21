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
    public partial class DeleteCar : Form
    {
        public DeleteCar()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        string deleted;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string deleted = cbCarDelete.Text;

            DialogResult choice = MessageBox.Show("Are you sure you want to delete " + deleted, "Do you want to quit? ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.No)
            {
               
            }
            else
            {
                // if( deletion from database is successful){
                // lblCarDeletionSuccess.Text = " Success you deleted " + deleted + " from the car list";
                // }
                pnlDeleteCarSubmit.Visible = false;
                MessageBox.Show("You deleted " + deleted);
            }

            pnlDeleteCarSuccess.Visible = true;
            lblDeletedCarSuccess.Text = " You successfully deleted " + deleted + " from the vehicle list!";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteCar_Load(object sender, EventArgs e)
        {
            // next 2 lines for testing code till database enabled.
            cbCarDelete.Items.Add( "Chevy");
            cbCarDelete.Items.Add("Dodge");

            
        }

        private void lblDeletedCarSuccess_Click(object sender, EventArgs e)
        {

        }
    }
}
