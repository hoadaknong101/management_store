using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace management_store
{
    public partial class UCNhanVien : UserControl
    {
        public DataTable dtb = new DataTable();
        BusinessLogicLayer bll = new BusinessLogicLayer();
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
            txtMaNV.Enabled = false;
            DisableOnControl();
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
            dgvNhanVien.Columns[8].HeaderText = "Chức vụ";
        }
        private void ClearContent()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtLienHe.Clear();
            txtDiaChi.Clear();
            txtGioiTinh.Clear();
            txtCCCD.Clear();
            picImage.Image = null;
        }
        private void DisableOnControl()
        {
            txtHoTen.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtCCCD.Enabled = false;
            txtDiaChi.Enabled = false;
            txtLienHe.Enabled = false;
            btnChonHinhAnh.Enabled = false;
        }
        private void EnabledOnControl()
        {
            txtHoTen.Enabled = true;
            txtGioiTinh.Enabled = true;
            txtCCCD.Enabled = true;
            txtDiaChi.Enabled = true;
            txtLienHe.Enabled = true;
            btnChonHinhAnh.Enabled = true;
        }
        private bool KiemTraDauVao()
        {
            if (txtHoTen.Text.Trim() == "" || txtCCCD.Text.Trim() == "" ||
                txtDiaChi.Text.Trim() == "" || txtGioiTinh.Text.Trim() == "" ||
                txtLienHe.Text.Trim() == "" || picImage.Image == null)
            {
                return false;
            }
            return true;
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
            string pathImage;
            OpenFileDialog chonHinhAnh = new OpenFileDialog();
            if (chonHinhAnh.ShowDialog() == DialogResult.OK)
            {
                pathImage = chonHinhAnh.FileName;
                picImage.Image = Image.FromFile(pathImage);
            }
        }
        #endregion

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtHoTen.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                txtLienHe.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                txtGioiTinh.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
                txtCCCD.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
                picImage.Image = null;
                picImage.Image = (ByteArrayToImage((byte[]) dgvNhanVien.CurrentRow.Cells[4].Value));
            }
            catch
            {
            }
            finally
            {
                EnabledOnControl();
                btnThemNhanVien.Enabled = false;
                btnLuuNhanVien.Enabled = true;
                btnXoaNhanVien.Enabled = true;
                btnHuy.Enabled = true;
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            ClearContent();
            txtHoTen.Focus();
            btnLuuNhanVien.Enabled = true;
            btnHuy.Enabled = true;
            EnabledOnControl();
        }

        private void btnLuuNhanVien_Click(object sender, EventArgs e)
        {
            if (!KiemTraDauVao())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (!btnThemNhanVien.Enabled)
                {
                    //Cập nhật nhân viên
                    try
                    {
                        bll.CapNhatNhanVien(int.Parse(txtMaNV.Text),txtHoTen.Text,txtLienHe.Text,txtDiaChi.Text,picImage.Image,txtGioiTinh.Text,txtCCCD.Text);
                        MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Không thể cập nhật nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        dgvNhanVien.Controls.Clear();
                        SettingData();
                        DisableOnControl();
                    }
                }
                else
                {
                    //Thêm nhân viên
                    try
                    {
                        bll.ThemNhanVien(txtHoTen.Text, txtLienHe.Text, txtDiaChi.Text, picImage.Image, txtGioiTinh.Text, txtCCCD.Text, cbbChucVu.Text, txtMatKhau.Text);
                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Có vấn đề khi thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dgvNhanVien.Controls.Clear();
                    SettingData();
                    DisableOnControl();
                }
                ClearContent();
                btnThemNhanVien.Enabled = true;
                btnXoaNhanVien.Enabled = false;
                btnLuuNhanVien.Enabled = false;
                btnHuy.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearContent();
            btnThemNhanVien.Enabled = true;
            btnXoaNhanVien.Enabled = false;
            btnLuuNhanVien.Enabled = false;
            btnHuy.Enabled = false;
            DisableOnControl();
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa nhân viên\n" + txtHoTen.Text, "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bll.XoaNhanVien(int.Parse(txtMaNV.Text));
                    MessageBox.Show("Đã xóa thông tin nhân viên!", "Thông báo");
                    DisableOnControl();
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong khi xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                dgvNhanVien.Controls.Clear();
                SettingData();
                ClearContent();
                btnThemNhanVien.Enabled = true;
                btnXoaNhanVien.Enabled = false;
                btnLuuNhanVien.Enabled = false;
                btnHuy.Enabled = false;
            }
        }
    }
}
