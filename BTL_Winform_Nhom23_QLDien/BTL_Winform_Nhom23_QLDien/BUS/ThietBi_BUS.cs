using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class ThietBi_BUS
    {
        ThietBi_DAL ThietBiDAL = new ThietBi_DAL();
        public DataTable getDaTa()
        {
            return ThietBiDAL.getDaTa();
        }
        public bool insertThietBi(ThietBi_DTO tb)
        {
            return ThietBiDAL.insertTB(tb);
        }
        public bool updateThietBi(ThietBi_DTO tb)
        {
            return ThietBiDAL.updateTB(tb);
        }
        public bool deleteThietBi(string maTB)
        {
            return ThietBiDAL.deleteTB(maTB);
        }
        public DataTable searchTB(string search)
        {
            return ThietBiDAL.searchTB(search);
        }
    }
}
