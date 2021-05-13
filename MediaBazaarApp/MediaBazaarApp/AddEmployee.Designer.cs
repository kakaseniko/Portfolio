
namespace MediaBazaarApp
{
    partial class AddEmployee
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
            this.lbEmplNum = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEditContract = new System.Windows.Forms.Button();
            this.btnSaveContract = new System.Windows.Forms.Button();
            this.btnViewContractHistory = new System.Windows.Forms.Button();
            this.btnAddNewContract = new System.Windows.Forms.Button();
            this.lblHours = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHoursPerWeek = new System.Windows.Forms.NumericUpDown();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxStreetNrAddition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxStreetName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxPostalCode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxStreetNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxEmergencyPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxEmergencyName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxBSN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoursPerWeek)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEmplNum
            // 
            this.lbEmplNum.AutoSize = true;
            this.lbEmplNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmplNum.Location = new System.Drawing.Point(501, 495);
            this.lbEmplNum.Name = "lbEmplNum";
            this.lbEmplNum.Size = new System.Drawing.Size(216, 17);
            this.lbEmplNum.TabIndex = 32;
            this.lbEmplNum.Text = "It will be generated automatically.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(542, 465);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 17);
            this.label20.TabIndex = 31;
            this.label20.Text = "Employee Number:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEditContract);
            this.groupBox4.Controls.Add(this.btnSaveContract);
            this.groupBox4.Controls.Add(this.btnViewContractHistory);
            this.groupBox4.Controls.Add(this.btnAddNewContract);
            this.groupBox4.Controls.Add(this.lblHours);
            this.groupBox4.Controls.Add(this.lbEndDate);
            this.groupBox4.Controls.Add(this.btnEnd);
            this.groupBox4.Controls.Add(this.numericUpDownSalary);
            this.groupBox4.Controls.Add(this.numericUpDownHoursPerWeek);
            this.groupBox4.Controls.Add(this.dtpStartDate);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(5, 314);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(491, 255);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contract Info";
            // 
            // btnEditContract
            // 
            this.btnEditContract.Location = new System.Drawing.Point(11, 146);
            this.btnEditContract.Name = "btnEditContract";
            this.btnEditContract.Size = new System.Drawing.Size(169, 32);
            this.btnEditContract.TabIndex = 42;
            this.btnEditContract.Text = "Edit Contract";
            this.btnEditContract.UseVisualStyleBackColor = true;
            this.btnEditContract.Visible = false;
            this.btnEditContract.Click += new System.EventHandler(this.btnEditContract_Click);
            // 
            // btnSaveContract
            // 
            this.btnSaveContract.Location = new System.Drawing.Point(352, 143);
            this.btnSaveContract.Name = "btnSaveContract";
            this.btnSaveContract.Size = new System.Drawing.Size(132, 32);
            this.btnSaveContract.TabIndex = 41;
            this.btnSaveContract.Text = "Save contract";
            this.btnSaveContract.UseVisualStyleBackColor = true;
            this.btnSaveContract.Visible = false;
            this.btnSaveContract.Click += new System.EventHandler(this.btnSaveContract_Click);
            // 
            // btnViewContractHistory
            // 
            this.btnViewContractHistory.Location = new System.Drawing.Point(314, 219);
            this.btnViewContractHistory.Name = "btnViewContractHistory";
            this.btnViewContractHistory.Size = new System.Drawing.Size(170, 29);
            this.btnViewContractHistory.TabIndex = 40;
            this.btnViewContractHistory.Text = "View Contract History";
            this.btnViewContractHistory.UseVisualStyleBackColor = true;
            this.btnViewContractHistory.Visible = false;
            this.btnViewContractHistory.Click += new System.EventHandler(this.btnViewContractHistory_Click);
            // 
            // btnAddNewContract
            // 
            this.btnAddNewContract.Location = new System.Drawing.Point(11, 219);
            this.btnAddNewContract.Name = "btnAddNewContract";
            this.btnAddNewContract.Size = new System.Drawing.Size(169, 29);
            this.btnAddNewContract.TabIndex = 39;
            this.btnAddNewContract.Text = "Add new contract";
            this.btnAddNewContract.UseVisualStyleBackColor = true;
            this.btnAddNewContract.Visible = false;
            this.btnAddNewContract.Click += new System.EventHandler(this.btnAddNewContract_Click);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(368, 42);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(98, 17);
            this.lblHours.TabIndex = 38;
            this.lblHours.Text = "Hours/week: 0";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(8, 151);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(16, 17);
            this.lbEndDate.TabIndex = 37;
            this.lbEndDate.Text = " .";
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(11, 184);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(169, 30);
            this.btnEnd.TabIndex = 36;
            this.btnEnd.Text = "End contract";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Visible = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.DecimalPlaces = 2;
            this.numericUpDownSalary.Location = new System.Drawing.Point(187, 69);
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownSalary.TabIndex = 35;
            // 
            // numericUpDownHoursPerWeek
            // 
            this.numericUpDownHoursPerWeek.DecimalPlaces = 2;
            this.numericUpDownHoursPerWeek.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownHoursPerWeek.Location = new System.Drawing.Point(187, 37);
            this.numericUpDownHoursPerWeek.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHoursPerWeek.Name = "numericUpDownHoursPerWeek";
            this.numericUpDownHoursPerWeek.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownHoursPerWeek.TabIndex = 34;
            this.numericUpDownHoursPerWeek.ValueChanged += new System.EventHandler(this.numericUpDownHoursPerWeek_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(187, 103);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(160, 22);
            this.dtpStartDate.TabIndex = 19;
            this.dtpStartDate.Value = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 39);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "FTE:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 71);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Salary(euro/hour):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 103);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "Start Date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxDepartment);
            this.groupBox3.Location = new System.Drawing.Point(504, 312);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(188, 90);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Department";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(34, 34);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDepartment.TabIndex = 0;
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Location = new System.Drawing.Point(5, 575);
            this.btnSaveEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(687, 41);
            this.btnSaveEmployee.TabIndex = 28;
            this.btnSaveEmployee.Text = "Save";
            this.btnSaveEmployee.UseVisualStyleBackColor = true;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCity);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbxStreetNrAddition);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxStreetName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbxPostalCode);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tbxStreetNumber);
            this.groupBox2.Location = new System.Drawing.Point(5, 172);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(687, 132);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address information:";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(187, 22);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(132, 22);
            this.tbCity.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "City:";
            // 
            // tbxStreetNrAddition
            // 
            this.tbxStreetNrAddition.Location = new System.Drawing.Point(187, 87);
            this.tbxStreetNrAddition.Margin = new System.Windows.Forms.Padding(4);
            this.tbxStreetNrAddition.Name = "tbxStreetNrAddition";
            this.tbxStreetNrAddition.Size = new System.Drawing.Size(132, 22);
            this.tbxStreetNrAddition.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Street name:";
            // 
            // tbxStreetName
            // 
            this.tbxStreetName.Location = new System.Drawing.Point(187, 51);
            this.tbxStreetName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxStreetName.Name = "tbxStreetName";
            this.tbxStreetName.Size = new System.Drawing.Size(132, 22);
            this.tbxStreetName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Street number addition:";
            // 
            // tbxPostalCode
            // 
            this.tbxPostalCode.Location = new System.Drawing.Point(533, 87);
            this.tbxPostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPostalCode.Name = "tbxPostalCode";
            this.tbxPostalCode.Size = new System.Drawing.Size(132, 22);
            this.tbxPostalCode.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(344, 90);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Postal code:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(344, 55);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 17);
            this.label16.TabIndex = 10;
            this.label16.Text = "Street number:";
            // 
            // tbxStreetNumber
            // 
            this.tbxStreetNumber.Location = new System.Drawing.Point(533, 51);
            this.tbxStreetNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbxStreetNumber.Name = "tbxStreetNumber";
            this.tbxStreetNumber.Size = new System.Drawing.Size(132, 22);
            this.tbxStreetNumber.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpDateOfBirth);
            this.groupBox1.Controls.Add(this.tbxFirstName);
            this.groupBox1.Controls.Add(this.tbxEmergencyPhone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxEmail);
            this.groupBox1.Controls.Add(this.tbxEmergencyName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxPhoneNumber);
            this.groupBox1.Controls.Add(this.tbxBSN);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxLastName);
            this.groupBox1.Location = new System.Drawing.Point(5, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(687, 154);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General information:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(187, 48);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(132, 22);
            this.dtpDateOfBirth.TabIndex = 18;
            this.dtpDateOfBirth.Value = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(187, 16);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(132, 22);
            this.tbxFirstName.TabIndex = 1;
            // 
            // tbxEmergencyPhone
            // 
            this.tbxEmergencyPhone.Location = new System.Drawing.Point(533, 112);
            this.tbxEmergencyPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmergencyPhone.Name = "tbxEmergencyPhone";
            this.tbxEmergencyPhone.Size = new System.Drawing.Size(132, 22);
            this.tbxEmergencyPhone.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date of Birth:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Emergency contact phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Emergency contact name:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(533, 80);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(132, 22);
            this.tbxEmail.TabIndex = 15;
            // 
            // tbxEmergencyName
            // 
            this.tbxEmergencyName.Location = new System.Drawing.Point(187, 112);
            this.tbxEmergencyName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmergencyName.Name = "tbxEmergencyName";
            this.tbxEmergencyName.Size = new System.Drawing.Size(132, 22);
            this.tbxEmergencyName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "BSN:";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(533, 48);
            this.tbxPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(132, 22);
            this.tbxPhoneNumber.TabIndex = 13;
            // 
            // tbxBSN
            // 
            this.tbxBSN.Location = new System.Drawing.Point(187, 80);
            this.tbxBSN.Margin = new System.Windows.Forms.Padding(4);
            this.tbxBSN.Name = "tbxBSN";
            this.tbxBSN.Size = new System.Drawing.Size(132, 22);
            this.tbxBSN.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phone number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Last name:";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(533, 16);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(132, 22);
            this.tbxLastName.TabIndex = 11;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 630);
            this.Controls.Add(this.lbEmplNum);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSaveEmployee);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoursPerWeek)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmplNum;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.NumericUpDown numericUpDownSalary;
        private System.Windows.Forms.NumericUpDown numericUpDownHoursPerWeek;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxStreetNrAddition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxStreetName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxPostalCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxStreetNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxEmergencyPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxEmergencyName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.TextBox tbxBSN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Button btnViewContractHistory;
        private System.Windows.Forms.Button btnAddNewContract;
        private System.Windows.Forms.Button btnEditContract;
        private System.Windows.Forms.Button btnSaveContract;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label13;
    }
}