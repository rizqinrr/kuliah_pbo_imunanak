using System;
using System.Collections.Generic;
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
        private string _petugas_id;
        private DateTime _tanggal_imunisasi;
        private string _keterangan;

        connectDB server;
        string Query;

        public Catatan_imunisasi_cls(){
            _anak_id = "";
            _imunisasi_id = "";
            _petugas_id = "";
            _tanggal_imunisasi = DateTime.Now;
            _keterangan = "";
            server = new connectDB();
            Query = "";
        }

        public string anak_id
        {
            set { _anak_id = value; }
        }

        public string imunisasi_id
        {
            set { _imunisasi_id = value; }
        }

        public string petugas_id
        {
            set { _petugas_id = value; }
        }

        public DateTime tanggal_imunisasi
        {
            get { return _tanggal_imunisasi; }
        }

        public bool simpanCatatan()
        {
            bool cek = true;
            Query = "insert into catatan_imunisasi values('" + _anak_id + "','" + _petugas_id + "','" + _imunisasi_id + "','" + _tanggal_imunisasi + "','" + _keterangan + "')";

            if (!(server.eksekusiNonQuery(Query) > 0))
            {
                //throw new Exception("Gagal menyimpan data");
                cek = false;
            }

            return cek;
        }
    }
}
