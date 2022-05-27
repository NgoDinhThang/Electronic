using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoTieuThu_DTO
    {
        private string maKH;
        private string hoTen;
        private string cmnd;
        private string diaChi;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string sdt;
        private DateTime ngayDangKi;
        private string loaiDien;

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public DateTime NgayDangKi { get => ngayDangKi; set => ngayDangKi = value; }
        public string LoaiDien { get => loaiDien; set => loaiDien = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}
