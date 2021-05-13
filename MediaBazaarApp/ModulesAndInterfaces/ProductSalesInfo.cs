using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulesAndInterfaces
{
    public class ProductSalesInfo: IComparable<ProductSalesInfo>
    {
        public int ProductNum { get; private set; }
        public int SoldAmount { get; private set; }
        public string Month { get; private set; }
        public int Year { get; private set; }

        public ProductSalesInfo(int productNum, int soldAmount, string month, int year)
        {
            ProductNum = productNum;
            SoldAmount = soldAmount;
            Month = month;
            Year = year;
        }

        public int CompareTo(ProductSalesInfo other)
        {
            if(this.SoldAmount > other.SoldAmount) { return 1; }
            if(this.SoldAmount < other.SoldAmount) { return -1; }
            return 0;
        }

    }
}
