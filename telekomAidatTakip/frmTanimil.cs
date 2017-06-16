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
    public partial class frmTanimil : Form
    {
        public frmTanimil()
        {
            InitializeComponent();
        }

        private void frmTanimil_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            var data = db.DataOku("select * from il");
            //data objesi sqlreadera dönüşüp veriyi alır
            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["ilNo"].ToString();
                item.SubItems.Add(data["ilAdi"].ToString());

                listvil.Items.Add(item);
                //oluşturulan item liste eklenir
            }
            btnKaydet.Enabled = false;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            //database bağlan, insert textbox1
            if (txtPlakaKodu.Text != string.Empty && txtAdi.Text != string.Empty)
            {
                Database db = new Database();
                db.Sorgu("insert into il (ilno,iladi) values (@0,@1)", txtPlakaKodu.Text, txtAdi.Text);
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
    }
}
