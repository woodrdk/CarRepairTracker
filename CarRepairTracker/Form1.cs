﻿using System;
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
        public frmMain()
        {
            InitializeComponent();
        }

   

        private void AddCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarSelection secondForm = new frmCarSelection();

            secondForm.ShowDialog();

         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCarSelection secondForm = new frmCarSelection();
            secondForm.TopLevel = false;
            secondForm.AutoScroll = true;
            this.pnlMain.Controls.Add(secondForm);
            secondForm.Show();


            /*
            Panel p = Parent as Panel;
            if (p != null)
            {
                frmCarSelection myForm = new frmCarSelection();
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                p.Controls.Add(myForm);
                myForm.Show();
                
            }
            */
        }

        private void repairsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModRepair ModRepair = new frmModRepair();

            ModRepair.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void whoseCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntroWho introForm = new IntroWho();
            introForm.ShowDialog();

           
        }
    }
}
