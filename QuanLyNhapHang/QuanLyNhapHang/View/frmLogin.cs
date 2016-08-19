using QuanLyNhapHang.Responsities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhapHang.Helper;
using QuanLyNhapHang.Model;

namespace QuanLyNhapHang.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            _IUser = new UserResponsity();
        }
        
        private IUser _IUser;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (valid()==true)
            {
                var userLogin = _IUser.Login(new Model.UserModel { UserName = txtUserName.Text.Trim(), Password = txtPassword.Text.Trim().Encrypt() });
                if (userLogin!=null)
                {
                    frmMain main = new frmMain();
                    main.Show();
                    main.SetUserInfo(userLogin);
                    GlobalContent.CurrentUser = userLogin.UserName;
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool valid()
        {
            if (!string.IsNullOrEmpty(this.txtUserName.Text.Trim()) && !string.IsNullOrEmpty(this.txtPassword.Text.Trim()))
            {
                return true;
            }
            return false;
        }
    }
}
