
namespace QuanLyNhapHang.View
{
    using QuanLyNhapHang.Model;
    using QuanLyNhapHang.Responsities;
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using QuanLyNhapHang.Helper;
    using System.ComponentModel;

    public partial class frmPhieuNhap : Form
    {
        private IDBActionContext dbMatHangcontext;
        private IDBActionContext dbDVTinhcontext;
        private IDBActionContext dbNhanHangcontext;
        private IDBActionContext dbDMPhieuNhapcontext;
        public frmPhieuNhap()
        {
            InitializeComponent();
            dbMatHangcontext = new tbMatHangResponsity();
            dbDVTinhcontext = new DVTinhResponsity();
            dbNhanHangcontext = new tbNhanHangResponsity();
            dbDMPhieuNhapcontext = new tbPhieuNhapResponsity();
            dgvDMPhieuNhap.AutoGenerateColumns = false;
            dtpsNgayNhap.Value = DateTime.Now;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.CloseTabForm();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            loadDMPhieuNhap();
        }

        private void loadDMPhieuNhap()
        {
            var lstDMPhieuNhap = dbDMPhieuNhapcontext.GetCollection<tbPhieuNhapModel>();
            BindingList<tbPhieuNhapModel> dmPhieuNhap = new BindingList<tbPhieuNhapModel>(lstDMPhieuNhap);
            dgvDMPhieuNhap.DataSource = dmPhieuNhap;
        }
    }
}
