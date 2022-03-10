
namespace RESTAURANT_ORDER_SYSTEM
{
    partial class FrmNewProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewProduct));
            this.txt_newname = new System.Windows.Forms.TextBox();
            this.txt_newBarkod = new System.Windows.Forms.TextBox();
            this.txt_newprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_Control = new System.Windows.Forms.Button();
            this.lbl_newproductError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_newname
            // 
            this.txt_newname.Enabled = false;
            this.txt_newname.Location = new System.Drawing.Point(169, 158);
            this.txt_newname.Name = "txt_newname";
            this.txt_newname.Size = new System.Drawing.Size(100, 20);
            this.txt_newname.TabIndex = 0;
            // 
            // txt_newBarkod
            // 
            this.txt_newBarkod.Location = new System.Drawing.Point(169, 123);
            this.txt_newBarkod.Name = "txt_newBarkod";
            this.txt_newBarkod.Size = new System.Drawing.Size(100, 20);
            this.txt_newBarkod.TabIndex = 1;
            // 
            // txt_newprice
            // 
            this.txt_newprice.Enabled = false;
            this.txt_newprice.Location = new System.Drawing.Point(169, 196);
            this.txt_newprice.Name = "txt_newprice";
            this.txt_newprice.Size = new System.Drawing.Size(100, 20);
            this.txt_newprice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(110, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Barkod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Goldenrod;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Goldenrod;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product Price:";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_add.Location = new System.Drawing.Point(169, 222);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Control
            // 
            this.btn_Control.BackColor = System.Drawing.Color.Maroon;
            this.btn_Control.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Control.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Control.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Control.Location = new System.Drawing.Point(275, 121);
            this.btn_Control.Name = "btn_Control";
            this.btn_Control.Size = new System.Drawing.Size(75, 23);
            this.btn_Control.TabIndex = 7;
            this.btn_Control.Text = "Control";
            this.btn_Control.UseVisualStyleBackColor = false;
            this.btn_Control.Click += new System.EventHandler(this.btn_Control_Click);
            // 
            // lbl_newproductError
            // 
            this.lbl_newproductError.AutoSize = true;
            this.lbl_newproductError.BackColor = System.Drawing.Color.Brown;
            this.lbl_newproductError.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_newproductError.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_newproductError.Location = new System.Drawing.Point(96, 254);
            this.lbl_newproductError.Name = "lbl_newproductError";
            this.lbl_newproductError.Size = new System.Drawing.Size(0, 16);
            this.lbl_newproductError.TabIndex = 8;
            // 
            // FrmNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 273);
            this.Controls.Add(this.lbl_newproductError);
            this.Controls.Add(this.btn_Control);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_newprice);
            this.Controls.Add(this.txt_newBarkod);
            this.Controls.Add(this.txt_newname);
            this.Name = "FrmNewProduct";
            this.Text = "FrmNewProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_newname;
        private System.Windows.Forms.TextBox txt_newBarkod;
        private System.Windows.Forms.TextBox txt_newprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_Control;
        private System.Windows.Forms.Label lbl_newproductError;
    }
}