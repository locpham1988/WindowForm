using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhapHang.Model
{
    public class tbMatHangModel
    {

        public string Mahang { get; set; }

        public string Tenhang { get; set; }

        public int MaNhanHang { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public decimal GiaNhap { get; set; }

        public string DVtinh { get; set; }

        public DateTime? NgayNhap { get; set; }

        
    }
}
