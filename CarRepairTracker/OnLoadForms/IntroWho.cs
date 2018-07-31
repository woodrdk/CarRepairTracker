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
        public static int whoUsing;
        private void IntroWho_Load(object sender, EventArgs e)
        {
            string addNew = "Add a new user";
            List<User> Users = User.GetAllUsers();
            if(Users.Count() == 0)
            {
                cbWho.Items.Add(addNew);
            }
            else
            {
                cbWho.DataSource = Users;
                cbWho.DisplayMember = nameof(User.FirstName);
            }

            whoUsing = ((User)cbWho.SelectedItem).UserID; // defines the user id of who picked

            string addNewCar = "Add a new car";
            List<UserCar> UserCars = UserCar.GetAllUserCars();
            if (UserCars.Count() == 0)
            {
                cbCarOfWho.Items.Add(addNewCar);
            }
            else
            {
                cbCarOfWho.DataSource = UserCars;
                cbCarOfWho.DisplayMember = nameof(UserCar.CarNameDescription);
            }


        }

       
        String who;
 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            who = cbWho.Text;
           
            string addCar = "Add a car";
            if (who == "Add a new user")
            {
                UserForms.addUser AddUser = new UserForms.addUser();
                AddUser.Show();
            }
         
            else
            {
                pnlWho.Visible = false;
                if (cbCarOfWho.SelectedItem == null || cbCarOfWho.Text == null)
                {
                    frmCarSelection UsersCars = new frmCarSelection();
                    UsersCars.Show();
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

        private void btnRepairHistory_Click(object sender, EventArgs e)
        {
           

        }
    }
}
