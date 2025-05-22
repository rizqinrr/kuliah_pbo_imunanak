using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using imun_anak_pbo.config;

namespace imun_anak_pbo.model
{
    class Catatan_imunisasi_cls
    {

        private string _anak_id;
        private string _imunisasi_id;
        private string _bidan_id;
        private DateTime _tanggal_imunisasi;
        private string _keterangan;

        connectDB server;
        string Query;

        public Catatan_imunisasi_cls(){
            _anak_id = "";
            _imunisasi_id = "";
            _bidan_id = "";
            _tanggal_imunisasi = DateTime.Now;
            _keterangan = "";
            server = new connectDB();
            Query = "";
        }

        public string anak_id
        {
            get { return _anak_id; } 
            set { _anak_id = value; }
        }

        public string imunisasi_id
        {
            get { return _imunisasi_id; } 
            set { _imunisasi_id = value; }
        }

        public string bidan_id
        {
            get { return _bidan_id; }  
            set { _bidan_id = value; }  
        }
        
        public DateTime tanggal_imunisasi
        {
            get { return _tanggal_imunisasi; }
            set { _tanggal_imunisasi= value; }
        }


        public string keterangan
        {
            get { return _keterangan; }
            set { _keterangan = value; }
        }

        public bool cekID(string id)
        {
            bool cek = false;

            Query = "select * from catatan_imunisasi where catatan_id = '" + id + "'";
            if (server.eksekusiQuery(Query).Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public DataTable tampilsemua()
        {
            Query = "select * from catatan_imunisasi";
            return server.eksekusiQuery(Query);

        }

        public DataTable tampilDataGabungan()
        {
            Query = @"SELECT 
                c.catatan_id,
                a.nama AS nama_anak,
                i.nama_imunisasi,
                b.nama_bidan,
                c.tanggal_imunisasi,
                c.keterangan
              FROM catatan_imunisasi c
              JOIN anak a ON c.anak_id = a.anak_id
              JOIN imunisasi i ON c.imunisasi_id = i.imunisasi_id
              JOIN bidan b ON c.bidan_id = b.bidan_id";

            return server.eksekusiQuery(Query);
        }


        public bool simpanCatatan()
        {
            try
            {
                Query = "INSERT INTO catatan_imunisasi " +
                        "(anak_id, bidan_id, imunisasi_id, tanggal_imunisasi, keterangan) " +
                        "VALUES ('" + _anak_id + "', '" + _bidan_id + "', '" + _imunisasi_id + "', '" + _tanggal_imunisasi.ToString("yyyy-MM-dd") + "', '" + _keterangan + "')";

                return server.eksekusiNonQuery(Query) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Query gagal: " + ex.Message);
            }
        }


    }
}
