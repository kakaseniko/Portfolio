namespace WorkshopManagement
{
    partial class WorkshopInfoForm
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
            this.lblWsInfo = new System.Windows.Forms.Label();
            this.listBoxParticipants = new System.Windows.Forms.ListBox();
            this.btnRemovePart = new System.Windows.Forms.Button();
            this.btnPrintParticipantList = new System.Windows.Forms.Button();
            this.btnStartWks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWsInfo
            // 
            this.lblWsInfo.AutoSize = true;
            this.lblWsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWsInfo.Location = new System.Drawing.Point(19, 9);
            this.lblWsInfo.Name = "lblWsInfo";
            this.lblWsInfo.Size = new System.Drawing.Size(84, 160);
            this.lblWsInfo.TabIndex = 0;
            this.lblWsInfo.Text = "Date:\r\nTitle: \r\nTopic: \r\nCapacity: \r\nTeacher: \r\nAddress: \r\nRoom:\r\nLink:  ";
            // 
            // listBoxParticipants
            // 
            this.listBoxParticipants.FormattingEnabled = true;
            this.listBoxParticipants.ItemHeight = 16;
            this.listBoxParticipants.Location = new System.Drawing.Point(23, 195);
            this.listBoxParticipants.Name = "listBoxParticipants";
            this.listBoxParticipants.Size = new System.Drawing.Size(404, 244);
            this.listBoxParticipants.TabIndex = 1;
            // 
            // btnRemovePart
            // 
            this.btnRemovePart.Location = new System.Drawing.Point(23, 455);
            this.btnRemovePart.Name = "btnRemovePart";
            this.btnRemovePart.Size = new System.Drawing.Size(404, 41);
            this.btnRemovePart.TabIndex = 2;
            this.btnRemovePart.Text = "Remove Selected Participant";
            this.btnRemovePart.UseVisualStyleBackColor = true;
            this.btnRemovePart.Click += new System.EventHandler(this.btnRemovePart_Click);
            // 
            // btnPrintParticipantList
            // 
            this.btnPrintParticipantList.Location = new System.Drawing.Point(442, 195);
            this.btnPrintParticipantList.Name = "btnPrintParticipantList";
            this.btnPrintParticipantList.Size = new System.Drawing.Size(176, 50);
            this.btnPrintParticipantList.TabIndex = 3;
            this.btnPrintParticipantList.Text = "Print Participant List";
            this.btnPrintParticipantList.UseVisualStyleBackColor = true;
            this.btnPrintParticipantList.Click += new System.EventHandler(this.btnPrintParticipantList_Click);
            // 
            // btnStartWks
            // 
            this.btnStartWks.Location = new System.Drawing.Point(442, 251);
            this.btnStartWks.Name = "btnStartWks";
            this.btnStartWks.Size = new System.Drawing.Size(176, 50);
            this.btnStartWks.TabIndex = 4;
            this.btnStartWks.Text = "Start workshop";
            this.btnStartWks.UseVisualStyleBackColor = true;
            this.btnStartWks.Click += new System.EventHandler(this.btnStartWks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Participants:";
            // 
            // WorkshopInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartWks);
            this.Controls.Add(this.btnPrintParticipantList);
            this.Controls.Add(this.btnRemovePart);
            this.Controls.Add(this.listBoxParticipants);
            this.Controls.Add(this.lblWsInfo);
            this.Name = "WorkshopInfoForm";
            this.Text = "Workshop Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWsInfo;
        private System.Windows.Forms.ListBox listBoxParticipants;
        private System.Windows.Forms.Button btnRemovePart;
        private System.Windows.Forms.Button btnPrintParticipantList;
        private System.Windows.Forms.Button btnStartWks;
        private System.Windows.Forms.Label label1;
    }
}