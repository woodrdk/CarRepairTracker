using CarRepairTracker.Models;
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
            {// --------------------------------------------------------------- needs finished

                // if( deletion from database is successful){
                // lblCarDeletionSuccess.Text = " Success you deleted " + deleted + " from the car list";
                // }
                pnlDeleteUserSuccess.Visible = false;
                MessageBox.Show("You deleted " + deleted);

                User whoToDelete = ((User)cbUserToDelete.SelectedItem);

                User.Delete(whoToDelete);
            }

            pnlDeleteUserSuccess.Visible = true;
            lblDeletedUserSuccess.Text = " You successfully deleted " + deleted + " from the user list!";
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            List<User> Users = User.GetAllUsers();
            if (Users.Count() == 0) // if there are no users in database
            {
                cbUserToDelete.Items.Add("No users to delete");    // insert add a new user to dropdown box
            }
            else // if there are users
            {
                cbUserToDelete.DataSource = Users; // get users from database
                cbUserToDelete.DisplayMember = nameof(User.FirstName); // input user first name to drop down list
            }           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
