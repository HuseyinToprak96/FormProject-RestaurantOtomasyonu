
namespace RESTAURANT_ORDER_SYSTEM
{
    partial class frm_restaurant
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_Product = new System.Windows.Forms.GroupBox();
            this.gb_Products = new System.Windows.Forms.Panel();
            this.gb = new System.Windows.Forms.GroupBox();
            this.gb_tables = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endOfTheDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearendReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTableAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmI_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AddOrder = new System.Windows.Forms.Button();
            this.btn_vazgec = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_Product.SuspendLayout();
            this.gb.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Product
            // 
            this.gb_Product.Controls.Add(this.gb_Products);
            this.gb_Product.Enabled = false;
            this.gb_Product.Location = new System.Drawing.Point(553, 31);
            this.gb_Product.Name = "gb_Product";
            this.gb_Product.Size = new System.Drawing.Size(235, 374);
            this.gb_Product.TabIndex = 0;
            this.gb_Product.TabStop = false;
            this.gb_Product.Text = "Products";
            // 
            // gb_Products
            // 
            this.gb_Products.AutoScroll = true;
            this.gb_Products.Location = new System.Drawing.Point(6, 12);
            this.gb_Products.Name = "gb_Products";
            this.gb_Products.Size = new System.Drawing.Size(223, 356);
            this.gb_Products.TabIndex = 0;
            // 
            // gb
            // 
            this.gb.Controls.Add(this.gb_tables);
            this.gb.Location = new System.Drawing.Point(26, 31);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(521, 374);
            this.gb.TabIndex = 1;
            this.gb.TabStop = false;
            this.gb.Text = "TABLES";
            // 
            // gb_tables
            // 
            this.gb_tables.AutoScroll = true;
            this.gb_tables.Location = new System.Drawing.Point(7, 12);
            this.gb_tables.Name = "gb_tables";
            this.gb_tables.Size = new System.Drawing.Size(508, 356);
            this.gb_tables.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkKhaki;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.tsmI_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endOfTheDayToolStripMenuItem,
            this.monthlyReportToolStripMenuItem,
            this.yearendReportToolStripMenuItem});
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.raporToolStripMenuItem.Text = "&Report";
            // 
            // endOfTheDayToolStripMenuItem
            // 
            this.endOfTheDayToolStripMenuItem.Name = "endOfTheDayToolStripMenuItem";
            this.endOfTheDayToolStripMenuItem.ShortcutKeyDisplayString = "ALT+D";
            this.endOfTheDayToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.endOfTheDayToolStripMenuItem.Text = "&Day-end report";
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.ShortcutKeyDisplayString = "Alt+M";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.monthlyReportToolStripMenuItem.Text = "&Monthly-end report";
            // 
            // yearendReportToolStripMenuItem
            // 
            this.yearendReportToolStripMenuItem.Name = "yearendReportToolStripMenuItem";
            this.yearendReportToolStripMenuItem.ShortcutKeyDisplayString = "Alt+Y";
            this.yearendReportToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.yearendReportToolStripMenuItem.Text = "&Year-end report";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPriceToolStripMenuItem,
            this.newProductToolStripMenuItem,
            this.newTableAddToolStripMenuItem,
            this.removeProductToolStripMenuItem,
            this.removeTableToolStripMenuItem,
            this.colorSettingToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ayarlarToolStripMenuItem.Text = "&Settings";
            // 
            // newPriceToolStripMenuItem
            // 
            this.newPriceToolStripMenuItem.Name = "newPriceToolStripMenuItem";
            this.newPriceToolStripMenuItem.ShortcutKeyDisplayString = "Alt+P+U";
            this.newPriceToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.newPriceToolStripMenuItem.Text = "Price Update";
            this.newPriceToolStripMenuItem.Click += new System.EventHandler(this.newPriceToolStripMenuItem_Click);
            // 
            // newProductToolStripMenuItem
            // 
            this.newProductToolStripMenuItem.Name = "newProductToolStripMenuItem";
            this.newProductToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Alt+P";
            this.newProductToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.newProductToolStripMenuItem.Text = "New Product Add";
            this.newProductToolStripMenuItem.Click += new System.EventHandler(this.newProductToolStripMenuItem_Click);
            // 
            // newTableAddToolStripMenuItem
            // 
            this.newTableAddToolStripMenuItem.Name = "newTableAddToolStripMenuItem";
            this.newTableAddToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Alt+T";
            this.newTableAddToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.newTableAddToolStripMenuItem.Text = "New Table Add";
            this.newTableAddToolStripMenuItem.Click += new System.EventHandler(this.newTableAddToolStripMenuItem_Click);
            // 
            // removeProductToolStripMenuItem
            // 
            this.removeProductToolStripMenuItem.Name = "removeProductToolStripMenuItem";
            this.removeProductToolStripMenuItem.ShortcutKeyDisplayString = "Shift+Alt+P";
            this.removeProductToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.removeProductToolStripMenuItem.Text = "Remove Product";
            // 
            // removeTableToolStripMenuItem
            // 
            this.removeTableToolStripMenuItem.Name = "removeTableToolStripMenuItem";
            this.removeTableToolStripMenuItem.ShortcutKeyDisplayString = "Shift+Alt+P";
            this.removeTableToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.removeTableToolStripMenuItem.Text = "Remove Table";
            // 
            // colorSettingToolStripMenuItem
            // 
            this.colorSettingToolStripMenuItem.Name = "colorSettingToolStripMenuItem";
            this.colorSettingToolStripMenuItem.ShortcutKeyDisplayString = "Alt+C";
            this.colorSettingToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.colorSettingToolStripMenuItem.Text = "Color Setting";
            this.colorSettingToolStripMenuItem.Click += new System.EventHandler(this.colorSettingToolStripMenuItem_Click);
            // 
            // tsmI_Help
            // 
            this.tsmI_Help.Name = "tsmI_Help";
            this.tsmI_Help.Size = new System.Drawing.Size(46, 20);
            this.tsmI_Help.Text = "&Help";
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_AddOrder.Enabled = false;
            this.btn_AddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AddOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_AddOrder.Location = new System.Drawing.Point(594, 411);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(95, 31);
            this.btn_AddOrder.TabIndex = 3;
            this.btn_AddOrder.Text = "Add Order";
            this.btn_AddOrder.UseVisualStyleBackColor = false;
            this.btn_AddOrder.Click += new System.EventHandler(this.btn_AddOrder_Click);
            // 
            // btn_vazgec
            // 
            this.btn_vazgec.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_vazgec.Enabled = false;
            this.btn_vazgec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_vazgec.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_vazgec.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_vazgec.Location = new System.Drawing.Point(696, 412);
            this.btn_vazgec.Name = "btn_vazgec";
            this.btn_vazgec.Size = new System.Drawing.Size(75, 30);
            this.btn_vazgec.TabIndex = 4;
            this.btn_vazgec.Text = "Give Up";
            this.btn_vazgec.UseVisualStyleBackColor = false;
            this.btn_vazgec.Click += new System.EventHandler(this.btn_vazgec_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(113, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 15);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(46, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(15, 15);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Beige;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(164, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(15, 15);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Empty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(128, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Full";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(181, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selected Table";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Aquamarine;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(283, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(15, 15);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(304, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Selected Product";
            // 
            // frm_restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_vazgec);
            this.Controls.Add(this.btn_AddOrder);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.gb_Product);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_restaurant";
            this.Text = "RESTAURANT";
            this.Load += new System.EventHandler(this.frm_restaurant_Load);
            this.gb_Product.ResumeLayout(false);
            this.gb.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Product;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmI_Help;
        private System.Windows.Forms.ToolStripMenuItem endOfTheDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearendReportToolStripMenuItem;
        private System.Windows.Forms.Button btn_AddOrder;
        private System.Windows.Forms.Button btn_vazgec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem newPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTableAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorSettingToolStripMenuItem;
        private System.Windows.Forms.Panel gb_tables;
        private System.Windows.Forms.Panel gb_Products;
    }
}

