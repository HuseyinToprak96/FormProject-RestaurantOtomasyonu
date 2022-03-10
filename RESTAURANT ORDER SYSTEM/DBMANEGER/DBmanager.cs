using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RESTAURANT_ORDER_SYSTEM.MODEL;
using System.Configuration;

namespace RESTAURANT_ORDER_SYSTEM.DBMANEGER
{
    class DBmanager
    {
        public ProductManager productManager { get; set; }
        public TablesManager tablesManager { get; set; }
        public string yol { get; set; }
        public SqlConnection con { get; set; }
        public DBmanager()
        {
            yol = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString.ToString();
            con = new SqlConnection(yol);
        }
    }
}
