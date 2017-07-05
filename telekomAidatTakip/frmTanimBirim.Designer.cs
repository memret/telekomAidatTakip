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
            this.listvil = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxMudurluk = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtBirimAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBirimKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listvil
            // 
            this.listvil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.listvil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listvil.FullRowSelect = true;
            this.listvil.Location = new System.Drawing.Point(4, 24);
            this.listvil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listvil.Name = "listvil";
            this.listvil.Size = new System.Drawing.Size(524, 282);
            this.listvil.TabIndex = 7;
            this.listvil.UseCompatibleStateImageBehavior = false;
            this.listvil.View = System.Windows.Forms.View.Details;
            this.listvil.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listvil_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Birim No";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Birim";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Müdürlük No";
            this.columnHeader4.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Müdürlük";
            this.columnHeader3.Width = 119;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxMudurluk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnYeni);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtBirimAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBirimKodu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(532, 258);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birim Tanımları";
            // 
            // cBoxMudurluk
            // 
            this.cBoxMudurluk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMudurluk.Enabled = false;
            this.cBoxMudurluk.FormattingEnabled = true;
            this.cBoxMudurluk.Location = new System.Drawing.Point(136, 111);
            this.cBoxMudurluk.Name = "cBoxMudurluk";
            this.cBoxMudurluk.Size = new System.Drawing.Size(340, 28);
            this.cBoxMudurluk.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Müdürlük:";
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnYeni.Location = new System.Drawing.Point(16, 169);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(132, 71);
            this.btnYeni.TabIndex = 4;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSil.Location = new System.Drawing.Point(354, 169);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(132, 71);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnKaydet.Location = new System.Drawing.Point(188, 169);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(132, 71);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtBirimAdi
            // 
            this.txtBirimAdi.Enabled = false;
            this.txtBirimAdi.Location = new System.Drawing.Point(136, 74);
            this.txtBirimAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBirimAdi.Name = "txtBirimAdi";
            this.txtBirimAdi.Size = new System.Drawing.Size(340, 26);
            this.txtBirimAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Birim:";
            // 
            // txtBirimKodu
            // 
            this.txtBirimKodu.Enabled = false;
            this.txtBirimKodu.Location = new System.Drawing.Point(136, 34);
            this.txtBirimKodu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBirimKodu.Name = "txtBirimKodu";
            this.txtBirimKodu.Size = new System.Drawing.Size(340, 26);
            this.txtBirimKodu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birim No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listvil);
            this.groupBox2.Location = new System.Drawing.Point(15, 285);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(532, 311);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlı Birimler";
            // 
            // frmTanimBirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmTanimBirim";
            this.Text = "Birim Tanımlama";
            this.Load += new System.EventHandler(this.frmTanimBirim_Load);
            this.Resize += new System.EventHandler(this.frmTanimBirim_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listvil;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtBirimAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBirimKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxMudurluk;
    }
}