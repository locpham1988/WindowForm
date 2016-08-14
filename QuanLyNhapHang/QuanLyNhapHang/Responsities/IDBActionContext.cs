using QuanLyNhapHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhapHang.Responsities
{
    public interface IDBActionContext
    {
        bool Add(object value);
        bool Delete(object ID);
        bool Update(object value);
        T GetObjById<T>(object ID) where T : class;
        List<T> GetCollection<T>() where T : class; 
    }
}
