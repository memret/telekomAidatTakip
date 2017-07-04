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
            Database db = new Database();
            var data = db.DataOku("SELECT mudurlukNo,mudurlukAdi FROM mudurluk");

            while (data.Read())
            {
                cboxSource.Add(Convert.ToInt32(data["mudurlukNo"]), data["mudurlukAdi"].ToString());
            }
            cBoxMudurluk.DataSource = new BindingSource(cboxSource, null);
            cBoxMudurluk.DisplayMember = "Value";
            cBoxMudurluk.ValueMember = "Key";
            db.Kapat();
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

            if (btnYeni.Text == "Yeni")
            {
                btnYeni.Text = "Ekle";
                txtBirimAdi.Enabled = true;
                txtBirimKodu.Enabled = true;
                cBoxMudurluk.Enabled = true;
                txtBirimAdi.Clear();
                txtBirimKodu.Clear();
            }

           else 
                if(txtBirimAdi.Text != string.Empty && txtBirimKodu.Text != string.Empty)
                {
                    int mudurlukNo = ((KeyValuePair<int, string>)cBoxMudurluk.SelectedItem).Key;
                    Database db = new Database();
                    db.Sorgu("INSERT INTO Birim Values (@0,@1,@2)", txtBirimKodu.Text, txtBirimAdi.Text, mudurlukNo.ToString());
                    listvil.Items.Clear();
                    listeDoldur();
                    db.Kapat();
            }
            else
            {
                MessageBox.Show("Bİrim adı veya Birim Kodu eksik.");
            }
        }

        private void listvil_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnKaydet.Enabled = true;
            btnSil.Enabled = true;
            txtBirimAdi.Enabled = true;
            cBoxMudurluk.Enabled = true;
            txtBirimKodu.Enabled = false;
            btnYeni.Text = "Yeni";
            Database db = new Database();
            String mudurlukAdi = listvil.SelectedItems[0].SubItems[3].Text;
            String birimKodu = listvil.SelectedItems[0].SubItems[0].Text;
            var data = db.DataOku("SELECT b.birimAdi,b.birimNo,m.mudurlukAdi " +
                  "FROM Mudurluk m, Birim b WHERE m.mudurlukNo = b.mudurlukNo AND m.mudurlukAdi = @0 AND b.birimNo =@1", mudurlukAdi, birimKodu);
            
                if(data.Read())
            {

                txtBirimAdi.Text = data["birimAdi"].ToString();
                txtBirimKodu.Text = data["birimNo"].ToString();
                cBoxMudurluk.Text = data["mudurlukAdi"].ToString();
            }
            db.Kapat();


            /*  String birimKodu = listvil.SelectedItems[0].SubItems[0].Text;
              String birimAdi = listvil.SelectedItems[0].SubItems[1].Text;
              txtBirimKodu.Text = birimKodu;
              txtBirimAdi.Text = birimAdi;
              cBoxMudurluk.Text = listvil.SelectedItems[0].SubItems[3].Text;*/


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
            db.Kapat();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.Sorgu("DELETE FROM Birim Where birimNo = @0", txtBirimKodu.Text);
            listvil.Items.Clear();
            listeDoldur();
            db.Kapat();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            int mudurlukNo = ((KeyValuePair<int, string>)cBoxMudurluk.SelectedItem).Key;
            db.Sorgu("UPDATE Birim Set birimAdi = @0, mudurlukNo=@1 WHERE birimNo=@2", txtBirimAdi.Text,mudurlukNo.ToString(),txtBirimKodu.Text);
            listvil.Items.Clear();
            listeDoldur();
            db.Kapat();

        }

        private void frmTanimBirim_Resize(object sender, EventArgs e)
        {
            //hata var düzeltilecek
            groupBox2.Width = this.Width - 44;
            groupBox2.Height = this.Height - 288;
        }

        private void frmTanimBirim_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }


}