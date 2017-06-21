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
    public partial class frmUye : Form
    {
        public frmUye()
        {
            InitializeComponent();
        }



        private void frmUye_Load(object sender, EventArgs e)
        {
            DoldurKomple();

        }
        private void DoldurKomple()
        {
            PRG.DoldurTahsil(ref cboxTahsil);
            PRG.DoldurUnvan(ref cboxUnvan);
            PRG.DoldurIl(ref cboxIl);
            PRG.DoldurMudurluk(ref cboxMudurluk, ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key.ToString());
            PRG.DoldurBirim(ref cboxBirim, ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key.ToString());
            PRG.DoldurUyelikTipi(ref cboxUyelikTipi);
        }
        private void DoldurKomple(string sicilno)
        {
            DoldurKomple();
            DoldurTemelBilgiler(sicilno);
        }
        private void DoldurAdresBilgiler(string sicilno)
        {
            Database db = new Database();
            var data = db.DataOku("select * from adres where sicilno=@0", sicilno);
            if (data.Read())
            {
                

            }
        }
        private void DoldurTemelBilgiler(string sicilno)
        {
            Database db = new Database();
            var data = db.DataOku("select * from uye where sicilno=@0", sicilno);
            if (data.Read())
            {
                txtAdSoyad.Text = data["adsoyad"].ToString();
                txtUyeNo.Text = sicilno;

            }
        }
        

        private void cboxUnvan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            PRG.DoldurMudurluk(ref cboxMudurluk, ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key.ToString());
        }

        private void cboxMudurluk_SelectedIndexChanged(object sender, EventArgs e)
        {
            PRG.DoldurBirim(ref cboxBirim, ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key.ToString());
        }

        private void cboxBirim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
