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
            this.txtünvanAdı = new System.Windows.Forms.TextBox();
            this.txtünvanKodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ünvanKodu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.groupBox1.Controls.Add(this.txtünvanAdı);
            this.groupBox1.Controls.Add(this.txtünvanKodu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ünvan Tanımları";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(242, 105);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 52);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(131, 105);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 52);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(25, 105);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 52);
            this.btnYeni.TabIndex = 4;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtünvanAdı
            // 
            this.txtünvanAdı.Location = new System.Drawing.Point(106, 59);
            this.txtünvanAdı.Name = "txtünvanAdı";
            this.txtünvanAdı.Size = new System.Drawing.Size(100, 20);
            this.txtünvanAdı.TabIndex = 3;
            // 
            // txtünvanKodu
            // 
            this.txtünvanKodu.Location = new System.Drawing.Point(106, 25);
            this.txtünvanKodu.Name = "txtünvanKodu";
            this.txtünvanKodu.Size = new System.Drawing.Size(100, 20);
            this.txtünvanKodu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ünvan Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ünvan Kodu :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ünvanKodu,
            this.ünvanAdı});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(337, 137);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ünvanKodu
            // 
            this.ünvanKodu.Text = "Ünvan Kodu";
            this.ünvanKodu.Width = 89;
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
            this.ClientSize = new System.Drawing.Size(380, 354);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTanimUnvan";
            this.Text = "frmTanimUnvan";
            this.Load += new System.EventHandler(this.frmTanimUnvan_Load);
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
        private System.Windows.Forms.TextBox txtünvanAdı;
        private System.Windows.Forms.TextBox txtünvanKodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ünvanKodu;
        private System.Windows.Forms.ColumnHeader ünvanAdı;
    }
}