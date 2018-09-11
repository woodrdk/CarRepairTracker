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
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            List<User> Users = User.GetAllUsers();
            // If there are no users in database
            if (Users.Count() == 0)
            {
                cbUserToEdit.Items.Add("No users to delete");
            }
            // If there are users
            else
            {
                // Get users from database
                cbUserToEdit.DataSource = Users;
                // Input user first name to drop down list
                cbUserToEdit.DisplayMember = nameof(User.FirstName);
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var editWho = cbUserToEdit.SelectedIndex;
            gbEdit.Visible = false;
            gbNameEdit.Visible = true;
            txtFirstName.Text = "xx";
            txtLastName.Text = "xxx";
        }
    }
}
