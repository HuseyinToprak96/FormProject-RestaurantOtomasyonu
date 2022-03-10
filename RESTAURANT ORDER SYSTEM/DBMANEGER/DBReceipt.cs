using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using RESTAURANT_ORDER_SYSTEM.MODEL;
namespace RESTAURANT_ORDER_SYSTEM.DBMANEGER
{
    class DBReceipt
    {
        DBmanager dBmanager = new DBmanager();
        Table_Products table_Products = new Table_Products();
        List<Table_Products> _Products = new List<Table_Products>();
        
        public void ReceiptAdd(Table_Products product)
        { 
                dBmanager.con.Open();
                SqlCommand cmd = new SqlCommand("gp_AddReceiptID", dBmanager.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TableID",product.table.TableID);
                cmd.Parameters.AddWithValue("@HowMuch", product.Money);
                cmd.Parameters.AddWithValue("@IsPaid",false);
                cmd.Parameters.AddWithValue("@dateTime", product.dateTime);
                cmd.Parameters.Add("@YeniID", SqlDbType.Int);
                cmd.Parameters[4].Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
            foreach (Product item in product.Orders)
            {
                SqlCommand cmdOrder = new SqlCommand("insert into Table_Products values(@ReceiptID,@TableID,@ProductID,@Number,@HowMuch)",dBmanager.con);
                cmdOrder.Parameters.AddWithValue("@ReceiptID",cmd.Parameters[4].Value);
                cmdOrder.Parameters.AddWithValue("@TableID", product.table.TableID);
                cmdOrder.Parameters.AddWithValue("@ProductID", item.ProductID);
                cmdOrder.Parameters.AddWithValue("@Number", 1);
                cmdOrder.Parameters.AddWithValue("@HowMuch", item.ProductPrice);
                cmdOrder.ExecuteNonQuery();
            }
            dBmanager.con.Close();
           
            
            }
        ReceiptWrite receiptWrite = new ReceiptWrite();
        Product p = new Product();
        List<Product> products = new List<Product>();
        List<int> numbers = new List<int>();
        List<ReceiptWrite> receiptWrites = new List<ReceiptWrite>();
        public List<ReceiptWrite> FindTable(int TID)
        {
            receiptWrites.Clear();
            dBmanager.con.Open();
            SqlCommand cmd = new SqlCommand("select tp.ReceiptID,r.HowMuch,r.DateTime,tp.number,p.ProductBarkod,p.ProductName,p.ProductPrice from Table_Products tp inner join Products p on tp.ProductID=p.ProductID inner join Receipts r on r.ReceiptID=tp.ReceiptID where tp.TableID=@T_ID and r.isPaid=@Paid", dBmanager.con);
            cmd.Parameters.AddWithValue("@T_ID",TID);
            cmd.Parameters.AddWithValue("@Paid", false);
            SqlDataReader dr = cmd.ExecuteReader();
           
                
            while(dr.Read())
            {
                receiptWrite = new ReceiptWrite();
                receiptWrite.ReceiptID = Convert.ToInt32(dr[0]);
                receiptWrite.ReceiptMoney = Convert.ToDouble(dr[1]);
                receiptWrite.ReceiptDateTime = DateTime.Parse(dr[2].ToString());
                receiptWrite.Number = Convert.ToInt32(dr[3]);
               
                receiptWrite.Barkod = dr[4].ToString();
                receiptWrite.ProductName = dr[5].ToString();
                receiptWrite.ProductPrice =Convert.ToDouble(dr[6]);
                receiptWrite.Number = Convert.ToInt32(dr[3]);
                receiptWrites.Add(receiptWrite);
            }
            dBmanager.con.Close();
            return receiptWrites;
            
        }
        public void OdemeAl(List<int> ReceiptIDs)
        {
            dBmanager.con.Open();
            foreach (int Number in ReceiptIDs)
            {
                SqlCommand cmd = new SqlCommand("update Receipts set isPaid=1 where ReceiptID=@rID",dBmanager.con);
                cmd.Parameters.AddWithValue("@rID", Number);
                cmd.ExecuteNonQuery();
            }
            dBmanager.con.Close();
        }
        }
}
