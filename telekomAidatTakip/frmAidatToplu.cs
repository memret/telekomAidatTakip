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
            cboxBirim.DataSource = new BindingSource(cboxSource, null);
            cboxBirim.DisplayMember = "Value";
            cboxBirim.ValueMember = "Key";
        }
  

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int ilNo = ((KeyValuePair<int, string>)cboxil.SelectedItem).Key;
            int mudurlukNo = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
            int birimNo = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
            DateTime dt = this.dateTarih.Value.Date;
            Database db = new Database();
            db.Sorgu("INSERT INTO Birim Values (@0,@1,@2)", txtAidatMiktari.Text, txtAidatMiktari.Text, mudurlukNo.ToString());






        }
    }
}
