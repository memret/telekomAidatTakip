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
    public partial class frmRaporUye : Form
    {
        public frmRaporUye()
        {
            InitializeComponent();
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
            //kısaltma olarak FROM uyeler u dediğimde hata veriyor ondan uzun uzun yazdım küfür etmeyin
            //tek satırda yazmazsam da hata veriyor ömer buralarda çıldırdı
            string temelSorgu = "SELECT Uyeler.adSoyad, Uyeler.sicilNo,KanGrubu.kanGrubu, il.ilAdi, Mudurluk.mudurlukAdi, Birim.birimAdi, Unvan.unvanAdi, Tahsil.tahsilAdi FROM uyeler,KanGrubu, il, Mudurluk, Birim, Unvan, Tahsil WHERE uyeler.kanGrubuNo = KanGrubu.kanGrubuNo AND uyeler.ilNo = il.ilNo AND uyeler.mudurlukNo = Mudurluk.mudurlukNo AND uyeler.birimNo = Birim.birimNo AND uyeler.unvanNo = Unvan.unvanNo AND uyeler.tahsilNo = Tahsil.tahsilNo AND uyeler.kanGrubuNo = KanGrubu.kanGrubuNo";
            Database db = new Database();

            var data = db.DataOku(temelSorgu);
            listUye.Items.Clear();
            int siraNo = 0;
            
            while (data.Read())
            {
                string ilMudBir = data["ilAdi"].ToString() + "/" + data["mudurlukAdi"].ToString() + "/" + data["birimAdi"].ToString();
                siraNo++;
                ListViewItem item = new ListViewItem();
                item.Text = siraNo.ToString();
                item.SubItems.Add(data["adSoyad"].ToString());
                item.SubItems.Add(data["sicilNo"].ToString());
                item.SubItems.Add(data["kanGrubu"].ToString());
                item.SubItems.Add(ilMudBir);
                item.SubItems.Add(data["unvanAdi"].ToString());
                item.SubItems.Add(data["tahsilAdi"].ToString());

                listUye.Items.Add(item);
            }
        }
    }
}
