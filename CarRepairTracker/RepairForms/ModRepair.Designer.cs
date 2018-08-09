namespace CarRepairTracker
{
    partial class frmModRepair
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
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblPartNum = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPartCost = new System.Windows.Forms.Label();
            this.lblLaborCost = new System.Windows.Forms.Label();
            this.lblMisc = new System.Windows.Forms.Label();
            this.lblPartBrand = new System.Windows.Forms.Label();
            this.lblShop = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.txtPartNum = new System.Windows.Forms.TextBox();
            this.txtPartBrand = new System.Windows.Forms.TextBox();
            this.txtPartCost = new System.Windows.Forms.TextBox();
            this.txtLaborCost = new System.Windows.Forms.TextBox();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.dtpRepair = new System.Windows.Forms.DateTimePicker();
            this.lblCarSelected = new System.Windows.Forms.Label();
            this.cbCars = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewRepair = new System.Windows.Forms.Button();
            this.gbAddPart = new System.Windows.Forms.GroupBox();
            this.gbAddPart.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Location = new System.Drawing.Point(32, 29);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(57, 13);
            this.lblPartName.TabIndex = 0;
            this.lblPartName.Text = "Part Name";
            // 
            // lblPartNum
            // 
            this.lblPartNum.AutoSize = true;
            this.lblPartNum.Location = new System.Drawing.Point(32, 69);
            this.lblPartNum.Name = "lblPartNum";
            this.lblPartNum.Size = new System.Drawing.Size(36, 13);
            this.lblPartNum.TabIndex = 1;
            this.lblPartNum.Text = "Part #";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(158, 69);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblPartCost
            // 
            this.lblPartCost.AutoSize = true;
            this.lblPartCost.Location = new System.Drawing.Point(33, 148);
            this.lblPartCost.Name = "lblPartCost";
            this.lblPartCost.Size = new System.Drawing.Size(50, 13);
            this.lblPartCost.TabIndex = 3;
            this.lblPartCost.Text = "Part Cost";
            // 
            // lblLaborCost
            // 
            this.lblLaborCost.AutoSize = true;
            this.lblLaborCost.Location = new System.Drawing.Point(33, 230);
            this.lblLaborCost.Name = "lblLaborCost";
            this.lblLaborCost.Size = new System.Drawing.Size(58, 13);
            this.lblLaborCost.TabIndex = 4;
            this.lblLaborCost.Text = "Labor Cost";
            // 
            // lblMisc
            // 
            this.lblMisc.AutoSize = true;
            this.lblMisc.Location = new System.Drawing.Point(158, 195);
            this.lblMisc.Name = "lblMisc";
            this.lblMisc.Size = new System.Drawing.Size(35, 13);
            this.lblMisc.TabIndex = 5;
            this.lblMisc.Text = "Notes";
            // 
            // lblPartBrand
            // 
            this.lblPartBrand.AutoSize = true;
            this.lblPartBrand.Location = new System.Drawing.Point(33, 108);
            this.lblPartBrand.Name = "lblPartBrand";
            this.lblPartBrand.Size = new System.Drawing.Size(57, 13);
            this.lblPartBrand.TabIndex = 6;
            this.lblPartBrand.Text = "Part Brand";
            // 
            // lblShop
            // 
            this.lblShop.AutoSize = true;
            this.lblShop.Location = new System.Drawing.Point(33, 270);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(61, 13);
            this.lblShop.TabIndex = 7;
            this.lblShop.Text = "Shop name";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(158, 109);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(44, 13);
            this.lblMileage.TabIndex = 8;
            this.lblMileage.Text = "Mileage";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(158, 148);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(26, 13);
            this.lblQty.TabIndex = 9;
            this.lblQty.Text = "Qty.";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(161, 165);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(23, 20);
            this.txtQty.TabIndex = 10;
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(161, 211);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(200, 96);
            this.rtbNotes.TabIndex = 11;
            this.rtbNotes.Text = "";
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(161, 125);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(83, 20);
            this.txtMileage.TabIndex = 12;
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(33, 46);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(100, 20);
            this.txtPartName.TabIndex = 13;
            // 
            // txtPartNum
            // 
            this.txtPartNum.Location = new System.Drawing.Point(35, 85);
            this.txtPartNum.Name = "txtPartNum";
            this.txtPartNum.Size = new System.Drawing.Size(100, 20);
            this.txtPartNum.TabIndex = 14;
            // 
            // txtPartBrand
            // 
            this.txtPartBrand.Location = new System.Drawing.Point(36, 125);
            this.txtPartBrand.Name = "txtPartBrand";
            this.txtPartBrand.Size = new System.Drawing.Size(100, 20);
            this.txtPartBrand.TabIndex = 15;
            // 
            // txtPartCost
            // 
            this.txtPartCost.Location = new System.Drawing.Point(36, 165);
            this.txtPartCost.Name = "txtPartCost";
            this.txtPartCost.Size = new System.Drawing.Size(100, 20);
            this.txtPartCost.TabIndex = 16;
            // 
            // txtLaborCost
            // 
            this.txtLaborCost.Location = new System.Drawing.Point(36, 247);
            this.txtLaborCost.Name = "txtLaborCost";
            this.txtLaborCost.Size = new System.Drawing.Size(100, 20);
            this.txtLaborCost.TabIndex = 17;
            // 
            // txtShopName
            // 
            this.txtShopName.Location = new System.Drawing.Point(33, 287);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(100, 20);
            this.txtShopName.TabIndex = 18;
            // 
            // dtpRepair
            // 
            this.dtpRepair.Location = new System.Drawing.Point(161, 86);
            this.dtpRepair.Name = "dtpRepair";
            this.dtpRepair.Size = new System.Drawing.Size(200, 20);
            this.dtpRepair.TabIndex = 19;
            // 
            // lblCarSelected
            // 
            this.lblCarSelected.AutoSize = true;
            this.lblCarSelected.Location = new System.Drawing.Point(158, 53);
            this.lblCarSelected.Name = "lblCarSelected";
            this.lblCarSelected.Size = new System.Drawing.Size(68, 13);
            this.lblCarSelected.TabIndex = 20;
            this.lblCarSelected.Text = "Car Selected";
            // 
            // cbCars
            // 
            this.cbCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCars.FormattingEnabled = true;
            this.cbCars.Location = new System.Drawing.Point(232, 45);
            this.cbCars.Name = "cbCars";
            this.cbCars.Size = new System.Drawing.Size(121, 21);
            this.cbCars.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(9, 396);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(33, 323);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(126, 323);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 23);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add Part To Repair";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(36, 203);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCost.TabIndex = 25;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(33, 188);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(75, 13);
            this.lblTotalCost.TabIndex = 26;
            this.lblTotalCost.Text = "Total part cost";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(248, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save Repair";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSame_Click);
            // 
            // btnNewRepair
            // 
            this.btnNewRepair.Location = new System.Drawing.Point(311, 396);
            this.btnNewRepair.Name = "btnNewRepair";
            this.btnNewRepair.Size = new System.Drawing.Size(75, 23);
            this.btnNewRepair.TabIndex = 29;
            this.btnNewRepair.Text = "New Repair";
            this.btnNewRepair.UseVisualStyleBackColor = true;
            this.btnNewRepair.Click += new System.EventHandler(this.btnNewRepair_Click);
            // 
            // gbAddPart
            // 
            this.gbAddPart.Controls.Add(this.btnClear);
            this.gbAddPart.Controls.Add(this.lblPartName);
            this.gbAddPart.Controls.Add(this.btnSave);
            this.gbAddPart.Controls.Add(this.lblPartNum);
            this.gbAddPart.Controls.Add(this.lblDate);
            this.gbAddPart.Controls.Add(this.lblTotalCost);
            this.gbAddPart.Controls.Add(this.lblPartCost);
            this.gbAddPart.Controls.Add(this.txtTotalCost);
            this.gbAddPart.Controls.Add(this.lblLaborCost);
            this.gbAddPart.Controls.Add(this.btnAdd);
            this.gbAddPart.Controls.Add(this.lblMisc);
            this.gbAddPart.Controls.Add(this.lblPartBrand);
            this.gbAddPart.Controls.Add(this.lblShop);
            this.gbAddPart.Controls.Add(this.cbCars);
            this.gbAddPart.Controls.Add(this.lblMileage);
            this.gbAddPart.Controls.Add(this.lblCarSelected);
            this.gbAddPart.Controls.Add(this.lblQty);
            this.gbAddPart.Controls.Add(this.dtpRepair);
            this.gbAddPart.Controls.Add(this.txtQty);
            this.gbAddPart.Controls.Add(this.txtShopName);
            this.gbAddPart.Controls.Add(this.rtbNotes);
            this.gbAddPart.Controls.Add(this.txtLaborCost);
            this.gbAddPart.Controls.Add(this.txtMileage);
            this.gbAddPart.Controls.Add(this.txtPartCost);
            this.gbAddPart.Controls.Add(this.txtPartName);
            this.gbAddPart.Controls.Add(this.txtPartBrand);
            this.gbAddPart.Controls.Add(this.txtPartNum);
            this.gbAddPart.Location = new System.Drawing.Point(12, 12);
            this.gbAddPart.Name = "gbAddPart";
            this.gbAddPart.Size = new System.Drawing.Size(377, 362);
            this.gbAddPart.TabIndex = 30;
            this.gbAddPart.TabStop = false;
            this.gbAddPart.Text = "Add Details";
            // 
            // frmModRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 440);
            this.Controls.Add(this.gbAddPart);
            this.Controls.Add(this.btnNewRepair);
            this.Controls.Add(this.btnClose);
            this.Name = "frmModRepair";
            this.Text = "Modification / Repair";
            this.Load += new System.EventHandler(this.frmModRepair_Load);
            this.gbAddPart.ResumeLayout(false);
            this.gbAddPart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.Label lblPartNum;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPartCost;
        private System.Windows.Forms.Label lblLaborCost;
        private System.Windows.Forms.Label lblMisc;
        private System.Windows.Forms.Label lblPartBrand;
        private System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.TextBox txtPartNum;
        private System.Windows.Forms.TextBox txtPartBrand;
        private System.Windows.Forms.TextBox txtPartCost;
        private System.Windows.Forms.TextBox txtLaborCost;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.DateTimePicker dtpRepair;
        private System.Windows.Forms.Label lblCarSelected;
        private System.Windows.Forms.ComboBox cbCars;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewRepair;
        private System.Windows.Forms.GroupBox gbAddPart;
    }
}