
namespace RESTAURANT_ORDER_SYSTEM
{
    partial class FrmNewTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewTable));
            this.cb_TableName = new System.Windows.Forms.ComboBox();
            this.cb_HowManyTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddTable = new System.Windows.Forms.Button();
            this.lbl_addTableError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_TableName
            // 
            this.cb_TableName.FormattingEnabled = true;
            this.cb_TableName.Location = new System.Drawing.Point(156, 97);
            this.cb_TableName.Name = "cb_TableName";
            this.cb_TableName.Size = new System.Drawing.Size(121, 21);
            this.cb_TableName.TabIndex = 0;
            // 
            // cb_HowManyTable
            // 
            this.cb_HowManyTable.FormattingEnabled = true;
            this.cb_HowManyTable.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10"});
            this.cb_HowManyTable.Location = new System.Drawing.Point(156, 141);
            this.cb_HowManyTable.Name = "cb_HowManyTable";
            this.cb_HowManyTable.Size = new System.Drawing.Size(32, 21);
            this.cb_HowManyTable.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Table Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "How Many Table?";
            // 
            // btn_AddTable
            // 
            this.btn_AddTable.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_AddTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AddTable.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_AddTable.Location = new System.Drawing.Point(156, 178);
            this.btn_AddTable.Name = "btn_AddTable";
            this.btn_AddTable.Size = new System.Drawing.Size(75, 23);
            this.btn_AddTable.TabIndex = 4;
            this.btn_AddTable.Text = "ADD";
            this.btn_AddTable.UseVisualStyleBackColor = false;
            this.btn_AddTable.Click += new System.EventHandler(this.btn_AddTable_Click);
            // 
            // lbl_addTableError
            // 
            this.lbl_addTableError.AutoSize = true;
            this.lbl_addTableError.Location = new System.Drawing.Point(117, 228);
            this.lbl_addTableError.Name = "lbl_addTableError";
            this.lbl_addTableError.Size = new System.Drawing.Size(0, 13);
            this.lbl_addTableError.TabIndex = 5;
            // 
            // FrmNewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(409, 290);
            this.Controls.Add(this.lbl_addTableError);
            this.Controls.Add(this.btn_AddTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_HowManyTable);
            this.Controls.Add(this.cb_TableName);
            this.Name = "FrmNewTable";
            this.Text = "FrmNewTable";
            this.Load += new System.EventHandler(this.FrmNewTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_TableName;
        private System.Windows.Forms.ComboBox cb_HowManyTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddTable;
        private System.Windows.Forms.Label lbl_addTableError;
    }
}