﻿using MetroFramework.Forms;
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
            try { 
            SilinmeListesiniDoldur();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        bool yeniKayit = true;
        private void btnYeni_Click(object sender, EventArgs e)
        {
            try { 
            if (yeniKayit)
            {
                if (btnKaydet.Enabled)
                {
                    DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                        btnKaydet_Click(this, null);
                    else if (dialogResult == DialogResult.Cancel)
                        return;
                }
                yeniKayit = false;
                txtAciklama.Text = string.Empty;
                txtAciklama.Text = string.Empty;
                txtKod.Enabled = true;
                txtAciklama.Enabled = true;
                //btnYeni.Text = "Ekle";
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
                toolTip1.SetToolTip(btnYeni, "Ekle");
            }
            else
            {   //database bağlan, insert textbox1
                if (txtKod.Text != string.Empty && txtAciklama.Text != string.Empty)
                {
                    Database db = new Database();
                    db.Sorgu("insert into SilinmeNedeni (SilinmeNedenNo,SilinmeNedeni) values (@0,@1)", txtKod.Text, txtAciklama.Text);


                    txtKod.Enabled = false;
                    txtAciklama.Enabled = false;
                    //  btnYeni.Text = "Yeni";
                    yeniKayit = true;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnSil_Click(object sender, EventArgs e)
        {
            try { 
            if (txtKod.Text != string.Empty)
            {
                Database db = new Database();
                db.Sorgu("delete from SilinmeNedeni where SilinmeNedenNo=@0", txtKod.Text);
                SilinmeListesiniDoldur();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try { 
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmTanimUyelikIptal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { 
            //burda form penceresi kapatılırken çalışacak kodlar bulunuyor
            if (!yeniKayit || btnKaydet.Enabled) //btnYeni nin ismi Ekle ise veya btnKaydet aktif ise bir düzenleme veya kayıt yapılıyor demektir.
            {
                DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!yeniKayit)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmTanimUyelikIptal_Resize(object sender, EventArgs e)
        {
            //groupBox4.Width = this.Width - 48; //design sekmesindeki boyut farklarını buraya yazdık
            //groupBox4.Height = this.Height - 237;
        }

        private void listvSilinme_DoubleClick(object sender, EventArgs e)
        {
            try { 
            string kod = listvSilinme.SelectedItems[0].Text; //listvilde seçili olan satırlardan ilkini alıp, bunun ilk sütunundaki veriyi çekiyor

            Database db = new Database();
            //iladi nı veritabanından çekiyoruz ki güncel olsun. listvil den alabilirdik direk fakat böyle daha güvenli (tabi biraz daha yavaş fakat localde önemsenmeyecek kadar az)
            txtAciklama.Text = db.DataOkuTek("select silinmeNedeni from SilinmeNedeni where silinmeNedeni=@0", "silinmeNedenNo", kod);

            txtKod.Text = kod;
            btnKaydet.Enabled = true;
            btnSil.Enabled = true;
            txtAciklama.Enabled = true;
            txtKod.Enabled = true;
                // btnYeni.Text = "Yeni";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
