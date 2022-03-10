using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RESTAURANT_ORDER_SYSTEM.MODEL;
using RESTAURANT_ORDER_SYSTEM.DBMANEGER;
namespace RESTAURANT_ORDER_SYSTEM
{
    public partial class FrmUpdatePrice : Form
    {
        public FrmUpdatePrice()
        {
            InitializeComponent();
        }
        DBmanager GetDbProducts = new DBmanager();
        ProductManager productManager = new ProductManager();
        private void FrmUpdatePrice_Load(object sender, EventArgs e)
        {
           DGW_Products.DataSource=productManager.GridWievProducts();
        }

        private void DGW_Products_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            productManager.UpdatePrice(int.Parse(DGW_Products.Rows[e.RowIndex].Cells[0].Value.ToString()), double.Parse(DGW_Products.Rows[e.RowIndex].Cells[3].Value.ToString()));

        }
    }
}
