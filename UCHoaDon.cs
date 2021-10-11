using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management_store
{
    public partial class UCHoaDon : UserControl
    {
        public delegate void TinhTongTien();
        public delegate void XoaItem(UCSanPhamBar a);
        public delegate void CapNhatTongTien();

        private List<UCSanPhamBar> lstSanPham;
        private float tongTien = 0;
        public UCHoaDon()
        {
            InitializeComponent();
            lstSanPham = new List<UCSanPhamBar>();
            lblNgayTao.Text = "Ngày tạo : " + (DateTime.Now).ToString("dd/MM/yyyy");

            lstSanPham.Add(new UCSanPhamBar(1, null, "Dep to ong", 1000,1, TinhTongTienHoaDon, XoaListItem,CapNhatTongTienHD));
            lstSanPham.Add(new UCSanPhamBar(2, null, "But bi", 1000,1, TinhTongTienHoaDon, XoaListItem, CapNhatTongTienHD));
            lstSanPham.Add(new UCSanPhamBar(3, null, "Dep lao", 1000,1, TinhTongTienHoaDon, XoaListItem, CapNhatTongTienHD));
            lstSanPham.Add(new UCSanPhamBar(7, null, "Laptop", 1000,1, TinhTongTienHoaDon, XoaListItem, CapNhatTongTienHD));
            lstSanPham.Add(new UCSanPhamBar(8, null, "Dien Thoai",1, 1000, TinhTongTienHoaDon, XoaListItem, CapNhatTongTienHD));
            lstSanPham.Add(new UCSanPhamBar(9, null, "Iphone", 1000,1, TinhTongTienHoaDon, XoaListItem, CapNhatTongTienHD));

            ThemSanPham();
            TinhTongTienHoaDon();
        }
        private void TinhTongTienHoaDon()
        {
            tongTien = 0;
            foreach (UCSanPhamBar a in lstSanPham)
            {
                tongTien += a.DonGia;
            }
            lblTongTien.Text = "Tổng tiền : " + tongTien + "VNĐ";
        }
        private void XoaListItem(UCSanPhamBar a)
        {
            lstSanPham.Remove(a);
            TinhTongTienHoaDon();
        }
        private void ThemSanPham()
        {
            foreach(UCSanPhamBar a in lstSanPham)
            {
                fpnlSanPham.Controls.Add(a);
            }
        }
        private void CapNhatTongTienHD()
        {
            tongTien = 0;
            foreach (UCSanPhamBar a in lstSanPham)
            {
                tongTien += a.DonGia;
            }
            lblTongTien.Text = "Tổng tiền : " + tongTien + "VNĐ";
        }
    }
}
