using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAURANT_ORDER_SYSTEM.MODEL
{
    class Table_Products
    {
        public Table table { get; set; }
        public List<Product> Orders { get; set; }
        public double Money { get; set; }
        public bool IsPaid { get; set; }
        public DateTime dateTime { get; set; }
        List<Table_Products> products = new List<Table_Products>();
        public void Add(Table_Products table_Products)
        {
            products.Add(table_Products);
        }
        public List<Table_Products> AllTableProduct() {
            return products;
        }
    }
}
