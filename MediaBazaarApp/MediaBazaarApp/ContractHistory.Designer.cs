namespace MediaBazaarApp
{
    partial class ContractHistory
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
            this.lbContractHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbContractHistory
            // 
            this.lbContractHistory.FormattingEnabled = true;
            this.lbContractHistory.HorizontalScrollbar = true;
            this.lbContractHistory.ItemHeight = 16;
            this.lbContractHistory.Location = new System.Drawing.Point(12, 12);
            this.lbContractHistory.Name = "lbContractHistory";
            this.lbContractHistory.Size = new System.Drawing.Size(967, 276);
            this.lbContractHistory.TabIndex = 0;
            // 
            // ContractHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 310);
            this.Controls.Add(this.lbContractHistory);
            this.Name = "ContractHistory";
            this.Text = "Contract History";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbContractHistory;
    }
}