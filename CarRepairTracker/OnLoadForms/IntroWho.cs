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

        String who; //variable in class scope
        public static int whoUsing; // used in many locations to keep track of who is using

        public IntroWho()
        {
            InitializeComponent();
        }

        private void IntroWho_Load(object sender, EventArgs e)
        {
            List<User> Users = User.GetAllUsers();

            // If there are no users in the list, open AddUser window
            if (Users.Count() == 0)
            {
                UserForms.AddUser AddUser = new UserForms.AddUser();

                // Opens the AddUser form and ActiveControl sets focus for window
                AddUser.Show(ActiveControl);
            }

            Users.Insert(0, new User() { FirstName = "Select a user" });
            // Gets users from the database
            cbWho.DataSource = Users;

            // Input user first name to drop down list
            cbWho.DisplayMember = nameof(User.FirstName); 
            cbWho.SelectedIndex = 0;
        }

        public void CbWho_SelectedIndexChanged(object sender, EventArgs e)
        {
            string addNewCar = "Add a new car";     // variable to add the input 
            List<UserCar> UserCars = UserCar.GetAllUserCars(); // makes list of users cars
            cbCarOfWho.DataSource = null;
            if (UserCars.Count() == 0)  // if no cars in the users car list
            {
                cbCarOfWho.Items.Clear();
                cbCarOfWho.Items.Add(addNewCar);    // input add a new car to drop down
            }
            else   // if user has cars
            {
                cbCarOfWho.DataSource = UserCars;   // pulls cars from database
                cbCarOfWho.DisplayMember = nameof(UserCar.CarNameDescription);  // populates the dropdown with the users cars
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)    // when submit button is clicked do this
        {
            who = cbWho.Text; // defines the variable as the selected text from the who drop down box
            // submit 
            whoUsing = Convert.ToInt32(((User)cbWho.SelectedItem).UserID);
            ((FrmMain)MdiParent).whoIsUsing = ((User)cbWho.SelectedItem);   // defines the user id of who picked         
            
            //string addCar = "Add a car";    // makes variable to save typing later
            if (who == "Add New User")    // if when clicked submit and the value is add a new user
            {
                UserForms.AddUser AddUser = new UserForms.AddUser();    
                AddUser.Show(); // opens the adduser form
            }
            else if(who == "Select a user")
            {
                MessageBox.Show("Select a user");
            }
            else
            {
                pnlWho.Visible = false;
                if (cbCarOfWho.SelectedItem == null || cbCarOfWho.Text == null || cbCarOfWho.Text == "Add a new car")
                {
                    frmCarSelection NewCarForm = new frmCarSelection
                    {
                        MdiParent = this.MdiParent
                    };
                    NewCarForm.Show(); // make the add car form run
                }
                pnlWhichCar.Visible = true;               
            }
        }

        private void BtnChangeCar_Click(object sender, EventArgs e)
        {
            pnlWho.Visible = true;
            scDisplay.Visible = false;
            cbWho.Visible = false;
            lblWho.Text = "Which car would you like to change to?";
        }

        private void BtnWhichCar_Click(object sender, EventArgs e)
        {
            scDisplay.Visible = true;   // makes the scdisplay visible
            lblWhoPicked.Text = "Welcome " + who + " what would you like to do today? ";    // changes the label text to welcome message
        }

        public void PopulateUserList()
        {
            List<User> Users = User.GetAllUsers();

            Users.Insert(0, new User() { FirstName = "Select a user" });
            cbWho.DataSource = Users; // get users from database

            cbWho.DisplayMember = nameof(User.FirstName); // input user first name to drop down list
            cbWho.SelectedIndex = 0;
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
