using System;
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
        BLL func = new BLL();
        
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
            txtMaSP.Enabled = false;
            DisableOnControl();
        }

        #region Chuc_nang
        private void SettingSanPham()
        {
            dtb = func.ThongTinSanPham();
            dgvSanPham.DataSource = dtb;

            dgvSanPham.Columns[4].Visible = false;
            dgvSanPham.Columns[0].HeaderText = "Mã";
            dgvSanPham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvSanPham.Columns[2].HeaderText = "Loại Sản Phẩm";
            dgvSanPham.Columns[3].HeaderText = "Đơn Giá";
            dgvSanPham.Columns[5].HeaderText = "Mã NSX";
            dgvSanPham.Columns[6].HeaderText = "Số Lượng";

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
        private void DisableOnControl()
        {
            txtTenSanPham.Enabled = false;
            txtDonGia.Enabled = false;
            txtSoLuong.Enabled = false;
            txtLoaiSP.Enabled = false;
            txtMaNSX.Enabled = false;
            btnChonHinhAnh.Enabled = false;
        }
        private void EnabledOnControl()
        {
            txtTenSanPham.Enabled = true;
            txtDonGia.Enabled = true;
            txtSoLuong.Enabled = true;
            txtLoaiSP.Enabled = true;
            txtMaNSX.Enabled = true;
            btnChonHinhAnh.Enabled = true;
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
                picImage.Image = ByteArrayToImage((byte[]) dgvSanPham.CurrentRow.Cells[4].Value);
                
            }
            catch
            {
                return;
            }
            finally
            {
                btnThemSanPham.Enabled = false;
                btnLuuSP.Enabled = true;
                btnXoaSP.Enabled = true;
                btnHuy.Enabled = true;
                EnabledOnControl();
            }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            ClearContent();
            txtTenSanPham.Focus();
            btnLuuSP.Enabled = true;
            btnHuy.Enabled = true;
            EnabledOnControl();
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            if (!KiemTraDauVao())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (!btnThemSanPham.Enabled)
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
                    }
                    catch
                    {
                        MessageBox.Show("Không thể cập nhật sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        dgvSanPham.Controls.Clear();
                        SettingSanPham();
                        DisableOnControl();
                    }
                }
                else
                {
                    //Thêm sản phẩm
                    try
                    {
                        func.ThemSanPham(txtTenSanPham.Text, txtLoaiSP.Text, float.Parse(txtDonGia.Text), 
                            picImage.Image, int.Parse(txtMaNSX.Text), int.Parse(txtSoLuong.Text));
                    }
                    catch
                    {
                        MessageBox.Show("Có vấn đề khi thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        dgvSanPham.Controls.Clear();
                        SettingSanPham();
                        DisableOnControl();
                    }
                }
                ClearContent();
                btnThemSanPham.Enabled = true;
                btnXoaSP.Enabled = false;
                btnLuuSP.Enabled = false;
                btnHuy.Enabled = false;
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn có muốn xóa sản phẩm\n" + txtTenSanPham.Text, "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    func.XoaSanPham(int.Parse(txtMaSP.Text));
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong khi xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                dgvSanPham.Controls.Clear();
                SettingSanPham();
                ClearContent();
                btnThemSanPham.Enabled = true;
                btnXoaSP.Enabled = false;
                btnLuuSP.Enabled = false;
                btnHuy.Enabled = false;
                DisableOnControl();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearContent();
            btnThemSanPham.Enabled = true;
            btnXoaSP.Enabled = false;
            btnLuuSP.Enabled = false;
            btnHuy.Enabled = false;
            DisableOnControl();
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
        #endregion

        private void btnThemSanPham_EnabledChanged(object sender, EventArgs e)
        {
            btnLuuSP.Text = btnThemSanPham.Enabled ? "Lưu" : "Cập nhật";
        }
    }
}
