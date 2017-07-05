using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telekomAidatTakip
{
    public partial class frmRaporAidat : Form
    {
        public frmRaporAidat()
        {
            InitializeComponent();
        }

        private void frmRaporAidat_Load(object sender, EventArgs e)
        {
            PRG.DoldurIl(ref cboxil);
            cboxil.SelectedIndex = -1;
            cboxMudurluk.SelectedIndex = -1;
            cboxBirim.SelectedIndex = -1;
            cboxMudurluk.Enabled = false;
            cboxBirim.Enabled = false;
        }

               
        private void cboxil_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
        //veri yüklenince seçili gelmese iyi olur

        private void cboxMudurluk_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //tarih ve ödenmeyenleri listele kısımları kullanılmıyor şimdilik
            Database db = new Database();
            string query = "select u.sicilNo, u.adSoyad, (select aidat from AidatMiktar where birimno = u.birimNo) 'Miktar', (select SUM(miktar) from aidatlog where sicilno = u.sicilno) 'toplammiktar', i.ilAdi, m.mudurlukAdi, b.birimAdi from uyeler u join il i on i.ilNo = u.ilNo join Mudurluk m on m.mudurlukNo = u.mudurlukNo join birim b on b.birimNo = u.birimNo ";
            List<SqlParameter> paramList = new List<SqlParameter>();
            if (checkBirim.Checked || checkMudurluk.Checked || checkIl.Checked)
            {
                string ekquery = " where ";
                
                SqlParameter paramTemp;
                if (checkIl.Checked)
                {
                    if (cboxil.SelectedIndex == -1)
                    {
                        MessageBox.Show("İl seçin yada yanındaki ticki kaldırın.");
                        return;
                    }
                    ekquery += "i.ilno = @il and ";
                    String ilNo = ((KeyValuePair<int, string>)cboxil.SelectedItem).Key.ToString();
                    paramTemp = new SqlParameter("@il", ilNo);
                    paramList.Add(paramTemp);
                }
                if (checkMudurluk.Checked)
                {
                    if (cboxMudurluk.SelectedIndex == -1)
                    {
                        MessageBox.Show("Müdürlük seçin yada yanındaki ticki kaldırın.");
                        return;
                    }
                    ekquery += "m.mudurlukno = @mudurluk and ";
                    String mudurlukno = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key.ToString();
                    paramTemp = new SqlParameter("@mudurluk", mudurlukno);
                    paramList.Add(paramTemp);
                }
                if (checkBirim.Checked)
                {
                    if (cboxBirim.SelectedIndex == -1)
                    {
                        MessageBox.Show("Birim seçin yada yanındaki ticki kaldırın.");
                        return;
                    }
                    ekquery += "b.birimno = @birim and ";
                    String birimno = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key.ToString();
                    paramTemp = new SqlParameter("@birim", birimno);
                    paramList.Add(paramTemp);
                }
                ekquery = ekquery.Trim().Substring(0,ekquery.Length-5);
                query += ekquery;
            }

            var data = db.DataOku(query,paramList);
            listUyeKayitlari.Items.Clear();
            while (data.Read())
            {

                ListViewItem item = new ListViewItem();
                item.Text = data["sicilNo"].ToString();
                item.SubItems.Add(data["adSoyad"].ToString());
                if (data["miktar"].ToString() == string.Empty)
                    item.SubItems.Add("0");
                else
                    item.SubItems.Add(data["miktar"].ToString());

                if (data["toplammiktar"].ToString() == string.Empty)
                    item.SubItems.Add("0");
                else
                    item.SubItems.Add(data["toplammiktar"].ToString());

                item.SubItems.Add(data["ilAdi"].ToString());
                    item.SubItems.Add(data["mudurlukAdi"].ToString());
                    item.SubItems.Add(data["birimAdi"].ToString());

                listUyeKayitlari.Items.Add(item);
            }
            db.Kapat();

            yazdir.list = listUyeKayitlari;
            /*
            yazdir.items = listUyeKayitlari.Items;
            Dictionary<string, int> basliklar = new Dictionary<string, int>();
            basliklar.Add("Sıra No", 60);
            basliklar.Add("Ad Soyad", 120);
            basliklar.Add("Aidat", 80);
            basliklar.Add("İl/Müdürlük/Kısım", 180);
            basliklar.Add("Ünvan", 70);
            basliklar.Add("Tahsil", 70);

            yazdir.basliklar = basliklar;
            */
            yazdir.baslik = "Aidat Listesi";
            btnYazdir.Enabled = true;
        }
        Yazdir yazdir = new Yazdir(1);
        private void grpAramaKriterleri_Enter(object sender, EventArgs e)
        {

        }

        private void cboxil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboxil.SelectedIndex != -1)
            {
                PRG.DoldurMudurluk(ref cboxMudurluk, ((KeyValuePair<int, string>)cboxil.SelectedItem).Key.ToString());
            }
        }

        private void cboxMudurluk_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboxMudurluk.SelectedIndex != -1)
            {
                PRG.DoldurBirim(ref cboxBirim, ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key.ToString());
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            yazdir.printPre.ShowDialog();
        }

        private void listUyeKayitlari_DoubleClick(object sender, EventArgs e)
        {
                if (listUyeKayitlari.SelectedItems.Count > 0)
                {
                    frmUye frm = new frmUye(listUyeKayitlari.SelectedItems[0].Text);
                    frm.ShowDialog();
                }

            
        }
    }



}

