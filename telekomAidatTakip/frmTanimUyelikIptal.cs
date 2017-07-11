using MetroFramework.Forms;
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
    public partial class frmTanimUyelikIptal : MetroForm
    {
        public frmTanimUyelikIptal()
        {
            InitializeComponent();
        }

        private void frmTanimUyelikIptal_Load(object sender, EventArgs e)
        {
            SilinmeListesiniDoldur();
        }

        private void SilinmeListesiniDoldur()
        {
            Database db = new Database();
            var data = db.DataOku("select * from SilinmeNedeni");

            listvSilinme.Items.Clear();

            while(data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["silinmeNedenNo"].ToString();
                item.SubItems.Add(data["silinmeNedeni"].ToString());

                listvSilinme.Items.Add(item);
                //oluşturulan item listeye eklendi
            }

            txtAciklama.Enabled = false;
            txtKod.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = false;
            btnYeni.Enabled = true;

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {

            if (btnYeni.Text == "Yeni")
            {
                if (btnKaydet.Enabled)
                {
                    DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                        btnKaydet_Click(this, null);
                    else if (dialogResult == DialogResult.Cancel)
                        return;
                }

                txtKod.Text = string.Empty;
                txtAciklama.Text = string.Empty;
                txtKod.Enabled = true;
                txtAciklama.Enabled = true;
                btnYeni.Text = "Ekle";
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
            else
            {   //database bağlan, insert textbox1
                if (txtKod.Text != string.Empty && txtAciklama.Text != string.Empty)
                {
                    Database db = new Database();
                    db.Sorgu("insert into SilinmeNedeni (SilinmeNedenNo,SilinmeNedeni) values (@0,@1)", txtKod.Text, txtAciklama.Text);


                    txtKod.Enabled = false;
                    txtAciklama.Enabled = false;
                    btnYeni.Text = "Yeni";
                    SilinmeListesiniDoldur();
                    txtKod.Text = string.Empty;
                    txtAciklama.Text = string.Empty;
                    btnYeni.Focus();
                }

                else
                {
                    MessageBox.Show("Silinme kodu veya açıklama kısmı boş!");
                }
            }
        }
        
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtKod.Text != string.Empty)
            {
                Database db = new Database();
                db.Sorgu("delete from SilinmeNedeni where SilinmeNedenNo=@0", txtKod.Text);
                SilinmeListesiniDoldur();
            }
        }

        private void listvSilinme_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string kod = listvSilinme.SelectedItems[0].Text; //listvilde seçili olan satırlardan ilkini alıp, bunun ilk sütunundaki veriyi çekiyor

            Database db = new Database();
            //iladi nı veritabanından çekiyoruz ki güncel olsun. listvil den alabilirdik direk fakat böyle daha güvenli (tabi biraz daha yavaş fakat localde önemsenmeyecek kadar az)
            txtAciklama.Text = db.DataOkuTek("select silinmeNedeni from SilinmeNedeni where silinmeNedeni=@0", "silinmeNedenNo", kod);

            txtKod.Text = kod;
            btnKaydet.Enabled = true;
            btnSil.Enabled = true;
            txtAciklama.Enabled = true;
            txtKod.Enabled = true;
            btnYeni.Text = "Yeni";
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKod.Text != string.Empty && txtAciklama.Text != string.Empty) // yine boş verilerle bir yeri update edemeyiz
            {
                Database db = new Database();
                db.Sorgu("update SilinmeNedeni set silinmeNedeni=@0 where silinmeNedenNo=@1", txtAciklama.Text, txtKod.Text);

                txtAciklama.Text = string.Empty;
                txtKod.Text = string.Empty;
                txtAciklama.Enabled = false;
                txtKod.Enabled = false;
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
                SilinmeListesiniDoldur();
            }
        }

        private void frmTanimUyelikIptal_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmTanimUyelikIptal_Resize(object sender, EventArgs e)
        {
            //groupBox4.Width = this.Width - 48; //design sekmesindeki boyut farklarını buraya yazdık
            //groupBox4.Height = this.Height - 237;
        }

        private void listvSilinme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click_1(object sender, EventArgs e)
        {
            
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click_2(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {

        }

        private void metroTextBoxAciklama_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxKod_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
