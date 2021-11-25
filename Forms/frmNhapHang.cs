using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace management_store
{
    public partial class frmNhapHang : Form
    {
        DataTable dtNhaSanXuat;
        public float tongTien;
        public frmNhapHang()
        {
            InitializeComponent();
            LoadData();
        }

        #region ChucNang
        private void LoadData()
        {
            DataTable dt = BusinessLogicLayer.Instance().ThongTinNhanVien(UCDashboard.Instance.IDNhanVien);
            txtMaNhanVien.Text = dt.Rows[0][0].ToString();
            txtTenNhanVien.Text = dt.Rows[0][1].ToString();

            dtNhaSanXuat = BusinessLogicLayer.Instance().DanhSachNhaSanXuat();
            List<string> lstMaNSX = new List<string>();
            for (int i = 0; i < dtNhaSanXuat.Rows.Count; i++)
            {
                lstMaNSX.Add(dtNhaSanXuat.Rows[i][0].ToString());
            }
            cbbMaNhaSanXuat.DataSource = lstMaNSX;

            txtTenNhaSanXuat.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text.ToString()), 1);
            txtDiaChi.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 2);
            txtLienHe.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 3);
            txtWebsite.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 4);
            txtZipCode.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 5);
            txtKhuVuc.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 6);
            txtMaPhieu.Text = TaoMaHoaDon(DateTime.Now) + "";
        }
        private void cbbMaNhaSanXuat_TextChanged(object sender, EventArgs e)
        {
            txtTenNhaSanXuat.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text.ToString()), 1);
            txtDiaChi.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 2);
            txtLienHe.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 3);
            txtWebsite.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 4);
            txtZipCode.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 5);
            txtKhuVuc.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 6);
        }
        private long TaoMaHoaDon(DateTime now)
        {
            long maNgay = 1000000000000 * now.Day;
            long maThang = 10000000000 * now.Month;
            long maNam = 1000000 * now.Year;
            long maGio = 10000 * now.Hour;
            long maPhut = 100 * now.Minute;
            long maGiay = now.Second;
            long maHoaDon = maNgay + maThang + maNam + maGio + maPhut + maGiay;
            return maHoaDon;
        }
        private bool KiemTraPhieuNhap()
        {
            if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return false;
            }
            if (txtTenNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return false;
            }
            return true;
        }

        #endregion

        #region Control
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn tạo mới danh sách đã nhập?", "Tạo mới danh sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvChiTietPhieuNhap.Rows.Clear();
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            long maPhieuNhap = TaoMaHoaDon(now);
            if (dgvChiTietPhieuNhap.RowCount < 2)
            {
                MessageBox.Show("Hãy thêm sản phẩm vào trong bảng", "Thêm sản phẩm");
                return;
            }
            if (MessageBox.Show("Bạn có muôn nhập thêm " + (dgvChiTietPhieuNhap.RowCount - 1) + " sản phẩm mới?", "Nhập hàng vào kho", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (KiemTraPhieuNhap())
                {
                    try
                    {
                        BusinessLogicLayer.Instance().ThemPhieuNhapHang(maPhieuNhap + "", now, int.Parse(txtMaNhanVien.Text.Trim()), tongTien);
                        for (int i = 0; i < dgvChiTietPhieuNhap.RowCount - 1; i++)
                        {
                            if (dgvChiTietPhieuNhap.Rows[i].Cells[1].Value == null || dgvChiTietPhieuNhap.Rows[i].Cells[2].Value == null)
                            {
                                throw new Exception();
                            }
                            int maSanPham = int.Parse(dgvChiTietPhieuNhap.Rows[i].Cells[0].Value.ToString());
                            float donGia = float.Parse(dgvChiTietPhieuNhap.Rows[i].Cells[1].Value.ToString());
                            int soLuong = int.Parse(dgvChiTietPhieuNhap.Rows[i].Cells[2].Value.ToString());
                            BusinessLogicLayer.Instance().ThemChiTietPhieuNhapHang(maPhieuNhap + "", maSanPham, donGia, soLuong);
                        }

                        MessageBox.Show("Thêm thành công!\n", "Thông báo", MessageBoxButtons.OK);
                        UCDoanhThu.Instance.TakeInfor();
                        UCDoanhThu.Instance.LoadData();
                        UCSanPham.Instance.SettingSanPham();
                        Hide();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Lỗi dữ liệu trên bảng!\nVui lòng nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

        }
        private void dgvChiTietPhieuNhap_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            tongTien = 0;
            try
            {
                for (int i = 0; i < dgvChiTietPhieuNhap.RowCount; i++)
                {
                    try
                    {
                        if (dgvChiTietPhieuNhap.Rows[i].Cells[1].Value == null || dgvChiTietPhieuNhap.Rows[i].Cells[2].Value == null)
                        {
                            throw new Exception();
                        }
                        float soLuong = float.Parse(dgvChiTietPhieuNhap.Rows[i].Cells[2].Value.ToString());
                        tongTien += float.Parse(dgvChiTietPhieuNhap.Rows[i].Cells[1].Value.ToString()) * soLuong;
                    }
                    catch
                    {
                        return;
                    }
                    lblTongTien.Text = "Tổng tiền : " + tongTien.ToString("N", CultureInfo.InvariantCulture) + " VNĐ";
                }
            }
            catch
            {
                return;
            }
        }
        #endregion
    }
}
