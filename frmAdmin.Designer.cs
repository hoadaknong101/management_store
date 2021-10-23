
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
            this.btnPower = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.timerDigitalClock = new System.Windows.Forms.Timer(this.components);
            this.ucHoaDon1 = new management_store.UCHoaDon();
            this.pnlTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBar.SuspendLayout();
            this.pnlMain.SuspendLayout();
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
            this.lblDigitalClock.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDigitalClock.ForeColor = System.Drawing.Color.White;
            this.lblDigitalClock.Location = new System.Drawing.Point(56, 623);
            this.lblDigitalClock.Name = "lblDigitalClock";
            this.lblDigitalClock.Size = new System.Drawing.Size(123, 27);
            this.lblDigitalClock.TabIndex = 2;
            this.lblDigitalClock.Text = "00:00:00 PM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 672);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "v1.0";
            // 
            // btnTabDangXuat
            // 
            this.btnTabDangXuat.FlatAppearance.BorderSize = 0;
            this.btnTabDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabDangXuat.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTabDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnTabDangXuat.Image = global::management_store.Properties.Resources.icons8_exit_48;
            this.btnTabDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabDangXuat.Location = new System.Drawing.Point(0, 528);
            this.btnTabDangXuat.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnTabDangXuat.Name = "btnTabDangXuat";
            this.btnTabDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTabDangXuat.Size = new System.Drawing.Size(216, 69);
            this.btnTabDangXuat.TabIndex = 1;
            this.btnTabDangXuat.Text = "    ĐĂNG XUẤT";
            this.btnTabDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTabDangXuat.UseVisualStyleBackColor = true;
            // 
            // btnTabNhanVien
            // 
            this.btnTabNhanVien.FlatAppearance.BorderSize = 0;
            this.btnTabNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabNhanVien.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTabNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnTabNhanVien.Image = global::management_store.Properties.Resources.icons8_group_48;
            this.btnTabNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabNhanVien.Location = new System.Drawing.Point(0, 453);
            this.btnTabNhanVien.Name = "btnTabNhanVien";
            this.btnTabNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTabNhanVien.Size = new System.Drawing.Size(221, 69);
            this.btnTabNhanVien.TabIndex = 1;
            this.btnTabNhanVien.Text = "    NHÂN VIÊN";
            this.btnTabNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTabNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnTabDoanhThu
            // 
            this.btnTabDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnTabDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabDoanhThu.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTabDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnTabDoanhThu.Image = global::management_store.Properties.Resources.icons8_statistics_48;
            this.btnTabDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabDoanhThu.Location = new System.Drawing.Point(0, 378);
            this.btnTabDoanhThu.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnTabDoanhThu.Name = "btnTabDoanhThu";
            this.btnTabDoanhThu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTabDoanhThu.Size = new System.Drawing.Size(221, 69);
            this.btnTabDoanhThu.TabIndex = 1;
            this.btnTabDoanhThu.Text = "    DOANH THU";
            this.btnTabDoanhThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTabDoanhThu.UseVisualStyleBackColor = true;
            // 
            // btnTabSanPham
            // 
            this.btnTabSanPham.FlatAppearance.BorderSize = 0;
            this.btnTabSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabSanPham.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTabSanPham.ForeColor = System.Drawing.Color.White;
            this.btnTabSanPham.Image = global::management_store.Properties.Resources.icons8_product_48;
            this.btnTabSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabSanPham.Location = new System.Drawing.Point(0, 303);
            this.btnTabSanPham.Name = "btnTabSanPham";
            this.btnTabSanPham.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTabSanPham.Size = new System.Drawing.Size(221, 69);
            this.btnTabSanPham.TabIndex = 1;
            this.btnTabSanPham.Text = "         SẢN PHẨM";
            this.btnTabSanPham.UseVisualStyleBackColor = true;
            this.btnTabSanPham.Click += new System.EventHandler(this.btnTabSanPham_Click);
            // 
            // btnTabHoaDon
            // 
            this.btnTabHoaDon.FlatAppearance.BorderSize = 0;
            this.btnTabHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabHoaDon.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTabHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnTabHoaDon.Image = global::management_store.Properties.Resources.icons8_receipt_48;
            this.btnTabHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabHoaDon.Location = new System.Drawing.Point(0, 228);
            this.btnTabHoaDon.Name = "btnTabHoaDon";
            this.btnTabHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTabHoaDon.Size = new System.Drawing.Size(221, 69);
            this.btnTabHoaDon.TabIndex = 1;
            this.btnTabHoaDon.Text = "        HÓA ĐƠN";
            this.btnTabHoaDon.UseVisualStyleBackColor = true;
            this.btnTabHoaDon.Click += new System.EventHandler(this.btnTabHoaDon_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Image = global::management_store.Properties.Resources.icons8_bar_chart_32;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 153);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(221, 69);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "     DASHBOARD";
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBar.Controls.Add(this.btnPower);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(221, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(1103, 49);
            this.pnlBar.TabIndex = 1;
            this.pnlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseDown);
            // 
            // btnPower
            // 
            this.btnPower.FlatAppearance.BorderSize = 0;
            this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPower.Font = new System.Drawing.Font("SVN-Avo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPower.ForeColor = System.Drawing.Color.White;
            this.btnPower.Image = global::management_store.Properties.Resources.icons8_delete_sign_filled_32;
            this.btnPower.Location = new System.Drawing.Point(1044, 1);
            this.btnPower.Name = "btnPower";
            this.btnPower.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPower.Size = new System.Drawing.Size(59, 45);
            this.btnPower.TabIndex = 1;
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.ucHoaDon1);
            this.pnlMain.Location = new System.Drawing.Point(221, 47);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1110, 666);
            this.pnlMain.TabIndex = 2;
            // 
            // timerDigitalClock
            // 
            this.timerDigitalClock.Enabled = true;
            this.timerDigitalClock.Interval = 1000;
            this.timerDigitalClock.Tick += new System.EventHandler(this.timerDigitalClock_Tick);
            // 
            // ucHoaDon1
            // 
            this.ucHoaDon1.AutoSize = true;
            this.ucHoaDon1.BackColor = System.Drawing.Color.White;
            this.ucHoaDon1.Location = new System.Drawing.Point(0, 0);
            this.ucHoaDon1.Margin = new System.Windows.Forms.Padding(0);
            this.ucHoaDon1.MaximumSize = new System.Drawing.Size(1100, 655);
            this.ucHoaDon1.MinimumSize = new System.Drawing.Size(1100, 655);
            this.ucHoaDon1.Name = "ucHoaDon1";
            this.ucHoaDon1.Size = new System.Drawing.Size(1100, 655);
            this.ucHoaDon1.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(199)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1324, 708);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBar);
            this.Controls.Add(this.pnlTab);
            this.Font = new System.Drawing.Font("SVN-Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị viên";
            this.pnlTab.ResumeLayout(false);
            this.pnlTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTab;
        private System.Windows.Forms.Button btnTabDangXuat;
        private System.Windows.Forms.Button btnTabNhanVien;
        private System.Windows.Forms.Button btnTabDoanhThu;
        private System.Windows.Forms.Button btnTabSanPham;
        private System.Windows.Forms.Button btnTabHoaDon;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Button btnPower;
        public System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerDigitalClock;
        private System.Windows.Forms.Label lblDigitalClock;
        private UCHoaDon ucHoaDon1;
    }
}