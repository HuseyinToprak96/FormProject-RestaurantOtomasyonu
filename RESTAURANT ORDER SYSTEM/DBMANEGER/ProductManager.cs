using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RESTAURANT_ORDER_SYSTEM.MODEL;
using System.Data;

namespace RESTAURANT_ORDER_SYSTEM.DBMANEGER
{
    class ProductManager
    {
        ModelManager modelManager = new ModelManager();
        DBmanager dBmanager = new DBmanager();
        List<Product> products = new List<Product>();

        public List<Product> Products()//list ve model döndürürken hata var.
        {
            products.Clear();
            Product product = new Product();
            dBmanager.con.Open();
            SqlCommand cmd = new SqlCommand("select * from Products", dBmanager.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                product = new Product();
                product.ProductID = Convert.ToInt32(dr[0]);
                product.ProductBarkod = dr[1].ToString();
                product.ProductPrice = double.Parse(dr[3].ToString());
                product.ProductName = dr[2].ToString();
                products.Add(product);
            }
            dBmanager.con.Close();
            return products;
        }
        public DataTable GridWievProducts()
        {

            Product product = new Product();
           // dBmanager.con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Products", dBmanager.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dBmanager.con.Close();
            return dt;
        }
        public void UpdatePrice(int id,double price)
        {
            dBmanager.con.Open();
            SqlCommand cmd = new SqlCommand("update  Products set ProductPrice=@price where ProductID=@id",dBmanager.con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.ExecuteNonQuery();
            dBmanager.con.Close();
        }
        public int findBarkod(string barkod)
        {
            Product product = new Product();
            dBmanager.con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Products where ProductBarkod=@Barkod",dBmanager.con);
            cmd.Parameters.AddWithValue("@Barkod", barkod);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            
            if (dr.HasRows)
            return 1;
            dBmanager.con.Close();
            return 0;
            
        }
        public void AddProduct(Product product)
        {
            dBmanager.con.Open();
            SqlCommand cmd = new SqlCommand("insert into Products values(@barkod,@ProductName,@ProductPrice)",dBmanager.con);
            cmd.Parameters.AddWithValue("@barkod",product.ProductBarkod);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@ProductPrice",product.ProductPrice);
            cmd.ExecuteNonQuery();
            dBmanager.con.Close();
        }
    }
}
