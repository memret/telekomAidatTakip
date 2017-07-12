namespace telekomAidatTakip
{
    partial class frmAidatMiktar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAidatMiktar));
            this.cboxIl = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tahsilNo = new MetroFramework.Controls.MetroLabel();
            this.cboxMudurluk = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cboxBirim = new MetroFramework.Controls.MetroComboBox();
            this.txtAidatMiktari = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxIl
            // 
            this.cboxIl.FormattingEnabled = true;
            this.cboxIl.ItemHeight = 23;
            this.cboxIl.Location = new System.Drawing.Point(126, 69);
            this.cboxIl.Name = "cboxIl";
            this.cboxIl.Size = new System.Drawing.Size(238, 29);
            this.cboxIl.TabIndex = 13;
            this.cboxIl.UseSelectable = true;
            this.cboxIl.SelectionChangeCommitted += new System.EventHandler(this.cboxIl_SelectionChangeCommitted);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 179);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(87, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Aidat Miktarı:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 144);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Birim:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Müdürlük:";
            // 
            // tahsilNo
            // 
            this.tahsilNo.AutoSize = true;
            this.tahsilNo.Location = new System.Drawing.Point(16, 74);
            this.tahsilNo.Name = "tahsilNo";
            this.tahsilNo.Size = new System.Drawing.Size(18, 19);
            this.tahsilNo.TabIndex = 9;
            this.tahsilNo.Text = "İl:";
            // 
            // cboxMudurluk
            // 
            this.cboxMudurluk.FormattingEnabled = true;
            this.cboxMudurluk.ItemHeight = 23;
            this.cboxMudurluk.Location = new System.Drawing.Point(126, 104);
            this.cboxMudurluk.Name = "cboxMudurluk";
            this.cboxMudurluk.Size = new System.Drawing.Size(238, 29);
            this.cboxMudurluk.TabIndex = 14;
            this.cboxMudurluk.UseSelectable = true;
            this.cboxMudurluk.SelectionChangeCommitted += new System.EventHandler(this.cboxMudurluk_SelectionChangeCommitted);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(342, 182);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(22, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "TL";
            // 
            // cboxBirim
            // 
            this.cboxBirim.FormattingEnabled = true;
            this.cboxBirim.ItemHeight = 23;
            this.cboxBirim.Location = new System.Drawing.Point(126, 139);
            this.cboxBirim.Name = "cboxBirim";
            this.cboxBirim.Size = new System.Drawing.Size(238, 29);
            this.cboxBirim.TabIndex = 16;
            this.cboxBirim.UseSelectable = true;
            this.cboxBirim.SelectionChangeCommitted += new System.EventHandler(this.cboxBirim_SelectionChangeCommitted);
            // 
            // txtAidatMiktari
            // 
            // 
            // 
            // 
            this.txtAidatMiktari.CustomButton.Image = null;
            this.txtAidatMiktari.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtAidatMiktari.CustomButton.Name = "";
            this.txtAidatMiktari.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtAidatMiktari.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAidatMiktari.CustomButton.TabIndex = 1;
            this.txtAidatMiktari.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAidatMiktari.CustomButton.UseSelectable = true;
            this.txtAidatMiktari.CustomButton.Visible = false;
            this.txtAidatMiktari.Lines = new string[0];
            this.txtAidatMiktari.Location = new System.Drawing.Point(126, 174);
            this.txtAidatMiktari.MaxLength = 32767;
            this.txtAidatMiktari.Name = "txtAidatMiktari";
            this.txtAidatMiktari.PasswordChar = '\0';
            this.txtAidatMiktari.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAidatMiktari.SelectedText = "";
            this.txtAidatMiktari.SelectionLength = 0;
            this.txtAidatMiktari.SelectionStart = 0;
            this.txtAidatMiktari.ShortcutsEnabled = true;
            this.txtAidatMiktari.Size = new System.Drawing.Size(214, 29);
            this.txtAidatMiktari.TabIndex = 17;
            this.txtAidatMiktari.UseSelectable = true;
            this.txtAidatMiktari.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAidatMiktari.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.White;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Image = global::telekomAidatTakip.Properties.Resources.if_icons_check_1564499;
            this.btnKaydet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKaydet.Location = new System.Drawing.Point(316, 209);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(48, 48);
            this.btnKaydet.TabIndex = 51;
            this.toolTip1.SetToolTip(this.btnKaydet, "Kaydet");
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Visible = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Image = global::telekomAidatTakip.Properties.Resources.if_icons_check_1564499;
            this.btnGuncelle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGuncelle.Location = new System.Drawing.Point(316, 209);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(48, 48);
            this.btnGuncelle.TabIndex = 52;
            this.toolTip1.SetToolTip(this.btnGuncelle, "Güncelle");
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Visible = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // frmAidatMiktar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 263);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtAidatMiktari);
            this.Controls.Add(this.cboxBirim);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cboxMudurluk);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cboxIl);
            this.Controls.Add(this.tahsilNo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAidatMiktar";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "       Aidat Miktarı Belirleme";
            this.Load += new System.EventHandler(this.frmAidatMiktar_Load);
            this.Resize += new System.EventHandler(this.frmAidatMiktar_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cboxIl;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel tahsilNo;
        private MetroFramework.Controls.MetroComboBox cboxMudurluk;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cboxBirim;
        private MetroFramework.Controls.MetroTextBox txtAidatMiktari;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}