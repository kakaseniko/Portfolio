using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using ModulesAndInterfaces;

namespace MediaBazaarApp
{
    public partial class ProductInformation : Form
    {
        private ProductManager ProductManager { get; set; }
        private Product SelectedProduct { get; set; }
        public bool IsAdd { get; set; } //To see if its an add product or edit product.
        //True = Add a product
        //False = Edit a product
        public ProductInformation(ProductManager pm, bool isAdd, Product p)
        {
            InitializeComponent();
            FillComboBox();
            this.ProductManager = pm;
            this.IsAdd = isAdd;
            if (p != null)
            {
                this.SelectedProduct = p;
            }
            if (IsAdd)
            {
                btnEdit.Visible = false;
                btnAddProduct.Visible = true;
                tbxStockAmount.Enabled = true;
                tbxNumber.Enabled = true;
            }
            else
            {
                btnEdit.Visible = true;
                btnAddProduct.Visible = false;
                tbxStockAmount.Enabled = false;
                tbxNumber.Enabled = false;
                try
                {
                    tbxName.Text = p.Name;
                    tbxNumber.Text = p.Number.ToString();
                    tbxModel.Text = p.Model;
                    tbxPurchasePrice.Text = p.PurchasePrice.ToString();
                    tbxSalesPrice.Text = p.SalesPrice.ToString();
                    tbxDimensions.Text = p.Dimensions;
                    tbxDescription.Text = p.Description;
                    cbxLocation.SelectedIndex = (int) p.Location;
                    tbxStockAmount.Text = p.AmountInStock.ToString();
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbxName.Text;
                string model = tbxModel.Text;
                int number = Convert.ToInt32(tbxNumber.Text);
                double purchasePrice = Convert.ToDouble(tbxPurchasePrice.Text);
                double salesPrice = Convert.ToDouble(tbxSalesPrice.Text);
                Location location = (Location) cbxLocation.SelectedIndex;
                string dimensions = tbxDimensions.Text;
                string description = tbxDescription.Text;
                int stockAmount = Convert.ToInt32(tbxStockAmount.Text);
                int storeAmount = 0;
                bool isActive = true;
                int amountRequested = 0;
                Product p = new Product(name, number, model, purchasePrice, salesPrice, location, dimensions, description, storeAmount, stockAmount, isActive, amountRequested);
                if (ProductManager.AddProduct(p))
                {
                    MessageBox.Show("Product added"); 
                    this.Close();
                }
                else
                { MessageBox.Show("Product with this number is already in the system"); }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Product edittedProduct = null;
                string name = tbxName.Text;
                string model = tbxModel.Text;
                int number = Convert.ToInt32(tbxNumber.Text);
                double purchasePrice = Convert.ToDouble(tbxPurchasePrice.Text);
                double salesPrice = Convert.ToDouble(tbxSalesPrice.Text);
                Location location = (Location)cbxLocation.SelectedIndex;
                string dimensions = tbxDimensions.Text;
                string description = tbxDescription.Text;
                int stockAmount = Convert.ToInt32(tbxStockAmount.Text);
                int storeAmount = SelectedProduct.AmountInStore;
                bool isActive = SelectedProduct.IsActive;
                int amountRequested = 0;


                edittedProduct = new Product(name, number, model, purchasePrice, salesPrice, location, dimensions, description, storeAmount, stockAmount, isActive, amountRequested);
                //edittedProduct.AmountInStock = stockAmount;

                //foreach (Product p in this.ProductManager.GetAllProducts().ToList())
                //{
                //    if (p.Number == this.SelectedProduct.Number)
                //    { this.ProductManager.RemoveProduct(p); }
                //}

                if (this.ProductManager.EditProduct(edittedProduct))
                { this.Close(); }
                else
                { MessageBox.Show("Product Number was already in the system"); }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void FillComboBox()
        {
            cbxLocation.DataSource = Enum.GetNames(typeof(Location));
        }
    }
}
