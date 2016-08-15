namespace QuanLyNhapHang.View
{
    partial class frmMatHang
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.btncreateNhanHang = new System.Windows.Forms.Button();
            this.cboNhanHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dpkNgayCapNhat = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.lblTenhang = new System.Windows.Forms.Label();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.clnMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNhanHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clnNgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNgayCapNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.dtpNgayTao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btncreate);
            this.groupBox1.Controls.Add(this.btncreateNhanHang);
            this.groupBox1.Controls.Add(this.cboNhanHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dpkNgayCapNhat);
            this.groupBox1.Controls.Add(this.lblNgayTao);
            this.groupBox1.Controls.Add(this.txtTenhang);
            this.groupBox1.Controls.Add(this.lblTenhang);
            this.groupBox1.Controls.Add(this.txtMahang);
            this.groupBox1.Controls.Add(this.lblMaHang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.MinimumSize = new System.Drawing.Size(0, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(707, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::QuanLyNhapHang.Properties.Resources.Toolbar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(505, 159);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 36);
            this.button2.TabIndex = 23;
            this.button2.Text = "Xóa trắng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(387, 159);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 36);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.CustomFormat = "dd/MM/yy ";
            this.dtpNgayTao.Enabled = false;
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTao.Location = new System.Drawing.Point(118, 125);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(200, 26);
            this.dtpNgayTao.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.MinimumSize = new System.Drawing.Size(80, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày tạo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.button1.Location = new System.Drawing.Point(611, 159);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Đóng";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackgroundImage = global::QuanLyNhapHang.Properties.Resources.Toolbar;
            this.btnCapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCapNhat.Image = global::QuanLyNhapHang.Properties.Resources.documents_white_edit;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(136, 159);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(127, 36);
            this.btnCapNhat.TabIndex = 17;
            this.btnCapNhat.Text = "Chỉnh sửa";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(271, 159);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 36);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btncreate
            // 
            this.btncreate.BackgroundImage = global::QuanLyNhapHang.Properties.Resources.Toolbar;
            this.btncreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncreate.Image = global::QuanLyNhapHang.Properties.Resources.add;
            this.btncreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncreate.Location = new System.Drawing.Point(16, 159);
            this.btncreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(112, 36);
            this.btncreate.TabIndex = 14;
            this.btncreate.Text = "Tạo mới";
            this.btncreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btncreateNhanHang
            // 
            this.btncreateNhanHang.BackgroundImage = global::QuanLyNhapHang.Properties.Resources.Toolbar;
            this.btncreateNhanHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncreateNhanHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncreateNhanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreateNhanHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncreateNhanHang.Image = global::QuanLyNhapHang.Properties.Resources.add;
            this.btncreateNhanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncreateNhanHang.Location = new System.Drawing.Point(455, 84);
            this.btncreateNhanHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncreateNhanHang.Name = "btncreateNhanHang";
            this.btncreateNhanHang.Size = new System.Drawing.Size(168, 36);
            this.btncreateNhanHang.TabIndex = 9;
            this.btncreateNhanHang.Text = "Tạo nhãn hàng";
            this.btncreateNhanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncreateNhanHang.UseVisualStyleBackColor = true;
            this.btncreateNhanHang.Click += new System.EventHandler(this.btncreateNhanHang_Click);
            // 
            // cboNhanHang
            // 
            this.cboNhanHang.DisplayMember = "Name";
            this.cboNhanHang.FormattingEnabled = true;
            this.cboNhanHang.Location = new System.Drawing.Point(118, 86);
            this.cboNhanHang.Name = "cboNhanHang";
            this.cboNhanHang.Size = new System.Drawing.Size(330, 28);
            this.cboNhanHang.TabIndex = 7;
            this.cboNhanHang.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.MinimumSize = new System.Drawing.Size(100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhãn hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpkNgayCapNhat
            // 
            this.dpkNgayCapNhat.CustomFormat = "dd/MM/yy ";
            this.dpkNgayCapNhat.Enabled = false;
            this.dpkNgayCapNhat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkNgayCapNhat.Location = new System.Drawing.Point(454, 125);
            this.dpkNgayCapNhat.Name = "dpkNgayCapNhat";
            this.dpkNgayCapNhat.Size = new System.Drawing.Size(167, 26);
            this.dpkNgayCapNhat.TabIndex = 5;
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTao.Location = new System.Drawing.Point(324, 128);
            this.lblNgayTao.MinimumSize = new System.Drawing.Size(80, 0);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(124, 20);
            this.lblNgayTao.TabIndex = 4;
            this.lblNgayTao.Text = "Ngày cập nhật";
            this.lblNgayTao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenhang
            // 
            this.txtTenhang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenhang.Location = new System.Drawing.Point(118, 53);
            this.txtTenhang.MinimumSize = new System.Drawing.Size(200, 4);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(582, 26);
            this.txtTenhang.TabIndex = 3;
            // 
            // lblTenhang
            // 
            this.lblTenhang.AutoSize = true;
            this.lblTenhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenhang.Location = new System.Drawing.Point(12, 56);
            this.lblTenhang.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblTenhang.Name = "lblTenhang";
            this.lblTenhang.Size = new System.Drawing.Size(100, 20);
            this.lblTenhang.TabIndex = 2;
            this.lblTenhang.Text = "Tên hàng";
            // 
            // txtMahang
            // 
            this.txtMahang.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtMahang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahang.ForeColor = System.Drawing.Color.Red;
            this.txtMahang.Location = new System.Drawing.Point(118, 21);
            this.txtMahang.MinimumSize = new System.Drawing.Size(200, 4);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.ReadOnly = true;
            this.txtMahang.Size = new System.Drawing.Size(400, 26);
            this.txtMahang.TabIndex = 1;
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHang.Location = new System.Drawing.Point(12, 24);
            this.lblMaHang.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(100, 20);
            this.lblMaHang.TabIndex = 0;
            this.lblMaHang.Text = "Mã hàng";
            this.lblMaHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMatHang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(707, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMaHang,
            this.clnTenHang,
            this.clnNhanHang,
            this.clnNgayTao,
            this.clnNgayCapNhat});
            this.dgvMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatHang.Location = new System.Drawing.Point(4, 24);
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.RowTemplate.Height = 30;
            this.dgvMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatHang.Size = new System.Drawing.Size(699, 165);
            this.dgvMatHang.TabIndex = 0;
            this.dgvMatHang.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMatHang_DataError);
            this.dgvMatHang.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvMatHang_UserDeletingRow);
            // 
            // clnMaHang
            // 
            this.clnMaHang.DataPropertyName = "Mahang";
            this.clnMaHang.Frozen = true;
            this.clnMaHang.HeaderText = "Mã hàng";
            this.clnMaHang.Name = "clnMaHang";
            this.clnMaHang.ReadOnly = true;
            // 
            // clnTenHang
            // 
            this.clnTenHang.DataPropertyName = "Tenhang";
            this.clnTenHang.Frozen = true;
            this.clnTenHang.HeaderText = "Tên hàng";
            this.clnTenHang.MinimumWidth = 200;
            this.clnTenHang.Name = "clnTenHang";
            this.clnTenHang.Width = 200;
            // 
            // clnNhanHang
            // 
            this.clnNhanHang.DataPropertyName = "MaNhanHang";
            this.clnNhanHang.Frozen = true;
            this.clnNhanHang.HeaderText = "Nhãn hàng";
            this.clnNhanHang.Name = "clnNhanHang";
            // 
            // clnNgayTao
            // 
            this.clnNgayTao.DataPropertyName = "Created";
            this.clnNgayTao.HeaderText = "Ngày tạo";
            this.clnNgayTao.MinimumWidth = 150;
            this.clnNgayTao.Name = "clnNgayTao";
            this.clnNgayTao.ReadOnly = true;
            this.clnNgayTao.Width = 150;
            // 
            // clnNgayCapNhat
            // 
            this.clnNgayCapNhat.DataPropertyName = "Updated";
            this.clnNgayCapNhat.HeaderText = "Ngày cập nhật";
            this.clnNgayCapNhat.Name = "clnNgayCapNhat";
            this.clnNgayCapNhat.ReadOnly = true;
            this.clnNgayCapNhat.Width = 250;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(707, 400);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "frmMatHang";
            this.Text = "DM Mặt Hàng";
            this.Load += new System.EventHandler(this.frmMatHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboNhanHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpkNgayCapNhat;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.Label lblTenhang;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btncreateNhanHang;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTenHang;
        private System.Windows.Forms.DataGridViewComboBoxColumn clnNhanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNgayCapNhat;
    }
}