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

        }
        private void DoldurKomple(string sicilno)
        {
            DoldurTahsil();
            DoldurUnvan();
            DoldurIl();
            DoldurMudurluk();
            DoldurBirim();
        }
        private void DoldurTemelBilgiler(string sicilno)
        {
            Database db = new Database();
            var data = db.DataOku("select * from uye where sicilno=@0",sicilno);
            if (data.Read())
            {
                txtAd.Text = data["adsoyad"].ToString();
                txtÜyeNo.Text = sicilno;

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
            cboxTahsilDurumu.DataSource = new BindingSource(cboxSource, null);
            cboxTahsilDurumu.DisplayMember = "Value";
            cboxTahsilDurumu.ValueMember = "Key";
        }
        private void DoldurIl()
        {
            Database db = new Database();
            var data = db.DataOku("select * from il");
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["ilno"]), data["iladi"].ToString());
            cboxÜnvan.DataSource = new BindingSource(cboxSource, null);
            cboxÜnvan.DisplayMember = "Value";
            cboxÜnvan.ValueMember = "Key";
        }
        private void DoldurMudurluk()
        {
            Database db = new Database();
            var data = db.DataOku("select * from mudurluk");
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["mudurlukno"]), data["mudurlukadi"].ToString());
            cboxÜnvan.DataSource = new BindingSource(cboxSource, null);
            cboxÜnvan.DisplayMember = "Value";
            cboxÜnvan.ValueMember = "Key";
        }
        private void DoldurBirim()
        {
            Database db = new Database();
            var data = db.DataOku("select * from birim");
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["birimno"]), data["birimadi"].ToString());
            cboxIl.DataSource = new BindingSource(cboxSource, null);
            cboxIl.DisplayMember = "Value";
            cboxIl.ValueMember = "Key";
        }
        private void DoldurUyelikTipi()
        {
            Database db = new Database();
            var data = db.DataOku("select * from uyeliktipi");
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["uyeliktipno"]), data["uyeliktipadi"].ToString());
            cboxIl.DataSource = new BindingSource(cboxSource, null);
            cboxIl.DisplayMember = "Value";
            cboxIl.ValueMember = "Key";
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
    }
}
