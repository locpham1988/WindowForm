

namespace QuanLyNhapHang.Responsities
{
    using Db;
    using Model;
    using System;
    using System.Collections.Generic;
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

                var phieunhap = new tbDMPhieuNhap { MaPhieuNhap = Guid.NewGuid().ToString(), NgayNhap = DateTime.Now, NgayCapNhat = DateTime.Now };
                
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
            throw new NotImplementedException();
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
