using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telekomAidatTakip
{
    class Database
    {
        MySqlConnection bag;
        MySqlCommand kmt;
        MySqlDataReader data;
        public Database(string connectstring)
        {
            bag = new MySqlConnection(connectstring);
            kmt = new MySqlCommand();
            kmt.Connection = bag;
            bag.Open();
        }
        public Database()
        {
            bag = new MySqlConnection(PRG.connectstring);
            kmt = new MySqlCommand();
            kmt.Connection = bag;
            bag.Open();
        }
        ~Database()
        {
            bag.Close();
        }
        public MySqlDataReader DataOku(string query)
        {
            kmt.CommandText = query;
            data = kmt.ExecuteReader();
            return data;
        }
        public MySqlDataReader DataOku(string query, params string[] param)
        {
            kmt.CommandText = query;
            for (int i = 0; i < param.Length; i++)
            {
                kmt.Parameters.AddWithValue("@" + i, param[i]);
            }
            data = kmt.ExecuteReader();
            return data;
        }
        public void Sorgu(string query)
        {
            kmt.CommandText = query;
            kmt.ExecuteNonQuery();
        }
        public void Sorgu(string query, params string[] param)
        {
            kmt.CommandText = query;
            for (int i = 0; i < param.Length; i++)
            {
                kmt.Parameters.AddWithValue("@" + i, param[i]);
            }
            kmt.ExecuteNonQuery();
        }
        public void Sorgu(string query, MySqlParameter param2, params string[] param)
        {
            kmt.CommandText = query;
            kmt.Parameters.Add(param2);
            for (int i = 0; i < param.Length; i++)
            {
                kmt.Parameters.AddWithValue("@" + i, param[i]);
            }
            kmt.ExecuteNonQuery();
        }
        public void Kapat()
        {
            bag.Close();
        }


    }
}
