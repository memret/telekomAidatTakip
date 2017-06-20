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
            DoldurTahsil();
            DoldurUnvan();
            DoldurIl();
            DoldurMudurluk();
            DoldurBirim();
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
        private void DoldurTahsil()
        {
            Database db = new Database();
            var data = db.DataOku("select * from tahsil");
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["tahsilno"]), data["tahsiladi"].ToString());
            try
            {
                cboxTahsil.DataSource = new BindingSource(cboxSource, null);
                cboxTahsil.DisplayMember = "Value";
                cboxTahsil.ValueMember = "Key";
            }
            catch
            {
                cboxTahsil.Items.Add("Veri Yok");
            }
        }
        private void DoldurUnvan()
        {
            Database db = new Database();
            var data = db.DataOku("select * from unvan");
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["unvanNo"]), data["Unvanadi"].ToString());
            try
            {
                cboxUnvan.DataSource = new BindingSource(cboxSource, null);
                cboxUnvan.DisplayMember = "Value";
                cboxUnvan.ValueMember = "Key";
            }
            catch
            {
                cboxUnvan.DataSource = null;
                cboxUnvan.Items.Add("Veri Yok");
            }
        }
        private void DoldurIl()
        {
            Database db = new Database();
            var data = db.DataOku("select * from il");
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["ilno"]), data["iladi"].ToString());
            try
            {
                cboxIl.DataSource = new BindingSource(cboxSource, null);
                cboxIl.DisplayMember = "Value";
                cboxIl.ValueMember = "Key";
            }
            catch
            {
                cboxIl.Items.Add("Veri Yok");
            }
        }
        private void DoldurMudurluk()
        {
            Database db = new Database();
            var data = db.DataOku("select * from mudurluk");
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["mudurlukno"]), data["mudurlukadi"].ToString());
            try
            {
                cboxMudurluk.DataSource = new BindingSource(cboxSource, null);
                cboxMudurluk.DisplayMember = "Value";
                cboxMudurluk.ValueMember = "Key";
            }
            catch
            {
                cboxMudurluk.Items.Add("Veri Yok");
            }
        }
        private void DoldurBirim()
        {
            Database db = new Database();
            var data = db.DataOku("select * from birim");
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["birimno"]), data["birimadi"].ToString());
            try
            {
                cboxBirim.DataSource = new BindingSource(cboxSource, null);
                cboxBirim.DisplayMember = "Value";
                cboxBirim.ValueMember = "Key";

            }
            catch
            {
                cboxBirim.Items.Add("Veri Yok");
            }
        }
        private void DoldurUyelikTipi()
        {
            Database db = new Database();
            var data = db.DataOku("select * from uyeliktipi");
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["uyeliktipno"]), data["uyeliktipadi"].ToString());
            try
            {
                cboxUyelikTipi.DataSource = new BindingSource(cboxSource, null);
                cboxUyelikTipi.DisplayMember = "Value";
                cboxUyelikTipi.ValueMember = "Key";
            }
            catch
            {
                cboxUyelikTipi.Items.Add("Veri Yok");
            }
        }

        private void cboxUnvan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxIl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxMudurluk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxBirim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
