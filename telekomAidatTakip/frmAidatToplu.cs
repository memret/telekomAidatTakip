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
            cboxil.SelectedIndex = -1;
            cboxMudurluk.SelectedIndex = -1;
            cboxBirim.SelectedIndex = -1;
            cboxMudurluk.Enabled = false;
            cboxBirim.Enabled = false;
            //cBoxMudurlukDoldur();
            //cboxMudurluk.Enabled = true;

        }

        //iller cbox doldurma fonksiyonu
        private void cBoxIlDoldur()
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db3 = new Database();
            var data = db3.DataOku("SELECT ilNo,ilAdi FROM il");

            while (data.Read())
            {
                cboxSource.Add(Convert.ToInt32(data["ilNo"]), data["ilAdi"].ToString());
            }
            cboxil.DataSource = new BindingSource(cboxSource, null);
            cboxil.DisplayMember = "Value";
            cboxil.ValueMember = "Key";
        }
        
        // BURALAAAAARRR YALAN AMA DURSUN BELKİ LAZIM OLUR SONRA
        /*
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
       */
  

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int ilNo = ((KeyValuePair<int, string>)cboxil.SelectedItem).Key;
            int mudurlukNo = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
            int birimNo = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
            DateTime dt = this.dateTarih.Value.Date;
            Database db = new Database();
            Database db2 = new Database();
            System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@2", dt);

            var kisiler = db.DataOku("SELECT sicilNo FROM uyeler WHERE birimNo =@0", birimNo.ToString());
                while (kisiler.Read())
                {
                    String sicilNo = kisiler["sicilNo"].ToString();
                    if(!string.IsNullOrEmpty(sicilNo))
                {
                    db2.Sorgu("INSERT INTO AidatLog (sicilNo,miktar,tarih) Values (@0, @1,@2)", param, sicilNo, txtAidatMiktari.Text);
                    MessageBox.Show("Aidat Ödemesi yapıldı.");
                }
                else
                {
                    MessageBox.Show("Sıkıntı");
                }
                }
                
            

            // "ALL (SELECT sicil no FROM uyeler WHERE @0)" mudurlukNo.ToString();

            
        }

        private void cboxil_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboxil.SelectedIndex != -1)
            {
                

                int ilNo = ((KeyValuePair<int, string>) cboxil.SelectedItem).Key;


                Dictionary<int, string> cboxSource = new Dictionary<int, string>();
                Database db2 = new Database();
                var data = db2.DataOku("SELECT mudurlukNo,mudurlukAdi FROM mudurluk WHERE ilNo = @0", ilNo.ToString());

                while (data.Read())
                {
                    cboxSource.Add(Convert.ToInt32(data["mudurlukNo"]), data["mudurlukAdi"].ToString());
                }
                cboxMudurluk.DataSource = new BindingSource(cboxSource, null);
                cboxMudurluk.DisplayMember = "Value";
                cboxMudurluk.ValueMember = "Key";

                cboxMudurluk.Enabled = true;
                cboxMudurluk.SelectedIndex = -1;
                cboxBirim.Enabled = false;
                cboxBirim.SelectedIndex = -1;
            }
            else
            {
                cboxMudurluk.Enabled = false;
                cboxBirim.Enabled = false;
            }
        }

        private void cboxMudurluk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxMudurluk.SelectedIndex != -1)
            {
                int mudurlukNo = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;


                Dictionary<int, string> cboxSource = new Dictionary<int, string>();
                Database db2 = new Database();
                var data = db2.DataOku("SELECT birimNo,birimAdi FROM Birim WHERE mudurlukNo = @0", mudurlukNo.ToString());

                while (data.Read())
                {
                    cboxSource.Add(Convert.ToInt32(data["birimNo"]), data["birimAdi"].ToString());
                }

                cboxBirim.DataSource = new BindingSource(cboxSource, null);
                cboxBirim.DisplayMember = "Value";
                //cboxBirim.ValueMember = "Key";
                cboxBirim.Enabled = true;
                cboxBirim.SelectedIndex = -1;

            }
            else
            {
                cboxBirim.Enabled = false;
            }
        }
    }
}
