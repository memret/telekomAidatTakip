﻿namespace telekomAidatTakip
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
            this.grpbxAidatMiktar = new System.Windows.Forms.GroupBox();
            this.txtAidatMiktari = new System.Windows.Forms.TextBox();
            this.cboxKisim = new System.Windows.Forms.ComboBox();
            this.cboxMudurluk = new System.Windows.Forms.ComboBox();
            this.cboxIl = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpbxAidatMiktar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxAidatMiktar
            // 
            this.grpbxAidatMiktar.Controls.Add(this.txtAidatMiktari);
            this.grpbxAidatMiktar.Controls.Add(this.cboxKisim);
            this.grpbxAidatMiktar.Controls.Add(this.cboxMudurluk);
            this.grpbxAidatMiktar.Controls.Add(this.cboxIl);
            this.grpbxAidatMiktar.Controls.Add(this.label4);
            this.grpbxAidatMiktar.Controls.Add(this.label3);
            this.grpbxAidatMiktar.Controls.Add(this.label2);
            this.grpbxAidatMiktar.Controls.Add(this.label1);
            this.grpbxAidatMiktar.Location = new System.Drawing.Point(12, 12);
            this.grpbxAidatMiktar.Name = "grpbxAidatMiktar";
            this.grpbxAidatMiktar.Size = new System.Drawing.Size(410, 156);
            this.grpbxAidatMiktar.TabIndex = 0;
            this.grpbxAidatMiktar.TabStop = false;
            this.grpbxAidatMiktar.Text = "Aidat Miktarı Değiştirme";
            // 
            // txtAidatMiktari
            // 
            this.txtAidatMiktari.Location = new System.Drawing.Point(105, 114);
            this.txtAidatMiktari.Name = "txtAidatMiktari";
            this.txtAidatMiktari.Size = new System.Drawing.Size(175, 20);
            this.txtAidatMiktari.TabIndex = 3;
            // 
            // cboxKisim
            // 
            this.cboxKisim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxKisim.FormattingEnabled = true;
            this.cboxKisim.Location = new System.Drawing.Point(105, 87);
            this.cboxKisim.Name = "cboxKisim";
            this.cboxKisim.Size = new System.Drawing.Size(238, 21);
            this.cboxKisim.TabIndex = 2;
            this.cboxKisim.SelectedIndexChanged += new System.EventHandler(this.cboxKisim_SelectedIndexChanged);
            // 
            // cboxMudurluk
            // 
            this.cboxMudurluk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMudurluk.FormattingEnabled = true;
            this.cboxMudurluk.Location = new System.Drawing.Point(105, 62);
            this.cboxMudurluk.Name = "cboxMudurluk";
            this.cboxMudurluk.Size = new System.Drawing.Size(238, 21);
            this.cboxMudurluk.TabIndex = 2;
            this.cboxMudurluk.SelectedIndexChanged += new System.EventHandler(this.cboxMudurluk_SelectedIndexChanged);
            // 
            // cboxIl
            // 
            this.cboxIl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxIl.FormattingEnabled = true;
            this.cboxIl.Location = new System.Drawing.Point(105, 37);
            this.cboxIl.Name = "cboxIl";
            this.cboxIl.Size = new System.Drawing.Size(238, 21);
            this.cboxIl.TabIndex = 2;
            this.cboxIl.SelectedIndexChanged += new System.EventHandler(this.cboxIl_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Aidat Miktarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kısım";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müdürlük:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İl:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(92, 189);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 50);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Güncelle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(284, 189);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 50);
            this.btnIptal.TabIndex = 2;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(190, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAidatMiktar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpbxAidatMiktar);
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Name = "frmAidatMiktar";
            this.Text = "frmAidatMiktar";
            this.Load += new System.EventHandler(this.frmAidatMiktar_Load);
            this.grpbxAidatMiktar.ResumeLayout(false);
            this.grpbxAidatMiktar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxAidatMiktar;
        private System.Windows.Forms.TextBox txtAidatMiktari;
        private System.Windows.Forms.ComboBox cboxKisim;
        private System.Windows.Forms.ComboBox cboxMudurluk;
        private System.Windows.Forms.ComboBox cboxIl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button button1;
    }
}