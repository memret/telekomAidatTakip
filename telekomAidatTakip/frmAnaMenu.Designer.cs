namespace telekomAidatTakip
{
    partial class frmAnaMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.üyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeFormuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilTanımıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeToolStripMenuItem,
            this.tanımlarToolStripMenuItem,
            this.birimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // üyeToolStripMenuItem
            // 
            this.üyeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeFormuToolStripMenuItem});
            this.üyeToolStripMenuItem.Name = "üyeToolStripMenuItem";
            this.üyeToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.üyeToolStripMenuItem.Text = "Üye";
            // 
            // üyeFormuToolStripMenuItem
            // 
            this.üyeFormuToolStripMenuItem.Name = "üyeFormuToolStripMenuItem";
            this.üyeFormuToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.üyeFormuToolStripMenuItem.Text = "Üye Formu";
            // 
            // tanımlarToolStripMenuItem
            // 
            this.tanımlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilTanımıToolStripMenuItem});
            this.tanımlarToolStripMenuItem.Name = "tanımlarToolStripMenuItem";
            this.tanımlarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tanımlarToolStripMenuItem.Text = "Tanımlar";
            // 
            // ilTanımıToolStripMenuItem
            // 
            this.ilTanımıToolStripMenuItem.Name = "ilTanımıToolStripMenuItem";
            this.ilTanımıToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ilTanımıToolStripMenuItem.Text = "İl Tanımı";
            this.ilTanımıToolStripMenuItem.Click += new System.EventHandler(this.ilTanımıToolStripMenuItem_Click);
            // 
            // birimToolStripMenuItem
            // 
            this.birimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.birimlerToolStripMenuItem});
            this.birimToolStripMenuItem.Name = "birimToolStripMenuItem";
            this.birimToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.birimToolStripMenuItem.Text = "Birim";
            // 
            // birimlerToolStripMenuItem
            // 
            this.birimlerToolStripMenuItem.Name = "birimlerToolStripMenuItem";
            this.birimlerToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.birimlerToolStripMenuItem.Text = "Birimler";
            this.birimlerToolStripMenuItem.Click += new System.EventHandler(this.birimlerToolStripMenuItem_Click);
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 521);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnaMenu";
            this.Text = "frmAnaMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem üyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeFormuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanımlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilTanımıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimlerToolStripMenuItem;
    }
}