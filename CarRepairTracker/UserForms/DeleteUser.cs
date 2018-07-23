using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRepairTracker.UserForms
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string deleted = cbUserToDelete.Text;

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
                pnlDeleteUserSuccess.Visible = false;
                MessageBox.Show("You deleted " + deleted);
            }

            pnlDeleteUserSuccess.Visible = true;
            lblDeletedUserSuccess.Text = " You successfully deleted " + deleted + " from the user list!";
        }
    }
}
