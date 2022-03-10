using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RESTAURANT_ORDER_SYSTEM.MODEL;
namespace RESTAURANT_ORDER_SYSTEM.DBMANEGER
{
    class TablesManager
    {
        List<Table> tables = new List<Table>();
        DBmanager dBmanager = new DBmanager();

        public List<Table> TableList()
        {
            tables.Clear();
            Table table = new Table();
            dBmanager.con.Open();
            SqlCommand cmd = new SqlCommand("select * from tables",dBmanager.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                table = new Table();
                table.TableID = Convert.ToInt32(dr[0]);
                table.TableName = dr[1].ToString();
                table.HowManyTable = Convert.ToInt32(dr[2]);
                tables.Add(table);
            }
            dBmanager.con.Close();
            return tables;
        }
        public void AddTable(Table table)
        {
            dBmanager.con.Open();
            SqlCommand cmd = new SqlCommand("insert into Tables values(@name,@How)", dBmanager.con);
            cmd.Parameters.AddWithValue("@name", table.TableName);
            cmd.Parameters.AddWithValue("@How", table.HowManyTable);
            cmd.ExecuteNonQuery();
            dBmanager.con.Close();
        }
    }
}
