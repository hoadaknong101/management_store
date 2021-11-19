using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace management_store
{
    public partial class UCSanPham : UserControl
    {
        #region Properties
        private DataTable dtb;
        static UCSanPham _obj;
        private bool flagThem = false;
        BusinessLogicLayer func = new BusinessLogicLayer();
        
        public static UCSanPham Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCSanPham();
                }

                return _obj;
            }
        }
        #endregion

        public UCSanPham()
        {
            InitializeComponent();
            SettingSanPham();
            txtMaSP.ReadOnly = true;
            DisableControl();
            LoadComboBox();
        }
        private void LoadComboBox()
        {
            List<string> lstLoai = new List<string>();
            DataTable dt = BusinessLogicLayer.Instance().DanhSachLoaiSanPhan();
            lstLoai.Add("Tất cả");
            for (int i =0;i< dt.Rows.Count;i++)
            {
                lstLoai.Add(dt.Rows[i][0].ToString());
            }
            cbbPhanLoai.DataSource = lstLoai;
        }

        #region Chuc_nang
        public void SettingSanPham()
        {
            dgvSanPham.Controls.Clear();
            dtb = func.ThongTinSanPham();
            dgvSanPham.DataSource = dtb;
            dgvSanPham.Columns[0].Width = 55;
            dgvSanPham.Columns[2].Width = 140;
            dgvSanPham.Columns[5].Width = 100;

            dgvSanPham.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ClearContent()
        {
            txtTenSanPham.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtLoaiSP.Clear();
            txtMaNSX.Clear();
            txtMaSP.Clear();
            picImage.Image = null;
            dgvSanPham.ClearSelection();
        }
        private bool KiemTraDauVao()
        {
            if (txtTenSanPham.Text.Trim().Equals("") ||
                txtDonGia.Text.Trim().Equals("") ||
                txtSoLuong.Text.Trim().Equals("") ||
                txtLoaiSP.Text.Trim().Equals("") ||
                txtMaNSX.Text.Trim().Equals("") ||
                picImage.Image == null)
            {
                return false;
            }
            return true;
        }
        private void DisableControl()
        {
            ClearContent();
            txtTenSanPham.Enabled = false;
            txtDonGia.Enabled = false;
            txtSoLuong.Enabled = false;
            txtLoaiSP.Enabled = false;
            txtMaNSX.Enabled = false;
            btnChonHinhAnh.Enabled = false;

            btnThemSanPham.Enabled = true;
            btnLuuSP.Enabled = false;
            btnHuy.Enabled = false;
            btnXoaSP.Enabled = false;
        }
        private void EnabledControl()
        {
            txtTenSanPham.Enabled = true;
            txtDonGia.Enabled = true;
            txtSoLuong.Enabled = true;
            txtLoaiSP.Enabled = true;
            txtMaNSX.Enabled = true;
            btnChonHinhAnh.Enabled = true;

            btnThemSanPham.Enabled = false;
            btnLuuSP.Enabled = true;
            btnHuy.Enabled = true;
            btnXoaSP.Enabled = true;
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
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaSP.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
                txtTenSanPham.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
                txtDonGia.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
                txtLoaiSP.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
                txtSoLuong.Text = dgvSanPham.CurrentRow.Cells[6].Value.ToString();
                txtMaNSX.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
                if (DBNull.Value.Equals(dgvSanPham.CurrentRow.Cells[4].Value))
                {
                    picImage.Image = null;
                }
                else
                {
                    picImage.Image = ByteArrayToImage((byte[])dgvSanPham.CurrentRow.Cells[4].Value);
                }
                EnabledControl();
            }
            catch
            {
                MessageBox.Show("Không thể hiển thị thông tin sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            ClearContent();
            flagThem = true;
            txtTenSanPham.Focus();
            EnabledControl();
            dgvSanPham.Enabled = false;
            btnXoaSP.Enabled = false;
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            if (!KiemTraDauVao())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin\nhoặc chọn hình ảnh trước khi tiếp tục!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (flagThem == false)
                {
                    //Cập nhật sản phẩm
                    try
                    {
                        func.CapNhatSanPham(int.Parse(txtMaSP.Text), txtTenSanPham.Text,
                            txtLoaiSP.Text,
                            float.Parse(txtDonGia.Text),
                            picImage.Image,
                            int.Parse(txtMaNSX.Text),
                            int.Parse(txtSoLuong.Text));
                        MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo");
                        SettingSanPham();
                        LoadComboBox();
                        DisableControl();
                        dgvSanPham.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("Không thể cập nhật sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    //Thêm sản phẩm
                    try
                    {
                        func.ThemSanPham(txtTenSanPham.Text, txtLoaiSP.Text, float.Parse(txtDonGia.Text), 
                            picImage.Image, int.Parse(txtMaNSX.Text), int.Parse(txtSoLuong.Text));
                        MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo");
                        SettingSanPham();
                        LoadComboBox();
                        DisableControl();
                        dgvSanPham.Enabled = true;
                        flagThem = false;
                    }
                    catch
                    {
                        MessageBox.Show("Có vấn đề khi thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn có muốn xóa sản phẩm\n" + txtTenSanPham.Text, "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    func.XoaSanPham(int.Parse(txtMaSP.Text));
                    MessageBox.Show("Đã xóa thông tin sản phẩm!", "Thông báo");
                    
                    SettingSanPham();
                    LoadComboBox();
                    DisableControl();
                    dgvSanPham.Enabled = true;
                    flagThem = false;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong khi xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearContent();
            DisableControl();
            dgvSanPham.Enabled = true;
            flagThem = false;
        }

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
        
        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            new frmNhapHang().Show();
        }

        private void btnNhaSanXuat_Click(object sender, EventArgs e)
        {
            new frmNhaSanXuat().ShowDialog();
        }

        private void cbbPhanLoai_TextChanged(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = BusinessLogicLayer.Instance().DanhSachSanPhamTheoLoai(cbbPhanLoai.Text.Trim());
        }
        #endregion
    }
}
