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
            this.vehicleListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCarDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.addRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnAddRepair = new System.Windows.Forms.Button();
            this.btnEditRepair = new System.Windows.Forms.Button();
            this.btnDeleteRepair = new System.Windows.Forms.Button();
            this.whoseCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
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
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCarToolStripMenuItem.Text = "Add Car";
            this.addCarToolStripMenuItem.Click += new System.EventHandler(this.AddCarToolStripMenuItem_Click);
            // 
            // deleteCarToolStripMenuItem
            // 
            this.deleteCarToolStripMenuItem.Name = "deleteCarToolStripMenuItem";
            this.deleteCarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteCarToolStripMenuItem.Text = "Delete Car";
            // 
            // editCarDetailsToolStripMenuItem
            // 
            this.editCarDetailsToolStripMenuItem.Name = "editCarDetailsToolStripMenuItem";
            this.editCarDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editCarDetailsToolStripMenuItem.Text = "Edit Car Details";
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
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(144, 44);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(572, 369);
            this.pnlMain.TabIndex = 2;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(12, 44);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnAddCar.TabIndex = 0;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.button1_Click);
            // 
            // addRepairToolStripMenuItem
            // 
            this.addRepairToolStripMenuItem.Name = "addRepairToolStripMenuItem";
            this.addRepairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addRepairToolStripMenuItem.Text = "Add Repair";
            // 
            // editRepairToolStripMenuItem
            // 
            this.editRepairToolStripMenuItem.Name = "editRepairToolStripMenuItem";
            this.editRepairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editRepairToolStripMenuItem.Text = "Edit Repair";
            // 
            // deleteRepairToolStripMenuItem
            // 
            this.deleteRepairToolStripMenuItem.Name = "deleteRepairToolStripMenuItem";
            this.deleteRepairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteRepairToolStripMenuItem.Text = "Delete Repair";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnEditCar
            // 
            this.btnEditCar.Location = new System.Drawing.Point(12, 73);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(75, 23);
            this.btnEditCar.TabIndex = 3;
            this.btnEditCar.Text = "Edit Car";
            this.btnEditCar.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(12, 102);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCar.TabIndex = 4;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            // 
            // btnAddRepair
            // 
            this.btnAddRepair.Location = new System.Drawing.Point(12, 156);
            this.btnAddRepair.Name = "btnAddRepair";
            this.btnAddRepair.Size = new System.Drawing.Size(75, 23);
            this.btnAddRepair.TabIndex = 5;
            this.btnAddRepair.Text = "Add Repair";
            this.btnAddRepair.UseVisualStyleBackColor = true;
            // 
            // btnEditRepair
            // 
            this.btnEditRepair.Location = new System.Drawing.Point(13, 186);
            this.btnEditRepair.Name = "btnEditRepair";
            this.btnEditRepair.Size = new System.Drawing.Size(75, 23);
            this.btnEditRepair.TabIndex = 6;
            this.btnEditRepair.Text = "Edit Repair";
            this.btnEditRepair.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRepair
            // 
            this.btnDeleteRepair.Location = new System.Drawing.Point(12, 216);
            this.btnDeleteRepair.Name = "btnDeleteRepair";
            this.btnDeleteRepair.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRepair.TabIndex = 7;
            this.btnDeleteRepair.Text = "Delete Repair";
            this.btnDeleteRepair.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.btnDeleteRepair);
            this.Controls.Add(this.btnEditRepair);
            this.Controls.Add(this.btnAddRepair);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Welcome to 253 Car Repair / Mod Tracker";
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
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.ToolStripMenuItem repairsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnAddRepair;
        private System.Windows.Forms.Button btnEditRepair;
        private System.Windows.Forms.Button btnDeleteRepair;
        private System.Windows.Forms.ToolStripMenuItem whoseCarToolStripMenuItem;
    }
}

