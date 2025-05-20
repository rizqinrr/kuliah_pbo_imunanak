using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using imun_anak_pbo.config;

namespace imun_anak_pbo.model
{
    class Imunisasi_cls
    {
        private string _imunisasi_id;
        private string _nama_imunisasi;
        private string _deskripsi;
        private string _usia_anak;

        connectDB server;
        string Query;

        public Imunisasi_cls()
        {
            _imunisasi_id = "";
            _nama_imunisasi = "";
            _deskripsi = "";
            _usia_anak = "";
            server = new connectDB();
            Query = "";

        }

        //Methode untuk ambil dan ubah sesuai kolom
        public string nama_imunisasi
        {
            get { return _nama_imunisasi; }   // ambil data petugas pakai nama petugas
            set { _nama_imunisasi = value; }  //ubah data petugas pakai nama petugas

        }

        public string imunisasi_id
        {
            set { _imunisasi_id = value; }
        }

        public string deskripsi
        {
            set { _deskripsi = value; }
        }

        public string usia_anak
        {
            set { _usia_anak = value; }
        }

        public bool cekImun(string nama_imun)
        {
            bool cek = false;

            Query = "select * from bidan where nama_imunisasi = '" + nama_imun + "'";
            if (server.eksekusiQuery(Query).Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public bool simpanImun()
        {
            bool cek = false;
            Query = "INSERT INTO imunisasi (nama_imunisasi, deskripsi, usia_anak) VALUES ('" + _nama_imunisasi + "', '" + _deskripsi + "', '" + _usia_anak + "' )";
            if (server.eksekusiNonQuery(Query) > 0)
            {
                cek = true;
            }
            return cek;
        }

        public DataTable tampilsemua()
        {
            Query = "select imunisasi_id, nama_imunisasi, deskripsi, usia_anak from imunisasi";
            return server.eksekusiQuery(Query);

        }
        public bool cekID(string id)
        {
            bool cek = false;

            Query = "select * from imunisasi where imunisasi_id = '" + id + "'";
            if (server.eksekusiQuery(Query).Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        //MENCOBA
        public bool hapusImun(string imunisasi_id)
        {
            string query = $"DELETE FROM imunisasi WHERE imunisasi_id = '{imunisasi_id}'";
            return server.eksekusiNonQuery(query) > 0;
        }

        public bool ubahImun(string id)
        {
            bool cek = true;
            Query = "update imunisasi set nama_imunisasi='" + _nama_imunisasi + "', deskripsi='" + _deskripsi + "' , usia_anak='" + _usia_anak + "'where imunisasi_id='" + id + "'";

            if (!(server.eksekusiNonQuery(Query) > 0))
            {
                //throw new Exception("Gagal menyimpan data");
                cek = false;
            }
            return cek;
        }

        public DataTable cariImun(string nama)
        {
            Query = "select * from imunisasi where nama_imunisasi like '" + nama + "%'";
            return server.eksekusiQuery(Query);
        }
    }
}
