using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class HoaDon_BUS
    {
        HoaDon_DAL hoaDonDAL = new HoaDon_DAL();
        public DataTable getData()
        {
            return hoaDonDAL.getData();
        }
        public bool getThanhToan(string maHD)
        {
            return hoaDonDAL.getThanhToan(maHD);
        }
        public DataTable searchMaHD(string search)
        {
            return hoaDonDAL.searchMaHD(search);
        }
        public DataTable searchMaKH(string search)
        {
            return hoaDonDAL.searchMaKH(search);
        }
    }
}
