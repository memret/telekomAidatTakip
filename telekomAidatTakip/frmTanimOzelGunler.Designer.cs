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
            this.gboxTabloGosterimi = new System.Windows.Forms.GroupBox();
            this.lblMailBasligi = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblYorum = new System.Windows.Forms.Label();
            this.TboxMailBasligi = new System.Windows.Forms.MaskedTextBox();
            this.tboxmesaj = new System.Windows.Forms.TextBox();
            this.tboxYorum = new System.Windows.Forms.TextBox();
            this.dateTimeTarih = new System.Windows.Forms.DateTimePicker();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gboxOzelGunTanimlari.SuspendLayout();
            this.gboxTabloGosterimi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxOzelGunTanimlari
            // 
            this.gboxOzelGunTanimlari.Controls.Add(this.btnSil);
            this.gboxOzelGunTanimlari.Controls.Add(this.btnKaydet);
            this.gboxOzelGunTanimlari.Controls.Add(this.btnYeni);
            this.gboxOzelGunTanimlari.Controls.Add(this.dateTimeTarih);
            this.gboxOzelGunTanimlari.Controls.Add(this.tboxYorum);
            this.gboxOzelGunTanimlari.Controls.Add(this.tboxmesaj);
            this.gboxOzelGunTanimlari.Controls.Add(this.TboxMailBasligi);
            this.gboxOzelGunTanimlari.Controls.Add(this.lblYorum);
            this.gboxOzelGunTanimlari.Controls.Add(this.lblMesaj);
            this.gboxOzelGunTanimlari.Controls.Add(this.lblTarih);
            this.gboxOzelGunTanimlari.Controls.Add(this.lblMailBasligi);
            this.gboxOzelGunTanimlari.Location = new System.Drawing.Point(19, 12);
            this.gboxOzelGunTanimlari.Name = "gboxOzelGunTanimlari";
            this.gboxOzelGunTanimlari.Size = new System.Drawing.Size(543, 296);
            this.gboxOzelGunTanimlari.TabIndex = 0;
            this.gboxOzelGunTanimlari.TabStop = false;
            this.gboxOzelGunTanimlari.Text = "Özel Gün Tanımları";
            // 
            // gboxTabloGosterimi
            // 
            this.gboxTabloGosterimi.Controls.Add(this.listView1);
            this.gboxTabloGosterimi.Location = new System.Drawing.Point(19, 314);
            this.gboxTabloGosterimi.Name = "gboxTabloGosterimi";
            this.gboxTabloGosterimi.Size = new System.Drawing.Size(543, 148);
            this.gboxTabloGosterimi.TabIndex = 1;
            this.gboxTabloGosterimi.TabStop = false;
            this.gboxTabloGosterimi.Text = "Tablo Gösterimi";
            // 
            // lblMailBasligi
            // 
            this.lblMailBasligi.AutoSize = true;
            this.lblMailBasligi.Location = new System.Drawing.Point(34, 34);
            this.lblMailBasligi.Name = "lblMailBasligi";
            this.lblMailBasligi.Size = new System.Drawing.Size(65, 13);
            this.lblMailBasligi.TabIndex = 1;
            this.lblMailBasligi.Text = "Mail Başlığı :";
            this.lblMailBasligi.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(34, 69);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(37, 13);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "Tarih :";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(34, 109);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(41, 13);
            this.lblMesaj.TabIndex = 6;
            this.lblMesaj.Text = "Mesaj :";
            // 
            // lblYorum
            // 
            this.lblYorum.AutoSize = true;
            this.lblYorum.Location = new System.Drawing.Point(34, 160);
            this.lblYorum.Name = "lblYorum";
            this.lblYorum.Size = new System.Drawing.Size(43, 13);
            this.lblYorum.TabIndex = 7;
            this.lblYorum.Text = "Yorum :";
            // 
            // TboxMailBasligi
            // 
            this.TboxMailBasligi.Location = new System.Drawing.Point(116, 31);
            this.TboxMailBasligi.Name = "TboxMailBasligi";
            this.TboxMailBasligi.Size = new System.Drawing.Size(289, 20);
            this.TboxMailBasligi.TabIndex = 0;
            // 
            // tboxmesaj
            // 
            this.tboxmesaj.Location = new System.Drawing.Point(116, 89);
            this.tboxmesaj.Multiline = true;
            this.tboxmesaj.Name = "tboxmesaj";
            this.tboxmesaj.Size = new System.Drawing.Size(289, 72);
            this.tboxmesaj.TabIndex = 8;
            this.tboxmesaj.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tboxYorum
            // 
            this.tboxYorum.Location = new System.Drawing.Point(116, 167);
            this.tboxYorum.Multiline = true;
            this.tboxYorum.Name = "tboxYorum";
            this.tboxYorum.Size = new System.Drawing.Size(289, 76);
            this.tboxYorum.TabIndex = 9;
            // 
            // dateTimeTarih
            // 
            this.dateTimeTarih.Location = new System.Drawing.Point(116, 63);
            this.dateTimeTarih.Name = "dateTimeTarih";
            this.dateTimeTarih.Size = new System.Drawing.Size(289, 20);
            this.dateTimeTarih.TabIndex = 10;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(235, 264);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(93, 26);
            this.btnYeni.TabIndex = 12;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(334, 264);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(89, 25);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(429, 263);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 26);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(3, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(528, 126);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // frmTanimOzelGunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 469);
            this.Controls.Add(this.gboxTabloGosterimi);
            this.Controls.Add(this.gboxOzelGunTanimlari);
            this.Name = "frmTanimOzelGunler";
            this.Text = "frmTanimOzelGunler";
            this.Load += new System.EventHandler(this.frmTanimOzelGunler_Load);
            this.gboxOzelGunTanimlari.ResumeLayout(false);
            this.gboxOzelGunTanimlari.PerformLayout();
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
        private System.Windows.Forms.TextBox tboxYorum;
        private System.Windows.Forms.TextBox tboxmesaj;
        private System.Windows.Forms.MaskedTextBox TboxMailBasligi;
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
    }
}