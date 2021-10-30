using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace management_store
{
    public partial class UCNhanVien : UserControl
    {
        DataTable dtb = new DataTable();
        BLL bll = new BLL();
        private static UCNhanVien _obj;
        public static UCNhanVien Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCNhanVien();
                }
                return _obj;
            }
        }

        public UCNhanVien()
        {
            InitializeComponent();
            SettingData();
        }

        #region ChucNang
        private void SettingData()
        {
            dtb = bll.ThongTinToanBoNhanVien();
            dgvNhanVien.DataSource = dtb;

            dgvNhanVien.Columns[4].Visible = false; //Hình ảnh
            dgvNhanVien.Columns[7].Visible = false; //Mật Khẩu
            dgvNhanVien.Columns[0].HeaderText = "Mã";
            dgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns[2].HeaderText = "Liên hệ";
            dgvNhanVien.Columns[3].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[5].HeaderText = "Giới tính";
            dgvNhanVien.Columns[6].HeaderText = "CCCD";
        }
        #endregion

        #region Convert_Image
        private byte[] ImageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
        private byte[] PathToByteArray(string path)
        {
            return File.ReadAllBytes(path);
        }
        private Image ByteArrayToImage(byte[] b)
        {
            MemoryStream ms = new MemoryStream(b);
            Image img = Image.FromStream(ms, true);
            return img;
        }
        #endregion

        #region Control
        private void btnChonHinhAnh_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {

        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
