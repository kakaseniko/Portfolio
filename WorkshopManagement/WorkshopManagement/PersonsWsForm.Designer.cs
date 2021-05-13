namespace WorkshopManagement
{
    partial class PersonsWsForm
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
            this.lblPersInfo = new System.Windows.Forms.Label();
            this.listBoxEnrolledWs = new System.Windows.Forms.ListBox();
            this.btnRemovePart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPersInfo
            // 
            this.lblPersInfo.AutoSize = true;
            this.lblPersInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersInfo.Location = new System.Drawing.Point(34, 17);
            this.lblPersInfo.Name = "lblPersInfo";
            this.lblPersInfo.Size = new System.Drawing.Size(192, 17);
            this.lblPersInfo.TabIndex = 0;
            this.lblPersInfo.Text = "First Name: Last Name: PCN:";
            // 
            // listBoxEnrolledWs
            // 
            this.listBoxEnrolledWs.FormattingEnabled = true;
            this.listBoxEnrolledWs.ItemHeight = 16;
            this.listBoxEnrolledWs.Location = new System.Drawing.Point(38, 60);
            this.listBoxEnrolledWs.Name = "listBoxEnrolledWs";
            this.listBoxEnrolledWs.Size = new System.Drawing.Size(696, 292);
            this.listBoxEnrolledWs.TabIndex = 1;
            // 
            // btnRemovePart
            // 
            this.btnRemovePart.Location = new System.Drawing.Point(38, 374);
            this.btnRemovePart.Name = "btnRemovePart";
            this.btnRemovePart.Size = new System.Drawing.Size(330, 45);
            this.btnRemovePart.TabIndex = 2;
            this.btnRemovePart.Text = "Remove participation from selected workshop";
            this.btnRemovePart.UseVisualStyleBackColor = true;
            this.btnRemovePart.Click += new System.EventHandler(this.btnRemovePart_Click);
            // 
            // PersonsWsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 468);
            this.Controls.Add(this.btnRemovePart);
            this.Controls.Add(this.listBoxEnrolledWs);
            this.Controls.Add(this.lblPersInfo);
            this.Name = "PersonsWsForm";
            this.Text = "Enrolled Workshops";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersInfo;
        private System.Windows.Forms.ListBox listBoxEnrolledWs;
        private System.Windows.Forms.Button btnRemovePart;
    }
}