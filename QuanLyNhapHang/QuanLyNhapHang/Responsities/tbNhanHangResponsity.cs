using QuanLyNhapHang.Db;
using QuanLyNhapHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhapHang.Responsities
{
    public class tbNhanHangResponsity:IDBActionContext
    {
        

        public tbNhanHangResponsity()
        {

        }
        bool IDBActionContext.Add(object value)
        {
            using (QLNHEntities entites = new QLNHEntities())
            {
                try
                {
                    tbNhanHangModel _tbNhanhang = value as tbNhanHangModel;
                    if (_tbNhanhang != null)
                    {
                        entites.tbNhanHangs.Add(new tbNhanHang { TenNhanHang = _tbNhanhang.Name });
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
                    int _ID = 0;
                    if (int.TryParse(ID.ToString(), out _ID))
                    {
                        var obj = entites.tbNhanHangs.SingleOrDefault(n => n.Id.Equals(_ID));
                        if (obj!=null)
                        {
                            entites.tbNhanHangs.Remove(obj);
                        }
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

        bool IDBActionContext.Update(object value)
        {
            using (QLNHEntities entites = new QLNHEntities())
            {
                try
                {
                    
                    var tbNhanHanghobj = value as tbNhanHangModel;
                    if (tbNhanHanghobj != null)
                    {
                        var obj = entites.tbNhanHangs.SingleOrDefault(n => n.Id.Equals(tbNhanHanghobj.ID));
                        if (obj != null)
                        {
                            obj.TenNhanHang = tbNhanHanghobj.Name;
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
            T result=null;
            using (QLNHEntities entites = new QLNHEntities())
            {
                try
                {
                    int _ID = 0;
                    if (int.TryParse(ID.ToString(), out _ID))
                    {
                        var obj = entites.tbNhanHangs.SingleOrDefault(n => n.Id.Equals(_ID));
                        if (obj != null)
                        {
                            result = obj as T;
                        }

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
            var lstResult = new List<T>();
            using (QLNHEntities entites = new QLNHEntities())
            {
                try
                {
                    lstResult =entites.tbNhanHangs.Select(n=>new tbNhanHangModel{
                        ID=n.Id, Name=n.TenNhanHang
                    }).ToList() as List<T>;
                }
                catch (Exception)
                {

                }
            }
            return lstResult;
        }
    }
}
