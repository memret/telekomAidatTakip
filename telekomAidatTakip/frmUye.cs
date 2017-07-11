﻿using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telekomAidatTakip
{
    public partial class frmUye : MetroForm
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

            if (imgBytes == null || imgBytes.Length == 0)
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
                txtNufusCilt.Text = data["ciltno"].ToString();
                txtNufusAile.Text = data["ailesirano"].ToString();
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

                if (!(bool)data["aktif"])
                {
                    Database db2 = new Database();

                    lblSilinmeBilgisi.Text = db2.DataOkuTek("select silinmenedeni from silinmenedeni where silinmenedenno = @0", "silinmenedeni", data["silinmenedenino"]);
                    lblSilinmeBilgisi.Visible = true;
                    lblSilinmeBilgisiLabeli.Visible = true;
                    btnAktiflestir.Location = new Point(lblSilinmeBilgisi.Location.X + lblSilinmeBilgisi.Size.Width + 5, btnAktiflestir.Location.Y);
                    btnAktiflestir.Visible = true;
                    btnSil.Visible = false;
                }

                dateGiris.Value = Convert.ToDateTime(data["girisTarihi"]);
                dateKayit.Value = Convert.ToDateTime(data["kayitTarihi"]);
                txtNot.Text = data["not"].ToString();
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
        public string BosYerVarMi()
        {
            if (txtSicilNo.Text == string.Empty)
            {
                return "Sicil numarası boş bırakılamaz";
            }
            if (txtAdSoyad.Text == string.Empty)
            {
                return "Ad soyad boş bırakılamaz";
            }
            if (cboxTahsil.Text == string.Empty)
            {
                return "Tahsil boş bırakılamaz";
            }
            if (cboxUnvan.Text == string.Empty)
            {
                return "Ünvan boş bırakılamaz";
            }
            if (cboxIl.Text == string.Empty)
            {
                return "İl boş bırakılamaz";
            }
            if (cboxMudurluk.Text == string.Empty)
            {
                return "Müdürlük boş bırakılamaz";
            }
            if (cboxBirim.Text == string.Empty)
            {
                return "Birim boş bırakılamaz";
            }
            if (cboxUyelikTipi.Text == string.Empty)
            {
                return "Üyelik tipi boş bırakılamaz";
            }


            return null;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (BosYerVarMi() == null)
            {
                yeniKayitEkle();
            }
            else
                MessageBox.Show(BosYerVarMi());
            // if (boslukkontroltextbox() && boslukkontrolcombo())
            //  MessageBox.Show("Test");

            /*if (pictureBox1.Image == null)
            {
                MessageBox.Show("Fotoğraf girsene reis.");
            }
            else
            {*/
            //}

            //  else
            //    MessageBox.Show("Eksik alanları doldurunuz!");
            //uyeBilgisiGuncelle();

        }

        private void yeniKayitEkle()
        {
            Database db, db2;
            byte[] resim;
            try
            {
                db = new Database();
                db2 = new Database();
                resim = fotografiAl(pictureBox1.Image);
                /*
                
                mdr = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                ilno = ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
                birimno = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
                tahsilno = ((KeyValuePair<int, string>)cboxTahsil.SelectedItem).Key;
                uyeliktipno = ((KeyValuePair<int, string>)cboxUyelikTipi.SelectedItem).Key;
                unvan = ((KeyValuePair<int, string>)cboxUnvan.SelectedItem).Key;
                evilNo = ((KeyValuePair<int, string>)cboxEvIl.SelectedItem).Key;
                isilNo = ((KeyValuePair<int, string>)cboxIsIl.SelectedItem).Key;
                kanNo = ((KeyValuePair<int, string>)cboxNufusKan.SelectedItem).Key;
                */
                var kanNo = PRG.cboxKeyGetir(ref cboxNufusKan);// ((KeyValuePair<int, string>)cboxNufusKan.SelectedItem).Key;
                var mdr = PRG.cboxKeyGetir(ref cboxMudurluk);//((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                var ilno = PRG.cboxKeyGetir(ref cboxIl);//((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
                var birimno = PRG.cboxKeyGetir(ref cboxBirim);//((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
                var tahsilno = PRG.cboxKeyGetir(ref cboxTahsil);//((KeyValuePair<int, string>)cboxTahsil.SelectedItem).Key;
                var uyeliktipno = PRG.cboxKeyGetir(ref cboxUyelikTipi);//((KeyValuePair<int, string>)cboxUyelikTipi.SelectedItem).Key;
                var unvan = PRG.cboxKeyGetir(ref cboxUnvan);//((KeyValuePair<int, string>)cboxUnvan.SelectedItem).Key;
                var evilNo = PRG.cboxKeyGetir(ref cboxEvIl);//((KeyValuePair<int, string>)cboxEvIl.SelectedItem).Key;
                var isilNo = PRG.cboxKeyGetir(ref cboxIsIl);//((KeyValuePair<int, string>)cboxIsIl.SelectedItem).Key;




                db.Sorgu("insert into Uyeler (sicilNo,adSoyad,tahsilNo,unvanNo,ilNo,mudurlukNo,birimNo,uyelikTipiNo,girisTarihi,kayitTarihi,aktif, [not]) values (@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11);" +
                "insert into Adres (sicilNo,ev,evilNo,[is],isilNo,evTel,istel,ceptel,email) values (@12,@13,@14,@15,@16,@17,@18,@19,@20);" +
                "insert into nufusBilgileri (sicilNo,baba,anne,dogumYeri,dogumTarihi,medeniHali,kanGrubuno,ilNo,ilce,mahalle,ciltNo,aileSiraNo,siraNo) values (@21,@22,@23,@24,@25,@26,@27,@28,@29,@30,@31,@32,@33);", txtSicilNo.Text, txtAdSoyad.Text, tahsilno, unvan, ilno, mdr, birimno, uyeliktipno, dateGiris.Value.Date, dateKayit.Value.Date, "1", txtNot.Text, txtSicilNo.Text, txtEvAdresi.Text, evilNo, txtIsAdresi.Text, isilNo, txtEvTel.Text, txtIsTel.Text, txtCepTel.Text, txtAdresEmail.Text, txtSicilNo.Text, txtNufusBaba.Text, txtNufusAnne.Text, txtNufusDogumYeri.Text, dateNufusDogum.Value.Date, cboxNufusMedeni.SelectedIndex, kanNo, ilno, txtNufusIlce.Text, txtNufusMahalle.Text, txtNufusCilt.Text, txtNufusAile.Text, txtNufusSira.Text);

                if (pictureBox1.Image != null)
                    db2.Sorgu("insert into UyeFotograf (sicilNo,Fotograf) values (@0,@1)", txtSicilNo.Text, resim);
                MessageBox.Show("Yeni üye kaydedildi.", "Üye Kayıt", MessageBoxButtons.OK);
                ekraniTemizle();
                db.Kapat();
                db2.Kapat();
                this.Close();
            }
            catch (Exception e)
            {
                Exception ed = e;
                MessageBox.Show("Yeni kayıt sırasında problem oluştu.");
            }
            finally
            {
                db = null;
                db2 = null;
            }
            /*
            Database db = new Database();
            Database db3 = new Database();
            Database db2 = new Database();
            Database db4 = new Database();

            db.Sorgu("insert into Uyeler (sicilNo,adSoyad,tahsilNo,unvanNo,ilNo,mudurlukNo,birimNo,uyelikTipiNo,girisTarihi,kayitTarihi,aktif, [not]) values (@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11)", txtSicilNo.Text, txtAdSoyad.Text, tahsilno, unvan, ilno, mdr, birimno, uyeliktipno, dateGiris.Value.Date, dateKayit.Value.Date, "1", txtNot.Text);
            db2.Sorgu("insert into Adres (sicilNo,ev,evilNo,[is],isilNo,evTel,istel,ceptel,email) values (@0,@1,@2,@3,@4,@5,@6,@7,@8)", txtSicilNo.Text, txtEvAdresi.Text, evilNo, txtIsAdresi.Text, isilNo, txtEvTel.Text, txtIsTel.Text, txtCepTel.Text, txtAdresEmail.Text);
            db3.Sorgu("insert into nufusBilgileri (sicilNo,baba,anne,dogumYeri,dogumTarihi,medeniHali,kanGrubuno,ilNo,ilce,mahalle,ciltNo,aileSiraNo,siraNo) values (@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12)", txtSicilNo.Text, txtNufusBaba.Text, txtNufusAnne.Text, txtNufusDogumYeri.Text, dateNufusDogum.Value.Date, cboxNufusMedeni.SelectedIndex, kanNo, ilno, txtNufusIlce.Text, txtNufusMahalle.Text, txtNufusCilt.Text, txtNufusAile.Text, txtNufusSira.Text);
            if (pictureBox1.Image != null)
                db4.Sorgu("insert into UyeFotograf (sicilNo,Fotograf) values (@0,@1)", txtSicilNo.Text, resim);
            MessageBox.Show("Yeni üye kaydedildi.", "Üye Kayıt", MessageBoxButtons.OK);

            db.Kapat();
            db2.Kapat();
            db3.Kapat();
            db4.Kapat();
            */



        }
        private void uyeBilgisiGuncelle()
        {
            Database db, db2, db3;
            try
            {
                byte[] resim = fotografiAl(pictureBox1.Image);
                db = new Database();
                db2 = new Database();
                db3 = new Database();


                var kanNo = PRG.cboxKeyGetir(ref cboxNufusKan);// ((KeyValuePair<int, string>)cboxNufusKan.SelectedItem).Key;
                var mdr = PRG.cboxKeyGetir(ref cboxMudurluk);//((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                var ilno = PRG.cboxKeyGetir(ref cboxIl);//((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
                var birimno = PRG.cboxKeyGetir(ref cboxBirim);//((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
                var tahsilno = PRG.cboxKeyGetir(ref cboxTahsil);//((KeyValuePair<int, string>)cboxTahsil.SelectedItem).Key;
                var uyeliktipno = PRG.cboxKeyGetir(ref cboxUyelikTipi);//((KeyValuePair<int, string>)cboxUyelikTipi.SelectedItem).Key;
                var unvan = PRG.cboxKeyGetir(ref cboxUnvan);//((KeyValuePair<int, string>)cboxUnvan.SelectedItem).Key;
                var evilNo = PRG.cboxKeyGetir(ref cboxEvIl);//((KeyValuePair<int, string>)cboxEvIl.SelectedItem).Key;
                var isilNo = PRG.cboxKeyGetir(ref cboxIsIl);//((KeyValuePair<int, string>)cboxIsIl.SelectedItem).Key;


                db.Sorgu("UPDATE Uyeler SET adSoyad=@0,tahsilNo=@1,unvanNo=@2,ilNo=@3,mudurlukNo=@4,birimNo=@5,uyelikTipiNo=@6,girisTarihi=@7,kayitTarihi=@8, [not]=@9 WHERE sicilNo=@10;" +
                "UPDATE Adres SET ev=@11,evilNo=@12,[is]=@13,isilNo=@14,evTel=@15,istel=@16,ceptel=@17, email=@18 wHERE SİCİLNO=@10 ;" +
                "UPDATE nufusBilgileri SET baba=@19,anne=@20,dogumYeri=@21,dogumTarihi=@22,medeniHali=@23,kanGrubuno=@24,ilNo=@25,ilce=@26,mahalle=@27,ciltNo=@28,aileSiraNo=@29,siraNo=@30 WHERE sicilNo=@10;",
                txtAdSoyad.Text, tahsilno.ToString(), unvan.ToString(), ilno.ToString(), mdr.ToString(), birimno.ToString(), uyeliktipno.ToString(), dateGiris.Value.Date, dateKayit.Value.Date, txtNot.Text, sicilno,
                txtEvAdresi.Text, evilNo, txtIsAdresi.Text, isilNo, txtEvTel.Text, txtIsTel.Text, txtCepTel.Text, txtAdresEmail.Text,
                txtNufusBaba.Text, txtNufusAnne.Text, txtNufusDogumYeri.Text, dateNufusDogum.Value.Date, cboxNufusMedeni.SelectedIndex, kanNo, ilno, txtNufusIlce.Text, txtNufusMahalle.Text, txtNufusCilt.Text, txtNufusAile.Text, txtNufusSira.Text);

                var data = db2.DataOku("SELECT * FROM uyeFotograf WHERE sicilNo=@0", sicilno);

                if (data.Read())
                {
                    db3.Sorgu("UPDATE uyeFotograf SET fotograf = @0 WHERE sicilNo = @1", resim, sicilno);
                }
                else
                {
                    db3.Sorgu("insert into UyeFotograf (sicilNo,Fotograf) values (@0,@1)", sicilno, resim);
                }
                ekraniTemizle();
            }
            catch
            {
                MessageBox.Show("Güncelleme sırasında problem oluştu.");

            }
            finally
            {
                db = null;
                db2 = null;
                db3 = null;
            }

        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            ekraniTemizle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (sicilno != string.Empty)
            {
                frmUyeSil frm = new frmUyeSil(sicilno);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    DoldurKomple(sicilno);
                }

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Silme işlemi için sicil numarası gerekli.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (BosYerVarMi() == null)
            {
                uyeBilgisiGuncelle();
                MessageBox.Show("Kayıt güncellendi!", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show(BosYerVarMi());

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

            /*if (txtSicilNo.Text != string.Empty)
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
            }*/
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
            db.Sorgu("insert into aidatlog (sicilNo,miktar,tarih) Values (@0, @1,@2)", sicilno, txtAidatMiktari.Text, dateAidatTarih.Value.ToShortDateString());
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txtEvTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txtIsTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txtCepTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txtNufusCilt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txtNufusAile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txtNufusSira_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }


        private void txtSicilNo_Leave(object sender, EventArgs e)
        {
            Database db = new Database();
            var data = db.DataOku("select sicilNo from Uyeler");
            while (data.Read())
            {
                String sicilDb = data["sicilNo"].ToString();
                if (sicilDb.Equals(txtSicilNo.Text.ToString()))
                {
                    MessageBox.Show("Bu sicil Numarası kayıtlı.");
                    txtSicilNo.Clear();
                    txtSicilNo.Select();
                }
            }
        }

        private void btnAktiflestir_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.Sorgu("update uyeler set aktif = 1, silinmenedenino= NULL where sicilno=@0", sicilno);
            lblSilinmeBilgisi.Visible = false;
            lblSilinmeBilgisiLabeli.Visible = false;
            btnAktiflestir.Visible = false;
            frmUye_Load(this, null);
        }

        private void txtAdresEmail_Leave(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (txtAdresEmail.Text != string.Empty)
            {

                if (!reg.IsMatch(txtAdresEmail.Text))
                {
                    MessageBox.Show("Email formatı yanlış.\n" + "Örnek: kullaniciAdi@turktelekom.com.tr");
                    txtAdresEmail.Clear();
                    txtAdresEmail.Select();

                }
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
