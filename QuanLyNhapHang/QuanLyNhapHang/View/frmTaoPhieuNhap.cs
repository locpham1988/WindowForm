

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
        private BindingList<tbMatHangNhapModel> dmMatHangNhap = new BindingList<tbMatHangNhapModel>();
        private IDBActionContext dbMatHangcontext;
        private IDBActionContext dbDVTinhcontext;
        private IDBActionContext dbNhanHangcontext;
        public frmTaoPhieuNhap()
        {
            InitializeComponent();
            dbMatHangcontext = new tbMatHangResponsity();
            dbDVTinhcontext = new DVTinhResponsity();
            dbNhanHangcontext = new tbNhanHangResponsity();
            dgvDMMatHang.AutoGenerateColumns = false;
            dtpsNgayNhap.Value = DateTime.Now;
        }
        private void LoadMatHang()
        {
            //tbNhanHangBindingSource.DataSource = dbNhanHangcontext.GetCollection<tbNhanHangModel>();
            var lstMatHang = dbMatHangcontext.GetCollection<tbMatHangModel>().OrderByDescending(n => n.Updated).ToList();
            cboMatHang.DataSource = lstMatHang;
            cboMatHang.DisplayMember = "Tenhang";
            cboMatHang.ValueMember = "Mahang";
            cboMatHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMatHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection lstComplete = new AutoCompleteStringCollection();
            lstComplete.AddRange(lstMatHang.Select(n => n.Tenhang).ToArray());
            cboMatHang.AutoCompleteCustomSource = lstComplete;
            dgvcboMatHang.DataSource = lstMatHang;
            dgvcboMatHang.DisplayMember = "Tenhang";
            dgvcboMatHang.ValueMember = "Mahang";

        }

        private void LoadNhanhang()
        {
            var lstNhanhang = dbNhanHangcontext.GetCollection<tbNhanHangModel>();
            lstNhanhang.Insert(0, new tbNhanHangModel { ID = -1, Name = "Chọn nhãn hàng" });
            cboNhanHang.DataSource = lstNhanhang;
            cboNhanHang.DisplayMember = "Name";
            cboNhanHang.ValueMember = "ID";
            dgvcboNhanHang.DataSource = lstNhanhang;
            dgvcboNhanHang.DisplayMember = "Name";
            dgvcboNhanHang.ValueMember = "ID";
        }

        private void LoadDVTinh()
        {
            var lstDVTinh = dbDVTinhcontext.GetCollection<DVTinhModel>();
            lstDVTinh.Insert(0, new DVTinhModel { ID = -1, Name = "Chọn Đ/V tính" });
            cboDVTinh.DataSource = lstDVTinh;
            cboDVTinh.DisplayMember = "Name";
            cboDVTinh.ValueMember = "ID";
            dgvcboDVTinh.DataSource = lstDVTinh;
            dgvcboDVTinh.DisplayMember = "Name";
            dgvcboDVTinh.ValueMember = "ID";
            

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
            dmMatHangNhap.AllowEdit = true;
            dmMatHangNhap.AllowNew = true;
            dmMatHangNhap.AllowRemove = true;
            dgvDMMatHang.DataSource = dmMatHangNhap;
            LoadNhanhang();
            LoadMatHang();
            
            LoadDVTinh();
            dgvcboDVTinh.DataPropertyName = "MaDVTinh";
            dgvcboMatHang.DataPropertyName = "MaMatHang";
            dgvcboNhanHang.DataPropertyName = "MaNhanhang";
            
        }

        private void cboMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboNhanHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<tbMatHangModel> lstMatHang = new List<tbMatHangModel>();
            if (!cboNhanHang.SelectedValue.Equals(-1))
            {
                var result = dbMatHangcontext.GetCollection<tbMatHangModel>().Where(n => n.MaNhanHang.Equals(cboNhanHang.SelectedValue)).OrderByDescending(n => n.Updated).ToList();
                if (result.Count>0)
                {
                    lstMatHang = result;
                }
            }
            else
            {
                lstMatHang = dbMatHangcontext.GetCollection<tbMatHangModel>().OrderByDescending(n => n.Updated).ToList();
            }
            cboMatHang.DataSource = lstMatHang;
            cboMatHang.DisplayMember = "Tenhang";
            cboMatHang.ValueMember = "Mahang";
            cboMatHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMatHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection lstComplete = new AutoCompleteStringCollection();
            lstComplete.AddRange(lstMatHang.Select(n => n.Tenhang).ToArray());
        }

        private void dgvDMMatHang_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvDMMatHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDMMatHang.Rows.Count>1)
            {
                
                if (e.ColumnIndex.Equals(dgvcboMatHang.DisplayIndex))
                {
                    DataGridViewComboBoxCell cell = dgvDMMatHang.Rows[e.RowIndex].Cells[dgvcboMatHang.DisplayIndex] as DataGridViewComboBoxCell;
                    if (cell!=null)
                    {
                        var selected = ((List<tbMatHangModel>)cell.DataSource).SingleOrDefault(n => n.Mahang.Equals(cell.Value));
                        if (selected!=null)
                        {
                            DataGridViewComboBoxCell NhanHangcell = dgvDMMatHang.Rows[e.RowIndex].Cells[dgvcboNhanHang.DisplayIndex] as DataGridViewComboBoxCell;
                            if (NhanHangcell!=null)
                            {
                                NhanHangcell.Value = selected.MaNhanHang;
                            }
                        }
                    }
                    
                }
                else if (e.ColumnIndex.Equals(dgvtxtGiaNhap.DisplayIndex) || e.ColumnIndex.Equals(dgvtxtSoLuong.DisplayIndex))
                {

                }
            }
        }

        private void dgvDMMatHang_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
