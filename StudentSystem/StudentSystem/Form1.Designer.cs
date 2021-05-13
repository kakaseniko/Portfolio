namespace StudentSystem
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddToAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbTeacher = new System.Windows.Forms.RadioButton();
            this.rbStu = new System.Windows.Forms.RadioButton();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbECs = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPCNAddFrom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCelebrate = new System.Windows.Forms.Button();
            this.tbAddECs = new System.Windows.Forms.TextBox();
            this.btnAddECs = new System.Windows.Forms.Button();
            this.btnStartNewYearStuFrom = new System.Windows.Forms.Button();
            this.btnPromote = new System.Windows.Forms.Button();
            this.tbPCNStudentForm = new System.Windows.Forms.TextBox();
            this.btnShowInfoStudentForm = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddToAdmin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbTeacher);
            this.panel1.Controls.Add(this.rbStu);
            this.panel1.Controls.Add(this.tbSalary);
            this.panel1.Controls.Add(this.tbECs);
            this.panel1.Controls.Add(this.tbYear);
            this.panel1.Controls.Add(this.tbAge);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.tbPCNAddFrom);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 348);
            this.panel1.TabIndex = 0;
            // 
            // btnAddToAdmin
            // 
            this.btnAddToAdmin.Location = new System.Drawing.Point(25, 297);
            this.btnAddToAdmin.Name = "btnAddToAdmin";
            this.btnAddToAdmin.Size = new System.Drawing.Size(203, 31);
            this.btnAddToAdmin.TabIndex = 14;
            this.btnAddToAdmin.Text = "Add to administration";
            this.btnAddToAdmin.UseVisualStyleBackColor = true;
            this.btnAddToAdmin.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Type:";
            // 
            // rbTeacher
            // 
            this.rbTeacher.AutoSize = true;
            this.rbTeacher.Location = new System.Drawing.Point(128, 65);
            this.rbTeacher.Name = "rbTeacher";
            this.rbTeacher.Size = new System.Drawing.Size(82, 21);
            this.rbTeacher.TabIndex = 14;
            this.rbTeacher.TabStop = true;
            this.rbTeacher.Text = "Teacher";
            this.rbTeacher.UseVisualStyleBackColor = true;
            // 
            // rbStu
            // 
            this.rbStu.AutoSize = true;
            this.rbStu.Location = new System.Drawing.Point(128, 37);
            this.rbStu.Name = "rbStu";
            this.rbStu.Size = new System.Drawing.Size(78, 21);
            this.rbStu.TabIndex = 13;
            this.rbStu.TabStop = true;
            this.rbStu.Text = "Student";
            this.rbStu.UseVisualStyleBackColor = true;
            this.rbStu.CheckedChanged += new System.EventHandler(this.rbStu_CheckedChanged);
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(128, 251);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(100, 22);
            this.tbSalary.TabIndex = 12;
            // 
            // tbECs
            // 
            this.tbECs.Location = new System.Drawing.Point(128, 223);
            this.tbECs.Name = "tbECs";
            this.tbECs.Size = new System.Drawing.Size(100, 22);
            this.tbECs.TabIndex = 11;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(128, 195);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 22);
            this.tbYear.TabIndex = 10;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(128, 166);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 22);
            this.tbAge.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(128, 138);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 8;
            // 
            // tbPCNAddFrom
            // 
            this.tbPCNAddFrom.Location = new System.Drawing.Point(128, 110);
            this.tbPCNAddFrom.Name = "tbPCNAddFrom";
            this.tbPCNAddFrom.Size = new System.Drawing.Size(100, 22);
            this.tbPCNAddFrom.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Salary:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "EC\'s:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Year at school:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "PCN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add form";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCelebrate);
            this.panel4.Controls.Add(this.tbAddECs);
            this.panel4.Controls.Add(this.btnAddECs);
            this.panel4.Controls.Add(this.btnStartNewYearStuFrom);
            this.panel4.Controls.Add(this.btnPromote);
            this.panel4.Controls.Add(this.tbPCNStudentForm);
            this.panel4.Controls.Add(this.btnShowInfoStudentForm);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(737, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 271);
            this.panel4.TabIndex = 3;
            // 
            // btnCelebrate
            // 
            this.btnCelebrate.Location = new System.Drawing.Point(13, 83);
            this.btnCelebrate.Name = "btnCelebrate";
            this.btnCelebrate.Size = new System.Drawing.Size(172, 23);
            this.btnCelebrate.TabIndex = 16;
            this.btnCelebrate.Text = "Celebrate birthday";
            this.btnCelebrate.UseVisualStyleBackColor = true;
            this.btnCelebrate.Click += new System.EventHandler(this.btnCelebrate_Click);
            // 
            // tbAddECs
            // 
            this.tbAddECs.Location = new System.Drawing.Point(13, 140);
            this.tbAddECs.Name = "tbAddECs";
            this.tbAddECs.Size = new System.Drawing.Size(79, 22);
            this.tbAddECs.TabIndex = 15;
            // 
            // btnAddECs
            // 
            this.btnAddECs.Location = new System.Drawing.Point(99, 141);
            this.btnAddECs.Name = "btnAddECs";
            this.btnAddECs.Size = new System.Drawing.Size(86, 23);
            this.btnAddECs.TabIndex = 14;
            this.btnAddECs.Text = "Add EC\'s";
            this.btnAddECs.UseVisualStyleBackColor = true;
            this.btnAddECs.Click += new System.EventHandler(this.btnAddECs_Click);
            // 
            // btnStartNewYearStuFrom
            // 
            this.btnStartNewYearStuFrom.Location = new System.Drawing.Point(13, 111);
            this.btnStartNewYearStuFrom.Name = "btnStartNewYearStuFrom";
            this.btnStartNewYearStuFrom.Size = new System.Drawing.Size(172, 23);
            this.btnStartNewYearStuFrom.TabIndex = 13;
            this.btnStartNewYearStuFrom.Text = "Start new school year";
            this.btnStartNewYearStuFrom.UseVisualStyleBackColor = true;
            this.btnStartNewYearStuFrom.Click += new System.EventHandler(this.btnStartNewYearStuFrom_Click);
            // 
            // btnPromote
            // 
            this.btnPromote.Location = new System.Drawing.Point(13, 170);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(172, 23);
            this.btnPromote.TabIndex = 15;
            this.btnPromote.Text = "Promote";
            this.btnPromote.UseVisualStyleBackColor = true;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // tbPCNStudentForm
            // 
            this.tbPCNStudentForm.Location = new System.Drawing.Point(85, 26);
            this.tbPCNStudentForm.Name = "tbPCNStudentForm";
            this.tbPCNStudentForm.Size = new System.Drawing.Size(100, 22);
            this.tbPCNStudentForm.TabIndex = 12;
            // 
            // btnShowInfoStudentForm
            // 
            this.btnShowInfoStudentForm.Location = new System.Drawing.Point(13, 54);
            this.btnShowInfoStudentForm.Name = "btnShowInfoStudentForm";
            this.btnShowInfoStudentForm.Size = new System.Drawing.Size(172, 23);
            this.btnShowInfoStudentForm.TabIndex = 10;
            this.btnShowInfoStudentForm.Text = "Show Info";
            this.btnShowInfoStudentForm.UseVisualStyleBackColor = true;
            this.btnShowInfoStudentForm.Click += new System.EventHandler(this.btnShowInfoStudentForm_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "PCN:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(292, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(427, 276);
            this.listBox1.TabIndex = 4;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(419, 294);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(300, 24);
            this.btnShowAll.TabIndex = 7;
            this.btnShowAll.Text = "Show persons";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Student",
            "Teacher"});
            this.comboBox1.Location = new System.Drawing.Point(292, 294);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(292, 324);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(121, 22);
            this.tbSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(419, 324);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(299, 22);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search via partial name";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 390);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddToAdmin;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbECs;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPCNAddFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbAddECs;
        private System.Windows.Forms.Button btnAddECs;
        private System.Windows.Forms.Button btnStartNewYearStuFrom;
        private System.Windows.Forms.TextBox tbPCNStudentForm;
        private System.Windows.Forms.Button btnShowInfoStudentForm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.RadioButton rbTeacher;
        private System.Windows.Forms.RadioButton rbStu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCelebrate;
    }
}

