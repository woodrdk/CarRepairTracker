using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRepairTracker.Models;

namespace CarRepairTracker
{
    public partial class FrmMain : Form
    {       

        public User whoIsUsing;

        //[DllImport("user32")] public static extern int SetParent(int hWndChild, int hWndNewParent);

        // In the class for a child window, add a private variable for an MDIChildExpander object:

        //private MDIChildExpander expander;

        // Next, in the constructer of the child window class, create it:

        //expander = new MDIChildExpander(this);

        // Then allow the user somehow to expand the window and then call the following code:

        //expander.Expand();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ShowNavButtons();   // on load  shows nav buttons
            ShowNavForm();      // on load shows nav form
            //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form.layoutmdi?view=netframework-4.7.2
            //HorizontallyTileMyWindows(sender, e);
            //VerticallyTileMyWindows(sender, e);
            //CascadeMyWindows(sender, e);
        }
        
        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form.layoutmdi?view=netframework-4.7.2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void HorizontallyTileMyWindows(object sender, System.EventArgs e)
        //{
        //    // Tile all child forms horizontally.
        //    this.LayoutMdi(MdiLayout.TileHorizontal);
        //}
        //private void VerticallyTileMyWindows(object sender, System.EventArgs e)
        //{
        //    // Tile all child forms vertically.
        //    this.LayoutMdi(MdiLayout.TileVertical);
        //}
        //private void CascadeMyWindows(object sender, System.EventArgs e)
        //{
        //    // Cascade all MDI child windows.
        //    this.LayoutMdi(MdiLayout.Cascade);
        //}

        private void NavigationToolStripMenuItem_Click(object sender, EventArgs e)
        { // this method is the code to make the nav buttons show
            ShowNavButtons();
        }

        private void ChangeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNavForm();
            
        }

        private void ShowNavButtons()
        {   // this method is the code to make the nav show
            Navigation navForm = new Navigation
            {
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this
            };
            pnlNavMenu.Controls.Add(navForm);
            pnlNavMenu.PointToScreen(new Point(124, 0));
            navForm.Show();
            //SetParent((int)navForm.Handle, (int)this.Handle);
        }

        private void ShowNavForm()
        { // this method is the code to make the nav show
            IntroWho introForm = new IntroWho
            {
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this
            };
            pnlMainWindow.Controls.Add(introForm);
            introForm.Show();
        }

        private void IntroWho(object sender, EventArgs e)
        {
            IntroWho introWho = new IntroWho
            {
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this
            };
            pnlMainWindow.Controls.Add(introWho);
            introWho.Show();
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
            DeleteCar deleteCar = new DeleteCar
            {
                MdiParent = this
            };
            deleteCar.Show();
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
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this
            };
            pnlMainWindow.Controls.Add(deleteCar);
            deleteCar.Show();
        }

        private void AddUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForms.AddUser addUser = new UserForms.AddUser
            {
                TopLevel = false,
                AutoScroll = true,
                MdiParent = this
            };
            pnlMainWindow.Controls.Add(addUser);
            addUser.Show(ActiveControl);
        }

        private void AddCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar
            {
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this
            };
            pnlMainWindow.Controls.Add(addCar);
            addCar.Show();
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

        private void MenuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void WhoseCarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void pnlNavMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
