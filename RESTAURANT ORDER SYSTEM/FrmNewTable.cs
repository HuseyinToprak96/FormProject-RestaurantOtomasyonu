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
    public partial class FrmNewTable : Form
    {
        public FrmNewTable()
        {
            InitializeComponent();
        }
        TablesManager tablesManager = new TablesManager();
        enum TypeTable {WoodenDiningTable=1,GameTable,DoubleTable};
        private void FrmNewTable_Load(object sender, EventArgs e)
        {
            cb_TableName.Items.Add(TypeTable.DoubleTable);
            cb_TableName.Items.Add(TypeTable.GameTable);
            cb_TableName.Items.Add(TypeTable.WoodenDiningTable);
        }

        private void btn_AddTable_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            if (cb_HowManyTable.Text != "" && cb_TableName.Text != "")
            {
                table.TableName = cb_TableName.SelectedItem.ToString();
                table.HowManyTable = Convert.ToInt32(cb_HowManyTable.SelectedItem);
                tablesManager.AddTable(table);
            }
            else
                lbl_addTableError.Text = "Seçim Yapınız.";
        }
    }
}
