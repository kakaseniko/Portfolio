using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using ModulesAndInterfaces;

namespace LogicLayer
{
    public class ProductManager
    {
        private List<Product> products;
        private ProductDBManager dbManager;
        private List<Product> requestedProducts;

        public ProductManager()
        {
            products = new List<Product>();
            dbManager = new ProductDBManager();
            requestedProducts = new List<Product>();
        }

        public bool AddProduct(Product product)
        {
            if (products.Count > 0)
            {
                foreach (Product p in products)
                {
                    if (p.Number == product.Number)
                    {
                        return false;
                    }
                }
            }
            products.Add(product);
            dbManager.AddProductToDB(product);
            return true;
        }

        public bool RemoveProduct(Product product)
        {
            foreach (Product p in products)
            {
                if (p.Number == product.Number)
                {
                    p.IsActive = false;
                    dbManager.EditProductDB(p);
                    return true;
                }
            }
            return false;
        }

        public bool EditProduct(Product newProduct)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Number == newProduct.Number)
                {
                    products[i] = newProduct;
                    this.dbManager.EditProductDB(newProduct);
                    return true;
                }
            }
            return false;
        }

        public void AddProductToRequestList(Product p, int amount)
        {
            p.AmountRequested = amount;
            requestedProducts.Add(p);
            dbManager.EditProductDBRequest(p); //TEST
        }

        public void AddSalesInfoToDB(Product p)
        {
            dbManager.AddSalesInfoToDB(p);
        }

        #region SearchProductMethods

        public List<Product> SearchProducts(string name)
        {
            List<Product> searchedProducts = new List<Product>();
            foreach (Product p in this.GetAllProducts())
            {
                if (p.Name.Contains(name))
                { searchedProducts.Add(p); }
            }
            return searchedProducts;
        }//Name only search

        public List<Product> SearchProducts(int number)
        {
            List<Product> searchedProducts = new List<Product>();
            foreach (Product p in this.GetAllProducts())
            {
                if (p.Number == number)
                { searchedProducts.Add(p); }
            }
            return searchedProducts;
        }//Number only search

        public List<Product> SearchProducts(Location location)
        {
            List<Product> searchedProducts = new List<Product>();
            foreach (Product p in this.GetAllProducts())
            {
                if (p.Location == location)
                { searchedProducts.Add(p); }
            }
            return searchedProducts;
        }//Location only search


        #endregion

        public List<Product> GetAllProducts() //Get all products
        {
            products.Sort();
            return products;
        }

        public List<Product> GetRequestedProductsList()
        {
            return requestedProducts;
        }

        public List<Product> FilterSalesInfoByYearOrMonth(int year, string month)
        {
            List<Product> found = new List<Product>();
            if (month == null)
            {
                foreach (Product p in GetAllProducts())
                {
                    if (p.GetProductSalesInfos() != null)
                    {
                        foreach (ProductSalesInfo psi in p.GetProductSalesInfos())
                        {
                            if (psi.Year == year)
                            {
                                found.Add(p);
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (Product p in GetAllProducts())
                {
                    if (p.GetProductSalesInfos() != null)
                    {
                        foreach (ProductSalesInfo psi in p.GetProductSalesInfos())
                        {
                            if (psi.Year == year && psi.Month == month)
                            {
                                found.Add(p);
                            }
                        }
                    }
                }
            }
            return found;
        }
        public List<Product> FindTopSellingProducts(List<Product> products)
        {
            List<Product> found = new List<Product>();

            List<ProductSalesInfo> allsalesinfo = new List<ProductSalesInfo>();

            foreach (Product p in products)
            {
                if (p.GetProductSalesInfos() != null)
                {
                    foreach (ProductSalesInfo psi in p.GetProductSalesInfos())
                    {
                        allsalesinfo.Add(psi);
                    }
                }
            }

            allsalesinfo.Sort();

            foreach(Product p in products)
            {
                foreach(ProductSalesInfo psi in allsalesinfo)
                {
                    if(p.Number == psi.ProductNum)
                    {
                        if(!found.Contains(p))
                        {
                            found.Add(p);
                        }
                        
                    }
                }
            }
            return found;
        }
        public List<Product> FindLowOnStockProducts(List<Product> products, int threshold)
        {
            List<Product> found = new List<Product>();
            foreach (Product p in products)
            {
                if(p.AmountInStock <= threshold)
                {
                    found.Add(p);
                }
            }
            return found;
        }

        public List<Product> FindLowOnStoreProducts(List<Product> products, int threshold)
        {
            List<Product> found = new List<Product>();
            foreach (Product p in products)
            {
                if (p.AmountInStore <= threshold)
                {
                    found.Add(p);
                }
            }
            return found;
        }
        public List<Product> FilterByLocation(List<Product> products, Location location)
        {
            List<Product> found = new List<Product>();
            foreach (Product p in products)
            {
                if(p.Location == location)
                {
                    found.Add(p);
                }
            }
            return found;
        }
        public double GetTotalRevenue(List<Product> products)
        {
            double totalRev = 0;
            foreach(Product p in products)
            {
                totalRev += p.CalculateRevenue();
            }
            return totalRev;
        }
        public double GetTotalProfit(List<Product> products)
        {
            double totalProf = 0;
            foreach (Product p in products)
            {
                totalProf += p.CalculateProfit();
            }
            return totalProf;
        }

        public List<Product> GetRequestedProducts()
        {
            return requestedProducts;
        }

        public void ReadProductsFromDB()
        {
            products = dbManager.ReadFromDB();
        }
    }
}
