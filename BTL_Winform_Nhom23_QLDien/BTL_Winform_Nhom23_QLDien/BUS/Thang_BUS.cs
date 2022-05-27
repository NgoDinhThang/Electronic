using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class Thang_BUS
    {
        Thang_DAL ThangDAL = new Thang_DAL();
        public DataTable getDaTa()
        {
            return ThangDAL.getDaTa();
        }
        public bool insertThang(Thang_DTO thang)
        {
            return ThangDAL.insertThang(thang);
        }
        public bool updateThang(Thang_DTO thang)
        {
            return ThangDAL.updateThang(thang);
        }
        public bool deleteThang(string maThang)
        {
            return ThangDAL.deleteThang(maThang);
        }
        public bool KtraThang(string mathang)
        {
            return ThangDAL.KtraThang(mathang);
        }
        public DataTable searchThang(string maThang)
        {
            return ThangDAL.searchThang(maThang);
        }
    }
}
