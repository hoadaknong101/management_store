using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace management_store
{
    public class BLL
    {
        DataAccessLayer dal = new DataAccessLayer();

        public BLL()
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

        #region SanPham
        public DataTable ThongTinSanPham()
        {
            return dal.GetDataToDataTable("SELECT * FROM SanPham");
        }

        public void ThemSanPham(string tenSanPham, string loaiSanPham, float donGia, Image hinhAnh, int maNSX, int soLuong)
        {
            dal.ExcuteNonQuery("sp_ThemSanPham", System.Data.CommandType.StoredProcedure, 
                new SqlParameter("@TenSanPham", tenSanPham),
                new SqlParameter("@LoaiSanPham", loaiSanPham),
                new SqlParameter("@DonGia",donGia),
                new SqlParameter("@HinhAnh", ImageToByteArray(hinhAnh)),
                new SqlParameter("@MaNhaSanXuat",maNSX),
                new SqlParameter("@SoLuongTrongKho",soLuong));
        }
        public void CapNhatSanPham(int maSanPham,string tenSanPham, string loaiSanPham, float donGia, Image hinhAnh, int maNSX, int soLuong)
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
        #endregion

        #region HoaDon
        public void ThemChiTietHoaDon(long maHoaDon, int maSanPham, int soLuong, float thanhTien)
        {
            string sql = "sp_ThemChiTietHoaDon";
            dal.ExcuteNonQuery(sql, System.Data.CommandType.StoredProcedure,
                new SqlParameter("@MaHoaDon", maHoaDon + ""),
                new SqlParameter("@MaSanPham", maSanPham),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@ThanhTien", thanhTien));
        }
        public void ThemHoaDon(long maHoaDon, DateTime ngayTao, int maNhanVien, float tongTien)
        {
            string sql = "sp_ThemHoaDon";
            dal.ExcuteNonQuery(sql, System.Data.CommandType.StoredProcedure, 
                new SqlParameter("@MaHoaDon", maHoaDon + ""),
                new SqlParameter("@NgayTao", ngayTao),
                new SqlParameter("@MaNhanVien", maNhanVien),
                new SqlParameter("@TongTien",tongTien));
        }
        public DataTable ThongTinToanBoHoaDon()
        {
            return dal.ExecuteQueryDataTable("select * from HoaDon", CommandType.Text, null);
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
        public void ThemNhanVien(string hoTen,string lienHe,string diaChi,Image hinhAnh,string gioiTinh,string cccd)
        {
            dal.ExcuteNonQuery("sp_ThemNhanVien", System.Data.CommandType.StoredProcedure,
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@LienHe", lienHe),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@HinhAnh", ImageToByteArray(hinhAnh)),
                new SqlParameter("@GioiTinh", gioiTinh),
                new SqlParameter("@CCCD", cccd));
        }
        public void CapNhatNhanVien(int maNhanVien,string hoTen, string lienHe, string diaChi, Image hinhAnh, string gioiTinh, string cccd)
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
        public void ThemChiTietPhieuNhapHang(int maPhieuNhapHang, int maSanPham, float donGia, int soLuong)
        {
            dal.ExcuteNonQuery("sp_ThemChiTietPhieuNhapHang", System.Data.CommandType.StoredProcedure,
                new SqlParameter("@maPhieuNhapHang", maPhieuNhapHang),
                new SqlParameter("@MaSanPham", maSanPham),
                new SqlParameter("@DonGia", donGia),
                new SqlParameter("@SoLuong", soLuong));
        }
        public void ThemPhieuNhapHang(int maPhieuNhapHang, DateTime ngayTao, int maNhanVien, float tongTien)
        {
            dal.ExcuteNonQuery("sp_ThemPhieuNhapHang", System.Data.CommandType.StoredProcedure,
                new SqlParameter("@maPhieuNhapHang", maPhieuNhapHang),
                new SqlParameter("@MaNhanVien", maNhanVien),
                new SqlParameter("@NgayTao", ngayTao),
                new SqlParameter("@TongTien", tongTien));
        }
        public DataTable ThongTinToanBoPhieuNhap()
        {
            return dal.ExecuteQueryDataTable("select * from PhieuNhapHang", CommandType.Text, null);
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
