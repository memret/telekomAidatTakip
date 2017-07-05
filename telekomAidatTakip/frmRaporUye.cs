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
    public partial class frmRaporUye : Form
    {
        public frmRaporUye()
        {
            InitializeComponent();
        }


        public frmRaporUye(string ilNo)
        {
            InitializeComponent();
            //checkbox tikle
            checkIl.Checked = true;
            cboxII.SelectedItem = PRG.cboxIndexBul(ref cboxII, ilNo);
            btnEkranaListele_Click(this, null);
            //checkboxda il seç
            //ekran listeleye tıklat
        }


        //PRG.DoldurTahsil(ref cboxTahsil);
        //PRG.DoldurUyelikTipi(ref cboxUyelikDurumu);




        private void checkIl_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIl.Checked)
            {
                PRG.DoldurIl(ref cboxII);
                checkMudurluk.Enabled = true;
            }
            else
            {
                checkMudurluk.Enabled = false;
                cboxII.Enabled = false;
                cboxII.SelectedIndex = -1;
                checkMudurluk.Checked = false;
            }

        }

        private void cboxII_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkMudurluk.Checked && checkIl.Checked)
            {
                PRG.DoldurMudurluk(ref cboxMudurluk, ((KeyValuePair<int, string>)cboxII.SelectedItem).Key.ToString());
                cboxMudurluk.Enabled = true;
            }  
            
        }

        private void cboxMudurluk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkKisim.Checked && checkMudurluk.Checked)
            {
                PRG.DoldurBirim(ref cboxKısım, ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key.ToString());
            }
        }

        private void checkMudurluk_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMudurluk.Checked)
            {
                cboxII_SelectedIndexChanged(this, null);
                checkKisim.Enabled = true;
            }
            else
            {
                cboxMudurluk.Enabled = false;
                cboxMudurluk.SelectedIndex = -1;

                checkKisim.Checked = false;
                checkKisim.Enabled = false;
            }
        }


        private void checkKisim_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKisim.Checked)
            {
                cboxMudurluk_SelectedIndexChanged(this, null);
                cboxMudurluk.Enabled = true;
            }
            else
            {
                cboxKısım.SelectedIndex = -1;
                cboxKısım.Enabled = false;
            }
            
        }

        private void checkUnvan_CheckedChanged(object sender, EventArgs e)
        {
            if(checkUnvan.Checked)
            {
                PRG.DoldurUnvan(ref cboxUnvan);
            }

            else
            {
                cboxUnvan.Enabled = false;
                cboxUnvan.SelectedIndex = -1;
            }
        }

        private void checkTahsil_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTahsil.Checked)
            {
                PRG.DoldurTahsil(ref cboxTahsil);
            }

            else
            {
                cboxTahsil.Enabled = false;
                cboxTahsil.SelectedIndex = -1;
            }
        }

        private void checkUyelik_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUyelik.Checked)
            {
                PRG.DoldurUyelikTipi(ref cboxUyelikDurumu);
            }

            else
            {
                cboxUyelikDurumu.Enabled = false;
                cboxUyelikDurumu.SelectedIndex = -1;
            }
        }

        private void checkKanGrubu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKanGrubu.Checked)
            {
                PRG.DoldurKanGrubu(ref cboxKanGrubu);
            }

            else
            {
                cboxKanGrubu.Enabled = false;
                cboxKanGrubu.SelectedIndex = -1;
            }
        }

        private void btnEkranaListele_Click(object sender, EventArgs e)
        {

            //TABLODA VERİ YOKKEN VERİ YOK DİYECEK.

            listUye.Items.Clear();
            //kısaltma olarak FROM uyeler u dediğimde hata veriyor ondan uzun uzun yazdım küfür etmeyin
            //tek satırda yazmazsam da hata veriyor ömer buralarda çıldırdı
            Database db = new Database();
            SqlParameter paramTemp;
            string temelSorgu = "SELECT u.adSoyad, u.sicilNo,kg.kanGrubu, i.ilAdi, m.mudurlukAdi, b.birimAdi, unv.unvanAdi, t.tahsilAdi FROM uyeler u,KanGrubu kg, il i, Mudurluk m, Birim b, Unvan unv, Tahsil t, nufusbilgileri nufus WHERE nufus.sicilno = u.sicilno and nufus.kanGrubuNo = kg.kanGrubuNo AND u.ilNo = i.ilNo AND u.mudurlukNo = m.mudurlukNo AND u.birimNo = b.birimNo AND u.unvanNo = unv.unvanNo AND u.tahsilNo = t.tahsilNo ";
            string ekSorgu = " ";



            List<SqlParameter> paramList = new List<SqlParameter>();
            if (checkIl.Checked)
            {
                String ilNo = ((KeyValuePair<int, string>)cboxII.SelectedItem).Key.ToString();
                ekSorgu += "AND u.ilNo = @il ";
                paramTemp = new SqlParameter("@il", ilNo);
                paramList.Add(paramTemp);
                temelSorgu += ekSorgu;
            }


            if (checkMudurluk.Checked)
            {
                string mudurlukNo = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key.ToString();
                ekSorgu += "AND u.mudurlukNo = @mudurlukNo ";
                paramTemp = new SqlParameter("@mudurlukNo", mudurlukNo);
                paramList.Add(paramTemp);
                temelSorgu += ekSorgu;
            }

            if (checkKisim.Checked)
            {
                string birimNo = ((KeyValuePair<int, string>)cboxKısım.SelectedItem).Key.ToString();
                ekSorgu += "AND u.birimNo = @birimNo ";
                paramTemp = new SqlParameter("@birimNo", birimNo);
                paramList.Add(paramTemp);
                temelSorgu += ekSorgu;
            }

            if (checkUnvan.Checked)
            {
                string unvanNo = ((KeyValuePair<int, string>)cboxUnvan.SelectedItem).Key.ToString();
                ekSorgu += "AND u.unvanNo = @unvanNo ";
                paramTemp = new SqlParameter("@unvanNo", unvanNo);
                paramList.Add(paramTemp);
                temelSorgu += ekSorgu;
            }

            if (checkTahsil.Checked)
            {
                string tahsilNo = ((KeyValuePair<int, string>)cboxTahsil.SelectedItem).Key.ToString();
                ekSorgu += "AND u.tahsilNo = @tahsilNo ";
                paramTemp = new SqlParameter("@tahsilNo", tahsilNo);
                paramList.Add(paramTemp);
                temelSorgu += ekSorgu;
            }

            if (checkUyelik.Checked)
            {
                string uyelikTipiNo = ((KeyValuePair<int, string>)cboxUyelikDurumu.SelectedItem).Key.ToString();
                ekSorgu += "AND u.uyelikTipiNo = @uyelikTipiNo ";
                paramTemp = new SqlParameter("@uyelikTipiNo", uyelikTipiNo);
                paramList.Add(paramTemp);
                temelSorgu += ekSorgu;
            }

            if (checkKanGrubu.Checked)
            {
                string kanGrubuNo = ((KeyValuePair<int, string>)cboxKanGrubu.SelectedItem).Key.ToString();
                ekSorgu += "AND nufus.kanGrubuNo = @kanGrubuNo ";
                paramTemp = new SqlParameter("@kanGrubuNo", kanGrubuNo);
                paramList.Add(paramTemp);
                temelSorgu += ekSorgu;
            }

            if (cSilinmisKayıt.Checked)
            {
                string uyelikTipiNo = 2.ToString();
                ekSorgu += "AND u.aktif = '0'";
                temelSorgu += ekSorgu;
            }

            if (!cSilinmisKayıt.Checked)
            {
                string uyelikTipiNo = 2.ToString();
                ekSorgu += "AND u.aktif = '1'";
                temelSorgu += ekSorgu;
            }



            var data = db.DataOku(temelSorgu, paramList);
            listUye.Items.Clear();

            while (data.Read())
            {
                string ilMudBir = data["ilAdi"].ToString() + "/" + data["mudurlukAdi"].ToString() + "/" + data["birimAdi"].ToString();
                ListViewItem item = new ListViewItem();
                item.Text = data["sicilNo"].ToString();
                item.SubItems.Add(data["adSoyad"].ToString());
                item.SubItems.Add(data["kanGrubu"].ToString());
                item.SubItems.Add(ilMudBir);
                item.SubItems.Add(data["unvanAdi"].ToString());
                item.SubItems.Add(data["tahsilAdi"].ToString());

                listUye.Items.Add(item);
            }
            db.Kapat();


            yazdir.list = listUye;

            /*yazdir.items = listUye.Items;
            Dictionary<string, int> basliklar = new Dictionary<string, int>();
            basliklar.Add("Sicil No",60);
            basliklar.Add("Ad Soyad",120);
            basliklar.Add("Kan Grubu",80);
            basliklar.Add("İl/Müdürlük/Kısım",180);
            basliklar.Add("Ünvan",70);
            basliklar.Add("Tahsil",70);


            yazdir.basliklar = basliklar;
            */
            yazdir.baslik = "Üye Listesi";
            btnYazdir.Enabled = true;
        }

        private void listUye_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listUye.SelectedItems.Count > 0)
            {
                frmUye frm = new frmUye(listUye.SelectedItems[0].Text);
                frm.ShowDialog();
            }
            
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            yazdir.printPre.ShowDialog();
            
        }
       Yazdir yazdir = new Yazdir(1);
        private void frmRaporUye_Load(object sender, EventArgs e)
        {
            
            //this.Controls.Add(yazdir.printPre);

        }
    }
}
