namespace QuanLyNhapHang.View
{
    partial class frmPhieuNhap
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvtxtNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTongHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaNhapTu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpsNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDVTinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSTenhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNhanHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.dgvtxtMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNhanHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcboDVTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 661);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DM Phiếu Nhập";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtNgayNhap,
            this.dgvtxtTongHoaDon});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 636);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgvtxtNgayNhap
            // 
            this.dgvtxtNgayNhap.HeaderText = "Ngày Nhập";
            this.dgvtxtNgayNhap.MinimumWidth = 150;
            this.dgvtxtNgayNhap.Name = "dgvtxtNgayNhap";
            this.dgvtxtNgayNhap.ReadOnly = true;
            this.dgvtxtNgayNhap.Width = 150;
            // 
            // dgvtxtTongHoaDon
            // 
            this.dgvtxtTongHoaDon.HeaderText = "Tổng Tiền";
            this.dgvtxtTongHoaDon.MinimumWidth = 200;
            this.dgvtxtTongHoaDon.Name = "dgvtxtTongHoaDon";
            this.dgvtxtTongHoaDon.ReadOnly = true;
            this.dgvtxtTongHoaDon.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtGiaNhapTu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpsNgayNhap);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboDVTinh);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSTenhang);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboNhanHang);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(347, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
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
            this.btnSearch.Location = new System.Drawing.Point(469, 85);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 28);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(309, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 26);
            this.textBox3.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "đến";
            // 
            // txtGiaNhapTu
            // 
            this.txtGiaNhapTu.Location = new System.Drawing.Point(100, 87);
            this.txtGiaNhapTu.Name = "txtGiaNhapTu";
            this.txtGiaNhapTu.Size = new System.Drawing.Size(161, 26);
            this.txtGiaNhapTu.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Giá nhập từ";
            // 
            // dtpsNgayNhap
            // 
            this.dtpsNgayNhap.CustomFormat = "dd/MM/yy ";
            this.dtpsNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpsNgayNhap.Location = new System.Drawing.Point(411, 51);
            this.dtpsNgayNhap.Name = "dtpsNgayNhap";
            this.dtpsNgayNhap.Size = new System.Drawing.Size(200, 26);
            this.dtpsNgayNhap.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày Nhập";
            // 
            // cboDVTinh
            // 
            this.cboDVTinh.FormattingEnabled = true;
            this.cboDVTinh.Location = new System.Drawing.Point(100, 53);
            this.cboDVTinh.Name = "cboDVTinh";
            this.cboDVTinh.Size = new System.Drawing.Size(211, 28);
            this.cboDVTinh.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đ/V Tính";
            // 
            // txtSTenhang
            // 
            this.txtSTenhang.Location = new System.Drawing.Point(411, 19);
            this.txtSTenhang.Name = "txtSTenhang";
            this.txtSTenhang.Size = new System.Drawing.Size(200, 26);
            this.txtSTenhang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hàng";
            // 
            // cboNhanHang
            // 
            this.cboNhanHang.FormattingEnabled = true;
            this.cboNhanHang.Location = new System.Drawing.Point(100, 19);
            this.cboNhanHang.Name = "cboNhanHang";
            this.cboNhanHang.Size = new System.Drawing.Size(211, 28);
            this.cboNhanHang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhãn hàng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnCapNhat);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(347, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 540);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Phiếu nhập";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackgroundImage = global::QuanLyNhapHang.Properties.Resources.Toolbar;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Image = global::QuanLyNhapHang.Properties.Resources.gnome_session_logout;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(563, 491);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 36);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.BackgroundImage = global::QuanLyNhapHang.Properties.Resources.Toolbar;
            this.btnCapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCapNhat.Image = global::QuanLyNhapHang.Properties.Resources.documents_white_edit;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(428, 491);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(127, 36);
            this.btnCapNhat.TabIndex = 28;
            this.btnCapNhat.Text = "Chỉnh sửa";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvMatHang);
            this.groupBox4.Location = new System.Drawing.Point(10, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(642, 426);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DM Mặt hàng nhập";
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtMatHang,
            this.clnNhanHang,
            this.dgvtxtSoLuong,
            this.dgvcboDVTinh,
            this.dgvtxtThanhTien});
            this.dgvMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatHang.Location = new System.Drawing.Point(3, 22);
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.RowTemplate.Height = 30;
            this.dgvMatHang.Size = new System.Drawing.Size(636, 401);
            this.dgvMatHang.TabIndex = 1;
            // 
            // dgvtxtMatHang
            // 
            this.dgvtxtMatHang.HeaderText = "Mặt hàng";
            this.dgvtxtMatHang.MinimumWidth = 150;
            this.dgvtxtMatHang.Name = "dgvtxtMatHang";
            this.dgvtxtMatHang.ReadOnly = true;
            this.dgvtxtMatHang.Width = 150;
            // 
            // clnNhanHang
            // 
            this.clnNhanHang.DataPropertyName = "MaNhanHang";
            this.clnNhanHang.HeaderText = "Nhãn hàng";
            this.clnNhanHang.MinimumWidth = 150;
            this.clnNhanHang.Name = "clnNhanHang";
            this.clnNhanHang.ReadOnly = true;
            this.clnNhanHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnNhanHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnNhanHang.Width = 150;
            // 
            // dgvtxtSoLuong
            // 
            this.dgvtxtSoLuong.HeaderText = "Số Lượng";
            this.dgvtxtSoLuong.MinimumWidth = 150;
            this.dgvtxtSoLuong.Name = "dgvtxtSoLuong";
            this.dgvtxtSoLuong.ReadOnly = true;
            this.dgvtxtSoLuong.Width = 150;
            // 
            // dgvcboDVTinh
            // 
            this.dgvcboDVTinh.HeaderText = "Đ/V Tính";
            this.dgvcboDVTinh.Name = "dgvcboDVTinh";
            this.dgvcboDVTinh.ReadOnly = true;
            this.dgvcboDVTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcboDVTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtThanhTien
            // 
            this.dgvtxtThanhTien.HeaderText = "Thành tiền";
            this.dgvtxtThanhTien.MinimumWidth = 150;
            this.dgvtxtThanhTien.Name = "dgvtxtThanhTien";
            this.dgvtxtThanhTien.ReadOnly = true;
            this.dgvtxtThanhTien.Width = 150;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 26);
            this.textBox1.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tổng tiền";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yy ";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 26);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ngày Nhập";
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1005, 661);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPhieuNhap";
            this.Text = "Hóa đơn nhập hàng";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTongHoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDVTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSTenhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNhanHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiaNhapTu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpsNgayNhap;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNhanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcboDVTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtThanhTien;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
    }
}