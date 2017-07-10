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
    public partial class frmTanimTahsil : MetroFramework.Forms.MetroForm
    {
        public frmTanimTahsil()
        {
            InitializeComponent();
        }

        private void frmTanimTahsil_Load(object sender, EventArgs e)
        {
            TahsilListesiDoldur();
        }

        private void TahsilListesiDoldur()
        {
            Database db = new Database();
            //data objesi sqlreadera dönüşüp veriyi alır. 
            //direk sqldatareaderda yazılabilir fakat bu sefer forum içerisinde using bilmemne yazmamız gerekir
            //var kelimesi ile tanımlanan değişkene ilk olarak ne eşitlersek o değişken tipinde olur
            var data = db.DataOku("select * from Tahsil");

            //listview içeriğini boşaltmamız gerekiyor il önce
            listvTanimTahsil.Items.Clear();

            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["tahsilNo"].ToString();
                item.SubItems.Add(data["tahsilAdi"].ToString());

                listvTanimTahsil.Items.Add(item);
                //oluşturulan item liste eklenir
            }

            txtTahsilAd.Enabled = false;
            txtTahsilKodu.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = false;
            btnYeni.Enabled = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tahsilNo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtTahsilKodu.Text != string.Empty && txtTahsilAd.Text != string.Empty) // yine boş verilerle bir yeri update edemeyiz
            {
                Database db = new Database();
                db.Sorgu("update Tahsil set tahsilAdi=@0 where tahsilNo=@1", txtTahsilAd.Text, txtTahsilKodu.Text);

                txtTahsilAd.Text = string.Empty;
                txtTahsilKodu.Text = string.Empty;
                txtTahsilAd.Enabled = false;
                txtTahsilAd.Enabled = false;
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
                TahsilListesiDoldur();
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtTahsilKodu.Text != string.Empty) //plaka kodu olmadan veri silmek tabiki biraz zor olur
            {
                Database db = new Database();
                db.Sorgu("delete from Tahsil where tahsilNo=@0", txtTahsilKodu.Text);
                TahsilListesiDoldur();
            }
        }

        private void listvTanimTahsil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void frmTanimTahsil_FormClosing(object sender, FormClosingEventArgs e)
        {
            //burda form penceresi kapatılırken çalışacak kodlar bulunuyor
            if (btnYeni.Text == "Ekle" || btnKaydet.Enabled) //btnYeni nin ismi Ekle ise veya btnKaydet aktif ise bir düzenleme veya kayıt yapılıyor demektir.
            {
                DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    if (btnYeni.Text == "Ekle")
                        btnYeni_Click(this, null); //btnYeni_Click fonksiyonunu çağırdık
                    else
                        btnKaydet_Click(this, null); //btnYeni_Click fonksiyonunu çağırdık
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true; //bu işlem ile formun kapanma işlemi iptal ediliyor
                }
            }

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

                txtTahsilKodu.Text = string.Empty;
                txtTahsilAd.Text = string.Empty;
                txtTahsilKodu.Enabled = true;
                txtTahsilAd.Enabled = true;
                btnYeni.Text = "Ekle";
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
            else //butonun ismi Yeni değilse demekki yeni kayıt sayfasındayız
            {
                if (txtTahsilAd.Text != string.Empty && txtTahsilKodu.Text != string.Empty) //yeni kayıt eklemek için bu iki verinin boş olmaması gerekiyor
                {
                    Database db = new Database();
                    db.Sorgu("insert into Tahsil (tahsilAdi,tahsilNo) values (@0,@1)", txtTahsilAd.Text, txtTahsilKodu.Text);

                    txtTahsilAd.Enabled = false;
                    txtTahsilKodu.Enabled = false;
                    btnYeni.Text = "Yeni";
                    TahsilListesiDoldur();
                    txtTahsilAd.Text = string.Empty;
                    txtTahsilKodu.Text = string.Empty;
                    btnYeni.Focus(); //görsel amaçlı
                }
                else
                {
                    MessageBox.Show("Tahsil kodu veya adı kısmı boş!");
                }

            }
        }

        private void frmTanimTahsil_Resize(object sender, EventArgs e)
        {
            kayıtTahsil.Width = this.Width - 80;
            kayıtTahsil.Height = this.Height - 241;
            listvTanimTahsil.Size = new Size(listvTanimTahsil.Size.Width, this.Size.Height - 258);
            pictureBox1.Location = new Point(this.Width - 70, pictureBox1.Location.Y);
        }

        private void listvTanimTahsil_DoubleClick_1(object sender, EventArgs e)
        {
            string plakakodu = listvTanimTahsil.SelectedItems[0].Text; //listvilde seçili olan satırlardan ilkini alıp, bunun ilk sütunundaki veriyi çekiyor

            Database db = new Database();
            //iladi nı veritabanından çekiyoruz ki güncel olsun. listvil den alabilirdik direk fakat böyle daha güvenli (tabi biraz daha yavaş fakat localde önemsenmeyecek kadar az)
            txtTahsilAd.Text = db.DataOkuTek("select tahsilAdi from Tahsil where tahsilNo=@0", "tahsilAdi", plakakodu);

            txtTahsilKodu.Text = plakakodu;
            btnKaydet.Enabled = true;
            btnSil.Enabled = true;
            txtTahsilAd.Enabled = true;
            txtTahsilKodu.Enabled = true;
            btnYeni.Text = "Yeni";
        }

        private void listvTanimTahsil_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
