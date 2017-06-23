namespace telekomAidatTakip
{
    partial class frmRaporUye
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkKanGrubu = new System.Windows.Forms.CheckBox();
            this.checkUyelik = new System.Windows.Forms.CheckBox();
            this.checkTahsil = new System.Windows.Forms.CheckBox();
            this.checkUnvan = new System.Windows.Forms.CheckBox();
            this.checkKisim = new System.Windows.Forms.CheckBox();
            this.checkMudurluk = new System.Windows.Forms.CheckBox();
            this.checkIl = new System.Windows.Forms.CheckBox();
            this.cSilinmisKayıt = new System.Windows.Forms.CheckBox();
            this.btnEkranaListele = new System.Windows.Forms.Button();
            this.cboxKanGrubu = new System.Windows.Forms.ComboBox();
            this.cboxUyelikDurumu = new System.Windows.Forms.ComboBox();
            this.cboxTahsil = new System.Windows.Forms.ComboBox();
            this.cboxUnvan = new System.Windows.Forms.ComboBox();
            this.cboxKısım = new System.Windows.Forms.ComboBox();
            this.cboxMudurluk = new System.Windows.Forms.ComboBox();
            this.cboxII = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listUye = new System.Windows.Forms.ListView();
            this.ListSiraNumarasi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListAdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListKurumSicil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListKanGrubu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListIlMudurlukKısım = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListUnvan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListTahsil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnYazdir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkKanGrubu);
            this.groupBox1.Controls.Add(this.checkUyelik);
            this.groupBox1.Controls.Add(this.checkTahsil);
            this.groupBox1.Controls.Add(this.checkUnvan);
            this.groupBox1.Controls.Add(this.checkKisim);
            this.groupBox1.Controls.Add(this.checkMudurluk);
            this.groupBox1.Controls.Add(this.checkIl);
            this.groupBox1.Controls.Add(this.cSilinmisKayıt);
            this.groupBox1.Controls.Add(this.btnEkranaListele);
            this.groupBox1.Controls.Add(this.cboxKanGrubu);
            this.groupBox1.Controls.Add(this.cboxUyelikDurumu);
            this.groupBox1.Controls.Add(this.cboxTahsil);
            this.groupBox1.Controls.Add(this.cboxUnvan);
            this.groupBox1.Controls.Add(this.cboxKısım);
            this.groupBox1.Controls.Add(this.cboxMudurluk);
            this.groupBox1.Controls.Add(this.cboxII);
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Kriterleri :";
            // 
            // checkKanGrubu
            // 
            this.checkKanGrubu.AutoSize = true;
            this.checkKanGrubu.Location = new System.Drawing.Point(13, 178);
            this.checkKanGrubu.Name = "checkKanGrubu";
            this.checkKanGrubu.Size = new System.Drawing.Size(80, 17);
            this.checkKanGrubu.TabIndex = 13;
            this.checkKanGrubu.Text = "Kan Grubu:";
            this.checkKanGrubu.UseVisualStyleBackColor = true;
            this.checkKanGrubu.CheckedChanged += new System.EventHandler(this.checkKanGrubu_CheckedChanged);
            // 
            // checkUyelik
            // 
            this.checkUyelik.AutoSize = true;
            this.checkUyelik.Location = new System.Drawing.Point(13, 152);
            this.checkUyelik.Name = "checkUyelik";
            this.checkUyelik.Size = new System.Drawing.Size(69, 17);
            this.checkUyelik.TabIndex = 12;
            this.checkUyelik.Text = "Üyelik D:";
            this.checkUyelik.UseVisualStyleBackColor = true;
            this.checkUyelik.CheckedChanged += new System.EventHandler(this.checkUyelik_CheckedChanged);
            // 
            // checkTahsil
            // 
            this.checkTahsil.AutoSize = true;
            this.checkTahsil.Location = new System.Drawing.Point(13, 126);
            this.checkTahsil.Name = "checkTahsil";
            this.checkTahsil.Size = new System.Drawing.Size(57, 17);
            this.checkTahsil.TabIndex = 11;
            this.checkTahsil.Text = "Tahsil:";
            this.checkTahsil.UseVisualStyleBackColor = true;
            this.checkTahsil.CheckedChanged += new System.EventHandler(this.checkTahsil_CheckedChanged);
            // 
            // checkUnvan
            // 
            this.checkUnvan.AutoSize = true;
            this.checkUnvan.Location = new System.Drawing.Point(13, 100);
            this.checkUnvan.Name = "checkUnvan";
            this.checkUnvan.Size = new System.Drawing.Size(61, 17);
            this.checkUnvan.TabIndex = 10;
            this.checkUnvan.Text = "Ünvan:";
            this.checkUnvan.UseVisualStyleBackColor = true;
            this.checkUnvan.CheckedChanged += new System.EventHandler(this.checkUnvan_CheckedChanged);
            // 
            // checkKisim
            // 
            this.checkKisim.AutoSize = true;
            this.checkKisim.Enabled = false;
            this.checkKisim.Location = new System.Drawing.Point(13, 74);
            this.checkKisim.Name = "checkKisim";
            this.checkKisim.Size = new System.Drawing.Size(53, 17);
            this.checkKisim.TabIndex = 9;
            this.checkKisim.Text = "Kısım:";
            this.checkKisim.UseVisualStyleBackColor = true;
            this.checkKisim.CheckedChanged += new System.EventHandler(this.checkKisim_CheckedChanged);
            // 
            // checkMudurluk
            // 
            this.checkMudurluk.AutoSize = true;
            this.checkMudurluk.Enabled = false;
            this.checkMudurluk.Location = new System.Drawing.Point(13, 48);
            this.checkMudurluk.Name = "checkMudurluk";
            this.checkMudurluk.Size = new System.Drawing.Size(73, 17);
            this.checkMudurluk.TabIndex = 8;
            this.checkMudurluk.Text = "Müdürlük:";
            this.checkMudurluk.UseVisualStyleBackColor = true;
            this.checkMudurluk.CheckedChanged += new System.EventHandler(this.checkMudurluk_CheckedChanged);
            // 
            // checkIl
            // 
            this.checkIl.AutoSize = true;
            this.checkIl.Location = new System.Drawing.Point(13, 22);
            this.checkIl.Name = "checkIl";
            this.checkIl.Size = new System.Drawing.Size(34, 17);
            this.checkIl.TabIndex = 7;
            this.checkIl.Text = "İl:";
            this.checkIl.UseVisualStyleBackColor = true;
            this.checkIl.CheckedChanged += new System.EventHandler(this.checkIl_CheckedChanged);
            // 
            // cSilinmisKayıt
            // 
            this.cSilinmisKayıt.AutoSize = true;
            this.cSilinmisKayıt.Location = new System.Drawing.Point(13, 204);
            this.cSilinmisKayıt.Name = "cSilinmisKayıt";
            this.cSilinmisKayıt.Size = new System.Drawing.Size(132, 17);
            this.cSilinmisKayıt.TabIndex = 6;
            this.cSilinmisKayıt.Text = "Silinmiş Kayıtları Listele";
            this.cSilinmisKayıt.UseVisualStyleBackColor = true;
            // 
            // btnEkranaListele
            // 
            this.btnEkranaListele.Location = new System.Drawing.Point(446, 220);
            this.btnEkranaListele.Name = "btnEkranaListele";
            this.btnEkranaListele.Size = new System.Drawing.Size(90, 36);
            this.btnEkranaListele.TabIndex = 5;
            this.btnEkranaListele.Text = "Ekrana Listele";
            this.btnEkranaListele.UseVisualStyleBackColor = true;
            this.btnEkranaListele.Click += new System.EventHandler(this.btnEkranaListele_Click);
            // 
            // cboxKanGrubu
            // 
            this.cboxKanGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxKanGrubu.Enabled = false;
            this.cboxKanGrubu.FormattingEnabled = true;
            this.cboxKanGrubu.Location = new System.Drawing.Point(101, 176);
            this.cboxKanGrubu.Name = "cboxKanGrubu";
            this.cboxKanGrubu.Size = new System.Drawing.Size(92, 21);
            this.cboxKanGrubu.TabIndex = 0;
            // 
            // cboxUyelikDurumu
            // 
            this.cboxUyelikDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUyelikDurumu.Enabled = false;
            this.cboxUyelikDurumu.FormattingEnabled = true;
            this.cboxUyelikDurumu.Location = new System.Drawing.Point(101, 150);
            this.cboxUyelikDurumu.Name = "cboxUyelikDurumu";
            this.cboxUyelikDurumu.Size = new System.Drawing.Size(187, 21);
            this.cboxUyelikDurumu.TabIndex = 0;
            // 
            // cboxTahsil
            // 
            this.cboxTahsil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTahsil.Enabled = false;
            this.cboxTahsil.FormattingEnabled = true;
            this.cboxTahsil.Location = new System.Drawing.Point(101, 124);
            this.cboxTahsil.Name = "cboxTahsil";
            this.cboxTahsil.Size = new System.Drawing.Size(260, 21);
            this.cboxTahsil.TabIndex = 0;
            // 
            // cboxUnvan
            // 
            this.cboxUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUnvan.Enabled = false;
            this.cboxUnvan.FormattingEnabled = true;
            this.cboxUnvan.Location = new System.Drawing.Point(101, 98);
            this.cboxUnvan.Name = "cboxUnvan";
            this.cboxUnvan.Size = new System.Drawing.Size(260, 21);
            this.cboxUnvan.TabIndex = 0;
            // 
            // cboxKısım
            // 
            this.cboxKısım.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxKısım.Enabled = false;
            this.cboxKısım.FormattingEnabled = true;
            this.cboxKısım.Location = new System.Drawing.Point(101, 72);
            this.cboxKısım.Name = "cboxKısım";
            this.cboxKısım.Size = new System.Drawing.Size(386, 21);
            this.cboxKısım.TabIndex = 0;
            // 
            // cboxMudurluk
            // 
            this.cboxMudurluk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMudurluk.Enabled = false;
            this.cboxMudurluk.FormattingEnabled = true;
            this.cboxMudurluk.Location = new System.Drawing.Point(101, 46);
            this.cboxMudurluk.Name = "cboxMudurluk";
            this.cboxMudurluk.Size = new System.Drawing.Size(386, 21);
            this.cboxMudurluk.TabIndex = 0;
            this.cboxMudurluk.SelectedIndexChanged += new System.EventHandler(this.cboxMudurluk_SelectedIndexChanged);
            // 
            // cboxII
            // 
            this.cboxII.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxII.Enabled = false;
            this.cboxII.FormattingEnabled = true;
            this.cboxII.Location = new System.Drawing.Point(101, 20);
            this.cboxII.Name = "cboxII";
            this.cboxII.Size = new System.Drawing.Size(386, 21);
            this.cboxII.TabIndex = 0;
            this.cboxII.SelectedIndexChanged += new System.EventHandler(this.cboxII_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listUye);
            this.groupBox2.Location = new System.Drawing.Point(6, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 227);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bulunan Üye Kayıtları";
            // 
            // listUye
            // 
            this.listUye.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListSiraNumarasi,
            this.ListAdSoyad,
            this.ListKurumSicil,
            this.ListKanGrubu,
            this.ListIlMudurlukKısım,
            this.ListUnvan,
            this.ListTahsil});
            this.listUye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUye.Location = new System.Drawing.Point(3, 16);
            this.listUye.Name = "listUye";
            this.listUye.Size = new System.Drawing.Size(773, 208);
            this.listUye.TabIndex = 0;
            this.listUye.UseCompatibleStateImageBehavior = false;
            this.listUye.View = System.Windows.Forms.View.Details;
            // 
            // ListSiraNumarasi
            // 
            this.ListSiraNumarasi.Text = "S.N";
            this.ListSiraNumarasi.Width = 90;
            // 
            // ListAdSoyad
            // 
            this.ListAdSoyad.Text = "Ad Soyad";
            this.ListAdSoyad.Width = 141;
            // 
            // ListKurumSicil
            // 
            this.ListKurumSicil.Text = "Kurum Sicil";
            this.ListKurumSicil.Width = 96;
            // 
            // ListKanGrubu
            // 
            this.ListKanGrubu.Text = "Kan Grubu";
            this.ListKanGrubu.Width = 41;
            // 
            // ListIlMudurlukKısım
            // 
            this.ListIlMudurlukKısım.Text = "İl/Müdürlük/Kısım";
            this.ListIlMudurlukKısım.Width = 169;
            // 
            // ListUnvan
            // 
            this.ListUnvan.Text = "Ünvan";
            this.ListUnvan.Width = 103;
            // 
            // ListTahsil
            // 
            this.ListTahsil.Text = "Tahsil";
            this.ListTahsil.Width = 100;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(548, 229);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(89, 37);
            this.btnYazdir.TabIndex = 6;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            // 
            // frmRaporUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 511);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRaporUye";
            this.Text = "frmUyeListele";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cSilinmisKayıt;
        private System.Windows.Forms.Button btnEkranaListele;
        private System.Windows.Forms.ComboBox cboxKanGrubu;
        private System.Windows.Forms.ComboBox cboxUyelikDurumu;
        private System.Windows.Forms.ComboBox cboxTahsil;
        private System.Windows.Forms.ComboBox cboxUnvan;
        private System.Windows.Forms.ComboBox cboxKısım;
        private System.Windows.Forms.ComboBox cboxMudurluk;
        private System.Windows.Forms.ComboBox cboxII;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listUye;
        private System.Windows.Forms.ColumnHeader ListSiraNumarasi;
        private System.Windows.Forms.ColumnHeader ListAdSoyad;
        private System.Windows.Forms.ColumnHeader ListKurumSicil;
        private System.Windows.Forms.ColumnHeader ListKanGrubu;
        private System.Windows.Forms.ColumnHeader ListIlMudurlukKısım;
        private System.Windows.Forms.ColumnHeader ListUnvan;
        private System.Windows.Forms.ColumnHeader ListTahsil;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.CheckBox checkKanGrubu;
        private System.Windows.Forms.CheckBox checkUyelik;
        private System.Windows.Forms.CheckBox checkTahsil;
        private System.Windows.Forms.CheckBox checkUnvan;
        private System.Windows.Forms.CheckBox checkKisim;
        private System.Windows.Forms.CheckBox checkMudurluk;
        private System.Windows.Forms.CheckBox checkIl;
    }
}