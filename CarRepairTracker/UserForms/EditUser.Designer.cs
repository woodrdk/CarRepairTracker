namespace CarRepairTracker.UserForms
{
    partial class EditUser
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblWhoToEdit = new System.Windows.Forms.Label();
            this.cbUserToEdit = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.gbNameEdit = new System.Windows.Forms.GroupBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbEdit.SuspendLayout();
            this.gbNameEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(231, 548);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(144, 548);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblWhoToEdit
            // 
            this.lblWhoToEdit.AutoSize = true;
            this.lblWhoToEdit.Location = new System.Drawing.Point(26, 30);
            this.lblWhoToEdit.Name = "lblWhoToEdit";
            this.lblWhoToEdit.Size = new System.Drawing.Size(127, 13);
            this.lblWhoToEdit.TabIndex = 4;
            this.lblWhoToEdit.Text = "Who do you wish to edit?";
            // 
            // cbUserToEdit
            // 
            this.cbUserToEdit.FormattingEnabled = true;
            this.cbUserToEdit.Location = new System.Drawing.Point(29, 57);
            this.cbUserToEdit.Name = "cbUserToEdit";
            this.cbUserToEdit.Size = new System.Drawing.Size(161, 21);
            this.cbUserToEdit.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(90, 37);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(90, 63);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.btnSelect);
            this.gbEdit.Controls.Add(this.cbUserToEdit);
            this.gbEdit.Controls.Add(this.lblWhoToEdit);
            this.gbEdit.Location = new System.Drawing.Point(12, 12);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(338, 121);
            this.gbEdit.TabIndex = 8;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Who to edit";
            // 
            // gbNameEdit
            // 
            this.gbNameEdit.Controls.Add(this.btnUpdate);
            this.gbNameEdit.Controls.Add(this.lblLastName);
            this.gbNameEdit.Controls.Add(this.lblFirstName);
            this.gbNameEdit.Controls.Add(this.txtFirstName);
            this.gbNameEdit.Controls.Add(this.txtLastName);
            this.gbNameEdit.Location = new System.Drawing.Point(12, 148);
            this.gbNameEdit.Name = "gbNameEdit";
            this.gbNameEdit.Size = new System.Drawing.Size(338, 140);
            this.gbNameEdit.TabIndex = 9;
            this.gbNameEdit.TabStop = false;
            this.gbNameEdit.Text = "Edit User";
            this.gbNameEdit.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(7, 37);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(7, 71);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last name";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(199, 88);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(199, 98);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 583);
            this.Controls.Add(this.gbNameEdit);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.gbNameEdit.ResumeLayout(false);
            this.gbNameEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblWhoToEdit;
        private System.Windows.Forms.ComboBox cbUserToEdit;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox gbNameEdit;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnUpdate;
    }
}