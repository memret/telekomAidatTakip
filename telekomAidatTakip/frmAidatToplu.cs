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
    public partial class frmAidatToplu : Form
    {
        public frmAidatToplu()
        {
            InitializeComponent();
        }

        private void frmAidatToplu_Load(object sender, EventArgs e)
        {
            cBoxIlDoldur();
            cBoxMudurlukDoldur();
            cBoxKisimDoldur();
            cBoxYilDoldur();
            cBoxAyDoldur();


        }

        //iller cbox doldurma fonksiyonu
        private void cBoxIlDoldur()
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db2 = new Database();
            var data = db2.DataOku("SELECT ilNo,ilAdi FROM il");

            while (data.Read())
            {
                cboxSource.Add(Convert.ToInt32(data["ilNo"]), data["ilAdi"].ToString());
            }

            cboxil.DataSource = new BindingSource(cboxSource, null);
            cboxil.DisplayMember = "Value";
            cboxil.ValueMember = "Key";
        }

        //mudurluk cbox doldurma fonksiyonu
        private void cBoxMudurlukDoldur()
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db2 = new Database();
            var data = db2.DataOku("SELECT mudurlukNo,mudurlukAdi FROM mudurluk");

            while (data.Read())
            {
                cboxSource.Add(Convert.ToInt32(data["mudurlukNo"]), data["mudurlukAdi"].ToString());
            }
            cboxMudurluk.DataSource = new BindingSource(cboxSource, null);
            cboxMudurluk.DisplayMember = "Value";
            cboxMudurluk.ValueMember = "Key";

        }

        private void cBoxKisimDoldur()
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db2 = new Database();
            var data = db2.DataOku("SELECT birimNo,birimAdi FROM Birim");

            while (data.Read())
            {
                cboxSource.Add(Convert.ToInt32(data["birimNo"]), data["birimAdi"].ToString());
            }
            cboxKisim.DataSource = new BindingSource(cboxSource, null);
            cboxKisim.DisplayMember = "Value";
            cboxKisim.ValueMember = "Key";
        }
        private void cBoxYilDoldur()
        {
            for (int i = 1950; i <= 2017; i++)
            {
                cboxYil.Items.Add(i);
            }
        }

        private void cBoxAyDoldur()
        {
            for (int i = 1; i <= 12; i++)
            {
                cboxAy.Items.Add(i);
            }
        }


    }
}
