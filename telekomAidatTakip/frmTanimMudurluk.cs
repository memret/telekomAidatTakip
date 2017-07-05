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
            frmTanimMudurluk_Resize(this, null);
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
            listvMdr.Items.Clear();

            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["mudurlukNo"].ToString();
                item.SubItems.Add(data["mudurlukAdi"].ToString());
                item.SubItems.Add(data["ilNo"].ToString());
                item.SubItems.Add(data["ilAdi"].ToString());


                listvMdr.Items.Add(item);
                //oluşturulan item liste eklenir
            }

            txtMdrKod.Enabled = false;
            txtMdrAd.Enabled = false;
            comboBox_il.Enabled = false;
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


        private void listvMdr_SelectedIndexChanged(object sender, EventArgs e)
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
                comboBox_il.Enabled = true;
                btnYeni.Text = "Ekle";
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
            else //butonun ismi Yeni değilse demekki yeni kayıt sayfasındayız
            {

                if (txtMdrKod.Text != string.Empty && txtMdrAd.Text != string.Empty) //yeni kayıt eklemek için bu iki verinin boş olmaması gerekiyor
                {
                    Database db = new Database();
                    int ilNo = ((KeyValuePair<int, string>)comboBox_il.SelectedItem).Key;
                    db.Sorgu("insert into Mudurluk values (@0,@1,@2)", txtMdrKod.Text, txtMdrAd.Text, ilNo.ToString());

                    txtMdrKod.Enabled = false;
                    txtMdrAd.Enabled = false;
                    btnYeni.Text = "Yeni";
                    kayitliMdrDoldur();
                    txtMdrAd.Text = string.Empty;
                    txtMdrKod.Text = string.Empty;
                    btnYeni.Focus(); //görsel amaçlı
                }
                else
                {
                    MessageBox.Show("Müdürlük kodu veya müdürlük adı kısmı boş!");
                }

            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMdrKod.Text != string.Empty && txtMdrAd.Text != string.Empty) // yine boş verilerle bir yeri update edemeyiz
            {
                Database db = new Database();
                int ilNo = ((KeyValuePair<int, string>)comboBox_il.SelectedItem).Key;
                db.Sorgu("update Mudurluk set mudurlukAdi=@0, ilNo=@1 where mudurlukNo=@2", txtMdrAd.Text, ilNo.ToString(), txtMdrKod.Text);

                txtMdrAd.Text = string.Empty;
                txtMdrKod.Text = string.Empty;
                txtMdrAd.Enabled = false;
                txtMdrKod.Enabled = false;
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
                listvMdr.Items.Clear();
                kayitliMdrDoldur();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (btnSil.Enabled)
            {
                DialogResult dialogResult = MessageBox.Show("Seçili müdürlük ve altında kayıtlı birimler silinecek. Emin misiniz?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (txtMdrKod.Text != string.Empty)
                    {
                        Database db = new Database();
                        db.Sorgu("DELETE FROM Mudurluk Where mudurlukNo = @0", txtMdrKod.Text);
                        listvMdr.Items.Clear();
                        kayitliMdrDoldur();
                    }
                }

                else if (dialogResult == DialogResult.Cancel)
                    return;
            }
        }

        private void listvMdr_MouseDoubleClick(object sender, MouseEventArgs e)
        {

             Database db = new Database();
             String mudurlukno = listvMdr.SelectedItems[0].SubItems[0].Text;
             String ilKodu = listvMdr.SelectedItems[0].SubItems[2].Text;
             var data = db.DataOku("SELECT i.ilAdi,m.mudurlukNo,m.mudurlukAdi " +
                   "FROM Mudurluk m, il i WHERE m.ilNo = i.ilNo AND m.mudurlukno = @0 AND i.ilNo =@1", mudurlukno, ilKodu);

             if (data.Read())
             {

                 txtMdrKod.Text = data["mudurlukNo"].ToString();
                 txtMdrAd.Text = data["mudurlukAdi"].ToString();
                 comboBox_il.Text = data["ilAdi"].ToString();
  
             }

            // txtMdrKod.Text = mdrKod;
             btnKaydet.Enabled = true;
             btnSil.Enabled = true;
             txtMdrAd.Enabled = true;
             txtMdrKod.Enabled = false;
             comboBox_il.Enabled = true;
             btnYeni.Text = "Yeni";
             
        }

        private void frmTanimMudurluk_Resize(object sender, EventArgs e)
        {
            groupBox2.Width = this.Width - 46;
            groupBox2.Height = this.Height - 273;
        }

        private void listvMdr_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
