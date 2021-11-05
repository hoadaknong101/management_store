using System;
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
            InitializeComponent();
            UCDashboard.Instance.IDNhanVien = ID_NhanVien;
            UCHoaDon.Instance.IDNhanVien = ID_NhanVien;
            timerDigitalClock.Enabled = true;
            timerDigitalClock.Start();
            
            // Add UserControl
            pnlMain.Controls.Add(UCDashboard.Instance);
            pnlMain.Controls.Add(UCHoaDon.Instance);
            pnlMain.Controls.Add(UCSanPham.Instance);
            pnlMain.Controls.Add(UCDoanhThu.Instance);
            pnlMain.Controls.Add(UCNhanVien.Instance);
            UCDashboard.Instance.BringToFront();

            this.ID_NhanVien = ID_NhanVien;
        }

        private void pnlBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #region TabControl
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
        private void btnTabDangXuat_Click(object sender, EventArgs e)
        {
           
            if(MessageBox.Show("Bạn có muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }            
        }
        private void btnTabNhanVien_Click(object sender, EventArgs e)
        {
            UCNhanVien.Instance.BringToFront();
        }
        private void btnTabDoanhThu_Click(object sender, EventArgs e)
        {
            UCDoanhThu.Instance.BringToFront();
        }
        #endregion

        private void timerDigitalClock_Tick(object sender, EventArgs e)
        {
            lblDigitalClock.Text = DateTime.Now.ToString("T");
        }
    }
}
