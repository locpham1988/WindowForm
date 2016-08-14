using QuanLyNhapHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhapHang.Responsities
{
    public interface IUser
    {
        UserModel Login(UserModel User);
        bool Create(UserModel User);
        bool Update(UserModel user);
        
    }
}
