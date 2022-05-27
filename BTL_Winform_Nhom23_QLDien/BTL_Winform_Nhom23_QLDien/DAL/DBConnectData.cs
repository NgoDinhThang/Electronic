using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnectData
    {
        public static SqlConnection Connect()
        {
            return new SqlConnection(@"Data Source=.;Initial Catalog=Nhom23_QLDIEN;Integrated Security=True");
        }

    }
}
