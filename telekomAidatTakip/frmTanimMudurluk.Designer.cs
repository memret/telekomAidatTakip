namespace telekomAidatTakip
{
    partial class frmTanimMudurluk
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
            this.txtMdrKod = new MetroFramework.Controls.MetroTextBox();
            this.comboBox_il = new MetroFramework.Controls.MetroComboBox();
            this.txtMdrAd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.labelMdrNo = new MetroFramework.Controls.MetroLabel();
            this.btnSil = new MetroFramework.Controls.MetroTile();
            this.btnKaydet = new MetroFramework.Controls.MetroTile();
            this.btnYeni = new MetroFramework.Controls.MetroTile();
            this.listvMdr = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtMdrKod
            // 
            // 
            // 
            // 
            this.txtMdrKod.CustomButton.Image = null;
            this.txtMdrKod.CustomButton.Location = new System.Drawing.Point(94, 2);
            this.txtMdrKod.CustomButton.Name = "";
            this.txtMdrKod.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtMdrKod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMdrKod.CustomButton.TabIndex = 1;
            this.txtMdrKod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMdrKod.CustomButton.UseSelectable = true;
            this.txtMdrKod.CustomButton.Visible = false;
            this.txtMdrKod.Lines = new string[0];
            this.txtMdrKod.Location = new System.Drawing.Point(159, 67);
            this.txtMdrKod.MaxLength = 32767;
            this.txtMdrKod.Name = "txtMdrKod";
            this.txtMdrKod.PasswordChar = '\0';
            this.txtMdrKod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMdrKod.SelectedText = "";
            this.txtMdrKod.SelectionLength = 0;
            this.txtMdrKod.SelectionStart = 0;
            this.txtMdrKod.ShortcutsEnabled = true;
            this.txtMdrKod.Size = new System.Drawing.Size(122, 30);
            this.txtMdrKod.TabIndex = 27;
            this.txtMdrKod.UseSelectable = true;
            this.txtMdrKod.WaterMark = "Müdürlük no giriniz.";
            this.txtMdrKod.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMdrKod.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMdrKod.TextChanged += new System.EventHandler(this.txtMdrKod_TextChanged);
            // 
            // comboBox_il
            // 
            this.comboBox_il.Enabled = false;
            this.comboBox_il.FormattingEnabled = true;
            this.comboBox_il.ItemHeight = 23;
            this.comboBox_il.Location = new System.Drawing.Point(159, 142);
            this.comboBox_il.Name = "comboBox_il";
            this.comboBox_il.PromptText = "İl seçiniz.";
            this.comboBox_il.Size = new System.Drawing.Size(370, 29);
            this.comboBox_il.TabIndex = 19;
            this.comboBox_il.Tag = "";
            this.comboBox_il.UseSelectable = true;
            this.comboBox_il.SelectedIndexChanged += new System.EventHandler(this.comboBox_il_SelectedIndexChanged);
            // 
            // txtMdrAd
            // 
            // 
            // 
            // 
            this.txtMdrAd.CustomButton.Image = null;
            this.txtMdrAd.CustomButton.Location = new System.Drawing.Point(342, 2);
            this.txtMdrAd.CustomButton.Name = "";
            this.txtMdrAd.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtMdrAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMdrAd.CustomButton.TabIndex = 1;
            this.txtMdrAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMdrAd.CustomButton.UseSelectable = true;
            this.txtMdrAd.CustomButton.Visible = false;
            this.txtMdrAd.Lines = new string[0];
            this.txtMdrAd.Location = new System.Drawing.Point(159, 104);
            this.txtMdrAd.MaxLength = 32767;
            this.txtMdrAd.Name = "txtMdrAd";
            this.txtMdrAd.PasswordChar = '\0';
            this.txtMdrAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMdrAd.SelectedText = "";
            this.txtMdrAd.SelectionLength = 0;
            this.txtMdrAd.SelectionStart = 0;
            this.txtMdrAd.ShortcutsEnabled = true;
            this.txtMdrAd.Size = new System.Drawing.Size(370, 30);
            this.txtMdrAd.TabIndex = 26;
            this.txtMdrAd.UseSelectable = true;
            this.txtMdrAd.WaterMark = "Müdürlük adı giriniz.";
            this.txtMdrAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMdrAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMdrAd.TextChanged += new System.EventHandler(this.txtMdrKod_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "Müdürlük: ";
            // 
            // labelMdrNo
            // 
            this.labelMdrNo.AutoSize = true;
            this.labelMdrNo.Location = new System.Drawing.Point(30, 73);
            this.labelMdrNo.Name = "labelMdrNo";
            this.labelMdrNo.Size = new System.Drawing.Size(93, 19);
            this.labelMdrNo.TabIndex = 24;
            this.labelMdrNo.Text = "Müdürlük No: ";
            // 
            // btnSil
            // 
            this.btnSil.ActiveControl = null;
            this.btnSil.Location = new System.Drawing.Point(407, 187);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(122, 42);
            this.btnSil.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSil.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSil.UseSelectable = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ActiveControl = null;
            this.btnKaydet.Location = new System.Drawing.Point(283, 187);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(118, 42);
            this.btnKaydet.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.ActiveControl = null;
            this.btnYeni.Location = new System.Drawing.Point(159, 187);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(118, 42);
            this.btnYeni.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnYeni.TabIndex = 21;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYeni.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnYeni.UseSelectable = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // listvMdr
            // 
            this.listvMdr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listvMdr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listvMdr.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listvMdr.FullRowSelect = true;
            this.listvMdr.Location = new System.Drawing.Point(27, 239);
            this.listvMdr.Name = "listvMdr";
            this.listvMdr.Size = new System.Drawing.Size(501, 252);
            this.listvMdr.TabIndex = 28;
            this.listvMdr.UseCompatibleStateImageBehavior = false;
            this.listvMdr.View = System.Windows.Forms.View.Details;
            this.listvMdr.SelectedIndexChanged += new System.EventHandler(this.comboBox_il_SelectedIndexChanged);
            this.listvMdr.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listvMdr_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müdürlük No";
            this.columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Müdürlük";
            this.columnHeader2.Width = 168;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İl No";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İl";
            this.columnHeader4.Width = 112;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(30, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(18, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "İl:";
            // 
            // frmTanimMudurluk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 516);
            this.Controls.Add(this.listvMdr);
            this.Controls.Add(this.txtMdrKod);
            this.Controls.Add(this.comboBox_il);
            this.Controls.Add(this.txtMdrAd);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.labelMdrNo);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(555, 516);
            this.Name = "frmTanimMudurluk";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "MÜDÜRLÜK TANIMLAMA";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTanimMudurluk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtMdrKod;
        private MetroFramework.Controls.MetroComboBox comboBox_il;
        private MetroFramework.Controls.MetroTextBox txtMdrAd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel labelMdrNo;
        private MetroFramework.Controls.MetroTile btnSil;
        private MetroFramework.Controls.MetroTile btnKaydet;
        private MetroFramework.Controls.MetroTile btnYeni;
        private System.Windows.Forms.ListView listvMdr;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}