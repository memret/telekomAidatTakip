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
            this.txtGünNo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxOzelGunTanimlari.SuspendLayout();
            this.gboxTabloGosterimi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxOzelGunTanimlari
            // 
            this.gboxOzelGunTanimlari.Controls.Add(this.txtGünNo);
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
            this.gboxOzelGunTanimlari.Location = new System.Drawing.Point(25, 13);
            this.gboxOzelGunTanimlari.Margin = new System.Windows.Forms.Padding(4);
            this.gboxOzelGunTanimlari.Name = "gboxOzelGunTanimlari";
            this.gboxOzelGunTanimlari.Padding = new System.Windows.Forms.Padding(4);
            this.gboxOzelGunTanimlari.Size = new System.Drawing.Size(724, 403);
            this.gboxOzelGunTanimlari.TabIndex = 0;
            this.gboxOzelGunTanimlari.TabStop = false;
            this.gboxOzelGunTanimlari.Text = "Özel Gün Tanımları";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(573, 355);
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
            this.btnKaydet.Location = new System.Drawing.Point(446, 356);
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
            this.btnYeni.Location = new System.Drawing.Point(314, 356);
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
            this.dateTimeTarih.Location = new System.Drawing.Point(156, 109);
            this.dateTimeTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeTarih.Name = "dateTimeTarih";
            this.dateTimeTarih.Size = new System.Drawing.Size(384, 22);
            this.dateTimeTarih.TabIndex = 10;
            // 
            // txtYorum
            // 
            this.txtYorum.Location = new System.Drawing.Point(156, 237);
            this.txtYorum.Margin = new System.Windows.Forms.Padding(4);
            this.txtYorum.Multiline = true;
            this.txtYorum.Name = "txtYorum";
            this.txtYorum.Size = new System.Drawing.Size(384, 93);
            this.txtYorum.TabIndex = 9;
            // 
            // txtMsj
            // 
            this.txtMsj.Location = new System.Drawing.Point(156, 141);
            this.txtMsj.Margin = new System.Windows.Forms.Padding(4);
            this.txtMsj.Multiline = true;
            this.txtMsj.Name = "txtMsj";
            this.txtMsj.Size = new System.Drawing.Size(384, 88);
            this.txtMsj.TabIndex = 8;
            this.txtMsj.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(156, 69);
            this.txtBaslik.Margin = new System.Windows.Forms.Padding(4);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(384, 22);
            this.txtBaslik.TabIndex = 0;
            this.txtBaslik.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TboxMailBasligi_MaskInputRejected);
            // 
            // lblYorum
            // 
            this.lblYorum.AutoSize = true;
            this.lblYorum.Location = new System.Drawing.Point(46, 228);
            this.lblYorum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYorum.Name = "lblYorum";
            this.lblYorum.Size = new System.Drawing.Size(57, 17);
            this.lblYorum.TabIndex = 7;
            this.lblYorum.Text = "Yorum :";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(46, 165);
            this.lblMesaj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(53, 17);
            this.lblMesaj.TabIndex = 6;
            this.lblMesaj.Text = "Mesaj :";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(46, 116);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(49, 17);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "Tarih :";
            // 
            // lblMailBasligi
            // 
            this.lblMailBasligi.AutoSize = true;
            this.lblMailBasligi.Location = new System.Drawing.Point(46, 73);
            this.lblMailBasligi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMailBasligi.Name = "lblMailBasligi";
            this.lblMailBasligi.Size = new System.Drawing.Size(86, 17);
            this.lblMailBasligi.TabIndex = 1;
            this.lblMailBasligi.Text = "Mail Başlığı :";
            this.lblMailBasligi.Click += new System.EventHandler(this.label2_Click);
            // 
            // gboxTabloGosterimi
            // 
            this.gboxTabloGosterimi.Controls.Add(this.listView1);
            this.gboxTabloGosterimi.Location = new System.Drawing.Point(25, 427);
            this.gboxTabloGosterimi.Margin = new System.Windows.Forms.Padding(4);
            this.gboxTabloGosterimi.Name = "gboxTabloGosterimi";
            this.gboxTabloGosterimi.Padding = new System.Windows.Forms.Padding(4);
            this.gboxTabloGosterimi.Size = new System.Drawing.Size(724, 190);
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
            this.listView1.Location = new System.Drawing.Point(4, 26);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(703, 154);
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
            // txtGünNo
            // 
            this.txtGünNo.Enabled = false;
            this.txtGünNo.Location = new System.Drawing.Point(156, 31);
            this.txtGünNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtGünNo.Name = "txtGünNo";
            this.txtGünNo.Size = new System.Drawing.Size(384, 22);
            this.txtGünNo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Özel Gün No :";
            // 
            // frmTanimOzelGunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 620);
            this.Controls.Add(this.gboxTabloGosterimi);
            this.Controls.Add(this.gboxOzelGunTanimlari);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.MaskedTextBox txtGünNo;
        private System.Windows.Forms.Label label1;
    }
}