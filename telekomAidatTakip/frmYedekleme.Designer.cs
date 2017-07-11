namespace telekomAidatTakip
{
    partial class frmYedekleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYedekleme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYukle = new MetroFramework.Controls.MetroTile();
            this.listYukle = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtYedek = new MetroFramework.Controls.MetroTextBox();
            this.btnYedek = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYukle);
            this.groupBox1.Controls.Add(this.listYukle);
            this.groupBox1.Location = new System.Drawing.Point(23, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geri Yükleme";
            // 
            // btnYukle
            // 
            this.btnYukle.ActiveControl = null;
            this.btnYukle.Location = new System.Drawing.Point(191, 214);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(190, 55);
            this.btnYukle.TabIndex = 4;
            this.btnYukle.Text = "Geri Yükleme";
            this.btnYukle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYukle.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnYukle.UseSelectable = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // listYukle
            // 
            this.listYukle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listYukle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listYukle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listYukle.FullRowSelect = true;
            this.listYukle.Location = new System.Drawing.Point(17, 25);
            this.listYukle.Name = "listYukle";
            this.listYukle.Size = new System.Drawing.Size(542, 174);
            this.listYukle.TabIndex = 0;
            this.listYukle.UseCompatibleStateImageBehavior = false;
            this.listYukle.View = System.Windows.Forms.View.Details;
            this.listYukle.SelectedIndexChanged += new System.EventHandler(this.listYukle_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tarih";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Özel Not";
            this.columnHeader2.Width = 149;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.txtYedek);
            this.groupBox2.Controls.Add(this.btnYedek);
            this.groupBox2.Location = new System.Drawing.Point(23, 411);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 124);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yedekleme";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(17, 53);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Özel Not:";
            // 
            // txtYedek
            // 
            // 
            // 
            // 
            this.txtYedek.CustomButton.Image = null;
            this.txtYedek.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtYedek.CustomButton.Name = "";
            this.txtYedek.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtYedek.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtYedek.CustomButton.TabIndex = 1;
            this.txtYedek.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtYedek.CustomButton.UseSelectable = true;
            this.txtYedek.CustomButton.Visible = false;
            this.txtYedek.Lines = new string[0];
            this.txtYedek.Location = new System.Drawing.Point(132, 53);
            this.txtYedek.MaxLength = 32767;
            this.txtYedek.Name = "txtYedek";
            this.txtYedek.PasswordChar = '\0';
            this.txtYedek.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtYedek.SelectedText = "";
            this.txtYedek.SelectionLength = 0;
            this.txtYedek.SelectionStart = 0;
            this.txtYedek.ShortcutsEnabled = true;
            this.txtYedek.Size = new System.Drawing.Size(206, 35);
            this.txtYedek.TabIndex = 6;
            this.txtYedek.UseSelectable = true;
            this.txtYedek.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtYedek.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnYedek
            // 
            this.btnYedek.ActiveControl = null;
            this.btnYedek.Location = new System.Drawing.Point(373, 43);
            this.btnYedek.Name = "btnYedek";
            this.btnYedek.Size = new System.Drawing.Size(166, 54);
            this.btnYedek.TabIndex = 5;
            this.btnYedek.Text = "Yedekle";
            this.btnYedek.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYedek.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnYedek.UseSelectable = true;
            this.btnYedek.Click += new System.EventHandler(this.btnYedek_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::telekomAidatTakip.Properties.Resources.telekom;
            this.pictureBox1.Location = new System.Drawing.Point(545, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmYedekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmYedekleme";
            this.Text = "Yedekleme";
            this.Load += new System.EventHandler(this.frmYedekleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listYukle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroTile btnYukle;
        private MetroFramework.Controls.MetroTile btnYedek;
        private MetroFramework.Controls.MetroTextBox txtYedek;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}