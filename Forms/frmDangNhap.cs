using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
        BusinessLogicLayer bll = new BusinessLogicLayer();
        public frmDangNhap()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {

        }

        #region Control_Form
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
            if(MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }            
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
        #endregion

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            loaderDangNhap.Enabled = true;
            loaderDangNhap.Visible = true;
            string vaiTro = "";
            if (rdbAdmin.Checked)
            {
                vaiTro = "Admin";
            }
            if (rdbNhanVien.Checked)
            {
                vaiTro = "Nhân Viên";
            }
            if (KiemTraThongTinDauVao())
            {
                if (bll.KiemTraThongTinDangNhap(int.Parse(txtTenTaiKhoan.Text.Trim()), txtMatKhau.Text, vaiTro))
                {
                    if (vaiTro == "Admin")
                    {
                        this.Hide();
                        frmAdmin form = new frmAdmin(int.Parse(txtTenTaiKhoan.Text.Trim()));
                        form.ShowDialog();
                        txtTenTaiKhoan.Clear();
                        txtMatKhau.Clear();                        
                        this.Show();
                        loaderDangNhap.Visible = false;
                        loaderDangNhap.Enabled = false;
                        
                    }
                    else
                    {
                        frmAdmin form = new frmAdmin(int.Parse(txtTenTaiKhoan.Text.Trim()));
                        form.btnTabNhanVien.Enabled = false;
                        this.Hide();
                        form.ShowDialog();
                        txtTenTaiKhoan.Clear();
                        txtMatKhau.Clear();
                        this.Show();
                        loaderDangNhap.Visible = false;
                        loaderDangNhap.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Sai thông tin tài khoản \n hoặc mật khẩu!!", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loaderDangNhap.Visible = false;
                    loaderDangNhap.Enabled = false;
                    return;
                }
            }
            else MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            loaderDangNhap.Visible = false;
            loaderDangNhap.Enabled = false;
        }

        private bool KiemTraThongTinDauVao()
        {
            if (txtTenTaiKhoan.Text.Trim() == "Tên tài khoản" || txtTenTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return false;
            }
            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return false;
            }
            return true;
        }

        private void lblNhanVien_Click(object sender, EventArgs e)
        {
            if (rdbNhanVien.Checked == false)
            {
                rdbNhanVien.Checked = true;
                rdbAdmin.Checked = false;
                rdbAdmin.OutlineColorUnchecked = System.Drawing.Color.White;
            }
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            if (rdbAdmin.Checked == false)
            {
                rdbAdmin.Checked = true;
                rdbNhanVien.Checked = false;
                rdbNhanVien.OutlineColorUnchecked = System.Drawing.Color.White;
            }
        }
    }
}
