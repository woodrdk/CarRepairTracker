namespace CarRepairTracker
{
    partial class IntroWho
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
            this.cbWho = new System.Windows.Forms.ComboBox();
            this.lblWho = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbWho
            // 
            this.cbWho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWho.FormattingEnabled = true;
            this.cbWho.Location = new System.Drawing.Point(117, 107);
            this.cbWho.Name = "cbWho";
            this.cbWho.Size = new System.Drawing.Size(121, 21);
            this.cbWho.TabIndex = 0;
            this.cbWho.SelectedIndexChanged += new System.EventHandler(this.cbWho_SelectedIndexChanged);
            // 
            // lblWho
            // 
            this.lblWho.AutoSize = true;
            this.lblWho.Location = new System.Drawing.Point(114, 74);
            this.lblWho.Name = "lblWho";
            this.lblWho.Size = new System.Drawing.Size(257, 13);
            this.lblWho.TabIndex = 1;
            this.lblWho.Text = "Hello, Who\'s car do you wish to keep track of today?";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(296, 107);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // IntroWho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblWho);
            this.Controls.Add(this.cbWho);
            this.Name = "IntroWho";
            this.Text = "IntroWho";
            this.Load += new System.EventHandler(this.IntroWho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWho;
        private System.Windows.Forms.Label lblWho;
        private System.Windows.Forms.Button btnSubmit;
    }
}