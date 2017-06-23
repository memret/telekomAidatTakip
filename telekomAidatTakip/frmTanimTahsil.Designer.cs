namespace telekomAidatTakip
{
    partial class frmTanimTahsil
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
            this.label1 = new System.Windows.Forms.Label();
            this.tahsilNo = new System.Windows.Forms.Label();
            this.tahsilAd = new System.Windows.Forms.Label();
            this.tahsilTanim = new System.Windows.Forms.GroupBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtTahsilAd = new System.Windows.Forms.TextBox();
            this.txtTahsilKodu = new System.Windows.Forms.TextBox();
            this.kayıtTahsil = new System.Windows.Forms.GroupBox();
            this.listvTanimTahsil = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tahsilTanim.SuspendLayout();
            this.kayıtTahsil.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // tahsilNo
            // 
            this.tahsilNo.AutoSize = true;
            this.tahsilNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tahsilNo.Location = new System.Drawing.Point(6, 28);
            this.tahsilNo.Name = "tahsilNo";
            this.tahsilNo.Size = new System.Drawing.Size(60, 13);
            this.tahsilNo.TabIndex = 1;
            this.tahsilNo.Text = "Tahsil Kod:";
            this.tahsilNo.Click += new System.EventHandler(this.tahsilNo_Click);
            // 
            // tahsilAd
            // 
            this.tahsilAd.AutoSize = true;
            this.tahsilAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tahsilAd.Location = new System.Drawing.Point(6, 59);
            this.tahsilAd.Name = "tahsilAd";
            this.tahsilAd.Size = new System.Drawing.Size(54, 13);
            this.tahsilAd.TabIndex = 2;
            this.tahsilAd.Text = "Tahsil Ad:";
            // 
            // tahsilTanim
            // 
            this.tahsilTanim.Controls.Add(this.btnYeni);
            this.tahsilTanim.Controls.Add(this.btnSil);
            this.tahsilTanim.Controls.Add(this.btnKaydet);
            this.tahsilTanim.Controls.Add(this.txtTahsilAd);
            this.tahsilTanim.Controls.Add(this.txtTahsilKodu);
            this.tahsilTanim.Controls.Add(this.tahsilNo);
            this.tahsilTanim.Controls.Add(this.tahsilAd);
            this.tahsilTanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tahsilTanim.Location = new System.Drawing.Point(12, 12);
            this.tahsilTanim.Name = "tahsilTanim";
            this.tahsilTanim.Size = new System.Drawing.Size(402, 152);
            this.tahsilTanim.TabIndex = 3;
            this.tahsilTanim.TabStop = false;
            this.tahsilTanim.Text = "Tahsil Tanımları";
            this.tahsilTanim.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnYeni.Location = new System.Drawing.Point(66, 87);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(88, 46);
            this.btnYeni.TabIndex = 5;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSil.Location = new System.Drawing.Point(256, 87);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 46);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnKaydet.Location = new System.Drawing.Point(162, 87);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(88, 46);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTahsilAd
            // 
            this.txtTahsilAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahsilAd.Location = new System.Drawing.Point(101, 54);
            this.txtTahsilAd.Name = "txtTahsilAd";
            this.txtTahsilAd.Size = new System.Drawing.Size(279, 20);
            this.txtTahsilAd.TabIndex = 4;
            this.txtTahsilAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTahsilKodu
            // 
            this.txtTahsilKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahsilKodu.Location = new System.Drawing.Point(101, 27);
            this.txtTahsilKodu.Name = "txtTahsilKodu";
            this.txtTahsilKodu.Size = new System.Drawing.Size(69, 20);
            this.txtTahsilKodu.TabIndex = 3;
            // 
            // kayıtTahsil
            // 
            this.kayıtTahsil.Controls.Add(this.listvTanimTahsil);
            this.kayıtTahsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtTahsil.Location = new System.Drawing.Point(12, 170);
            this.kayıtTahsil.Name = "kayıtTahsil";
            this.kayıtTahsil.Size = new System.Drawing.Size(402, 184);
            this.kayıtTahsil.TabIndex = 4;
            this.kayıtTahsil.TabStop = false;
            this.kayıtTahsil.Text = "Kayıtlı Tahsil Tanımları";
            // 
            // listvTanimTahsil
            // 
            this.listvTanimTahsil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            this.listvTanimTahsil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listvTanimTahsil.FullRowSelect = true;
            this.listvTanimTahsil.Location = new System.Drawing.Point(3, 19);
            this.listvTanimTahsil.Name = "listvTanimTahsil";
            this.listvTanimTahsil.Size = new System.Drawing.Size(396, 162);
            this.listvTanimTahsil.TabIndex = 0;
            this.listvTanimTahsil.UseCompatibleStateImageBehavior = false;
            this.listvTanimTahsil.View = System.Windows.Forms.View.Details;
            this.listvTanimTahsil.SelectedIndexChanged += new System.EventHandler(this.listvTanimTahsil_SelectedIndexChanged);
            this.listvTanimTahsil.DoubleClick += new System.EventHandler(this.listvTanimTahsil_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tahsil Kodu";
            this.columnHeader2.Width = 164;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tahsil Açıklama";
            this.columnHeader1.Width = 156;
            // 
            // frmTanimTahsil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 364);
            this.Controls.Add(this.kayıtTahsil);
            this.Controls.Add(this.tahsilTanim);
            this.Controls.Add(this.label1);
            this.Name = "frmTanimTahsil";
            this.Text = "Tahsil Tanımlama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTanimTahsil_FormClosing);
            this.Load += new System.EventHandler(this.frmTanimTahsil_Load);
            this.tahsilTanim.ResumeLayout(false);
            this.tahsilTanim.PerformLayout();
            this.kayıtTahsil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tahsilNo;
        private System.Windows.Forms.Label tahsilAd;
        private System.Windows.Forms.GroupBox tahsilTanim;
        private System.Windows.Forms.TextBox txtTahsilKodu;
        private System.Windows.Forms.TextBox txtTahsilAd;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox kayıtTahsil;
        private System.Windows.Forms.ListView listvTanimTahsil;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}