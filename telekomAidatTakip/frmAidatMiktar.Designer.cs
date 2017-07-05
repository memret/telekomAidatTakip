namespace telekomAidatTakip
{
    partial class frmAidatMiktar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxIl = new System.Windows.Forms.ComboBox();
            this.cboxMudurluk = new System.Windows.Forms.ComboBox();
            this.cboxBirim = new System.Windows.Forms.ComboBox();
            this.txtAidatMiktari = new System.Windows.Forms.TextBox();
            this.grpbxAidatMiktar = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grpbxAidatMiktar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İl:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müdürlük:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Birim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Aidat Miktarı:";
            // 
            // cboxIl
            // 
            this.cboxIl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxIl.FormattingEnabled = true;
            this.cboxIl.Location = new System.Drawing.Point(152, 43);
            this.cboxIl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxIl.Name = "cboxIl";
            this.cboxIl.Size = new System.Drawing.Size(355, 28);
            this.cboxIl.TabIndex = 0;
            this.cboxIl.SelectionChangeCommitted += new System.EventHandler(this.cboxIl_SelectionChangeCommitted);
            // 
            // cboxMudurluk
            // 
            this.cboxMudurluk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMudurluk.FormattingEnabled = true;
            this.cboxMudurluk.Location = new System.Drawing.Point(152, 82);
            this.cboxMudurluk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxMudurluk.Name = "cboxMudurluk";
            this.cboxMudurluk.Size = new System.Drawing.Size(355, 28);
            this.cboxMudurluk.TabIndex = 1;
            this.cboxMudurluk.SelectionChangeCommitted += new System.EventHandler(this.cboxMudurluk_SelectionChangeCommitted);
            // 
            // cboxBirim
            // 
            this.cboxBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBirim.FormattingEnabled = true;
            this.cboxBirim.Location = new System.Drawing.Point(152, 120);
            this.cboxBirim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxBirim.Name = "cboxBirim";
            this.cboxBirim.Size = new System.Drawing.Size(355, 28);
            this.cboxBirim.TabIndex = 2;
            this.cboxBirim.SelectionChangeCommitted += new System.EventHandler(this.cboxBirim_SelectionChangeCommitted);
            // 
            // txtAidatMiktari
            // 
            this.txtAidatMiktari.Location = new System.Drawing.Point(152, 162);
            this.txtAidatMiktari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAidatMiktari.Name = "txtAidatMiktari";
            this.txtAidatMiktari.Size = new System.Drawing.Size(260, 26);
            this.txtAidatMiktari.TabIndex = 3;
            // 
            // grpbxAidatMiktar
            // 
            this.grpbxAidatMiktar.Controls.Add(this.label7);
            this.grpbxAidatMiktar.Controls.Add(this.label6);
            this.grpbxAidatMiktar.Controls.Add(this.label5);
            this.grpbxAidatMiktar.Controls.Add(this.btnIptal);
            this.grpbxAidatMiktar.Controls.Add(this.button1);
            this.grpbxAidatMiktar.Controls.Add(this.txtAidatMiktari);
            this.grpbxAidatMiktar.Controls.Add(this.cboxBirim);
            this.grpbxAidatMiktar.Controls.Add(this.btnKaydet);
            this.grpbxAidatMiktar.Controls.Add(this.cboxMudurluk);
            this.grpbxAidatMiktar.Controls.Add(this.cboxIl);
            this.grpbxAidatMiktar.Controls.Add(this.label4);
            this.grpbxAidatMiktar.Controls.Add(this.label3);
            this.grpbxAidatMiktar.Controls.Add(this.label2);
            this.grpbxAidatMiktar.Controls.Add(this.label1);
            this.grpbxAidatMiktar.Location = new System.Drawing.Point(18, 18);
            this.grpbxAidatMiktar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxAidatMiktar.Name = "grpbxAidatMiktar";
            this.grpbxAidatMiktar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxAidatMiktar.Size = new System.Drawing.Size(546, 320);
            this.grpbxAidatMiktar.TabIndex = 0;
            this.grpbxAidatMiktar.TabStop = false;
            this.grpbxAidatMiktar.Text = "Aidat Miktarı Değiştirme";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnIptal.Location = new System.Drawing.Point(326, 217);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(112, 77);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(165, 217);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 77);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(165, 217);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 77);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Güncelle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmAidatMiktar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 358);
            this.Controls.Add(this.grpbxAidatMiktar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(601, 388);
            this.Name = "frmAidatMiktar";
            this.Text = "Aidat Miktarı Belirleme";
            this.Load += new System.EventHandler(this.frmAidatMiktar_Load);
            this.Resize += new System.EventHandler(this.frmAidatMiktar_Resize);
            this.grpbxAidatMiktar.ResumeLayout(false);
            this.grpbxAidatMiktar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxIl;
        private System.Windows.Forms.ComboBox cboxMudurluk;
        private System.Windows.Forms.ComboBox cboxBirim;
        private System.Windows.Forms.TextBox txtAidatMiktari;
        private System.Windows.Forms.GroupBox grpbxAidatMiktar;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}