﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace management_store
{
    public partial class frmAdmin : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        int ID_NhanVien;

        public frmAdmin(int ID_NhanVien)
        {
            UCDashboard.Instance.IDNhanVien = ID_NhanVien;
            UCHoaDon.Instance.IDNhanVien = ID_NhanVien;
            InitializeComponent();
            timerDigitalClock.Enabled = true;
            timerDigitalClock.Start();
            pnlMain.Controls.Add(UCDashboard.Instance);
            pnlMain.Controls.Add(UCHoaDon.Instance);
            pnlMain.Controls.Add(UCSanPham.Instance);
            pnlMain.Controls.Add(UCNhanVien.Instance);
            UCDashboard.Instance.BringToFront();
            this.ID_NhanVien = ID_NhanVien;
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pnlBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

            UCDashboard.Instance.BringToFront();

        }

        private void btnTabHoaDon_Click(object sender, EventArgs e)
        {
            UCHoaDon.Instance.BringToFront();

        }

        private void btnTabSanPham_Click(object sender, EventArgs e)
        {

            UCSanPham.Instance.BringToFront();
        }

        private void timerDigitalClock_Tick(object sender, EventArgs e)
        {
            lblDigitalClock.Text = DateTime.Now.ToString("T");
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTabDangXuat_Click(object sender, EventArgs e)
        {
            
            frmDangNhap form = new frmDangNhap();

            form.Show();
            this.Close();


        }

        private void btnTabNhanVien_Click(object sender, EventArgs e)
        {
            UCNhanVien.Instance.BringToFront();
        }
    }
}
