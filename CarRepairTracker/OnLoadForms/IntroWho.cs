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
            string addNew = "Add a new user";
            List<User> Users = User.GetAllUsers();
            if(Users.Count() == 0)
            {
                cbWho.Items.Add(addNew);
                // cbWho.Items.Add = "Add a new user";
            }
            else
            {
         
                cbWho.DataSource = Users;
                cbWho.DisplayMember = nameof(User.FirstName);
            }
                

        }

       
        String who;
   

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            who = cbWho.Text;
            if(who == "Add a new user")
            {
                UserForms.addUser AddUser = new UserForms.addUser();
                AddUser.Show();
            }
            else
            {

                pnlWho.Visible = false;

                if (lblCarOfWho.SelectedItem == null)
                {
                    // make the add car form run
                }

                scDisplay.Visible = true;
                lblWhoPicked.Text = "Welcome " + who + " what would you like to do today? ";

            }
        }

        private void lblCarOfWho_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
