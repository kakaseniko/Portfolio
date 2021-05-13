using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulesAndInterfaces;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    public class ProductDBManager
    {
        public static MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi387054;uid=dbi387054;password=password;");


        public void AddProductToDB(Product p)
        {
            //INSERT INTO `product` (`Name`, `Number`, `Model`, `PurchasePrice`, `SalesPrice`, `Location`, `Dimensions`, `Description`, `AmountInStock`, `AmountInStore`) VALUES ('Keyboard', '1001', 'Appliances, Razer', '20', '180', 'Computer', '30x20x10', 'This is a keyboard.', '80', '0');
            string name = p.Name;
            int number = p.Number;
            string model = p.Model;
            double purchasePrice = p.PurchasePrice;
            double salesPrice = p.SalesPrice;
            Location location = p.Location;
            string dimensions = p.Dimensions;
            string description = p.Description;
            int amountInStock = p.AmountInStock;
            int amountInStore = p.AmountInStore;
            bool isActive = p.IsActive;
            int amountRequested = p.AmountRequested;
            try
            {
                string sql = "INSERT INTO product (Name, Number, Model, PurchasePrice, SalesPrice, Location, Dimensions, Description, AmountInStock, AmountInStore, IsActive, AmountRequested) VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9, @param10, @param11, @param12)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@param1", name);
                cmd.Parameters.AddWithValue("@param2", number);
                cmd.Parameters.AddWithValue("@param3", model);
                cmd.Parameters.AddWithValue("@param4", purchasePrice);
                cmd.Parameters.AddWithValue("@param5", salesPrice);
                cmd.Parameters.AddWithValue("@param6", location);
                cmd.Parameters.AddWithValue("@param7", dimensions);
                cmd.Parameters.AddWithValue("@param8", description);
                cmd.Parameters.AddWithValue("@param9", amountInStock);
                cmd.Parameters.AddWithValue("@param10", amountInStore);
                cmd.Parameters.AddWithValue("@param11", isActive);
                cmd.Parameters.AddWithValue("@param12", amountRequested);

                conn.Open();
                cmd.ExecuteNonQuery();

                
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void AddSalesInfoToDB(Product p)
        {
            try
            {
                conn.Open();
                foreach (ProductSalesInfo prod in p.GetProductSalesInfos())
                {
                    string sqlSalesInfo = "INSERT INTO productsalesinfo(Number, SoldAmount, Year, Month) VALUES(@num,@amount,@year, @month);";
                    MySqlCommand cmdSalesInfo = new MySqlCommand(sqlSalesInfo, conn);

                    cmdSalesInfo.Parameters.AddWithValue("@num", p.Number);
                    cmdSalesInfo.Parameters.AddWithValue("@amount", prod.SoldAmount);
                    cmdSalesInfo.Parameters.AddWithValue("@year", prod.Year);
                    cmdSalesInfo.Parameters.AddWithValue("@month", prod.Month);
                    cmdSalesInfo.ExecuteNonQuery();
                }               
            }
            catch(MySqlException ex)
            {
                throw ex;
            }
            
        }
        public List<Product> ReadFromDB()
        {
            List<Product> products = new List<Product>();
            try
            {
                string sql = "SELECT Name, Number, Model, PurchasePrice, SalesPrice, Location, Dimensions, Description, AmountInStock, AmountInStore, IsActive, AmountRequested FROM product";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                string sqlSalesInfo = "SELECT Number, SoldAmount, Year, Month FROM productsalesinfo;";

                MySqlCommand cmdSalesInfo = new MySqlCommand(sqlSalesInfo, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                

                while (dr.Read())
                {
                    string name = dr[0].ToString();
                    int number = Convert.ToInt32(dr[1]);
                    string model = dr[2].ToString();
                    double purchasePrice = Convert.ToDouble(dr[3]);
                    double salesPrice = Convert.ToDouble(dr[4]);
                    Location location = (Location) Enum.Parse(typeof(Location), dr[5].ToString());
                    string dimensions = dr[6].ToString();
                    string description = dr[7].ToString();
                    int amountInStock = Convert.ToInt32(dr[8]);
                    int amountInStore = Convert.ToInt32(dr[9]);
                    //Product product = new Product(name, number, model, purchasePrice, salesPrice, location, dimensions,
                    //    description);
                    //product.AddAmountStock(amountInStock);
                    //product.AddAmountStore(amountInStore);
                    //product.IsActive = Convert.ToBoolean(dr[10]);
                    bool isActive = Convert.ToBoolean(dr[10]);
                    int amountRequested = Convert.ToInt32(dr[11]);
                    Product product = new Product(name, number, model, purchasePrice, salesPrice, location, dimensions,
                        description, amountInStore, amountInStock, isActive, amountRequested);
                    products.Add(product);
                }

                dr.Close();
                MySqlDataReader drSalesInfo = cmdSalesInfo.ExecuteReader();
                List<ProductSalesInfo> allsalesinfo = new List<ProductSalesInfo>();

                while(drSalesInfo.Read())
                {
                    ProductSalesInfo info = new ProductSalesInfo(Convert.ToInt32(drSalesInfo[0]),Convert.ToInt32(drSalesInfo[1]), drSalesInfo[3].ToString(), Convert.ToInt32(drSalesInfo[2]));
                    allsalesinfo.Add(info);
                }
                drSalesInfo.Close();

                foreach (ProductSalesInfo psi in allsalesinfo)
                {
                    foreach (Product p in products)
                    {
                        if(p.Number == psi.ProductNum)
                        {
                            p.InitializeSalesInfo(psi);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return products;
        }

        public void EditProductDB(Product p)
        {
            string name = p.Name;
            int number = p.Number;
            string model = p.Model;
            double purchasePrice = p.PurchasePrice;
            double salesPrice = p.SalesPrice;
            Location location = p.Location;
            string dimensions = p.Dimensions;
            string description = p.Description;
            int amountInStock = p.AmountInStock;
            int amountInStore = p.AmountInStore;
            bool isActive = p.IsActive;
            try
            {
                string sql =
                    "UPDATE product SET Name=@param1,Model=@param3,PurchasePrice=@param4,SalesPrice=@param5,Location=@param6,Dimensions=@param7,Description=@param8,AmountInStock=@param9,AmountInStore=@param10,IsActive=@param11 WHERE Number = @param2";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@param1", name);
                cmd.Parameters.AddWithValue("@param2", number);
                cmd.Parameters.AddWithValue("@param3", model);
                cmd.Parameters.AddWithValue("@param4", purchasePrice);
                cmd.Parameters.AddWithValue("@param5", salesPrice);
                cmd.Parameters.AddWithValue("@param6", location);
                cmd.Parameters.AddWithValue("@param7", dimensions);
                cmd.Parameters.AddWithValue("@param8", description);
                cmd.Parameters.AddWithValue("@param9", amountInStock);
                cmd.Parameters.AddWithValue("@param10", amountInStore);
                cmd.Parameters.AddWithValue("@param11", isActive);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void EditProductDBRequest(Product p)
        {
            string name = p.Name;
            int number = p.Number;
            string model = p.Model;
            double purchasePrice = p.PurchasePrice;
            double salesPrice = p.SalesPrice;
            Location location = p.Location;
            string dimensions = p.Dimensions;
            string description = p.Description;
            int amountInStock = p.AmountInStock;
            int amountInStore = p.AmountInStore;
            bool isActive = p.IsActive;
            int amountRequested = p.AmountRequested;
            try
            {
                string sql =
                    "UPDATE product SET Name=@param1,Model=@param3,PurchasePrice=@param4,SalesPrice=@param5,Location=@param6,Dimensions=@param7,Description=@param8,AmountInStock=@param9,AmountInStore=@param10,IsActive=@param11,AmountRequested=@param12 WHERE Number = @param2";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@param1", name);
                cmd.Parameters.AddWithValue("@param2", number);
                cmd.Parameters.AddWithValue("@param3", model);
                cmd.Parameters.AddWithValue("@param4", purchasePrice);
                cmd.Parameters.AddWithValue("@param5", salesPrice);
                cmd.Parameters.AddWithValue("@param6", location);
                cmd.Parameters.AddWithValue("@param7", dimensions);
                cmd.Parameters.AddWithValue("@param8", description);
                cmd.Parameters.AddWithValue("@param9", amountInStock);
                cmd.Parameters.AddWithValue("@param10", amountInStore);
                cmd.Parameters.AddWithValue("@param11", isActive);
                cmd.Parameters.AddWithValue("@param12", amountRequested);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
