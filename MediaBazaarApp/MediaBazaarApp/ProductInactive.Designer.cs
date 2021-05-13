
namespace MediaBazaarApp
{
    partial class ProductInactive
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
            this.lvProducts = new System.Windows.Forms.ListView();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnActivate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.ProductNumber,
            this.ProductDepartment,
            this.ProductStock});
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(12, 12);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(667, 400);
            this.lvProducts.TabIndex = 19;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Name";
            this.ProductName.Width = 217;
            // 
            // ProductNumber
            // 
            this.ProductNumber.Text = "Product Number";
            this.ProductNumber.Width = 141;
            // 
            // ProductDepartment
            // 
            this.ProductDepartment.Text = "Department";
            this.ProductDepartment.Width = 154;
            // 
            // ProductStock
            // 
            this.ProductStock.Text = "Amount in stock";
            this.ProductStock.Width = 150;
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(12, 420);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(667, 23);
            this.btnActivate.TabIndex = 20;
            this.btnActivate.Text = "Activate Selected Product";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // ProductInactive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 455);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.lvProducts);
            this.Name = "ProductInactive";
            this.Text = "ProductInactive";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductNumber;
        private System.Windows.Forms.ColumnHeader ProductDepartment;
        private System.Windows.Forms.ColumnHeader ProductStock;
        private System.Windows.Forms.Button btnActivate;
    }
}