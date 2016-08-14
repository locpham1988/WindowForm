namespace QuanLyNhapHang.View
{
    partial class frmNhanhang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grbDMDVTinh = new System.Windows.Forms.GroupBox();
            this.dgvDMNhanhang = new System.Windows.Forms.DataGridView();
            this.dgvtxtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsRefresh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.grbDMDVTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMNhanhang)).BeginInit();
            this.cmsRefresh.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btncreate);
            this.groupBox2.Controls.Add(this.lblUsername);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1002, 125);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
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
            this.btnRefresh.Location = new System.Drawing.Point(424, 69);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 36);
            this.btnRefresh.TabIndex = 4;
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
            this.button1.Location = new System.Drawing.Point(549, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 5;
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
            this.btnSearch.Location = new System.Drawing.Point(308, 69);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 36);
            this.btnSearch.TabIndex = 3;
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
            this.btncreate.Location = new System.Drawing.Point(188, 69);
            this.btncreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(112, 36);
            this.btncreate.TabIndex = 2;
            this.btncreate.Text = "Tạo mới";
            this.btncreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Location = new System.Drawing.Point(13, 32);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(129, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tên nhãn hàng";
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = true;
            this.txtName.Location = new System.Drawing.Point(188, 29);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(794, 26);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // grbDMDVTinh
            // 
            this.grbDMDVTinh.Controls.Add(this.dgvDMNhanhang);
            this.grbDMDVTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDMDVTinh.Location = new System.Drawing.Point(0, 125);
            this.grbDMDVTinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDMDVTinh.Name = "grbDMDVTinh";
            this.grbDMDVTinh.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDMDVTinh.Size = new System.Drawing.Size(1002, 583);
            this.grbDMDVTinh.TabIndex = 1;
            this.grbDMDVTinh.TabStop = false;
            this.grbDMDVTinh.Text = "DM Nhãn hàng";
            // 
            // dgvDMNhanhang
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDMNhanhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDMNhanhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMNhanhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtID,
            this.dgvtxtName});
            this.dgvDMNhanhang.ContextMenuStrip = this.cmsRefresh;
            this.dgvDMNhanhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDMNhanhang.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDMNhanhang.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvDMNhanhang.Location = new System.Drawing.Point(4, 24);
            this.dgvDMNhanhang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDMNhanhang.MultiSelect = false;
            this.dgvDMNhanhang.Name = "dgvDMNhanhang";
            this.dgvDMNhanhang.RowHeadersWidth = 10;
            this.dgvDMNhanhang.RowTemplate.ErrorText = "Lỗi";
            this.dgvDMNhanhang.RowTemplate.Height = 30;
            this.dgvDMNhanhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDMNhanhang.Size = new System.Drawing.Size(994, 554);
            this.dgvDMNhanhang.TabIndex = 0;
            this.dgvDMNhanhang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDMDonViTinh_CellEndEdit);
            this.dgvDMNhanhang.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDMDonViTinh_CellEnter);
            this.dgvDMNhanhang.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDMDonViTinh_UserDeletingRow);
            // 
            // dgvtxtID
            // 
            this.dgvtxtID.DataPropertyName = "ID";
            this.dgvtxtID.HeaderText = "ID";
            this.dgvtxtID.Name = "dgvtxtID";
            this.dgvtxtID.ReadOnly = true;
            // 
            // dgvtxtName
            // 
            this.dgvtxtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtName.DataPropertyName = "Name";
            this.dgvtxtName.HeaderText = "Tên nhãn hàng";
            this.dgvtxtName.Name = "dgvtxtName";
            // 
            // cmsRefresh
            // 
            this.cmsRefresh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiRefresh,
            this.cmsiDelete});
            this.cmsRefresh.Name = "cmsRefresh";
            this.cmsRefresh.Size = new System.Drawing.Size(169, 48);
            this.cmsRefresh.Text = "Làm mới";
            // 
            // cmsiRefresh
            // 
            this.cmsiRefresh.Name = "cmsiRefresh";
            this.cmsiRefresh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.cmsiRefresh.Size = new System.Drawing.Size(168, 22);
            this.cmsiRefresh.Text = "Làm mới";
            this.cmsiRefresh.Click += new System.EventHandler(this.cmsiRefresh_Click);
            // 
            // cmsiDelete
            // 
            this.cmsiDelete.Name = "cmsiDelete";
            this.cmsiDelete.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.cmsiDelete.Size = new System.Drawing.Size(168, 22);
            this.cmsiDelete.Text = "Xóa";
            this.cmsiDelete.Click += new System.EventHandler(this.cmsiDelete_Click);
            // 
            // frmNhanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1002, 708);
            this.Controls.Add(this.grbDMDVTinh);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhanhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DM Nhãn hàng";
            this.Load += new System.EventHandler(this.frmDVtinh_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbDMDVTinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMNhanhang)).EndInit();
            this.cmsRefresh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbDMDVTinh;
        private System.Windows.Forms.DataGridView dgvDMNhanhang;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip cmsRefresh;
        private System.Windows.Forms.ToolStripMenuItem cmsiRefresh;
        private System.Windows.Forms.ToolStripMenuItem cmsiDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtName;

    }
}