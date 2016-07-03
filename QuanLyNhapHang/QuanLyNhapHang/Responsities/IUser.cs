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
        bool Login(User User);
        bool Create(User User);
        bool Update(User user);
    }
}
