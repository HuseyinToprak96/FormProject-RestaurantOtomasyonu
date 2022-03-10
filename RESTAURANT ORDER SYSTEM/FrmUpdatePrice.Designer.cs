
namespace RESTAURANT_ORDER_SYSTEM
{
    partial class FrmUpdatePrice
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
            this.DGW_Products = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // DGW_Products
            // 
            this.DGW_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Products.Location = new System.Drawing.Point(29, 12);
            this.DGW_Products.Name = "DGW_Products";
            this.DGW_Products.Size = new System.Drawing.Size(441, 387);
            this.DGW_Products.TabIndex = 0;
            this.DGW_Products.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW_Products_CellEndEdit);
            // 
            // FrmUpdatePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.DGW_Products);
            this.Name = "FrmUpdatePrice";
            this.Text = "FrmUpdatePrice";
            this.Load += new System.EventHandler(this.FrmUpdatePrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGW_Products;
    }
}