namespace QuanLyNhapHang.View
{
    partial class frmDVtinh
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDMDonViTinh = new System.Windows.Forms.DataGridView();
            this.dgvckbSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvtxtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMDonViTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btncreate);
            this.groupBox2.Controls.Add(this.lblUsername);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDMDonViTinh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 409);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DM Đơn vị tính";
            // 
            // dgvDMDonViTinh
            // 
            this.dgvDMDonViTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMDonViTinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvckbSelect,
            this.dgvtxtID,
            this.dgvtxtName});
            this.dgvDMDonViTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDMDonViTinh.Location = new System.Drawing.Point(3, 16);
            this.dgvDMDonViTinh.Name = "dgvDMDonViTinh";
            this.dgvDMDonViTinh.Size = new System.Drawing.Size(662, 390);
            this.dgvDMDonViTinh.TabIndex = 2;
            // 
            // dgvckbSelect
            // 
            this.dgvckbSelect.HeaderText = "Chon";
            this.dgvckbSelect.Name = "dgvckbSelect";
            // 
            // dgvtxtID
            // 
            this.dgvtxtID.HeaderText = "ID";
            this.dgvtxtID.Name = "dgvtxtID";
            this.dgvtxtID.ReadOnly = true;
            // 
            // dgvtxtName
            // 
            this.dgvtxtName.HeaderText = "Tên Đơn vị tính";
            this.dgvtxtName.Name = "dgvtxtName";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Location = new System.Drawing.Point(12, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Tên Đơn vị tính";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(125, 19);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(229, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::QuanLyNhapHang.Properties.Resources.Toolbar;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Image = global::QuanLyNhapHang.Properties.Resources.search16;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(461, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Tìm kiếm";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btncreate
            // 
            this.btncreate.BackgroundImage = global::QuanLyNhapHang.Properties.Resources.Toolbar;
            this.btncreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncreate.Image = global::QuanLyNhapHang.Properties.Resources.add16;
            this.btncreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncreate.Location = new System.Drawing.Point(362, 17);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(80, 23);
            this.btncreate.TabIndex = 8;
            this.btncreate.Text = "Tạo mới";
            this.btncreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncreate.UseVisualStyleBackColor = true;
            // 
            // frmDVtinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(668, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDVtinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DV tinh";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMDonViTinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDMDonViTinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvckbSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btncreate;

    }
}