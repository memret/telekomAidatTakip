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
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(47, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(18, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "İl:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(47, 141);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Müdürlük:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(47, 183);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Birim:";
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.Location = new System.Drawing.Point(181, 227);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(69, 20);
            this.lblKisiSayisi.TabIndex = 4;
            this.lblKisiSayisi.Text = "Kişi Sayısı:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(47, 263);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(103, 20);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Aidat Ay ve Yılı:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(47, 320);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(88, 20);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Aidat miktarı:";
            // 
            // cboxil
            // 
            this.cboxil.FormattingEnabled = true;
            this.cboxil.ItemHeight = 24;
            this.cboxil.Location = new System.Drawing.Point(181, 80);
            this.cboxil.Name = "cboxil";
            this.cboxil.Size = new System.Drawing.Size(236, 30);
            this.cboxil.TabIndex = 7;
            this.cboxil.UseSelectable = true;
            this.cboxil.SelectedIndexChanged += new System.EventHandler(this.cboxil_SelectedIndexChanged);
            this.cboxil.SelectionChangeCommitted += new System.EventHandler(this.cboxil_SelectionChangeCommitted);
            // 
            // cboxBirim
            // 
            this.cboxBirim.FormattingEnabled = true;
            this.cboxBirim.ItemHeight = 24;
            this.cboxBirim.Location = new System.Drawing.Point(181, 183);
            this.cboxBirim.Name = "cboxBirim";
            this.cboxBirim.Size = new System.Drawing.Size(236, 30);
            this.cboxBirim.TabIndex = 8;
            this.cboxBirim.UseSelectable = true;
            this.cboxBirim.SelectedIndexChanged += new System.EventHandler(this.cboxBirim_SelectedIndexChanged);
            this.cboxBirim.SelectionChangeCommitted += new System.EventHandler(this.cboxBirim_SelectionChangeCommitted);
            // 
            // cboxMudurluk
            // 
            this.cboxMudurluk.FormattingEnabled = true;
            this.cboxMudurluk.ItemHeight = 24;
            this.cboxMudurluk.Location = new System.Drawing.Point(181, 131);
            this.cboxMudurluk.Name = "cboxMudurluk";
            this.cboxMudurluk.Size = new System.Drawing.Size(236, 30);
            this.cboxMudurluk.TabIndex = 9;
            this.cboxMudurluk.UseSelectable = true;
            this.cboxMudurluk.SelectionChangeCommitted += new System.EventHandler(this.cboxMudurluk_SelectionChangeCommitted);
            // 
            // dateTarih
            // 
            this.dateTarih.CustomFormat = "MM yyyy";
            this.dateTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTarih.Location = new System.Drawing.Point(181, 263);
            this.dateTarih.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(200, 30);
            this.dateTarih.TabIndex = 10;
            // 
            // txtAidatMiktari
            // 
            // 
            // 
            // 
            this.txtAidatMiktari.CustomButton.Image = null;
            this.txtAidatMiktari.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtAidatMiktari.CustomButton.Name = "";
            this.txtAidatMiktari.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAidatMiktari.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAidatMiktari.CustomButton.TabIndex = 1;
            this.txtAidatMiktari.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAidatMiktari.CustomButton.UseSelectable = true;
            this.txtAidatMiktari.CustomButton.Visible = false;
            this.txtAidatMiktari.Lines = new string[0];
            this.txtAidatMiktari.Location = new System.Drawing.Point(181, 320);
            this.txtAidatMiktari.MaxLength = 32767;
            this.txtAidatMiktari.Name = "txtAidatMiktari";
            this.txtAidatMiktari.PasswordChar = '\0';
            this.txtAidatMiktari.PromptText = "Aidat miktarını giriniz.";
            this.txtAidatMiktari.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAidatMiktari.SelectedText = "";
            this.txtAidatMiktari.SelectionLength = 0;
            this.txtAidatMiktari.SelectionStart = 0;
            this.txtAidatMiktari.ShortcutsEnabled = true;
            this.txtAidatMiktari.Size = new System.Drawing.Size(200, 29);
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
            this.btnKaydet.Location = new System.Drawing.Point(181, 369);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(109, 53);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmAidatToplu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 464);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAidatToplu";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Toplu Aidat Girişi";
            this.Load += new System.EventHandler(this.frmAidatToplu_Load);
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
    }
}