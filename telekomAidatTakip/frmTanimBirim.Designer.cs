﻿namespace telekomAidatTakip
{
    partial class frmTanimBirim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTanimBirim));
            this.cBoxMudurluk = new MetroFramework.Controls.MetroComboBox();
            this.txtBirimKodu = new MetroFramework.Controls.MetroTextBox();
            this.txtBirimAdi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.listBirim = new MetroFramework.Controls.MetroListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSil = new MetroFramework.Controls.MetroTile();
            this.btnKaydet = new MetroFramework.Controls.MetroTile();
            this.btnYeni = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxMudurluk
            // 
            this.cBoxMudurluk.FormattingEnabled = true;
            this.cBoxMudurluk.ItemHeight = 23;
            this.cBoxMudurluk.Location = new System.Drawing.Point(157, 126);
            this.cBoxMudurluk.Name = "cBoxMudurluk";
            this.cBoxMudurluk.Size = new System.Drawing.Size(279, 29);
            this.cBoxMudurluk.TabIndex = 7;
            this.cBoxMudurluk.UseSelectable = true;
            this.cBoxMudurluk.SelectionChangeCommitted += new System.EventHandler(this.cBoxMudurluk_SelectionChangeCommitted);
            // 
            // txtBirimKodu
            // 
            // 
            // 
            // 
            this.txtBirimKodu.CustomButton.Image = null;
            this.txtBirimKodu.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtBirimKodu.CustomButton.Name = "";
            this.txtBirimKodu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBirimKodu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBirimKodu.CustomButton.TabIndex = 1;
            this.txtBirimKodu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBirimKodu.CustomButton.UseSelectable = true;
            this.txtBirimKodu.CustomButton.Visible = false;
            this.txtBirimKodu.Lines = new string[0];
            this.txtBirimKodu.Location = new System.Drawing.Point(157, 68);
            this.txtBirimKodu.MaxLength = 32767;
            this.txtBirimKodu.Name = "txtBirimKodu";
            this.txtBirimKodu.PasswordChar = '\0';
            this.txtBirimKodu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBirimKodu.SelectedText = "";
            this.txtBirimKodu.SelectionLength = 0;
            this.txtBirimKodu.SelectionStart = 0;
            this.txtBirimKodu.ShortcutsEnabled = true;
            this.txtBirimKodu.Size = new System.Drawing.Size(161, 23);
            this.txtBirimKodu.TabIndex = 8;
            this.txtBirimKodu.UseSelectable = true;
            this.txtBirimKodu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBirimKodu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBirimAdi
            // 
            // 
            // 
            // 
            this.txtBirimAdi.CustomButton.Image = null;
            this.txtBirimAdi.CustomButton.Location = new System.Drawing.Point(258, 1);
            this.txtBirimAdi.CustomButton.Name = "";
            this.txtBirimAdi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBirimAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBirimAdi.CustomButton.TabIndex = 1;
            this.txtBirimAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBirimAdi.CustomButton.UseSelectable = true;
            this.txtBirimAdi.CustomButton.Visible = false;
            this.txtBirimAdi.Lines = new string[0];
            this.txtBirimAdi.Location = new System.Drawing.Point(157, 97);
            this.txtBirimAdi.MaxLength = 32767;
            this.txtBirimAdi.Name = "txtBirimAdi";
            this.txtBirimAdi.PasswordChar = '\0';
            this.txtBirimAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBirimAdi.SelectedText = "";
            this.txtBirimAdi.SelectionLength = 0;
            this.txtBirimAdi.SelectionStart = 0;
            this.txtBirimAdi.ShortcutsEnabled = true;
            this.txtBirimAdi.Size = new System.Drawing.Size(280, 23);
            this.txtBirimAdi.TabIndex = 8;
            this.txtBirimAdi.UseSelectable = true;
            this.txtBirimAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBirimAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(73, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Birim No:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(73, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Birim:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(73, 134);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Müdürlük:";
            // 
            // listBirim
            // 
            this.listBirim.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listBirim.AllowColumnReorder = true;
            this.listBirim.AllowSorting = true;
            this.listBirim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listBirim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBirim.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBirim.FullRowSelect = true;
            this.listBirim.GridLines = true;
            this.listBirim.Location = new System.Drawing.Point(20, 238);
            this.listBirim.MultiSelect = false;
            this.listBirim.Name = "listBirim";
            this.listBirim.OwnerDraw = true;
            this.listBirim.Size = new System.Drawing.Size(472, 221);
            this.listBirim.Style = MetroFramework.MetroColorStyle.Blue;
            this.listBirim.TabIndex = 4;
            this.listBirim.UseCompatibleStateImageBehavior = false;
            this.listBirim.UseSelectable = true;
            this.listBirim.View = System.Windows.Forms.View.Details;
            this.listBirim.DoubleClick += new System.EventHandler(this.listvil_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Birim No";
            this.columnHeader5.Width = 77;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Birim";
            this.columnHeader6.Width = 111;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Müdürlük No";
            this.columnHeader7.Width = 117;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Müdürlük";
            this.columnHeader8.Width = 141;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::telekomAidatTakip.Properties.Resources.telekom;
            this.pictureBox1.Location = new System.Drawing.Point(442, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.ActiveControl = null;
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(349, 171);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 45);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.TileImage = global::telekomAidatTakip.Properties.Resources.if_delete_101939;
            this.btnSil.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSil.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnSil.UseSelectable = true;
            this.btnSil.UseTileImage = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ActiveControl = null;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(201, 171);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(113, 45);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.TileImage = global::telekomAidatTakip.Properties.Resources.if_check_101940;
            this.btnKaydet.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnKaydet.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.UseTileImage = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.ActiveControl = null;
            this.btnYeni.Location = new System.Drawing.Point(73, 171);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(92, 45);
            this.btnYeni.TabIndex = 10;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeni.TileImage = global::telekomAidatTakip.Properties.Resources.if_save_101946;
            this.btnYeni.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeni.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnYeni.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnYeni.UseSelectable = true;
            this.btnYeni.UseTileImage = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // frmTanimBirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 479);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.listBirim);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cBoxMudurluk);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtBirimKodu);
            this.Controls.Add(this.txtBirimAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(512, 479);
            this.Name = "frmTanimBirim";
            this.Text = "Birim Tanımlama";
            this.Load += new System.EventHandler(this.frmTanimBirim_Load);
            this.Resize += new System.EventHandler(this.frmTanimBirim_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtBirimAdi;
        private MetroFramework.Controls.MetroTextBox txtBirimKodu;
        private MetroFramework.Controls.MetroComboBox cBoxMudurluk;
        private MetroFramework.Controls.MetroTile btnSil;
        private MetroFramework.Controls.MetroTile btnKaydet;
        private MetroFramework.Controls.MetroTile btnYeni;
        private MetroFramework.Controls.MetroListView listBirim;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}