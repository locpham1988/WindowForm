

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
    public partial class frmSearchPhieuNhap : Form
    {
        private IDBActionContext dbMatHangcontext;
        private IDBActionContext dbNhanHangcontext;
        private IDBActionContext dbDVTinhcontext;
        public frmSearchPhieuNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
