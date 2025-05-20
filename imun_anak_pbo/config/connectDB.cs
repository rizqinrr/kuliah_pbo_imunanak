using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace imun_anak_pbo.config
{
    class connectDB: services
    {
        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataAdapter adapter;

        string strCon = "server=localhost; port=3306; database=imun_anak_pbo; uid=root; pwd=";

        public connectDB()
        {
            conn = new MySqlConnection(strCon);
            comm = new MySqlCommand();
            adapter = new MySqlDataAdapter();
        }

        void bukaKoneksi()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception e) { }
        }
        void tutupKoneksi()
        {
            conn.Close();
        }
        public override int eksekusiNonQuery(string query)
        {
            int kembali = -1;
            try
            {
                bukaKoneksi();
                comm.Connection = conn;
                comm.CommandText = query;
                kembali = comm.ExecuteNonQuery();
            }
            catch (Exception e) { }
            finally
            {
                tutupKoneksi();
            }

            return kembali;
        }

        public override DataTable eksekusiQuery(string query)
        {
            DataTable kembali = new DataTable();
            try
            {
                bukaKoneksi();
                comm.Connection = conn;
                comm.CommandText = query;
                adapter.SelectCommand = comm;
                adapter.Fill(kembali);
            }
            catch (Exception e) { }
            finally
            {
                tutupKoneksi();
            }

            return kembali;
        }
    }

    
}
