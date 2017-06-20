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
    public partial class frmTanimMudurluk : Form
    {
        public frmTanimMudurluk()
        {
            InitializeComponent();
        }

        private void frmTanimMudurluk_Load(object sender, EventArgs e)
        {
            kayitliMdrDoldur();
            cBoxIlDoldur();
        }

        private void kayitliMdrDoldur()
        {
            Database db = new Database();
            //data objesi sqlreadera dönüşüp veriyi alır. 
            //direk sqldatareaderda yazılabilir fakat bu sefer forum içerisinde using bilmemne yazmamız gerekir
            //var kelimesi ile tanımlanan değişkene ilk olarak ne eşitlersek o değişken tipinde olur
            var data = db.DataOku("SELECT i.ilAdi, i.ilNo, m.mudurlukNo, m.mudurlukAdi " +
                 "FROM Mudurluk m, il i WHERE i.ilNo = m.ilNo");

            //listview içeriğini boşaltmamız gerekiyor il önce
            listvil.Items.Clear(); //listvil --> "kayıtlı müdürlükler" :D

            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["mudurlukAdi"].ToString();
                item.SubItems.Add(data["mudurlukNo"].ToString());
                item.SubItems.Add(data["ilAdi"].ToString());
                item.SubItems.Add(data["ilNo"].ToString());


                listvil.Items.Add(item);
                //oluşturulan item liste eklenir
            }

            txtMdrKod.Enabled = false;
            txtMdrAd.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = false;
            btnYeni.Enabled = true;

        }
        private void cBoxIlDoldur()
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db2 = new Database();
            var data = db2.DataOku("SELECT ilNo,ilAdi FROM il");

            while (data.Read())
            {
                cboxSource.Add(Convert.ToInt32(data["ilNo"]), data["ilAdi"].ToString());
            }

            comboBox_il.DataSource = new BindingSource(cboxSource, null);
            comboBox_il.DisplayMember = "Value";
            comboBox_il.ValueMember = "Key";
        }


        private void listvil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMdrAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMdrKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_il_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            // butonun ismine göre yeni kaydın veritabanına ekleneceğini mi yoksa ekleme sayfasına mı geçileceğini mi tespit ediyoruz

            if (btnYeni.Text == "Yeni") // butonun ismi "Yeni" ise ekleme sayfası oluşturulmalı
            {
                if (btnKaydet.Enabled) // yeni butonuna basıldığı sırada bir kayıt düzenleniyor ise bunu tespit edip, kayıt için soruyor
                {
                    DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                        btnKaydet_Click(this, null);
                    else if (dialogResult == DialogResult.Cancel)
                        return;
                }

                txtMdrKod.Text = string.Empty;
                txtMdrAd.Text = string.Empty;
                txtMdrKod.Enabled = true;
                txtMdrAd.Enabled = true;
                btnYeni.Text = "Ekle";
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
            else //butonun ismi Yeni değilse demekki yeni kayıt sayfasındayız
            {
                /*
                if (txtMdrKod.Text != string.Empty && txtMdrAd.Text != string.Empty) //yeni kayıt eklemek için bu iki verinin boş olmaması gerekiyor
                {
                    Database db = new Database();
                    int ilAdi = ((KeyValuePair<int, string>)cBoxMudurluk.SelectedItem).Key;
                    db.Sorgu("insert into Mudurluk (mudurlukNo,mudurlukAdi) values (@0,@1)", txtMdrKod.Text, txtMdrAd.Text);

                    txtPlakaKodu.Enabled = false;
                    txtAdi.Enabled = false;
                    btnYeni.Text = "Yeni";
                    IlListesiniDoldur();
                    txtAdi.Text = string.Empty;
                    txtPlakaKodu.Text = string.Empty;
                    btnYeni.Focus(); //görsel amaçlı
                }
                else
                {
                    MessageBox.Show("Plaka kodu veya il adı kısmı boş!");
                }
                */
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        
    }
}
