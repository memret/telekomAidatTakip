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
    public partial class frmAidatMiktar : Form
    {
        private void cBoxIlDoldur()
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db2 = new Database();
            var data = db2.DataOku("SELECT ilNo,ilAdi FROM il");

            while (data.Read())
            {
                cboxSource.Add(Convert.ToInt32(data["ilNo"]), data["ilAdi"].ToString());
            }

            cboxIl.DataSource = new BindingSource(cboxSource, null);
            cboxIl.DisplayMember = "Value";
            cboxIl.ValueMember = "Key";
            
        }
        private void cbxmudurlukdoldur()
        {
            if (cboxIl.SelectedIndex != -1)
            {
                int ilno = ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
                Dictionary<int, string> cboxSource = new Dictionary<int, string>();
                Database db2 = new Database();
                var data = db2.DataOku("SELECT mudurlukNo,mudurlukAdi FROM Mudurluk WHERE ilNo=@0", ilno.ToString());
                while (data.Read())
                {
                    cboxSource.Add(Convert.ToInt32(data["mudurlukNo"]), data["mudurlukAdi"].ToString());


                }
                cboxMudurluk.DataSource = new BindingSource(cboxSource, null);
                cboxMudurluk.DisplayMember = "Value";
                cboxMudurluk.ValueMember = "Key";
            }
        }

        private void cbxKisimdoldur()
        {
           
            { 
            int mdr = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db2 = new Database();

            var data = db2.DataOku("SELECT birimNo, birimAdi FROM Birim WHERE mudurlukNo=@0", mdr.ToString());
            while (data.Read())
            {
                cboxSource.Add(Convert.ToInt32(data["birimNo"]), data["birimAdi"].ToString());


            }
            cboxKisim.DataSource = new BindingSource(cboxSource, null);
            cboxKisim.DisplayMember = "Value";
            cboxKisim.ValueMember = "Key";
          }
        }

        private void IlListesiniDoldur()
        {




        }
        public frmAidatMiktar()
        {
            InitializeComponent();
        }

        private void frmAidatMiktar_Load(object sender, EventArgs e)
        {
            cBoxIlDoldur();
            cboxIl.SelectedIndex = -1;
           
           

        }


        private void btnKaydet_Click(object sender, EventArgs e)
        { if (cboxIl.SelectedIndex != -1 || cboxKisim.SelectedIndex != -1 || cboxMudurluk.SelectedIndex != -1 || txtAidatMiktari.ToString() != string.Empty)
            {
                Database db = new Database();
                int mdr = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                int ilno = ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
                int birimno = ((KeyValuePair<int, string>)cboxKisim.SelectedItem).Key;
                db.Sorgu("update AidatMiktar set aidat=@0 where ilNo=@1 AND birimNo=@2 AND mudurlukNo=@3", txtAidatMiktari.Text,  ilno.ToString(),birimno.ToString(),mdr.ToString() );
            }
         
        }

        private void cboxMudurluk_SelectedIndexChanged(object sender, EventArgs e)
        {   if (cboxMudurluk.SelectedIndex != -1)
            {
                cbxKisimdoldur();
                cboxKisim.SelectedIndex = -1;
            }
        }


        private void cboxIl_SelectedIndexChanged(object sender, EventArgs e)
        {   if (cboxIl.SelectedIndex != -1)
            {
                cbxmudurlukdoldur();
                cboxMudurluk.SelectedIndex = -1;
            }
        }

        private void cboxKisim_SelectedIndexChanged(object sender, EventArgs e)
        {  if (cboxKisim.SelectedIndex != -1)
          {
                {
                    Dictionary<int, string> cboxSource = new Dictionary<int, string>();
                    Database db2 = new Database();
                    int mdr = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                    int ilno = ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
                    int birimno = ((KeyValuePair<int, string>)cboxKisim.SelectedItem).Key;
                    var data = db2.DataOku("SELECT * FROM AidatMiktar WHERE ilNo=@0 AND mudurlukNo=@1 AND birimNo=@2  ", ilno.ToString(), birimno.ToString(), mdr.ToString());
                    while (data.Read())
                    {

                        txtAidatMiktari.Text = data["aidat"].ToString();

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboxIl.SelectedIndex != -1 || cboxKisim.SelectedIndex != -1 || cboxMudurluk.SelectedIndex != -1 || txtAidatMiktari.ToString() != string.Empty)
            {
                Database db = new Database();
                int mdr = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                int ilno = ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
                int birimno = ((KeyValuePair<int, string>)cboxKisim.SelectedItem).Key;
                db.Sorgu("INSERT INTO AidatMiktar values (@0,@1,@2,@3)", ilno.ToString(), birimno.ToString(), mdr.ToString(), txtAidatMiktari.Text);
                cboxIl.SelectedIndex = -1;
                cboxMudurluk.SelectedIndex = -1;
                cboxKisim.SelectedIndex = -1;
                txtAidatMiktari.Text = string.Empty;
            }
            else
                MessageBox.Show("Lütfen boş alanları doldururuz!");
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            cboxIl.SelectedIndex = -1;
            cboxMudurluk.SelectedIndex = -1;
            cboxKisim.SelectedIndex = -1;
            txtAidatMiktari.Text = string.Empty;
        }
    }
}

    

