﻿namespace telekomAidatTakip
{
    partial class frmTanimUnvan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTanimUnvan));
            this.btnKaydet = new MetroFramework.Controls.MetroTile();
            this.btnYeni = new MetroFramework.Controls.MetroTile();
            this.btnSil = new MetroFramework.Controls.MetroTile();
            this.txtUnvanNo = new MetroFramework.Controls.MetroTextBox();
            this.txtUnvanAdi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.listUnvan = new System.Windows.Forms.ListView();
            this.unvanNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unvanAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.ActiveControl = null;
            this.btnKaydet.Location = new System.Drawing.Point(181, 199);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(111, 45);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.ActiveControl = null;
            this.btnYeni.Location = new System.Drawing.Point(34, 199);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(111, 45);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYeni.UseSelectable = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.ActiveControl = null;
            this.btnSil.Location = new System.Drawing.Point(345, 199);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(111, 45);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSil.UseSelectable = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtUnvanNo
            // 
            // 
            // 
            // 
            this.txtUnvanNo.CustomButton.Image = null;
            this.txtUnvanNo.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtUnvanNo.CustomButton.Name = "";
            this.txtUnvanNo.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUnvanNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnvanNo.CustomButton.TabIndex = 1;
            this.txtUnvanNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnvanNo.CustomButton.UseSelectable = true;
            this.txtUnvanNo.CustomButton.Visible = false;
            this.txtUnvanNo.Lines = new string[0];
            this.txtUnvanNo.Location = new System.Drawing.Point(151, 92);
            this.txtUnvanNo.MaxLength = 32767;
            this.txtUnvanNo.Name = "txtUnvanNo";
            this.txtUnvanNo.PasswordChar = '\0';
            this.txtUnvanNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnvanNo.SelectedText = "";
            this.txtUnvanNo.SelectionLength = 0;
            this.txtUnvanNo.SelectionStart = 0;
            this.txtUnvanNo.ShortcutsEnabled = true;
            this.txtUnvanNo.Size = new System.Drawing.Size(120, 30);
            this.txtUnvanNo.TabIndex = 4;
            this.txtUnvanNo.UseSelectable = true;
            this.txtUnvanNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnvanNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUnvanAdi
            // 
            // 
            // 
            // 
            this.txtUnvanAdi.CustomButton.Image = null;
            this.txtUnvanAdi.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtUnvanAdi.CustomButton.Name = "";
            this.txtUnvanAdi.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUnvanAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnvanAdi.CustomButton.TabIndex = 1;
            this.txtUnvanAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnvanAdi.CustomButton.UseSelectable = true;
            this.txtUnvanAdi.CustomButton.Visible = false;
            this.txtUnvanAdi.Lines = new string[0];
            this.txtUnvanAdi.Location = new System.Drawing.Point(151, 137);
            this.txtUnvanAdi.MaxLength = 32767;
            this.txtUnvanAdi.Name = "txtUnvanAdi";
            this.txtUnvanAdi.PasswordChar = '\0';
            this.txtUnvanAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnvanAdi.SelectedText = "";
            this.txtUnvanAdi.SelectionLength = 0;
            this.txtUnvanAdi.SelectionStart = 0;
            this.txtUnvanAdi.ShortcutsEnabled = true;
            this.txtUnvanAdi.Size = new System.Drawing.Size(120, 30);
            this.txtUnvanAdi.TabIndex = 5;
            this.txtUnvanAdi.UseSelectable = true;
            this.txtUnvanAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnvanAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Ünvan No:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(34, 137);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Ünvan Adı:";
            // 
            // listUnvan
            // 
            this.listUnvan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.unvanNo,
            this.unvanAdi});
            this.listUnvan.Location = new System.Drawing.Point(33, 289);
            this.listUnvan.Name = "listUnvan";
            this.listUnvan.Size = new System.Drawing.Size(433, 179);
            this.listUnvan.TabIndex = 10;
            this.listUnvan.UseCompatibleStateImageBehavior = false;
            this.listUnvan.View = System.Windows.Forms.View.Details;
            this.listUnvan.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // unvanNo
            // 
            this.unvanNo.Text = "Ünvan No";
            this.unvanNo.Width = 122;
            // 
            // unvanAdi
            // 
            this.unvanAdi.Text = "Ünvan Adı";
            this.unvanAdi.Width = 131;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::telekomAidatTakip.Properties.Resources.telekom;
            this.pictureBox1.Location = new System.Drawing.Point(416, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmTanimUnvan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listUnvan);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtUnvanNo);
            this.Controls.Add(this.txtUnvanAdi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTanimUnvan";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Text = "Ünvan Tanımlama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTanimUnvan_FormClosing);
            this.Load += new System.EventHandler(this.frmTanimUnvan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile btnSil;
        private MetroFramework.Controls.MetroTile btnKaydet;
        private MetroFramework.Controls.MetroTile btnYeni;
        private MetroFramework.Controls.MetroTextBox txtUnvanAdi;
        private MetroFramework.Controls.MetroTextBox txtUnvanNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListView listUnvan;
        private System.Windows.Forms.ColumnHeader unvanNo;
        private System.Windows.Forms.ColumnHeader unvanAdi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}