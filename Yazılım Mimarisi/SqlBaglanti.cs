using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Yazılım_Mimarisi
{
    public class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H17AOV5\\SQLEXPRESS;Initial Catalog=MimariTasarim;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
