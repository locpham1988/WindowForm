

namespace QuanLyNhapHang.Responsities
{
    using Db;
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public sealed class tbPhieuNhapResponsity : IDBActionContext
    {
        private QLNHEntities entites;

        public tbPhieuNhapResponsity():this(new QLNHEntities())
        {

        }
        public tbPhieuNhapResponsity(QLNHEntities _entites)
        {
            entites = _entites;
        }

        public bool Add(object value)
        {
            try
            {
                var insertModel = value as tbPhieuNhapModel;

                var phieunhap = new tbDMPhieuNhap { MaDMPhieuNhap = Guid.NewGuid().ToString(), NgayNhap = DateTime.Now, NgayCapNhat = DateTime.Now };
                phieunhap.TongHoaDon = string.Format("{0}", insertModel.DMMatHangNhap.Sum(n => n.TongTien));
                
                phieunhap.tbPhieuNhaps = insertModel.DMMatHangNhap.Select(n => new tbPhieuNhap
                {
                    MaDVTinh = n.MaDVTinh,
                    MaDMPhieuNhap = phieunhap.MaDMPhieuNhap,
                    MaPhieuNhap=Guid.NewGuid().ToString(),
                    GiaNhap=n.GiaNhap,
                    NgayCapNhat=DateTime.Now,
                    NgayNhap=DateTime.Now,
                    MaMatHang=n.MaMatHang,
                    SoLuong=string.Format("{0}", n.SoLuong),
                    TongHoaDon= string.Format("{0}", n.TongTien),
                    MaNguoiNhap=GlobalContent.CurrentUser
                }).ToList();
                entites.tbDMPhieuNhaps.Add(phieunhap);
                entites.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Delete(object ID)
        {
            throw new NotImplementedException();
        }

        public List<T> GetCollection<T>() where T : class
        {
            var lstResult = new List<T>();
            lstResult = entites.tbDMPhieuNhaps.Select(n => new tbPhieuNhapModel
            {
                DMMatHangNhap=(n.tbPhieuNhaps??new List<tbPhieuNhap>()).Select(m=>new tbMatHangNhapModel
                {
                    GiaNhap = m.GiaNhap,
                    MaDVTinh = m.MaDVTinh.HasValue? m.MaDVTinh.Value:-1,
                    MaMatHang = m.MaMatHang,
                    MaNhanhang = m.tbMatHang.MaNhanHang.Value,
                    SoLuong = Convert.ToInt32(m.SoLuong),
                    TongTien = decimal.Parse(m.TongHoaDon)
                }).ToList(),
                MaPhieuNhap=n.MaDMPhieuNhap,
                NgayCapNhat= n.NgayCapNhat.HasValue?n.NgayCapNhat.Value:new DateTime(),
                NgayNhap= n.NgayNhap.HasValue?n.NgayNhap.Value : new DateTime(),
                TongTien=decimal.Parse(n.TongHoaDon)
            }).ToList() as List<T>;
            return lstResult;
        }

        public T GetObjById<T>(object ID) where T : class
        {
            throw new NotImplementedException();
        }

        public bool Update(object value)
        {
            throw new NotImplementedException();
        }
    }
}
