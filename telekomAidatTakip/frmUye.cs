using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telekomAidatTakip
{
    public partial class frmUye : Form
    {
        string sicilno;
        string resimPath;
        public frmUye() // yeni kayıt eklenirken
        {
            InitializeComponent();
        }
        public frmUye(string sicilno) //raporuye den çağırılınca
        {
            this.sicilno = sicilno;
            InitializeComponent();
        }



        private void frmUye_Load(object sender, EventArgs e)
        {

            // DoldurKomple();

            if (sicilno != null)
            {
                DoldurKomple(sicilno);
                btnGuncelle.Enabled = true;
                btnGuncelle.Visible = true;
                btnSil.Enabled = true;
                btnSil.Visible = true;
            }
            else
            {
                DoldurKomple();
                btnKaydet.Enabled = true;
                btnKaydet.Visible = true;
            }
        }

        private void DoldurKomple()
        {
            PRG.DoldurTahsil(ref cboxTahsil);
            PRG.DoldurUnvan(ref cboxUnvan);
            PRG.DoldurIl(ref cboxIl);

            //3 kere daha aynı sql sorgusunu yapmasın diye cboxilden çekiyoruz verileri
            PRG.DoldurIlKopyala(ref cboxEvIl, cboxIl);
            PRG.DoldurIlKopyala(ref cboxIsIl, cboxIl);
            PRG.DoldurIlKopyala(ref cboxNufusIl, cboxIl);
            //PRG.DoldurIl(ref cboxEvIl);
            //PRG.DoldurIl(ref cboxIsIl);
            //PRG.DoldurIl(ref cboxNufusIl);

            PRG.DoldurUyelikTipi(ref cboxUyelikTipi);
            PRG.DoldurKanGrubu(ref cboxNufusKan);



        }

        private void DoldurKomple(string sicilno)
        {
            DoldurKomple();
            DoldurTemelBilgiler(sicilno);
            DoldurFotograf(sicilno);
            DoldurAdresBilgiler(sicilno);
            DoldurNufusBilgileri(sicilno);
            DoldurAidatBilgileri(sicilno);
        }
        byte[] imgBytes;
        private void DoldurFotograf(string sicilno)
        {
            
            Database db = new Database();

            var data = db.DataOku("select fotograf from uyeFotograf where sicilno=@0", sicilno);

            if (data.Read())
            {
                imgBytes = (byte[])data["fotograf"];
            }
            else
            {
                pictureBox1.Image = Properties.Resources._default;
                return;
            }



            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            Bitmap foto = (Bitmap)tc.ConvertFrom(imgBytes);
            pictureBox1.Image = foto;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            db.Kapat();

        }

        private void DoldurNufusBilgileri(string sicilno)
        {
            Database db = new Database();
            var data = db.DataOku("select * from nufusbilgileri where sicilno=@0", sicilno);

            if (data.Read())
            {
                txtNufusBaba.Text = data["baba"].ToString();
                txtNufusAnne.Text = data["anne"].ToString();
                txtNufusDogumYeri.Text = data["dogumyeri"].ToString();
                dateNufusDogum.Value = Convert.ToDateTime(data["dogumTarihi"]);
                cboxNufusMedeni.SelectedIndex = Convert.ToInt32(data["medeniHali"]);
                cboxNufusKan.SelectedItem = PRG.cboxIndexBul(ref cboxNufusKan, data["kangrubuno"]);
                cboxNufusIl.SelectedItem = PRG.cboxIndexBul(ref cboxNufusIl, data["ilno"]);
                txtNufusIlce.Text = data["ilce"].ToString();
                txtNufusMahalle.Text = data["mahalle"].ToString();
                txtNufusSira.Text = data["sirano"].ToString();
                txtNufusCilt.Text = data["ailesirano"].ToString();
                txtNufusAile.Text = data["ciltno"].ToString();
            }
            db.Kapat();
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
                txtAdresEmail.Text = data["email"].ToString();

            }
            db.Kapat();
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

                dateGiris.Value = Convert.ToDateTime(data["girisTarihi"]);
                dateKayit.Value = Convert.ToDateTime(data["kayitTarihi"]);
            }
            db.Kapat();
        }
        private void DoldurAidatBilgileri(string sicilno)
        {
            Database db = new Database();

            var data = db.DataOku("select * from aidatlog where sicilno=@0", sicilno);
            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["aidatlogno"].ToString();
                DateTime dt = Convert.ToDateTime(data["tarih"].ToString());
                item.SubItems.Add(dt.ToString("MM.yyyy"));
                item.SubItems.Add(data["miktar"].ToString());
                listAidatLog.Items.Add(item);
            }
            db.Kapat();
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

        
        
        private bool boslukkontroltextbox()
        {
            foreach (Control c in this.groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == string.Empty || c.Name != "txtNot" || c.Name != "tabControl1")
                        return false;
                }
            }

            return true;
        }
        private bool boslukkontrolcombo()
        {
            foreach (Control c in this.groupBox1.Controls)
            {
                if (c is ComboBox)
                {
                    if (c.Text == string.Empty)
                        return false;
                }
            }

            return true;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // if (boslukkontroltextbox() && boslukkontrolcombo())
            //  MessageBox.Show("Test");

            /*if (pictureBox1.Image == null)
            {
                MessageBox.Show("Fotoğraf girsene reis.");
            }
            else
            {*/
                yeniKayitEkle();

            //}

            //  else
            //    MessageBox.Show("Eksik alanları doldurunuz!");
            //uyeBilgisiGuncelle();

        }

        private void yeniKayitEkle()
        {
            byte[] resim = fotografiAl(pictureBox1.Image);

            int mdr = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
            int ilno = ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
            int birimno = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
            int tahsilno = ((KeyValuePair<int, string>)cboxTahsil.SelectedItem).Key;
            int uyeliktipno = ((KeyValuePair<int, string>)cboxUyelikTipi.SelectedItem).Key;
            int unvan = ((KeyValuePair<int, string>)cboxUnvan.SelectedItem).Key;
            int evilNo = ((KeyValuePair<int, string>)cboxEvIl.SelectedItem).Key;
            int isilNo = ((KeyValuePair<int, string>)cboxIsIl.SelectedItem).Key;
            int kanNo = ((KeyValuePair<int, string>)cboxNufusKan.SelectedItem).Key;
            Database db = new Database();
            Database db3 = new Database();
            Database db2 = new Database();
            Database db4 = new Database();

            db.Sorgu("insert into Uyeler (sicilNo,adSoyad,tahsilNo,unvanNo,ilNo,mudurlukNo,birimNo,uyelikTipiNo,girisTarihi,kayitTarihi,aktif, [not]) values (@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11)", txtSicilNo.Text, txtAdSoyad.Text, tahsilno, unvan, ilno, mdr, birimno, uyeliktipno, dateGiris.Value.Date, dateKayit.Value.Date, "1", txtNot.Text);
            db2.Sorgu("insert into Adres (sicilNo,ev,evilNo,[is],isilNo,evTel,istel,ceptel,email) values (@0,@1,@2,@3,@4,@5,@6,@7,@8)", txtSicilNo.Text, txtEvAdresi.Text, evilNo, txtIsAdresi.Text, isilNo, txtEvTel.Text, txtIsTel.Text, txtCepTel.Text, txtAdresEmail.Text);
            db3.Sorgu("insert into nufusBilgileri (sicilNo,baba,anne,dogumYeri,dogumTarihi,medeniHali,kanGrubuno,ilNo,ilce,mahalle,ciltNo,aileSiraNo,siraNo) values (@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12)", txtSicilNo.Text, txtNufusBaba.Text, txtNufusAnne.Text, txtNufusDogumYeri.Text, dateNufusDogum.Value.Date, cboxNufusMedeni.SelectedIndex, kanNo, ilno, txtNufusIlce.Text, txtNufusMahalle.Text, txtNufusCilt.Text, txtNufusAile.Text, txtNufusSira.Text);
            if(pictureBox1.Image != null)
                db4.Sorgu("insert into UyeFotograf (sicilNo,Fotograf) values (@0,@1)", txtSicilNo.Text, resim);
            MessageBox.Show("Yeni üye kaydedildi.", "Üye Kayıt", MessageBoxButtons.OK);

            db.Kapat();
            db2.Kapat();
            db3.Kapat();
            db4.Kapat();

            ekraniTemizle();

        }
        private void uyeBilgisiGuncelle()
        {

            byte[] resim = fotografiAl(pictureBox1.Image);

            Database db = new Database();
            Database db2 = new Database();
            Database db3 = new Database();
            Database db4 = new Database();
            Database db5 = new Database();
            int kanNo = ((KeyValuePair<int, string>)cboxNufusKan.SelectedItem).Key;
            int mdr = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
            int ilno = ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
            int birimno = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
            int tahsilno = ((KeyValuePair<int, string>)cboxTahsil.SelectedItem).Key;
            int uyeliktipno = ((KeyValuePair<int, string>)cboxUyelikTipi.SelectedItem).Key;
            int unvan = ((KeyValuePair<int, string>)cboxUnvan.SelectedItem).Key;
            int evilNo = ((KeyValuePair<int, string>)cboxEvIl.SelectedItem).Key;
            int isilNo = ((KeyValuePair<int, string>)cboxIsIl.SelectedItem).Key;
            db.Sorgu("UPDATE Uyeler SET adSoyad=@0,tahsilNo=@1,unvanNo=@2,ilNo=@3,mudurlukNo=@4,birimNo=@5,uyelikTipiNo=@6,girisTarihi=@7,kayitTarihi=@8, [not]=@9 WHERE sicilNo=@10", txtAdSoyad.Text, tahsilno.ToString(), unvan.ToString(), ilno.ToString(), mdr.ToString(), birimno.ToString(), uyeliktipno.ToString(), dateGiris.Value.Date, dateKayit.Value.Date,txtNot.Text, sicilno);
            db2.Sorgu("UPDATE Adres SET ev=@0,evilNo=@1,[is]=@2,isilNo=@3,evTel=@4,istel=@5,ceptel=@6, email=@7 wHERE SİCİLNO=@8 ", txtEvAdresi.Text, evilNo, txtIsAdresi.Text, isilNo, txtEvTel.Text, txtIsTel.Text, txtCepTel.Text,txtAdresEmail.Text, sicilno);
            db3.Sorgu("UPDATE nufusBilgileri SET baba=@0,anne=@1,dogumYeri=@2,dogumTarihi=@3,medeniHali=@4,kanGrubuno=@5,ilNo=@6,ilce=@7,mahalle=@8,ciltNo=@9,aileSiraNo=@10,siraNo=@11 WHERE sicilNo=@12", txtNufusBaba.Text, txtNufusAnne.Text, txtNufusDogumYeri.Text, dateNufusDogum.Value.Date, cboxNufusMedeni.SelectedIndex, kanNo, ilno, txtNufusIlce.Text, txtNufusMahalle.Text, txtNufusCilt.Text, txtNufusAile.Text, txtNufusSira.Text, sicilno);

            var data = db4.DataOku("SELECT * FROM uyeFotograf WHERE sicilNo=@0", sicilno);

            if (data.Read())
            {
                db5.Sorgu("UPDATE uyeFotograf SET fotograf = @0 WHERE sicilNo = @1", resim, sicilno);
            }
            else
            {
                db5.Sorgu("insert into UyeFotograf (sicilNo,Fotograf) values (@0,@1)", sicilno, resim);
            }

            db.Kapat();
            db2.Kapat();
            db3.Kapat();
            db4.Kapat();
            db5.Kapat();

            ekraniTemizle();
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            ekraniTemizle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (sicilno != string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Üye silinecek. Emin misiniz?", "Üye silme", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    //üye silinmeyecek silinme nedeni verilip aktif = 0 yapılacak
                    //silinmesi gerekse dahi ilk sorgu yeterli hepsini silmeye :D
                    /*
                    Database db = new Database();
                    Database db2 = new Database();
                    Database db3 = new Database();
                    Database db4 = new Database();
                    db.Sorgu("DELETE FROM Uyeler WHERE sicilNo=@0", sicilno);
                    db2.Sorgu("DELETE FROM Adres WHERE sicilNo=@0", sicilno);
                    db3.Sorgu("DELETE FROM nufusBilgileri WHERE sicilNo=@0", sicilno);
                    db4.Sorgu("DELETE FROM uyeFotograf WHERE sicilNo=@0", sicilno);
                    ekraniTemizle();
                    db.Kapat();
                    db2.Kapat();
                    db3.Kapat();
                    db4.Kapat();
                    MessageBox.Show("Üye silindi.", "Üye silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    */
                }

                else if (dialogResult == DialogResult.Cancel)
                    return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Sicil No gerekli.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            uyeBilgisiGuncelle();
            MessageBox.Show("Kayıt güncellendi!", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnYeniResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Resim seç";
            fd.Filter = "Resim Dosyaları (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = new Bitmap(fd.OpenFile());
                resimPath = fd.FileName.ToString();
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnResimSil_Click(object sender, EventArgs e)
        {
            if (txtSicilNo.Text != string.Empty)
            {
                //Silmek istiyor musun krdş diye sorulacak.
                DialogResult dialogResult = MessageBox.Show("Üye resmi silinecek. Emin misiniz?", "Resim silme", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    Database db = new Database();
                    db.Sorgu("DELETE FROM uyeFotograf WHERE sicilNo=@0", txtSicilNo.Text);
                    db.Kapat();
                }
                else if (dialogResult == DialogResult.Cancel)
                    return;
            }
            pictureBox1.Image = null;
        }

        private byte[] fotografiAl(Image img) 
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));

            /* ömerin yazdığı yarı yanlış
            byte[] resim;
            //fotoğrafı tanıtma 
            FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            resim = br.ReadBytes((int)fs.Length);
            br.Close();
            return resim;
            */
        }

        private void btnAidatEkle_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.Sorgu("insert into aidatlog (sicilNo,miktar,tarih) Values (@0, @1,@2)",sicilno, txtAidatMiktari.Text, dateAidatTarih.Value.ToShortDateString());
            db.Kapat();
            DoldurAidatBilgileri(sicilno);
        }
        private void cboxIl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboxIl.SelectedIndex != -1)
                PRG.DoldurMudurluk(ref cboxMudurluk, ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key.ToString());
        }

        private void cboxMudurluk_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboxMudurluk.SelectedIndex != -1)
                PRG.DoldurBirim(ref cboxBirim, ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key.ToString());
        }
        
        //Buradan sonrası.. Ömer
        private void txtSicilNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }

        private void txtEvTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }

        private void txtIsTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }

        private void txtCepTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }

        private void txtNufusCilt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }

        private void txtNufusAile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }

        private void txtNufusSira_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }

    }
}
