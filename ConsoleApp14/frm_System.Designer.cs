
namespace ConsoleApp14
{
    partial class frm_System
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
            this.gb_Products = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gb_Products
            // 
            this.gb_Products.Location = new System.Drawing.Point(588, 32);
            this.gb_Products.Name = "gb_Products";
            this.gb_Products.Size = new System.Drawing.Size(200, 370);
            this.gb_Products.TabIndex = 0;
            this.gb_Products.TabStop = false;
            this.gb_Products.Text = "Products";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(24, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TABLES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(219, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "RESTAURANT ORDER SYSTEM";
            // 
            // frm_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Products);
            this.Name = "frm_System";
            this.Text = "frm_System";
            this.Load += new System.EventHandler(this.frm_System_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Products;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}