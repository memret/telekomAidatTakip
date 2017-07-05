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
    public partial class frmTanimOzelGunler : Form
    {
        public frmTanimOzelGunler()
        {
            InitializeComponent();
        }

        private void frmTanimOzelGunler_Load(object sender, EventArgs e)
        {
            tabloDoldur();
        }

        private void tabloDoldur()
        {
            Database db = new Database();
            var data = db.DataOku("SELECT * FROM OzelGunler");

            listView1.Items.Clear();

            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["ozelGunNo"].ToString();
                item.SubItems.Add(data["baslik"].ToString());
                item.SubItems.Add(data["tarih"].ToString());
                item.SubItems.Add(data["mesaj"].ToString());
                item.SubItems.Add(data["yorum"].ToString());
               
                listView1.Items.Add(item);
                //oluşturulan item liste eklenir
            }

            txtBaslik.Enabled = false;
            txtMsj.Enabled = false;
            txtYorum.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = false;
            btnYeni.Enabled = true;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
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

                txtBaslik.Text = string.Empty;
                txtMsj.Text = string.Empty;
                txtYorum.Text = string.Empty;
                txtBaslik.Enabled = true;
                txtMsj.Enabled = true;
                txtYorum.Enabled = true;
                
                btnYeni.Text = "Ekle";
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
            else //butonun ismi Yeni değilse demekki yeni kayıt sayfasındayız
            {

                if (txtBaslik.Text != string.Empty && txtMsj.Text != string.Empty) //yeni kayıt eklemek için bu iki verinin boş olmaması gerekiyor
                {
                    DateTime dt = this.dateTimeTarih.Value.Date;
                    Database db = new Database();
                    
                    System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@3", dt);
                    db.Sorgu("insert into OzelGunler(baslik,mesaj,yorum,tarih) values (@0,@1,@2,@3)", param, txtBaslik.Text, txtMsj.Text, txtYorum.Text);

                    txtBaslik.Enabled = false;
                    txtMsj.Enabled = false;
                    txtYorum.Enabled = false;
                    btnYeni.Text = "Yeni";
                    tabloDoldur();
                    txtBaslik.Text = string.Empty;
                    txtMsj.Text = string.Empty;
                    txtYorum.Text = string.Empty;
                    btnYeni.Focus(); //görsel amaçlı imiş
                }
                else
                {
                    MessageBox.Show("Başlık veya mesaj boş!");
                }

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            /*if (txtBaslik.Text != string.Empty && txtMsj.Text != string.Empty)
            {
                DateTime dt = this.dateTimeTarih.Value.Date;
                Database db = new Database();
                System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@3", dt);
                db.Sorgu("update OzelGunler set baslik=@0, mesaj=@1, yorum=@2, tarih=@3 where ozelGunNo=@4", param, txtBaslik.Text, txtMsj.Text, txtYorum.Text, BURAYA OzelgunNo'yu NASIL YAZACAM YA :'D);

                txtBaslik.Text = string.Empty;
                txtMsj.Text = string.Empty;
                txtYorum.Text = string.Empty;
                txtBaslik.Enabled = false;
                txtMsj.Enabled = false;
                txtYorum.Enabled = false;

                btnSil.Enabled = false;
                listView1.Items.Clear();
                tabloDoldur();
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TboxMailBasligi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
    }
}
