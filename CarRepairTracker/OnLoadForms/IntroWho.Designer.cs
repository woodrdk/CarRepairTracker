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
            this.scDisplay = new System.Windows.Forms.SplitContainer();
            this.btnChangeCar = new System.Windows.Forms.Button();
            this.btnRepairHistory = new System.Windows.Forms.Button();
            this.lblWhoPicked = new System.Windows.Forms.Label();
            this.cbCarOfWho = new System.Windows.Forms.ComboBox();
            this.pnlWhichCar = new System.Windows.Forms.Panel();
            this.btnWhichCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlWho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDisplay)).BeginInit();
            this.scDisplay.Panel1.SuspendLayout();
            this.scDisplay.Panel2.SuspendLayout();
            this.scDisplay.SuspendLayout();
            this.pnlWhichCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbWho
            // 
            this.cbWho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWho.FormattingEnabled = true;
            this.cbWho.Location = new System.Drawing.Point(82, 10);
            this.cbWho.Name = "cbWho";
            this.cbWho.Size = new System.Drawing.Size(121, 21);
            this.cbWho.TabIndex = 0;
            this.cbWho.SelectedIndexChanged += new System.EventHandler(this.CbWho_SelectedIndexChanged);
            // 
            // lblWho
            // 
            this.lblWho.AutoSize = true;
            this.lblWho.Location = new System.Drawing.Point(5, 13);
            this.lblWho.Name = "lblWho";
            this.lblWho.Size = new System.Drawing.Size(71, 13);
            this.lblWho.TabIndex = 1;
            this.lblWho.Text = "Choose User:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(128, 37);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // pnlWho
            // 
            this.pnlWho.Controls.Add(this.lblWho);
            this.pnlWho.Controls.Add(this.btnSubmit);
            this.pnlWho.Controls.Add(this.cbWho);
            this.pnlWho.Location = new System.Drawing.Point(12, 12);
            this.pnlWho.Name = "pnlWho";
            this.pnlWho.Size = new System.Drawing.Size(215, 74);
            this.pnlWho.TabIndex = 3;
            // 
            // scDisplay
            // 
            this.scDisplay.Location = new System.Drawing.Point(12, 92);
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
            this.scDisplay.Size = new System.Drawing.Size(421, 231);
            this.scDisplay.SplitterDistance = 114;
            this.scDisplay.TabIndex = 4;
            this.scDisplay.Visible = false;
            // 
            // btnChangeCar
            // 
            this.btnChangeCar.Location = new System.Drawing.Point(4, 33);
            this.btnChangeCar.Name = "btnChangeCar";
            this.btnChangeCar.Size = new System.Drawing.Size(114, 23);
            this.btnChangeCar.TabIndex = 1;
            this.btnChangeCar.Text = "Change Car";
            this.btnChangeCar.UseVisualStyleBackColor = true;
            this.btnChangeCar.Click += new System.EventHandler(this.BtnChangeCar_Click);
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
            this.lblWhoPicked.Location = new System.Drawing.Point(7, 4);
            this.lblWhoPicked.Name = "lblWhoPicked";
            this.lblWhoPicked.Size = new System.Drawing.Size(114, 13);
            this.lblWhoPicked.TabIndex = 0;
            this.lblWhoPicked.Text = "place holder for design";
            // 
            // cbCarOfWho
            // 
            this.cbCarOfWho.FormattingEnabled = true;
            this.cbCarOfWho.Location = new System.Drawing.Point(68, 10);
            this.cbCarOfWho.Name = "cbCarOfWho";
            this.cbCarOfWho.Size = new System.Drawing.Size(121, 21);
            this.cbCarOfWho.TabIndex = 5;
            // 
            // pnlWhichCar
            // 
            this.pnlWhichCar.Controls.Add(this.btnWhichCar);
            this.pnlWhichCar.Controls.Add(this.label1);
            this.pnlWhichCar.Controls.Add(this.cbCarOfWho);
            this.pnlWhichCar.Location = new System.Drawing.Point(233, 12);
            this.pnlWhichCar.Name = "pnlWhichCar";
            this.pnlWhichCar.Size = new System.Drawing.Size(200, 74);
            this.pnlWhichCar.TabIndex = 4;
            this.pnlWhichCar.Visible = false;
            // 
            // btnWhichCar
            // 
            this.btnWhichCar.Location = new System.Drawing.Point(114, 37);
            this.btnWhichCar.Name = "btnWhichCar";
            this.btnWhichCar.Size = new System.Drawing.Size(75, 23);
            this.btnWhichCar.TabIndex = 6;
            this.btnWhichCar.Text = "Submit";
            this.btnWhichCar.UseVisualStyleBackColor = true;
            this.btnWhichCar.Click += new System.EventHandler(this.BtnWhichCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Car:";
            // 
            // IntroWho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 335);
            this.Controls.Add(this.pnlWhichCar);
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
            this.pnlWhichCar.ResumeLayout(false);
            this.pnlWhichCar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWho;
        private System.Windows.Forms.Label lblWho;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlWho;
        private System.Windows.Forms.SplitContainer scDisplay;
        private System.Windows.Forms.Label lblWhoPicked;
        private System.Windows.Forms.Button btnRepairHistory;
        private System.Windows.Forms.Button btnChangeCar;
        private System.Windows.Forms.ComboBox cbCarOfWho;
        private System.Windows.Forms.Panel pnlWhichCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWhichCar;
    }
}