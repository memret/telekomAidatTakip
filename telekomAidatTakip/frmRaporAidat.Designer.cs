namespace telekomAidatTakip
{
    partial class frmRaporAidat
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
            this.grpAramaKriterleri = new System.Windows.Forms.GroupBox();
            this.btnYazdir = new MetroFramework.Controls.MetroTile();
            this.btnListele = new MetroFramework.Controls.MetroTile();
            this.checkBirim = new MetroFramework.Controls.MetroCheckBox();
            this.checkMudurluk = new MetroFramework.Controls.MetroCheckBox();
            this.checkIl = new MetroFramework.Controls.MetroCheckBox();
            this.cboxBirim = new MetroFramework.Controls.MetroComboBox();
            this.cboxMudurluk = new MetroFramework.Controls.MetroComboBox();
            this.cboxil = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listUyeKayitlari = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpAramaKriterleri.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAramaKriterleri
            // 
            this.grpAramaKriterleri.Controls.Add(this.btnYazdir);
            this.grpAramaKriterleri.Controls.Add(this.btnListele);
            this.grpAramaKriterleri.Controls.Add(this.checkBirim);
            this.grpAramaKriterleri.Controls.Add(this.checkMudurluk);
            this.grpAramaKriterleri.Controls.Add(this.checkIl);
            this.grpAramaKriterleri.Controls.Add(this.cboxBirim);
            this.grpAramaKriterleri.Controls.Add(this.cboxMudurluk);
            this.grpAramaKriterleri.Controls.Add(this.cboxil);
            this.grpAramaKriterleri.Location = new System.Drawing.Point(13, 52);
            this.grpAramaKriterleri.Name = "grpAramaKriterleri";
            this.grpAramaKriterleri.Size = new System.Drawing.Size(651, 196);
            this.grpAramaKriterleri.TabIndex = 3;
            this.grpAramaKriterleri.TabStop = false;
            this.grpAramaKriterleri.Text = "Arama Kriterleri";
            this.grpAramaKriterleri.Enter += new System.EventHandler(this.grpAramaKriterleri_Enter);
            // 
            // btnYazdir
            // 
            this.btnYazdir.ActiveControl = null;
            this.btnYazdir.Location = new System.Drawing.Point(268, 146);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(98, 44);
            this.btnYazdir.TabIndex = 23;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYazdir.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYazdir.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnYazdir.UseSelectable = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnListele
            // 
            this.btnListele.ActiveControl = null;
            this.btnListele.Location = new System.Drawing.Point(130, 146);
            this.btnListele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(98, 44);
            this.btnListele.TabIndex = 22;
            this.btnListele.Text = "Ekrana Listele";
            this.btnListele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnListele.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListele.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnListele.UseSelectable = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // checkBirim
            // 
            this.checkBirim.AutoSize = true;
            this.checkBirim.Location = new System.Drawing.Point(23, 104);
            this.checkBirim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBirim.Name = "checkBirim";
            this.checkBirim.Size = new System.Drawing.Size(54, 15);
            this.checkBirim.TabIndex = 19;
            this.checkBirim.Text = "Birim:";
            this.checkBirim.UseSelectable = true;
            this.checkBirim.CheckedChanged += new System.EventHandler(this.checkBirim_CheckedChanged);
            // 
            // checkMudurluk
            // 
            this.checkMudurluk.AutoSize = true;
            this.checkMudurluk.Location = new System.Drawing.Point(23, 65);
            this.checkMudurluk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkMudurluk.Name = "checkMudurluk";
            this.checkMudurluk.Size = new System.Drawing.Size(78, 15);
            this.checkMudurluk.TabIndex = 18;
            this.checkMudurluk.Text = "Müdürlük:";
            this.checkMudurluk.UseSelectable = true;
            this.checkMudurluk.CheckedChanged += new System.EventHandler(this.checkMudurluk_CheckedChanged);
            // 
            // checkIl
            // 
            this.checkIl.AutoSize = true;
            this.checkIl.Location = new System.Drawing.Point(23, 27);
            this.checkIl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkIl.Name = "checkIl";
            this.checkIl.Size = new System.Drawing.Size(32, 15);
            this.checkIl.TabIndex = 17;
            this.checkIl.Text = "İl:";
            this.checkIl.UseSelectable = true;
            this.checkIl.CheckedChanged += new System.EventHandler(this.checkIl_CheckedChanged);
            // 
            // cboxBirim
            // 
            this.cboxBirim.FormattingEnabled = true;
            this.cboxBirim.ItemHeight = 23;
            this.cboxBirim.Location = new System.Drawing.Point(153, 101);
            this.cboxBirim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxBirim.Name = "cboxBirim";
            this.cboxBirim.Size = new System.Drawing.Size(214, 29);
            this.cboxBirim.TabIndex = 16;
            this.cboxBirim.UseSelectable = true;
            // 
            // cboxMudurluk
            // 
            this.cboxMudurluk.FormattingEnabled = true;
            this.cboxMudurluk.ItemHeight = 23;
            this.cboxMudurluk.Location = new System.Drawing.Point(153, 60);
            this.cboxMudurluk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxMudurluk.Name = "cboxMudurluk";
            this.cboxMudurluk.Size = new System.Drawing.Size(214, 29);
            this.cboxMudurluk.TabIndex = 15;
            this.cboxMudurluk.UseSelectable = true;
            this.cboxMudurluk.SelectionChangeCommitted += new System.EventHandler(this.cboxMudurluk_SelectionChangeCommitted);
            // 
            // cboxil
            // 
            this.cboxil.ItemHeight = 23;
            this.cboxil.Location = new System.Drawing.Point(153, 19);
            this.cboxil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxil.Name = "cboxil";
            this.cboxil.Size = new System.Drawing.Size(214, 29);
            this.cboxil.TabIndex = 0;
            this.cboxil.UseSelectable = true;
            this.cboxil.SelectedIndexChanged += new System.EventHandler(this.cboxil_SelectedIndexChanged);
            this.cboxil.SelectionChangeCommitted += new System.EventHandler(this.cboxil_SelectionChangeCommitted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listUyeKayitlari);
            this.groupBox2.Location = new System.Drawing.Point(13, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 213);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bulunan Üye Kayıtları";
            // 
            // listUyeKayitlari
            // 
            this.listUyeKayitlari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listUyeKayitlari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUyeKayitlari.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listUyeKayitlari.FullRowSelect = true;
            this.listUyeKayitlari.Location = new System.Drawing.Point(3, 16);
            this.listUyeKayitlari.Name = "listUyeKayitlari";
            this.listUyeKayitlari.Size = new System.Drawing.Size(644, 194);
            this.listUyeKayitlari.TabIndex = 0;
            this.listUyeKayitlari.UseCompatibleStateImageBehavior = false;
            this.listUyeKayitlari.View = System.Windows.Forms.View.Details;
            this.listUyeKayitlari.DoubleClick += new System.EventHandler(this.listUyeKayitlari_DoubleClick);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Sicil No";
            this.columnHeader0.Width = 88;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad Soyad";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Aidat";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Genel Toplamı";
            this.columnHeader5.Width = 123;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İl";
            this.columnHeader6.Width = 71;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Müdürlük";
            this.columnHeader7.Width = 103;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Birim";
            this.columnHeader8.Width = 100;
            // 
            // frmRaporAidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpAramaKriterleri);
            this.Name = "frmRaporAidat";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Aidat Raporları";
            this.Load += new System.EventHandler(this.frmRaporAidat_Load);
            this.grpAramaKriterleri.ResumeLayout(false);
            this.grpAramaKriterleri.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpAramaKriterleri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listUyeKayitlari;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MetroFramework.Controls.MetroComboBox cboxil;
        private MetroFramework.Controls.MetroCheckBox checkMudurluk;
        private MetroFramework.Controls.MetroCheckBox checkIl;
        private MetroFramework.Controls.MetroComboBox cboxBirim;
        private MetroFramework.Controls.MetroComboBox cboxMudurluk;
        private MetroFramework.Controls.MetroCheckBox checkBirim;
        private MetroFramework.Controls.MetroTile btnListele;
        private MetroFramework.Controls.MetroTile btnYazdir;
    }
}