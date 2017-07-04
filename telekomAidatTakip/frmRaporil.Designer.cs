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
            this.Listİl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListAktif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListPasif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListToplam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listIl = new System.Windows.Forms.ListView();
            this.gboxListelemeİslemi.SuspendLayout();
            this.gboxBulunanKayitlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxListelemeİslemi
            // 
            this.gboxListelemeİslemi.Controls.Add(this.btnYazdir);
            this.gboxListelemeİslemi.Controls.Add(this.btnEkranaListele);
            this.gboxListelemeİslemi.Controls.Add(this.label1);
            this.gboxListelemeİslemi.Location = new System.Drawing.Point(6, 8);
            this.gboxListelemeİslemi.Name = "gboxListelemeİslemi";
            this.gboxListelemeİslemi.Size = new System.Drawing.Size(564, 100);
            this.gboxListelemeİslemi.TabIndex = 0;
            this.gboxListelemeİslemi.TabStop = false;
            this.gboxListelemeİslemi.Text = "Listeleme İşlemi";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(477, 59);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(78, 31);
            this.btnYazdir.TabIndex = 2;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            // 
            // btnEkranaListele
            // 
            this.btnEkranaListele.Location = new System.Drawing.Point(388, 59);
            this.btnEkranaListele.Name = "btnEkranaListele";
            this.btnEkranaListele.Size = new System.Drawing.Size(83, 31);
            this.btnEkranaListele.TabIndex = 1;
            this.btnEkranaListele.Text = "Ekrana Listele";
            this.btnEkranaListele.UseVisualStyleBackColor = true;
            this.btnEkranaListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İllere Göre Üye Dağılım Listesi";
            // 
            // gboxBulunanKayitlar
            // 
            this.gboxBulunanKayitlar.Controls.Add(this.listIl);
            this.gboxBulunanKayitlar.Location = new System.Drawing.Point(6, 114);
            this.gboxBulunanKayitlar.Name = "gboxBulunanKayitlar";
            this.gboxBulunanKayitlar.Size = new System.Drawing.Size(564, 279);
            this.gboxBulunanKayitlar.TabIndex = 1;
            this.gboxBulunanKayitlar.TabStop = false;
            this.gboxBulunanKayitlar.Text = "Bulunan Kayıtlar";
            // 
            // Listİl
            // 
            this.Listİl.Text = "İli";
            this.Listİl.Width = 99;
            // 
            // ListAktif
            // 
            this.ListAktif.Text = "Aktif";
            this.ListAktif.Width = 86;
            // 
            // ListPasif
            // 
            this.ListPasif.Text = "Pasif";
            this.ListPasif.Width = 87;
            // 
            // ListToplam
            // 
            this.ListToplam.Text = "Toplam";
            this.ListToplam.Width = 92;
            // 
            // listIl
            // 
            this.listIl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Listİl,
            this.ListAktif,
            this.ListPasif,
            this.ListToplam});
            this.listIl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listIl.Location = new System.Drawing.Point(3, 16);
            this.listIl.Name = "listIl";
            this.listIl.Size = new System.Drawing.Size(558, 260);
            this.listIl.TabIndex = 0;
            this.listIl.UseCompatibleStateImageBehavior = false;
            this.listIl.View = System.Windows.Forms.View.Details;
            // 
            // frmRaporIl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 399);
            this.Controls.Add(this.gboxBulunanKayitlar);
            this.Controls.Add(this.gboxListelemeİslemi);
            this.Name = "frmRaporIl";
            this.Text = "İl Raporları";
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
        private System.Windows.Forms.ColumnHeader Listİl;
        private System.Windows.Forms.ColumnHeader ListAktif;
        private System.Windows.Forms.ColumnHeader ListPasif;
        private System.Windows.Forms.ColumnHeader ListToplam;
    }
}