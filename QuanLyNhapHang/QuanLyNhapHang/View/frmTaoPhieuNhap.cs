

namespace QuanLyNhapHang.View
{
    using QuanLyNhapHang.Model;
    using QuanLyNhapHang.Responsities;
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using QuanLyNhapHang.Helper;
    using System.ComponentModel;
    using System.Collections.Generic;
    public partial class frmTaoPhieuNhap : Form
    {
        private IBindingList dmMatHangNhap;
        public frmTaoPhieuNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CloseTabForm();
        }

        private void dtpsNgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {

        }

        private void frmTaoPhieuNhap_Load(object sender, EventArgs e)
        {
            dmMatHangNhap = new BindingList<tbMatHangNhapModel>();
            
        }
    }
}
