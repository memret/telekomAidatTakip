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
          private void cBoxIlDoldur()
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db2 = new Database();
            var data = db2.DataOku("SELECT ilNo,ilAdi FROM il");

            while (data.Read())
            {
                cboxSource.Add(Convert.ToInt32(data["ilNo"]), data["ilAdi"].ToString());
            }

            cboxIl.DataSource = new BindingSource(cboxSource, null);
            cboxIl.DisplayMember = "Value";
            cboxIl.ValueMember = "Key";
        }
        private void cbxmudurlukdoldur()
        {
            int ilno = ((KeyValuePair<int, string>)cboxIl.SelectedItem).Key;
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db2 = new Database();
            var data = db2.DataOku("SELECT mudurlukNo,mudurlukAdi FROM Mudurluk WHERE ilNo=@0", ilno.ToString());
            while (data.Read())
            {
                cboxSource.Add(Convert.ToInt32(data["mudurlukNo"]), data["mudurlukAdi"].ToString());


            }
            cboxMudurluk.DataSource = new BindingSource(cboxSource, null);
            cboxMudurluk.DisplayMember = "Value";
            cboxMudurluk.ValueMember = "Key";
        }

        private void cbxKisimdoldur()
        {
            //hata var 
            int mdr = ((KeyValuePair<int, string>)cboxMudurluk.SelectedItem).Key;
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db2 = new Database();

            var data = db2.DataOku("SELECT birimNo, birimAdi FROM Birim WHERE mudurlukNo=@0", mdr.ToString());
            while (data.Read())
            {
                cboxSource.Add(Convert.ToInt32(data["birimNo"]), data["birimAdi"].ToString());


            }
            cboxKisim.DataSource = new BindingSource(cboxSource, null);
            cboxKisim.DisplayMember = "Value";
            cboxKisim.ValueMember = "Key";
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


        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void cboxMudurluk_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxKisimdoldur();
        }

        private void grpbxAidatMiktar_Resize(object sender, EventArgs e)
        {

        }

        private void cboxIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxmudurlukdoldur();
        }
    }
}

    

