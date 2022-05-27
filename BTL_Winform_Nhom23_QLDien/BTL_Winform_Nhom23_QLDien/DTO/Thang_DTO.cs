using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thang_DTO
    {
        private string maThang;
        private string tenThang;

        public string MaThang { get => maThang; set => maThang = value; }
        public string TenThang { get => tenThang; set => tenThang = value; }
    }
}
