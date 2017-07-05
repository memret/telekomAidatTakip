namespace telekomAidatTakip
{
    partial class frmYedekleme
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
            this.btnYedek = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.listYukle = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtYedek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYedek
            // 
            this.btnYedek.Location = new System.Drawing.Point(261, 19);
            this.btnYedek.Name = "btnYedek";
            this.btnYedek.Size = new System.Drawing.Size(78, 32);
            this.btnYedek.TabIndex = 0;
            this.btnYedek.Text = "Yedekle";
            this.btnYedek.UseVisualStyleBackColor = true;
            this.btnYedek.Click += new System.EventHandler(this.btnYedek_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYukle);
            this.groupBox1.Controls.Add(this.listYukle);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(351, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geri Yükleme";
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(126, 132);
            this.btnYukle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(78, 31);
            this.btnYukle.TabIndex = 3;
            this.btnYukle.Text = "Geri Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // listYukle
            // 
            this.listYukle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listYukle.FullRowSelect = true;
            this.listYukle.Location = new System.Drawing.Point(4, 17);
            this.listYukle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listYukle.Name = "listYukle";
            this.listYukle.Size = new System.Drawing.Size(335, 108);
            this.listYukle.TabIndex = 0;
            this.listYukle.UseCompatibleStateImageBehavior = false;
            this.listYukle.View = System.Windows.Forms.View.Details;
            this.listYukle.SelectedIndexChanged += new System.EventHandler(this.listYukle_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tarih";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Özel Not";
            this.columnHeader2.Width = 142;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtYedek);
            this.groupBox2.Controls.Add(this.btnYedek);
            this.groupBox2.Location = new System.Drawing.Point(11, 188);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(351, 62);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yedekleme";
            // 
            // txtYedek
            // 
            this.txtYedek.Location = new System.Drawing.Point(65, 26);
            this.txtYedek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtYedek.Name = "txtYedek";
            this.txtYedek.Size = new System.Drawing.Size(191, 20);
            this.txtYedek.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Özel Not:";
            // 
            // frmYedekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 258);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmYedekleme";
            this.Text = "Yedekleme";
            this.Load += new System.EventHandler(this.frmYedekleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYedek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listYukle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtYedek;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Label label1;
    }
}