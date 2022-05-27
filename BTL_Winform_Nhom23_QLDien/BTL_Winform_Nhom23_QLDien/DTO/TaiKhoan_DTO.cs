using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        private string tai_khoan;
        private string mat_khau;
        private string quyen;

        public string Tai_khoan { get => tai_khoan; set => tai_khoan = value; }
        public string Mat_khau { get => mat_khau; set => mat_khau = value; }
        public string Quyen { get => quyen; set => quyen = value; }
    }
}
