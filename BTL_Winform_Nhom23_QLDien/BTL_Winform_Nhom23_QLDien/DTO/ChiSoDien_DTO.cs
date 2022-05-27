using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiSoDien_DTO
    {
        private string maKH;
        private string maThang;
        private int chisocu;
        private int chisomoi;

        public string MaKH
        { get => maKH; set => maKH = value; }
        public string MaThang { get => maThang; set => maThang = value; }
        public int Chisocu { get => chisocu; set => chisocu = value; }
        public int Chisomoi { get => chisomoi; set => chisomoi = value; }
    }
}
