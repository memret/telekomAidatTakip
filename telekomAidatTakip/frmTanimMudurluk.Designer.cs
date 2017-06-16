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
            this.groupBoxMdrTnm = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.comboBox_il = new System.Windows.Forms.ComboBox();
            this.txtMdrAd = new System.Windows.Forms.TextBox();
            this.txtMdrKod = new System.Windows.Forms.TextBox();
            this.label_il = new System.Windows.Forms.Label();
            this.labelMdrAd = new System.Windows.Forms.Label();
            this.labelMdrKod = new System.Windows.Forms.Label();
            this.boxKayitliMdr = new System.Windows.Forms.GroupBox();
            this.listMdr = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxMdrTnm.SuspendLayout();
            this.boxKayitliMdr.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMdrTnm
            // 
            this.groupBoxMdrTnm.Controls.Add(this.button4);
            this.groupBoxMdrTnm.Controls.Add(this.btnKaydet);
            this.groupBoxMdrTnm.Controls.Add(this.btnYeni);
            this.groupBoxMdrTnm.Controls.Add(this.comboBox_il);
            this.groupBoxMdrTnm.Controls.Add(this.txtMdrAd);
            this.groupBoxMdrTnm.Controls.Add(this.txtMdrKod);
            this.groupBoxMdrTnm.Controls.Add(this.label_il);
            this.groupBoxMdrTnm.Controls.Add(this.labelMdrAd);
            this.groupBoxMdrTnm.Controls.Add(this.labelMdrKod);
            this.groupBoxMdrTnm.Location = new System.Drawing.Point(20, 28);
            this.groupBoxMdrTnm.Name = "groupBoxMdrTnm";
            this.groupBoxMdrTnm.Size = new System.Drawing.Size(586, 238);
            this.groupBoxMdrTnm.TabIndex = 0;
            this.groupBoxMdrTnm.TabStop = false;
            this.groupBoxMdrTnm.Text = "Müdürlük Tanımları";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(394, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 64);
            this.button4.TabIndex = 10;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(239, 148);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(114, 64);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(84, 148);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(114, 64);
            this.btnYeni.TabIndex = 7;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_il
            // 
            this.comboBox_il.FormattingEnabled = true;
            this.comboBox_il.Location = new System.Drawing.Point(120, 103);
            this.comboBox_il.Name = "comboBox_il";
            this.comboBox_il.Size = new System.Drawing.Size(433, 24);
            this.comboBox_il.TabIndex = 6;
            // 
            // txtMdrAd
            // 
            this.txtMdrAd.Location = new System.Drawing.Point(120, 64);
            this.txtMdrAd.Name = "txtMdrAd";
            this.txtMdrAd.Size = new System.Drawing.Size(433, 22);
            this.txtMdrAd.TabIndex = 5;
            // 
            // txtMdrKod
            // 
            this.txtMdrKod.Location = new System.Drawing.Point(120, 26);
            this.txtMdrKod.Name = "txtMdrKod";
            this.txtMdrKod.Size = new System.Drawing.Size(100, 22);
            this.txtMdrKod.TabIndex = 3;
            // 
            // label_il
            // 
            this.label_il.AutoSize = true;
            this.label_il.Location = new System.Drawing.Point(15, 103);
            this.label_il.Name = "label_il";
            this.label_il.Size = new System.Drawing.Size(18, 17);
            this.label_il.TabIndex = 2;
            this.label_il.Text = "İl:";
            this.label_il.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelMdrAd
            // 
            this.labelMdrAd.AutoSize = true;
            this.labelMdrAd.Location = new System.Drawing.Point(15, 67);
            this.labelMdrAd.Name = "labelMdrAd";
            this.labelMdrAd.Size = new System.Drawing.Size(94, 17);
            this.labelMdrAd.TabIndex = 1;
            this.labelMdrAd.Text = "Müdürlük Adı:";
            // 
            // labelMdrKod
            // 
            this.labelMdrKod.AutoSize = true;
            this.labelMdrKod.Location = new System.Drawing.Point(15, 31);
            this.labelMdrKod.Name = "labelMdrKod";
            this.labelMdrKod.Size = new System.Drawing.Size(99, 17);
            this.labelMdrKod.TabIndex = 0;
            this.labelMdrKod.Text = "Müdürlük Kod:";
            this.labelMdrKod.Click += new System.EventHandler(this.label1_Click);
            // 
            // boxKayitliMdr
            // 
            this.boxKayitliMdr.Controls.Add(this.listMdr);
            this.boxKayitliMdr.Location = new System.Drawing.Point(20, 272);
            this.boxKayitliMdr.Name = "boxKayitliMdr";
            this.boxKayitliMdr.Size = new System.Drawing.Size(586, 252);
            this.boxKayitliMdr.TabIndex = 1;
            this.boxKayitliMdr.TabStop = false;
            this.boxKayitliMdr.Text = "Kayıtlı Müdürlükler";
            // 
            // listMdr
            // 
            this.listMdr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.listMdr.Location = new System.Drawing.Point(18, 30);
            this.listMdr.Margin = new System.Windows.Forms.Padding(4);
            this.listMdr.Name = "listMdr";
            this.listMdr.Size = new System.Drawing.Size(535, 215);
            this.listMdr.TabIndex = 1;
            this.listMdr.UseCompatibleStateImageBehavior = false;
            this.listMdr.View = System.Windows.Forms.View.Details;
            this.listMdr.SelectedIndexChanged += new System.EventHandler(this.listvil_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Müdürlük Adı";
            this.columnHeader2.Width = 215;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kod";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İl";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İl Kodu";
            this.columnHeader4.Width = 118;
            // 
            // frmTanimMudurluk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 538);
            this.Controls.Add(this.boxKayitliMdr);
            this.Controls.Add(this.groupBoxMdrTnm);
            this.Name = "frmTanimMudurluk";
            this.Text = "Müdürlük Tanımları";
            this.Load += new System.EventHandler(this.frmTanimMudurluk_Load);
            this.groupBoxMdrTnm.ResumeLayout(false);
            this.groupBoxMdrTnm.PerformLayout();
            this.boxKayitliMdr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMdrTnm;
        private System.Windows.Forms.Label labelMdrKod;
        private System.Windows.Forms.Label label_il;
        private System.Windows.Forms.Label labelMdrAd;
        private System.Windows.Forms.ComboBox comboBox_il;
        private System.Windows.Forms.TextBox txtMdrAd;
        private System.Windows.Forms.TextBox txtMdrKod;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox boxKayitliMdr;
        private System.Windows.Forms.ListView listMdr;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnKaydet;
    }
}