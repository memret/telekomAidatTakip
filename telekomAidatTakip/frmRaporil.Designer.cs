﻿namespace telekomAidatTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaporIl));
            this.gboxBulunanKayitlar = new System.Windows.Forms.GroupBox();
            this.listIl = new System.Windows.Forms.ListView();
            this.listIlNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listİlAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListAktif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListPasif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListToplam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkranaListele = new MetroFramework.Controls.MetroTile();
            this.btnYazdir = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboxBulunanKayitlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxBulunanKayitlar
            // 
            this.gboxBulunanKayitlar.Controls.Add(this.listIl);
            this.gboxBulunanKayitlar.Location = new System.Drawing.Point(12, 97);
            this.gboxBulunanKayitlar.Name = "gboxBulunanKayitlar";
            this.gboxBulunanKayitlar.Size = new System.Drawing.Size(455, 291);
            this.gboxBulunanKayitlar.TabIndex = 1;
            this.gboxBulunanKayitlar.TabStop = false;
            this.gboxBulunanKayitlar.Text = "Bulunan Kayıtlar";
            // 
            // listIl
            // 
            this.listIl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listIl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listIlNo,
            this.listİlAdi,
            this.ListAktif,
            this.ListPasif,
            this.ListToplam});
            this.listIl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listIl.FullRowSelect = true;
            this.listIl.Location = new System.Drawing.Point(3, 16);
            this.listIl.Name = "listIl";
            this.listIl.Size = new System.Drawing.Size(449, 272);
            this.listIl.TabIndex = 0;
            this.listIl.UseCompatibleStateImageBehavior = false;
            this.listIl.UseWaitCursor = true;
            this.listIl.View = System.Windows.Forms.View.Details;
            this.listIl.VirtualMode = true;
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
            // btnEkranaListele
            // 
            this.btnEkranaListele.ActiveControl = null;
            this.btnEkranaListele.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEkranaListele.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEkranaListele.Location = new System.Drawing.Point(217, 55);
            this.btnEkranaListele.Name = "btnEkranaListele";
            this.btnEkranaListele.Size = new System.Drawing.Size(122, 36);
            this.btnEkranaListele.TabIndex = 3;
            this.btnEkranaListele.Text = "Ekrana Listele";
            this.btnEkranaListele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEkranaListele.UseCustomBackColor = true;
            this.btnEkranaListele.UseCustomForeColor = true;
            this.btnEkranaListele.UseSelectable = true;
            this.btnEkranaListele.UseStyleColors = true;
            this.btnEkranaListele.UseTileImage = true;
            this.btnEkranaListele.UseWaitCursor = true;
            this.btnEkranaListele.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.ActiveControl = null;
            this.btnYazdir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnYazdir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYazdir.Location = new System.Drawing.Point(345, 55);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(122, 36);
            this.btnYazdir.TabIndex = 4;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYazdir.UseCustomBackColor = true;
            this.btnYazdir.UseCustomForeColor = true;
            this.btnYazdir.UseSelectable = true;
            this.btnYazdir.UseStyleColors = true;
            this.btnYazdir.UseTileImage = true;
            this.btnYazdir.UseWaitCursor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(178, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "İllere GöreÜye Dağılım Listesi";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 41);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmRaporIl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 398);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.gboxBulunanKayitlar);
            this.Controls.Add(this.btnEkranaListele);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "frmRaporIl";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "İl Raporları";
            this.Load += new System.EventHandler(this.frmRaporIl_Load);
            this.gboxBulunanKayitlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gboxBulunanKayitlar;
        private System.Windows.Forms.ListView listIl;
        private System.Windows.Forms.ColumnHeader ListAktif;
        private System.Windows.Forms.ColumnHeader ListPasif;
        private System.Windows.Forms.ColumnHeader ListToplam;
        private System.Windows.Forms.ColumnHeader listIlNo;
        private System.Windows.Forms.ColumnHeader listİlAdi;
        private MetroFramework.Controls.MetroTile btnEkranaListele;
        private MetroFramework.Controls.MetroTile btnYazdir;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}