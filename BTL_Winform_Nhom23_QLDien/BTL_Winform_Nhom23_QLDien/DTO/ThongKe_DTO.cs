using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKe_DTO
    {
        private string maKH;
        private string maThang;
        private string maHD;
        private bool payment;

        public string MaKH { get => maKH; set => maKH = value; }
        public string MaThang { get => maThang; set => maThang = value; }
        public string MaHD { get => maHD; set => maHD = value; }
        public bool Payment { get => payment; set => payment = value; }
    }
}
