namespace CarRepairTracker
{
    partial class frmCarSelection
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
            this.tcVehicleData = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbIdentifications = new System.Windows.Forms.GroupBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.rtbUnique = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.txtCarNameIdentifier = new System.Windows.Forms.TextBox();
            this.lbltxtCarNameIdentifier = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMake = new System.Windows.Forms.ComboBox();
            this.lblEngine = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblTrim = new System.Windows.Forms.Label();
            this.cbEngine = new System.Windows.Forms.ComboBox();
            this.cbTrim = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTireSize = new System.Windows.Forms.TextBox();
            this.txtHeadlight = new System.Windows.Forms.TextBox();
            this.lblTireSize = new System.Windows.Forms.Label();
            this.lblHeadlight = new System.Windows.Forms.Label();
            this.txtSparkPlugs = new System.Windows.Forms.TextBox();
            this.txtAirFilter = new System.Windows.Forms.TextBox();
            this.txtOilFilter = new System.Windows.Forms.TextBox();
            this.txtOilGrade = new System.Windows.Forms.TextBox();
            this.lblSparkPlugs = new System.Windows.Forms.Label();
            this.lblAirFilter = new System.Windows.Forms.Label();
            this.lblOilFilter = new System.Windows.Forms.Label();
            this.lblOil = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbPurchaseDetails = new System.Windows.Forms.GroupBox();
            this.lblExpMileage = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.txtWarrMileage = new System.Windows.Forms.TextBox();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.cbWarranty = new System.Windows.Forms.CheckBox();
            this.lblPurchaseMileage = new System.Windows.Forms.Label();
            this.txtPurchaseMileage = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.datePurchase = new System.Windows.Forms.DateTimePicker();
            this.lblPurchased = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpWarrExp = new System.Windows.Forms.DateTimePicker();
            this.tcVehicleData.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbIdentifications.SuspendLayout();
            this.gbGeneral.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbPurchaseDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcVehicleData
            // 
            this.tcVehicleData.Controls.Add(this.tabPage1);
            this.tcVehicleData.Controls.Add(this.tabPage2);
            this.tcVehicleData.Controls.Add(this.tabPage3);
            this.tcVehicleData.Location = new System.Drawing.Point(12, 12);
            this.tcVehicleData.Name = "tcVehicleData";
            this.tcVehicleData.SelectedIndex = 0;
            this.tcVehicleData.Size = new System.Drawing.Size(626, 375);
            this.tcVehicleData.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbIdentifications);
            this.tabPage1.Controls.Add(this.gbGeneral);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbIdentifications
            // 
            this.gbIdentifications.Controls.Add(this.txtColor);
            this.gbIdentifications.Controls.Add(this.txtState);
            this.gbIdentifications.Controls.Add(this.txtPlate);
            this.gbIdentifications.Controls.Add(this.txtVin);
            this.gbIdentifications.Controls.Add(this.rtbUnique);
            this.gbIdentifications.Controls.Add(this.label5);
            this.gbIdentifications.Controls.Add(this.label4);
            this.gbIdentifications.Controls.Add(this.label3);
            this.gbIdentifications.Controls.Add(this.label2);
            this.gbIdentifications.Controls.Add(this.label1);
            this.gbIdentifications.Location = new System.Drawing.Point(272, 25);
            this.gbIdentifications.Name = "gbIdentifications";
            this.gbIdentifications.Size = new System.Drawing.Size(200, 256);
            this.gbIdentifications.TabIndex = 23;
            this.gbIdentifications.TabStop = false;
            this.gbIdentifications.Text = "Identification";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(64, 103);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 9;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(64, 73);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 8;
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(64, 49);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(100, 20);
            this.txtPlate.TabIndex = 7;
            // 
            // txtVin
            // 
            this.txtVin.Location = new System.Drawing.Point(64, 27);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(100, 20);
            this.txtVin.TabIndex = 6;
            // 
            // rtbUnique
            // 
            this.rtbUnique.Location = new System.Drawing.Point(19, 160);
            this.rtbUnique.Name = "rtbUnique";
            this.rtbUnique.Size = new System.Drawing.Size(161, 79);
            this.rtbUnique.TabIndex = 5;
            this.rtbUnique.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unique Identifiers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plate #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vin #";
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.txtCarNameIdentifier);
            this.gbGeneral.Controls.Add(this.lbltxtCarNameIdentifier);
            this.gbGeneral.Controls.Add(this.cbYear);
            this.gbGeneral.Controls.Add(this.cbMake);
            this.gbGeneral.Controls.Add(this.lblEngine);
            this.gbGeneral.Controls.Add(this.lblYear);
            this.gbGeneral.Controls.Add(this.cbModel);
            this.gbGeneral.Controls.Add(this.lblMake);
            this.gbGeneral.Controls.Add(this.lblTrim);
            this.gbGeneral.Controls.Add(this.cbEngine);
            this.gbGeneral.Controls.Add(this.cbTrim);
            this.gbGeneral.Controls.Add(this.lblModel);
            this.gbGeneral.Location = new System.Drawing.Point(20, 25);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(221, 256);
            this.gbGeneral.TabIndex = 22;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "General";
            // 
            // txtCarNameIdentifier
            // 
            this.txtCarNameIdentifier.Location = new System.Drawing.Point(16, 181);
            this.txtCarNameIdentifier.Name = "txtCarNameIdentifier";
            this.txtCarNameIdentifier.Size = new System.Drawing.Size(171, 20);
            this.txtCarNameIdentifier.TabIndex = 11;
            // 
            // lbltxtCarNameIdentifier
            // 
            this.lbltxtCarNameIdentifier.AutoSize = true;
            this.lbltxtCarNameIdentifier.Location = new System.Drawing.Point(13, 165);
            this.lbltxtCarNameIdentifier.Name = "lbltxtCarNameIdentifier";
            this.lbltxtCarNameIdentifier.Size = new System.Drawing.Size(112, 13);
            this.lbltxtCarNameIdentifier.TabIndex = 10;
            this.lbltxtCarNameIdentifier.Text = "Car name  description:";
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(66, 27);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 21);
            this.cbYear.TabIndex = 12;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged_1);
            // 
            // cbMake
            // 
            this.cbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMake.FormattingEnabled = true;
            this.cbMake.Location = new System.Drawing.Point(66, 54);
            this.cbMake.Name = "cbMake";
            this.cbMake.Size = new System.Drawing.Size(121, 21);
            this.cbMake.TabIndex = 18;
            this.cbMake.SelectedIndexChanged += new System.EventHandler(this.cbMake_SelectedIndexChanged);
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Location = new System.Drawing.Point(13, 138);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(40, 13);
            this.lblEngine.TabIndex = 17;
            this.lblEngine.Text = "Engine";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(13, 30);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Year";
            // 
            // cbModel
            // 
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(66, 81);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(121, 21);
            this.cbModel.TabIndex = 19;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(13, 57);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 14;
            this.lblMake.Text = "Make";
            // 
            // lblTrim
            // 
            this.lblTrim.AutoSize = true;
            this.lblTrim.Location = new System.Drawing.Point(13, 111);
            this.lblTrim.Name = "lblTrim";
            this.lblTrim.Size = new System.Drawing.Size(27, 13);
            this.lblTrim.TabIndex = 16;
            this.lblTrim.Text = "Trim";
            // 
            // cbEngine
            // 
            this.cbEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEngine.FormattingEnabled = true;
            this.cbEngine.Location = new System.Drawing.Point(66, 135);
            this.cbEngine.Name = "cbEngine";
            this.cbEngine.Size = new System.Drawing.Size(121, 21);
            this.cbEngine.TabIndex = 21;
            this.cbEngine.SelectedIndexChanged += new System.EventHandler(this.cbEngine_SelectedIndexChanged);
            // 
            // cbTrim
            // 
            this.cbTrim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrim.FormattingEnabled = true;
            this.cbTrim.Location = new System.Drawing.Point(66, 108);
            this.cbTrim.Name = "cbTrim";
            this.cbTrim.Size = new System.Drawing.Size(121, 21);
            this.cbTrim.TabIndex = 20;
            this.cbTrim.SelectedIndexChanged += new System.EventHandler(this.cbTrim_SelectedIndexChanged);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(13, 84);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 15;
            this.lblModel.Text = "Model";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTireSize);
            this.tabPage2.Controls.Add(this.txtHeadlight);
            this.tabPage2.Controls.Add(this.lblTireSize);
            this.tabPage2.Controls.Add(this.lblHeadlight);
            this.tabPage2.Controls.Add(this.txtSparkPlugs);
            this.tabPage2.Controls.Add(this.txtAirFilter);
            this.tabPage2.Controls.Add(this.txtOilFilter);
            this.tabPage2.Controls.Add(this.txtOilGrade);
            this.tabPage2.Controls.Add(this.lblSparkPlugs);
            this.tabPage2.Controls.Add(this.lblAirFilter);
            this.tabPage2.Controls.Add(this.lblOilFilter);
            this.tabPage2.Controls.Add(this.lblOil);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Specifications";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTireSize
            // 
            this.txtTireSize.Location = new System.Drawing.Point(85, 140);
            this.txtTireSize.Name = "txtTireSize";
            this.txtTireSize.Size = new System.Drawing.Size(100, 20);
            this.txtTireSize.TabIndex = 13;
            // 
            // txtHeadlight
            // 
            this.txtHeadlight.Location = new System.Drawing.Point(85, 115);
            this.txtHeadlight.Name = "txtHeadlight";
            this.txtHeadlight.Size = new System.Drawing.Size(100, 20);
            this.txtHeadlight.TabIndex = 12;
            // 
            // lblTireSize
            // 
            this.lblTireSize.AutoSize = true;
            this.lblTireSize.Location = new System.Drawing.Point(7, 139);
            this.lblTireSize.Name = "lblTireSize";
            this.lblTireSize.Size = new System.Drawing.Size(48, 13);
            this.lblTireSize.TabIndex = 9;
            this.lblTireSize.Text = "Tire Size";
            // 
            // lblHeadlight
            // 
            this.lblHeadlight.AutoSize = true;
            this.lblHeadlight.Location = new System.Drawing.Point(7, 122);
            this.lblHeadlight.Name = "lblHeadlight";
            this.lblHeadlight.Size = new System.Drawing.Size(75, 13);
            this.lblHeadlight.TabIndex = 8;
            this.lblHeadlight.Text = "Headlight bulb";
            // 
            // txtSparkPlugs
            // 
            this.txtSparkPlugs.Location = new System.Drawing.Point(85, 89);
            this.txtSparkPlugs.Name = "txtSparkPlugs";
            this.txtSparkPlugs.Size = new System.Drawing.Size(100, 20);
            this.txtSparkPlugs.TabIndex = 7;
            // 
            // txtAirFilter
            // 
            this.txtAirFilter.Location = new System.Drawing.Point(85, 68);
            this.txtAirFilter.Name = "txtAirFilter";
            this.txtAirFilter.Size = new System.Drawing.Size(100, 20);
            this.txtAirFilter.TabIndex = 6;
            // 
            // txtOilFilter
            // 
            this.txtOilFilter.Location = new System.Drawing.Point(86, 46);
            this.txtOilFilter.Name = "txtOilFilter";
            this.txtOilFilter.Size = new System.Drawing.Size(100, 20);
            this.txtOilFilter.TabIndex = 5;
            // 
            // txtOilGrade
            // 
            this.txtOilGrade.Location = new System.Drawing.Point(86, 21);
            this.txtOilGrade.Name = "txtOilGrade";
            this.txtOilGrade.Size = new System.Drawing.Size(100, 20);
            this.txtOilGrade.TabIndex = 4;
            // 
            // lblSparkPlugs
            // 
            this.lblSparkPlugs.AutoSize = true;
            this.lblSparkPlugs.Location = new System.Drawing.Point(7, 97);
            this.lblSparkPlugs.Name = "lblSparkPlugs";
            this.lblSparkPlugs.Size = new System.Drawing.Size(64, 13);
            this.lblSparkPlugs.TabIndex = 3;
            this.lblSparkPlugs.Text = "Spark Plugs";
            this.lblSparkPlugs.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblAirFilter
            // 
            this.lblAirFilter.AutoSize = true;
            this.lblAirFilter.Location = new System.Drawing.Point(6, 68);
            this.lblAirFilter.Name = "lblAirFilter";
            this.lblAirFilter.Size = new System.Drawing.Size(44, 13);
            this.lblAirFilter.TabIndex = 2;
            this.lblAirFilter.Text = "Air Filter";
            // 
            // lblOilFilter
            // 
            this.lblOilFilter.AutoSize = true;
            this.lblOilFilter.Location = new System.Drawing.Point(7, 46);
            this.lblOilFilter.Name = "lblOilFilter";
            this.lblOilFilter.Size = new System.Drawing.Size(44, 13);
            this.lblOilFilter.TabIndex = 1;
            this.lblOilFilter.Text = "Oil Filter";
            // 
            // lblOil
            // 
            this.lblOil.AutoSize = true;
            this.lblOil.Location = new System.Drawing.Point(7, 24);
            this.lblOil.Name = "lblOil";
            this.lblOil.Size = new System.Drawing.Size(51, 13);
            this.lblOil.TabIndex = 0;
            this.lblOil.Text = "Oil Grade";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbPurchaseDetails);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(618, 349);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Purchase Details";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbPurchaseDetails
            // 
            this.gbPurchaseDetails.Controls.Add(this.dtpWarrExp);
            this.gbPurchaseDetails.Controls.Add(this.lblExpMileage);
            this.gbPurchaseDetails.Controls.Add(this.lblExpDate);
            this.gbPurchaseDetails.Controls.Add(this.txtWarrMileage);
            this.gbPurchaseDetails.Controls.Add(this.lblWarranty);
            this.gbPurchaseDetails.Controls.Add(this.cbWarranty);
            this.gbPurchaseDetails.Controls.Add(this.lblPurchaseMileage);
            this.gbPurchaseDetails.Controls.Add(this.txtPurchaseMileage);
            this.gbPurchaseDetails.Controls.Add(this.txtPurchasePrice);
            this.gbPurchaseDetails.Controls.Add(this.lblPurchasePrice);
            this.gbPurchaseDetails.Controls.Add(this.lblPurchaseDate);
            this.gbPurchaseDetails.Controls.Add(this.datePurchase);
            this.gbPurchaseDetails.Controls.Add(this.lblPurchased);
            this.gbPurchaseDetails.Controls.Add(this.lblComments);
            this.gbPurchaseDetails.Controls.Add(this.txtComments);
            this.gbPurchaseDetails.Location = new System.Drawing.Point(27, 23);
            this.gbPurchaseDetails.Name = "gbPurchaseDetails";
            this.gbPurchaseDetails.Size = new System.Drawing.Size(533, 298);
            this.gbPurchaseDetails.TabIndex = 0;
            this.gbPurchaseDetails.TabStop = false;
            this.gbPurchaseDetails.Text = "Purchase Details";
            // 
            // lblExpMileage
            // 
            this.lblExpMileage.AutoSize = true;
            this.lblExpMileage.Location = new System.Drawing.Point(371, 190);
            this.lblExpMileage.Name = "lblExpMileage";
            this.lblExpMileage.Size = new System.Drawing.Size(93, 13);
            this.lblExpMileage.TabIndex = 31;
            this.lblExpMileage.Text = "Expiration Mileage";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(39, 222);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(79, 13);
            this.lblExpDate.TabIndex = 30;
            this.lblExpDate.Text = "Expiration Date";
            // 
            // txtWarrMileage
            // 
            this.txtWarrMileage.Location = new System.Drawing.Point(411, 222);
            this.txtWarrMileage.Name = "txtWarrMileage";
            this.txtWarrMileage.Size = new System.Drawing.Size(100, 20);
            this.txtWarrMileage.TabIndex = 29;
            // 
            // lblWarranty
            // 
            this.lblWarranty.AutoSize = true;
            this.lblWarranty.Location = new System.Drawing.Point(3, 190);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(56, 13);
            this.lblWarranty.TabIndex = 26;
            this.lblWarranty.Text = "Warranty?";
            // 
            // cbWarranty
            // 
            this.cbWarranty.AutoSize = true;
            this.cbWarranty.Location = new System.Drawing.Point(63, 186);
            this.cbWarranty.Name = "cbWarranty";
            this.cbWarranty.Size = new System.Drawing.Size(80, 17);
            this.cbWarranty.TabIndex = 25;
            this.cbWarranty.Text = "checkBox1";
            this.cbWarranty.UseVisualStyleBackColor = true;
            this.cbWarranty.CheckedChanged += new System.EventHandler(this.cbWarranty_CheckedChanged);
            // 
            // lblPurchaseMileage
            // 
            this.lblPurchaseMileage.AutoSize = true;
            this.lblPurchaseMileage.Location = new System.Drawing.Point(7, 137);
            this.lblPurchaseMileage.Name = "lblPurchaseMileage";
            this.lblPurchaseMileage.Size = new System.Drawing.Size(92, 13);
            this.lblPurchaseMileage.TabIndex = 24;
            this.lblPurchaseMileage.Text = "Purchase Mileage";
            // 
            // txtPurchaseMileage
            // 
            this.txtPurchaseMileage.Location = new System.Drawing.Point(124, 142);
            this.txtPurchaseMileage.Name = "txtPurchaseMileage";
            this.txtPurchaseMileage.Size = new System.Drawing.Size(100, 20);
            this.txtPurchaseMileage.TabIndex = 23;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(111, 106);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(100, 20);
            this.txtPurchasePrice.TabIndex = 22;
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(7, 106);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(79, 13);
            this.lblPurchasePrice.TabIndex = 21;
            this.lblPurchasePrice.Text = "Purchase Price";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(7, 63);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(78, 13);
            this.lblPurchaseDate.TabIndex = 20;
            this.lblPurchaseDate.Text = "Purchase Date";
            // 
            // datePurchase
            // 
            this.datePurchase.Location = new System.Drawing.Point(111, 57);
            this.datePurchase.Name = "datePurchase";
            this.datePurchase.Size = new System.Drawing.Size(200, 20);
            this.datePurchase.TabIndex = 19;
            // 
            // lblPurchased
            // 
            this.lblPurchased.AutoSize = true;
            this.lblPurchased.Location = new System.Drawing.Point(7, 37);
            this.lblPurchased.Name = "lblPurchased";
            this.lblPurchased.Size = new System.Drawing.Size(95, 13);
            this.lblPurchased.TabIndex = 18;
            this.lblPurchased.Text = "Purchase location:";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(7, 275);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(56, 13);
            this.lblComments.TabIndex = 17;
            this.lblComments.Text = "Comments";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(86, 272);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(440, 20);
            this.txtComments.TabIndex = 16;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(559, 393);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(478, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpWarrExp
            // 
            this.dtpWarrExp.Location = new System.Drawing.Point(124, 222);
            this.dtpWarrExp.Name = "dtpWarrExp";
            this.dtpWarrExp.Size = new System.Drawing.Size(200, 20);
            this.dtpWarrExp.TabIndex = 32;
            // 
            // frmCarSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 431);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tcVehicleData);
            this.Name = "frmCarSelection";
            this.Text = "Add Car";
            this.Load += new System.EventHandler(this.frmCarSelection_Load);
            this.tcVehicleData.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbIdentifications.ResumeLayout(false);
            this.gbIdentifications.PerformLayout();
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.gbPurchaseDetails.ResumeLayout(false);
            this.gbPurchaseDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcVehicleData;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.ComboBox cbEngine;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cbTrim;
        private System.Windows.Forms.Label lblTrim;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.ComboBox cbMake;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gbIdentifications;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.RichTextBox rtbUnique;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.Label lblSparkPlugs;
        private System.Windows.Forms.Label lblAirFilter;
        private System.Windows.Forms.Label lblOilFilter;
        private System.Windows.Forms.Label lblOil;
        private System.Windows.Forms.TextBox txtTireSize;
        private System.Windows.Forms.TextBox txtHeadlight;
        private System.Windows.Forms.Label lblTireSize;
        private System.Windows.Forms.Label lblHeadlight;
        private System.Windows.Forms.TextBox txtSparkPlugs;
        private System.Windows.Forms.TextBox txtAirFilter;
        private System.Windows.Forms.TextBox txtOilFilter;
        private System.Windows.Forms.TextBox txtOilGrade;
        private System.Windows.Forms.GroupBox gbPurchaseDetails;
        private System.Windows.Forms.Label lblExpMileage;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.TextBox txtWarrMileage;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.CheckBox cbWarranty;
        private System.Windows.Forms.Label lblPurchaseMileage;
        private System.Windows.Forms.TextBox txtPurchaseMileage;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.DateTimePicker datePurchase;
        private System.Windows.Forms.Label lblPurchased;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.TextBox txtCarNameIdentifier;
        private System.Windows.Forms.Label lbltxtCarNameIdentifier;
        private System.Windows.Forms.DateTimePicker dtpWarrExp;
    }
}