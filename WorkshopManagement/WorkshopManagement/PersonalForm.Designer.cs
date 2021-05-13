namespace WorkshopManagement
{
    partial class PersonalForm
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
            this.btnLoadPeople = new System.Windows.Forms.Button();
            this.comboBoxPeople = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSeeDetails = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxMyWs = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSeen = new System.Windows.Forms.Button();
            this.listBoxNotifications = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnrollmentRequest = new System.Windows.Forms.Button();
            this.listBoxAvWs = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btnLoadPeople);
            this.panel1.Controls.Add(this.comboBoxPeople);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnLoadPeople
            // 
            this.btnLoadPeople.Location = new System.Drawing.Point(526, 14);
            this.btnLoadPeople.Name = "btnLoadPeople";
            this.btnLoadPeople.Size = new System.Drawing.Size(116, 23);
            this.btnLoadPeople.TabIndex = 2;
            this.btnLoadPeople.Text = "Load people";
            this.btnLoadPeople.UseVisualStyleBackColor = true;
            this.btnLoadPeople.Click += new System.EventHandler(this.btnLoadPeople_Click);
            // 
            // comboBoxPeople
            // 
            this.comboBoxPeople.FormattingEnabled = true;
            this.comboBoxPeople.Location = new System.Drawing.Point(142, 14);
            this.comboBoxPeople.Name = "comboBoxPeople";
            this.comboBoxPeople.Size = new System.Drawing.Size(364, 24);
            this.comboBoxPeople.TabIndex = 1;
            this.comboBoxPeople.SelectedIndexChanged += new System.EventHandler(this.comboBoxPeople_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select person:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnSeeDetails);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.listBoxMyWs);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnEnrollmentRequest);
            this.panel2.Controls.Add(this.listBoxAvWs);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 543);
            this.panel2.TabIndex = 1;
            // 
            // btnSeeDetails
            // 
            this.btnSeeDetails.Location = new System.Drawing.Point(509, 462);
            this.btnSeeDetails.Name = "btnSeeDetails";
            this.btnSeeDetails.Size = new System.Drawing.Size(465, 49);
            this.btnSeeDetails.TabIndex = 7;
            this.btnSeeDetails.Text = "See Details of Selected Workshop";
            this.btnSeeDetails.UseVisualStyleBackColor = true;
            this.btnSeeDetails.Click += new System.EventHandler(this.btnSeeDetails_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Available Workshops:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "My Workshops:";
            // 
            // listBoxMyWs
            // 
            this.listBoxMyWs.FormattingEnabled = true;
            this.listBoxMyWs.ItemHeight = 16;
            this.listBoxMyWs.Location = new System.Drawing.Point(509, 276);
            this.listBoxMyWs.Name = "listBoxMyWs";
            this.listBoxMyWs.Size = new System.Drawing.Size(465, 180);
            this.listBoxMyWs.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.Controls.Add(this.btnSeen);
            this.panel3.Controls.Add(this.listBoxNotifications);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(506, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 205);
            this.panel3.TabIndex = 3;
            // 
            // btnSeen
            // 
            this.btnSeen.Location = new System.Drawing.Point(303, 159);
            this.btnSeen.Name = "btnSeen";
            this.btnSeen.Size = new System.Drawing.Size(180, 33);
            this.btnSeen.TabIndex = 2;
            this.btnSeen.Text = "Mark selected as seen";
            this.btnSeen.UseVisualStyleBackColor = true;
            this.btnSeen.Click += new System.EventHandler(this.btnSeen_Click);
            // 
            // listBoxNotifications
            // 
            this.listBoxNotifications.FormattingEnabled = true;
            this.listBoxNotifications.ItemHeight = 16;
            this.listBoxNotifications.Location = new System.Drawing.Point(20, 37);
            this.listBoxNotifications.Name = "listBoxNotifications";
            this.listBoxNotifications.Size = new System.Drawing.Size(463, 116);
            this.listBoxNotifications.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(16, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Notifications:";
            // 
            // btnEnrollmentRequest
            // 
            this.btnEnrollmentRequest.Location = new System.Drawing.Point(15, 463);
            this.btnEnrollmentRequest.Name = "btnEnrollmentRequest";
            this.btnEnrollmentRequest.Size = new System.Drawing.Size(467, 49);
            this.btnEnrollmentRequest.TabIndex = 2;
            this.btnEnrollmentRequest.Text = "Request Enrollment to Selected Workshop";
            this.btnEnrollmentRequest.UseVisualStyleBackColor = true;
            this.btnEnrollmentRequest.Click += new System.EventHandler(this.btnEnrollmentRequest_Click);
            // 
            // listBoxAvWs
            // 
            this.listBoxAvWs.FormattingEnabled = true;
            this.listBoxAvWs.ItemHeight = 16;
            this.listBoxAvWs.Location = new System.Drawing.Point(15, 116);
            this.listBoxAvWs.Name = "listBoxAvWs";
            this.listBoxAvWs.Size = new System.Drawing.Size(467, 340);
            this.listBoxAvWs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Available Workshops:";
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PersonalForm";
            this.Text = "Person";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxMyWs;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSeen;
        private System.Windows.Forms.ListBox listBoxNotifications;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnrollmentRequest;
        private System.Windows.Forms.ListBox listBoxAvWs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSeeDetails;
        private System.Windows.Forms.Button btnLoadPeople;
    }
}