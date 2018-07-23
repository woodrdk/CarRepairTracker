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
    public partial class frmMain : Form
    {

        private frmCarSelection of = new frmCarSelection();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ShowNavButtons();
            ShowNavForm();
        }

        private void ShowNavButtons()
        {
            Navigation navForm = new Navigation();
            navForm.MdiParent = this;
            navForm.Show();
        }

        private void ShowNavForm()
        {
            IntroWho introForm = new IntroWho();
            introForm.MdiParent = this;
            introForm.Show();
        }

        private void navigationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNavButtons();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to quit? ", "Do you want to quit? ",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("Thank you for using 253 Car Mod Tracker");
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frmCarSelection secondForm = new frmCarSelection();
            secondForm.MdiParent = this;
            secondForm.Show();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void whoseCarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowNavForm();
        }

        private void addCarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCarSelection secondForm = new frmCarSelection();
            secondForm.MdiParent = this;
            secondForm.Show();
        }

        private void navigationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Navigation navForm = new Navigation();
            navForm.MdiParent = this;
            navForm.Show();
        }

        private void addRepairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmModRepair ModRepair = new frmModRepair();
            ModRepair.MdiParent = this;
            ModRepair.Show();
        }

        private void deleteRepairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DeleteCar DeleteCar = new DeleteCar();
            DeleteCar.MdiParent = this;
            DeleteCar.Show();
        }

        private void editCarDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditCar EditCar = new EditCar();
            EditCar.MdiParent = this;
            EditCar.Show();
        }

        private void editRepairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditRepair EditRepair = new EditRepair();
            EditRepair.MdiParent = this;
            EditRepair.Show();
        }

        private void deleteCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCar deleteCar = new DeleteCar();
            deleteCar.MdiParent = this;
            deleteCar.Show();
        }
    }
}
