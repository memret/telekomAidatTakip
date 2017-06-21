using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telekomAidatTakip
{
    static class PRG
    {
        public static void DoldurTahsil(ref ComboBox cboxTahsil)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db = new Database();
            var data = db.DataOku("select * from tahsil");

            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["tahsilno"]), data["tahsiladi"].ToString());
            if (cboxSource.Count == 0)
            {
                cboxSource.Add(-1, "Veri Yok");
                cboxTahsil.Enabled = false;
            }
            cboxTahsil.DataSource = new BindingSource(cboxSource, null);
            cboxTahsil.DisplayMember = "Value";
            cboxTahsil.ValueMember = "Key";
            cboxTahsil.Enabled = true;
        }
        
        public static void DoldurUnvan(ref ComboBox cboxUnvan)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db = new Database();
            var data = db.DataOku("select * from unvan");

            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["unvanNo"]), data["Unvanadi"].ToString());
            if (cboxSource.Count == 0)
            {
                cboxSource.Add(-1, "Veri Yok");
                cboxUnvan.Enabled = false;
            }
            cboxUnvan.DataSource = new BindingSource(cboxSource, null);
            cboxUnvan.DisplayMember = "Value";
            cboxUnvan.ValueMember = "Key";
            cboxUnvan.Enabled = true;
        }
        public static void DoldurIl(ref ComboBox cboxIl)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db = new Database();
            var data = db.DataOku("select * from il");

            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["ilno"]), data["iladi"].ToString());
            if (cboxSource.Count == 0)
            {
                cboxSource.Add(-1, "Veri Yok");
                cboxIl.Enabled = false;
            }
            cboxIl.DataSource = new BindingSource(cboxSource, null);
            cboxIl.DisplayMember = "Value";
            cboxIl.ValueMember = "Key";
            cboxIl.Enabled = true;
        }
        public static void DoldurUyelikTipi(ref ComboBox cboxUyelikTipi)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            Database db = new Database();
            var data = db.DataOku("select * from uyeliktipi");

            while (data.Read())
                cboxSource.Add(Convert.ToInt32(data["uyeliktipno"]), data["uyeliktipadi"].ToString());
            if (cboxSource.Count == 0)
            {
                cboxSource.Add(-1, "Veri Yok");
                cboxUyelikTipi.Enabled = false;
            }
            cboxUyelikTipi.DataSource = new BindingSource(cboxSource, null);
            cboxUyelikTipi.DisplayMember = "Value";
            cboxUyelikTipi.ValueMember = "Key";
            cboxUyelikTipi.Enabled = true;
        }
        public static void DoldurMudurluk(ref ComboBox cboxMudurluk, string ilNo)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            if (ilNo != string.Empty)
            {
                Database db = new Database();
                var data = db.DataOku("select * from mudurluk where ilno=@0", ilNo);

                while (data.Read())
                    cboxSource.Add(Convert.ToInt32(data["mudurlukno"]), data["mudurlukadi"].ToString());
                if (cboxSource.Count == 0)
                {
                    cboxSource.Add(-1, "Veri Yok");
                    cboxMudurluk.Enabled = false;
                }
            }
            else
            {
                cboxSource.Add(-1, "İlk önce il seçin");
                cboxMudurluk.Enabled = false;
            }
            cboxMudurluk.DataSource = new BindingSource(cboxSource, null);
            cboxMudurluk.DisplayMember = "Value";
            cboxMudurluk.ValueMember = "Key";
            cboxMudurluk.Enabled = true;
        }
        public static void DoldurBirim(ref ComboBox cboxBirim, string mudurlukNo)
        {
            Dictionary<int, string> cboxSource = new Dictionary<int, string>();
            if (mudurlukNo != string.Empty)
            {
                Database db = new Database();
                var data = db.DataOku("select * from birim where mudurlukno=@0", mudurlukNo);

                while (data.Read())
                    cboxSource.Add(Convert.ToInt32(data["birimno"]), data["birimadi"].ToString());
                if (cboxSource.Count == 0)
                {
                    cboxSource.Add(-1, "Veri Yok");
                    cboxBirim.Enabled = false;
                }
            }
            else
            {
                cboxSource.Add(-1, "İlk önce il seçin");
                cboxBirim.Enabled = false;
            }
            cboxBirim.DataSource = new BindingSource(cboxSource, null);
            cboxBirim.DisplayMember = "Value";
            cboxBirim.ValueMember = "Key";
            cboxBirim.Enabled = true;
        }
        
        
    }
}
