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
    partial class Frm_Receipt : Form
    {
        public Frm_Receipt()
        {
            InitializeComponent();
        }
        public List<ReceiptWrite> receiptWrite { get; set; }
        public Table table { get; set; }
        public Button btn { get; set; }
        public GroupBox gb_Products { get; set; }
        public GroupBox gb_Tables { get; set; }
        List<int> ReceiptNumbers = new List<int>();
        DBReceipt dBReceipt = new DBReceipt();
        private void Frm_Receipt_Load(object sender, EventArgs e)
        {
            lbl_masaNumber.Text = table.TableID.ToString();
            lbl_ReceiptNumber.Text = receiptWrite[0].ReceiptID.ToString();
            lbl_date.Text = receiptWrite[0].ReceiptDateTime.ToString();
            foreach (ReceiptWrite item in receiptWrite)
            {
                lbl_total.Text = (Convert.ToInt32(lbl_total.Text) + (Convert.ToInt32(item.ProductPrice) * item.Number)).ToString();
                lb_ProductList.Items.Add(item.Barkod + "\t" + item.ProductName + "\t" + item.ProductPrice);
                ReceiptNumbers.Add(item.ReceiptID);
            }
            string[] Birlerdizisi = {"","Bir","İki","Üç","Dört","Beş","Altı","Yedi","Sekiz","Dokuz"};
           
            string[] Onlardizisi = { "","On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yeltmiş", "Seksen", "Doksan" };
            string[] Yüzlerdizisi = {"","Yüz", "İkiyüz", "Üçyüz", "Dörtyüz", "Beşyüz", "Altıyüz", "Yediyüz", "Sekizyüz", "Dokuzyüz", };
            MessageBox.Show(Birlerdizisi[5]);
            lbl_writeTotal.Text = Yüzlerdizisi[int.Parse(lbl_total.Text[0].ToString())]+" "+Onlardizisi[int.Parse(lbl_total.Text[1].ToString())]+" "+Birlerdizisi[int.Parse(lbl_total.Text[2].ToString())]+" Türk Lirası";
            //  lbl_writeTotal.Text = str;

        }

        private void btn_ode_Click(object sender, EventArgs e)
        {

            dBReceipt.OdemeAl(ReceiptNumbers);
            MessageBox.Show("Bizi Tercih Ettiğiniz için Teşekkürler...");
            this.Close();
            btn.BackColor = Color.Green;
        }

        private void btn_newOther_Click(object sender, EventArgs e)
        {
            btn.BackColor = Color.Beige;
            gb_Products.Enabled = true;
            gb_Tables.Enabled = false;
            this.Close();
        }
    }
}
