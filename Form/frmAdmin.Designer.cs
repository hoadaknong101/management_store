
namespace management_store
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.pnlTab = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDigitalClock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTabDangXuat = new System.Windows.Forms.Button();
            this.btnTabNhanVien = new System.Windows.Forms.Button();
            this.btnTabDoanhThu = new System.Windows.Forms.Button();
            this.btnTabSanPham = new System.Windows.Forms.Button();
            this.btnTabHoaDon = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.timerDigitalClock = new System.Windows.Forms.Timer(this.components);
            this.pnlTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTab
            // 
            this.pnlTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTab.Controls.Add(this.pictureBox1);
            this.pnlTab.Controls.Add(this.lblDigitalClock);
            this.pnlTab.Controls.Add(this.label1);
            this.pnlTab.Controls.Add(this.btnTabDangXuat);
            this.pnlTab.Controls.Add(this.btnTabNhanVien);
            this.pnlTab.Controls.Add(this.btnTabDoanhThu);
            this.pnlTab.Controls.Add(this.btnTabSanPham);
            this.pnlTab.Controls.Add(this.btnTabHoaDon);
            this.pnlTab.Controls.Add(this.btnTrangChu);
            this.pnlTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTab.Location = new System.Drawing.Point(0, 0);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.Size = new System.Drawing.Size(221, 708);
            this.pnlTab.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::management_store.Properties.Resources.book_shelf_96px;
            this.pictureBox1.Location = new System.Drawing.Point(7, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblDigitalClock
            // 
            this.lblDigitalClock.AutoSize = true;
            this.lblDigitalClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitalClock.ForeColor = System.Drawing.Color.White;
            this.lblDigitalClock.Location = new System.Drawing.Point(56, 623);
            this.lblDigitalClock.Name = "lblDigitalClock";
            this.lblDigitalClock.Size = new System.Drawing.Size(124, 24);
            this.lblDigitalClock.TabIndex = 2;
            this.lblDigitalClock.Text = "00:00:00 PM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 672);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "v1.0";
            // 
            // btnTabDangXuat
            // 
            this.btnTabDangXuat.FlatAppearance.BorderSize = 0;
            this.btnTabDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnTabDangXuat.Image = global::management_store.Properties.Resources.icons8_exit_48;
            this.btnTabDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabDangXuat.Location = new System.Drawing.Point(0, 528);
            this.btnTabDangXuat.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnTabDangXuat.Name = "btnTabDangXuat";
            this.btnTabDangXuat.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnTabDangXuat.Size = new System.Drawing.Size(216, 69);
            this.btnTabDangXuat.TabIndex = 1;
            this.btnTabDangXuat.Text = "     ĐĂNG XUẤT";
            this.btnTabDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTabDangXuat.UseVisualStyleBackColor = true;
            this.btnTabDangXuat.Click += new System.EventHandler(this.btnTabDangXuat_Click);
            // 
            // btnTabNhanVien
            // 
            this.btnTabNhanVien.FlatAppearance.BorderSize = 0;
            this.btnTabNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnTabNhanVien.Image = global::management_store.Properties.Resources.icons8_group_48;
            this.btnTabNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabNhanVien.Location = new System.Drawing.Point(0, 453);
            this.btnTabNhanVien.Name = "btnTabNhanVien";
            this.btnTabNhanVien.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnTabNhanVien.Size = new System.Drawing.Size(221, 69);
            this.btnTabNhanVien.TabIndex = 1;
            this.btnTabNhanVien.Text = "     NHÂN VIÊN";
            this.btnTabNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTabNhanVien.UseVisualStyleBackColor = true;
            this.btnTabNhanVien.Click += new System.EventHandler(this.btnTabNhanVien_Click);
            // 
            // btnTabDoanhThu
            // 
            this.btnTabDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnTabDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnTabDoanhThu.Image = global::management_store.Properties.Resources.icons8_statistics_48;
            this.btnTabDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabDoanhThu.Location = new System.Drawing.Point(0, 378);
            this.btnTabDoanhThu.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnTabDoanhThu.Name = "btnTabDoanhThu";
            this.btnTabDoanhThu.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnTabDoanhThu.Size = new System.Drawing.Size(221, 69);
            this.btnTabDoanhThu.TabIndex = 1;
            this.btnTabDoanhThu.Text = "     DOANH THU";
            this.btnTabDoanhThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTabDoanhThu.UseVisualStyleBackColor = true;
            this.btnTabDoanhThu.Click += new System.EventHandler(this.btnTabDoanhThu_Click);
            // 
            // btnTabSanPham
            // 
            this.btnTabSanPham.FlatAppearance.BorderSize = 0;
            this.btnTabSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabSanPham.ForeColor = System.Drawing.Color.White;
            this.btnTabSanPham.Image = global::management_store.Properties.Resources.icons8_product_48;
            this.btnTabSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabSanPham.Location = new System.Drawing.Point(0, 303);
            this.btnTabSanPham.Name = "btnTabSanPham";
            this.btnTabSanPham.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTabSanPham.Size = new System.Drawing.Size(221, 69);
            this.btnTabSanPham.TabIndex = 1;
            this.btnTabSanPham.Text = "        SẢN PHẨM";
            this.btnTabSanPham.UseVisualStyleBackColor = true;
            this.btnTabSanPham.Click += new System.EventHandler(this.btnTabSanPham_Click);
            // 
            // btnTabHoaDon
            // 
            this.btnTabHoaDon.FlatAppearance.BorderSize = 0;
            this.btnTabHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnTabHoaDon.Image = global::management_store.Properties.Resources.icons8_receipt_48;
            this.btnTabHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabHoaDon.Location = new System.Drawing.Point(0, 228);
            this.btnTabHoaDon.Name = "btnTabHoaDon";
            this.btnTabHoaDon.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTabHoaDon.Size = new System.Drawing.Size(221, 69);
            this.btnTabHoaDon.TabIndex = 1;
            this.btnTabHoaDon.Text = "      HÓA ĐƠN";
            this.btnTabHoaDon.UseVisualStyleBackColor = true;
            this.btnTabHoaDon.Click += new System.EventHandler(this.btnTabHoaDon_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Image = global::management_store.Properties.Resources.icons8_bar_chart_32;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 153);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(221, 69);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "       DASHBOARD";
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseMnemonic = false;
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(221, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(1103, 49);
            this.pnlBar.TabIndex = 1;
            this.pnlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseDown);
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(221, 47);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1103, 661);
            this.pnlMain.TabIndex = 2;
            // 
            // timerDigitalClock
            // 
            this.timerDigitalClock.Enabled = true;
            this.timerDigitalClock.Interval = 1000;
            this.timerDigitalClock.Tick += new System.EventHandler(this.timerDigitalClock_Tick);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(199)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1324, 708);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBar);
            this.Controls.Add(this.pnlTab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị viên";
            this.pnlTab.ResumeLayout(false);
            this.pnlTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTab;
        private System.Windows.Forms.Button btnTabDangXuat;
        private System.Windows.Forms.Button btnTabDoanhThu;
        private System.Windows.Forms.Button btnTabSanPham;
        private System.Windows.Forms.Button btnTabHoaDon;
        private System.Windows.Forms.Panel pnlBar;
        public System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerDigitalClock;
        private System.Windows.Forms.Label lblDigitalClock;
        public System.Windows.Forms.Button btnTabNhanVien;
    }
}