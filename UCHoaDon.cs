using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace management_store
{
    public partial class UCHoaDon : UserControl
    {
        public delegate void delCapNhatTongTien();
        public delegate void delXoaSanPham(UCSanPhamBar sanPham);
        public delegate void delThemSanPhamVaoHoaDon(int maSP, string tenSP, float donGia, Image hinhAnh);

        #region Properties
        BLL func; //query
        public List<UCSanPhamBar> lstSanPham;
        public float tongTien = 0;

        static UCHoaDon _obj;

        frmTimSP themSP;
        DateTime now = DateTime.Now;
        int width_bill = 148;
        #endregion

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
            themSP = new frmTimSP(ThemSanPhamVaoHoaDon);

            lstSanPham = new List<UCSanPhamBar>();
            lblNgayTao.Text = "Ngày tạo : " + (DateTime.Now).ToString("dd/MM/yyyy");
            
            // Dữ liệu mẫu
            lstSanPham.Add(new UCSanPhamBar(1, null, "Dép tổ ong", 40000, 1, CapNhatTongTienHoaDon, XoaSanPham));
            lstSanPham.Add(new UCSanPhamBar(2, null, "Dép lào", 15000, 1, CapNhatTongTienHoaDon, XoaSanPham));
            lstSanPham.Add(new UCSanPhamBar(3, null, "Dép tông", 20000, 1, CapNhatTongTienHoaDon, XoaSanPham));
            lstSanPham.Add(new UCSanPhamBar(4, null, "Bút bi", 5000, 5, CapNhatTongTienHoaDon, XoaSanPham));

            ThemSanPham();
            CapNhatTongTienHoaDon();
            func = new BLL();
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
            var distinct = lstSanPham.Distinct(new ItemEqualityComparer());
            fpnlSanPham.Controls.Clear();
            foreach (UCSanPhamBar sp in distinct)
            {
                fpnlSanPham.Controls.Add(sp);
            }
        }

        private void btnThemSp_Click(object sender, EventArgs e)
        {
            themSP.Show();
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            fpnlSanPham.Controls.Clear();
            lstSanPham.Clear();
            lblTongTien.Text = "Tổng tiền : 0.00 VNĐ";
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            //251020211205
            int maHoaDon = (now.Day * 100000000 + now.Month + now.Year + now.Hour + now.Minute + now.Second);

            func.ThemHoaDon(maHoaDon, now, int.Parse(txtMaNV.Text), tongTien);
            float chietKhau = 5.8f;
            foreach(UCSanPhamBar x in lstSanPham)
            {
                func.ThemChiTietHoaDon(maHoaDon, x.MaSP, x.SoLuong, chietKhau);
            }
            
            // Tạo hóa đơn
            printBill.DefaultPageSettings.PaperSize = new PaperSize("HÓA ĐƠN", width_bill, lstSanPham.Count * 10 + 100);
            printPreviewDialogBill.ShowDialog();
        }

        private void printBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fontTieuDe = new Font("Arial", 3, FontStyle.Bold);
            Font fontNoiDung = new Font("Arial", 3, FontStyle.Regular);
            
            printBill.DefaultPageSettings.PaperSize = new PaperSize("HÓA ĐƠN", width_bill, lstSanPham.Count * 10 + 70);

            int stt = 1;
            int pos = 0;
            int theLastPos = 0;
            int leftMargin = 21;
            int topMargin = 20;
            int halfWidthPage = printBill.DefaultPageSettings.PaperSize.Width / 2;

            e.Graphics.DrawString("HÓA ĐƠN", new Font("Arial", 3, FontStyle.Bold), Brushes.Black, new Point(halfWidthPage-8, 10));

            //In phần tiêu đề hóa đơn
            e.Graphics.DrawString("STT", fontTieuDe, Brushes.Black, new Point(leftMargin, topMargin));
            e.Graphics.DrawString("Sản phẩm", fontTieuDe, Brushes.Black, new Point(leftMargin + 10, topMargin));
            e.Graphics.DrawString("Số lượng", fontTieuDe, Brushes.Black, new Point(leftMargin + 50, topMargin));
            e.Graphics.DrawString("Thành tiền", fontTieuDe, Brushes.Black, new Point(leftMargin + 85, topMargin));

            //In chi tiết trong hóa đơn
            foreach (UCSanPhamBar x in lstSanPham)
            {
                e.Graphics.DrawString(stt + "", fontNoiDung, Brushes.Black, new Point(leftMargin + 1, topMargin+ 10 + pos));
                e.Graphics.DrawString(x.TenSP + "", fontNoiDung, Brushes.Black, new Point(leftMargin + 10, topMargin +  10 + pos));
                e.Graphics.DrawString(x.SoLuong + "", fontNoiDung, Brushes.Black, new Point(leftMargin + 56, topMargin +  10 + pos));
                e.Graphics.DrawString(x.ThanhTien + "", fontNoiDung, Brushes.Black, new Point(leftMargin + 85, topMargin +  10 + pos));

                theLastPos = topMargin + 10 + pos;
                pos += 10;
                stt++;
            }

            e.Graphics.DrawString("==========================================", fontNoiDung, 
                Brushes.Black, new Point(leftMargin, theLastPos + 10));
            e.Graphics.DrawString("Total : " + tongTien.ToString("N", CultureInfo.InvariantCulture) + " VNĐ", fontTieuDe, 
                Brushes.Black, new Point(leftMargin, theLastPos + 20));
            e.Graphics.DrawString("- HẸN GẶP LẠI QUÝ KHÁCH - ", fontTieuDe, Brushes.Black,
                new Point(leftMargin + 21, theLastPos + 50));
        }
    }
}
