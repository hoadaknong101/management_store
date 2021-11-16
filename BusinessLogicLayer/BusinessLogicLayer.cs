using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace management_store
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();
        private static BusinessLogicLayer obj;
        public static BusinessLogicLayer Instance()
        {
            if (obj == null)
            {
                obj = new BusinessLogicLayer();
                return obj;
            }
            return obj;
        }
        public BusinessLogicLayer()
        {

        }

        public bool KiemTraThongTinDangNhap(int taiKhoan, string matKhau, string chucVu)
        {
            bool flag = false;
            try
            {
                DataTable dt = dal.ExecuteQueryDataTable("sp_KiemTraDangNhap",
                    CommandType.StoredProcedure,
                    new SqlParameter("@MaNhanVien", taiKhoan),
                    new SqlParameter("@MatKhau", matKhau),
                    new SqlParameter("@ChucVu", chucVu));
                if (dt.Rows.Count > 0)
                {
                    flag = true;
                }
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        #region Chung
        public int SoLuongHoaDon()
        {
            string sql = "SELECT * FROM HoaDon";
            return dal.GetDataToDataTable(sql).Rows.Count;
        }

        public int SoLuongNhanVien()
        {
            string sql = "SELECT dbo.func_SoLuongNhanVien()";
            return int.Parse(dal.ExecuteScalarToGetNumber(sql, CommandType.Text));
        }
        public int SoLuongSanPhamDaBan()
        {
            string sql = "SELECT dbo.func_SoLuongSanPhamDaBan()";
            return int.Parse(dal.ExecuteScalarToGetNumber(sql, CommandType.Text));
        }
        public int SoLuongSanPhamTrongKho()
        {
            string sql = "SELECT dbo.func_SoLuongSanPhamTrongKho()";
            return int.Parse(dal.ExecuteScalarToGetNumber(sql, CommandType.Text));
        }
        public float TongChiTieu()
        {
            string sql = "SELECT dbo.func_TongChiTieu()";
            float value = 0;
            try
            {
                value = float.Parse(dal.ExecuteScalarToGetNumber(sql, CommandType.Text));
            }
            catch
            {

            }
            return value;
        }
        public float TongThuNhap()
        {
            string sql = "SELECT dbo.func_TongThuNhap()";
            float value = 0;
            try
            {
                value = float.Parse(dal.ExecuteScalarToGetNumber(sql, CommandType.Text));
            }
            catch
            {
            }
            return value;
        }
        #endregion

        #region SanPham
        public DataTable ThongTinSanPham()
        {
            string sql = "select MaSanPham as N'ID',TenSanPham as N'Tên SP', LoaiSanPham as N'Loại SP'," +
                "DonGia as N'Đơn giá',HinhAnh as N'Hình ảnh',MaNhaSanXuat as N'Mã NSX', SoLuongTrongKho as N'Số lượng' from SanPham";
            return dal.GetDataToDataTable(sql);
        }
        public DataTable ThongTinSanPhamConHang()
        {
            string sql = "SELECT * FROM SanPham WHERE SoLuongTrongKho > 1";
            return dal.GetDataToDataTable(sql);
        }
        public void ThemSanPham(string tenSanPham, string loaiSanPham, float donGia, Image hinhAnh, int maNSX, int soLuong)
        {
            dal.ExcuteNonQuery("sp_ThemSanPham", System.Data.CommandType.StoredProcedure,
                new SqlParameter("@TenSanPham", tenSanPham),
                new SqlParameter("@LoaiSanPham", loaiSanPham),
                new SqlParameter("@DonGia", donGia),
                new SqlParameter("@HinhAnh", ImageToByteArray(hinhAnh)),
                new SqlParameter("@MaNhaSanXuat", maNSX),
                new SqlParameter("@SoLuongTrongKho", soLuong));
        }
        public void CapNhatSanPham(int maSanPham, string tenSanPham, string loaiSanPham, float donGia, Image hinhAnh, int maNSX, int soLuong)
        {
            dal.ExcuteNonQuery("sp_CapNhatSanPham", System.Data.CommandType.StoredProcedure,
                new SqlParameter("@MaSanPham", maSanPham),
                new SqlParameter("@TenSanPham", tenSanPham),
                new SqlParameter("@LoaiSanPham", loaiSanPham),
                new SqlParameter("@DonGia", donGia),
                new SqlParameter("@HinhAnh", ImageToByteArray(hinhAnh)),
                new SqlParameter("@MaNhaSanXuat", maNSX),
                new SqlParameter("@SoLuongTrongKho", soLuong));
        }
        public void XoaSanPham(int maSanPham)
        {
            dal.ExcuteNonQuery("sp_XoaSanPham", System.Data.CommandType.StoredProcedure,
                new SqlParameter("@MaSanPham", maSanPham));
        }
        public DataTable DanhSachSanPhamTheoLoai(string loai)
        {
            string sql;
            if(loai == "Tất cả")
            {
                sql = "select MaSanPham as N'ID',TenSanPham as N'Tên SP', LoaiSanPham as N'Loại SP'," +
                "DonGia as N'Đơn giá',HinhAnh as N'Hình ảnh',MaNhaSanXuat as N'Mã NSX', SoLuongTrongKho as N'Số lượng' from SanPham";
            }
            else
            {
                sql = "select MaSanPham as N'ID',TenSanPham as N'Tên SP', LoaiSanPham as N'Loại SP'," +
                "DonGia as N'Đơn giá',HinhAnh as N'Hình ảnh',MaNhaSanXuat as N'Mã NSX', SoLuongTrongKho as N'Số lượng' from SanPham where LoaiSanPham like " +
                "N'%" + loai + "%'";
            }
            return dal.GetDataToDataTable(sql);
        }
        public DataTable DanhSachLoaiSanPhan()
        {
            string sql = "select distinct LoaiSanPham from SanPham";
            return dal.GetDataToDataTable(sql);
        }
        #endregion

        #region NhaSanXuat
        public DataTable DanhSachNhaSanXuat()
        {
            return dal.GetDataToDataTable("SELECT MaNhaSanXuat as N'ID', TenNhaSanXuat as N'Tên NSX'," +
                "DiaChi as N'Địa chỉ', LienHe as N'Liên hệ', Website, MaBuuChinh as N'Zip code'," +
                "KhuVuc as N'Khu vực' FROM NhaSanXuat");
        }

        public string LayGiaTriTrongBangNhaSanXuat(int maNhaSanXuat, int index)
        {
            DataTable dt = dal.GetDataToDataTable("SELECT * FROM NhaSanXuat WHERE MaNhaSanXuat = " + maNhaSanXuat);
            return dt.Rows[0][index].ToString();
        }
        public void ThemNhaSanXuat(string tenNhaSanXuat, string diaChi,
            string lienHe, string website, string zipCode, string khuVuc)
        {
            string sql = "sp_ThemNhaSanXuat";
            dal.ExcuteNonQuery(sql, CommandType.StoredProcedure,
                new SqlParameter("@TenNhaSanXuat", tenNhaSanXuat),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@LienHe", lienHe),
                new SqlParameter("@Website", website),
                new SqlParameter("@MaBuuChinh", zipCode),
                new SqlParameter("@KhuVuc", khuVuc));
        }
        public void CapNhatNhaSanXuat(int maNSX, string tenNhaSanXuat, string diaChi,
            string lienHe, string website, string zipCode, string khuVuc)
        {
            string sql = "sp_CapNhatNhaSanXuat";
            dal.ExcuteNonQuery(sql, CommandType.StoredProcedure,
                new SqlParameter("@MaNhaSanXuat", maNSX),
                new SqlParameter("@TenNhaSanXuat", tenNhaSanXuat),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@LienHe", lienHe),
                new SqlParameter("@Website", website),
                new SqlParameter("@MaBuuChinh", zipCode),
                new SqlParameter("@KhuVuc", khuVuc));
        }
        public void XoaNhaSanXuat(int maNSX)
        {
            string sql = "sp_XoaNhaSanXuat";
            try
            {
                dal.ExcuteNonQuery(sql, CommandType.StoredProcedure,
                new SqlParameter("@MaNhaSanXuat", maNSX));
            }
            catch
            {
                throw new Exception();
            }
        }
        #endregion

        #region HoaDon
        public void ThemChiTietHoaDon(long maHoaDon, int maSanPham, int soLuong, float thanhTien)
        {
            //try
            //{
                string sql = "sp_ThemChiTietHoaDon";
                dal.ExcuteNonQuery(sql, System.Data.CommandType.StoredProcedure,
                    new SqlParameter("@MaHoaDon", maHoaDon + ""),
                    new SqlParameter("@MaSanPham", maSanPham),
                    new SqlParameter("@SoLuong", soLuong),
                    new SqlParameter("@thanhTien", thanhTien));
            //}
            //catch
            //{
            //    throw new Exception();
            //}
        }

        public bool KiemTraSoLuongHangBanRa(string maSP, int soLuong)
        {
            string sql = "select TenSanPham, SoLuongTrongKho from SanPham where MaSanPham = " + maSP;
            DataTable dt = dal.GetDataToDataTable(sql);
            if (soLuong > int.Parse(dt.Rows[0][1].ToString()))
            {
                return false;
            }
            return true;
        }

        public void ThemHoaDon(long maHoaDon, DateTime ngayTao, int maNhanVien, float tongTien)
        {
            string sql = "sp_ThemHoaDon";
            dal.ExcuteNonQuery(sql, System.Data.CommandType.StoredProcedure,
                new SqlParameter("@MaHoaDon", maHoaDon + ""),
                new SqlParameter("@NgayTao", ngayTao),
                new SqlParameter("@MaNhanVien", maNhanVien),
                new SqlParameter("@TongTien", tongTien));
        }
        public DataTable ThongTinToanBoHoaDon()
        {
            string sql = "select MaHoaDon as N'Mã HĐ', NgayTao as N'Ngày tạo', TongTien as N'TT' from HoaDon";
            return dal.ExecuteQueryDataTable(sql, CommandType.Text, null);
        }
        #endregion

        #region NhanVien
        public DataTable ThongTinNhanVien(int maNhanVien)
        {
            return dal.ExecuteQueryDataTable("dbo.sp_ThongTinNhanVien", CommandType.StoredProcedure,
                new SqlParameter("@MaNhanVien", maNhanVien));
        }
        public DataTable ThongTinToanBoNhanVien()
        {
            return dal.GetDataToDataTable("select * from NhanVien");
        }
        public void ThemNhanVien(string hoTen, string lienHe, string diaChi, Image hinhAnh, string gioiTinh, string cccd)
        {
            dal.ExcuteNonQuery("sp_ThemNhanVien", System.Data.CommandType.StoredProcedure,
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@LienHe", lienHe),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@HinhAnh", ImageToByteArray(hinhAnh)),
                new SqlParameter("@GioiTinh", gioiTinh),
                new SqlParameter("@CCCD", cccd));
        }
        public void CapNhatNhanVien(int maNhanVien, string hoTen, string lienHe, string diaChi, Image hinhAnh, string gioiTinh, string cccd)
        {
            dal.ExcuteNonQuery("sp_CapNhatNhanVien", System.Data.CommandType.StoredProcedure,
                new SqlParameter("@MaNhanVien", maNhanVien),
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@LienHe", lienHe),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@HinhAnh", ImageToByteArray(hinhAnh)),
                new SqlParameter("@GioiTinh", gioiTinh),
                new SqlParameter("@CCCD", cccd));
        }
        public void XoaNhanVien(int maNhanVien)
        {
            dal.ExcuteNonQuery("sp_XoaNhanVien", System.Data.CommandType.StoredProcedure,
                new SqlParameter("@MaNhanVien", maNhanVien));
        }
        public void DoiMatKhau(int maNhanVien, string MatKhau)
        {
            dal.ExcuteNonQuery("sp_DoiMatKhau", System.Data.CommandType.StoredProcedure,
                new SqlParameter("@MaNhanVien", maNhanVien),
                new SqlParameter("@MatKhau", MatKhau));
        }
        #endregion

        #region PhieuNhapHang
        public void ThemChiTietPhieuNhapHang(string maPhieuNhapHang, int maSanPham, float donGia, int soLuong)
        {
            dal.ExcuteNonQuery("sp_ThemChiTietPhieuNhapHang", CommandType.StoredProcedure,
                new SqlParameter("@maPhieuNhapHang", maPhieuNhapHang),
                new SqlParameter("@MaSanPham", maSanPham),
                new SqlParameter("@DonGia", donGia),
                new SqlParameter("@SoLuong", soLuong));
        }
        public void ThemPhieuNhapHang(string maPhieuNhapHang, DateTime ngayTao, int maNhanVien, float tongTien)
        {
            dal.ExcuteNonQuery("sp_ThemPhieuNhapHang", CommandType.StoredProcedure,
                new SqlParameter("@maPhieuNhapHang", maPhieuNhapHang),
                new SqlParameter("@MaNhanVien", maNhanVien),
                new SqlParameter("@NgayTao", ngayTao),
                new SqlParameter("@TongTien", tongTien));
        }
        public DataTable ThongTinToanBoPhieuNhap()
        {
            string sql = "select MaPhieuNhapHang as N'Mã phiếu', NgayNhapHang as N'Ngày nhập', TongGiaTri as N'TT', MaNhanVien as N'Mã NV' from PhieuNhapHang";
            return dal.ExecuteQueryDataTable(sql, CommandType.Text, null);
        }
        #endregion

        #region Convert_Image
        private byte[] ImageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
        #endregion
    }
}
