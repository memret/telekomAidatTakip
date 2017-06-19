using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telekomAidatTakip
{
    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }

        private void ilTanımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTanimIl tanimIl = new frmTanimIl();
            tanimIl.MdiParent = this;
            tanimIl.Show();
        }

        private void birimlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTanimBirim tanimBirim = new frmTanimBirim();
            tanimBirim.MdiParent = this;
            tanimBirim.Show();
        }
    }
}
