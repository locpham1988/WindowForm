using QuanLyNhapHang.Db;
using QuanLyNhapHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhapHang.Responsities
{
    public sealed class DVTinhResponsity : IDBActionContext
    {
        private QLNHEntities entites;

        public DVTinhResponsity(QLNHEntities entites)
        {
            this.entites = entites;
        }
        
        public DVTinhResponsity():this(new QLNHEntities())
        {
            
        }
        bool IDBActionContext.Add(object value)
        {
            try
            {
                
                DVTinhModel _DVTinh = value as DVTinhModel;
                if (_DVTinh != null)
                {
                    entites.DVTinhs.Add(new DVTinh { TenDVTinh = _DVTinh.Name });
                    entites.SaveChanges();

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
            return true;
        }




        bool IDBActionContext.Delete(object ID)
        {
            try
            {
                
                int dvID = 0;
                if (int.TryParse(ID.ToString(), out dvID))
                {
                    var obj = entites.DVTinhs.SingleOrDefault(n => n.Id.Equals(dvID));
                    if (obj != null)
                    {
                        entites.DVTinhs.Remove(obj);
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
            return true;
        }

        bool IDBActionContext.Update(object value)
        {
            try
            {
                var dvTinhobj = value as DVTinhModel;
                if (dvTinhobj != null)
                {
                    var dvTinh = entites.DVTinhs.SingleOrDefault(n => n.Id.Equals(dvTinhobj.ID));
                    dvTinh.TenDVTinh = dvTinhobj.Name;
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
            return true;
        }


        T IDBActionContext.GetObjById<T>(object ID)
        {
            T result = null;
            try
            {
                int _ID = 0;
                if (int.TryParse(ID.ToString(), out _ID))
                {
                    entites.Database.Connection.Open();
                    var obj = entites.DVTinhs.SingleOrDefault(n => n.Id.Equals(_ID));
                    if (obj != null)
                    {
                        result = obj as T;
                    }
                    entites.Database.Connection.Close();
                }
            }
            catch (Exception)
            {

            }
            return result;
        }

        List<T> IDBActionContext.GetCollection<T>()
        {
            var lstResult = new List<T>();
            try
            {
                
                lstResult = entites.DVTinhs.Select(n => new DVTinhModel
                {
                    ID = n.Id,
                    Name = n.TenDVTinh
                }).ToList() as List<T>;
                
            }
            catch (Exception)
            {

            }
            return lstResult;
        }
    }
}
