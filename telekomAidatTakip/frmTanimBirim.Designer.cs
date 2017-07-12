namespace telekomAidatTakip
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTanimBirim));
            this.cBoxMudurluk = new MetroFramework.Controls.MetroComboBox();
            this.txtBirimKodu = new MetroFramework.Controls.MetroTextBox();
            this.txtBirimAdi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnSil = new MetroFramework.Controls.MetroTile();
            this.btnKaydet = new MetroFramework.Controls.MetroTile();
            this.btnYeni = new MetroFramework.Controls.MetroTile();
            this.listBirim = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxMudurluk
            // 
            this.cBoxMudurluk.Enabled = false;
            this.cBoxMudurluk.FormattingEnabled = true;
            this.cBoxMudurluk.ItemHeight = 23;
            this.cBoxMudurluk.Location = new System.Drawing.Point(157, 125);
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
            this.txtBirimKodu.Enabled = false;
            this.txtBirimKodu.Lines = new string[0];
            this.txtBirimKodu.Location = new System.Drawing.Point(157, 67);
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
            this.txtBirimAdi.Enabled = false;
            this.txtBirimAdi.Lines = new string[0];
            this.txtBirimAdi.Location = new System.Drawing.Point(157, 96);
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
            this.metroLabel1.Location = new System.Drawing.Point(73, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Birim No:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(73, 98);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Birim:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(73, 133);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Müdürlük:";
            // 
            // btnSil
            // 
            this.btnSil.ActiveControl = null;
            this.btnSil.BackColor = System.Drawing.Color.Silver;
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(391, 160);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(45, 45);
            this.btnSil.TabIndex = 10;
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSil.TileImage = global::telekomAidatTakip.Properties.Resources.if_delete_101939;
            this.btnSil.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSil.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSil.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.toolTip1.SetToolTip(this.btnSil, "Sil");
            this.btnSil.UseCustomBackColor = true;
            this.btnSil.UseSelectable = true;
            this.btnSil.UseTileImage = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ActiveControl = null;
            this.btnKaydet.BackColor = System.Drawing.Color.Silver;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(340, 160);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(45, 45);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.TileImage = global::telekomAidatTakip.Properties.Resources.if_check_101940;
            this.btnKaydet.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnKaydet.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.toolTip1.SetToolTip(this.btnKaydet, "Kaydet");
            this.btnKaydet.UseCustomBackColor = true;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.UseTileImage = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.ActiveControl = null;
            this.btnYeni.Location = new System.Drawing.Point(289, 160);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(45, 45);
            this.btnYeni.TabIndex = 10;
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnYeni.TileImage = global::telekomAidatTakip.Properties.Resources.if_save_101946;
            this.btnYeni.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYeni.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnYeni.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.toolTip1.SetToolTip(this.btnYeni, "Yeni Kayıt");
            this.btnYeni.UseSelectable = true;
            this.btnYeni.UseTileImage = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // listBirim
            // 
            this.listBirim.AllowColumnReorder = true;
            this.listBirim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listBirim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBirim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBirim.FullRowSelect = true;
            this.listBirim.GridLines = true;
            this.listBirim.Location = new System.Drawing.Point(20, 215);
            this.listBirim.MultiSelect = false;
            this.listBirim.Name = "listBirim";
            this.listBirim.Size = new System.Drawing.Size(472, 214);
            this.listBirim.TabIndex = 16;
            this.listBirim.UseCompatibleStateImageBehavior = false;
            this.listBirim.View = System.Windows.Forms.View.Details;
            this.listBirim.DoubleClick += new System.EventHandler(this.listvil_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Birim No";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Birim";
            this.columnHeader2.Width = 136;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Müdürlük No";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Müdürlük";
            this.columnHeader4.Width = 155;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::telekomAidatTakip.Properties.Resources.telekom;
            this.pictureBox2.Location = new System.Drawing.Point(15, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // frmTanimBirim
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(512, 449);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listBirim);
            this.Controls.Add(this.btnSil);
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
            this.Name = "frmTanimBirim";
            this.Text = "       Birim Tanımlama";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.frmTanimBirim_Load);
            this.Resize += new System.EventHandler(this.frmTanimBirim_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.ListView listBirim;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}