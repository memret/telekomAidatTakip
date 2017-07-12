using MetroFramework;
using MetroFramework.Drawing;
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
    public partial class frmTanimBirim : MetroFramework.Forms.MetroForm
    {
        public frmTanimBirim()
        {
            InitializeComponent();
        }


        private void frmTanimBirim_Load(object sender, EventArgs e)
        {
            try
            {
                //listBirim.Font = new MetroFramework.Fonts.FontResolver;
                frmTanimBirim_Resize(this, null);
                listeDoldur();
                Dictionary<int, string> cboxSource = new Dictionary<int, string>();
                Database db = new Database();
                var data = db.DataOku("SELECT mudurlukNo,mudurlukAdi FROM mudurluk");

                while (data.Read())
                {
                    cboxSource.Add(Convert.ToInt32(data["mudurlukNo"]), data["mudurlukAdi"].ToString());
                }
                cBoxMudurluk.DataSource = new BindingSource(cboxSource, null);
                cBoxMudurluk.DisplayMember = "Value";
                cBoxMudurluk.ValueMember = "Key";
                db.Kapat();
                cBoxMudurluk.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        bool yeniKayit = true;
        private void btnYeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (yeniKayit)
                {
                    if (btnKaydet.Enabled) // yeni butonuna basıldığı sırada bir kayıt düzenleniyor ise bunu tespit edip, kayıt için soruyor
                    {
                        DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "", MessageBoxButtons.YesNoCancel);
                        if (dialogResult == DialogResult.Yes)
                            btnKaydet_Click(this, null);
                        else if (dialogResult == DialogResult.Cancel)
                            return;
                    }
                    yeniKayit = false;
                    //btnYeni.Image = telekomAidatTakip.Properties.Resources.if_check_101940;
                    txtBirimAdi.Enabled = true;
                    txtBirimKodu.Enabled = true;
                    cBoxMudurluk.Enabled = true;
                    txtBirimAdi.Clear();
                    txtBirimKodu.Clear();
                    cBoxMudurluk.SelectedIndex = -1;
                    toolTip1.SetToolTip(btnYeni, "Ekle");
                }

                else
                    if (txtBirimAdi.Text != string.Empty && txtBirimKodu.Text != string.Empty)
                {
                    int mudurlukNo = ((KeyValuePair<int, string>)cBoxMudurluk.SelectedItem).Key;
                    Database db = new Database();
                    db.Sorgu("INSERT INTO Birim Values (@0,@1,@2)", txtBirimKodu.Text, txtBirimAdi.Text, mudurlukNo.ToString());
                    listBirim.Items.Clear();
                    listeDoldur();
                    db.Kapat();
                    //btnYeni.Image = telekomAidatTakip.Properties.Resources.if_save_101946;


                    txtBirimAdi.Enabled = false;
                    cBoxMudurluk.Enabled = false;
                    yeniKayit = true;
                    toolTip1.SetToolTip(btnYeni, "Yeni Kayıt");
                }
                else
                {
                    MessageBox.Show("Bİrim adı veya Birim Kodu eksik.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listvil_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            try
            {
                string birimKodu = listBirim.SelectedItems[0].Text; //listvilde seçili olan satırlardan ilkini alıp, bunun ilk sütunundaki veriyi çekiyor

                Database db = new Database();
                //iladi nı veritabanından çekiyoruz ki güncel olsun. listvil den alabilirdik direk fakat böyle daha güvenli (tabi biraz daha yavaş fakat localde önemsenmeyecek kadar az)
                var data = db.DataOku("select birimNo,birimAdi,mudurlukAdi from birim b, Mudurluk m where b.mudurlukNo = m.mudurlukNo AND birimNo = @0", birimKodu);

                while (data.Read())
                {
                    txtBirimKodu.Text = data["birimNo"].ToString();
                    txtBirimAdi.Text = data["birimAdi"].ToString();
                    cBoxMudurluk.Text = data["mudurlukAdi"].ToString();

                    txtBirimAdi.Enabled = true;
                    cBoxMudurluk.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listeDoldur()
        {
            listBirim.Items.Clear();
            Database db = new Database();
            var data = db.DataOku("SELECT b.birimAdi,b.birimNo,b.mudurlukNo,m.mudurlukAdi " +
                 "FROM Mudurluk m, Birim b WHERE m.mudurlukNo = b.mudurlukNo");
            listBirim.BeginUpdate();
            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["birimNo"].ToString();
                item.SubItems.Add(data["birimAdi"].ToString());
                item.SubItems.Add(data["mudurlukNo"].ToString());
                item.SubItems.Add(data["mudurlukAdi"].ToString());

                listBirim.Items.Add(item);
            }
            db.Kapat();
            listBirim.EndUpdate();

            //;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBirimKodu.Text != string.Empty)
                {
                    Database db2 = new Database();
                    string countKisi = "0";
                    var data2 = db2.DataOku("SELECT COUNT (sicilNo) 'count' FROM Uyeler WHERE birimNo = @0", txtBirimKodu.Text);
                    if (data2.Read())
                    {
                        countKisi = data2["count"].ToString();
                    }

                    Database db3 = new Database();
                    string countAidat = "0";
                    var data3 = db3.DataOku("SELECT COUNT (aidatLogNo) 'count' FROM Uyeler u JOIN AidatLog a on u.sicilNo=a.sicilNo WHERE u.birimNo = @0", txtBirimKodu.Text);
                    if (data3.Read())
                    {
                        countAidat = data3["count"].ToString();
                    }
                    // 0dan büyüklerse bu soruyu sormak lazım.
                    DialogResult dialogResult;
                    if (countAidat != "0" && countKisi != "0")
                        dialogResult = MessageBox.Show("Bu işlem ile sadece birimi değil, ona kayıtlı olan kişileri ve aidat kayıtlarınıda sileceksiniz. \nSilinecek kişi sayısı: " + countKisi + "\nSilinecek aidat kaydı: " + countAidat + " \nEmin misiniz?", "Birim Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    else
                        dialogResult = MessageBox.Show("Seçili birim silinecek. Emin misiniz?", "Birim Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        Database db = new Database();
                        db.Sorgu("DELETE FROM Birim Where birimNo = @0", txtBirimKodu.Text);
                        listBirim.Items.Clear();
                        listeDoldur();
                        db.Kapat();
                        MessageBox.Show("Seçili birim silindi!", "Birim Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBirimAdi.Text = string.Empty;
                        txtBirimKodu.Text = string.Empty;

                        txtBirimAdi.Enabled = false;
                        cBoxMudurluk.Enabled = false;
                    }
                }
                else
                    MessageBox.Show("Birim no kısmı boş");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                int mudurlukNo = ((KeyValuePair<int, string>)cBoxMudurluk.SelectedItem).Key;
                db.Sorgu("UPDATE Birim Set birimAdi = @0, mudurlukNo=@1 WHERE birimNo=@2", txtBirimAdi.Text, mudurlukNo.ToString(), txtBirimKodu.Text);
                listBirim.Items.Clear();
                listeDoldur();
                db.Kapat();

                btnKaydet.Enabled = false;
                //btnKaydet.UseCustomBackColor = true;
                btnSil.Enabled = false;
                //btnSil.UseCustomBackColor = true;
                txtBirimAdi.Text = string.Empty;
                txtBirimKodu.Text = string.Empty;


                txtBirimAdi.Enabled = false;
                cBoxMudurluk.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmTanimBirim_Resize(object sender, EventArgs e)
        {
            try
            {
                //groupBox2.Width = this.Width - 44;
                // groupBox2.Height = this.Height - 288;
                listBirim.Size = new Size(listBirim.Size.Width, this.Size.Height - 258);
                // pictureBox1.Location = new Point(this.Width - 70, pictureBox1.Location.Y );

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listvil_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                btnKaydet.Enabled = true;
                btnSil.Enabled = true;
                //btnKaydet.UseCustomBackColor = false;
                //btnSil.UseCustomBackColor = false;
                txtBirimAdi.Enabled = true;
                cBoxMudurluk.Enabled = true;
                txtBirimKodu.Enabled = false;
                yeniKayit = true;
                toolTip1.SetToolTip(btnYeni, "Yeni Kayıt");
                Database db = new Database();
                String mudurlukAdi = listBirim.SelectedItems[0].SubItems[3].Text;
                String birimKodu = listBirim.SelectedItems[0].SubItems[0].Text;
                var data = db.DataOku("SELECT b.birimAdi,b.birimNo,m.mudurlukAdi " +
                      "FROM Mudurluk m, Birim b WHERE m.mudurlukNo = b.mudurlukNo AND m.mudurlukAdi = @0 AND b.birimNo =@1", mudurlukAdi, birimKodu);

                if (data.Read())
                {

                    txtBirimAdi.Text = data["birimAdi"].ToString();
                    txtBirimKodu.Text = data["birimNo"].ToString();
                    cBoxMudurluk.Text = data["mudurlukAdi"].ToString();
                }
                db.Kapat();


                /*  String birimKodu = listvil.SelectedItems[0].SubItems[0].Text;
                  String birimAdi = listvil.SelectedItems[0].SubItems[1].Text;
                  txtBirimKodu.Text = birimKodu;
                  txtBirimAdi.Text = birimAdi;
                  cBoxMudurluk.Text = listvil.SelectedItems[0].SubItems[3].Text;*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }


}