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
            this.pnlWho = new System.Windows.Forms.Panel();
            this.cbCarOfWho = new System.Windows.Forms.ComboBox();
            this.scDisplay = new System.Windows.Forms.SplitContainer();
            this.btnRepairHistory = new System.Windows.Forms.Button();
            this.lblWhoPicked = new System.Windows.Forms.Label();
            this.btnChangeCar = new System.Windows.Forms.Button();
            this.pnlWho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDisplay)).BeginInit();
            this.scDisplay.Panel1.SuspendLayout();
            this.scDisplay.Panel2.SuspendLayout();
            this.scDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbWho
            // 
            this.cbWho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWho.FormattingEnabled = true;
            this.cbWho.Location = new System.Drawing.Point(24, 49);
            this.cbWho.Name = "cbWho";
            this.cbWho.Size = new System.Drawing.Size(121, 21);
            this.cbWho.TabIndex = 0;
            this.cbWho.SelectedIndexChanged += new System.EventHandler(this.cbWho_SelectedIndexChanged);
            // 
            // lblWho
            // 
            this.lblWho.AutoSize = true;
            this.lblWho.Location = new System.Drawing.Point(21, 16);
            this.lblWho.Name = "lblWho";
            this.lblWho.Size = new System.Drawing.Size(261, 13);
            this.lblWho.TabIndex = 1;
            this.lblWho.Text = "Hello, Whose car do you wish to keep track of today?";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(203, 88);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlWho
            // 
            this.pnlWho.Controls.Add(this.cbCarOfWho);
            this.pnlWho.Controls.Add(this.lblWho);
            this.pnlWho.Controls.Add(this.btnSubmit);
            this.pnlWho.Controls.Add(this.cbWho);
            this.pnlWho.Location = new System.Drawing.Point(12, 12);
            this.pnlWho.Name = "pnlWho";
            this.pnlWho.Size = new System.Drawing.Size(298, 142);
            this.pnlWho.TabIndex = 3;
            // 
            // cbCarOfWho
            // 
            this.cbCarOfWho.FormattingEnabled = true;
            this.cbCarOfWho.Location = new System.Drawing.Point(24, 89);
            this.cbCarOfWho.Name = "cbCarOfWho";
            this.cbCarOfWho.Size = new System.Drawing.Size(121, 21);
            this.cbCarOfWho.TabIndex = 3;
            this.cbCarOfWho.SelectedIndexChanged += new System.EventHandler(this.lblCarOfWho_SelectedIndexChanged);
            // 
            // scDisplay
            // 
            this.scDisplay.Location = new System.Drawing.Point(12, 207);
            this.scDisplay.Name = "scDisplay";
            // 
            // scDisplay.Panel1
            // 
            this.scDisplay.Panel1.Controls.Add(this.btnChangeCar);
            this.scDisplay.Panel1.Controls.Add(this.btnRepairHistory);
            this.scDisplay.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // scDisplay.Panel2
            // 
            this.scDisplay.Panel2.Controls.Add(this.lblWhoPicked);
            this.scDisplay.Size = new System.Drawing.Size(462, 231);
            this.scDisplay.SplitterDistance = 126;
            this.scDisplay.TabIndex = 4;
            this.scDisplay.Visible = false;
            // 
            // btnRepairHistory
            // 
            this.btnRepairHistory.Location = new System.Drawing.Point(4, 4);
            this.btnRepairHistory.Name = "btnRepairHistory";
            this.btnRepairHistory.Size = new System.Drawing.Size(114, 23);
            this.btnRepairHistory.TabIndex = 0;
            this.btnRepairHistory.Text = "Repair History";
            this.btnRepairHistory.UseVisualStyleBackColor = true;
            this.btnRepairHistory.Click += new System.EventHandler(this.btnRepairHistory_Click);
            // 
            // lblWhoPicked
            // 
            this.lblWhoPicked.AutoSize = true;
            this.lblWhoPicked.Location = new System.Drawing.Point(3, 4);
            this.lblWhoPicked.Name = "lblWhoPicked";
            this.lblWhoPicked.Size = new System.Drawing.Size(114, 13);
            this.lblWhoPicked.TabIndex = 0;
            this.lblWhoPicked.Text = "place holder for design";
            // 
            // btnChangeCar
            // 
            this.btnChangeCar.Location = new System.Drawing.Point(4, 33);
            this.btnChangeCar.Name = "btnChangeCar";
            this.btnChangeCar.Size = new System.Drawing.Size(114, 23);
            this.btnChangeCar.TabIndex = 1;
            this.btnChangeCar.Text = "Change Car";
            this.btnChangeCar.UseVisualStyleBackColor = true;
            this.btnChangeCar.Click += new System.EventHandler(this.btnChangeCar_Click);
            // 
            // IntroWho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 462);
            this.Controls.Add(this.scDisplay);
            this.Controls.Add(this.pnlWho);
            this.Name = "IntroWho";
            this.Text = "IntroWho";
            this.Load += new System.EventHandler(this.IntroWho_Load);
            this.pnlWho.ResumeLayout(false);
            this.pnlWho.PerformLayout();
            this.scDisplay.Panel1.ResumeLayout(false);
            this.scDisplay.Panel2.ResumeLayout(false);
            this.scDisplay.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDisplay)).EndInit();
            this.scDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWho;
        private System.Windows.Forms.Label lblWho;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlWho;
        private System.Windows.Forms.ComboBox cbCarOfWho;
        private System.Windows.Forms.SplitContainer scDisplay;
        private System.Windows.Forms.Label lblWhoPicked;
        private System.Windows.Forms.Button btnRepairHistory;
        private System.Windows.Forms.Button btnChangeCar;
    }
}