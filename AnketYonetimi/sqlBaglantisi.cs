using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketYonetimi
{
    class sqlBaglantisi
    {
        public  SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UN9NE1J\SQLEXPRESS;Initial Catalog=anketDeneme1;Integrated Security=True");
    }

}
