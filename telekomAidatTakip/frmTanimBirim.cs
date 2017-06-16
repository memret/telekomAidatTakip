﻿using System;
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
            Database db = new Database();
            var data = db.DataOku("SELECT b.birimAdi,b.birimNo,b.mudurlukNo,m.mudurlukAdi "+
                "FROM Mudurluk m, Birim b WHERE m.mudurlukNo = b.mudurlukNo");
            
            while (data.Read())
            {
                cBoxMudurluk.Items.Add(data["mudurlukAdi"]);

                ListViewItem item = new ListViewItem();
                item.Text = data["birimNo"].ToString();
                item.SubItems.Add(data["birimAdi"].ToString());
                item.SubItems.Add(data["mudurlukNo"].ToString());
                item.SubItems.Add(data["mudurlukAdi"].ToString());

                listvil.Items.Add(item);
            }



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
