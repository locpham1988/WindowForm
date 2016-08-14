

namespace QuanLyNhapHang.View
{
    using QuanLyNhapHang.Model;
    using QuanLyNhapHang.Responsities;
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using QuanLyNhapHang.Helper;
    public partial class frmMatHang : Form
    {
        public frmMatHang()
        {
            InitializeComponent();
            dgvMatHang.SelectionChanged += dgvMatHang_SelectionChanged;
            dgvMatHang.MultiSelect = false;
        }

        void dgvMatHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMatHang.SelectedRows.Count>0)
            {
                var model = dgvMatHang.SelectedRows[0].DataBoundItem as tbMatHangModel;
                if (model!=null)
                {
                    txtMahang.Text = model.Mahang;
                    txtTenhang.Text = model.Tenhang;
                    dpkNgayCapNhat.Value = model.Updated;
                    dtpNgayTao.Value = model.Created;
                    cboNhanHang.SelectedValue = model.MaNhanHang;
                }
            }
        }
        private IDBActionContext dbMatHangcontext;
        private IDBActionContext dbNhanHangcontext;
        private void btncreate_Click(object sender, EventArgs e)
        {
            bool invalid = false;
            if (string.IsNullOrWhiteSpace(txtTenhang.Text) || cboNhanHang.SelectedValue.ToString().Equals("-1"))
            {
                invalid=true;
            }

            if (invalid ==false)
            {
                var success= dbMatHangcontext.Add(new tbMatHangModel
                {
                    
                    Tenhang=txtTenhang.Text,
                    MaNhanHang=int.Parse(cboNhanHang.SelectedValue.ToString())
                });

                if (success)
                {
                    LoadMatHang();
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi: Không thể thêm mặt hàng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            txtMahang.Clear();
            txtTenhang.Clear();
            dpkNgayCapNhat.Value = DateTime.Now;
            dtpNgayTao.Value = DateTime.Now;
        }

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            dbMatHangcontext = new tbMatHangResponsity();
            dbNhanHangcontext = new tbNhanHangResponsity();
            
            LoadNhanhang(string.Empty);
            LoadMatHang();
            
        }

        private void LoadMatHang()
        {
            //tbNhanHangBindingSource.DataSource = dbNhanHangcontext.GetCollection<tbNhanHangModel>();
            var lstMatHang= dbMatHangcontext.GetCollection<tbMatHangModel>();
            dgvMatHang.AutoGenerateColumns = false;
            dgvMatHang.DataSource = lstMatHang.OrderByDescending(n => n.Updated).ToList();
        }
        private void LoadNhanhang(string selected)
        {
            var lstNhanhang = dbNhanHangcontext.GetCollection<tbNhanHangModel>();
            ((DataGridViewComboBoxColumn)dgvMatHang.Columns["clnNhanHang"]).DataSource = lstNhanhang;
            ((DataGridViewComboBoxColumn)dgvMatHang.Columns["clnNhanHang"]).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)dgvMatHang.Columns["clnNhanHang"]).ValueMember = "ID";
            lstNhanhang.Insert(0, new tbNhanHangModel { ID = -1, Name = "Chọn nhãn hàng" });
            cboNhanHang.DataSource = lstNhanhang;
            cboNhanHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboNhanHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection lstComplete = new AutoCompleteStringCollection();
            lstComplete.AddRange(lstNhanhang.Select(n => n.Name).ToArray());
            cboNhanHang.AutoCompleteCustomSource = lstComplete;
            if (!string.IsNullOrWhiteSpace(selected))
            {
                cboNhanHang.Text = string.Empty;
                cboNhanHang.SelectedText = selected;
            }
        }

        private void btncreateNhanHang_Click(object sender, EventArgs e)
        {
            string addValue = this.cboNhanHang.Text.Trim();
            if (!string.IsNullOrEmpty(addValue))
            {
                var lstSource = dbNhanHangcontext.GetCollection<tbNhanHangModel>().Where(n => n.Name.ToLower().Trim().Equals(addValue.ToLower().Trim()));
                if (lstSource != null && lstSource.Count() == 0)
                {

                    if (dbNhanHangcontext.Add(new tbNhanHangModel { Name = addValue }))
                    {
                        LoadNhanhang(addValue);
                        MessageBox.Show("Thêm nhãn hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.CloseTabForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMatHang();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bool invalid = false;
            if (string.IsNullOrWhiteSpace(txtTenhang.Text) || cboNhanHang.SelectedValue.ToString().Equals("-1"))
            {
                invalid = true;
            }

            if (invalid == false)
            {
                var success = dbMatHangcontext.Update(new tbMatHangModel
                {
                    Mahang = txtMahang.Text,
                    Tenhang = txtTenhang.Text,
                    MaNhanHang = int.Parse(cboNhanHang.SelectedValue.ToString())
                });

                if (success)
                {
                    LoadMatHang();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
