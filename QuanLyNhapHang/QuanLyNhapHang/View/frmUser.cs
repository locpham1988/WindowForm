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
    public partial class frmUser : Form
    {
        private IUser _IUser;
        public frmUser()
        {
            InitializeComponent();
            _IUser = new UserResponsity() ;
            List<string> lstRole = new List<string>() {"Admin","General","Editor" };
            cboLoaiNguoiDung.DataSource = lstRole;
            
        }
        
       
       
       

        private bool valid()
        {
            if (!string.IsNullOrEmpty(this.txtUserName.Text.Trim())
                && !string.IsNullOrEmpty(this.txtPassword.Text.Trim())
                && !string.IsNullOrEmpty(this.txtFullName.Text.Trim()))
            {
                return true;
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (valid()==true)
            {
               
                _IUser.Create(new Model.User { 
                    UserName = this.txtUserName.Text.Trim(),
                    Password = this.txtPassword.Text.Trim().Encrypt(),
                    FullName = this.txtFullName.Text.Trim(),
                    Role=this.cboLoaiNguoiDung.SelectedValue.ToString()
                });
                new frmLogin().Show();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {

        }
    }
}
