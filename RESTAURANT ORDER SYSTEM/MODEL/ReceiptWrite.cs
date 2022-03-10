using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAURANT_ORDER_SYSTEM.MODEL
{
    class ReceiptWrite
    {
        public int ReceiptID { get; set; }
        public double ReceiptMoney { get; set; }
        public DateTime ReceiptDateTime { get; set; }
        public int Number { get; set; }
        public string Barkod { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }
}
