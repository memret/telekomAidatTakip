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
            this.txtTahsil = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.kayıtTahsil = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.tahsilTanim.Controls.Add(this.textBox1);
            this.tahsilTanim.Controls.Add(this.txtTahsil);
            this.tahsilTanim.Controls.Add(this.tahsilNo);
            this.tahsilTanim.Controls.Add(this.tahsilAd);
            this.tahsilTanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tahsilTanim.Location = new System.Drawing.Point(12, 12);
            this.tahsilTanim.Name = "tahsilTanim";
            this.tahsilTanim.Size = new System.Drawing.Size(431, 174);
            this.tahsilTanim.TabIndex = 3;
            this.tahsilTanim.TabStop = false;
            this.tahsilTanim.Text = "Tahsil Tanımları";
            this.tahsilTanim.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTahsil
            // 
            this.txtTahsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahsil.Location = new System.Drawing.Point(101, 27);
            this.txtTahsil.Name = "txtTahsil";
            this.txtTahsil.Size = new System.Drawing.Size(69, 17);
            this.txtTahsil.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(101, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 17);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnYeni.Location = new System.Drawing.Point(9, 93);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(88, 46);
            this.btnYeni.TabIndex = 5;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSil.Location = new System.Drawing.Point(199, 93);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 46);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnKaydet.Location = new System.Drawing.Point(105, 93);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(88, 46);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // kayıtTahsil
            // 
            this.kayıtTahsil.Controls.Add(this.listView1);
            this.kayıtTahsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtTahsil.Location = new System.Drawing.Point(12, 192);
            this.kayıtTahsil.Name = "kayıtTahsil";
            this.kayıtTahsil.Size = new System.Drawing.Size(431, 184);
            this.kayıtTahsil.TabIndex = 4;
            this.kayıtTahsil.TabStop = false;
            this.kayıtTahsil.Text = "Kayıtlı Tahsil Tanımları";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(0, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(431, 156);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tahsil Açıklama";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tahsil Kodu";
            this.columnHeader2.Width = 89;
            // 
            // frmTanimTahsil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 379);
            this.Controls.Add(this.kayıtTahsil);
            this.Controls.Add(this.tahsilTanim);
            this.Controls.Add(this.label1);
            this.Name = "frmTanimTahsil";
            this.Text = "frmTanimTahsil";
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
        private System.Windows.Forms.TextBox txtTahsil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox kayıtTahsil;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}