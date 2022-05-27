using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        private string maHD;
        private string maKH;
        private string maThang;
        private string ldtt;
        private long tien;

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaThang { get => maThang; set => maThang = value; }
        public string Ldtt { get => ldtt; set => ldtt = value; }
        public long Tien { get => tien; set => tien = value; }
    }
}
