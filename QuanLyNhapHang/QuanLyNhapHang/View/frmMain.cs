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

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void đVTinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var frmTabDVTinh = tbForm.TabPages["frmDVTinh"];
            if (frmTabDVTinh == null)
            {
                var DVtinh = new frmDVtinh();
                DVtinh.TopLevel = false;
                DVtinh.Dock = DockStyle.Fill;

                var tabpage = new TabPage
                {
                    Name = DVtinh.Name,
                    Text = DVtinh.Text,

                };
                DVtinh.Parent = tabpage;
                DVtinh.Visible = true;
                tabpage.Controls.Add(DVtinh);
                frmTabDVTinh = tabpage;
                tbForm.TabPages.Add(frmTabDVTinh);
            }
            tbForm.SelectedTab = frmTabDVTinh;
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
    }
}
