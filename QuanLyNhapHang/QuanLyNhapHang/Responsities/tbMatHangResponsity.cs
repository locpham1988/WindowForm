using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhapHang.Model;
using QuanLyNhapHang.Responsities;
using QuanLyNhapHang.Db;

namespace QuanLyNhapHang.Responsities
{
    public sealed class tbMatHangResponsity : IDBActionContext
    {

        public tbMatHangResponsity()
        {

        }
        bool IDBActionContext.Add(object value)
        {
            using (QLNHEntities entites = new QLNHEntities())
            {
                try
                {
                    tbMatHangModel mathang = value as tbMatHangModel;
                    if (mathang != null)
                    {
                        var id = Guid.NewGuid();
                        entites.tbMatHangs.Add(new tbMatHang
                        {
                            Created = DateTime.Now,
                            MaHang = id.ToString(),
                            MaNhanHang = mathang.MaNhanHang,
                            TenHang = mathang.Tenhang,
                            Updated = DateTime.Now
                        });
                        entites.SaveChangesAsync();
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }

        bool IDBActionContext.Delete(object ID)
        {
            using (QLNHEntities entites = new QLNHEntities())
            {
                try
                {
                    var obj = entites.tbMatHangs.SingleOrDefault(n => n.MaHang.Equals(ID));
                    if (obj != null)
                    {
                        entites.tbMatHangs.Remove(obj);
                    }
                    entites.SaveChangesAsync();
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }

        bool IDBActionContext.Update(object value)
        {
            using (QLNHEntities entites = new QLNHEntities())
            {
                try
                {

                    var mathang = value as tbMatHangModel;
                    if (mathang != null)
                    {
                        var obj = entites.tbMatHangs.SingleOrDefault(n => n.MaHang.Equals(mathang.Mahang));
                        if (obj != null)
                        {
                            obj.TenHang = mathang.Tenhang;
                            obj.MaNhanHang = mathang.MaNhanHang;
                            obj.Updated = DateTime.Now;

                            entites.SaveChangesAsync();
                        }

                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }

        T IDBActionContext.GetObjById<T>(object ID)
        {
            T result = null;
            using (QLNHEntities entites = new QLNHEntities())
            {
                try
                {
                    var obj = entites.tbMatHangs.SingleOrDefault(n => n.MaHang.Equals((string)ID));
                    if (obj != null)
                    {
                        DateTime? ngayNhap = null;
                        decimal gianhap = 0;
                        string dvTinh = string.Empty;
                        GetThongTinGiaNhap(obj, out gianhap, out ngayNhap, out dvTinh);
                        var tempresult = new tbMatHangModel
                        {
                            Mahang = obj.MaHang,
                            Tenhang = obj.TenHang,
                            MaNhanHang = obj.MaNhanHang ?? -1,
                            Created = obj.Created ?? new DateTime(1900, 01, 01),
                            Updated = obj.Updated ?? new DateTime(1900, 01, 01),
                            GiaNhap = gianhap,
                            DVtinh = dvTinh,
                            NgayNhap = ngayNhap
                        };

                        result = tempresult as T;
                    }
                }
                catch (Exception)
                {

                }
            }
            return result;
        }

        List<T> IDBActionContext.GetCollection<T>()
        {
            List<T> lstresult = new List<T>();
            try
            {
                using (var entity = new QLNHEntities())
                {

                    if (entity.tbMatHangs != null && entity.tbMatHangs.Count() > 0)
                    {

                        var lstMatHang = new List<tbMatHangModel>();
                        foreach (var item in entity.tbMatHangs)
                        {
                            DateTime? ngayNhap = null;
                            decimal gianhap = 0;
                            string dvTinh = string.Empty;
                            GetThongTinGiaNhap(item, out gianhap, out ngayNhap, out dvTinh);
                            var mhItem = new tbMatHangModel
                            {
                                Mahang = item.MaHang,
                                Tenhang = item.TenHang,
                                MaNhanHang = item.MaNhanHang ?? -1,
                                Created = item.Created ?? new DateTime(1900, 01, 01),
                                Updated = item.Updated ?? new DateTime(1900, 01, 01),
                                GiaNhap = gianhap,
                                NgayNhap = ngayNhap
                            };
                            lstMatHang.Add(mhItem);
                        }
                        lstresult = lstMatHang as List<T>;
                    }
                }
            }
            catch (Exception ex)
            {
                var mess = ex.ToString();
            }
            return lstresult;
        }

        private void GetThongTinGiaNhap(tbMatHang item, out decimal gianhap, out DateTime? ngayNhap, out string dvTinh)
        {
            gianhap = 0;
            ngayNhap = null;
            dvTinh = string.Empty;
            if (item.tbPhieuNhaps != null && item.tbPhieuNhaps.Count > 0)
            {
                var last = item.tbPhieuNhaps.OrderByDescending(p => p.NgayCapNhat).FirstOrDefault();
                if (last != null)
                {
                    gianhap = last.GiaNhap;
                    dvTinh = last.DVTinh.TenDVTinh;
                    ngayNhap = last.NgayCapNhat ;
                }
            }
        }
    }
}
