namespace MediaBazaarApp
{
    partial class EndContract
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
            this.btnEndContract = new System.Windows.Forms.Button();
            this.tbEndReason = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnEndContract
            // 
            this.btnEndContract.Location = new System.Drawing.Point(133, 114);
            this.btnEndContract.Name = "btnEndContract";
            this.btnEndContract.Size = new System.Drawing.Size(134, 32);
            this.btnEndContract.TabIndex = 9;
            this.btnEndContract.Text = "End contract";
            this.btnEndContract.UseVisualStyleBackColor = true;
            this.btnEndContract.Click += new System.EventHandler(this.btnEndContract_Click);
            // 
            // tbEndReason
            // 
            this.tbEndReason.Location = new System.Drawing.Point(147, 76);
            this.tbEndReason.Name = "tbEndReason";
            this.tbEndReason.Size = new System.Drawing.Size(200, 22);
            this.tbEndReason.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "End reason:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "End date:";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(147, 32);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEndDate.TabIndex = 5;
            this.dateTimePickerEndDate.Value = new System.DateTime(2021, 4, 8, 0, 0, 0, 0);
            // 
            // EndContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 186);
            this.Controls.Add(this.btnEndContract);
            this.Controls.Add(this.tbEndReason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Name = "EndContract";
            this.Text = "End contract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEndContract;
        private System.Windows.Forms.TextBox tbEndReason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
    }
}