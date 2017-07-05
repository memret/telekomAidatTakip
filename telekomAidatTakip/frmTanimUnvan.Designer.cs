namespace telekomAidatTakip
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtUnvanAdi = new System.Windows.Forms.TextBox();
            this.txtUnvanNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listUnvan = new System.Windows.Forms.ListView();
            this.ünvanNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ünvanAdı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btnYeni);
            this.groupBox1.Controls.Add(this.txtUnvanAdi);
            this.groupBox1.Controls.Add(this.txtUnvanNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ünvan Tanımları";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSil.Location = new System.Drawing.Point(229, 87);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 39);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnKaydet.Location = new System.Drawing.Point(123, 87);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(80, 39);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnYeni.Location = new System.Drawing.Point(17, 87);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(80, 39);
            this.btnYeni.TabIndex = 4;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtUnvanAdi
            // 
            this.txtUnvanAdi.Location = new System.Drawing.Point(94, 54);
            this.txtUnvanAdi.Name = "txtUnvanAdi";
            this.txtUnvanAdi.Size = new System.Drawing.Size(158, 20);
            this.txtUnvanAdi.TabIndex = 3;
            // 
            // txtUnvanNo
            // 
            this.txtUnvanNo.Location = new System.Drawing.Point(94, 23);
            this.txtUnvanNo.Name = "txtUnvanNo";
            this.txtUnvanNo.Size = new System.Drawing.Size(87, 20);
            this.txtUnvanNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ünvan Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ünvan No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listUnvan);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ünvan Listesi";
            // 
            // listUnvan
            // 
            this.listUnvan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ünvanNo,
            this.ünvanAdı});
            this.listUnvan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUnvan.FullRowSelect = true;
            this.listUnvan.Location = new System.Drawing.Point(3, 16);
            this.listUnvan.Name = "listUnvan";
            this.listUnvan.Size = new System.Drawing.Size(321, 137);
            this.listUnvan.TabIndex = 0;
            this.listUnvan.UseCompatibleStateImageBehavior = false;
            this.listUnvan.View = System.Windows.Forms.View.Details;
            this.listUnvan.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // ünvanNo
            // 
            this.ünvanNo.Text = "Ünvan No";
            this.ünvanNo.Width = 113;
            // 
            // ünvanAdı
            // 
            this.ünvanAdı.Text = "Ünvan Adı";
            this.ünvanAdı.Width = 193;
            // 
            // frmTanimUnvan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 326);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTanimUnvan";
            this.Text = "Ünvan Tanımlama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTanimUnvan_FormClosing);
            this.Load += new System.EventHandler(this.frmTanimUnvan_Load);
            this.Resize += new System.EventHandler(this.frmTanimUnvan_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtUnvanAdi;
        private System.Windows.Forms.TextBox txtUnvanNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listUnvan;
        private System.Windows.Forms.ColumnHeader ünvanNo;
        private System.Windows.Forms.ColumnHeader ünvanAdı;
    }
}