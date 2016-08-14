
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
    public partial class frmBangGia : Form
    {
        private IDBActionContext dbMatHangcontext;
        private IDBActionContext dbNhanHangcontext;
        private IDBActionContext dbDVTinhcontext;
        public frmBangGia()
        {
            InitializeComponent();
        }

        private void LoadMatHang()
        {
            //tbNhanHangBindingSource.DataSource = dbNhanHangcontext.GetCollection<tbNhanHangModel>();
            var lstMatHang = dbMatHangcontext.GetCollection<tbMatHangModel>().OrderByDescending(n => n.Updated).ToList();
            
            
            dgvMatHang.AutoGenerateColumns = false;
            dgvMatHang.DataSource = lstMatHang;
        }
        private void LoadNhanhang(string selected)
        {
            var lstNhanhang = dbNhanHangcontext.GetCollection<tbNhanHangModel>();
            lstNhanhang.Insert(0, new tbNhanHangModel { ID=-1, Name="Chọn nhãn hàng" });
            cboNhanHang.DataSource = lstNhanhang;
            cboNhanHang.DisplayMember = "Name";
            cboNhanHang.ValueMember = "ID";
            ((DataGridViewComboBoxColumn)dgvMatHang.Columns["clnNhanHang"]).DataSource = lstNhanhang;
            ((DataGridViewComboBoxColumn)dgvMatHang.Columns["clnNhanHang"]).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)dgvMatHang.Columns["clnNhanHang"]).ValueMember = "ID";
        }

        private void frmBangGia_Load(object sender, EventArgs e)
        {
            dbMatHangcontext = new tbMatHangResponsity();
            dbNhanHangcontext = new tbNhanHangResponsity();
            dbDVTinhcontext = new DVTinhResponsity();
            var lstDVTinh = dbDVTinhcontext.GetCollection<DVTinhModel>();
            lstDVTinh.Insert(0, new DVTinhModel { ID=-1, Name="Chọn Đ/V tính" });
            cboDVTinh.DataSource = lstDVTinh;
            cboDVTinh.DisplayMember = "Name";
            cboDVTinh.ValueMember = "ID";
            LoadNhanhang(string.Empty);
            LoadMatHang();
        }
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CloseTabForm();
        }
        private System.ComponentModel.ListSortDirection sortdirection = System.ComponentModel.ListSortDirection.Ascending;
        private void dgvMatHang_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //dgvMatHang.Sort(dgvMatHang.Columns.Cast<DataGridViewColumn>().ToList()[e.ColumnIndex], sortdirection);
            //switch (sortdirection)
            //{
            //    case System.ComponentModel.ListSortDirection.Ascending:
            //        sortdirection = System.ComponentModel.ListSortDirection.Descending;
            //        break;
            //    case System.ComponentModel.ListSortDirection.Descending:
            //        sortdirection = System.ComponentModel.ListSortDirection.Ascending;
            //        break;
            //    default:
            //        break;
            //}

            
        }

        private void dgvMatHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //dgvMatHang.Sort(dgvMatHang.Columns[0], sortdirection);
            //dgvMatHang.Columns[0].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int from = 0;
            int to = 0;
            int.TryParse(txtGiaNhapTu.Text.Trim(), out from);
            int.TryParse(txtGiaNhapDen.Text.Trim(), out to);
            var lstMatHang = dgvMatHang.DataSource as List<tbMatHangModel>;
            bool found = false;
            if (lstMatHang!=null)
            {
                var lstresult = lstMatHang.Where(m => Contains(m.Tenhang,txtSTenhang.Text).Equals(true) || m.MaNhanHang.Equals(cboNhanHang.SelectedValue)
                    || CompareNumber(m.GiaNhap, from).Equals(true) || CompareNumber(m.GiaNhap, to, false).Equals(true) || Contains(m.DVtinh, cboDVTinh.SelectedText).Equals(true)
                    );
                if (lstresult!=null && lstresult.Count()>0)
                {
                    dgvMatHang.DataSource = lstresult.OrderByDescending(n=>n.Updated).ToList();
                    found = true;
                }
            }

            if (found==false)
            {
                MessageBox.Show("Không tìm thấy bất kỳ mặt hàng nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool Contains(string originalValue, string compareValue)
        {
            if (!string.IsNullOrEmpty(compareValue) && !string.IsNullOrEmpty(originalValue))
            {
                return originalValue.Contains(compareValue);
            }
            return false;
        }

        private bool CompareNumber(decimal originalValue, decimal compareValue,bool isFrom=true)
        {
            if (originalValue>0)
            {
                if (isFrom)
                {
                    return originalValue >= compareValue;
                }
                else
                {
                    return originalValue <= compareValue;
                }
            }
            return false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMatHang();
        }
    }
}
