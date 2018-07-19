namespace CarRepairTracker
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.repairsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCarDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoseCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.vehicleListToolStripMenuItem,
            this.repairsToolStripMenuItem,
            this.whoseCarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationToolStripMenuItem,
            this.vehicleListToolStripMenuItem1,
            this.repairsToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.navigationToolStripMenuItem.Text = "Navigation";
            // 
            // vehicleListToolStripMenuItem1
            // 
            this.vehicleListToolStripMenuItem1.Name = "vehicleListToolStripMenuItem1";
            this.vehicleListToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.vehicleListToolStripMenuItem1.Text = "Vehicle List";
            // 
            // repairsToolStripMenuItem1
            // 
            this.repairsToolStripMenuItem1.Name = "repairsToolStripMenuItem1";
            this.repairsToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.repairsToolStripMenuItem1.Text = "Repairs";
            // 
            // vehicleListToolStripMenuItem
            // 
            this.vehicleListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem,
            this.deleteCarToolStripMenuItem,
            this.editCarDetailsToolStripMenuItem});
            this.vehicleListToolStripMenuItem.Name = "vehicleListToolStripMenuItem";
            this.vehicleListToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.vehicleListToolStripMenuItem.Text = "Vehicle List";
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addCarToolStripMenuItem.Text = "Add Car";
            this.addCarToolStripMenuItem.Click += new System.EventHandler(this.AddCarToolStripMenuItem_Click);
            // 
            // deleteCarToolStripMenuItem
            // 
            this.deleteCarToolStripMenuItem.Name = "deleteCarToolStripMenuItem";
            this.deleteCarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteCarToolStripMenuItem.Text = "Delete Car";
            this.deleteCarToolStripMenuItem.Click += new System.EventHandler(this.deleteCarToolStripMenuItem_Click);
            // 
            // editCarDetailsToolStripMenuItem
            // 
            this.editCarDetailsToolStripMenuItem.Name = "editCarDetailsToolStripMenuItem";
            this.editCarDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editCarDetailsToolStripMenuItem.Text = "Edit Car Details";
            this.editCarDetailsToolStripMenuItem.Click += new System.EventHandler(this.editCarDetailsToolStripMenuItem_Click);
            // 
            // repairsToolStripMenuItem
            // 
            this.repairsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRepairToolStripMenuItem,
            this.editRepairToolStripMenuItem,
            this.deleteRepairToolStripMenuItem});
            this.repairsToolStripMenuItem.Name = "repairsToolStripMenuItem";
            this.repairsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.repairsToolStripMenuItem.Text = "Repairs";
            this.repairsToolStripMenuItem.Click += new System.EventHandler(this.repairsToolStripMenuItem_Click);
            // 
            // addRepairToolStripMenuItem
            // 
            this.addRepairToolStripMenuItem.Name = "addRepairToolStripMenuItem";
            this.addRepairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addRepairToolStripMenuItem.Text = "Add Repair";
            this.addRepairToolStripMenuItem.Click += new System.EventHandler(this.addRepairToolStripMenuItem_Click);
            // 
            // editRepairToolStripMenuItem
            // 
            this.editRepairToolStripMenuItem.Name = "editRepairToolStripMenuItem";
            this.editRepairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editRepairToolStripMenuItem.Text = "Edit Repair";
            this.editRepairToolStripMenuItem.Click += new System.EventHandler(this.editRepairToolStripMenuItem_Click);
            // 
            // deleteRepairToolStripMenuItem
            // 
            this.deleteRepairToolStripMenuItem.Name = "deleteRepairToolStripMenuItem";
            this.deleteRepairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteRepairToolStripMenuItem.Text = "Delete Repair";
            this.deleteRepairToolStripMenuItem.Click += new System.EventHandler(this.deleteRepairToolStripMenuItem_Click);
            // 
            // whoseCarToolStripMenuItem
            // 
            this.whoseCarToolStripMenuItem.Name = "whoseCarToolStripMenuItem";
            this.whoseCarToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.whoseCarToolStripMenuItem.Text = "Whose Car";
            this.whoseCarToolStripMenuItem.Click += new System.EventHandler(this.whoseCarToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Welcome to 253 Car Repair / Mod Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCarDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whoseCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem repairsToolStripMenuItem1;
    }
}

