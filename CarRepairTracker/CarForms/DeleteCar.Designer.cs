namespace CarRepairTracker
{
    partial class DeleteCar
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
            this.lblDeleteCar = new System.Windows.Forms.Label();
            this.cbCarDelete = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlDeleteCarSubmit = new System.Windows.Forms.Panel();
            this.pnlDeleteCarSuccess = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDeletedCarSuccess = new System.Windows.Forms.Label();
            this.pnlDeleteCarSubmit.SuspendLayout();
            this.pnlDeleteCarSuccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeleteCar
            // 
            this.lblDeleteCar.AutoSize = true;
            this.lblDeleteCar.Location = new System.Drawing.Point(6, 22);
            this.lblDeleteCar.Name = "lblDeleteCar";
            this.lblDeleteCar.Size = new System.Drawing.Size(176, 13);
            this.lblDeleteCar.TabIndex = 0;
            this.lblDeleteCar.Text = "Which car would you like to delete?";
            // 
            // cbCarDelete
            // 
            this.cbCarDelete.FormattingEnabled = true;
            this.cbCarDelete.Location = new System.Drawing.Point(188, 19);
            this.cbCarDelete.Name = "cbCarDelete";
            this.cbCarDelete.Size = new System.Drawing.Size(178, 21);
            this.cbCarDelete.TabIndex = 1;
            this.cbCarDelete.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(291, 63);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(9, 63);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlDeleteCarSubmit
            // 
            this.pnlDeleteCarSubmit.Controls.Add(this.btnSubmit);
            this.pnlDeleteCarSubmit.Controls.Add(this.btnCancel);
            this.pnlDeleteCarSubmit.Controls.Add(this.lblDeleteCar);
            this.pnlDeleteCarSubmit.Controls.Add(this.cbCarDelete);
            this.pnlDeleteCarSubmit.Location = new System.Drawing.Point(12, 12);
            this.pnlDeleteCarSubmit.Name = "pnlDeleteCarSubmit";
            this.pnlDeleteCarSubmit.Size = new System.Drawing.Size(369, 113);
            this.pnlDeleteCarSubmit.TabIndex = 4;
            // 
            // pnlDeleteCarSuccess
            // 
            this.pnlDeleteCarSuccess.Controls.Add(this.lblDeletedCarSuccess);
            this.pnlDeleteCarSuccess.Controls.Add(this.btnClose);
            this.pnlDeleteCarSuccess.Location = new System.Drawing.Point(21, 144);
            this.pnlDeleteCarSuccess.Name = "pnlDeleteCarSuccess";
            this.pnlDeleteCarSuccess.Size = new System.Drawing.Size(365, 57);
            this.pnlDeleteCarSuccess.TabIndex = 5;
            this.pnlDeleteCarSuccess.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(287, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDeletedCarSuccess
            // 
            this.lblDeletedCarSuccess.AutoSize = true;
            this.lblDeletedCarSuccess.Location = new System.Drawing.Point(5, 13);
            this.lblDeletedCarSuccess.Name = "lblDeletedCarSuccess";
            this.lblDeletedCarSuccess.Size = new System.Drawing.Size(102, 13);
            this.lblDeletedCarSuccess.TabIndex = 1;
            this.lblDeletedCarSuccess.Text = "DELETE SUCCESS";
            this.lblDeletedCarSuccess.Click += new System.EventHandler(this.lblDeletedCarSuccess_Click);
            // 
            // DeleteCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 224);
            this.Controls.Add(this.pnlDeleteCarSuccess);
            this.Controls.Add(this.pnlDeleteCarSubmit);
            this.Name = "DeleteCar";
            this.Text = "Delete Car";
            this.Load += new System.EventHandler(this.DeleteCar_Load);
            this.pnlDeleteCarSubmit.ResumeLayout(false);
            this.pnlDeleteCarSubmit.PerformLayout();
            this.pnlDeleteCarSuccess.ResumeLayout(false);
            this.pnlDeleteCarSuccess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteCar;
        private System.Windows.Forms.ComboBox cbCarDelete;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlDeleteCarSubmit;
        private System.Windows.Forms.Panel pnlDeleteCarSuccess;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDeletedCarSuccess;
    }
}