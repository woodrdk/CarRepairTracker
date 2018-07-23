namespace CarRepairTracker.UserForms
{
    partial class DeleteUser
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbUserToDelete = new System.Windows.Forms.ComboBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.pnlDeleteUserSuccess = new System.Windows.Forms.Panel();
            this.lblDeletedUserSuccess = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlWhoToDelete = new System.Windows.Forms.Panel();
            this.pnlDeleteUserSuccess.SuspendLayout();
            this.pnlWhoToDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(8, 52);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbUserToDelete
            // 
            this.cbUserToDelete.FormattingEnabled = true;
            this.cbUserToDelete.Location = new System.Drawing.Point(8, 25);
            this.cbUserToDelete.Name = "cbUserToDelete";
            this.cbUserToDelete.Size = new System.Drawing.Size(161, 21);
            this.cbUserToDelete.TabIndex = 4;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(84, 52);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(85, 23);
            this.btnDeleteUser.TabIndex = 5;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // pnlDeleteUserSuccess
            // 
            this.pnlDeleteUserSuccess.Controls.Add(this.lblDeletedUserSuccess);
            this.pnlDeleteUserSuccess.Controls.Add(this.btnClose);
            this.pnlDeleteUserSuccess.Location = new System.Drawing.Point(12, 137);
            this.pnlDeleteUserSuccess.Name = "pnlDeleteUserSuccess";
            this.pnlDeleteUserSuccess.Size = new System.Drawing.Size(365, 57);
            this.pnlDeleteUserSuccess.TabIndex = 6;
            this.pnlDeleteUserSuccess.Visible = false;
            // 
            // lblDeletedUserSuccess
            // 
            this.lblDeletedUserSuccess.AutoSize = true;
            this.lblDeletedUserSuccess.Location = new System.Drawing.Point(5, 13);
            this.lblDeletedUserSuccess.Name = "lblDeletedUserSuccess";
            this.lblDeletedUserSuccess.Size = new System.Drawing.Size(102, 13);
            this.lblDeletedUserSuccess.TabIndex = 1;
            this.lblDeletedUserSuccess.Text = "DELETE SUCCESS";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(287, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pnlWhoToDelete
            // 
            this.pnlWhoToDelete.Controls.Add(this.cbUserToDelete);
            this.pnlWhoToDelete.Controls.Add(this.btnCancel);
            this.pnlWhoToDelete.Controls.Add(this.btnDeleteUser);
            this.pnlWhoToDelete.Location = new System.Drawing.Point(12, 12);
            this.pnlWhoToDelete.Name = "pnlWhoToDelete";
            this.pnlWhoToDelete.Size = new System.Drawing.Size(200, 100);
            this.pnlWhoToDelete.TabIndex = 7;
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 362);
            this.Controls.Add(this.pnlWhoToDelete);
            this.Controls.Add(this.pnlDeleteUserSuccess);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.pnlDeleteUserSuccess.ResumeLayout(false);
            this.pnlDeleteUserSuccess.PerformLayout();
            this.pnlWhoToDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbUserToDelete;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Panel pnlDeleteUserSuccess;
        private System.Windows.Forms.Label lblDeletedUserSuccess;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlWhoToDelete;
    }
}