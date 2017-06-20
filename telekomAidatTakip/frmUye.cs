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
        private void DoldurTemelBilgiler(string sicilno)
        {
            Database db = new Database();
            var data = db.DataOku("select * from uye where sicilno=@0",sicilno);
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
            while(data.Read())
                cboxSource.Add(Convert.ToInt32(data["tahsilno"]), data["tahsiladi"].ToString());
            cboxTahsil.DataSource = new BindingSource(cboxSource, null);
            cboxTahsil.DisplayMember = "Value";
            cboxTahsil.ValueMember = "Key";
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
                
            }
        }
        private void DoldurIl()
        {
            Database db = new Database();
            var data = db.DataOku("select * from il");
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["ilno"]), data["iladi"].ToString());
            cboxll.DataSource = new BindingSource(cboxSource, null);
            cboxll.DisplayMember = "Value";
            cboxll.ValueMember = "Key";
        }
        private void DoldurMudurluk()
        {
            Database db = new Database();
            var data = db.DataOku("select * from mudurluk");
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["mudurlukno"]), data["mudurlukadi"].ToString());
            cboxMudurluk.DataSource = new BindingSource(cboxSource, null);
            cboxUnvan.DisplayMember = "Value";
            cboxUnvan.ValueMember = "Key";
        }
        private void DoldurBirim()
        {
            Database db = new Database();
            var data = db.DataOku("select * from birim");
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["birimno"]), data["birimadi"].ToString());
            cboxBirim.DataSource = new BindingSource(cboxSource, null);
            cboxBirim.DisplayMember = "Value";
            cboxBirim.ValueMember = "Key";
        }
        private void DoldurUyelikTipi()
        {
            Database db = new Database();
            var data = db.DataOku("select * from uyeliktipi");
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["uyeliktipno"]), data["uyeliktipadi"].ToString());
            cboxUyelikTipi.DataSource = new BindingSource(cboxSource, null);
            cboxUyelikTipi.DisplayMember = "Value";
            cboxUyelikTipi.ValueMember = "Key";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtİşAdresi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtÜyeNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cboxTahsilDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxll_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSilinmeBilgisi_Click(object sender, EventArgs e)
        {

        }
    }
}
