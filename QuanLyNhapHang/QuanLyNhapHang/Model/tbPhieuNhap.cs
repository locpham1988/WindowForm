using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhapHang.Model
{
    public class tbPhieuNhapModel
    {
        public string MaPhieuNhap { get; set; }

        public decimal TongTien { get; set; }

        public DateTime NgayNhap { get; set; }

        public DateTime NgayCapNhat { get; set; }
    }
}
