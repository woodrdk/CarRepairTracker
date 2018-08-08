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
    public partial class frmCarSelection : Form
    {
        

        public frmCarSelection()
        {
            InitializeComponent();
        }
        
        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCarSelection_Load(object sender, EventArgs e)
        {
            DateTime currYear = DateTime.Now;
            int year = currYear.Year;
            for (int i = year + 1; i > 1900; i--)
            {
                cbYear.Items.Add(i);
            }

            cbMake.SelectedItem = "";
                // temp vars for testing
            cbTrim.Items.Add("HEMI");
            cbEngine.Items.Add("V8");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            String make = cbMake.Text;
            String year = cbYear.Text;
            List<Model> Models = Model.GetAllModels(make, year);
            cbModel.DataSource = Models;
            cbModel.DisplayMember = nameof(Model.Name);
            // need to set this up to change models when this is refreshed
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String year = cbYear.Text;
            List<Make> Makes = Make.GetAllMakes(year);
            cbMake.DataSource = Makes;
            cbMake.DisplayMember = nameof(Make.Name);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var ifCarAdded = UserCar.GetAllUserCars().Count();
            using (CarRepairDbContext objUserContext = new CarRepairDbContext())
            {
                UserCar userCars = new UserCar();

                userCars.UserId = IntroWho.whoUsing; //((FrmMain)MdiParent).whoIsUsing;
                    //IntroWho.cbWho_SelectedIndexChanged(sender, e); // pulls the variable of whos owner of car from intro form
                userCars.CarNameDescription = txtCarNameIdentifier.Text;
                userCars.Year = Int32.Parse( cbYear.SelectedItem.ToString());
                userCars.Make = ((Make)cbMake.SelectedItem).Name;
                    // another way to do prev line of code
                    // Make SelectedMake = cbMake.SelectedItem as Make;
                    // userCars.Make = SelectedMake.Name;
                userCars.Model = ((Model)cbModel.SelectedItem).Name;
                userCars.Trim = cbTrim.SelectedItem.ToString(); ;
                userCars.Engine = cbEngine.SelectedItem.ToString(); ;
                userCars.Vin = txtVin.Text;
                userCars.Plate = txtPlate.Text;
                userCars.State = txtState.Text;
                userCars.Color = txtColor.Text;
                userCars.UniqueIdentifiers = rtbUnique.Text;
                userCars.OilGrade = txtOilGrade.Text;
                userCars.OilFilter = txtOilFilter.Text;
                userCars.AirFilter = txtAirFilter.Text;
                userCars.SparkPlugs = txtSparkPlugs.Text;
                userCars.HeadlightBulb = txtHeadlight.Text;
                userCars.TireSize = txtTireSize.Text;
                userCars.PurchaseDate = datePurchase.Value; 
                //userCars.PurchasePrice = Convert.ToDouble(txtPurchasePrice.Text); //double.Parse
                //userCars.PurchaseMileage = Convert.ToInt32(txtPurchaseMileage.Text);
                //userCars.Warranty = Convert.ToBoolean( cbWarranty.Text); // need to get data
                userCars.ExpirationDate = dtpWarrExp.Value;
                //userCars.ExpirationMileage = Convert.ToInt32(txtWarrMileage.Text);
                userCars.Comments = txtComments.Text;
                objUserContext.UserCars.Add(userCars);
                objUserContext.SaveChanges();
           
                // code to verify car added needs work
                if((ifCarAdded + 1) == UserCar.GetAllUserCars().Count())
                {
                    Close();
                    MessageBox.Show("Car Successfully Added");
                }
            };
        }

        private void cbWarranty_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWarranty.Checked)
            {
                cbWarranty.Text = "True";
            }
            else
            {
                cbWarranty.Text = "False";
            }
        }

        private void cbTrim_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbEngine_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
