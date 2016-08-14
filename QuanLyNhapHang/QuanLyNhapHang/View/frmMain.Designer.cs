namespace QuanLyNhapHang.View
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DVTinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dMNhanHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dMMatHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dMPPhieuNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblTenNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblLoaiNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsbCreateNewInvoice = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.tbForm = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.danhMụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.systemToolStripMenuItem.Image = global::QuanLyNhapHang.Properties.Resources.emblem_system;
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.systemToolStripMenuItem.Text = "Hệ thống";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::QuanLyNhapHang.Properties.Resources.gnome_logout;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DVTinhToolStripMenuItem,
            this.dMNhanHangToolStripMenuItem,
            this.dMMatHangToolStripMenuItem,
            this.dMPPhieuNhapToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Image = global::QuanLyNhapHang.Properties.Resources.bookmark_new_list;
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // DVTinhToolStripMenuItem
            // 
            this.DVTinhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.DVTinhToolStripMenuItem.Image = global::QuanLyNhapHang.Properties.Resources.measure_units;
            this.DVTinhToolStripMenuItem.Name = "DVTinhToolStripMenuItem";
            this.DVTinhToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.DVTinhToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.DVTinhToolStripMenuItem.Text = "ĐV Tính";
            this.DVTinhToolStripMenuItem.Click += new System.EventHandler(this.đVTinhToolStripMenuItem_Click);
            // 
            // dMNhanHangToolStripMenuItem
            // 
            this.dMNhanHangToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dMNhanHangToolStripMenuItem.Image = global::QuanLyNhapHang.Properties.Resources.brand;
            this.dMNhanHangToolStripMenuItem.Name = "dMNhanHangToolStripMenuItem";
            this.dMNhanHangToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.dMNhanHangToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.dMNhanHangToolStripMenuItem.Text = "DM Nhãn Hàng";
            this.dMNhanHangToolStripMenuItem.Click += new System.EventHandler(this.dMNhanHangToolStripMenuItem_Click);
            // 
            // dMMatHangToolStripMenuItem
            // 
            this.dMMatHangToolStripMenuItem.Image = global::QuanLyNhapHang.Properties.Resources.maersk3;
            this.dMMatHangToolStripMenuItem.Name = "dMMatHangToolStripMenuItem";
            this.dMMatHangToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.I)));
            this.dMMatHangToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.dMMatHangToolStripMenuItem.Text = "DM Mặt Hàng";
            this.dMMatHangToolStripMenuItem.Click += new System.EventHandler(this.dMMatHangToolStripMenuItem_Click);
            // 
            // dMPPhieuNhapToolStripMenuItem
            // 
            this.dMPPhieuNhapToolStripMenuItem.Image = global::QuanLyNhapHang.Properties.Resources.invoice_1;
            this.dMPPhieuNhapToolStripMenuItem.Name = "dMPPhieuNhapToolStripMenuItem";
            this.dMPPhieuNhapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.dMPPhieuNhapToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.dMPPhieuNhapToolStripMenuItem.Text = "DM Phiếu Nhập";
            this.dMPPhieuNhapToolStripMenuItem.Click += new System.EventHandler(this.dMPPhieuNhapToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslblTenNguoiDung,
            this.tsslblLoaiNguoiDung,
            this.tsslblRole});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(890, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(134, 19);
            this.toolStripStatusLabel1.Text = "Người dùng hiện tại:";
            // 
            // tsslblTenNguoiDung
            // 
            this.tsslblTenNguoiDung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsslblTenNguoiDung.ForeColor = System.Drawing.Color.DarkRed;
            this.tsslblTenNguoiDung.Name = "tsslblTenNguoiDung";
            this.tsslblTenNguoiDung.Size = new System.Drawing.Size(32, 19);
            this.tsslblTenNguoiDung.Text = "Ten";
            // 
            // tsslblLoaiNguoiDung
            // 
            this.tsslblLoaiNguoiDung.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsslblLoaiNguoiDung.Name = "tsslblLoaiNguoiDung";
            this.tsslblLoaiNguoiDung.Size = new System.Drawing.Size(112, 19);
            this.tsslblLoaiNguoiDung.Text = "Loại người dùng:";
            // 
            // tsslblRole
            // 
            this.tsslblRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsslblRole.ForeColor = System.Drawing.Color.DarkRed;
            this.tsslblRole.Name = "tsslblRole";
            this.tsslblRole.Size = new System.Drawing.Size(39, 19);
            this.tsslblRole.Text = "Role";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbCreateNewInvoice,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(890, 76);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsbCreateNewInvoice
            // 
            this.tlsbCreateNewInvoice.Image = global::QuanLyNhapHang.Properties.Resources.medical_invoice_information;
            this.tlsbCreateNewInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbCreateNewInvoice.Name = "tlsbCreateNewInvoice";
            this.tlsbCreateNewInvoice.Size = new System.Drawing.Size(96, 73);
            this.tlsbCreateNewInvoice.Text = "Tạo &mới PN";
            this.tlsbCreateNewInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlsbCreateNewInvoice.Click += new System.EventHandler(this.tlsbCreateNewInvoice_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::QuanLyNhapHang.Properties.Resources.invoice;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(74, 73);
            this.toolStripButton2.Text = "Bảng &giá";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(122, 73);
            this.toolStripButton3.Text = "&Tìm phiếu nhập";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 175);
            // 
            // tbForm
            // 
            this.tbForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbForm.Location = new System.Drawing.Point(0, 104);
            this.tbForm.Name = "tbForm";
            this.tbForm.SelectedIndex = 0;
            this.tbForm.Size = new System.Drawing.Size(890, 433);
            this.tbForm.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(890, 561);
            this.Controls.Add(this.tbForm);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhập Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DVTinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dMNhanHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dMMatHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dMPPhieuNhapToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsbCreateNewInvoice;
        public System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TabControl tbForm;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblTenNguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel tsslblLoaiNguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel tsslblRole;
    }
}