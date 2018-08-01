using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRepairTracker.Models;

namespace CarRepairTracker
{
    public partial class frmMain : Form
    {

        private frmCarSelection of = new frmCarSelection();

        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ShowNavButtons(); // on load  shows nav buttons
            ShowNavForm();      // on load shows nav form
        }

        private void ShowNavButtons()
        {   // this method is te code to make the nav show
            Navigation navForm = new Navigation
            {
                MdiParent = this
            };
            navForm.Show();
        }

        private void ShowNavForm()
        { // this method is the code to make the nav show
            IntroWho introForm = new IntroWho
            {
                MdiParent = this
            };

            // Generate List of users to check if a first time user
            List<User> Users = User.GetAllUsers();
            if (Users.Count() == 0) // if there are no users in database
            {
                UserForms.addUser AddUser = new UserForms.addUser
                {
                    MdiParent = this
                };
                AddUser.Show(); // opens the adduser form
            }
            else // if there are users
            {
                introForm.Show();
            }            
        }

        private void NavigationToolStripMenuItem_Click(object sender, EventArgs e)
        { // this method is the code to make the nav buttons show
            ShowNavButtons();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {   // code for pop up verification box upon close
            //DialogResult choice = MessageBox.Show("Are you sure you want to quit? ", "Do you want to quit? ",
            //MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (choice == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
            //else
            //{
            //    MessageBox.Show("Thank you for using 253 Car Mod Tracker");
            //}
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frmCarSelection secondForm = new frmCarSelection
            {
                MdiParent = this
            };
            secondForm.Show();
        }

        private void MenuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void WhoseCarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void AddCarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCarSelection secondForm = new frmCarSelection
            {
                MdiParent = this
            };
            secondForm.Show();
        }

        private void NavigationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Navigation navForm = new Navigation
            {
                MdiParent = this
            };
            navForm.Show();
        }

        private void AddRepairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmModRepair ModRepair = new frmModRepair
            {
                MdiParent = this
            };
            ModRepair.Show();
        }

        private void DeleteRepairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DeleteCar DeleteCar = new DeleteCar
            {
                MdiParent = this
            };
            DeleteCar.Show();
        }

        private void EditCarDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditCar EditCar = new EditCar
            {
                MdiParent = this
            };
            EditCar.Show();
        }

        private void EditRepairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditRepair EditRepair = new EditRepair
            {
                MdiParent = this
            };
            EditRepair.Show();
        }

        private void DeleteCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCar deleteCar = new DeleteCar
            {
                MdiParent = this
            };
            deleteCar.Show();
        }

        private void AddUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForms.addUser AddUser = new UserForms.addUser
            {
                MdiParent = this
            };
            AddUser.Show();
        }

        private void ChangeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNavForm();
        }
    }
}
