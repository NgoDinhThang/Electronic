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
    public class HoTieuThu_BUS
    {
        HoTieuThu_DAL HoTieuThuDAL = new HoTieuThu_DAL();
        public DataTable loadHoTieuThu()
        {
            return HoTieuThuDAL.getData();
        }
        public bool insertHoTieuThu(HoTieuThu_DTO htt)
        {
            return HoTieuThuDAL.insertHTT(htt);
        }
        public bool updateHoTieuThu(HoTieuThu_DTO htt)
        {
            return HoTieuThuDAL.updateHTT(htt);
        }
        public bool deleteHoTieuThu(string maKH)
        {
            return HoTieuThuDAL.deleteHTT(maKH);
        }
        public DataTable searchMaKH(string search)
        {
            return HoTieuThuDAL.searchMaKH(search);
        }
        public DataTable searchTenKH(string search)
        {
            return HoTieuThuDAL.searchTenKH(search);
        }
        public DataTable searchDiaChi(string search)
        {
            return HoTieuThuDAL.searchDC(search);
        }
    }
}
