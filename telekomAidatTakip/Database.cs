using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telekomAidatTakip
{
    class Database
    {
        SqlConnection bag;
        SqlCommand kmt;
        SqlDataReader data;
        public Database(string connectstring)
        {
            bag = new SqlConnection(connectstring);
            kmt = new SqlCommand();
            kmt.Connection = bag;
            bag.Open();
        }
        public Database()
        {
            bag = new SqlConnection(Program.connectstring);
            kmt = new SqlCommand();
            kmt.Connection = bag;
            bag.Open();
        }
        ~Database()
        {
            bag.Close();
        }
        public SqlDataReader DataOku(string query)
        {
            kmt.CommandText = query;
            data = kmt.ExecuteReader();
            return data;
        }
        public SqlDataReader DataOku(string query, params string[] param)
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
        public void Sorgu(string query, SqlParameter param2, params string[] param)
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
