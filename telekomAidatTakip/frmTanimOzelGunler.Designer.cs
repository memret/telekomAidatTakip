namespace telekomAidatTakip
{
    partial class frmTanimOzelGunler
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
            this.gboxOzelGunTanimlari = new System.Windows.Forms.GroupBox();
            this.grpDegiskenler = new System.Windows.Forms.GroupBox();
            this.txtGunNo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.dateTimeTarih = new System.Windows.Forms.DateTimePicker();
            this.txtYorum = new System.Windows.Forms.TextBox();
            this.txtMsj = new System.Windows.Forms.TextBox();
            this.txtBaslik = new System.Windows.Forms.MaskedTextBox();
            this.lblYorum = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblMailBasligi = new System.Windows.Forms.Label();
            this.gboxTabloGosterimi = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdi = new System.Windows.Forms.Button();
            this.btnSehir = new System.Windows.Forms.Button();
            this.btnMudurluk = new System.Windows.Forms.Button();
            this.btnBirim = new System.Windows.Forms.Button();
            this.btnSicilNo = new System.Windows.Forms.Button();
            this.gboxOzelGunTanimlari.SuspendLayout();
            this.grpDegiskenler.SuspendLayout();
            this.gboxTabloGosterimi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxOzelGunTanimlari
            // 
            this.gboxOzelGunTanimlari.Controls.Add(this.grpDegiskenler);
            this.gboxOzelGunTanimlari.Controls.Add(this.txtGunNo);
            this.gboxOzelGunTanimlari.Controls.Add(this.label1);
            this.gboxOzelGunTanimlari.Controls.Add(this.btnSil);
            this.gboxOzelGunTanimlari.Controls.Add(this.btnKaydet);
            this.gboxOzelGunTanimlari.Controls.Add(this.btnYeni);
            this.gboxOzelGunTanimlari.Controls.Add(this.dateTimeTarih);
            this.gboxOzelGunTanimlari.Controls.Add(this.txtYorum);
            this.gboxOzelGunTanimlari.Controls.Add(this.txtMsj);
            this.gboxOzelGunTanimlari.Controls.Add(this.txtBaslik);
            this.gboxOzelGunTanimlari.Controls.Add(this.lblYorum);
            this.gboxOzelGunTanimlari.Controls.Add(this.lblMesaj);
            this.gboxOzelGunTanimlari.Controls.Add(this.lblTarih);
            this.gboxOzelGunTanimlari.Controls.Add(this.lblMailBasligi);
            this.gboxOzelGunTanimlari.Location = new System.Drawing.Point(25, 14);
            this.gboxOzelGunTanimlari.Margin = new System.Windows.Forms.Padding(4);
            this.gboxOzelGunTanimlari.Name = "gboxOzelGunTanimlari";
            this.gboxOzelGunTanimlari.Padding = new System.Windows.Forms.Padding(4);
            this.gboxOzelGunTanimlari.Size = new System.Drawing.Size(727, 402);
            this.gboxOzelGunTanimlari.TabIndex = 0;
            this.gboxOzelGunTanimlari.TabStop = false;
            this.gboxOzelGunTanimlari.Text = "Özel Gün Tanımları";
            // 
            // grpDegiskenler
            // 
            this.grpDegiskenler.Controls.Add(this.btnSicilNo);
            this.grpDegiskenler.Controls.Add(this.btnBirim);
            this.grpDegiskenler.Controls.Add(this.btnMudurluk);
            this.grpDegiskenler.Controls.Add(this.btnSehir);
            this.grpDegiskenler.Controls.Add(this.btnAdi);
            this.grpDegiskenler.Location = new System.Drawing.Point(548, 22);
            this.grpDegiskenler.Name = "grpDegiskenler";
            this.grpDegiskenler.Size = new System.Drawing.Size(162, 309);
            this.grpDegiskenler.TabIndex = 17;
            this.grpDegiskenler.TabStop = false;
            this.grpDegiskenler.Text = "Değişkenler";
            // 
            // txtGunNo
            // 
            this.txtGunNo.Enabled = false;
            this.txtGunNo.Location = new System.Drawing.Point(156, 31);
            this.txtGunNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtGunNo.Name = "txtGunNo";
            this.txtGunNo.Size = new System.Drawing.Size(384, 22);
            this.txtGunNo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Özel Gün No :";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(599, 348);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(111, 32);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(471, 350);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(119, 31);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(340, 350);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(124, 32);
            this.btnYeni.TabIndex = 12;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // dateTimeTarih
            // 
            this.dateTimeTarih.Location = new System.Drawing.Point(156, 110);
            this.dateTimeTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeTarih.Name = "dateTimeTarih";
            this.dateTimeTarih.Size = new System.Drawing.Size(384, 22);
            this.dateTimeTarih.TabIndex = 10;
            // 
            // txtYorum
            // 
            this.txtYorum.Location = new System.Drawing.Point(156, 238);
            this.txtYorum.Margin = new System.Windows.Forms.Padding(4);
            this.txtYorum.Multiline = true;
            this.txtYorum.Name = "txtYorum";
            this.txtYorum.Size = new System.Drawing.Size(384, 93);
            this.txtYorum.TabIndex = 9;
            // 
            // txtMsj
            // 


            this.txtMsj.Location = new System.Drawing.Point(156, 142);
            this.txtMsj.Margin = new System.Windows.Forms.Padding(4);
            this.txtMsj.Multiline = true;
            this.txtMsj.Name = "txtMsj";
            this.txtMsj.Size = new System.Drawing.Size(384, 88);
            this.txtMsj.TabIndex = 8;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(156, 69);
            this.txtBaslik.Margin = new System.Windows.Forms.Padding(4);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(384, 22);
            this.txtBaslik.TabIndex = 0;
            // 
            // lblYorum
            // 
            this.lblYorum.AutoSize = true;
            this.lblYorum.Location = new System.Drawing.Point(45, 228);
            this.lblYorum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYorum.Name = "lblYorum";
            this.lblYorum.Size = new System.Drawing.Size(57, 17);
            this.lblYorum.TabIndex = 7;
            this.lblYorum.Text = "Yorum :";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(45, 165);
            this.lblMesaj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(53, 17);
            this.lblMesaj.TabIndex = 6;
            this.lblMesaj.Text = "Mesaj :";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(45, 116);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(49, 17);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "Tarih :";
            // 
            // lblMailBasligi
            // 
            this.lblMailBasligi.AutoSize = true;
            this.lblMailBasligi.Location = new System.Drawing.Point(45, 73);
            this.lblMailBasligi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMailBasligi.Name = "lblMailBasligi";
            this.lblMailBasligi.Size = new System.Drawing.Size(86, 17);
            this.lblMailBasligi.TabIndex = 1;
            this.lblMailBasligi.Text = "Mail Başlığı :";
            // 
            // gboxTabloGosterimi
            // 
            this.gboxTabloGosterimi.Controls.Add(this.listView1);
            this.gboxTabloGosterimi.Location = new System.Drawing.Point(25, 423);
            this.gboxTabloGosterimi.Margin = new System.Windows.Forms.Padding(4);
            this.gboxTabloGosterimi.Name = "gboxTabloGosterimi";
            this.gboxTabloGosterimi.Padding = new System.Windows.Forms.Padding(4);
            this.gboxTabloGosterimi.Size = new System.Drawing.Size(727, 191);
            this.gboxTabloGosterimi.TabIndex = 1;
            this.gboxTabloGosterimi.TabStop = false;
            this.gboxTabloGosterimi.Text = "Tablo Gösterimi";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(4, 26);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(703, 154);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Özel Gün No";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mail Başlığı";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarih";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mesaj";
            this.columnHeader4.Width = 134;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yorum";
            this.columnHeader5.Width = 185;
            // 
            // btnAdi
            // 
            this.btnAdi.Enabled = false;
            this.btnAdi.Location = new System.Drawing.Point(6, 31);
            this.btnAdi.Name = "btnAdi";
            this.btnAdi.Size = new System.Drawing.Size(149, 25);
            this.btnAdi.TabIndex = 0;
            this.btnAdi.Text = "Ad Soyad";
            this.btnAdi.UseVisualStyleBackColor = true;
            this.btnAdi.Click += new System.EventHandler(this.btnAdi_Click);
            // 
            // btnSehir
            // 
            this.btnSehir.Enabled = false;
            this.btnSehir.Location = new System.Drawing.Point(6, 95);
            this.btnSehir.Name = "btnSehir";
            this.btnSehir.Size = new System.Drawing.Size(149, 25);
            this.btnSehir.TabIndex = 1;
            this.btnSehir.Text = "Şehir";
            this.btnSehir.UseVisualStyleBackColor = true;
            this.btnSehir.Click += new System.EventHandler(this.btnSehir_Click);
            // 
            // btnMudurluk
            // 
            this.btnMudurluk.Enabled = false;
            this.btnMudurluk.Location = new System.Drawing.Point(6, 126);
            this.btnMudurluk.Name = "btnMudurluk";
            this.btnMudurluk.Size = new System.Drawing.Size(149, 25);
            this.btnMudurluk.TabIndex = 2;
            this.btnMudurluk.Text = "Müdürlük";
            this.btnMudurluk.UseVisualStyleBackColor = true;
            this.btnMudurluk.Click += new System.EventHandler(this.btnMudurluk_Click);
            // 
            // btnBirim
            // 
            this.btnBirim.Enabled = false;
            this.btnBirim.Location = new System.Drawing.Point(7, 157);
            this.btnBirim.Name = "btnBirim";
            this.btnBirim.Size = new System.Drawing.Size(149, 25);
            this.btnBirim.TabIndex = 3;
            this.btnBirim.Text = "Birim";
            this.btnBirim.UseVisualStyleBackColor = true;
            this.btnBirim.Click += new System.EventHandler(this.btnBirim_Click);
            // 
            // btnSicilNo
            // 
            this.btnSicilNo.Enabled = false;
            this.btnSicilNo.Location = new System.Drawing.Point(6, 64);
            this.btnSicilNo.Name = "btnSicilNo";
            this.btnSicilNo.Size = new System.Drawing.Size(149, 25);
            this.btnSicilNo.TabIndex = 4;
            this.btnSicilNo.Text = "SicilNo";
            this.btnSicilNo.UseVisualStyleBackColor = true;
            this.btnSicilNo.Click += new System.EventHandler(this.btnSicilNo_Click);
            // 
            // frmTanimOzelGunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 623);
            this.Controls.Add(this.gboxTabloGosterimi);
            this.Controls.Add(this.gboxOzelGunTanimlari);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(801, 660);
            this.Name = "frmTanimOzelGunler";
            this.Text = "frmTanimOzelGunler";
            this.Load += new System.EventHandler(this.frmTanimOzelGunler_Load);
            this.Resize += new System.EventHandler(this.frmTanimOzelGunler_Resize);
            this.gboxOzelGunTanimlari.ResumeLayout(false);
            this.gboxOzelGunTanimlari.PerformLayout();
            this.grpDegiskenler.ResumeLayout(false);
            this.gboxTabloGosterimi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxOzelGunTanimlari;
        private System.Windows.Forms.GroupBox gboxTabloGosterimi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.DateTimePicker dateTimeTarih;
        private System.Windows.Forms.TextBox txtYorum;
        private System.Windows.Forms.TextBox txtMsj;
        private System.Windows.Forms.MaskedTextBox txtBaslik;
        private System.Windows.Forms.Label lblYorum;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblMailBasligi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.MaskedTextBox txtGunNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDegiskenler;
        private System.Windows.Forms.Button btnAdi;
        private System.Windows.Forms.Button btnSicilNo;
        private System.Windows.Forms.Button btnBirim;
        private System.Windows.Forms.Button btnMudurluk;
        private System.Windows.Forms.Button btnSehir;
    }
}