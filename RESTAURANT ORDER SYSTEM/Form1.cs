using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using RESTAURANT_ORDER_SYSTEM.MODEL;
using RESTAURANT_ORDER_SYSTEM.DBMANEGER;
namespace RESTAURANT_ORDER_SYSTEM
{
    public partial class frm_restaurant : Form
    {
        public frm_restaurant()
        {
            InitializeComponent();
        }
       
        
        ModelManager modelManager = new ModelManager();
        List<Product> Products_Selected = new List<Product>();
        List<Button> Button_selected = new List<Button>();
        List<Table_Products> Table_Products = new List<Table_Products>();
        DBmanager dBmanager = new DBmanager();
        ProductManager productManager = new ProductManager();
        TablesManager tablesManager = new TablesManager();
        DBReceipt dBReceipt = new DBReceipt();
        Product product = new Product();
        Table table = new Table();
        Button table_Selected;
        private void frm_restaurant_Load(object sender, EventArgs e)
        {
            Button Product_button = new Button();
            List<Product> products = new List<Product>();
            products =productManager.Products();
            int left = 0;
            int top = 0;
            int row=products.Count/4;
            if (products.Count % 4 != 0)
                row +=1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Product_button = new Button();
                    product = new Product();
                    Product_button.Text = products[((i*4)+(j))].ProductName;
                    Product_button.Font = new Font("Arial",6);
                    Product_button.Width = 54;
                    Product_button.Height = 40;
                    Product_button.Left = left + 6;
                    Product_button.Top = top + 20;
                    Product_button.BackColor = Color.AntiqueWhite;
                    Product_button.ForeColor = Color.Red;
                    Product_button.FlatStyle = FlatStyle.Popup;
                    product.ProductID = products[((i * 4) + (j))].ProductID;
                    product.ProductName = Product_button.Text;
                    product.ProductBarkod = products[((i * 4) + (j))].ProductBarkod;
                    product.ProductPrice = products[((i * 4) + (j))].ProductPrice;
                    Product_button.Tag = product;
                    Product_button.MouseClick += Product_button_MouseClick; ;
                    gb_Products.Controls.Add(Product_button);
                    left += 54;
                }
                top += 50;
                left = 0;
            }
            top = 0;
            List<Table> tables = new List<Table>();

            tables = tablesManager.TableList();
            Button Table_button = new Button();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Table_button = new Button();
                    table = new Table();
                    Table_button.Text = tables[((i * 4) + (j))].TableName+"\n Masa No:"+tables[((i * 4) + (j))].TableID;
                    Table_button.Font = new Font("Arial", 6);
                    Table_button.Width = 80;
                    Table_button.Height = 63;
                    Table_button.Left = left + 25;
                    Table_button.Top = top + 35;
                    Table_button.BackColor = Color.Green;
                    Table_button.ForeColor = Color.White;
                    Table_button.FlatStyle = FlatStyle.Popup;
                    table.TableID = tables[((i * 4) + (j))].TableID;
                    table.TableName = tables[((i * 4) + (j))].TableName;
                    table.HowManyTable = tables[((i * 4) + (j))].HowManyTable;
                    Table_button.Tag = table;
                    Table_button.MouseClick += Table_button_MouseClick;
                    gb_tables.Controls.Add(Table_button);
                    left += 100;
                }
                top += 80;
                left = 0;
            }
        }
        double ucret = 0;
        private void Product_button_MouseClick(object sender, MouseEventArgs e)
        {
            Product p = (Product)((Button)sender).Tag;
           Products_Selected.Add(p);
            ucret += p.ProductPrice;
            MessageBox.Show("Toplam Ücret: "+ucret.ToString()+" TL");
            ((Button)sender).BackColor = Color.Aquamarine;
            ((Button)sender).Enabled = false;
            Button_selected.Add((Button)sender);
            btn_AddOrder.Enabled = true;
        }
        Table Selectedtable;
        private void Table_button_MouseClick(object sender, MouseEventArgs e)
        {
            Selectedtable = (Table)((Button)sender).Tag;
            table_Selected = (Button)sender;
            if (((Button)sender).BackColor != Color.Brown)
            {
                ((Button)sender).BackColor = Color.Beige;
                gb_Product.Enabled = true;
                gb.Enabled = false;
                btn_vazgec.Enabled = true;
            }
            else
            {
                Frm_Receipt frmReceipt = new Frm_Receipt();
                frmReceipt.Width = 300;
                frmReceipt.Height = 700;
                frmReceipt.table = Selectedtable;
                frmReceipt.btn = table_Selected;
                frmReceipt.gb_Products = gb_Product;
                frmReceipt.gb_Tables = gb;
                frmReceipt.receiptWrite = dBReceipt.FindTable(Selectedtable.TableID);

                frmReceipt.ShowDialog();
            }
          
        }
#pragma warning disable CS0050 // Tutarsız erişilebilirlik: 'Table_Products' dönüş türü, 'frm_restaurant.SiparisBul(int)' yönteminden daha az erişilebilir

        private void btn_vazgec_Click(object sender, EventArgs e)
        {
            ucret = 0;
            table_Selected.BackColor=Color.Green;
            gb_Product.Enabled = false;
            gb.Enabled = true;
            btn_AddOrder.Enabled =false;
            btn_vazgec.Enabled = false;
            foreach (Button product in Button_selected)
            {
                product.BackColor = Color.AntiqueWhite;
                product.Enabled = true;
            }
        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            table_Selected.BackColor = Color.Brown;
            foreach (Button product in Button_selected) { 
            product.BackColor = Color.AntiqueWhite;
            product.Enabled = true;}
            Table_Products table_Products = new Table_Products();
            table_Products.table = Selectedtable;
            table_Products.Money = ucret;
            table_Products.Orders = Products_Selected;
            table_Products.dateTime = DateTime.Now;
            dBReceipt.ReceiptAdd(table_Products);
            Table_Products.Add(table_Products);
            ClearProducts();
            ucret = 0;
            gb_Product.Enabled = false;
            gb.Enabled = true;
            btn_AddOrder.Enabled = false;
            btn_vazgec.Enabled = false;  
        }
        List<Product> lp = new List<Product>();
        public void ClearProducts()
        {
         foreach (Product item in Products_Selected)
         lp.Add(item);
         foreach (Product item in lp)
         Products_Selected.Remove(item);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void colorSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdatePrice frmUpdatePrice = new FrmUpdatePrice();
            frmUpdatePrice.ShowDialog();
        }

        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNewProduct frmNewProduct = new FrmNewProduct();
            frmNewProduct.ShowDialog();
        }

        private void newTableAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNewTable frmNewTable = new FrmNewTable();
            frmNewTable.ShowDialog();
        }
    }
}
