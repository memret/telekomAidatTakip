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
    public partial class frmRaporAidat : Form
    {
        public frmRaporAidat()
        {
            InitializeComponent();
        }

        private void frmRaporAidat_Load(object sender, EventArgs e)
        {
            PRG.DoldurIl(ref cboxil);
            cboxil.SelectedIndex = -1;
            cboxMudurluk.SelectedIndex = -1;
            cboxBirim.SelectedIndex = -1;
            cboxMudurluk.Enabled = false;
            cboxBirim.Enabled = false;
        }

               
        private void cboxil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxil.SelectedIndex != -1)
            {
                PRG.DoldurMudurluk(ref cboxMudurluk, ((KeyValuePair<int, string>)cboxil.SelectedItem).Key.ToString());
            }
        }

        
        //veri yüklenince seçili gelmese iyi olur

        private void cboxMudurluk_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboxMudurluk.SelectedIndex != -1)
            {
                PRG.DoldurBirim(ref cboxBirim, ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key.ToString());
            }
        }


      
    }



}

