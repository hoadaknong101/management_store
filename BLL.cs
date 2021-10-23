using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management_store
{
    class BLL
    {
        Function func = new Function();
        public BLL()
        {

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
        private byte[] ImageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
    }
}
