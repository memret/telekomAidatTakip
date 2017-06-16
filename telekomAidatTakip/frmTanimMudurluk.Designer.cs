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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMdrKod = new System.Windows.Forms.TextBox();
            this.txtMdrAd = new System.Windows.Forms.TextBox();
            this.comboBoxIl = new System.Windows.Forms.ComboBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listMdr = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btnYeni);
            this.groupBox1.Controls.Add(this.comboBoxIl);
            this.groupBox1.Controls.Add(this.txtMdrAd);
            this.groupBox1.Controls.Add(this.txtMdrKod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müdürlük Tanımları";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müdürlük Kod:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müdürlük Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "İl:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMdrKod
            // 
            this.txtMdrKod.Location = new System.Drawing.Point(120, 26);
            this.txtMdrKod.Name = "txtMdrKod";
            this.txtMdrKod.Size = new System.Drawing.Size(100, 22);
            this.txtMdrKod.TabIndex = 3;
            // 
            // txtMdrAd
            // 
            this.txtMdrAd.Location = new System.Drawing.Point(120, 64);
            this.txtMdrAd.Name = "txtMdrAd";
            this.txtMdrAd.Size = new System.Drawing.Size(433, 22);
            this.txtMdrAd.TabIndex = 5;
            // 
            // comboBoxIl
            // 
            this.comboBoxIl.FormattingEnabled = true;
            this.comboBoxIl.Location = new System.Drawing.Point(120, 103);
            this.comboBoxIl.Name = "comboBoxIl";
            this.comboBoxIl.Size = new System.Drawing.Size(433, 24);
            this.comboBoxIl.TabIndex = 6;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listMdr);
            this.groupBox2.Location = new System.Drawing.Point(25, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlı Müdürlükler";
            // 
            // listMdr
            // 
            this.listMdr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.listMdr.Location = new System.Drawing.Point(18, 22);
            this.listMdr.Margin = new System.Windows.Forms.Padding(4);
            this.listMdr.Name = "listMdr";
            this.listMdr.Size = new System.Drawing.Size(564, 215);
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
            this.ClientSize = new System.Drawing.Size(655, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTanimMudurluk";
            this.Text = "frmTanimMudurluk";
            this.Load += new System.EventHandler(this.frmTanimMudurluk_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxIl;
        private System.Windows.Forms.TextBox txtMdrAd;
        private System.Windows.Forms.TextBox txtMdrKod;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listMdr;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnKaydet;
    }
}