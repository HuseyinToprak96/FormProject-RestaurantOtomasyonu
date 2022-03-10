using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp14.Model;
namespace ConsoleApp14
{
    public partial class frm_System : Form
    {
        public frm_System()
        {
            InitializeComponent();
        }
        ModelManager modelManager = new ModelManager();
        private void frm_System_Load(object sender, EventArgs e)
        {
            Button button = new Button();
            List<Product> products = new List<Product>();
            products = modelManager.productMenu.Products();
            int left = 0;
            for(int i = 0; i <10; i++)
            {
                button = new Button();
                button.Text = products[i].ProductName;
                button.Width = 80;
                button.Height = 80;
                button.Left = left + 20;
                button.BackColor = Color.AliceBlue;
                gb_Products.Controls.Add(button);
                left += 20;

            }
        }
    }
}
