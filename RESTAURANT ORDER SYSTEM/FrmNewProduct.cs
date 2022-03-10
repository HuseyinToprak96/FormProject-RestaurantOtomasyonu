using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RESTAURANT_ORDER_SYSTEM.DBMANEGER;
using RESTAURANT_ORDER_SYSTEM.MODEL;
namespace RESTAURANT_ORDER_SYSTEM
{
    public partial class FrmNewProduct : Form
    {
        public FrmNewProduct()
        {
            InitializeComponent();
        }
        ProductManager productManager = new ProductManager();

        
        private void btn_Control_Click(object sender, EventArgs e)
        {
            int Control;
            if (txt_newBarkod.Text == "") { 
                lbl_newproductError.Text = "Barkod Giriniz.";
                Control = -1;
}
            else
             Control = productManager.findBarkod(txt_newBarkod.Text);
            if (Control==0)
            {
                txt_newname.Enabled = true;
                txt_newprice.Enabled = true;
            }
            else if(Control==1)
                lbl_newproductError.Text = "Farklı bir barkod girmelisiniz.";
    }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductBarkod = txt_newBarkod.Text;
            product.ProductName = txt_newname.Text;
            product.ProductPrice = Double.Parse(txt_newprice.Text);
            productManager.AddProduct(product);
            MessageBox.Show("İşlem Başarılı");
        }
    }
}
