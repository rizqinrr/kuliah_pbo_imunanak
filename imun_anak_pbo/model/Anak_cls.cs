using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using imun_anak_pbo.config;

namespace imun_anak_pbo.model
{
    class Anak_cls
    {
        private string _nama;
        private string _tanggal_lahir;
        private string _jenis_kelamin;  
        private string _nama_orangtua;

        connectDB server;
        string Query;

        public Anak_cls()
        {
            _nama = "";
            _tanggal_lahir = "";
            _jenis_kelamin = "";
            _nama_orangtua = "";
            server = new connectDB();
            Query = "";

        }

        public DataTable tampilAnak()
        {
            Query = "select * from anak";
            return server.eksekusiQuery(Query);

        }

        public DataTable tampilNamaAnak()
        {
            Query = "SELECT nama FROM anak";
            return server.eksekusiQuery(Query);
        }

        public string ambilNamaAnak(string nm)
        {
            string id = "";
            Query = "SELECT anak_id FROM anak WHERE nama = '" + nm + "'";
            DataTable data = server.eksekusiQuery(Query);

            if (data.Rows.Count > 0)
            {
                id = data.Rows[0]["anak_id"].ToString();
            }

            return id;
        }


    }
}
