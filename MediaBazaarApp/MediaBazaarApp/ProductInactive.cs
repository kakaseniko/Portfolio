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
    public partial class ProductInactive : Form
    {
        public ProductManager ProductManager { get; set; }
        public ProductInactive(ProductManager pm)
        {
            InitializeComponent();
            this.ProductManager = pm;
            UpdateLV(ProductManager.GetAllProducts());
        }

        public void UpdateLV(List<Product> list)
        {
            lvProducts.Items.Clear();
            foreach (Product p in list)
            {
                if (!p.IsActive)
                {
                    var row = new string[]
                        {p.Name, p.Number.ToString(), p.Location.ToString(), p.AmountInStock.ToString()};
                    var lvi = new ListViewItem(row);
                    lvi.Tag = p;
                    lvProducts.Items.Add(lvi);
                }
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                Product selectedProduct = (Product)lvProducts.SelectedItems[0].Tag;
                selectedProduct.IsActive = true;
                ProductManager.EditProduct(selectedProduct);
                UpdateLV(ProductManager.GetAllProducts());
            }
            else
            {
                MessageBox.Show("Please select a product first");
            }
        }
    }
}
