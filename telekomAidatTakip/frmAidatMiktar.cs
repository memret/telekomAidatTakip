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
        private void IlListesiniDoldur()
        {
            Database db = new Database();
            //data objesi sqlreadera dönüşüp veriyi alır. 
            //direk sqldatareaderda yazılabilir fakat bu sefer forum içerisinde using bilmemne yazmamız gerekir
            //var kelimesi ile tanımlanan değişkene ilk olarak ne eşitlersek o değişken tipinde olur
            var data = db.DataOku("select * from il");

            //listview içeriğini boşaltmamız gerekiyor il önce

            cboxIl.Items.Clear();

            while (data.Read())
            {


                /*  item.Text = data["ilNo"].ToString();
                  item.SubItems.Add(data["ilAdi"].ToString());
                  cboxIl.Items.Add(item);*/


            }
        }
        public frmAidatMiktar()
        {
            InitializeComponent();
        }

        private void frmAidatMiktar_Load(object sender, EventArgs e)
        {

        }
    }
}
