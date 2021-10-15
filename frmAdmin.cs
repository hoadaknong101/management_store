using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
        public frmAdmin()
        {
            InitializeComponent();
            if (!pnlMain.Controls.Contains(UCDashboard.Instance))
            {
                pnlMain.Controls.Add(UCDashboard.Instance);
            }
            else
            {
                UCDashboard.Instance.BringToFront();
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
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
            if (!pnlMain.Controls.Contains(UCDashboard.Instance))
            {
                pnlMain.Controls.Add(UCDashboard.Instance);
                UCDashboard.Instance.BringToFront();
            }
            else
            {
                UCDashboard.Instance.BringToFront();
            }
        }

        private void btnTabHoaDon_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(UCHoaDon.Instance))
            {
                pnlMain.Controls.Add(UCHoaDon.Instance);
                UCHoaDon.Instance.BringToFront();
            }
            else
            {
                UCHoaDon.Instance.BringToFront();
            }
        }

        private void timerDigitalClock_Tick(object sender, EventArgs e)
        {
            lblDigitalClock.Text = DateTime.Now.ToString("T");
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            timerDigitalClock.Start();
        }

        private void btnTabSanPham_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(UCSanPham.Instance))
            {
                pnlMain.Controls.Add(UCSanPham.Instance);
                UCSanPham.Instance.BringToFront();
            }
            else
            {
                UCSanPham.Instance.BringToFront();
            }
        }

        private void btnTabDoanhThu_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(UCDoanhThu.Instance))
            {
                pnlMain.Controls.Add(UCDoanhThu.Instance);
                UCDoanhThu.Instance.BringToFront();
            }
            else
            {
                UCDoanhThu.Instance.BringToFront();
            }
        }
    }
}
