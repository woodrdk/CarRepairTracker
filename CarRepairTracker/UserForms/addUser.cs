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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            List<User> Users = User.GetAllUsers();
            if (Users.Count() == 0) // if there are no users in database
            {
                lblFirstTimeUser.Show();
            }
            else
            {
                lblFirstTimeUser.Hide();
            }
        }

        private void BtnAddUserName_Click(object sender, EventArgs e)
        {
            using (CarRepairDbContext objUserContext = new CarRepairDbContext())
            {

                User userName = new User
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text
                };
                objUserContext.Users.Add(userName);
                objUserContext.SaveChanges();

                MessageBox.Show("User " + userName.FirstName + " added successfully");
                // need to put in code for if inserted properly  alerts ya it was inserted
                // also need to repopulate the intro form  select user dropdown
            };
            // Closes initial AddUser Form
            Close();

            // Checks if first time user
            List<User> Users = User.GetAllUsers();
            // If a first time user just registered, take to IntroWho form
            if (Users.Count() == 1)
            {
                // Creates a new IntroWho form object
                IntroWho FirstTimeUserIntroWho = new IntroWho();
                // Opens the intro who form after first time user registers
                FirstTimeUserIntroWho.Show();                
            }         
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
