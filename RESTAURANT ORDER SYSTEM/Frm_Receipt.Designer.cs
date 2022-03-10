
namespace RESTAURANT_ORDER_SYSTEM
{
    partial class Frm_Receipt
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
            this.lb_ProductList = new System.Windows.Forms.ListBox();
            this.lbl_Masa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ode = new System.Windows.Forms.Button();
            this.btn_newOther = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_writeTotal = new System.Windows.Forms.Label();
            this.lbl_masaNumber = new System.Windows.Forms.Label();
            this.lbl_ReceiptNumber = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_ProductList
            // 
            this.lb_ProductList.FormattingEnabled = true;
            this.lb_ProductList.Location = new System.Drawing.Point(12, 136);
            this.lb_ProductList.Name = "lb_ProductList";
            this.lb_ProductList.Size = new System.Drawing.Size(263, 277);
            this.lb_ProductList.TabIndex = 0;
            // 
            // lbl_Masa
            // 
            this.lbl_Masa.AutoSize = true;
            this.lbl_Masa.Location = new System.Drawing.Point(60, 36);
            this.lbl_Masa.Name = "lbl_Masa";
            this.lbl_Masa.Size = new System.Drawing.Size(100, 13);
            this.lbl_Masa.TabIndex = 1;
            this.lbl_Masa.Text = "MASA NUMARASI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "FİŞ NUMARASI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TARİH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TOPLAM TUTAR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "YAZIYLA TOPLAM TUTAR:";
            // 
            // btn_ode
            // 
            this.btn_ode.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_ode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ode.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ode.Location = new System.Drawing.Point(93, 545);
            this.btn_ode.Name = "btn_ode";
            this.btn_ode.Size = new System.Drawing.Size(75, 23);
            this.btn_ode.TabIndex = 6;
            this.btn_ode.Text = "ÖDEME AL";
            this.btn_ode.UseVisualStyleBackColor = false;
            this.btn_ode.Click += new System.EventHandler(this.btn_ode_Click);
            // 
            // btn_newOther
            // 
            this.btn_newOther.BackColor = System.Drawing.Color.Orange;
            this.btn_newOther.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_newOther.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_newOther.Location = new System.Drawing.Point(174, 545);
            this.btn_newOther.Name = "btn_newOther";
            this.btn_newOther.Size = new System.Drawing.Size(88, 23);
            this.btn_newOther.TabIndex = 7;
            this.btn_newOther.Text = "SİPARİŞ EKLE";
            this.btn_newOther.UseVisualStyleBackColor = false;
            this.btn_newOther.Click += new System.EventHandler(this.btn_newOther_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(174, 462);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(13, 13);
            this.lbl_total.TabIndex = 8;
            this.lbl_total.Text = "0";
            // 
            // lbl_writeTotal
            // 
            this.lbl_writeTotal.AutoSize = true;
            this.lbl_writeTotal.Location = new System.Drawing.Point(174, 494);
            this.lbl_writeTotal.Name = "lbl_writeTotal";
            this.lbl_writeTotal.Size = new System.Drawing.Size(31, 13);
            this.lbl_writeTotal.TabIndex = 9;
            this.lbl_writeTotal.Text = "abcd";
            // 
            // lbl_masaNumber
            // 
            this.lbl_masaNumber.AutoSize = true;
            this.lbl_masaNumber.Location = new System.Drawing.Point(180, 36);
            this.lbl_masaNumber.Name = "lbl_masaNumber";
            this.lbl_masaNumber.Size = new System.Drawing.Size(31, 13);
            this.lbl_masaNumber.TabIndex = 10;
            this.lbl_masaNumber.Text = "0000";
            // 
            // lbl_ReceiptNumber
            // 
            this.lbl_ReceiptNumber.AutoSize = true;
            this.lbl_ReceiptNumber.Location = new System.Drawing.Point(180, 64);
            this.lbl_ReceiptNumber.Name = "lbl_ReceiptNumber";
            this.lbl_ReceiptNumber.Size = new System.Drawing.Size(31, 13);
            this.lbl_ReceiptNumber.TabIndex = 11;
            this.lbl_ReceiptNumber.Text = "0000";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(180, 95);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(53, 13);
            this.lbl_date.TabIndex = 12;
            this.lbl_date.Text = "00/00/00";
            // 
            // Frm_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 742);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_ReceiptNumber);
            this.Controls.Add(this.lbl_masaNumber);
            this.Controls.Add(this.lbl_writeTotal);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_newOther);
            this.Controls.Add(this.btn_ode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Masa);
            this.Controls.Add(this.lb_ProductList);
            this.Name = "Frm_Receipt";
            this.Text = "Frm_Receipt";
            this.Load += new System.EventHandler(this.Frm_Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_ProductList;
        private System.Windows.Forms.Label lbl_Masa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ode;
        private System.Windows.Forms.Button btn_newOther;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_writeTotal;
        private System.Windows.Forms.Label lbl_masaNumber;
        private System.Windows.Forms.Label lbl_ReceiptNumber;
        private System.Windows.Forms.Label lbl_date;
    }
}