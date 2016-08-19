namespace QuanLyNhapHang.View
{
    partial class frmTaoPhieuNhap
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
            this.cboNhanHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDVTinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMatHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpsNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDMMatHang = new System.Windows.Forms.DataGridView();
            this.dgvcboMatHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcboNhanHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcboDVTinh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNhanHang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTaoMoi);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboDVTinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboMatHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.dtpsNgayNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 165);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cboNhanHang
            // 
            this.cboNhanHang.FormattingEnabled = true;
            this.cboNhanHang.Location = new System.Drawing.Point(99, 17);
            this.cboNhanHang.Name = "cboNhanHang";
            this.cboNhanHang.Size = new System.Drawing.Size(211, 28);
            this.cboNhanHang.TabIndex = 41;
            this.cboNhanHang.SelectedIndexChanged += new System.EventHandler(this.cboNhanHang_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nhãn hàng";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(99, 51);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(211, 26);
            this.txtGiaNhap.TabIndex = 39;
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Giá nhập";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.BackgroundImage = global::QuanLyNhapHang.Properties.Resources.Toolbar;
            this.btnTaoMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTaoMoi.Image = global::QuanLyNhapHang.Properties.Resources.my_invoices;
            this.btnTaoMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoMoi.Location = new System.Drawing.Point(99, 119);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(170, 36);
            this.btnTaoMoi.TabIndex = 37;
            this.btnTaoMoi.Text = "nhập mặt hàng ";
            this.btnTaoMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(99, 85);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(211, 26);
            this.txtSoLuong.TabIndex = 36;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Số lượng";
            // 
            // cboDVTinh
            // 
            this.cboDVTinh.FormattingEnabled = true;
            this.cboDVTinh.Location = new System.Drawing.Point(409, 49);
            this.cboDVTinh.Name = "cboDVTinh";
            this.cboDVTinh.Size = new System.Drawing.Size(202, 28);
            this.cboDVTinh.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Đ/V Tính";
            // 
            // cboMatHang
            // 
            this.cboMatHang.FormattingEnabled = true;
            this.cboMatHang.Location = new System.Drawing.Point(409, 15);
            this.cboMatHang.Name = "cboMatHang";
            this.cboMatHang.Size = new System.Drawing.Size(202, 28);
            this.cboMatHang.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mặt hàng";
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
            this.button1.Location = new System.Drawing.Point(364, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 30;
            this.button1.Text = "Đóng";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::QuanLyNhapHang.Properties.Resources.Toolbar;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Image = global::QuanLyNhapHang.Properties.Resources.document_save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(277, 119);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 36);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpsNgayNhap
            // 
            this.dtpsNgayNhap.CustomFormat = "dd/MM/yy ";
            this.dtpsNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpsNgayNhap.Location = new System.Drawing.Point(409, 83);
            this.dtpsNgayNhap.Name = "dtpsNgayNhap";
            this.dtpsNgayNhap.Size = new System.Drawing.Size(202, 26);
            this.dtpsNgayNhap.TabIndex = 23;
            this.dtpsNgayNhap.ValueChanged += new System.EventHandler(this.dtpsNgayNhap_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày Nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDMMatHang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 350);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DM Mặt hàng nhập";
            // 
            // dgvDMMatHang
            // 
            this.dgvDMMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcboMatHang,
            this.dgvcboNhanHang,
            this.dgvcboDVTinh,
            this.dgvtxtSoLuong,
            this.dgvtxtGiaNhap,
            this.dgvtxtTotal});
            this.dgvDMMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDMMatHang.Location = new System.Drawing.Point(3, 22);
            this.dgvDMMatHang.Name = "dgvDMMatHang";
            this.dgvDMMatHang.Size = new System.Drawing.Size(617, 325);
            this.dgvDMMatHang.TabIndex = 0;
            this.dgvDMMatHang.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDMMatHang_CellValueChanged);
            this.dgvDMMatHang.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDMMatHang_CurrentCellDirtyStateChanged);
            this.dgvDMMatHang.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDMMatHang_DataError);
            // 
            // dgvcboMatHang
            // 
            this.dgvcboMatHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcboMatHang.HeaderText = "Mặt hàng";
            this.dgvcboMatHang.MinimumWidth = 200;
            this.dgvcboMatHang.Name = "dgvcboMatHang";
            // 
            // dgvcboNhanHang
            // 
            this.dgvcboNhanHang.HeaderText = "Nhãn hàng";
            this.dgvcboNhanHang.MinimumWidth = 150;
            this.dgvcboNhanHang.Name = "dgvcboNhanHang";
            this.dgvcboNhanHang.ReadOnly = true;
            this.dgvcboNhanHang.Width = 150;
            // 
            // dgvcboDVTinh
            // 
            this.dgvcboDVTinh.HeaderText = "Đ/V Tính";
            this.dgvcboDVTinh.MinimumWidth = 150;
            this.dgvcboDVTinh.Name = "dgvcboDVTinh";
            this.dgvcboDVTinh.Width = 150;
            // 
            // dgvtxtSoLuong
            // 
            this.dgvtxtSoLuong.DataPropertyName = "SoLuong";
            this.dgvtxtSoLuong.HeaderText = "Số lượng";
            this.dgvtxtSoLuong.Name = "dgvtxtSoLuong";
            // 
            // dgvtxtGiaNhap
            // 
            this.dgvtxtGiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtGiaNhap.DataPropertyName = "GiaNhap";
            this.dgvtxtGiaNhap.HeaderText = "Giá Nhập";
            this.dgvtxtGiaNhap.MinimumWidth = 150;
            this.dgvtxtGiaNhap.Name = "dgvtxtGiaNhap";
            // 
            // dgvtxtTotal
            // 
            this.dgvtxtTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtTotal.DataPropertyName = "TongTien";
            this.dgvtxtTotal.HeaderText = "Tổng tiền";
            this.dgvtxtTotal.Name = "dgvtxtTotal";
            // 
            // frmTaoPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(623, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTaoPhieuNhap";
            this.Text = "Nhập Hàng";
            this.Load += new System.EventHandler(this.frmTaoPhieuNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpsNgayNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDMMatHang;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboMatHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDVTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboNhanHang;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcboMatHang;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcboNhanHang;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcboDVTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTotal;
    }
}