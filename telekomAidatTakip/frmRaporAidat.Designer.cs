﻿namespace telekomAidatTakip
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
            this.İli = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpAramaKriterleri = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.checkOdemeyenler = new System.Windows.Forms.CheckBox();
            this.cboxBirim = new System.Windows.Forms.ComboBox();
            this.cboxMudurluk = new System.Windows.Forms.ComboBox();
            this.cboxil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listUyeKayitlari = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpAramaKriterleri.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // İli
            // 
            this.İli.AutoSize = true;
            this.İli.Location = new System.Drawing.Point(64, 34);
            this.İli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.İli.Name = "İli";
            this.İli.Size = new System.Drawing.Size(24, 20);
            this.İli.TabIndex = 0;
            this.İli.Text = "İli:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Müdürlüğü:";
            // 
            // grpAramaKriterleri
            // 
            this.grpAramaKriterleri.Controls.Add(this.dateTimePicker1);
            this.grpAramaKriterleri.Controls.Add(this.btnYazdir);
            this.grpAramaKriterleri.Controls.Add(this.btnListele);
            this.grpAramaKriterleri.Controls.Add(this.checkOdemeyenler);
            this.grpAramaKriterleri.Controls.Add(this.cboxBirim);
            this.grpAramaKriterleri.Controls.Add(this.cboxMudurluk);
            this.grpAramaKriterleri.Controls.Add(this.cboxil);
            this.grpAramaKriterleri.Controls.Add(this.label1);
            this.grpAramaKriterleri.Controls.Add(this.label2);
            this.grpAramaKriterleri.Controls.Add(this.label3);
            this.grpAramaKriterleri.Controls.Add(this.İli);
            this.grpAramaKriterleri.Location = new System.Drawing.Point(18, 18);
            this.grpAramaKriterleri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAramaKriterleri.Name = "grpAramaKriterleri";
            this.grpAramaKriterleri.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAramaKriterleri.Size = new System.Drawing.Size(976, 323);
            this.grpAramaKriterleri.TabIndex = 3;
            this.grpAramaKriterleri.TabStop = false;
            this.grpAramaKriterleri.Text = "Arama Kriterleri";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Location = new System.Drawing.Point(396, 246);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(158, 68);
            this.btnYazdir.TabIndex = 12;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(230, 246);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(158, 68);
            this.btnListele.TabIndex = 11;
            this.btnListele.Text = "Ekrana Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            // 
            // checkOdemeyenler
            // 
            this.checkOdemeyenler.AutoSize = true;
            this.checkOdemeyenler.Location = new System.Drawing.Point(230, 200);
            this.checkOdemeyenler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkOdemeyenler.Name = "checkOdemeyenler";
            this.checkOdemeyenler.Size = new System.Drawing.Size(182, 24);
            this.checkOdemeyenler.TabIndex = 10;
            this.checkOdemeyenler.Text = "Ödemeyenleri Listele";
            this.checkOdemeyenler.UseVisualStyleBackColor = true;
            // 
            // cboxBirim
            // 
            this.cboxBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBirim.FormattingEnabled = true;
            this.cboxBirim.Location = new System.Drawing.Point(230, 114);
            this.cboxBirim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxBirim.Name = "cboxBirim";
            this.cboxBirim.Size = new System.Drawing.Size(319, 28);
            this.cboxBirim.TabIndex = 6;
            // 
            // cboxMudurluk
            // 
            this.cboxMudurluk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMudurluk.FormattingEnabled = true;
            this.cboxMudurluk.Location = new System.Drawing.Point(230, 72);
            this.cboxMudurluk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxMudurluk.Name = "cboxMudurluk";
            this.cboxMudurluk.Size = new System.Drawing.Size(319, 28);
            this.cboxMudurluk.TabIndex = 5;
            this.cboxMudurluk.SelectedIndexChanged += new System.EventHandler(this.cboxMudurluk_SelectedIndexChanged_1);
            // 
            // cboxil
            // 
            this.cboxil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxil.FormattingEnabled = true;
            this.cboxil.Location = new System.Drawing.Point(230, 31);
            this.cboxil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxil.Name = "cboxil";
            this.cboxil.Size = new System.Drawing.Size(319, 28);
            this.cboxil.TabIndex = 4;
            this.cboxil.SelectedIndexChanged += new System.EventHandler(this.cboxil_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aidat Ayı ve Yılı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listUyeKayitlari);
            this.groupBox2.Location = new System.Drawing.Point(20, 368);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(975, 328);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bulunan Üye Kayıtları";
            // 
            // listUyeKayitlari
            // 
            this.listUyeKayitlari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listUyeKayitlari.Location = new System.Drawing.Point(10, 31);
            this.listUyeKayitlari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listUyeKayitlari.Name = "listUyeKayitlari";
            this.listUyeKayitlari.Size = new System.Drawing.Size(962, 286);
            this.listUyeKayitlari.TabIndex = 0;
            this.listUyeKayitlari.UseCompatibleStateImageBehavior = false;
            this.listUyeKayitlari.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "S.N.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Üye No";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Aidat";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Aidat Genel Toplamı";
            this.columnHeader5.Width = 123;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İl";
            this.columnHeader6.Width = 48;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Müdürlük";
            this.columnHeader7.Width = 83;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kısım";
            // 
            // frmRaporAidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 714);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpAramaKriterleri);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRaporAidat";
            this.Text = "frmAidatListesi";
            this.Load += new System.EventHandler(this.frmRaporAidat_Load);
            this.grpAramaKriterleri.ResumeLayout(false);
            this.grpAramaKriterleri.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label İli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpAramaKriterleri;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.CheckBox checkOdemeyenler;
        private System.Windows.Forms.ComboBox cboxBirim;
        private System.Windows.Forms.ComboBox cboxMudurluk;
        private System.Windows.Forms.ComboBox cboxil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listUyeKayitlari;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}