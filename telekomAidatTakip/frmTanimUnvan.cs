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
            Database db = new Database();
            var data = db.DataOku("select * from ünvan");

            while (data.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = data["ünvanKodu"].ToString();
                item.SubItems.Add(data["ünvanAdı"].ToString());

                listView1.Items.Add(item);

            }
            btnKaydet.Enabled = false;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            if (txtünvanKodu.Text != string.Empty && txtünvanAdı.Text != string.Empty)
            {
                Database db = new Database();
                db.Sorgu("insert into ünvan (ünvankodu,ünvanadı) values (@0,@1)", txtünvanKodu.Text, txtünvanAdı.Text);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtünvanKodu.Text != string.Empty)
            {
                Database db = new Database();
                db.Sorgu("delete from il where ilno=@0", txtünvanKodu.Text);
            }
        }
    }
}
