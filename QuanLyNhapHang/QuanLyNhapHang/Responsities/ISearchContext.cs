using QuanLyNhapHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyNhapHang.Responsities
{
    public interface ISearchContext
    {
        List<tbMatHangModel> SearchMatHang(string tenhang,int manhanhang,DateTime ngaytao,DateTime ngaycapnhat);

        List<Model.tbPhieuNhapModel> SearchPhieuNhap(DateTime ngaynhap, string mahang, decimal gianhaptu, decimal gianhapden);
    }
}
