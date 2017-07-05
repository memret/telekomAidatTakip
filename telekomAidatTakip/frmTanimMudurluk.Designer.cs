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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.comboBox_il = new System.Windows.Forms.ComboBox();
            this.txtMdrAd = new System.Windows.Forms.TextBox();
            this.txtMdrKod = new System.Windows.Forms.TextBox();
            this.label_il = new System.Windows.Forms.Label();
            this.labelMdrAd = new System.Windows.Forms.Label();
            this.labelMdrNo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listvMdr = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxMdrTnm.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMdrTnm
            // 
            this.groupBoxMdrTnm.Controls.Add(this.btnKaydet);
            this.groupBoxMdrTnm.Controls.Add(this.btnSil);
            this.groupBoxMdrTnm.Controls.Add(this.btnYeni);
            this.groupBoxMdrTnm.Controls.Add(this.comboBox_il);
            this.groupBoxMdrTnm.Controls.Add(this.txtMdrAd);
            this.groupBoxMdrTnm.Controls.Add(this.txtMdrKod);
            this.groupBoxMdrTnm.Controls.Add(this.label_il);
            this.groupBoxMdrTnm.Controls.Add(this.labelMdrAd);
            this.groupBoxMdrTnm.Controls.Add(this.labelMdrNo);
            this.groupBoxMdrTnm.Location = new System.Drawing.Point(16, 17);
            this.groupBoxMdrTnm.Name = "groupBoxMdrTnm";
            this.groupBoxMdrTnm.Size = new System.Drawing.Size(660, 282);
            this.groupBoxMdrTnm.TabIndex = 0;
            this.groupBoxMdrTnm.TabStop = false;
            this.groupBoxMdrTnm.Text = "Müdürlük Tanımları";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnKaydet.Location = new System.Drawing.Point(267, 185);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(129, 72);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSil.Location = new System.Drawing.Point(444, 185);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(129, 72);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnYeni.Location = new System.Drawing.Point(94, 185);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(129, 72);
            this.btnYeni.TabIndex = 7;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // comboBox_il
            // 
            this.comboBox_il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_il.FormattingEnabled = true;
            this.comboBox_il.Location = new System.Drawing.Point(142, 123);
            this.comboBox_il.Name = "comboBox_il";
            this.comboBox_il.Size = new System.Drawing.Size(409, 28);
            this.comboBox_il.TabIndex = 6;
            this.comboBox_il.SelectedIndexChanged += new System.EventHandler(this.comboBox_il_SelectedIndexChanged);
            // 
            // txtMdrAd
            // 
            this.txtMdrAd.Location = new System.Drawing.Point(142, 78);
            this.txtMdrAd.Name = "txtMdrAd";
            this.txtMdrAd.Size = new System.Drawing.Size(409, 26);
            this.txtMdrAd.TabIndex = 5;
            this.txtMdrAd.TextChanged += new System.EventHandler(this.txtMdrAd_TextChanged);
            // 
            // txtMdrKod
            // 
            this.txtMdrKod.Location = new System.Drawing.Point(142, 34);
            this.txtMdrKod.Name = "txtMdrKod";
            this.txtMdrKod.Size = new System.Drawing.Size(112, 26);
            this.txtMdrKod.TabIndex = 3;
            this.txtMdrKod.TextChanged += new System.EventHandler(this.txtMdrKod_TextChanged);
            // 
            // label_il
            // 
            this.label_il.AutoSize = true;
            this.label_il.Location = new System.Drawing.Point(22, 128);
            this.label_il.Name = "label_il";
            this.label_il.Size = new System.Drawing.Size(21, 20);
            this.label_il.TabIndex = 2;
            this.label_il.Text = "İl:";
            // 
            // labelMdrAd
            // 
            this.labelMdrAd.AutoSize = true;
            this.labelMdrAd.Location = new System.Drawing.Point(22, 83);
            this.labelMdrAd.Name = "labelMdrAd";
            this.labelMdrAd.Size = new System.Drawing.Size(105, 20);
            this.labelMdrAd.TabIndex = 1;
            this.labelMdrAd.Text = "Müdürlük Adı:";
            // 
            // labelMdrNo
            // 
            this.labelMdrNo.AutoSize = true;
            this.labelMdrNo.Location = new System.Drawing.Point(22, 38);
            this.labelMdrNo.Name = "labelMdrNo";
            this.labelMdrNo.Size = new System.Drawing.Size(102, 20);
            this.labelMdrNo.TabIndex = 0;
            this.labelMdrNo.Text = "Müdürlük No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listvMdr);
            this.groupBox2.Location = new System.Drawing.Point(16, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 315);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlı Müdürlükler";
            // 
            // listvMdr
            // 
            this.listvMdr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.listvMdr.Cursor = System.Windows.Forms.Cursors.Default;
            this.listvMdr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listvMdr.FullRowSelect = true;
            this.listvMdr.Location = new System.Drawing.Point(3, 22);
            this.listvMdr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listvMdr.Name = "listvMdr";
            this.listvMdr.Size = new System.Drawing.Size(654, 290);
            this.listvMdr.TabIndex = 1;
            this.listvMdr.UseCompatibleStateImageBehavior = false;
            this.listvMdr.View = System.Windows.Forms.View.Details;
            this.listvMdr.SelectedIndexChanged += new System.EventHandler(this.listvMdr_SelectedIndexChanged_1);
            this.listvMdr.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listvMdr_MouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Müdürlük Adı";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müdürlük No";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İl";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İl No";
            this.columnHeader4.Width = 125;
            // 
            // frmTanimMudurluk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 638);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxMdrTnm);
            this.Name = "frmTanimMudurluk";
            this.Text = "Müdürlük Tanımlama";
            this.Load += new System.EventHandler(this.frmTanimMudurluk_Load);
            this.Resize += new System.EventHandler(this.frmTanimMudurluk_Resize);
            this.groupBoxMdrTnm.ResumeLayout(false);
            this.groupBoxMdrTnm.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMdrTnm;
        private System.Windows.Forms.Label labelMdrNo;
        private System.Windows.Forms.Label label_il;
        private System.Windows.Forms.Label labelMdrAd;
        private System.Windows.Forms.ComboBox comboBox_il;
        private System.Windows.Forms.TextBox txtMdrAd;
        private System.Windows.Forms.TextBox txtMdrKod;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listvMdr;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnKaydet;
    }
}