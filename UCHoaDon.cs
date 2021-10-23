using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            printPreviewDialogBill.ShowDialog();
        }

        private void printBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            for (int i = 0; i < printBill.PrinterSettings.PaperSizes.Count; i++)
            {
                if (printBill.PrinterSettings.PaperSizes[i].RawKind == 11)
                {
                    printBill.DefaultPageSettings.PaperSize = printBill.PrinterSettings.PaperSizes[i];
                }
            }
            int stt = 1;
            int pos = 0;
            int theLastPos =0 ;
            e.Graphics.DrawString("BILL", new Font("Arial", 15, FontStyle.Bold),
                    Brushes.Black, new Point((printBill.DefaultPageSettings.PaperSize.Width/2)+110, 20));
            e.Graphics.DrawString("No." + "\t" + "Name" + "\t\t" + "\tQuantity\t"
                     + "\tTotal", new Font("Arial", 13, FontStyle.Regular),
                    Brushes.Black, new Point((printBill.DefaultPageSettings.PaperSize.Width / 2)-130, 60));
            foreach (UCSanPhamBar x in lstSanPham)
            {
                e.Graphics.DrawString(stt + "\t" + x.TenSP + "\t\t" + x.SoLuong
                    + "\t\t" + x.ThanhTien, new Font("Arial", 9, FontStyle.Regular),
                    Brushes.Black, new Point((printBill.DefaultPageSettings.PaperSize.Width / 2)-130, 100 + pos));
                theLastPos = pos + 100;
                pos += 40;
                stt++;
            }
            e.Graphics.DrawString("==============================================", new Font("Arial", 9, FontStyle.Regular),
                    Brushes.Black, new Point((printBill.DefaultPageSettings.PaperSize.Width / 2) -130, theLastPos + 40));
            e.Graphics.DrawString("Total : " + tongTien + " VND", new Font("Arial", 9, FontStyle.Regular),
                    Brushes.Black, new Point((printBill.DefaultPageSettings.PaperSize.Width / 2) + 200, theLastPos + 80));
        }
    }
}
