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
        public delegate void delCapNhatTongTien();
        public delegate void delXoaSanPham(UCSanPhamBar sanPham);


        public List<UCSanPhamBar> lstSanPham;
        public float tongTien = 0;
        static UCHoaDon _obj;
        public static UCHoaDon Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new UCHoaDon();
                }
                return _obj;
            }
        }
        public UCHoaDon()
        {
            InitializeComponent();
            lstSanPham = new List<UCSanPhamBar>();
            lblNgayTao.Text = "Ngày tạo : " + (DateTime.Now).ToString("dd/MM/yyyy");

            lstSanPham.Add(new UCSanPhamBar(1, null, "Dép tổ ong", 1000,3, CapNhatTongTienHoaDon,XoaSanPham));
            lstSanPham.Add(new UCSanPhamBar(2, null, "Bút bi", 1000,1, CapNhatTongTienHoaDon, XoaSanPham));
            lstSanPham.Add(new UCSanPhamBar(3, null, "Dép lào", 1000,1, CapNhatTongTienHoaDon, XoaSanPham));
            lstSanPham.Add(new UCSanPhamBar(7, null, "Laptop", 1000,1, CapNhatTongTienHoaDon, XoaSanPham));
            lstSanPham.Add(new UCSanPhamBar(8, null, "Điện thoại",1000, 1, CapNhatTongTienHoaDon, XoaSanPham));
            lstSanPham.Add(new UCSanPhamBar(9, null, "Iphone", 1000,1, CapNhatTongTienHoaDon, XoaSanPham));

            ThemSanPham();
            CapNhatTongTienHoaDon();
        }
        public void CapNhatTongTienHoaDon()
        {
            tongTien = 0;
            foreach (UCSanPhamBar sp in lstSanPham)
            {
                tongTien += sp.ThanhTien;
            }
            lblTongTien.Text = "Tổng tiền : " + tongTien + " VNĐ";
        }

        private void XoaSanPham(UCSanPhamBar sanPham)
        {
            lstSanPham.Remove(sanPham);
            fpnlSanPham.Controls.Clear();
            foreach (UCSanPhamBar sp in lstSanPham)
            {
                fpnlSanPham.Controls.Add(sp);
            }
            CapNhatTongTienHoaDon();
        }
        private void ThemSanPham()
        {
            foreach(UCSanPhamBar sp in lstSanPham)
            {
                fpnlSanPham.Controls.Add(sp);
            }
        }

        private void UCHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
