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
    public class TaiKhoan_BUS
    {
        TaiKhoan_DAL taiKhoanDAL = new TaiKhoan_DAL();
        public bool getTaiKhoan(TaiKhoan_DTO tk)
        {
            return taiKhoanDAL.getTK(tk);
        }
        public string getQuyen(TaiKhoan_DTO tk)
        {
            return taiKhoanDAL.getQuyen(tk);
        }
        public DataTable AdminLoad()
        {
            return taiKhoanDAL.AdminLoad();
        }
        public bool insertTK(TaiKhoan_DTO tk)
        {
            return taiKhoanDAL.insertTK(tk);
        }
        public bool updateTK(TaiKhoan_DTO tk)
        {
            return taiKhoanDAL.updateTK(tk);
        }
        public bool deleteTK(string tenTK)
        {
            return taiKhoanDAL.deleteTK(tenTK);
        }
        public bool DangKiAdmin(TaiKhoan_DTO tk)
        {
            return taiKhoanDAL.DangKiAdmin(tk);
        }
    }
}
