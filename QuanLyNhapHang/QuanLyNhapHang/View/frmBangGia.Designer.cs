namespace QuanLyNhapHang.View
{
    partial class frmBangGia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtGiaNhapDen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaNhapTu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDVTinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSTenhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNhanHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.clnTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNhanHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clnNgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDVTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtGiaNhapDen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGiaNhapTu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboDVTinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSTenhang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboNhanHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 168);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::QuanLyNhapHang.Properties.Resources.Toolbar;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Image = global::QuanLyNhapHang.Properties.Resources.symbol_refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(216, 122);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 36);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::QuanLyNhapHang.Properties.Resources.Toolbar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::QuanLyNhapHang.Properties.Resources.gnome_session_logout;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(334, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "Đóng";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::QuanLyNhapHang.Properties.Resources.Toolbar;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Image = global::QuanLyNhapHang.Properties.Resources.search24;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(100, 122);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 36);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtGiaNhapDen
            // 
            this.txtGiaNhapDen.Location = new System.Drawing.Point(411, 88);
            this.txtGiaNhapDen.Name = "txtGiaNhapDen";
            this.txtGiaNhapDen.Size = new System.Drawing.Size(218, 26);
            this.txtGiaNhapDen.TabIndex = 25;
            this.txtGiaNhapDen.Text = "0";
            this.txtGiaNhapDen.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtGiaNhapDen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "đến";
            // 
            // txtGiaNhapTu
            // 
            this.txtGiaNhapTu.Location = new System.Drawing.Point(100, 88);
            this.txtGiaNhapTu.Name = "txtGiaNhapTu";
            this.txtGiaNhapTu.Size = new System.Drawing.Size(211, 26);
            this.txtGiaNhapTu.TabIndex = 23;
            this.txtGiaNhapTu.Text = "0";
            this.txtGiaNhapTu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Giá nhập từ";
            // 
            // cboDVTinh
            // 
            this.cboDVTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDVTinh.FormattingEnabled = true;
            this.cboDVTinh.Location = new System.Drawing.Point(411, 54);
            this.cboDVTinh.Name = "cboDVTinh";
            this.cboDVTinh.Size = new System.Drawing.Size(218, 28);
            this.cboDVTinh.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đ/V Tính";
            // 
            // txtSTenhang
            // 
            this.txtSTenhang.Location = new System.Drawing.Point(100, 22);
            this.txtSTenhang.Name = "txtSTenhang";
            this.txtSTenhang.Size = new System.Drawing.Size(529, 26);
            this.txtSTenhang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hàng";
            // 
            // cboNhanHang
            // 
            this.cboNhanHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanHang.FormattingEnabled = true;
            this.cboNhanHang.Location = new System.Drawing.Point(100, 54);
            this.cboNhanHang.Name = "cboNhanHang";
            this.cboNhanHang.Size = new System.Drawing.Size(211, 28);
            this.cboNhanHang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhãn hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMatHang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 168);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(639, 188);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng giá nhập";
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.AllowUserToAddRows = false;
            this.dgvMatHang.AllowUserToDeleteRows = false;
            this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnTenHang,
            this.clnNhanHang,
            this.clnNgayTao,
            this.dgvtxtDVTinh,
            this.dgvtxtNgayNhap});
            this.dgvMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatHang.Location = new System.Drawing.Point(4, 24);
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.ReadOnly = true;
            this.dgvMatHang.RowTemplate.Height = 30;
            this.dgvMatHang.Size = new System.Drawing.Size(631, 159);
            this.dgvMatHang.TabIndex = 1;
            this.dgvMatHang.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMatHang_ColumnHeaderMouseClick);
            // 
            // clnTenHang
            // 
            this.clnTenHang.DataPropertyName = "Tenhang";
            this.clnTenHang.Frozen = true;
            this.clnTenHang.HeaderText = "Tên hàng";
            this.clnTenHang.MinimumWidth = 200;
            this.clnTenHang.Name = "clnTenHang";
            this.clnTenHang.ReadOnly = true;
            this.clnTenHang.Width = 200;
            // 
            // clnNhanHang
            // 
            this.clnNhanHang.DataPropertyName = "MaNhanHang";
            this.clnNhanHang.Frozen = true;
            this.clnNhanHang.HeaderText = "Nhãn hàng";
            this.clnNhanHang.Name = "clnNhanHang";
            this.clnNhanHang.ReadOnly = true;
            // 
            // clnNgayTao
            // 
            this.clnNgayTao.DataPropertyName = "GiaNhap";
            this.clnNgayTao.HeaderText = "Giá Nhập";
            this.clnNgayTao.MinimumWidth = 150;
            this.clnNgayTao.Name = "clnNgayTao";
            this.clnNgayTao.ReadOnly = true;
            this.clnNgayTao.Width = 150;
            // 
            // dgvtxtDVTinh
            // 
            this.dgvtxtDVTinh.DataPropertyName = "DVTinh";
            this.dgvtxtDVTinh.HeaderText = "Đ/V Tính";
            this.dgvtxtDVTinh.MinimumWidth = 150;
            this.dgvtxtDVTinh.Name = "dgvtxtDVTinh";
            this.dgvtxtDVTinh.ReadOnly = true;
            this.dgvtxtDVTinh.Width = 150;
            // 
            // dgvtxtNgayNhap
            // 
            this.dgvtxtNgayNhap.DataPropertyName = "NgayNhap";
            this.dgvtxtNgayNhap.HeaderText = "Ngày Nhập";
            this.dgvtxtNgayNhap.MinimumWidth = 150;
            this.dgvtxtNgayNhap.Name = "dgvtxtNgayNhap";
            this.dgvtxtNgayNhap.ReadOnly = true;
            this.dgvtxtNgayNhap.Width = 150;
            // 
            // frmBangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(639, 356);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBangGia";
            this.Text = "Bảng giá nhập";
            this.Load += new System.EventHandler(this.frmBangGia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtGiaNhapDen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiaNhapTu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDVTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSTenhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNhanHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTenHang;
        private System.Windows.Forms.DataGridViewComboBoxColumn clnNhanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDVTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNgayNhap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefresh;

    }
}