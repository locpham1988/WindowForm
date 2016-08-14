
namespace QuanLyNhapHang.View
{
    using QuanLyNhapHang.Model;
    using QuanLyNhapHang.Responsities;
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using QuanLyNhapHang.Helper;
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.CloseTabForm();
        }
    }
}
