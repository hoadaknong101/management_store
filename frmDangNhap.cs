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
using BussinessAccessLayer;

namespace management_store
{
    public partial class frmDangNhap : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmDangNhap()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
        }

        private void frmDangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTenTaiKhoan_Click(object sender, EventArgs e)
        {
            if(txtTenTaiKhoan.Text.Trim() == "Tên tài khoản")
            {
                txtTenTaiKhoan.Clear();
            }

        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.Text.Trim() == "password")
            {
                txtMatKhau.Clear();
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Trim() == "")
            {
                txtMatKhau.Text = "password";
            }
        }

        private void txtTenTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text.Trim() == "")
            {
                txtTenTaiKhoan.Text = "Tên tài khoản";
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text.Trim() == "Tên tài khoản" || txtTenTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            if (rdbAdmin.Checked == false && rdbNhanVien.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn quyền đăng nhập!");
                return;
            }
        }
    }
}
