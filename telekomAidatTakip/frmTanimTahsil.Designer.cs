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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tahsilTanim.SuspendLayout();
            this.kayıtTahsil.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // tahsilNo
            // 
            this.tahsilNo.AutoSize = true;
            this.tahsilNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tahsilNo.Location = new System.Drawing.Point(9, 43);
            this.tahsilNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tahsilNo.Name = "tahsilNo";
            this.tahsilNo.Size = new System.Drawing.Size(86, 20);
            this.tahsilNo.TabIndex = 1;
            this.tahsilNo.Text = "Tahsil Kod:";
            this.tahsilNo.Click += new System.EventHandler(this.tahsilNo_Click);
            // 
            // tahsilAd
            // 
            this.tahsilAd.AutoSize = true;
            this.tahsilAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tahsilAd.Location = new System.Drawing.Point(9, 91);
            this.tahsilAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tahsilAd.Name = "tahsilAd";
            this.tahsilAd.Size = new System.Drawing.Size(78, 20);
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
            this.tahsilTanim.Location = new System.Drawing.Point(18, 18);
            this.tahsilTanim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tahsilTanim.Name = "tahsilTanim";
            this.tahsilTanim.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tahsilTanim.Size = new System.Drawing.Size(646, 268);
            this.tahsilTanim.TabIndex = 3;
            this.tahsilTanim.TabStop = false;
            this.tahsilTanim.Text = "Tahsil Tanımları";
            this.tahsilTanim.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnYeni.Location = new System.Drawing.Point(14, 143);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(132, 71);
            this.btnYeni.TabIndex = 5;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSil.Location = new System.Drawing.Point(298, 143);
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
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnKaydet.Location = new System.Drawing.Point(158, 143);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(132, 71);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTahsilAd
            // 
            this.txtTahsilAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahsilAd.Location = new System.Drawing.Point(152, 83);
            this.txtTahsilAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTahsilAd.Name = "txtTahsilAd";
            this.txtTahsilAd.Size = new System.Drawing.Size(434, 26);
            this.txtTahsilAd.TabIndex = 4;
            this.txtTahsilAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTahsilKodu
            // 
            this.txtTahsilKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahsilKodu.Location = new System.Drawing.Point(152, 42);
            this.txtTahsilKodu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTahsilKodu.Name = "txtTahsilKodu";
            this.txtTahsilKodu.Size = new System.Drawing.Size(102, 26);
            this.txtTahsilKodu.TabIndex = 3;
            // 
            // kayıtTahsil
            // 
            this.kayıtTahsil.Controls.Add(this.listvTanimTahsil);
            this.kayıtTahsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtTahsil.Location = new System.Drawing.Point(18, 295);
            this.kayıtTahsil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kayıtTahsil.Name = "kayıtTahsil";
            this.kayıtTahsil.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kayıtTahsil.Size = new System.Drawing.Size(646, 283);
            this.kayıtTahsil.TabIndex = 4;
            this.kayıtTahsil.TabStop = false;
            this.kayıtTahsil.Text = "Kayıtlı Tahsil Tanımları";
            // 
            // listvTanimTahsil
            // 
            this.listvTanimTahsil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            this.listvTanimTahsil.FullRowSelect = true;
            this.listvTanimTahsil.Location = new System.Drawing.Point(0, 34);
            this.listvTanimTahsil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listvTanimTahsil.Name = "listvTanimTahsil";
            this.listvTanimTahsil.Size = new System.Drawing.Size(644, 238);
            this.listvTanimTahsil.TabIndex = 0;
            this.listvTanimTahsil.UseCompatibleStateImageBehavior = false;
            this.listvTanimTahsil.View = System.Windows.Forms.View.Details;
            this.listvTanimTahsil.SelectedIndexChanged += new System.EventHandler(this.listvTanimTahsil_SelectedIndexChanged);
            this.listvTanimTahsil.DoubleClick += new System.EventHandler(this.listvTanimTahsil_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tahsil Açıklama";
            this.columnHeader1.Width = 156;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tahsil Kodu";
            this.columnHeader2.Width = 164;
            // 
            // frmTanimTahsil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 583);
            this.Controls.Add(this.kayıtTahsil);
            this.Controls.Add(this.tahsilTanim);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTanimTahsil";
            this.Text = "frmTanimTahsil";
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