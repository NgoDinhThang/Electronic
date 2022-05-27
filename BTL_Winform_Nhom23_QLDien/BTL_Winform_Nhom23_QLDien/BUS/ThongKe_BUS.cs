using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class ThongKe_BUS
    {
        ThongKe_DAL ThongKeDAL = new ThongKe_DAL();
        public DataTable getKHDaNop()
        {
            return ThongKeDAL.getKHDaTT();
        }
        public DataTable getKHChuaNop()
        {
            return ThongKeDAL.getKHChuaTT();
        }
    }
}
