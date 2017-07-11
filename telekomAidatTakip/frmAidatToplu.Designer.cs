namespace telekomAidatTakip
{
    partial class frmAidatToplu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAidatToplu));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblKisiSayisi = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cboxil = new MetroFramework.Controls.MetroComboBox();
            this.cboxBirim = new MetroFramework.Controls.MetroComboBox();
            this.cboxMudurluk = new MetroFramework.Controls.MetroComboBox();
            this.dateTarih = new MetroFramework.Controls.MetroDateTime();
            this.txtAidatMiktari = new MetroFramework.Controls.MetroTextBox();
            this.btnKaydet = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 70);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(18, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "İl:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 111);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Müdürlük:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 154);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Birim:";
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.Location = new System.Drawing.Point(136, 186);
            this.lblKisiSayisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(65, 19);
            this.lblKisiSayisi.TabIndex = 4;
            this.lblKisiSayisi.Text = "Kişi Sayısı:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(22, 220);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Aidat Ay ve Yılı:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(22, 265);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(87, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Aidat miktarı:";
            // 
            // cboxil
            // 
            this.cboxil.FormattingEnabled = true;
            this.cboxil.ItemHeight = 23;
            this.cboxil.Location = new System.Drawing.Point(136, 65);
            this.cboxil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxil.Name = "cboxil";
            this.cboxil.PromptText = "İl seçiniz.";
            this.cboxil.Size = new System.Drawing.Size(178, 29);
            this.cboxil.TabIndex = 7;
            this.cboxil.UseSelectable = true;
            this.cboxil.SelectedIndexChanged += new System.EventHandler(this.cboxil_SelectedIndexChanged);
            this.cboxil.SelectionChangeCommitted += new System.EventHandler(this.cboxil_SelectionChangeCommitted);
            // 
            // cboxBirim
            // 
            this.cboxBirim.FormattingEnabled = true;
            this.cboxBirim.ItemHeight = 23;
            this.cboxBirim.Location = new System.Drawing.Point(136, 149);
            this.cboxBirim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxBirim.Name = "cboxBirim";
            this.cboxBirim.PromptText = "Birim seçiniz.";
            this.cboxBirim.Size = new System.Drawing.Size(178, 29);
            this.cboxBirim.TabIndex = 8;
            this.cboxBirim.UseSelectable = true;
            this.cboxBirim.SelectedIndexChanged += new System.EventHandler(this.cboxBirim_SelectedIndexChanged);
            this.cboxBirim.SelectionChangeCommitted += new System.EventHandler(this.cboxBirim_SelectionChangeCommitted);
            // 
            // cboxMudurluk
            // 
            this.cboxMudurluk.FormattingEnabled = true;
            this.cboxMudurluk.ItemHeight = 23;
            this.cboxMudurluk.Location = new System.Drawing.Point(136, 106);
            this.cboxMudurluk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxMudurluk.Name = "cboxMudurluk";
            this.cboxMudurluk.PromptText = "Müdürlük seçiniz.";
            this.cboxMudurluk.Size = new System.Drawing.Size(178, 29);
            this.cboxMudurluk.TabIndex = 9;
            this.cboxMudurluk.UseSelectable = true;
            this.cboxMudurluk.SelectionChangeCommitted += new System.EventHandler(this.cboxMudurluk_SelectionChangeCommitted);
            // 
            // dateTarih
            // 
            this.dateTarih.CustomFormat = "MM yyyy";
            this.dateTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTarih.Location = new System.Drawing.Point(136, 214);
            this.dateTarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTarih.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(151, 30);
            this.dateTarih.TabIndex = 10;
            // 
            // txtAidatMiktari
            // 
            // 
            // 
            // 
            this.txtAidatMiktari.CustomButton.Image = null;
            this.txtAidatMiktari.CustomButton.Location = new System.Drawing.Point(96, 2);
            this.txtAidatMiktari.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAidatMiktari.CustomButton.Name = "";
            this.txtAidatMiktari.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.txtAidatMiktari.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAidatMiktari.CustomButton.TabIndex = 1;
            this.txtAidatMiktari.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAidatMiktari.CustomButton.UseSelectable = true;
            this.txtAidatMiktari.CustomButton.Visible = false;
            this.txtAidatMiktari.Lines = new string[0];
            this.txtAidatMiktari.Location = new System.Drawing.Point(136, 260);
            this.txtAidatMiktari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAidatMiktari.MaxLength = 32767;
            this.txtAidatMiktari.Name = "txtAidatMiktari";
            this.txtAidatMiktari.PasswordChar = '\0';
            this.txtAidatMiktari.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAidatMiktari.SelectedText = "";
            this.txtAidatMiktari.SelectionLength = 0;
            this.txtAidatMiktari.SelectionStart = 0;
            this.txtAidatMiktari.ShortcutsEnabled = true;
            this.txtAidatMiktari.Size = new System.Drawing.Size(150, 29);
            this.txtAidatMiktari.TabIndex = 11;
            this.txtAidatMiktari.UseSelectable = true;
            this.txtAidatMiktari.WaterMark = "Aidat miktarını giriniz.";
            this.txtAidatMiktari.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAidatMiktari.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAidatMiktari.TextChanged += new System.EventHandler(this.txtAidatMiktari_TextChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ActiveControl = null;
            this.btnKaydet.Location = new System.Drawing.Point(136, 300);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(82, 43);
            this.btnKaydet.Style = MetroFramework.MetroColorStyle.Red;
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::telekomAidatTakip.Properties.Resources.telekom;
            this.pictureBox1.Location = new System.Drawing.Point(15, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmAidatToplu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAidatMiktari);
            this.Controls.Add(this.dateTarih);
            this.Controls.Add(this.cboxMudurluk);
            this.Controls.Add(this.cboxBirim);
            this.Controls.Add(this.cboxil);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lblKisiSayisi);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAidatToplu";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "       TOPLU AİDAT GİRİŞİ";
            this.Load += new System.EventHandler(this.frmAidatToplu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblKisiSayisi;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cboxil;
        private MetroFramework.Controls.MetroComboBox cboxBirim;
        private MetroFramework.Controls.MetroComboBox cboxMudurluk;
        private MetroFramework.Controls.MetroDateTime dateTarih;
        private MetroFramework.Controls.MetroTextBox txtAidatMiktari;
        private MetroFramework.Controls.MetroTile btnKaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}