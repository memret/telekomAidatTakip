namespace telekomAidatTakip
{
    partial class frmTanimIl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTanimIl));
            this.txtAdi = new MetroFramework.Controls.MetroTextBox();
            this.txtPlakaKodu = new MetroFramework.Controls.MetroTextBox();
            this.btnSil = new MetroFramework.Controls.MetroTile();
            this.btnKaydet = new MetroFramework.Controls.MetroTile();
            this.btnYeni = new MetroFramework.Controls.MetroTile();
            this.Label1 = new MetroFramework.Controls.MetroLabel();
            this.Label2 = new MetroFramework.Controls.MetroLabel();
            this.listvil = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdi
            // 
            // 
            // 
            // 
            this.txtAdi.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtAdi.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.txtAdi.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.txtAdi.CustomButton.Name = "";
            this.txtAdi.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.txtAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdi.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.txtAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdi.CustomButton.UseSelectable = true;
            this.txtAdi.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.txtAdi.Lines = new string[0];
            resources.ApplyResources(this.txtAdi, "txtAdi");
            this.txtAdi.MaxLength = 32767;
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.PasswordChar = '\0';
            this.txtAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdi.SelectedText = "";
            this.txtAdi.SelectionLength = 0;
            this.txtAdi.SelectionStart = 0;
            this.txtAdi.ShortcutsEnabled = true;
            this.txtAdi.UseSelectable = true;
            this.txtAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdi.Leave += new System.EventHandler(this.txtAdi_Leave);
            // 
            // txtPlakaKodu
            // 
            // 
            // 
            // 
            this.txtPlakaKodu.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.txtPlakaKodu.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.txtPlakaKodu.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.txtPlakaKodu.CustomButton.Name = "";
            this.txtPlakaKodu.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.txtPlakaKodu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPlakaKodu.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.txtPlakaKodu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPlakaKodu.CustomButton.UseSelectable = true;
            this.txtPlakaKodu.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.txtPlakaKodu.Lines = new string[0];
            resources.ApplyResources(this.txtPlakaKodu, "txtPlakaKodu");
            this.txtPlakaKodu.MaxLength = 32767;
            this.txtPlakaKodu.Name = "txtPlakaKodu";
            this.txtPlakaKodu.PasswordChar = '\0';
            this.txtPlakaKodu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPlakaKodu.SelectedText = "";
            this.txtPlakaKodu.SelectionLength = 0;
            this.txtPlakaKodu.SelectionStart = 0;
            this.txtPlakaKodu.ShortcutsEnabled = true;
            this.txtPlakaKodu.UseSelectable = true;
            this.txtPlakaKodu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPlakaKodu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPlakaKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlakaKodu_KeyPress);
            this.txtPlakaKodu.Leave += new System.EventHandler(this.txtPlakaKodu_Leave);
            // 
            // btnSil
            // 
            this.btnSil.ActiveControl = null;
            this.btnSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.btnSil, "btnSil");
            this.btnSil.Name = "btnSil";
            this.btnSil.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnSil.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSil.UseSelectable = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ActiveControl = null;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.btnKaydet, "btnKaydet");
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnKaydet.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.ActiveControl = null;
            this.btnYeni.BackColor = System.Drawing.Color.SeaGreen;
            this.btnYeni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.btnYeni, "btnYeni");
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnYeni.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeni.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnYeni.UseSelectable = true;
            this.btnYeni.UseTileImage = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Name = "Label1";
            this.Label1.UseCustomForeColor = true;
            this.Label1.UseMnemonic = false;
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Name = "Label2";
            this.Label2.UseCustomForeColor = true;
            this.Label2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // listvil
            // 
            this.listvil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            resources.ApplyResources(this.listvil, "listvil");
            this.listvil.FullRowSelect = true;
            this.listvil.MultiSelect = false;
            this.listvil.Name = "listvil";
            this.listvil.UseCompatibleStateImageBehavior = false;
            this.listvil.View = System.Windows.Forms.View.Details;
            this.listvil.SelectedIndexChanged += new System.EventHandler(this.listvil_SelectedIndexChanged);
            this.listvil.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listvil_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::telekomAidatTakip.Properties.Resources.telekom;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // frmTanimIl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(100);
            this.BackLocation = MetroFramework.Forms.BackLocation.BottomLeft;
            this.BackMaxSize = 15;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listvil);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtPlakaKodu);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "frmTanimIl";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTanimIl_FormClosing);
            this.Load += new System.EventHandler(this.frmTanimil_Load);
            this.Resize += new System.EventHandler(this.frmTanimIl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtAdi;
        private MetroFramework.Controls.MetroTextBox txtPlakaKodu;
        private MetroFramework.Controls.MetroTile btnSil;
        private MetroFramework.Controls.MetroTile btnKaydet;
        private MetroFramework.Controls.MetroTile btnYeni;
        private MetroFramework.Controls.MetroLabel Label1;
        private MetroFramework.Controls.MetroLabel Label2;
        private System.Windows.Forms.ListView listvil;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}