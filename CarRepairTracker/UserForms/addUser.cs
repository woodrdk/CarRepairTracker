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
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void btnAddUserName_Click(object sender, EventArgs e)
        {
            using (CarRepairDbContext objUserContext = new CarRepairDbContext())
            {
                User userName = new User();
                userName.FirstName = txtFirstName.Text;
                userName.LastName = txtLastName.Text;
                objUserContext.Users.Add(userName);
                objUserContext.SaveChanges();


                // need to put in code for if inserted properly  alerts ya it was inserted
            };
            


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addUser_Load(object sender, EventArgs e)
        {

        }
    }
}
