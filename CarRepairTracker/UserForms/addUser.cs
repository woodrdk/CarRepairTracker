﻿using CarRepairTracker.Models;
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

            User userName = new User();
            userName.FirstName = txtFirstName.Text;
            userName.LastName = txtLastName.Text;



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
