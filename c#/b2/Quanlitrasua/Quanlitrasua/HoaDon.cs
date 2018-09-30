using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlitrasua
{
    public class HoaDon
    {
        public DateTime Ngay { get; set; }
        public int TongSoTien { get; set; }
        public List<ChiTietHoaDon> DsChiTietHoaDon { get; set; }
    }
}
