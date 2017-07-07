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
            PRG.DoldurIl(ref cboxil);
            cboxMudurluk.SelectedIndex = -1;
            cboxBirim.SelectedIndex = -1;
            cboxMudurluk.Enabled = false;
            cboxBirim.Enabled = false;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cboxil.SelectedIndex != -1 && cboxBirim.SelectedIndex != -1 && cboxMudurluk.SelectedIndex != -1 && txtAidatMiktari.Text != string.Empty)
            {
                int ilNo = ((KeyValuePair<int, string>)cboxil.SelectedItem).Key;
                int mudurlukNo = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                int birimNo = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
                Database db = new Database();
                Database db2 = new Database();

                var kisiler = db.DataOku("SELECT sicilNo FROM uyeler WHERE birimNo =@0", birimNo.ToString());
                if (!kisiler.HasRows)
                {
                    MessageBox.Show("Birimde kişi yok!");
                }
                else
                {
                    while (kisiler.Read())
                    {
                        String sicilNo = kisiler["sicilNo"].ToString();
                        if (!string.IsNullOrEmpty(sicilNo))
                        {
                            db2.Sorgu("INSERT INTO AidatLog (sicilNo,miktar,tarih) Values (@0, @1,@2)", sicilNo, txtAidatMiktari.Text, this.dateTarih.Value.Date);

                        }
                        else
                        {
                            MessageBox.Show("Birimde birisinin sicilnosuna ulaşılamadı.");
                        }
                    }
                    MessageBox.Show("Aidat Ödemesi yapıldı.");
                }
                db.Kapat();
                db2.Kapat();
            }
            else
                MessageBox.Show("Lütfen boş alanları doldururuz!");


        }
        private void cboxil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboxil.SelectedIndex != -1)
            {

                int ilNo = ((KeyValuePair<int, string>)cboxil.SelectedItem).Key;
                PRG.DoldurMudurluk(ref cboxMudurluk, ilNo.ToString());


                cboxBirim.Enabled = false;
                cboxBirim.SelectedIndex = -1;
            }
            else
            {
                cboxMudurluk.Enabled = false;
                cboxBirim.Enabled = false;
            }
        }

        private void cboxMudurluk_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblKisiSayisi.Text = "Kişi Sayısı: ";
            if (cboxMudurluk.SelectedIndex != -1)
            {
                int mudurlukNo = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                PRG.DoldurBirim(ref cboxBirim, mudurlukNo.ToString());

                cboxBirim.Enabled = true;
                cboxBirim.SelectedIndex = -1;

            }
            else
            {
                cboxBirim.Enabled = false;
            }
        }

        private void cboxBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  Database db = new Database();
            string countkisi = "0";
            if (cboxBirim.SelectedIndex != -1)
            {
                lblKisiSayisi.Text = "";


            int birimNo = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
            var data = db.DataOku("select count (sicilNo) 'count' from Uyeler u join Birim b on u.birimNo=b.birimNo where b.birimNo=@0", birimNo);
            if(data.Read())
            {
                countkisi = data["count"].ToString();
            }
            
            lblKisiSayisi.Text = "Kişi Sayısı: "+ countkisi;
            }
            */
        }

        private void cboxil_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblKisiSayisi.Text = "Kişi Sayısı: ";
        }

        private void cboxBirim_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblKisiSayisi.Text = "Kişi Sayısı: ";
            Database db = new Database();
            string countkisi = "0";
            if (cboxBirim.SelectedIndex != -1)
            {
                lblKisiSayisi.Text = "";


                int birimNo = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
                var data = db.DataOku("select count (sicilNo) 'count' from Uyeler u join Birim b on u.birimNo=b.birimNo where b.birimNo=@0", birimNo);
                if (data.Read())
                {
                    countkisi = data["count"].ToString();
                }

                lblKisiSayisi.Text = "Kişi Sayısı: " + countkisi;
            }
        }
    }
}
