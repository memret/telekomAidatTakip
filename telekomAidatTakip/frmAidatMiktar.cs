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
    public partial class frmAidatMiktar : Form
    {
        int cntrl;
        private void cBoxIlDoldur()
        {
            PRG.DoldurIl(ref cboxIl);
            
        }
        private void cbxmudurlukdoldur()
        {
            if (cboxIl.SelectedIndex != -1)
            {
                int ilno = ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
                PRG.DoldurMudurluk(ref cboxMudurluk, ilno.ToString());
            }
        }

        private void cbxBirimdoldur()
        {
            if (cboxMudurluk.SelectedIndex != -1)
            {
                int mdr = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                PRG.DoldurBirim(ref cboxBirim, mdr.ToString());
            }
            
        }

        private void IlListesiniDoldur()
        {




        }
        public frmAidatMiktar()
        {
            InitializeComponent();
        }

        private void frmAidatMiktar_Load(object sender, EventArgs e)
        {
            cBoxIlDoldur();
           
            cboxIl.SelectedIndex = -1;
            cboxBirim.Enabled = false;
            cboxMudurluk.Enabled = false;
            btnKaydet.Visible = false;
            button1.Visible = true;
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        { if (cboxIl.SelectedIndex != -1 || cboxBirim.SelectedIndex != -1 || cboxMudurluk.SelectedIndex != -1 || txtAidatMiktari.ToString() != string.Empty)
            {
                Database db = new Database();
                int mdr = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                int ilno = ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
                int birimno = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
                db.Sorgu("update AidatMiktar set aidat=@0 where  birimNo=@1", txtAidatMiktari.Text,birimno.ToString());
                MessageBox.Show("Aidat bilgisi güncellendi!");
                cboxIl.SelectedIndex = -1;
                cboxMudurluk.SelectedIndex = -1;
                cboxBirim.SelectedIndex = -1;
                txtAidatMiktari.Text = string.Empty;
            }
         
        }

        private void cboxMudurluk_SelectedIndexChanged(object sender, EventArgs e)
        {   if (cboxMudurluk.SelectedIndex != -1)
            {   
                cbxBirimdoldur();
                cboxBirim.Enabled = true;
                cboxBirim.SelectedIndex = -1;
                txtAidatMiktari.Text = string.Empty;
            }
        }


        private void cboxIl_SelectedIndexChanged(object sender, EventArgs e)
        {   if (cboxIl.SelectedIndex != -1)
            {
                
                cbxmudurlukdoldur();
                cboxMudurluk.Enabled = true;
                cboxBirim.Enabled = false;
                cboxMudurluk.SelectedIndex = -1;
              
           }
             
        }

        private void cboxBirim_SelectedIndexChanged(object sender, EventArgs e)
        {  if ( cboxBirim.SelectedIndex != -1 && cboxIl.SelectedIndex != -1 && cboxMudurluk.SelectedIndex != -1)
          {
                {
                    btnKaydet.Visible = true;
                    button1.Visible = true;
                    Database db2 = new Database();
                    int birimno = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
                    //  var data = db2.DataOku("SELECT * FROM AidatMiktar WHERE birimNo=@1 ",birimno.ToString() );
                    var data = db2.DataOku("SELECT * FROM aidatmiktar WHERE birimno=@0 ", birimno.ToString());
                    while (data.Read())
                    {

                        txtAidatMiktari.Text = data["aidat"].ToString();

                    }

                    if (txtAidatMiktari.Text == string.Empty)
                    {
                        btnKaydet.Visible = false;
                    }
                    else
                        button1.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboxIl.SelectedIndex != -1 || cboxBirim.SelectedIndex != -1 || cboxMudurluk.SelectedIndex != -1 || txtAidatMiktari.ToString() != string.Empty)
            {
                Database db = new Database();
                int mdr = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
                int ilno = ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
                int birimno = ((KeyValuePair<int, string>)cboxBirim.SelectedItem).Key;
                db.Sorgu("INSERT INTO AidatMiktar values (@0,@1)",  birimno.ToString(), txtAidatMiktari.Text);
                cboxIl.SelectedIndex = -1;
                cboxMudurluk.SelectedIndex = -1;
                cboxBirim.SelectedIndex = -1;
                txtAidatMiktari.Text = string.Empty;
            }
            else
                MessageBox.Show("Lütfen boş alanları doldururuz!");
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            cboxIl.SelectedIndex = -1;
            cboxMudurluk.SelectedIndex = -1;
            cboxBirim.SelectedIndex = -1;
            txtAidatMiktari.Text = string.Empty;
           // btnKaydet.Visible =true;
            button1.Visible = true;
            btnKaydet.Visible = false;
        }

        private void frmAidatMiktar_Resize(object sender, EventArgs e)
        {
            grpbxAidatMiktar.Width = this.Width - 40;
            grpbxAidatMiktar.Height = this.Height - 95;
        }
    }
}

    

