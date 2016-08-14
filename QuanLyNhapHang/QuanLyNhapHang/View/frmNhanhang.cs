

namespace QuanLyNhapHang.View
{
    using QuanLyNhapHang.Model;
    using QuanLyNhapHang.Responsities;
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using QuanLyNhapHang.Helper;
    public partial class frmNhanhang : Form
    {
        private IDBActionContext dbcontext;


        public frmNhanhang()
        {
            InitializeComponent();

        }
        private void frmDVtinh_Load(object sender, EventArgs e)
        {
            dbcontext = new tbNhanHangResponsity();
            LoadGrid();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                var lstSource = dbcontext.GetCollection<tbNhanHangModel>().Where(n => n.Name.ToLower().Trim().Equals(txtName.Text.ToLower().Trim()));
                if (lstSource!=null && lstSource.Count() == 0)
                {

                    if (dbcontext.Add(new tbNhanHangModel { Name = txtName.Text.Trim() }))
                    {
                        txtName.Clear();
                        LoadGrid();
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: Không thể thêm nhãn hàng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi: tên đã tồn tại. Vui lòng nhập 1 tên khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LoadGrid()
        {
            var lstSource = dbcontext.GetCollection<tbNhanHangModel>().OrderByDescending(n => n.ID).ToList();
            this.dgvDMNhanhang.DataSource = lstSource;
            grbDMDVTinh.Text = string.Format("DM Nhãn hàng - Tổng số dữ liệu:{0}", lstSource.Count);
        }

        private void dgvDMDonViTinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CloseTabForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                var lstSource = dbcontext.GetCollection<tbNhanHangModel>().Where(n => n.Name.ToLower().Trim().Contains(txtName.Text.ToLower().Trim())).ToList();
                this.dgvDMNhanhang.DataSource = lstSource;
            }
            
        }

        private void cmsiRefresh_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void cmsiDelete_Click(object sender, EventArgs e)
        {
            RemoveRow();
        }

        private void RemoveRow()
        {
            if (dgvDMNhanhang.SelectedRows.Count > 0)
            {
                var currentSelected = dgvDMNhanhang.SelectedRows[0].DataBoundItem as DVTinhModel;
                if (currentSelected != null)
                {
                    DialogResult dglog = MessageBox.Show(string.Format("Bạn có thật sự muốn xóa - đơn vị tính '{0}' ?", currentSelected.Name), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dglog == DialogResult.Yes)
                    {
                        dbcontext.Delete(currentSelected.ID);
                        LoadGrid();
                    }
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dgvDMDonViTinh_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            RemoveRow();
        }

        private void dgvDMDonViTinh_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDMDonViTinh_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvDMNhanhang.Rows[e.RowIndex];
            var item = row.DataBoundItem as tbNhanHangModel;
            if (item != null)
            {
                var lst = dbcontext.GetCollection<tbNhanHangModel>();
                var lstSource = lst.Where(n => n.Name.ToLower().Trim().Equals(item.Name.ToLower().Trim()));
                if (lstSource!=null && lstSource.Count() == 0)
                {
                    dbcontext.Update(item);
                }
                else
                {

                    MessageBox.Show("Lỗi: tên đã tồn tại. Vui lòng nhập 1 tên khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    item = lst.FirstOrDefault(n => n.ID.Equals(item.ID));
                    dgvDMNhanhang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = item.Name;
                }
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btncreate_Click(sender, new EventArgs());
            }
        }
        
    }
}
