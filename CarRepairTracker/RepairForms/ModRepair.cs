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
    public partial class frmModRepair : Form
    {
        public frmModRepair()
        {
            InitializeComponent();
        }
        public static int RepairID = 0;
        

        private void frmModRepair_Load(object sender, EventArgs e)
        {
         
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPartName.Clear();
            txtPartNum.Clear();
            txtPartBrand.Clear();
            txtPartCost.Clear();
            txtQty.Clear();
            rtbNotes.Clear();
            txtMileage.Clear();
            txtTotalCost.Clear();
            txtTotalCost.Clear();
            txtLaborCost.Clear();
        }

        CarRepairDbContext objUserContext = new CarRepairDbContext(); //replaces the using 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
                Repair CarRepair = new Repair();
                CarRepair.RepairDate = dtpRepair.Value;
                CarRepair.CarId = 0; // pull it from open car need to write code forthis
                CarRepair.LaborCost = Convert.ToDouble(txtLaborCost.Text);
                CarRepair.Mileage = Convert.ToInt32(txtMileage.Text);
                CarRepair.Misc = rtbNotes.Text;
             // CarRepair.Name = txtPartName.Text; 
                CarRepair.ShopName = txtShopName.Text;
                CarRepair.TotalCost = Convert.ToDouble(txtTotalCost.Text);
                CarRepair.RepairID = RepairID;

                Part CarPart = new Part();
                CarPart.PartBrand = txtPartBrand.Text;
                CarPart.Price = Convert.ToDouble(txtPartCost.Text);
                CarPart.PartNumber = txtPartNum.Text;
                CarPart.Qty = Convert.ToInt32(txtQty.Text);
                CarPart.PartName = txtPartName.Text; 
                CarPart.RepairID = RepairID; 
             
                objUserContext.Repairs.Add(CarRepair);
                objUserContext.Parts.Add(CarPart);
        }

        private void btnSame_Click(object sender, EventArgs e)
        {
            objUserContext.SaveChanges();
        }

        private void btnNewRepair_Click(object sender, EventArgs e)
        {
            // restart repair
            RepairID ++;
            gbAddPart.Visible = true;
        }
    }
}
