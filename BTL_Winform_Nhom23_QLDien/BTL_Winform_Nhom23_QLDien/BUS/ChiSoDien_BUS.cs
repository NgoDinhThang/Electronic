using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class ChiSoDien_BUS
    {
        ChiSoDien_DAL ChiSoDienDAL = new ChiSoDien_DAL();
        public DataTable loadChiSoDien()
        {
            return ChiSoDienDAL.getData();
        }
        public bool insertChiSoDien(ChiSoDien_DTO csd)
        {
            return ChiSoDienDAL.insertCSD(csd);
        }
        public DataTable loadCbbThang()
        {
            return ChiSoDienDAL.loadCbbMT();
        }
        public bool updateChiSoDien(ChiSoDien_DTO csd)
        {
            return ChiSoDienDAL.updateCSD(csd);
        }
        public bool deleteChiSoDien(string maKH, string maThang)
        {
            return ChiSoDienDAL.deleteCSD(maKH,maThang);
        }
        public void createHoaDon_ThongKe(string makh)
        {
            ChiSoDienDAL.createHD_TK(makh);
        }
        public DataTable searchChiSoDien(string search)
        {
            return ChiSoDienDAL.searchCSD(search);
        }
        public bool KtraCSD(string maKH, string maThang)
        {
            return ChiSoDienDAL.KtraCSD(maKH, maThang);
        }
    }
}
