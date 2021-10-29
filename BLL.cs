using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace management_store
{
    public class BLL
    {
        Function func = new Function();

        public BLL()
        {

        }

        public bool KiemTraThongTinDangNhap(int taiKhoan, string matKhau, string chucVu)
        {
            bool flag = false;

            try
            {
                string sql = "SELECT * FROM NhanVien WHERE MaNhanVien = " + taiKhoan + " AND MatKhau = N'" + matKhau + "' AND ChucVu = N'" + chucVu + "'";
                DataTable dt = func.GetDataToDataTable(sql);
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
        public DataTable ThongTinSanPham(string sql)
        {
            return func.GetDataToDataTable(sql);
        }
        public void ThemSanPham(string tenSanPham, string loaiSanPham, float donGia, Image hinhAnh, int maNSX, int soLuong)
        {
            string sql = "sp_ThemSanPham";
            func.ExcuteNonQuery(sql, System.Data.CommandType.StoredProcedure, 
                new SqlParameter("@TenSanPham", tenSanPham),
                new SqlParameter("@LoaiSanPham", loaiSanPham),
                new SqlParameter("@DonGia",donGia),
                new SqlParameter("@HinhAnh", ImageToByteArray(hinhAnh)),
                new SqlParameter("@MaNhaSanXuat",maNSX),
                new SqlParameter("@SoLuongTrongKho",soLuong));
        }
        public void CapNhatSanPham(int maSanPham,string tenSanPham, string loaiSanPham, float donGia, Image hinhAnh, int maNSX, int soLuong)
        {
            string sql = "sp_CapNhatSanPham";
            func.ExcuteNonQuery(sql, System.Data.CommandType.StoredProcedure,
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
            string sql = "sp_XoaSanPham";
            func.ExcuteNonQuery(sql, System.Data.CommandType.StoredProcedure,
                new SqlParameter("@MaSanPham", maSanPham));
        }
        #endregion

        #region HoaDon
        public void ThemChiTietHoaDon(long maHoaDon, int maSanPham, int soLuong, float thanhTien)
        {
            string sql = "sp_ThemChiTietHoaDon";
            func.ExcuteNonQuery(sql, System.Data.CommandType.StoredProcedure,
                new SqlParameter("@MaHoaDon", maHoaDon + ""),
                new SqlParameter("@MaSanPham", maSanPham),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@ThanhTien", thanhTien));
        }
        public void ThemHoaDon(long maHoaDon, DateTime ngayTao, int maNhanVien, float tongTien)
        {
            string sql = "sp_ThemHoaDon";
            func.ExcuteNonQuery(sql, System.Data.CommandType.StoredProcedure, 
                new SqlParameter("@MaHoaDon", maHoaDon + ""),
                new SqlParameter("@NgayTao", ngayTao),
                new SqlParameter("@MaNhanVien", maNhanVien),
                new SqlParameter("@TongTien",tongTien));
        }

        public DataTable ThongTinNhanVien(int maNhanVien)
        {
            string sql = "dbo.sp_ThongTinNhanVien";
            return func.ExecuteQueryDataTable(sql, CommandType.StoredProcedure,new SqlParameter("@MaNhanVien", maNhanVien));
        }

        #endregion

        #region PhieuThu
        public void ThemChiTietPhieuThu(int maPhieuThu, int maSanPham, int soLuong)
        {
            string sql = "sp_ThemChiTietPhieuThu";
            func.ExcuteNonQuery(sql, System.Data.CommandType.StoredProcedure,
                new SqlParameter("@maPhieuThu", maPhieuThu),
                new SqlParameter("@MaSanPham", maSanPham),
                new SqlParameter("@SoLuong", soLuong));
        }
        public void ThemPhieuThu(int maPhieuThu, DateTime ngayTao, int maNhanVien, float tongTien)
        {
            string sql = "sp_ThemPhieuThu";
            func.ExcuteNonQuery(sql, System.Data.CommandType.StoredProcedure,
                new SqlParameter("@maPhieuThu", maPhieuThu),
                new SqlParameter("@NgayTao", ngayTao),
                new SqlParameter("@MaNhanVien", maNhanVien),
                new SqlParameter("@TongTien", tongTien));
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
