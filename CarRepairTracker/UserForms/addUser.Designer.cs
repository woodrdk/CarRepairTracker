namespace CarRepairTracker.UserForms
{
    partial class AddUser
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
            this.lblWhatIsYourName = new System.Windows.Forms.Label();
            this.btnAddUserName = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstTimeUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(76, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblWhatIsYourName
            // 
            this.lblWhatIsYourName.AutoSize = true;
            this.lblWhatIsYourName.Location = new System.Drawing.Point(27, 46);
            this.lblWhatIsYourName.Name = "lblWhatIsYourName";
            this.lblWhatIsYourName.Size = new System.Drawing.Size(121, 13);
            this.lblWhatIsYourName.TabIndex = 2;
            this.lblWhatIsYourName.Text = "Please enter your name:";
            // 
            // btnAddUserName
            // 
            this.btnAddUserName.Location = new System.Drawing.Point(76, 123);
            this.btnAddUserName.Name = "btnAddUserName";
            this.btnAddUserName.Size = new System.Drawing.Size(112, 23);
            this.btnAddUserName.TabIndex = 3;
            this.btnAddUserName.Text = "Add User Name";
            this.btnAddUserName.UseVisualStyleBackColor = true;
            this.btnAddUserName.Click += new System.EventHandler(this.BtnAddUserName_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(101, 71);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(87, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(101, 97);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(87, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(27, 74);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(60, 13);
            this.lblFirst.TabIndex = 6;
            this.lblFirst.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(26, 100);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstTimeUser
            // 
            this.lblFirstTimeUser.AutoSize = true;
            this.lblFirstTimeUser.Location = new System.Drawing.Point(47, 19);
            this.lblFirstTimeUser.Name = "lblFirstTimeUser";
            this.lblFirstTimeUser.Size = new System.Drawing.Size(119, 13);
            this.lblFirstTimeUser.TabIndex = 8;
            this.lblFirstTimeUser.Text = "Welcome first time user!";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 205);
            this.Controls.Add(this.lblFirstTimeUser);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnAddUserName);
            this.Controls.Add(this.lblWhatIsYourName);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddUser";
            this.Text = "Add User Name";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblWhatIsYourName;
        private System.Windows.Forms.Button btnAddUserName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstTimeUser;
    }
}