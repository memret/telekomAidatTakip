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
    public partial class frmUye : Form
    {
        public frmUye() // yeni kayıt eklenirken
        {
            InitializeComponent();
        }
        public frmUye(string sicilno) //raporuye den çağırılınca
        {
            InitializeComponent();
        }



        private void frmUye_Load(object sender, EventArgs e)
        {
            // DoldurKomple();
            DoldurKomple("1");
        }
        private void DoldurKomple()
        {
            PRG.DoldurTahsil(ref cboxTahsil);
            PRG.DoldurUnvan(ref cboxUnvan);
            PRG.DoldurIl(ref cboxIl);
            PRG.DoldurIl(ref cboxEvIl);
            PRG.DoldurIl(ref cboxIsIl);
            
            PRG.DoldurUyelikTipi(ref cboxUyelikTipi);
            PRG.DoldurKanGrubu(ref cboxNufusKan);
            PRG.DoldurIl(ref cboxNufusIl);



        }
        private void DoldurKomple(string sicilno)
        {
            DoldurKomple();
            DoldurTemelBilgiler(sicilno);
            
            DoldurAdresBilgiler(sicilno);
            DoldurNufusBilgileri(sicilno); //test edilmedi
        }
        private void DoldurNufusBilgileri(string sicilno)
        {
            Database db = new Database();
            var data = db.DataOku("select * from nufusbilgileri where sicilno=@0",sicilno);

            if (data.Read())
            {
                txtNufusBaba.Text = data["baba"].ToString();
                txtNufusAnne.Text = data["anne"].ToString();
                txtNufusDogumYeri.Text = data["dogumyeri"].ToString();
                dateNufusDogum.Value = Convert.ToDateTime(data["dogumTarihi"]);
                //cboxNufusMedeni.SelectedIndex = Convert.ToInt32(data["medeniHal"]);
                cboxNufusKan.SelectedItem = PRG.cboxIndexBul(ref cboxNufusKan, data["kangrubuno"]);
                cboxNufusIl.SelectedItem = PRG.cboxIndexBul(ref cboxNufusIl,data["ilno"]);
                txtNufusIlce.Text = data["ilce"].ToString();
                txtNufusMahalle.Text = data["mahalle"].ToString();
                txtNufusSira.Text = data["sirano"].ToString();
                txtNufusCilt.Text = data["ailesirano"].ToString();
                txtNufusAile.Text = data["ciltno"].ToString();
            }

        }
        private void DoldurAdresBilgiler(string sicilno)
        {
            Database db = new Database();
            var data = db.DataOku("select * from adres where sicilno=@0", sicilno);
            if (data.Read())
            {
                txtEvAdresi.Text = data["ev"].ToString();
                cboxEvIl.SelectedItem = PRG.cboxIndexBul(ref cboxEvIl, data["evilno"]);
                cboxIsIl.SelectedItem = PRG.cboxIndexBul(ref cboxIsIl, data["isilno"]);
                txtIsAdresi.Text = data["is"].ToString();
                txtEvTel.Text = data["evtel"].ToString();
                txtIsTel.Text = data["istel"].ToString();
                txtCepTel.Text = data["ceptel"].ToString();

            }
        }

        private void DoldurTemelBilgiler(string sicilno)
        {
            Database db = new Database();
           
            var data = db.DataOku("select * from uyeler where sicilno=@0", sicilno);
            if (data.Read())
            {
                txtAdSoyad.Text = data["adsoyad"].ToString();
                txtSicilNo.Text = sicilno;
                cboxTahsil.SelectedItem = PRG.cboxIndexBul(ref cboxTahsil, data["tahsilno"]);
                cboxUnvan.SelectedItem = PRG.cboxIndexBul(ref cboxUnvan, data["unvanno"]);
                cboxIl.SelectedItem = PRG.cboxIndexBul(ref cboxIl, data["ilno"]);
                PRG.DoldurMudurluk(ref cboxMudurluk, data["ilno"].ToString());
                PRG.DoldurBirim(ref cboxBirim, data["mudurlukno"].ToString());
                cboxMudurluk.SelectedItem = PRG.cboxIndexBul(ref cboxMudurluk, data["mudurlukno"]);
                cboxBirim.SelectedItem = PRG.cboxIndexBul(ref cboxBirim, data["birimno"]);
                cboxUyelikTipi.SelectedItem = PRG.cboxIndexBul(ref cboxUyelikTipi, data["uyeliktipino"]);
                
                //dateGiris.Value = Convert.ToDateTime(data["girisTarihi"]);
                //dateKayit.Value = Convert.ToDateTime(data["kayitTarihi"]);
            }
        }
        private void TextboxTemizle(Control control)

        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.HasChildren)
                {
                    TextboxTemizle(c);
                }
            }
        }
        private void ComboTemizle(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is ComboBox)
                {
                    
                    ((ComboBox)c).SelectedIndex = -1;
                }
                if (c.HasChildren)
                {
                   ComboTemizle(c);
                }
            }
        }
        private void ekraniTemizle()
        {
            
            TextboxTemizle(groupBox1);
            ComboTemizle(groupBox1);

        }

        private void cboxUnvan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxIl_SelectedIndexChanged(object sender, EventArgs e)
        {   if(cboxIl.SelectedIndex!=-1)
            PRG.DoldurMudurluk(ref cboxMudurluk, ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key.ToString());
        }

        private void cboxMudurluk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxMudurluk .SelectedIndex != -1)
                PRG.DoldurBirim(ref cboxBirim, ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key.ToString());
        }

        private void cboxBirim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUyeNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
            
        }

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // yeniKayitEkle();
          // uyeBilgisiGuncelle();
        }
        private void yeniKayitEkle()
        {

            int mdr = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
            int ilno = ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
            int birimno = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
            int tahsilno = ((KeyValuePair<int, string>)cboxTahsil.SelectedItem).Key;
            int uyeliktipno = ((KeyValuePair<int, string>)cboxUyelikTipi.SelectedItem).Key;
            int unvan = ((KeyValuePair<int, string>)cboxUnvan.SelectedItem).Key;
             int evilNo = ((KeyValuePair<int, string>)cboxEvIl.SelectedItem).Key;
              int isilNo = ((KeyValuePair<int, string>)cboxIsIl.SelectedItem).Key;
            Database db = new Database();
            Database db3 = new Database();
            Database db2 = new Database();

              db.Sorgu("insert into Uyeler (sicilNo,adSoyad,tahsilNo,unvanNo,ilNo,mudurlukNo,birimNo,uyelikTipiNo,girisTarihi,kayitTarihi) values (@0,@1,@2,@3,@4,@5,@6,@7,@8,@9)", txtSicilNo.Text, txtAdSoyad.Text, tahsilno, unvan, ilno, mdr, birimno, uyeliktipno, dateGiris.Value.Date, dateKayit.Value.Date);
              db2.Sorgu("insert into Adres (sicilNo,ev,evilNo,[is],isilNo,evTel,istel,ceptel) values (@0,@1,@2,@3,@4,@5,@6,@7)", txtSicilNo.Text, txtEvAdresi.Text, evilNo, txtIsAdresi.Text, isilNo, txtEvTel.Text, txtIsTel.Text, txtCepTel.Text);
              db3.Sorgu("insert into nufusBilgileri (sicilNo,baba,anne,dogumYeri,dogumTarihi,medeniHali,kanGrubuno,ilNo,ilce,mahalle,ciltNo,aileSiraNo,siraNo) values (@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12)", txtSicilNo.Text, txtNufusBaba.Text, txtNufusAnne.Text, txtNufusDogumYeri.Text, dateNufusDogum.Value.Date,cboxNufusMedeni.SelectedIndex,cboxNufusKan.SelectedIndex,ilno,txtNufusIlce.Text, txtNufusMahalle.Text, txtNufusCilt.Text, txtNufusAile.Text, txtNufusSira.Text);


        }
        private void uyeBilgisiGuncelle()
        {
            Database db = new Database();
            Database db2 = new Database();
            Database db3 = new Database();
            int mdr = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
            int ilno = ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
            int birimno = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
            int tahsilno = ((KeyValuePair<int, string>)cboxTahsil.SelectedItem).Key;
            int uyeliktipno = ((KeyValuePair<int, string>)cboxUyelikTipi.SelectedItem).Key;
            int unvan = ((KeyValuePair<int, string>)cboxUnvan.SelectedItem).Key;
            int evilNo = ((KeyValuePair<int, string>)cboxEvIl.SelectedItem).Key;
            int isilNo = ((KeyValuePair<int, string>)cboxIsIl.SelectedItem).Key;
            db.Sorgu("UPDATE Uyeler SET adSoyad=@0,tahsilNo=@1,unvanNo=@2,ilNo=@3,mudurlukNo=@4,birimNo=@5,uyelikTipiNo=@6,girisTarihi=@7,kayitTarihi=@8 WHERE sicilNo=@9", txtAdSoyad.Text, tahsilno.ToString(), unvan.ToString(), ilno.ToString(), mdr.ToString(), birimno.ToString(), uyeliktipno.ToString(), dateGiris.Value.Date, dateKayit.Value.Date, txtSicilNo.Text);
            db2.Sorgu("UPDATE Adres SET ev=@0,evilNo=@1,[is]=@2,isilNo=@3,evTel=@4,istel=@5,ceptel=@6 wHERE SİCİLNO=@7 ", txtEvAdresi.Text, evilNo, txtIsAdresi.Text, isilNo, txtEvTel.Text, txtIsTel.Text, txtCepTel.Text, txtSicilNo.Text);
            db3.Sorgu("UPDATE nufusBilgileri SET baba=@0,anne=@1,dogumYeri=@2,dogumTarihi=@3,medeniHali=@4,kanGrubuno=@5,ilNo=@6,ilce=@7,mahalle=@8,ciltNo=@9,aileSiraNo=@10,siraNo=@11 WHERE sicilNo=@12)", txtNufusBaba.Text, txtNufusAnne.Text, txtNufusDogumYeri.Text, dateNufusDogum.Value.Date, cboxNufusMedeni.SelectedIndex, cboxNufusKan.SelectedIndex, ilno, txtNufusIlce.Text, txtNufusMahalle.Text, txtNufusCilt.Text, txtNufusAile.Text, txtNufusSira.Text, txtSicilNo.Text);

        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            ekraniTemizle();
            
        }
    }
}
