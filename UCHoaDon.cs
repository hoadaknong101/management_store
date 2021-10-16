using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        public delegate void delThemSanPhamVaoHoaDon(int maSP, string tenSP, float donGia, Image hinhAnh);

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
            ThemSanPham();
            CapNhatTongTienHoaDon();
        }

        public void ThemSanPhamVaoHoaDon(int maSP, string tenSP, float donGia, Image hinhAnh)
        {
            lstSanPham.Add(new UCSanPhamBar(maSP, hinhAnh, tenSP, donGia, 1, CapNhatTongTienHoaDon, XoaSanPham));
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
            CultureInfo ci = new CultureInfo("en-us");
            lblTongTien.Text = "Tổng tiền : " + tongTien.ToString("N", CultureInfo.InvariantCulture) + " VNĐ";
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
            fpnlSanPham.Controls.Clear();
            foreach (UCSanPhamBar sp in lstSanPham)
            {
                fpnlSanPham.Controls.Add(sp);
            }
        }

        private void UCHoaDon_Load(object sender, EventArgs e)
        {
        }

        private void btnThemSp_Click(object sender, EventArgs e)
        {
            frmTimSP themSP = new frmTimSP(ThemSanPhamVaoHoaDon);
            themSP.Show();
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            fpnlSanPham.Controls.Clear();
            lblTongTien.Text = "Tổng tiền : 0.00 VNĐ";
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
