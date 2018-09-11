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

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            
            string deleted = cbUserToDelete.Text;

            DialogResult choice = MessageBox.Show("Are you sure you want to delete " + deleted, "Do you want to quit? ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.Yes)
            {

                // Needs finished
                // if( deletion from database is successful){
                // lblCarDeletionSuccess.Text = " Success you deleted " + deleted + " from the car list";
                // }

                MessageBox.Show("You deleted " + deleted);
                User whoToDelete = ((User)cbUserToDelete.SelectedItem);
                User.Delete(whoToDelete);
                Close();
            }
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            List<User> Users = User.GetAllUsers();
            // If there are no users in database
            if (Users.Count() == 0)
            {
                cbUserToDelete.Items.Add("No users to delete");
            }
            // If there are users
            else
            {
                // Get users from database
                cbUserToDelete.DataSource = Users;
                // Input user first name to drop down list
                cbUserToDelete.DisplayMember = nameof(User.FirstName); 
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbUserToDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
