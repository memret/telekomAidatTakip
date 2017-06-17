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
            this.İli = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpAramaKriterleri = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxİl = new System.Windows.Forms.ComboBox();
            this.cbxMudurluk = new System.Windows.Forms.ComboBox();
            this.cbxKisim = new System.Windows.Forms.ComboBox();
            this.cbxAy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxYil = new System.Windows.Forms.ComboBox();
            this.checkOdemeyenler = new System.Windows.Forms.CheckBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
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
            this.İli.Location = new System.Drawing.Point(43, 22);
            this.İli.Name = "İli";
            this.İli.Size = new System.Drawing.Size(17, 13);
            this.İli.TabIndex = 0;
            this.İli.Text = "İli:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kısım:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Müdürlüğü:";
            // 
            // grpAramaKriterleri
            // 
            this.grpAramaKriterleri.Controls.Add(this.btnYazdir);
            this.grpAramaKriterleri.Controls.Add(this.btnListele);
            this.grpAramaKriterleri.Controls.Add(this.checkOdemeyenler);
            this.grpAramaKriterleri.Controls.Add(this.cbxYil);
            this.grpAramaKriterleri.Controls.Add(this.label4);
            this.grpAramaKriterleri.Controls.Add(this.cbxAy);
            this.grpAramaKriterleri.Controls.Add(this.cbxKisim);
            this.grpAramaKriterleri.Controls.Add(this.cbxMudurluk);
            this.grpAramaKriterleri.Controls.Add(this.cbxİl);
            this.grpAramaKriterleri.Controls.Add(this.label1);
            this.grpAramaKriterleri.Controls.Add(this.label2);
            this.grpAramaKriterleri.Controls.Add(this.label3);
            this.grpAramaKriterleri.Controls.Add(this.İli);
            this.grpAramaKriterleri.Location = new System.Drawing.Point(12, 12);
            this.grpAramaKriterleri.Name = "grpAramaKriterleri";
            this.grpAramaKriterleri.Size = new System.Drawing.Size(651, 210);
            this.grpAramaKriterleri.TabIndex = 3;
            this.grpAramaKriterleri.TabStop = false;
            this.grpAramaKriterleri.Text = "Arama Kriterleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aidat Ayı ve Yılı:";
            // 
            // cbxİl
            // 
            this.cbxİl.FormattingEnabled = true;
            this.cbxİl.Location = new System.Drawing.Point(153, 20);
            this.cbxİl.Name = "cbxİl";
            this.cbxİl.Size = new System.Drawing.Size(214, 21);
            this.cbxİl.TabIndex = 4;
            // 
            // cbxMudurluk
            // 
            this.cbxMudurluk.FormattingEnabled = true;
            this.cbxMudurluk.Location = new System.Drawing.Point(153, 47);
            this.cbxMudurluk.Name = "cbxMudurluk";
            this.cbxMudurluk.Size = new System.Drawing.Size(214, 21);
            this.cbxMudurluk.TabIndex = 5;
            // 
            // cbxKisim
            // 
            this.cbxKisim.FormattingEnabled = true;
            this.cbxKisim.Location = new System.Drawing.Point(153, 74);
            this.cbxKisim.Name = "cbxKisim";
            this.cbxKisim.Size = new System.Drawing.Size(214, 21);
            this.cbxKisim.TabIndex = 6;
            // 
            // cbxAy
            // 
            this.cbxAy.FormattingEnabled = true;
            this.cbxAy.Location = new System.Drawing.Point(153, 102);
            this.cbxAy.Name = "cbxAy";
            this.cbxAy.Size = new System.Drawing.Size(91, 21);
            this.cbxAy.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "/";
            // 
            // cbxYil
            // 
            this.cbxYil.FormattingEnabled = true;
            this.cbxYil.Location = new System.Drawing.Point(276, 101);
            this.cbxYil.Name = "cbxYil";
            this.cbxYil.Size = new System.Drawing.Size(91, 21);
            this.cbxYil.TabIndex = 9;
            // 
            // checkOdemeyenler
            // 
            this.checkOdemeyenler.AutoSize = true;
            this.checkOdemeyenler.Location = new System.Drawing.Point(153, 130);
            this.checkOdemeyenler.Name = "checkOdemeyenler";
            this.checkOdemeyenler.Size = new System.Drawing.Size(123, 17);
            this.checkOdemeyenler.TabIndex = 10;
            this.checkOdemeyenler.Text = "Ödemeyenleri Listele";
            this.checkOdemeyenler.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(153, 160);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(105, 44);
            this.btnListele.TabIndex = 11;
            this.btnListele.Text = "Ekrana Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Location = new System.Drawing.Point(264, 160);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(105, 44);
            this.btnYazdir.TabIndex = 12;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listUyeKayitlari);
            this.groupBox2.Location = new System.Drawing.Point(13, 239);
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
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listUyeKayitlari.Location = new System.Drawing.Point(7, 20);
            this.listUyeKayitlari.Name = "listUyeKayitlari";
            this.listUyeKayitlari.Size = new System.Drawing.Size(643, 187);
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
            // frmAidatListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpAramaKriterleri);
            this.Name = "frmAidatListesi";
            this.Text = "frmAidatListesi";
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
        private System.Windows.Forms.ComboBox cbxYil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxAy;
        private System.Windows.Forms.ComboBox cbxKisim;
        private System.Windows.Forms.ComboBox cbxMudurluk;
        private System.Windows.Forms.ComboBox cbxİl;
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
    }
}