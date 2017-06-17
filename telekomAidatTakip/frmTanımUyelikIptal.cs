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
    public partial class frmTanımUyelikIptal : Form
    {
        public frmTanımUyelikIptal()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //database bağlan, insert textbox1
            if (txtKod.Text != string.Empty && txtAciklama.Text != string.Empty)
            {
                Database db = new Database();
                db.Sorgu("insert into SilinmeNedeni (Kod,Aciklama) values (@0,@1)", txtKod.Text, txtAciklama.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtKod.Text != string.Empty)
            {
                Database db = new Database();
                db.Sorgu("delete from SilinmeNedeni where Kod=@0", txtKod.Text);
            }
        }
    }
}
