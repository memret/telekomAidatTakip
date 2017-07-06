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
    public partial class frmTanimIl : Form
    {
        public frmTanimIl()
        {
            InitializeComponent();
        }

        private void frmTanimil_Load(object sender, EventArgs e)
        {
            frmTanimIl_Resize(this, null);
            IlListesiniDoldur();
            
        }
        private void IlListesiniDoldur()
        {
            Database db = new Database();
            //data objesi sqlreadera dönüşüp veriyi alır. 
            //direk sqldatareaderda yazılabilir fakat bu sefer forum içerisinde using bilmemne yazmamız gerekir
            //var kelimesi ile tanımlanan değişkene ilk olarak ne eşitlersek o değişken tipinde olur
            var data = db.DataOku("select * from il");

            //listview içeriğini boşaltmamız gerekiyor il önce
            listvil.Items.Clear();
            
            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["ilNo"].ToString();
                item.SubItems.Add(data["ilAdi"].ToString());

                listvil.Items.Add(item);
                //oluşturulan item liste eklenir
            }

            txtAdi.Enabled = false;
            txtPlakaKodu.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = false;
            btnYeni.Enabled = true;
            
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
                    else if(dialogResult == DialogResult.Cancel)
                        return;
                }

                txtAdi.Text = string.Empty;
                txtPlakaKodu.Text = string.Empty;
                txtPlakaKodu.Enabled = true;
                txtAdi.Enabled = true;
                btnYeni.Text = "Ekle";
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
            else //butonun ismi Yeni değilse demekki yeni kayıt sayfasındayız
            {
                if (txtPlakaKodu.Text != string.Empty && txtAdi.Text != string.Empty) //yeni kayıt eklemek için bu iki verinin boş olmaması gerekiyor
                {
                    Database db = new Database();
                    db.Sorgu("insert into il (ilno,iladi) values (@0,@1)", txtPlakaKodu.Text, txtAdi.Text);

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
                
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {   
            if (txtPlakaKodu.Text != string.Empty) //plaka kodu olmadan veri silmek tabiki biraz zor olur
            {    
                Database db1 = new Database();
                string countMudurluk="0";
                
                var data = db1.DataOku("select count(mudurlukNo) 'count' from Mudurluk where ilNo=@0",txtPlakaKodu.Text);
                if(data.Read())
                {
                    countMudurluk = data["count"].ToString();
                }
                Database db2 = new Database();
                string countUye = "0";

                var data2 = db2.DataOku("select count(sicilNo) 'count' from Uyeler where ilNo=@0", txtPlakaKodu.Text);
                if (data2.Read())
                {
                    countUye = data2["count"].ToString();
                }
                Database db3 = new Database();
                string countBirim = "0";
                var data3 = db3.DataOku("select count(birimno) 'count' from Birim b join mudurluk m on m.mudurlukno = b.mudurlukno where m.ilno =@0",txtPlakaKodu.Text);
                if (data3.Read())
                {
                    countBirim= data3["count"].ToString();
                }
                Database db4 = new Database();
                string countAidatLog = "0";
                var data4 = db4.DataOku("select count(aidatLogNo) 'count' from AidatLog a join Uyeler u on u.sicilNo = a.sicilNo where u.ilNo =@0", txtPlakaKodu.Text);
                if (data4.Read())
                {
                    countAidatLog = data4["count"].ToString();
                }
                    DialogResult dialogresult = MessageBox.Show(countMudurluk+ " Müdürlük \n"+countBirim+" Birim \n"+countUye+" Üye\n"+countAidatLog+" aidat bilgisi seçili ile ait.\n"+"Seçili il ve alt verileri silinecek. Emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogresult == DialogResult.Yes)
                {
                    Database db = new Database();
                   // Database db5 = new Database();
                  //  Database db6 = new Database();
                   // Database db7 = new Database();
                    
                   // db6.Sorgu("delete from Uyeler where ilNo=@0",txtPlakaKodu.Text);
                  //  db5.Sorgu("delete from Mudurluk where ilNo=@0", txtPlakaKodu.Text);
                    db.Sorgu("delete from il where ilNo=@0", txtPlakaKodu.Text);
                    
                   

                    IlListesiniDoldur();
                    txtAdi.Clear();
                    txtPlakaKodu.Clear();
                    MessageBox.Show("Seçili il silindi!" , "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dialogresult == DialogResult.Cancel)
                    return;
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listvil_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string plakakodu = listvil.SelectedItems[0].Text; //listvilde seçili olan satırlardan ilkini alıp, bunun ilk sütunundaki veriyi çekiyor

            Database db = new Database();
            //iladi nı veritabanından çekiyoruz ki güncel olsun. listvil den alabilirdik direk fakat böyle daha güvenli (tabi biraz daha yavaş fakat localde önemsenmeyecek kadar az)
            txtAdi.Text = db.DataOkuTek("select iladi from il where ilNo=@0", "ilAdi", plakakodu);

            txtPlakaKodu.Text = plakakodu;
            btnKaydet.Enabled = true;
            btnSil.Enabled = true;
            txtAdi.Enabled = true;
            txtPlakaKodu.Enabled = true;
            btnYeni.Text = "Yeni";
            
         
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtPlakaKodu.Text != string.Empty && txtAdi.Text != string.Empty) // yine boş verilerle bir yeri update edemeyiz
            {
                Database db = new Database();
                db.Sorgu("update il set iladi=@0 where ilno=@1", txtAdi.Text, txtPlakaKodu.Text);

                txtAdi.Text = string.Empty;
                txtPlakaKodu.Text = string.Empty;
                txtAdi.Enabled = false;
                txtPlakaKodu.Enabled = false;
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
                IlListesiniDoldur();
            }
        }

        private void frmTanimIl_FormClosing(object sender, FormClosingEventArgs e)
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

        private void listvil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTanimIl_Resize(object sender, EventArgs e)
        {
          groupBox2.Width = this.Width - 49; //design sekmesindeki boyut farklarını buraya yazdık
          groupBox2.Height = this.Height - 252;
        }

        private void txtAdi_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtPlakaKodu_Leave(object sender, EventArgs e)
        {
            if (txtPlakaKodu.Text != string.Empty)
            {
                Database db = new Database();
                var data = db.DataOku("select ilNo from il");
                while (data.Read())
                {
                    String sicilDb = data["ilNo"].ToString();
                    if (sicilDb.Equals(txtPlakaKodu.Text.ToString()))
                    {
                        MessageBox.Show("Bu plaka kodu kayıtlı.");
                        txtPlakaKodu.Clear();
                        txtPlakaKodu.Select();
                    }
                }
            }
        }

        private void txtPlakaKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }
    }
}
