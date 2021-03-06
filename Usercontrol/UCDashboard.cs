using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace management_store
{
    public partial class UCDashboard : UserControl
    {
        #region Properties
        private Image hinhAnh = null;
        private BusinessLogicLayer bll = new BusinessLogicLayer();
        private DataTable dt;
        static UCDashboard _obj;
        private int ID_NhanVien;
        public static int maNhanVien;
        public static UCDashboard Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new UCDashboard();
                }
                return _obj;
            }
        }
        #endregion

        public UCDashboard()
        {
            InitializeComponent();
        }

        public int IDNhanVien
        {
            get { return ID_NhanVien; }
            set { ID_NhanVien = value; }
        }

        #region Contact
        private void picFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/hoaffffff/");

        }

        private void picInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/hoaffffffffff/");
            
        }

        private void picYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/quochoaeditor");
        }

        private void picPinterest_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pinterest.com/hoadaknong101/");
        }
        #endregion

        #region Address
        private void picLocationTruong_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps/place/Tr%C6%B0%E1%BB%9Dng+%C4%90%E1%BA%A1i+h%E1%BB%8Dc+S%C6%B0+ph%E1%BA%A1m+K%E1%BB%B9+thu%E1%BA%ADt+Th%C3%A0nh+ph%E1%BB%91+H%E1%BB%93+Ch%C3%AD+Minh/@10.8507267,106.7697336,17z/data=!3m1!4b1!4m5!3m4!1s0x31752763f23816ab:0x282f711441b6916f!8m2!3d10.8507214!4d106.7719223?hl=vi-VN");
        }

        private void picLocation2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps/place/484+%C4%90.+L%C3%AA+V%C4%83n+Vi%E1%BB%87t,+T%C4%83ng+Nh%C6%A1n+Ph%C3%BA+A,+Qu%E1%BA%ADn+9,+Th%C3%A0nh+ph%E1%BB%91+H%E1%BB%93+Ch%C3%AD+Minh,+Vi%E1%BB%87t+Nam/@10.8452589,106.7945554,17z/data=!3m1!4b1!4m5!3m4!1s0x3175273e5b95f75d:0x774a073b596e07ab!8m2!3d10.8452536!4d106.7967441?hl=vi-VN");
        }

        private void picLocation1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps/place/Tr%C6%B0%E1%BB%9Dng+%C4%90%E1%BA%A1i+h%E1%BB%8Dc+S%C6%B0+ph%E1%BA%A1m+K%E1%BB%B9+thu%E1%BA%ADt+Th%C3%A0nh+ph%E1%BB%91+H%E1%BB%93+Ch%C3%AD+Minh/@10.8507267,106.7697336,17z/data=!3m1!4b1!4m5!3m4!1s0x31752763f23816ab:0x282f711441b6916f!8m2!3d10.8507214!4d106.7719223?hl=vi-VN");
        }
        #endregion

        private Image ByteArrayToImage(byte[] b)
        {
            MemoryStream ms = new MemoryStream(b);
            Image img = Image.FromStream(ms, true);
            return img;
        }

        public void LoadData()
        {
            dt = bll.ThongTinNhanVien(IDNhanVien);
            lblSoLuongHoaDon.Text = bll.SoLuongHoaDon() + "";
            try
            {
                lblMaNhanVien.Text = "Mã Nhân Viên : " + dt.Rows[0][0].ToString();
                lblHoTenNhanVien.Text = "Họ Và Tên : " + dt.Rows[0][1].ToString();
                lblGioiTinh.Text = "Giới Tính : " + dt.Rows[0][5].ToString();
                lblChucVu.Text = "Chức Vụ : " + dt.Rows[0][8].ToString();
                lblLienHe.Text = "Liên Hệ : " + dt.Rows[0][2].ToString();
                hinhAnh = ByteArrayToImage((byte[])dt.Rows[0][4]);
                picNhanVien.Image = hinhAnh;
            }
            catch
            {
                MessageBox.Show("Không thể hiển thị thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblSoLuongNhanVien.Text = bll.SoLuongNhanVien().ToString();
            lblSoLuongHoaDon.Text = bll.SoLuongHoaDon().ToString();
            lbl_SoLuongSPDaBan.Text = bll.SoLuongSanPhamDaBan().ToString();
            lbl_SoLuongSPTrongKho.Text = bll.SoLuongSanPhamTrongKho().ToString();
        }

        private void UCDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            new frmDoiMatKhau(ID_NhanVien).ShowDialog();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            new frmDoiThongTinCaNhan(ID_NhanVien).ShowDialog();
            LoadData();
        }
    }
}
