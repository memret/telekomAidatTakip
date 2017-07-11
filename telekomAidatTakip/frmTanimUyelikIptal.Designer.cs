namespace telekomAidatTakip
{
    partial class frmTanimUyelikIptal
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
            this.txtAciklama = new MetroFramework.Controls.MetroTextBox();
            this.txtKod = new MetroFramework.Controls.MetroTextBox();
            this.btnSil = new MetroFramework.Controls.MetroTile();
            this.btnKaydet = new MetroFramework.Controls.MetroTile();
            this.btnYeni = new MetroFramework.Controls.MetroTile();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelKod = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aidatMiktarTableAdapter1 = new telekomAidatTakip.telekomAidatDataSetTableAdapters.AidatMiktarTableAdapter();
            this.ilTableAdapter1 = new telekomAidatTakip.telekomAidatDataSetTableAdapters.ilTableAdapter();
            this.listvSilinme = new System.Windows.Forms.ListView();
            this.columnHeaderKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.Gainsboro;
            // 
            // 
            // 
            this.txtAciklama.CustomButton.Image = null;
            this.txtAciklama.CustomButton.Location = new System.Drawing.Point(125, 2);
            this.txtAciklama.CustomButton.Name = "";
            this.txtAciklama.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.txtAciklama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAciklama.CustomButton.TabIndex = 1;
            this.txtAciklama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAciklama.CustomButton.UseSelectable = true;
            this.txtAciklama.CustomButton.UseWaitCursor = true;
            this.txtAciklama.CustomButton.Visible = false;
            this.txtAciklama.Lines = new string[0];
            this.txtAciklama.Location = new System.Drawing.Point(114, 112);
            this.txtAciklama.MaxLength = 32767;
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PasswordChar = '\0';
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAciklama.SelectedText = "";
            this.txtAciklama.SelectionLength = 0;
            this.txtAciklama.SelectionStart = 0;
            this.txtAciklama.ShortcutsEnabled = true;
            this.txtAciklama.Size = new System.Drawing.Size(183, 60);
            this.txtAciklama.TabIndex = 20;
            this.txtAciklama.UseCustomBackColor = true;
            this.txtAciklama.UseCustomForeColor = true;
            this.txtAciklama.UseSelectable = true;
            this.txtAciklama.UseStyleColors = true;
            this.txtAciklama.UseSystemPasswordChar = true;
            this.txtAciklama.UseWaitCursor = true;
            this.txtAciklama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAciklama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtKod
            // 
            this.txtKod.BackColor = System.Drawing.Color.Gainsboro;
            // 
            // 
            // 
            this.txtKod.CustomButton.Image = null;
            this.txtKod.CustomButton.Location = new System.Drawing.Point(161, 2);
            this.txtKod.CustomButton.Name = "";
            this.txtKod.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtKod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKod.CustomButton.TabIndex = 1;
            this.txtKod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKod.CustomButton.UseSelectable = true;
            this.txtKod.CustomButton.UseWaitCursor = true;
            this.txtKod.CustomButton.Visible = false;
            this.txtKod.Lines = new string[0];
            this.txtKod.Location = new System.Drawing.Point(114, 72);
            this.txtKod.MaxLength = 32767;
            this.txtKod.Name = "txtKod";
            this.txtKod.PasswordChar = '●';
            this.txtKod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKod.SelectedText = "";
            this.txtKod.SelectionLength = 0;
            this.txtKod.SelectionStart = 0;
            this.txtKod.ShortcutsEnabled = true;
            this.txtKod.Size = new System.Drawing.Size(183, 29);
            this.txtKod.TabIndex = 19;
            this.txtKod.UseCustomBackColor = true;
            this.txtKod.UseCustomForeColor = true;
            this.txtKod.UseSelectable = true;
            this.txtKod.UseStyleColors = true;
            this.txtKod.UseSystemPasswordChar = true;
            this.txtKod.UseWaitCursor = true;
            this.txtKod.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKod.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSil
            // 
            this.btnSil.ActiveControl = null;
            this.btnSil.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSil.Location = new System.Drawing.Point(216, 192);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(66, 48);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSil.UseCustomBackColor = true;
            this.btnSil.UseCustomForeColor = true;
            this.btnSil.UseSelectable = true;
            this.btnSil.UseStyleColors = true;
            this.btnSil.UseTileImage = true;
            this.btnSil.UseWaitCursor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ActiveControl = null;
            this.btnKaydet.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.Location = new System.Drawing.Point(134, 192);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(66, 48);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.UseCustomBackColor = true;
            this.btnKaydet.UseCustomForeColor = true;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.UseStyleColors = true;
            this.btnKaydet.UseTileImage = true;
            this.btnKaydet.UseWaitCursor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.ActiveControl = null;
            this.btnYeni.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnYeni.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnYeni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYeni.Location = new System.Drawing.Point(52, 192);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(67, 49);
            this.btnYeni.TabIndex = 14;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYeni.UseCustomBackColor = true;
            this.btnYeni.UseCustomForeColor = true;
            this.btnYeni.UseSelectable = true;
            this.btnYeni.UseStyleColors = true;
            this.btnYeni.UseTileImage = true;
            this.btnYeni.UseWaitCursor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 84);
            this.label5.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 84);
            this.label4.TabIndex = 12;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 117);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Açıklama :";
            // 
            // metroLabelKod
            // 
            this.metroLabelKod.AutoSize = true;
            this.metroLabelKod.Location = new System.Drawing.Point(23, 77);
            this.metroLabelKod.Name = "metroLabelKod";
            this.metroLabelKod.Size = new System.Drawing.Size(39, 19);
            this.metroLabelKod.TabIndex = 26;
            this.metroLabelKod.Text = "Kod :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 84);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 84);
            this.label2.TabIndex = 21;
            // 
            // aidatMiktarTableAdapter1
            // 
            this.aidatMiktarTableAdapter1.ClearBeforeFill = true;
            // 
            // ilTableAdapter1
            // 
            this.ilTableAdapter1.ClearBeforeFill = true;
            // 
            // listvSilinme
            // 
            this.listvSilinme.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listvSilinme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderKod,
            this.columnHeaderAciklama});
            this.listvSilinme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listvSilinme.Location = new System.Drawing.Point(16, 258);
            this.listvSilinme.Name = "listvSilinme";
            this.listvSilinme.Size = new System.Drawing.Size(323, 122);
            this.listvSilinme.TabIndex = 29;
            this.listvSilinme.UseCompatibleStateImageBehavior = false;
            this.listvSilinme.View = System.Windows.Forms.View.Details;
            this.listvSilinme.DoubleClick += new System.EventHandler(this.listvSilinme_DoubleClick);
            // 
            // columnHeaderKod
            // 
            this.columnHeaderKod.Text = "Kod";
            this.columnHeaderKod.Width = 130;
            // 
            // columnHeaderAciklama
            // 
            this.columnHeaderAciklama.Text = "Açıklama";
            this.columnHeaderAciklama.Width = 188;
            // 
            // frmTanimUyelikIptal
            // 
            this.ClientSize = new System.Drawing.Size(362, 403);
            this.Controls.Add(this.listvSilinme);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabelKod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnKaydet);
            this.Font = new System.Drawing.Font("Cambria Math", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "frmTanimUyelikIptal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Silinme Nedeni Tanımlama";
            this.Load += new System.EventHandler(this.frmTanimUyelikIptal_Load);
            this.BackColorChanged += new System.EventHandler(this.frmTanimUyelikIptal_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtAciklama;
        private MetroFramework.Controls.MetroTextBox txtKod;
        private MetroFramework.Controls.MetroTile btnSil;
        private MetroFramework.Controls.MetroTile btnKaydet;
        private MetroFramework.Controls.MetroTile btnYeni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private telekomAidatDataSetTableAdapters.AidatMiktarTableAdapter aidatMiktarTableAdapter1;
        private telekomAidatDataSetTableAdapters.ilTableAdapter ilTableAdapter1;
        private System.Windows.Forms.ListView listvSilinme;
        private System.Windows.Forms.ColumnHeader columnHeaderKod;
        private System.Windows.Forms.ColumnHeader columnHeaderAciklama;
    }
}