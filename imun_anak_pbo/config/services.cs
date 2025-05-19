using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imun_anak_pbo.config
{
    abstract class services
    {
        //untuk menangani insert, update, delete
        public abstract int eksekusiNonQuery(string query);

        //untuk menangani select
        public abstract DataTable eksekusiQuery(string query);
    }
}
