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
            this.label1 = new System.Windows.Forms.Label();
            this.txtYedek = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYedek
            // 
            this.btnYedek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnYedek.Location = new System.Drawing.Point(392, 29);
            this.btnYedek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYedek.Name = "btnYedek";
            this.btnYedek.Size = new System.Drawing.Size(117, 49);
            this.btnYedek.TabIndex = 0;
            this.btnYedek.Text = "Yedekle";
            this.btnYedek.UseVisualStyleBackColor = true;
            this.btnYedek.Click += new System.EventHandler(this.btnYedek_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYukle);
            this.groupBox1.Controls.Add(this.listYukle);
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geri Yükleme";
            // 
            // btnYukle
            // 
            this.btnYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnYukle.Location = new System.Drawing.Point(189, 203);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(157, 48);
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
            this.listYukle.Location = new System.Drawing.Point(6, 26);
            this.listYukle.Name = "listYukle";
            this.listYukle.Size = new System.Drawing.Size(500, 164);
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
            this.groupBox2.Location = new System.Drawing.Point(16, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 95);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yedekleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Özel Not:";
            // 
            // txtYedek
            // 
            this.txtYedek.Location = new System.Drawing.Point(98, 40);
            this.txtYedek.Name = "txtYedek";
            this.txtYedek.Size = new System.Drawing.Size(284, 26);
            this.txtYedek.TabIndex = 0;
            // 
            // frmYedekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 397);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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