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
    public partial class frmYedekleme : Form
    {
        public frmYedekleme()
        {
            InitializeComponent();
        }

        private void frmYedekleme_Load(object sender, EventArgs e)
        {

        }
        void Yedekle()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.Yedekle();
        }
    }
}
