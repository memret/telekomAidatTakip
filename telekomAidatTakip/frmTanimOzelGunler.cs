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
    public partial class frmTanimOzelGunler : MetroFramework.Forms.MetroForm
    {
        public frmTanimOzelGunler()
        {
            InitializeComponent();
        }

        private void frmTanimOzelGunler_Load(object sender, EventArgs e)
        {
            tabloDoldur();
        }
        private void sayfayıtemizle()
        {
            txtBaslik.Clear();
            txtGunNo.Clear();
            txtMsj.Clear();
            txtYorum.Clear();
            dateTimeTarih.Value = DateTime.Today;
        }
        private void tabloDoldur()
        {
            Database db = new Database();
            var data = db.DataOku("SELECT * FROM OzelGunler");

            listView1.Items.Clear();

            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["ozelGunNo"].ToString();
                item.SubItems.Add(data["baslik"].ToString());
                item.SubItems.Add(Convert.ToDateTime(data["tarih"]).ToShortDateString());
                item.SubItems.Add(data["mesaj"].ToString());
                item.SubItems.Add(data["yorum"].ToString());
               
                listView1.Items.Add(item);
                //oluşturulan item liste eklenir
            }

            txtBaslik.Enabled = false;
            dateTimeTarih.Enabled = false;
            txtMsj.Enabled = false;
            txtYorum.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = false;
            btnYeni.Enabled = true;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
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

                txtBaslik.Text = string.Empty;
                txtMsj.Text = string.Empty;
                txtYorum.Text = string.Empty;
                txtGunNo.Text = string.Empty;
                txtBaslik.Enabled = true;
                dateTimeTarih.Enabled = true;
                txtMsj.Enabled = true;
                txtYorum.Enabled = true;

                btnAdi.Enabled = true;
                btnSicilNo.Enabled = true;
                btnSehir.Enabled = true;
                btnMudurluk.Enabled = true;
                btnBirim.Enabled = true;
                
                btnYeni.Text = "Ekle";
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
            else //butonun ismi Yeni değilse demekki yeni kayıt sayfasındayız
            {

                if (txtBaslik.Text != string.Empty && txtMsj.Text != string.Empty) //yeni kayıt eklemek için bu iki verinin boş olmaması gerekiyor
                {
                    //DateTime dt = this.dateTimeTarih.Value.Date;
                    Database db = new Database();
                    
                    //System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@3", dt);
                    db.Sorgu("insert into OzelGunler(baslik,mesaj,yorum,tarih) values (@0,@1,@2,@3)", txtBaslik.Text, txtMsj.Text, txtYorum.Text, this.dateTimeTarih.Value.Date);

                    txtBaslik.Enabled = false;
                    txtMsj.Enabled = false;
                    txtYorum.Enabled = false;
                    dateTimeTarih.Enabled = false;
                    btnYeni.Text = "Yeni";
                    tabloDoldur();
                    sayfayıtemizle();
                    MessageBox.Show("Yeni özel gün kaydedildi.", "Özel Gün Tanımlama", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    btnYeni.Focus(); //görsel amaçlı imiş
                }
                else
                {
                    MessageBox.Show("Başlık veya mesaj boş!");
                }

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtBaslik.Text != string.Empty && txtMsj.Text != string.Empty)
            {
                //DateTime dt = this.dateTimeTarih.Value.Date;
                Database db = new Database();
               // System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@3", dt);
                db.Sorgu("update OzelGunler set baslik=@0, mesaj=@1, yorum=@2, tarih=@3 where ozelGunNo=@4", txtBaslik.Text, txtMsj.Text, txtYorum.Text, this.dateTimeTarih.Value.Date, txtGunNo.Text);

                sayfayıtemizle();
                dateTimeTarih.Enabled = false;
                txtBaslik.Enabled = false;
                txtMsj.Enabled = false;
                txtYorum.Enabled = false;

                btnSil.Enabled = false;
                listView1.Items.Clear();
                MessageBox.Show("Özel gün güncellendi.", "Özel Gün Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tabloDoldur();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtGunNo.Text != string.Empty)
                 {   DialogResult dialogresult = MessageBox.Show("Seçili özel gün silinecek. Emin misiniz?", "Silme", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                     if (dialogresult == DialogResult.Yes)               
                    {

                        Database db = new Database();
                        db.Sorgu("DELETE FROM OzelGunler Where ozelGunNo = @0", txtGunNo.Text);
                        listView1.Items.Clear();
                        tabloDoldur();
                        sayfayıtemizle();
                        MessageBox.Show("Özel gün silindi!", "Özel Gün Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                     else if (dialogresult == DialogResult.Cancel)
                           return;
                }
          
        }
      

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Database db = new Database();
            String gunNo = listView1.SelectedItems[0].SubItems[0].Text;

            var data = db.DataOku("SELECT * FROM OzelGunler gun where gun.ozelGunNo =@0 ", gunNo);

            if (data.Read())
            {
                txtGunNo.Text = data["ozelGunNo"].ToString();
                txtBaslik.Text = data["baslik"].ToString();
                dateTimeTarih.Text = data["tarih"].ToString();
                txtMsj.Text = data["mesaj"].ToString();
                txtYorum.Text = data["yorum"].ToString();
            }

            btnKaydet.Enabled = true;
            btnSil.Enabled = true;
            txtGunNo.Enabled = false;
            txtBaslik.Enabled = true;
            txtMsj.Enabled = true;
            txtYorum.Enabled = true;
            dateTimeTarih.Enabled = true;


            btnAdi.Enabled = true;
            btnSicilNo.Enabled = true;
            btnSehir.Enabled = true;
            btnMudurluk.Enabled = true;
            btnBirim.Enabled = true;

            btnYeni.Text = "Yeni";

        }

        private void frmTanimOzelGunler_Resize(object sender, EventArgs e)
        {
           
            //gboxTabloGosterimi.Height = this.Height - 390;
           
          //  gboxTabloGosterimi.Width = this.Width - 60;
           // listView1.Width = this.Width - 77;
           // listView1.Height = this.Height - 419;
        }

        private void btnAdi_Click(object sender, EventArgs e)
        {
            txtMsj.Text += " %adsoyad% ";
        }

        private void btnSicilNo_Click(object sender, EventArgs e)
        {
            txtMsj.Text += " %sicilno% ";
        }

        private void btnSehir_Click(object sender, EventArgs e)
        {
            txtMsj.Text += " %sehir% ";
        }

        private void btnMudurluk_Click(object sender, EventArgs e)
        {
            txtMsj.Text += " %mudurluk% ";
        }

        private void btnBirim_Click(object sender, EventArgs e)
        {
            txtMsj.Text += " %birim% ";
        }
    }
}
