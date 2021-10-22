using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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
        public void ThemSanPham(string tenSanPham, string loaiSanPham, float donGia, byte[] hinhAnh, int maNSX, int soLuong)
        {
            string sql = "INSERT INTO SanPham(TenSanPham, LoaiSanPham, DonGia, HinhAnh,MaNhaSanXuat,SoLuongTrongKhi) VALUES(N'" +
                 tenSanPham + "', N'" +
                 loaiSanPham + "', " +
                 donGia + ", " +
                 hinhAnh + ", " +
                 maNSX + ", " +
                 soLuong +")";
            func.ExcuteNonQuery(sql, System.Data.CommandType.Text);
        }
        public void insertSanPham(string tenSanPham, string loaiSanPham, float donGia, Image hinhAnh, int maNSX, int soLuong)
        {
            string sql = "EXC sp_ThemSanPham";
            func.ExcuteNonQuery(sql, System.Data.CommandType.StoredProcedure, 
                new SqlParameter("@TenSanPham", tenSanPham),
                new SqlParameter("@LoaiSanPham", loaiSanPham),
                new SqlParameter("@DonGia",donGia),
                new SqlParameter("@HinhAnh", hinhAnh),
                new SqlParameter("@MaNhaSanXuat",maNSX),
                new SqlParameter("@SoLuongTrongKho",soLuong));
        }
    }
}
