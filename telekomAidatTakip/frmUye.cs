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
                txtAdSoyad.Text = data["adsoyad"].ToString();
                txtSicilNo.Text = sicilno;

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
            cboxUnvan.DataSource = new BindingSource(cboxSource, null);
            cboxUnvan.DisplayMember = "Value";
            cboxUnvan.ValueMember = "Key";
        }
        private void DoldurIl()
        {
            Database db = new Database();
            var data = db.DataOku("select * from il");
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["ilno"]), data["iladi"].ToString());
            cboxIl.DataSource = new BindingSource(cboxSource, null);
            cboxIl.DisplayMember = "Value";
            cboxIl.ValueMember = "Key";
        }
        private void DoldurMudurluk()
        {
            Database db = new Database();
            var data = db.DataOku("select * from mudurluk");
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["mudurlukno"]), data["mudurlukadi"].ToString());
            cboxIl.DataSource = new BindingSource(cboxSource, null);
            cboxIl.DisplayMember = "Value";
            cboxIl.ValueMember = "Key";
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
    }
}
