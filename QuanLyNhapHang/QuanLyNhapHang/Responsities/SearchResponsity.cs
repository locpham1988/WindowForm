using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhapHang.Db;
using QuanLyNhapHang.Model;

namespace QuanLyNhapHang.Responsities
{
    public sealed class SearchResponsity:ISearchContext
    {
        List<tbMatHangModel> ISearchContext.SearchMatHang(string tenhang, int manhanhang, DateTime ngaytao, DateTime ngaycapnhat)
        {
            var lstResult = new List<tbMatHangModel>();
            using (QLNHEntities entites = new QLNHEntities())
            {
                try
                {
                    lstResult = entites.tbMatHangs.Where(h => 
                        h.TenHang.ToLower().Contains(tenhang.ToLower()) 
                        || h.MaNhanHang.Equals(manhanhang)
                        || h.Created.Equals(ngaytao) || h.Updated.Equals(ngaycapnhat)).Select(obj => new tbMatHangModel {
                            Mahang = obj.MaHang,
                            Tenhang = obj.TenHang,
                            MaNhanHang = obj.MaNhanHang ?? -1,
                            Created = obj.Created ?? new DateTime(1900, 01, 01),
                            Updated = obj.Updated ?? new DateTime(1900, 01, 01)
                    }).ToList();
                }
                catch (Exception)
                {
                }
            }
            return lstResult;
        }

        List<Model.tbPhieuNhapModel> ISearchContext.SearchPhieuNhap(DateTime ngaynhap,string mahang, decimal gianhaptu,decimal gianhapden)
        {
            List<Model.tbPhieuNhapModel> lstresult = new List<tbPhieuNhapModel>();

            return lstresult;
        }
    }
}
