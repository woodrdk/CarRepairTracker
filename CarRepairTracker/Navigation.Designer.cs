namespace CarRepairTracker
{
    partial class Navigation
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
            this.btnDeleteRepair = new System.Windows.Forms.Button();
            this.btnEditRepair = new System.Windows.Forms.Button();
            this.btnAddRepair = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbCar = new System.Windows.Forms.GroupBox();
            this.gbRepairs = new System.Windows.Forms.GroupBox();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.gbCar.SuspendLayout();
            this.gbRepairs.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteRepair
            // 
            this.btnDeleteRepair.Location = new System.Drawing.Point(6, 79);
            this.btnDeleteRepair.Name = "btnDeleteRepair";
            this.btnDeleteRepair.Size = new System.Drawing.Size(86, 23);
            this.btnDeleteRepair.TabIndex = 13;
            this.btnDeleteRepair.Text = "Delete Repair";
            this.btnDeleteRepair.UseVisualStyleBackColor = true;
            // 
            // btnEditRepair
            // 
            this.btnEditRepair.Location = new System.Drawing.Point(7, 49);
            this.btnEditRepair.Name = "btnEditRepair";
            this.btnEditRepair.Size = new System.Drawing.Size(85, 23);
            this.btnEditRepair.TabIndex = 12;
            this.btnEditRepair.Text = "Edit Repair";
            this.btnEditRepair.UseVisualStyleBackColor = true;
            // 
            // btnAddRepair
            // 
            this.btnAddRepair.Location = new System.Drawing.Point(6, 19);
            this.btnAddRepair.Name = "btnAddRepair";
            this.btnAddRepair.Size = new System.Drawing.Size(86, 23);
            this.btnAddRepair.TabIndex = 11;
            this.btnAddRepair.Text = "Add Repair";
            this.btnAddRepair.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(6, 77);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(89, 23);
            this.btnDeleteCar.TabIndex = 10;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            // 
            // btnEditCar
            // 
            this.btnEditCar.Location = new System.Drawing.Point(6, 48);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(89, 23);
            this.btnEditCar.TabIndex = 9;
            this.btnEditCar.Text = "Edit Car";
            this.btnEditCar.UseVisualStyleBackColor = true;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(6, 19);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(89, 23);
            this.btnAddCar.TabIndex = 8;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(7, 19);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(85, 23);
            this.btnAddUser.TabIndex = 14;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(7, 49);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(85, 23);
            this.btnEditUser.TabIndex = 15;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(7, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete User";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gbCar
            // 
            this.gbCar.Controls.Add(this.btnAddCar);
            this.gbCar.Controls.Add(this.btnEditCar);
            this.gbCar.Controls.Add(this.btnDeleteCar);
            this.gbCar.Location = new System.Drawing.Point(13, 12);
            this.gbCar.Name = "gbCar";
            this.gbCar.Size = new System.Drawing.Size(101, 106);
            this.gbCar.TabIndex = 17;
            this.gbCar.TabStop = false;
            this.gbCar.Text = "Car Specifics";
            // 
            // gbRepairs
            // 
            this.gbRepairs.Controls.Add(this.btnAddRepair);
            this.gbRepairs.Controls.Add(this.btnEditRepair);
            this.gbRepairs.Controls.Add(this.btnDeleteRepair);
            this.gbRepairs.Location = new System.Drawing.Point(13, 124);
            this.gbRepairs.Name = "gbRepairs";
            this.gbRepairs.Size = new System.Drawing.Size(98, 106);
            this.gbRepairs.TabIndex = 18;
            this.gbRepairs.TabStop = false;
            this.gbRepairs.Text = "Repair Specifics";
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.btnAddUser);
            this.gbUser.Controls.Add(this.btnEditUser);
            this.gbUser.Controls.Add(this.btnDelete);
            this.gbUser.Location = new System.Drawing.Point(13, 236);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(98, 107);
            this.gbUser.TabIndex = 19;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "User Details";
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(129, 359);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.gbRepairs);
            this.Controls.Add(this.gbCar);
            this.Name = "Navigation";
            this.Text = "Navigation";
            this.gbCar.ResumeLayout(false);
            this.gbRepairs.ResumeLayout(false);
            this.gbUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRepair;
        private System.Windows.Forms.Button btnEditRepair;
        private System.Windows.Forms.Button btnAddRepair;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbCar;
        private System.Windows.Forms.GroupBox gbRepairs;
        private System.Windows.Forms.GroupBox gbUser;
    }
}