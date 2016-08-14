using QuanLyNhapHang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhapHang.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

       
        public void SetUserInfo(UserModel user)
        {
            tsslblTenNguoiDung.Text=user.FullName;
            tsslblRole.Text = user.Role;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void đVTinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmDVtinh();
            openTabForm(frm);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogin().Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dMNhanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmNhanhang();
            openTabForm(frm);
        }

        private void dMMatHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmMatHang();
            openTabForm(frm);
        }

        private void dMPPhieuNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmPhieuNhap();
            openTabForm(frm);
        }

        private void openTabForm(Form frm)
        {
            var tabpage = tbForm.TabPages[frm.Name];
            if (tabpage==null)
            {
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;

                tabpage = new TabPage
                {
                    Name = frm.Name,
                    Text = frm.Text
                };
                frm.Parent = tabpage;
                frm.Visible = true;
                tabpage.Controls.Add(frm);
                tbForm.TabPages.Add(tabpage);
            }
            tbForm.SelectedTab = tabpage;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmBangGia frm = new frmBangGia();
            openTabForm(frm);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmSearchPhieuNhap frm = new frmSearchPhieuNhap();
            
            frm.ShowDialog();
        }

        private void tlsbCreateNewInvoice_Click(object sender, EventArgs e)
        {
            frmTaoPhieuNhap frm = new frmTaoPhieuNhap();
            openTabForm(frm);
        }
    }
}
