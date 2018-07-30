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
    }
}
