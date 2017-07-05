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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.dateTimeTarih = new System.Windows.Forms.DateTimePicker();
            this.tboxYorum = new System.Windows.Forms.TextBox();
            this.tboxmesaj = new System.Windows.Forms.TextBox();
            this.TboxMailBasligi = new System.Windows.Forms.MaskedTextBox();
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
            this.gboxOzelGunTanimlari.Location = new System.Drawing.Point(28, 18);
            this.gboxOzelGunTanimlari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxOzelGunTanimlari.Name = "gboxOzelGunTanimlari";
            this.gboxOzelGunTanimlari.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxOzelGunTanimlari.Size = new System.Drawing.Size(814, 455);
            this.gboxOzelGunTanimlari.TabIndex = 0;
            this.gboxOzelGunTanimlari.TabStop = false;
            this.gboxOzelGunTanimlari.Text = "Özel Gün Tanımları";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSil.Location = new System.Drawing.Point(644, 405);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(124, 40);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnKaydet.Location = new System.Drawing.Point(501, 406);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(134, 38);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnYeni.Location = new System.Drawing.Point(352, 406);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(140, 40);
            this.btnYeni.TabIndex = 12;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimeTarih
            // 
            this.dateTimeTarih.Location = new System.Drawing.Point(174, 97);
            this.dateTimeTarih.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimeTarih.Name = "dateTimeTarih";
            this.dateTimeTarih.Size = new System.Drawing.Size(432, 26);
            this.dateTimeTarih.TabIndex = 10;
            // 
            // tboxYorum
            // 
            this.tboxYorum.Location = new System.Drawing.Point(174, 257);
            this.tboxYorum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxYorum.Multiline = true;
            this.tboxYorum.Name = "tboxYorum";
            this.tboxYorum.Size = new System.Drawing.Size(432, 115);
            this.tboxYorum.TabIndex = 9;
            // 
            // tboxmesaj
            // 
            this.tboxmesaj.Location = new System.Drawing.Point(174, 137);
            this.tboxmesaj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxmesaj.Multiline = true;
            this.tboxmesaj.Name = "tboxmesaj";
            this.tboxmesaj.Size = new System.Drawing.Size(432, 109);
            this.tboxmesaj.TabIndex = 8;
            this.tboxmesaj.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TboxMailBasligi
            // 
            this.TboxMailBasligi.Location = new System.Drawing.Point(174, 48);
            this.TboxMailBasligi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TboxMailBasligi.Name = "TboxMailBasligi";
            this.TboxMailBasligi.Size = new System.Drawing.Size(432, 26);
            this.TboxMailBasligi.TabIndex = 0;
            // 
            // lblYorum
            // 
            this.lblYorum.AutoSize = true;
            this.lblYorum.Location = new System.Drawing.Point(51, 246);
            this.lblYorum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYorum.Name = "lblYorum";
            this.lblYorum.Size = new System.Drawing.Size(64, 20);
            this.lblYorum.TabIndex = 7;
            this.lblYorum.Text = "Yorum :";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(51, 168);
            this.lblMesaj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(59, 20);
            this.lblMesaj.TabIndex = 6;
            this.lblMesaj.Text = "Mesaj :";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(51, 106);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(52, 20);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "Tarih :";
            // 
            // lblMailBasligi
            // 
            this.lblMailBasligi.AutoSize = true;
            this.lblMailBasligi.Location = new System.Drawing.Point(51, 52);
            this.lblMailBasligi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMailBasligi.Name = "lblMailBasligi";
            this.lblMailBasligi.Size = new System.Drawing.Size(95, 20);
            this.lblMailBasligi.TabIndex = 1;
            this.lblMailBasligi.Text = "Mail Başlığı :";
            this.lblMailBasligi.Click += new System.EventHandler(this.label2_Click);
            // 
            // gboxTabloGosterimi
            // 
            this.gboxTabloGosterimi.Controls.Add(this.listView1);
            this.gboxTabloGosterimi.Location = new System.Drawing.Point(28, 483);
            this.gboxTabloGosterimi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxTabloGosterimi.Name = "gboxTabloGosterimi";
            this.gboxTabloGosterimi.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxTabloGosterimi.Size = new System.Drawing.Size(814, 228);
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
            this.listView1.Location = new System.Drawing.Point(4, 32);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(790, 192);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 722);
            this.Controls.Add(this.gboxTabloGosterimi);
            this.Controls.Add(this.gboxOzelGunTanimlari);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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