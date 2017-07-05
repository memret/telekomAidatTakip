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
    public partial class frmRaporIl : Form
    {
        public frmRaporIl()
        {
            InitializeComponent();
        }

        private void btnEkranaListele_Click(object sender, EventArgs e)
        {


            listIl.Items.Clear();

            Database db = new Database();
            string query = "SELECT distinct i.ilAdi, i.ilNo, coalesce((Select Count(*) from Uyeler u2 where aktif = 'true' AND u.ilNo = u2.ilNo group by ilno),0) 'aktif', coalesce((Select Count(*) from Uyeler u2 where aktif = 'false' AND u.ilNo = u2.ilNo group by ilno) ,0) 'pasif', coalesce((Select Count(*) from Uyeler u2 where u.ilNo = u2.ilNo group by ilno),0) 'toplam' FROM Uyeler u , il i where u.ilno = i.ilno";
            var data = db.DataOku(query);

            while (data.Read())
            {

                ListViewItem item = new ListViewItem();
                item.Text = data["ilno"].ToString();
                item.SubItems.Add(data["ilAdi"].ToString());
                item.SubItems.Add(data["aktif"].ToString());
                item.SubItems.Add(data["pasif"].ToString());
                item.SubItems.Add(data["toplam"].ToString());
                listIl.Items.Add(item);
            }
            db.Kapat();
            yazdir.list = listIl;
            yazdir.baslik = "İl Listesi";
            btnYazdir.Enabled = true;
        }
        Yazdir yazdir;

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            yazdir.printPre.ShowDialog();
        }

        private void frmRaporIl_Load(object sender, EventArgs e)
        {
            yazdir = new Yazdir(1);
        }

        private void listIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listIl_DoubleClick(object sender, EventArgs e)
        {
            if (listIl.SelectedItems.Count > 0)
            {
                frmRaporUye frm = new frmRaporUye(listIl.SelectedItems[0].Text);
                frm.Show();
            }
            
        }
    }
}
