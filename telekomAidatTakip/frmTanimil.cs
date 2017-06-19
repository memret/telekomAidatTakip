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
    public partial class frmTanimIl : Form
    {
        public frmTanimIl()
        {
            InitializeComponent();
        }

        private void frmTanimil_Load(object sender, EventArgs e)
        {
            IlListesiniDoldur();
            
        }
        private void IlListesiniDoldur()
        {
            Database db = new Database();
            //data objesi sqlreadera dönüşüp veriyi alır
            var data = db.DataOku("select * from il");

            //listview içeriğini boşaltmamız gerekiyor il önce
            listvil.Items.Clear();
            
            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["ilNo"].ToString();
                item.SubItems.Add(data["ilAdi"].ToString());

                listvil.Items.Add(item);
                //oluşturulan item liste eklenir
            }

            txtAdi.Enabled = false;
            txtPlakaKodu.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = false;
            btnYeni.Enabled = true;
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            if (btnYeni.Text == "Yeni")
            {
                if (btnKaydet.Enabled)
                {
                    DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Some Title", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                    {
                        btnKaydet_Click(this, null);
                    }
                    else if(dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                }

                txtAdi.Text = string.Empty;
                txtPlakaKodu.Text = string.Empty;
                txtPlakaKodu.Enabled = true;
                txtAdi.Enabled = true;
                btnYeni.Text = "Ekle";
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
            else
            {
                if (txtPlakaKodu.Text != string.Empty && txtAdi.Text != string.Empty)
                {
                    Database db = new Database();
                    db.Sorgu("insert into il (ilno,iladi) values (@0,@1)", txtPlakaKodu.Text, txtAdi.Text);
                    txtPlakaKodu.Enabled = false;
                    txtAdi.Enabled = false;
                    btnYeni.Text = "Yeni";
                    IlListesiniDoldur();
                    txtAdi.Text = string.Empty;
                    txtPlakaKodu.Text = string.Empty;
                    btnYeni.Focus(); //görsel amaçlı
                }
                else
                {
                    MessageBox.Show("Plaka kodu veya il adı kısmı boş!");
                }
                
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtPlakaKodu.Text != string.Empty)
            {
                Database db = new Database();
                db.Sorgu("delete from il where ilno=@0", txtPlakaKodu.Text);
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listvil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listvil_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string plakakodu = listvil.SelectedItems[0].Text;
            Database db = new Database();
            txtAdi.Text = db.DataOkuTek("select iladi from il where ilNo=@0", "ilAdi", plakakodu);
            txtPlakaKodu.Text = plakakodu;
            btnKaydet.Enabled = true;
            btnSil.Enabled = true;
            txtAdi.Enabled = true;
            txtPlakaKodu.Enabled = true;
                
         
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtPlakaKodu.Text != string.Empty && txtAdi.Text != string.Empty)
            {
                Database db = new Database();
                db.Sorgu("update il set iladi=@0 where ilno=@1", txtAdi.Text, txtPlakaKodu.Text);

                txtAdi.Text = string.Empty;
                txtPlakaKodu.Text = string.Empty;
                txtAdi.Enabled = false;
                txtPlakaKodu.Enabled = false;
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
                IlListesiniDoldur();
            }
        }
    }
}
