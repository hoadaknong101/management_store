using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace management_store
{
    public partial class UCHoaDon : UserControl
    {
        #region Properties
        public delegate void delCapNhatTongTien();
        public delegate void delXoaSanPham(UCSanPhamBar sanPham);
        public delegate void delThemSanPhamVaoHoaDon(int maSP, string tenSP, float donGia, Image hinhAnh);

        private int ID_NhanVien;
        private DataTable dt = new DataTable();
        private BusinessLogicLayer bll = new BusinessLogicLayer();
        
        public List<UCSanPhamBar> lstSanPham;
        public float tongTien = 0;
        frmTimSP themSP;
        private int width_bill = 148;

        static UCHoaDon _obj;
        public static UCHoaDon Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCHoaDon();
                }
                return _obj;
            }
        }
        #endregion

        public UCHoaDon()
        {
            InitializeComponent();
            themSP = new frmTimSP(ThemSanPhamVaoHoaDon);
            lstSanPham = new List<UCSanPhamBar>();
            lblNgayTao.Text = "Ngày tạo : " + (DateTime.Now).ToString("dd/MM/yyyy");
            ThemSanPham();
            CapNhatTongTienHoaDon();
        }
        public int IDNhanVien
        {
            get { return ID_NhanVien; }
            set { ID_NhanVien = value; }
        }

        #region SanPham
        public void ThemSanPhamVaoHoaDon(int maSP, string tenSP, float donGia, Image hinhAnh)
        {
            lstSanPham.Add(new UCSanPhamBar(maSP, hinhAnh, tenSP, donGia, 1, CapNhatTongTienHoaDon, XoaSanPham));
            ThemSanPham();
            CapNhatTongTienHoaDon();
        }

        public void CapNhatTongTienHoaDon()
        {
            tongTien = 0;
            var distinct = lstSanPham.Distinct(new ItemEqualityComparer());
            foreach (UCSanPhamBar sp in distinct)
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
        #endregion

        #region HoaDon
        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            fpnlSanPham.Controls.Clear();
            lstSanPham.Clear();
            lblTongTien.Text = "Tổng tiền : 0.00 VNĐ";
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            var distinct = lstSanPham.Distinct(new ItemEqualityComparer());
            foreach (var x in distinct)
            {
                if (bll.KiemTraSoLuongHangBanRa(x.MaSP + "", x.SoLuong) == false)
                {
                    MessageBox.Show(x.TenSP + " không đủ số lượng trong kho để bán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            DateTime now = DateTime.Now;
            long maHoaDon = TaoMaHoaDon(now);
            if (KiemTraXuatHoaDon())
            {
                bll.ThemHoaDon(maHoaDon, now, IDNhanVien, tongTien, txtHoTenKH.Text);

                foreach (UCSanPhamBar x in distinct)
                {
                    bll.ThemChiTietHoaDon(maHoaDon, x.MaSP, x.SoLuong, x.ThanhTien);
                }
                printBill.DefaultPageSettings.PaperSize = new PaperSize("HÓA ĐƠN", width_bill, distinct.ToList().Count * 10 + 100);
                printPreviewDialogBill.ShowDialog();
                fpnlSanPham.Controls.Clear();
                lstSanPham.Clear();
                lblTongTien.Text = "Tổng tiền : 0.00 VNĐ";
                CapNhatSauKhiXuatHoaDon();
            }
            else
            {
                return;
            }
        }

        private void CapNhatSauKhiXuatHoaDon()
        {
            UCDashboard.Instance.LoadData();
            UCDoanhThu.Instance.TakeInfor();
            UCDoanhThu.Instance.LoadData();
            UCSanPham.Instance.SettingSanPham();
        }

        private bool KiemTraXuatHoaDon()
        {
            if (txtHoTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenKH.Focus();
                return false;
            }
            if (txtTenNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus();
                return false;
            }
            if (lstSanPham.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnThemSp.Focus();
                return false;
            }
            return true;
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
        #endregion

        private void printBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var distinct = lstSanPham.Distinct(new ItemEqualityComparer());
            Font fontTieuDe = new Font("Arial", 3, FontStyle.Bold);
            Font fontNoiDung = new Font("Arial", 3, FontStyle.Regular);

            printBill.DefaultPageSettings.PaperSize = new PaperSize("HÓA ĐƠN", width_bill, distinct.ToList().Count * 10 + 70);

            int stt = 1;
            int pos = 0;
            int theLastPos = 0;
            int leftMargin = 22;
            int topMargin = 30;
            int halfWidthPage = printBill.DefaultPageSettings.PaperSize.Width / 2;

            e.Graphics.DrawString("HÓA ĐƠN BÁN LẺ", new Font("Arial", 5, FontStyle.Bold), Brushes.Black, new Point(halfWidthPage - 30, 10));
            e.Graphics.DrawString("Người mua hàng : " + txtHoTenKH.Text, new Font("Arial", 3, FontStyle.Bold), Brushes.Black, new Point(leftMargin, 23));

            //In phần tiêu đề hóa đơn
            e.Graphics.DrawString("STT", fontTieuDe, Brushes.Black, new Point(leftMargin, topMargin));
            e.Graphics.DrawString("Sản phẩm", fontTieuDe, Brushes.Black, new Point(leftMargin + 10, topMargin));
            e.Graphics.DrawString("Số lượng", fontTieuDe, Brushes.Black, new Point(leftMargin + 50, topMargin));
            e.Graphics.DrawString("Thành tiền", fontTieuDe, Brushes.Black, new Point(leftMargin + 85, topMargin));

            //In chi tiết trong hóa đơn
            foreach (UCSanPhamBar x in distinct)
            {
                e.Graphics.DrawString(stt + "", fontNoiDung, Brushes.Black, new Point(leftMargin + 1, topMargin + 10 + pos));
                e.Graphics.DrawString(x.TenSP + "", fontNoiDung, Brushes.Black, new Point(leftMargin + 10, topMargin + 10 + pos));
                e.Graphics.DrawString(x.SoLuong + "", fontNoiDung, Brushes.Black, new Point(leftMargin + 56, topMargin + 10 + pos));
                e.Graphics.DrawString(x.ThanhTien + "", fontNoiDung, Brushes.Black, new Point(leftMargin + 85, topMargin + 10 + pos));

                theLastPos = topMargin + 10 + pos;
                pos += 10;
                stt++;
            }

            e.Graphics.DrawString("==========================================", fontNoiDung,
                Brushes.Black, new Point(leftMargin, theLastPos + 10));
            e.Graphics.DrawString("Total : " + tongTien.ToString("N", CultureInfo.InvariantCulture) + " VNĐ", fontTieuDe,
                Brushes.Black, new Point(leftMargin, theLastPos + 20));
            e.Graphics.DrawString("Ngày bán : " + DateTime.Now.ToString("dd-MM-yyyy"), fontTieuDe,
                Brushes.Black, new Point(leftMargin, theLastPos + 30));
            e.Graphics.DrawString("Người bán hàng : " + dt.Rows[0][1].ToString(), fontTieuDe,
                Brushes.Black, new Point(leftMargin, theLastPos + 40));
            e.Graphics.DrawString("- HẸN GẶP LẠI QUÝ KHÁCH - ", fontTieuDe, Brushes.Black,
                new Point(leftMargin + 21, theLastPos + 60));
        }

        private void UCHoaDon_Load(object sender, EventArgs e)
        {
            dt = bll.ThongTinNhanVien(IDNhanVien);
            txtTenNV.Text = dt.Rows[0][1].ToString();
        }

        private void btnLichSuBanHang_Click(object sender, EventArgs e)
        {
            frmLichSuaBanHang frm = new frmLichSuaBanHang(true);
            frm.ShowDialog();
        }
    }
}
