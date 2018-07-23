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
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            frmCarSelection frmCarSelection = new frmCarSelection();
            frmCarSelection.Show();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            EditCar editCar = new EditCar();
            editCar.Show();
            editCar.BringToFront();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            DeleteCar deleteCar = new DeleteCar();
            deleteCar.Show();
        }

        private void btnAddRepair_Click(object sender, EventArgs e)
        {
            frmModRepair addRepair = new frmModRepair();
            addRepair.Show();
        }

        private void btnEditRepair_Click(object sender, EventArgs e)
        {
            EditRepair editRepair = new EditRepair();
            editRepair.Show();
        }

        private void btnDeleteRepair_Click(object sender, EventArgs e)
        {
            DeleteRepair deleteRepair = new DeleteRepair();
            deleteRepair.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void gbUser_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
