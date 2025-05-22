using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using imun_anak_pbo.config;

namespace imun_anak_pbo.model
{
    class Bidan_cls
    {
        private string _kode_bidan;
        private string _nama_bidan;
        private string _no_telepon;

        connectDB server;
        string Query;

        public Bidan_cls()
        {
            _kode_bidan = "";
            _nama_bidan = "";
            _no_telepon = "";
            server = new connectDB();
            Query = "";

        }

        //Methode untuk ambil dan ubah sesuai kolom
        public string kode_bidan
        {
            get { return _kode_bidan; }   // ambil data petugas pakai nama petugas
            set { _kode_bidan = value; }  //ubah data petugas pakai nama petugas

        }

        public string nama_bidan
        {
            set { _nama_bidan = value; }
        }

        public string no_telepon
        {
            set { _no_telepon = value; }
        }

        public bool cekKodeBidan(string kode_bidan)
        {
            bool cek = false;

            Query = "select * from bidan where kode_bidan = '" + kode_bidan + "'";
            if (server.eksekusiQuery(Query).Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public bool simpanBidan()
        {
            bool cek = false;
            Query = "INSERT INTO bidan (kode_bidan, nama_bidan, no_telepon) VALUES ('" + _kode_bidan + "', '" + _nama_bidan + "', '" + _no_telepon + "' )";
            if (server.eksekusiNonQuery(Query) > 0)
            {
                cek = true;
            }
            return cek;
        }

        public DataTable tampilsemua()
        {
            Query = "select kode_bidan, nama_bidan, no_telepon from bidan";
            return server.eksekusiQuery(Query);

        }


        //MENCOBA
        public bool hapusBidan(string kode_bidan)
        {
            string query = $"DELETE FROM bidan WHERE kode_bidan = '{kode_bidan}'";
            return server.eksekusiNonQuery(query) > 0;
        }

        public string ambilNamaBidan(string id)
        {
            string nama = "";
            DataTable data = new DataTable();

            Query = "select nama_bidan from bidan where bidan_id='" + id + "'";
            data = server.eksekusiQuery(Query);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dt in data.Rows)
                {
                    nama = dt[0].ToString();
                }
            }

            return nama;
        }

        public string ambilIdBidan(string nama)
        {
            string id = "";
            Query = "SELECT bidan_id FROM bidan WHERE nama_bidan = '" + nama + "'";
            DataTable data = server.eksekusiQuery(Query);

            if (data.Rows.Count > 0)
            {
                id = data.Rows[0]["bidan_id"].ToString();
            }

            return id;
        }

    }
}
