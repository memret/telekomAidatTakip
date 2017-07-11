namespace telekomAidatTakip
{
    partial class frmUyeSil
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.btnOnayla = new MetroFramework.Controls.MetroTile();
            this.btnIptal = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Silinme Nedeni:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 23;
            this.comboBox1.Location = new System.Drawing.Point(132, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 29);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.UseSelectable = true;
            // 
            // btnOnayla
            // 
            this.btnOnayla.ActiveControl = null;
            this.btnOnayla.Location = new System.Drawing.Point(132, 96);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(82, 40);
            this.btnOnayla.TabIndex = 6;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOnayla.UseSelectable = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.ActiveControl = null;
            this.btnIptal.Location = new System.Drawing.Point(242, 96);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(82, 40);
            this.btnIptal.TabIndex = 6;
            this.btnIptal.Text = "İptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIptal.UseSelectable = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // frmUyeSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 150);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmUyeSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Üye Silme Nedeni";
            this.Load += new System.EventHandler(this.frmUyeSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox comboBox1;
        private MetroFramework.Controls.MetroTile btnOnayla;
        private MetroFramework.Controls.MetroTile btnIptal;
    }
}