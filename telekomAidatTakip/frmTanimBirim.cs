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
    public partial class frmTanimBirim : Form
    {
        public frmTanimBirim()
        {
            InitializeComponent();
        }


        private void frmTanimBirim_Load(object sender, EventArgs e)
        {
            listeDoldur();
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db2 = new Database();
            var data = db2.DataOku("SELECT mudurlukNo,mudurlukAdi FROM mudurluk");

            while (data.Read())
            {
                cboxSource.Add(Convert.ToInt32(data["mudurlukNo"]), data["mudurlukAdi"].ToString());
                cBoxMudurluk.DataSource = new BindingSource(cboxSource, null);
                cBoxMudurluk.DisplayMember = "Value";
                cBoxMudurluk.ValueMember = "Key";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            //Aynı birim no varsa hata kontrolü yap.
            int mudurlukNo = ((KeyValuePair<int, string>)cBoxMudurluk.SelectedItem).Key;
            Database db = new Database();
            db.Sorgu("INSERT INTO Birim Values (@0,@1,@2)",txtBirimKodu.Text, txtBirimAdi.Text,mudurlukNo.ToString());
            listvil.Items.Clear();
            listeDoldur();
        }

        private void listvil_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String birimKodu = listvil.SelectedItems[0].Text;
            String birimAdi = listvil.SelectedItems[0].SubItems[1].Text;
            txtBirimKodu.Text = birimKodu;
            txtBirimAdi.Text = birimAdi;
            cBoxMudurluk.Text = listvil.SelectedItems[0].SubItems[3].Text;

        }

        private void listeDoldur()
        {
            Database db = new Database();
            var data = db.DataOku("SELECT b.birimAdi,b.birimNo,b.mudurlukNo,m.mudurlukAdi " +
                 "FROM Mudurluk m, Birim b WHERE m.mudurlukNo = b.mudurlukNo");
            while (data.Read())
            {

                ListViewItem item = new ListViewItem();
                item.Text = data["birimNo"].ToString();
                item.SubItems.Add(data["birimAdi"].ToString());
                item.SubItems.Add(data["mudurlukNo"].ToString());
                item.SubItems.Add(data["mudurlukAdi"].ToString());

                listvil.Items.Add(item);
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.Sorgu("DELETE FROM Birim Where birimNo = @0", txtBirimKodu.Text);
            listvil.Items.Clear();
            listeDoldur();

        }
    }


}