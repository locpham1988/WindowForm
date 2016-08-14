using QuanLyNhapHang.Db;
using QuanLyNhapHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhapHang.Responsities
{
    public sealed class UserResponsity:IUser
    {
        private QLNHEntities dbEntities;

        
        public UserResponsity(QLNHEntities _entities)
        {
            dbEntities = _entities;
        }
        public UserResponsity(): this(new QLNHEntities())
        {
            
        }

        public UserModel Login(Model.UserModel _User)
        {
            var user = FindUser(_User) as tbUser;
            if (user!=null)
            {
                return new UserModel {
                    UserName=user.Username,
                    FullName=user.Fullname,
                    Role=user.Role
                };
            }
            return null;
        }

        private object FindUser(Model.UserModel _User)
        {
            var user = dbEntities.tbUsers.SingleOrDefault(n => n.Username.Equals(_User.UserName) && n.Password.Equals(_User.Password));
            return user;
        }
        public bool Create(Model.UserModel _User)
        {
            var user = FindUser(_User);
            if (user == null)
            {
                var userEntry=new tbUser {
                    Username=_User.UserName,
                    Password=_User.Password,
                    Fullname=_User.FullName,
                    Role=_User.Role
                };
                dbEntities.tbUsers.Add(userEntry);
                dbEntities.SaveChangesAsync();
                
                return true;
            }
            return false;
        }

        public bool Update(Model.UserModel _User)
        {
            var user = dbEntities.tbUsers.SingleOrDefault(n => n.Username.Equals(_User.UserName));
            if (user!=null)
            {
                user.Fullname = _User.FullName;
                user.Role = _User.Role.ToString();
                user.Password = _User.Password;
                dbEntities.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
