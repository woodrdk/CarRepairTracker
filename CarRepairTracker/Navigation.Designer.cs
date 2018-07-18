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
            this.SuspendLayout();
            // 
            // btnDeleteRepair
            // 
            this.btnDeleteRepair.Location = new System.Drawing.Point(12, 184);
            this.btnDeleteRepair.Name = "btnDeleteRepair";
            this.btnDeleteRepair.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRepair.TabIndex = 13;
            this.btnDeleteRepair.Text = "Delete Repair";
            this.btnDeleteRepair.UseVisualStyleBackColor = true;
            // 
            // btnEditRepair
            // 
            this.btnEditRepair.Location = new System.Drawing.Point(13, 154);
            this.btnEditRepair.Name = "btnEditRepair";
            this.btnEditRepair.Size = new System.Drawing.Size(75, 23);
            this.btnEditRepair.TabIndex = 12;
            this.btnEditRepair.Text = "Edit Repair";
            this.btnEditRepair.UseVisualStyleBackColor = true;
            // 
            // btnAddRepair
            // 
            this.btnAddRepair.Location = new System.Drawing.Point(12, 124);
            this.btnAddRepair.Name = "btnAddRepair";
            this.btnAddRepair.Size = new System.Drawing.Size(75, 23);
            this.btnAddRepair.TabIndex = 11;
            this.btnAddRepair.Text = "Add Repair";
            this.btnAddRepair.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(12, 70);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCar.TabIndex = 10;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            // 
            // btnEditCar
            // 
            this.btnEditCar.Location = new System.Drawing.Point(12, 41);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(75, 23);
            this.btnEditCar.TabIndex = 9;
            this.btnEditCar.Text = "Edit Car";
            this.btnEditCar.UseVisualStyleBackColor = true;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(12, 12);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnAddCar.TabIndex = 8;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 307);
            this.Controls.Add(this.btnDeleteRepair);
            this.Controls.Add(this.btnEditRepair);
            this.Controls.Add(this.btnAddRepair);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnAddCar);
            this.Name = "Navigation";
            this.Text = "Navigation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRepair;
        private System.Windows.Forms.Button btnEditRepair;
        private System.Windows.Forms.Button btnAddRepair;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnAddCar;
    }
}