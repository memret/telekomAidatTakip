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
            this.btnYazdir = new System.Windows.Forms.Button();
            this.checkKanGrubu = new System.Windows.Forms.CheckBox();
            this.checkUyelik = new System.Windows.Forms.CheckBox();
            this.checkTahsil = new System.Windows.Forms.CheckBox();
            this.checkUnvan = new System.Windows.Forms.CheckBox();
            this.checkKisim = new System.Windows.Forms.CheckBox();
            this.checkMudurluk = new System.Windows.Forms.CheckBox();
            this.checkIl = new System.Windows.Forms.CheckBox();
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
            this.ListKurumSicil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListAdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListKanGrubu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListIlMudurlukKısım = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListUnvan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListTahsil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioHepsi = new System.Windows.Forms.RadioButton();
            this.radioPasif = new System.Windows.Forms.RadioButton();
            this.radioAktif = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioHepsi);
            this.groupBox1.Controls.Add(this.radioPasif);
            this.groupBox1.Controls.Add(this.radioAktif);
            this.groupBox1.Controls.Add(this.btnYazdir);
            this.groupBox1.Controls.Add(this.checkKanGrubu);
            this.groupBox1.Controls.Add(this.checkUyelik);
            this.groupBox1.Controls.Add(this.checkTahsil);
            this.groupBox1.Controls.Add(this.checkUnvan);
            this.groupBox1.Controls.Add(this.checkKisim);
            this.groupBox1.Controls.Add(this.checkMudurluk);
            this.groupBox1.Controls.Add(this.checkIl);
            this.groupBox1.Controls.Add(this.btnEkranaListele);
            this.groupBox1.Controls.Add(this.cboxKanGrubu);
            this.groupBox1.Controls.Add(this.cboxUyelikDurumu);
            this.groupBox1.Controls.Add(this.cboxTahsil);
            this.groupBox1.Controls.Add(this.cboxUnvan);
            this.groupBox1.Controls.Add(this.cboxKısım);
            this.groupBox1.Controls.Add(this.cboxMudurluk);
            this.groupBox1.Controls.Add(this.cboxII);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(908, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Kriterleri :";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Enabled = false;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnYazdir.Location = new System.Drawing.Point(775, 220);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(119, 46);
            this.btnYazdir.TabIndex = 6;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // checkKanGrubu
            // 
            this.checkKanGrubu.AutoSize = true;
            this.checkKanGrubu.Location = new System.Drawing.Point(17, 219);
            this.checkKanGrubu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkKanGrubu.Name = "checkKanGrubu";
            this.checkKanGrubu.Size = new System.Drawing.Size(103, 21);
            this.checkKanGrubu.TabIndex = 13;
            this.checkKanGrubu.Text = "Kan Grubu:";
            this.checkKanGrubu.UseVisualStyleBackColor = true;
            this.checkKanGrubu.CheckedChanged += new System.EventHandler(this.checkKanGrubu_CheckedChanged);
            // 
            // checkUyelik
            // 
            this.checkUyelik.AutoSize = true;
            this.checkUyelik.Location = new System.Drawing.Point(17, 187);
            this.checkUyelik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkUyelik.Name = "checkUyelik";
            this.checkUyelik.Size = new System.Drawing.Size(86, 21);
            this.checkUyelik.TabIndex = 12;
            this.checkUyelik.Text = "Üyelik D:";
            this.checkUyelik.UseVisualStyleBackColor = true;
            this.checkUyelik.CheckedChanged += new System.EventHandler(this.checkUyelik_CheckedChanged);
            // 
            // checkTahsil
            // 
            this.checkTahsil.AutoSize = true;
            this.checkTahsil.Location = new System.Drawing.Point(17, 155);
            this.checkTahsil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkTahsil.Name = "checkTahsil";
            this.checkTahsil.Size = new System.Drawing.Size(72, 21);
            this.checkTahsil.TabIndex = 11;
            this.checkTahsil.Text = "Tahsil:";
            this.checkTahsil.UseVisualStyleBackColor = true;
            this.checkTahsil.CheckedChanged += new System.EventHandler(this.checkTahsil_CheckedChanged);
            // 
            // checkUnvan
            // 
            this.checkUnvan.AutoSize = true;
            this.checkUnvan.Location = new System.Drawing.Point(17, 123);
            this.checkUnvan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkUnvan.Name = "checkUnvan";
            this.checkUnvan.Size = new System.Drawing.Size(75, 21);
            this.checkUnvan.TabIndex = 10;
            this.checkUnvan.Text = "Ünvan:";
            this.checkUnvan.UseVisualStyleBackColor = true;
            this.checkUnvan.CheckedChanged += new System.EventHandler(this.checkUnvan_CheckedChanged);
            // 
            // checkKisim
            // 
            this.checkKisim.AutoSize = true;
            this.checkKisim.Enabled = false;
            this.checkKisim.Location = new System.Drawing.Point(17, 91);
            this.checkKisim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkKisim.Name = "checkKisim";
            this.checkKisim.Size = new System.Drawing.Size(65, 21);
            this.checkKisim.TabIndex = 9;
            this.checkKisim.Text = "Birim:";
            this.checkKisim.UseVisualStyleBackColor = true;
            this.checkKisim.CheckedChanged += new System.EventHandler(this.checkKisim_CheckedChanged);
            // 
            // checkMudurluk
            // 
            this.checkMudurluk.AutoSize = true;
            this.checkMudurluk.Enabled = false;
            this.checkMudurluk.Location = new System.Drawing.Point(17, 59);
            this.checkMudurluk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkMudurluk.Name = "checkMudurluk";
            this.checkMudurluk.Size = new System.Drawing.Size(92, 21);
            this.checkMudurluk.TabIndex = 8;
            this.checkMudurluk.Text = "Müdürlük:";
            this.checkMudurluk.UseVisualStyleBackColor = true;
            this.checkMudurluk.CheckedChanged += new System.EventHandler(this.checkMudurluk_CheckedChanged);
            // 
            // checkIl
            // 
            this.checkIl.AutoSize = true;
            this.checkIl.Location = new System.Drawing.Point(17, 27);
            this.checkIl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkIl.Name = "checkIl";
            this.checkIl.Size = new System.Drawing.Size(40, 21);
            this.checkIl.TabIndex = 7;
            this.checkIl.Text = "İl:";
            this.checkIl.UseVisualStyleBackColor = true;
            this.checkIl.CheckedChanged += new System.EventHandler(this.checkIl_CheckedChanged);
            // 
            // btnEkranaListele
            // 
            this.btnEkranaListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnEkranaListele.Location = new System.Drawing.Point(595, 220);
            this.btnEkranaListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkranaListele.Name = "btnEkranaListele";
            this.btnEkranaListele.Size = new System.Drawing.Size(172, 46);
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
            this.cboxKanGrubu.Location = new System.Drawing.Point(135, 217);
            this.cboxKanGrubu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxKanGrubu.Name = "cboxKanGrubu";
            this.cboxKanGrubu.Size = new System.Drawing.Size(121, 24);
            this.cboxKanGrubu.TabIndex = 0;
            // 
            // cboxUyelikDurumu
            // 
            this.cboxUyelikDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUyelikDurumu.Enabled = false;
            this.cboxUyelikDurumu.FormattingEnabled = true;
            this.cboxUyelikDurumu.Location = new System.Drawing.Point(135, 185);
            this.cboxUyelikDurumu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxUyelikDurumu.Name = "cboxUyelikDurumu";
            this.cboxUyelikDurumu.Size = new System.Drawing.Size(248, 24);
            this.cboxUyelikDurumu.TabIndex = 0;
            // 
            // cboxTahsil
            // 
            this.cboxTahsil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTahsil.Enabled = false;
            this.cboxTahsil.FormattingEnabled = true;
            this.cboxTahsil.Location = new System.Drawing.Point(135, 153);
            this.cboxTahsil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxTahsil.Name = "cboxTahsil";
            this.cboxTahsil.Size = new System.Drawing.Size(345, 24);
            this.cboxTahsil.TabIndex = 0;
            // 
            // cboxUnvan
            // 
            this.cboxUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUnvan.Enabled = false;
            this.cboxUnvan.FormattingEnabled = true;
            this.cboxUnvan.Location = new System.Drawing.Point(135, 121);
            this.cboxUnvan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxUnvan.Name = "cboxUnvan";
            this.cboxUnvan.Size = new System.Drawing.Size(345, 24);
            this.cboxUnvan.TabIndex = 0;
            // 
            // cboxKısım
            // 
            this.cboxKısım.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxKısım.Enabled = false;
            this.cboxKısım.FormattingEnabled = true;
            this.cboxKısım.Location = new System.Drawing.Point(135, 89);
            this.cboxKısım.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxKısım.Name = "cboxKısım";
            this.cboxKısım.Size = new System.Drawing.Size(513, 24);
            this.cboxKısım.TabIndex = 0;
            // 
            // cboxMudurluk
            // 
            this.cboxMudurluk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMudurluk.Enabled = false;
            this.cboxMudurluk.FormattingEnabled = true;
            this.cboxMudurluk.Location = new System.Drawing.Point(135, 57);
            this.cboxMudurluk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxMudurluk.Name = "cboxMudurluk";
            this.cboxMudurluk.Size = new System.Drawing.Size(513, 24);
            this.cboxMudurluk.TabIndex = 0;
            this.cboxMudurluk.SelectionChangeCommitted += new System.EventHandler(this.cboxMudurluk_SelectionChangeCommitted);
            // 
            // cboxII
            // 
            this.cboxII.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxII.Enabled = false;
            this.cboxII.FormattingEnabled = true;
            this.cboxII.Location = new System.Drawing.Point(135, 25);
            this.cboxII.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxII.Name = "cboxII";
            this.cboxII.Size = new System.Drawing.Size(513, 24);
            this.cboxII.TabIndex = 0;
            this.cboxII.SelectedIndexChanged += new System.EventHandler(this.cboxII_SelectedIndexChanged);
            this.cboxII.SelectionChangeCommitted += new System.EventHandler(this.cboxII_SelectionChangeCommitted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listUye);
            this.groupBox2.Location = new System.Drawing.Point(16, 304);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(912, 279);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bulunan Üye Kayıtları";
            // 
            // listUye
            // 
            this.listUye.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListKurumSicil,
            this.ListAdSoyad,
            this.ListKanGrubu,
            this.ListIlMudurlukKısım,
            this.ListUnvan,
            this.ListTahsil});
            this.listUye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUye.FullRowSelect = true;
            this.listUye.Location = new System.Drawing.Point(4, 19);
            this.listUye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listUye.Name = "listUye";
            this.listUye.Size = new System.Drawing.Size(904, 256);
            this.listUye.TabIndex = 0;
            this.listUye.UseCompatibleStateImageBehavior = false;
            this.listUye.View = System.Windows.Forms.View.Details;
            this.listUye.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listUye_MouseDoubleClick);
            // 
            // ListKurumSicil
            // 
            this.ListKurumSicil.Text = "Sicil No";
            this.ListKurumSicil.Width = 78;
            // 
            // ListAdSoyad
            // 
            this.ListAdSoyad.Text = "Ad Soyad";
            this.ListAdSoyad.Width = 141;
            // 
            // ListKanGrubu
            // 
            this.ListKanGrubu.Text = "Kan Grubu";
            this.ListKanGrubu.Width = 67;
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
            this.ListTahsil.Width = 106;
            // 
            // radioHepsi
            // 
            this.radioHepsi.AutoSize = true;
            this.radioHepsi.Location = new System.Drawing.Point(281, 254);
            this.radioHepsi.Name = "radioHepsi";
            this.radioHepsi.Size = new System.Drawing.Size(102, 21);
            this.radioHepsi.TabIndex = 15;
            this.radioHepsi.TabStop = true;
            this.radioHepsi.Text = "Tüm Üyeler";
            this.radioHepsi.UseVisualStyleBackColor = true;
            // 
            // radioPasif
            // 
            this.radioPasif.AutoSize = true;
            this.radioPasif.Location = new System.Drawing.Point(170, 254);
            this.radioPasif.Name = "radioPasif";
            this.radioPasif.Size = new System.Drawing.Size(105, 21);
            this.radioPasif.TabIndex = 16;
            this.radioPasif.TabStop = true;
            this.radioPasif.Text = "Pasif Üyeler";
            this.radioPasif.UseVisualStyleBackColor = true;
            // 
            // radioAktif
            // 
            this.radioAktif.AutoSize = true;
            this.radioAktif.Location = new System.Drawing.Point(63, 254);
            this.radioAktif.Name = "radioAktif";
            this.radioAktif.Size = new System.Drawing.Size(101, 21);
            this.radioAktif.TabIndex = 17;
            this.radioAktif.TabStop = true;
            this.radioAktif.Text = "Aktif Üyeler";
            this.radioAktif.UseVisualStyleBackColor = true;
            // 
            // frmRaporUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 597);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRaporUye";
            this.Text = "Üye Raporu";
            this.Load += new System.EventHandler(this.frmRaporUye_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.RadioButton radioHepsi;
        private System.Windows.Forms.RadioButton radioPasif;
        private System.Windows.Forms.RadioButton radioAktif;
    }
}