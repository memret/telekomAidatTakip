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

            
            listUnvan.Items.Clear();

            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["unvanNo"].ToString();
                item.SubItems.Add(data["unvanAdi"].ToString());

                listUnvan.Items.Add(item);
                
            }

            txtUnvanAdi.Enabled = false;
            txtUnvanNo.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = false;
            btnYeni.Enabled = true;

        }

        private void txtünvanKodu_TextChanged(object sender, EventArgs e)
        {
            
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

                txtUnvanAdi.Text = string.Empty;
                txtUnvanNo.Text = string.Empty;
                txtUnvanNo.Enabled = true;
                txtUnvanAdi.Enabled = true;
                btnYeni.Text = "Ekle";
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
            }
            else 
            {
                if (txtUnvanNo.Text != string.Empty && txtUnvanAdi.Text != string.Empty)
                {
                    Database db = new Database();
                    db.Sorgu("insert into unvan (unvanNo,unvanAdi) values (@0,@1)", txtUnvanNo.Text, txtUnvanAdi.Text);

                    txtUnvanNo.Enabled = false;
                    txtUnvanAdi.Enabled = false;
                    btnYeni.Text = "Yeni";
                    UnvanListesiniDoldur();
                    
                    txtUnvanAdi.Text = string.Empty;
                    txtUnvanNo.Text = string.Empty;
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
            if (txtUnvanNo.Text != string.Empty && txtUnvanAdi.Text != string.Empty) 
            {
                Database db = new Database();
                db.Sorgu("update unvan set unvanAdİ=@0 where unvanNo=@1", txtUnvanAdi.Text, txtUnvanNo.Text);

                txtUnvanAdi.Text = string.Empty;
                txtUnvanNo.Text = string.Empty;
                txtUnvanAdi.Enabled = false;
                txtUnvanNo.Enabled = false;
                btnKaydet.Enabled = false;
                btnSil.Enabled = false;
                UnvanListesiniDoldur();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (btnSil.Enabled)
            {
                DialogResult dialogResult = MessageBox.Show("Değişiklikleri silmek istiyor musunuz?", "", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    if (txtUnvanNo.Text != string.Empty)
                    {
                        Database db = new Database();
                        db.Sorgu("delete from unvan where unvanNo=@0", txtUnvanNo.Text);
                        UnvanListesiniDoldur();
                    }
                }
                    
                else if (dialogResult == DialogResult.Cancel)
                    return;
            }
            }

        private void frmTanimUnvan_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (btnYeni.Text == "Ekle" || btnKaydet.Enabled) 
            {
                DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    if (btnYeni.Text == "Ekle")
                        btnYeni_Click(this, null); 
                    else
                        btnKaydet_Click(this, null); 
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true; 
                }
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string ünvanKodu = listUnvan.SelectedItems[0].Text; 

            Database db = new Database();
            
            txtUnvanAdi.Text = db.DataOkuTek("select unvanAdi from unvan where unvanNo=@0", "unvanAdi", ünvanKodu);

            txtUnvanNo.Text = ünvanKodu;
            btnKaydet.Enabled = true;
            btnSil.Enabled = true;
            txtUnvanAdi.Enabled = true;
            txtUnvanNo.Enabled = true;
            btnYeni.Text = "Yeni";
        }

        private void frmTanimUnvan_Resize(object sender, EventArgs e)
        {
            groupBox2.Width = this.Width - 59;
            groupBox2.Height = this.Height - 256;
        }
    }
            }
    