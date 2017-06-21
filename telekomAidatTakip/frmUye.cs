﻿using System;
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
        public frmUye()
        {
            InitializeComponent();
        }



        private void frmUye_Load(object sender, EventArgs e)
        {
            DoldurKomple("1");

        }
        private void DoldurKomple()
        {
            PRG.DoldurTahsil(ref cboxTahsil);
            PRG.DoldurUnvan(ref cboxUnvan);
            PRG.DoldurIl(ref cboxIl);
            PRG.DoldurIl(ref cboxEvIl);
            PRG.DoldurIl(ref cboxIsIl);
            PRG.DoldurMudurluk(ref cboxMudurluk, ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key.ToString());
            PRG.DoldurBirim(ref cboxBirim, ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key.ToString());
            PRG.DoldurUyelikTipi(ref cboxUyelikTipi);
        }
        private void DoldurKomple(string sicilno)
        {
            DoldurKomple();
            DoldurTemelBilgiler(sicilno);
            DoldurAdresBilgiler(sicilno);
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
                /*cboxTahsil.SelectedItem = PRG.cboxIndexBul(ref cboxTahsil, data["tahsilno"]);
                cboxUnvan.SelectedItem = PRG.cboxIndexBul(ref cboxUnvan, data["unvanno"]);
                cboxIl.SelectedItem = PRG.cboxIndexBul(ref cboxIl, data["ilno"]);
                cboxMudurluk.SelectedItem = PRG.cboxIndexBul(ref cboxMudurluk, data["mudurlukno"]);
                cboxBirim.SelectedItem = PRG.cboxIndexBul(ref cboxBirim, data["birimno"]);
                cboxUyelikTipi.SelectedItem = PRG.cboxIndexBul(ref cboxUyelikTipi, data["uyeliktipino"]);
                */
                //dateGiris.Value = Convert.ToDateTime(data["girisTarihi"]);
                //dateKayit.Value = Convert.ToDateTime(data["kayitTarihi"]);
            }
        }
        

        private void cboxUnvan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            PRG.DoldurMudurluk(ref cboxMudurluk, ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key.ToString());
        }

        private void cboxMudurluk_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
