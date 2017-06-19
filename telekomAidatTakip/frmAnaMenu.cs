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

        private void frmAnaMenu_Load(object sender, EventArgs e)
        {

        }

        #region Menu işlemleri
        frmTanimIl tanimil = new frmTanimIl();
        frmTanimBirim tanimBirim = new frmTanimBirim();
        frmTanimMudurluk tanimMudurluk = new frmTanimMudurluk();
        frmTanimUnvan tanimUnvan = new frmTanimUnvan();
        frmTanimTahsil tanimTahsil = new frmTanimTahsil();
        frmTanimUyelikIptal tanimUyelikIptal = new frmTanimUyelikIptal();

        frmRaporIl raporIl = new frmRaporIl();
        frmRaporUye raporUye = new frmRaporUye();
        frmRaporAidat raporAidat = new frmRaporAidat();

        frmAidatMiktar aidatMiktar = new frmAidatMiktar();
        frmAidatToplu aidatToplu = new frmAidatToplu();

        frmUye uye = new frmUye();
        frmUyeAidat uyeAidat = new frmUyeAidat();

        frmYedekleme yedekleme = new frmYedekleme();
        private void ilTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tanimil.IsDisposed)
            {
                tanimil = new frmTanimIl();
                tanimil.MdiParent = this;
                tanimil.Show();
            }
            else
            {
                tanimil.MdiParent = this;
                tanimil.Show();
                tanimil.Focus();
            }
        }

        private void birimTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tanimBirim.IsDisposed)
            {
                tanimBirim = new frmTanimBirim();
                tanimBirim.MdiParent = this;
                tanimBirim.Show();
            }
            else
            {
                tanimBirim.MdiParent = this;
                tanimBirim.Show();
                tanimBirim.Focus();
            }
        }

        private void müdürlükTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tanimMudurluk.IsDisposed)
            {
                tanimMudurluk = new frmTanimMudurluk();
                tanimMudurluk.MdiParent = this;
                tanimMudurluk.Show();
            }
            else
            {
                tanimMudurluk.MdiParent = this;
                tanimMudurluk.Show();
                tanimMudurluk.Focus();
            }
        }
        private void üyeFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uye.IsDisposed)
            {
                uye = new frmUye();
                uye.MdiParent = this;
                uye.Show();
            }
            else
            {
                uye.MdiParent = this;
                uye.Show();
                uye.Focus();
            }
        }

        private void ünvanTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tanimUnvan.IsDisposed)
            {
                tanimUnvan = new frmTanimUnvan();
                tanimUnvan.MdiParent = this;
                tanimUnvan.Show();
            }
            else
            {
                tanimUnvan.MdiParent = this;
                tanimUnvan.Show();
                tanimUnvan.Focus();
            }
        }

        private void tahsilTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tanimTahsil.IsDisposed)
            {
                tanimTahsil = new frmTanimTahsil();
                tanimTahsil.MdiParent = this;
                tanimTahsil.Show();
            }
            else
            {
                tanimTahsil.MdiParent = this;
                tanimTahsil.Show();
                tanimTahsil.Focus();
            }
        }

        private void üyelikİptalNedeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tanimUyelikIptal.IsDisposed)
            {
                tanimUyelikIptal = new frmTanimUyelikIptal();
                tanimUyelikIptal.MdiParent = this;
                tanimUyelikIptal.Show();
            }
            else
            {
                tanimUyelikIptal.MdiParent = this;
                tanimUyelikIptal.Show();
                tanimUyelikIptal.Focus();
            }
        }

        private void üyeRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (raporUye.IsDisposed)
            {
                raporUye = new frmRaporUye();
                raporUye.MdiParent = this;
                raporUye.Show();
            }
            else
            {
                raporUye.MdiParent = this;
                raporUye.Show();
                raporUye.Focus();
            }
        }

        private void ilRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (raporIl.IsDisposed)
            {
                raporIl = new frmRaporIl();
                raporIl.MdiParent = this;
                raporIl.Show();
            }
            else
            {
                raporIl.MdiParent = this;
                raporIl.Show();
                raporIl.Focus();
            }
        }

        private void aidatListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aidatMiktarıTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aidatMiktar.IsDisposed)
            {
                aidatMiktar = new frmAidatMiktar();
                aidatMiktar.MdiParent = this;
                aidatMiktar.Show();
            }
            else
            {
                aidatMiktar.MdiParent = this;
                aidatMiktar.Show();
                aidatMiktar.Focus();
            }
        }

        private void topluAidatÖdemesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aidatToplu.IsDisposed)
            {
                aidatToplu = new frmAidatToplu();
                aidatToplu.MdiParent = this;
                aidatToplu.Show();
            }
            else
            {
                aidatToplu.MdiParent = this;
                aidatToplu.Show();
                aidatToplu.Focus();
            }
        }

        private void yedeklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (yedekleme.IsDisposed)
            {
                yedekleme = new frmYedekleme();
                yedekleme.MdiParent = this;
                yedekleme.Show();
            }
            else
            {
                yedekleme.MdiParent = this;
                yedekleme.Show();
                yedekleme.Focus();
            }
        }

        private void aidatRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (raporAidat.IsDisposed)
            {
                raporAidat = new frmRaporAidat();
                raporAidat.MdiParent = this;
                raporAidat.Show();
            }
            else
            {
                raporAidat.MdiParent = this;
                raporAidat.Show();
                raporAidat.Focus();
            }
        }

        #endregion



    }
}
