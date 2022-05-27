using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThietBi_DTO
    {
        private string maThietBi;
        private string tenThietBi;
        private int gia;

        public string MaThietBi { get => maThietBi; set => maThietBi = value; }
        public string TenThietBi { get => tenThietBi; set => tenThietBi = value; }
        public int Gia { get => gia; set => gia = value; }
    }
}
