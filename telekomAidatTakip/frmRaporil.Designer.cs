namespace telekomAidatTakip
{
    partial class frmRaporIl
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
            this.gboxListelemeİslemi = new System.Windows.Forms.GroupBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnEkranaListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxBulunanKayitlar = new System.Windows.Forms.GroupBox();
            this.listIl = new System.Windows.Forms.ListView();
            this.listIlNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listİlAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListAktif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListPasif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListToplam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gboxListelemeİslemi.SuspendLayout();
            this.gboxBulunanKayitlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxListelemeİslemi
            // 
            this.gboxListelemeİslemi.Controls.Add(this.btnYazdir);
            this.gboxListelemeİslemi.Controls.Add(this.btnEkranaListele);
            this.gboxListelemeİslemi.Controls.Add(this.label1);
            this.gboxListelemeİslemi.Location = new System.Drawing.Point(9, 12);
            this.gboxListelemeİslemi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxListelemeİslemi.Name = "gboxListelemeİslemi";
            this.gboxListelemeİslemi.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxListelemeİslemi.Size = new System.Drawing.Size(846, 154);
            this.gboxListelemeİslemi.TabIndex = 0;
            this.gboxListelemeİslemi.TabStop = false;
            this.gboxListelemeİslemi.Text = "Listeleme İşlemi";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnYazdir.Location = new System.Drawing.Point(716, 91);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(117, 48);
            this.btnYazdir.TabIndex = 2;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnEkranaListele
            // 
            this.btnEkranaListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnEkranaListele.Location = new System.Drawing.Point(519, 91);
            this.btnEkranaListele.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEkranaListele.Name = "btnEkranaListele";
            this.btnEkranaListele.Size = new System.Drawing.Size(187, 48);
            this.btnEkranaListele.TabIndex = 1;
            this.btnEkranaListele.Text = "Ekrana Listele";
            this.btnEkranaListele.UseVisualStyleBackColor = true;
            this.btnEkranaListele.Click += new System.EventHandler(this.btnEkranaListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İllere Göre Üye Dağılım Listesi";
            // 
            // gboxBulunanKayitlar
            // 
            this.gboxBulunanKayitlar.Controls.Add(this.listIl);
            this.gboxBulunanKayitlar.Location = new System.Drawing.Point(9, 175);
            this.gboxBulunanKayitlar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxBulunanKayitlar.Name = "gboxBulunanKayitlar";
            this.gboxBulunanKayitlar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxBulunanKayitlar.Size = new System.Drawing.Size(846, 429);
            this.gboxBulunanKayitlar.TabIndex = 1;
            this.gboxBulunanKayitlar.TabStop = false;
            this.gboxBulunanKayitlar.Text = "Bulunan Kayıtlar";
            // 
            // listIl
            // 
            this.listIl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listIlNo,
            this.listİlAdi,
            this.ListAktif,
            this.ListPasif,
            this.ListToplam});
            this.listIl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listIl.FullRowSelect = true;
            this.listIl.Location = new System.Drawing.Point(4, 24);
            this.listIl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listIl.Name = "listIl";
            this.listIl.Size = new System.Drawing.Size(838, 400);
            this.listIl.TabIndex = 0;
            this.listIl.UseCompatibleStateImageBehavior = false;
            this.listIl.View = System.Windows.Forms.View.Details;
            this.listIl.SelectedIndexChanged += new System.EventHandler(this.listIl_SelectedIndexChanged);
            this.listIl.DoubleClick += new System.EventHandler(this.listIl_DoubleClick);
            // 
            // listIlNo
            // 
            this.listIlNo.Text = "İl No";
            this.listIlNo.Width = 91;
            // 
            // listİlAdi
            // 
            this.listİlAdi.Text = "İl";
            this.listİlAdi.Width = 76;
            // 
            // ListAktif
            // 
            this.ListAktif.Text = "Aktif";
            this.ListAktif.Width = 87;
            // 
            // ListPasif
            // 
            this.ListPasif.Text = "Pasif";
            this.ListPasif.Width = 90;
            // 
            // ListToplam
            // 
            this.ListToplam.Text = "Toplam";
            this.ListToplam.Width = 98;
            // 
            // frmRaporIl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 614);
            this.Controls.Add(this.gboxBulunanKayitlar);
            this.Controls.Add(this.gboxListelemeİslemi);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRaporIl";
            this.Text = "İl Raporları";
            this.Load += new System.EventHandler(this.frmRaporIl_Load);
            this.gboxListelemeİslemi.ResumeLayout(false);
            this.gboxListelemeİslemi.PerformLayout();
            this.gboxBulunanKayitlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxListelemeİslemi;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnEkranaListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboxBulunanKayitlar;
        private System.Windows.Forms.ListView listIl;
        private System.Windows.Forms.ColumnHeader ListAktif;
        private System.Windows.Forms.ColumnHeader ListPasif;
        private System.Windows.Forms.ColumnHeader ListToplam;
        private System.Windows.Forms.ColumnHeader listIlNo;
        private System.Windows.Forms.ColumnHeader listİlAdi;
    }
}