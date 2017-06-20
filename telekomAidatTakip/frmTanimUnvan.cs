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
    public partial class frmTanimUnvan : Form
    {
        public frmTanimUnvan()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmTanimUnvan_Load(object sender, EventArgs e)
        {
            UnvanListesiniDoldur();
        }
        private void UnvanListesiniDoldur()
        {
            Database db = new Database();
           
            var data = db.DataOku("select * from unvan");

            
            listView1.Items.Clear();

            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["unvanNo"].ToString();
                item.SubItems.Add(data["unvanAdi"].ToString());

                listView1.Items.Add(item);
                
            }

            txtünvanAdı.Enabled = false;
            txtünvanKodu.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = false;
            btnYeni.Enabled = true;

        }

        private void txtünvanKodu_TextChanged(object sender, EventArgs e)
        {
            groupBox2.Width = this.Width - 43; 
            groupBox2.Height = this.Height - 233;
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            

            if (btnYeni.Text == "Yeni") 
            {
                if (btnKaydet.Enabled) 
                {
                    DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                        btnKaydet_Click(this, null);
                    else if (dialogResult == DialogResult.Cancel)
                        return;
                }

                txtünvanAdı.Text = string.Empty;
                txtünvanKodu.Text = string.Empty;
                txtünvanKodu.Enabled = true;
                txtünvanAdı.Enabled = true;
                btnYeni.Text = "Ekle";
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
            else 
            {
                if (txtünvanKodu.Text != string.Empty && txtünvanAdı.Text != string.Empty)
                {
                    Database db = new Database();
                    db.Sorgu("insert into unvan (unvanNo,unvanAdi) values (@0,@1)", txtünvanKodu.Text, txtünvanAdı.Text);

                    txtünvanKodu.Enabled = false;
                    txtünvanAdı.Enabled = false;
                    btnYeni.Text = "Yeni";
                    UnvanListesiniDoldur();
                    
                    txtünvanAdı.Text = string.Empty;
                    txtünvanKodu.Text = string.Empty;
                    btnYeni.Focus(); 
                }
                else
                {
                    MessageBox.Show("Ünvan kodu veya ünvan adı kısmı boş!");
                }

            }

        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtünvanKodu.Text != string.Empty && txtünvanAdı.Text != string.Empty) 
            {
                Database db = new Database();
                db.Sorgu("update unvan set unvanAdİ=@0 where unvanNo=@1", txtünvanAdı.Text, txtünvanKodu.Text);

                txtünvanAdı.Text = string.Empty;
                txtünvanKodu.Text = string.Empty;
                txtünvanAdı.Enabled = false;
                txtünvanKodu.Enabled = false;
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
                UnvanListesiniDoldur();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtünvanKodu.Text != string.Empty) 
            {
                Database db = new Database();
                db.Sorgu("delete from unvan where unvanNo=@0", txtünvanKodu.Text);
                UnvanListesiniDoldur();
            }

        }

        private void frmTanimUnvan_FormClosing(object sender, FormClosingEventArgs e)
        {
            //burda form penceresi kapatılırken çalışacak kodlar bulunuyor
            if (btnYeni.Text == "Ekle" || btnKaydet.Enabled) //btnYeni nin ismi Ekle ise veya btnKaydet aktif ise bir düzenleme veya kayıt yapılıyor demektir.
            {
                DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    if (btnYeni.Text == "Ekle")
                        btnYeni_Click(this, null); //btnYeni_Click fonksiyonunu çağırdık
                    else
                        btnKaydet_Click(this, null); //btnYeni_Click fonksiyonunu çağırdık
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true; //bu işlem ile formun kapanma işlemi iptal ediliyor
                }
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string ünvanKodu = listView1.SelectedItems[0].Text; 

            Database db = new Database();
            
            txtünvanKodu.Text = db.DataOkuTek("select unvanAdi from unvan where unvanNo=@0", "unvanAdi", ünvanKodu);

            txtünvanKodu.Text = ünvanKodu;
            btnKaydet.Enabled = true;
            btnSil.Enabled = true;
            txtünvanAdı.Enabled = true;
            txtünvanKodu.Enabled = true;
            btnYeni.Text = "Yeni";
        }
        
                }
            }
    