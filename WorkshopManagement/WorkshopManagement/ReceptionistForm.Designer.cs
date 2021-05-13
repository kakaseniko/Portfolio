namespace WorkshopManagement
{
    partial class ReceptionistForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePeople = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxPersonRole = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSavePaopleMan = new System.Windows.Forms.Button();
            this.btnAddPeopleMan = new System.Windows.Forms.Button();
            this.btnEditPeopleMan = new System.Windows.Forms.Button();
            this.listBoxPeopleMan = new System.Windows.Forms.ListBox();
            this.textBoxPCN = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageWSMan = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownRoomNumber = new System.Windows.Forms.NumericUpDown();
            this.btnPrintWs = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.btnRemoveWs = new System.Windows.Forms.Button();
            this.btnEditWs = new System.Windows.Forms.Button();
            this.listBoxWorkshops = new System.Windows.Forms.ListBox();
            this.btnSaveWs = new System.Windows.Forms.Button();
            this.btnAddWs = new System.Windows.Forms.Button();
            this.tbLinkWsMan = new System.Windows.Forms.TextBox();
            this.tbAddressWsMan = new System.Windows.Forms.TextBox();
            this.comboBoxteacherWsMan = new System.Windows.Forms.ComboBox();
            this.numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            this.tbTopicWsMan = new System.Windows.Forms.TextBox();
            this.tbTitleWsMan = new System.Windows.Forms.TextBox();
            this.comboBoxTypeWsMan = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageEnrollment = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDenyER = new System.Windows.Forms.Button();
            this.btnApproveER = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.listBoxEnrollementRequests = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.comboBoxWsEnMan = new System.Windows.Forms.ComboBox();
            this.comboBoxPeopleEnMan = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPagePeople.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageWSMan.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
            this.tabPageEnrollment.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePeople);
            this.tabControl1.Controls.Add(this.tabPageWSMan);
            this.tabControl1.Controls.Add(this.tabPageEnrollment);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePeople
            // 
            this.tabPagePeople.Controls.Add(this.panel1);
            this.tabPagePeople.Location = new System.Drawing.Point(4, 25);
            this.tabPagePeople.Name = "tabPagePeople";
            this.tabPagePeople.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePeople.Size = new System.Drawing.Size(910, 409);
            this.tabPagePeople.TabIndex = 0;
            this.tabPagePeople.Text = "People Management";
            this.tabPagePeople.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.comboBoxPersonRole);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.btnSavePaopleMan);
            this.panel1.Controls.Add(this.btnAddPeopleMan);
            this.panel1.Controls.Add(this.btnEditPeopleMan);
            this.panel1.Controls.Add(this.listBoxPeopleMan);
            this.panel1.Controls.Add(this.textBoxPCN);
            this.panel1.Controls.Add(this.textBoxLName);
            this.panel1.Controls.Add(this.textBoxFName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 397);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxPersonRole
            // 
            this.comboBoxPersonRole.FormattingEnabled = true;
            this.comboBoxPersonRole.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.comboBoxPersonRole.Location = new System.Drawing.Point(181, 64);
            this.comboBoxPersonRole.Name = "comboBoxPersonRole";
            this.comboBoxPersonRole.Size = new System.Drawing.Size(179, 24);
            this.comboBoxPersonRole.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(95, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "Role:";
            // 
            // btnSavePaopleMan
            // 
            this.btnSavePaopleMan.Location = new System.Drawing.Point(52, 265);
            this.btnSavePaopleMan.Name = "btnSavePaopleMan";
            this.btnSavePaopleMan.Size = new System.Drawing.Size(308, 41);
            this.btnSavePaopleMan.TabIndex = 9;
            this.btnSavePaopleMan.Text = "Save";
            this.btnSavePaopleMan.UseVisualStyleBackColor = true;
            this.btnSavePaopleMan.Visible = false;
            this.btnSavePaopleMan.Click += new System.EventHandler(this.btnSavePaopleMan_Click);
            // 
            // btnAddPeopleMan
            // 
            this.btnAddPeopleMan.Location = new System.Drawing.Point(52, 219);
            this.btnAddPeopleMan.Name = "btnAddPeopleMan";
            this.btnAddPeopleMan.Size = new System.Drawing.Size(308, 41);
            this.btnAddPeopleMan.TabIndex = 8;
            this.btnAddPeopleMan.Text = "Add person";
            this.btnAddPeopleMan.UseVisualStyleBackColor = true;
            this.btnAddPeopleMan.Click += new System.EventHandler(this.btnAddPeopleMan_Click);
            // 
            // btnEditPeopleMan
            // 
            this.btnEditPeopleMan.Location = new System.Drawing.Point(429, 266);
            this.btnEditPeopleMan.Name = "btnEditPeopleMan";
            this.btnEditPeopleMan.Size = new System.Drawing.Size(442, 40);
            this.btnEditPeopleMan.TabIndex = 7;
            this.btnEditPeopleMan.Text = "Edit Selected";
            this.btnEditPeopleMan.UseVisualStyleBackColor = true;
            this.btnEditPeopleMan.Click += new System.EventHandler(this.btnEditPeopleMan_Click);
            // 
            // listBoxPeopleMan
            // 
            this.listBoxPeopleMan.FormattingEnabled = true;
            this.listBoxPeopleMan.ItemHeight = 16;
            this.listBoxPeopleMan.Location = new System.Drawing.Point(429, 48);
            this.listBoxPeopleMan.Name = "listBoxPeopleMan";
            this.listBoxPeopleMan.Size = new System.Drawing.Size(442, 212);
            this.listBoxPeopleMan.TabIndex = 6;
            this.listBoxPeopleMan.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPeopleMan_MouseDoubleClick);
            // 
            // textBoxPCN
            // 
            this.textBoxPCN.Location = new System.Drawing.Point(181, 174);
            this.textBoxPCN.Name = "textBoxPCN";
            this.textBoxPCN.Size = new System.Drawing.Size(179, 22);
            this.textBoxPCN.TabIndex = 5;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(181, 140);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(179, 22);
            this.textBoxLName.TabIndex = 4;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(181, 103);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(179, 22);
            this.textBoxFName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "PCN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // tabPageWSMan
            // 
            this.tabPageWSMan.Controls.Add(this.panel2);
            this.tabPageWSMan.Location = new System.Drawing.Point(4, 25);
            this.tabPageWSMan.Name = "tabPageWSMan";
            this.tabPageWSMan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWSMan.Size = new System.Drawing.Size(910, 409);
            this.tabPageWSMan.TabIndex = 1;
            this.tabPageWSMan.Text = "Workshop Management";
            this.tabPageWSMan.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.numericUpDownRoomNumber);
            this.panel2.Controls.Add(this.btnPrintWs);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.btnRemoveWs);
            this.panel2.Controls.Add(this.btnEditWs);
            this.panel2.Controls.Add(this.listBoxWorkshops);
            this.panel2.Controls.Add(this.btnSaveWs);
            this.panel2.Controls.Add(this.btnAddWs);
            this.panel2.Controls.Add(this.tbLinkWsMan);
            this.panel2.Controls.Add(this.tbAddressWsMan);
            this.panel2.Controls.Add(this.comboBoxteacherWsMan);
            this.panel2.Controls.Add(this.numericUpDownCapacity);
            this.panel2.Controls.Add(this.tbTopicWsMan);
            this.panel2.Controls.Add(this.tbTitleWsMan);
            this.panel2.Controls.Add(this.comboBoxTypeWsMan);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 394);
            this.panel2.TabIndex = 0;
            // 
            // numericUpDownRoomNumber
            // 
            this.numericUpDownRoomNumber.Location = new System.Drawing.Point(128, 240);
            this.numericUpDownRoomNumber.Name = "numericUpDownRoomNumber";
            this.numericUpDownRoomNumber.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRoomNumber.TabIndex = 24;
            // 
            // btnPrintWs
            // 
            this.btnPrintWs.Location = new System.Drawing.Point(743, 8);
            this.btnPrintWs.Name = "btnPrintWs";
            this.btnPrintWs.Size = new System.Drawing.Size(139, 49);
            this.btnPrintWs.TabIndex = 23;
            this.btnPrintWs.Text = "Print Workshops";
            this.btnPrintWs.UseVisualStyleBackColor = true;
            this.btnPrintWs.Click += new System.EventHandler(this.btnPrintWs_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy - hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 179);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 4, 30, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(68, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Date:";
            // 
            // btnRemoveWs
            // 
            this.btnRemoveWs.Location = new System.Drawing.Point(658, 314);
            this.btnRemoveWs.Name = "btnRemoveWs";
            this.btnRemoveWs.Size = new System.Drawing.Size(224, 53);
            this.btnRemoveWs.TabIndex = 20;
            this.btnRemoveWs.Text = "Remove Selected";
            this.btnRemoveWs.UseVisualStyleBackColor = true;
            this.btnRemoveWs.Click += new System.EventHandler(this.btnRemoveWs_Click);
            // 
            // btnEditWs
            // 
            this.btnEditWs.Location = new System.Drawing.Point(408, 314);
            this.btnEditWs.Name = "btnEditWs";
            this.btnEditWs.Size = new System.Drawing.Size(244, 53);
            this.btnEditWs.TabIndex = 19;
            this.btnEditWs.Text = "Edit Selected";
            this.btnEditWs.UseVisualStyleBackColor = true;
            this.btnEditWs.Click += new System.EventHandler(this.btnEditWs_Click);
            // 
            // listBoxWorkshops
            // 
            this.listBoxWorkshops.FormattingEnabled = true;
            this.listBoxWorkshops.ItemHeight = 16;
            this.listBoxWorkshops.Location = new System.Drawing.Point(408, 63);
            this.listBoxWorkshops.Name = "listBoxWorkshops";
            this.listBoxWorkshops.Size = new System.Drawing.Size(474, 244);
            this.listBoxWorkshops.TabIndex = 18;
            this.listBoxWorkshops.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxWorkshops_MouseDoubleClick);
            // 
            // btnSaveWs
            // 
            this.btnSaveWs.Location = new System.Drawing.Point(21, 314);
            this.btnSaveWs.Name = "btnSaveWs";
            this.btnSaveWs.Size = new System.Drawing.Size(339, 53);
            this.btnSaveWs.TabIndex = 17;
            this.btnSaveWs.Text = "Save";
            this.btnSaveWs.UseVisualStyleBackColor = true;
            this.btnSaveWs.Visible = false;
            this.btnSaveWs.Click += new System.EventHandler(this.btnSaveWs_Click);
            // 
            // btnAddWs
            // 
            this.btnAddWs.Location = new System.Drawing.Point(21, 314);
            this.btnAddWs.Name = "btnAddWs";
            this.btnAddWs.Size = new System.Drawing.Size(339, 53);
            this.btnAddWs.TabIndex = 16;
            this.btnAddWs.Text = "Add Workshop";
            this.btnAddWs.UseVisualStyleBackColor = true;
            this.btnAddWs.Click += new System.EventHandler(this.btnAddWs_Click);
            // 
            // tbLinkWsMan
            // 
            this.tbLinkWsMan.Location = new System.Drawing.Point(128, 268);
            this.tbLinkWsMan.Name = "tbLinkWsMan";
            this.tbLinkWsMan.Size = new System.Drawing.Size(232, 22);
            this.tbLinkWsMan.TabIndex = 15;
            // 
            // tbAddressWsMan
            // 
            this.tbAddressWsMan.Location = new System.Drawing.Point(128, 207);
            this.tbAddressWsMan.Name = "tbAddressWsMan";
            this.tbAddressWsMan.Size = new System.Drawing.Size(232, 22);
            this.tbAddressWsMan.TabIndex = 13;
            // 
            // comboBoxteacherWsMan
            // 
            this.comboBoxteacherWsMan.FormattingEnabled = true;
            this.comboBoxteacherWsMan.Location = new System.Drawing.Point(128, 149);
            this.comboBoxteacherWsMan.Name = "comboBoxteacherWsMan";
            this.comboBoxteacherWsMan.Size = new System.Drawing.Size(121, 24);
            this.comboBoxteacherWsMan.TabIndex = 12;
            // 
            // numericUpDownCapacity
            // 
            this.numericUpDownCapacity.Location = new System.Drawing.Point(128, 116);
            this.numericUpDownCapacity.Name = "numericUpDownCapacity";
            this.numericUpDownCapacity.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCapacity.TabIndex = 11;
            // 
            // tbTopicWsMan
            // 
            this.tbTopicWsMan.Location = new System.Drawing.Point(128, 82);
            this.tbTopicWsMan.Name = "tbTopicWsMan";
            this.tbTopicWsMan.Size = new System.Drawing.Size(232, 22);
            this.tbTopicWsMan.TabIndex = 10;
            // 
            // tbTitleWsMan
            // 
            this.tbTitleWsMan.Location = new System.Drawing.Point(128, 54);
            this.tbTitleWsMan.Name = "tbTitleWsMan";
            this.tbTitleWsMan.Size = new System.Drawing.Size(232, 22);
            this.tbTitleWsMan.TabIndex = 9;
            // 
            // comboBoxTypeWsMan
            // 
            this.comboBoxTypeWsMan.FormattingEnabled = true;
            this.comboBoxTypeWsMan.Items.AddRange(new object[] {
            "In building",
            "Online"});
            this.comboBoxTypeWsMan.Location = new System.Drawing.Point(128, 22);
            this.comboBoxTypeWsMan.Name = "comboBoxTypeWsMan";
            this.comboBoxTypeWsMan.Size = new System.Drawing.Size(120, 24);
            this.comboBoxTypeWsMan.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Teacher:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(74, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Link:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Room number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Capacity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Topic:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type:";
            // 
            // tabPageEnrollment
            // 
            this.tabPageEnrollment.Controls.Add(this.panel4);
            this.tabPageEnrollment.Controls.Add(this.panel3);
            this.tabPageEnrollment.Location = new System.Drawing.Point(4, 25);
            this.tabPageEnrollment.Name = "tabPageEnrollment";
            this.tabPageEnrollment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnrollment.Size = new System.Drawing.Size(910, 409);
            this.tabPageEnrollment.TabIndex = 2;
            this.tabPageEnrollment.Text = "Enrollment Management";
            this.tabPageEnrollment.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel4.Controls.Add(this.btnDenyER);
            this.panel4.Controls.Add(this.btnApproveER);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.listBoxEnrollementRequests);
            this.panel4.Location = new System.Drawing.Point(319, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(585, 397);
            this.panel4.TabIndex = 1;
            // 
            // btnDenyER
            // 
            this.btnDenyER.Location = new System.Drawing.Point(296, 322);
            this.btnDenyER.Name = "btnDenyER";
            this.btnDenyER.Size = new System.Drawing.Size(269, 37);
            this.btnDenyER.TabIndex = 3;
            this.btnDenyER.Text = "Deny Selected";
            this.btnDenyER.UseVisualStyleBackColor = true;
            this.btnDenyER.Click += new System.EventHandler(this.btnDenyER_Click);
            // 
            // btnApproveER
            // 
            this.btnApproveER.Location = new System.Drawing.Point(21, 322);
            this.btnApproveER.Name = "btnApproveER";
            this.btnApproveER.Size = new System.Drawing.Size(269, 37);
            this.btnApproveER.TabIndex = 2;
            this.btnApproveER.Text = "Approve Selected";
            this.btnApproveER.UseVisualStyleBackColor = true;
            this.btnApproveER.Click += new System.EventHandler(this.btnApproveER_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(16, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(197, 25);
            this.label14.TabIndex = 1;
            this.label14.Text = "Enrollment Requests:";
            // 
            // listBoxEnrollementRequests
            // 
            this.listBoxEnrollementRequests.FormattingEnabled = true;
            this.listBoxEnrollementRequests.ItemHeight = 16;
            this.listBoxEnrollementRequests.Location = new System.Drawing.Point(21, 75);
            this.listBoxEnrollementRequests.Name = "listBoxEnrollementRequests";
            this.listBoxEnrollementRequests.Size = new System.Drawing.Size(544, 228);
            this.listBoxEnrollementRequests.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.btnEnroll);
            this.panel3.Controls.Add(this.comboBoxWsEnMan);
            this.panel3.Controls.Add(this.comboBoxPeopleEnMan);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 397);
            this.panel3.TabIndex = 0;
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(7, 210);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(297, 44);
            this.btnEnroll.TabIndex = 4;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // comboBoxWsEnMan
            // 
            this.comboBoxWsEnMan.FormattingEnabled = true;
            this.comboBoxWsEnMan.Location = new System.Drawing.Point(7, 143);
            this.comboBoxWsEnMan.Name = "comboBoxWsEnMan";
            this.comboBoxWsEnMan.Size = new System.Drawing.Size(297, 24);
            this.comboBoxWsEnMan.TabIndex = 3;
            // 
            // comboBoxPeopleEnMan
            // 
            this.comboBoxPeopleEnMan.FormattingEnabled = true;
            this.comboBoxPeopleEnMan.Location = new System.Drawing.Point(7, 81);
            this.comboBoxPeopleEnMan.Name = "comboBoxPeopleEnMan";
            this.comboBoxPeopleEnMan.Size = new System.Drawing.Size(297, 24);
            this.comboBoxPeopleEnMan.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Workshops:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "People:";
            // 
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReceptionistForm";
            this.Text = "Receptionist";
            this.tabControl1.ResumeLayout(false);
            this.tabPagePeople.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageWSMan.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
            this.tabPageEnrollment.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePeople;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageWSMan;
        private System.Windows.Forms.TabPage tabPageEnrollment;
        private System.Windows.Forms.Button btnSavePaopleMan;
        private System.Windows.Forms.Button btnAddPeopleMan;
        private System.Windows.Forms.Button btnEditPeopleMan;
        private System.Windows.Forms.ListBox listBoxPeopleMan;
        private System.Windows.Forms.TextBox textBoxPCN;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemoveWs;
        private System.Windows.Forms.Button btnEditWs;
        private System.Windows.Forms.ListBox listBoxWorkshops;
        private System.Windows.Forms.Button btnSaveWs;
        private System.Windows.Forms.Button btnAddWs;
        private System.Windows.Forms.TextBox tbLinkWsMan;
        private System.Windows.Forms.TextBox tbAddressWsMan;
        private System.Windows.Forms.ComboBox comboBoxteacherWsMan;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
        private System.Windows.Forms.TextBox tbTopicWsMan;
        private System.Windows.Forms.TextBox tbTitleWsMan;
        private System.Windows.Forms.ComboBox comboBoxTypeWsMan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDenyER;
        private System.Windows.Forms.Button btnApproveER;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listBoxEnrollementRequests;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.ComboBox comboBoxWsEnMan;
        private System.Windows.Forms.ComboBox comboBoxPeopleEnMan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPrintWs;
        private System.Windows.Forms.ComboBox comboBoxPersonRole;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDownRoomNumber;
    }
}

