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
            Database db = new Database();
            var data = db.DataOku("select * from msdb.dbo.backupmediafamily");

            //physical_device_name

            while (data.Read())
            {

                ListViewItem item = new ListViewItem();

                string veri = data["physical_device_name"].ToString();          
                string[] split = veri.Split(new Char[] { '\\', '-', '.'});

                if (split.Length> 2)
                {
                    DateTime result = DateTime.ParseExact(split[2], "ddMMyyyy", System.Globalization.CultureInfo.InvariantCulture);


                    item.SubItems[0].Text = result.ToShortDateString();
                    item.SubItems.Add(split[1]);



                    listYukle.Items.Add(item);
                }
                

            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            
        }
        void Yedekle()
        {

        }

        private void btnYedek_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.Yedekle();
        }

        private void listYukle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
