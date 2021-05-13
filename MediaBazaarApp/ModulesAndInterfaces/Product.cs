using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulesAndInterfaces
{
    [Serializable]
    public class Product: IComparable<Product>
    {

        //Properties
        public string Name { get; private set; }
        public int Number { get; private set; }
        public int ID { get; private set; }
        public string Model { get; private set; }
        public double PurchasePrice { get; private set; }
        public double SalesPrice { get; private set; }
        public Location Location { get; private set; }
        public string Dimensions { get; private set; }

        public string Description { get; private set; }
        public int AmountInStock { get; set; }
        public int AmountInStore { get; private set; }

        public bool IsActive { get; set; }

        public List<ProductSalesInfo> salesInfo;

        public int AmountRequested { get; set; }



        //Constructor

        public Product(string name, int number, string model, double purchasePrice, double salesPrice, Location location,
            string dimensions, string description)
        {
            this.Name = name;
            this.Number = number;
            this.Model = model;
            this.PurchasePrice = purchasePrice;
            this.SalesPrice = salesPrice;
            this.Location = location;
            this.Dimensions = dimensions;
            this.Description = description;
            this.AmountInStock = 0;
            this.AmountInStore = 0;
            this.AmountRequested = 0;
            this.IsActive = true;
            salesInfo = new List<ProductSalesInfo>();
        }

        public Product(string name, int number, string model, double purchasePrice, double salesPrice, Location location,
            string dimensions, string description, int stockAmount)
        {
            this.Name = name;
            this.Number = number;
            this.Model = model;
            this.PurchasePrice = purchasePrice;
            this.SalesPrice = salesPrice;
            this.Location = location;
            this.Dimensions = dimensions;
            this.Description = description;
            this.AmountInStock = stockAmount;
            this.AmountInStore = 0;
            this.AmountRequested = 0;
            this.IsActive = true;
            salesInfo = new List<ProductSalesInfo>();
        }

        public Product(string name, int number, string model, double purchasePrice, double salesPrice, Location location,
            string dimensions, string description, int amountInStore, int amountInStock, bool isActive)
        {
            this.Name = name;
            this.Number = number;
            this.Model = model;
            this.PurchasePrice = purchasePrice;
            this.SalesPrice = salesPrice;
            this.Location = location;
            this.Dimensions = dimensions;
            this.Description = description;
            this.AmountInStock = amountInStock;
            this.AmountInStore = amountInStore;
            this.AmountRequested = 0;
            this.IsActive = isActive;
            salesInfo = new List<ProductSalesInfo>();
        }

        public Product(string name, int number, string model, double purchasePrice, double salesPrice, Location location,
            string dimensions, string description, int amountInStore, int amountInStock, bool isActive, int amountRequested)
        {
            this.Name = name;
            this.Number = number;
            this.Model = model;
            this.PurchasePrice = purchasePrice;
            this.SalesPrice = salesPrice;
            this.Location = location;
            this.Dimensions = dimensions;
            this.Description = description;
            this.AmountInStock = amountInStock;
            this.AmountInStore = amountInStore;
            this.IsActive = isActive;
            this.AmountRequested = amountRequested;
            salesInfo = new List<ProductSalesInfo>();
        }

        public void AddAmountStock(int amountInStock)
        {
            this.AmountInStock += amountInStock;
        }

        public void RemoveAmountStock(int amountInStock)
        {
            this.AmountInStock -= amountInStock;
        }
        public void EditAmountStock(int amountInStock)
        {
            this.AmountInStock = amountInStock;
        }
        public void AddAmountStore(int amountInStore)
        {
            this.AmountInStore += amountInStore;
        }

        public void RemoveAmountRequested(int amountRequested)
        {
            this.AmountRequested -= amountRequested;
        }
        public void RemoveAmountStore(int amountInStore, string month, int year)
        {
            this.AmountInStore -= amountInStore;
            salesInfo.Add(new ProductSalesInfo(this.Number,amountInStore, month, year));
        }
        public void InitializeSalesInfo(ProductSalesInfo psi)
        {
            salesInfo.Add(psi);
        }
        public void EditAmountStore(int amountInStore)
        {
            this.AmountInStore = amountInStore;
        }
        public List<ProductSalesInfo> GetProductSalesInfos()
        {
            if(salesInfo.Count > 0)
            {
                return this.salesInfo;
            }
            return null;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}. Number: {this.Number}. Location: {this.Location}. Amount in stock: {this.AmountInStock}. Amount in store: {this.AmountInStore}.";
        }

        public int CompareTo(Product other)
        {
            if (this.Number > other.Number) { return 1;}
            if (this.Number < other.Number) { return -1;}
            return 0;
        }
        public double CalculateRevenue()
        {
            double rev = 0;
            foreach(ProductSalesInfo psi in salesInfo)
            {
                rev += psi.SoldAmount * SalesPrice;
            }
            return rev;
        }
        public double CalculateProfit()
        {
            double prof = 0;
            foreach(ProductSalesInfo psi in salesInfo)
            {
                prof += (psi.SoldAmount * SalesPrice) - (psi.SoldAmount * PurchasePrice);
            }
            return prof;
        }
    }
}
