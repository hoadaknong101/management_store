using management_store.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using ExcelEngine;
using ClosedXML.Excel;

namespace management_store
{
    public partial class UCDoanhThu : UserControl
    {
        static UCDoanhThu _obj;
        private BusinessLogicLayer bll = new BusinessLogicLayer();

        public static UCDoanhThu Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCDoanhThu();
                }
                return _obj;
            }
        }
        public UCDoanhThu()
        {
            InitializeComponent();
            LoadData();
            TakeInfor();
        }

        public void TakeInfor()
        {
            lblNhanVien.Text = bll.SoLuongNhanVien().ToString();
            lblHoaDon.Text = bll.SoLuongHoaDon().ToString();
            lblChiTieu.Text = "Tổng chi tiêu : " + bll.TongChiTieu().ToString("0,000") + " VNĐ";
            lblThuNhap.Text = "Tổng thu nhập : " + bll.TongThuNhap().ToString("0,000") + " VNĐ";
            lblLoiNhuanHienTai.Text = (bll.TongThuNhap() - bll.TongChiTieu()).ToString("000,000");
            lbl_spTrongKho.Text = bll.SoLuongSanPhamTrongKho().ToString();
        }

        public void LoadData()
        {
            dgvHoaDon.DataSource = bll.ThongTinToanBoHoaDon();
            dgvPhieuNhap.DataSource = bll.ThongTinToanBoPhieuNhap();
        }

        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            chartThongKe.Series["Thu nhập"].Points.Clear();
            chartThongKe.Series["Chi tiêu"].Points.Clear();

            if (radNgay.Checked)
            {
                DateTime toDay = DateTime.Now;
                DateTime weekBefore = DateTime.Now.AddDays(-7);
                float valueThuNhap;
                float valueChiTieu;
                foreach (DateTime day in EachDay(weekBefore, toDay))
                {
                    valueThuNhap = BusinessLogicLayer.Instance().TongGiaTriTheoNgay(day);
                    valueChiTieu = BusinessLogicLayer.Instance().TongChiTieuTheoNgay(day);
                    chartThongKe.Series["Thu nhập"].Points.AddXY(day.Day + "/" + day.Month, valueThuNhap);
                    chartThongKe.Series["Chi tiêu"].Points.AddXY(day.Day + "/" + day.Month, valueChiTieu);
                }
            }
            if (radThang.Checked)
            {
                DateTime target = DateTime.Now.AddMonths(-6);
                float valueThuNhap;
                float valueChiTieu;
                while (target < DateTime.Now)
                {
                    valueThuNhap = BusinessLogicLayer.Instance().TongGiaTriTheoThang(target);
                    valueChiTieu = BusinessLogicLayer.Instance().TongChiTieuTheoThang(target);
                    chartThongKe.Series["Thu nhập"].Points.AddXY(target.Month + "/" + target.Year, valueThuNhap);
                    chartThongKe.Series["Chi tiêu"].Points.AddXY(target.Month + "/" + target.Year, valueChiTieu);
                    target = target.AddMonths(1);
                }
            }
            if (radNam.Checked)
            {
                DateTime target = DateTime.Now.AddYears(-4);
                float valueThuNhap;
                float valueChiTieu;
                while (target < DateTime.Now)
                {
                    valueThuNhap = BusinessLogicLayer.Instance().TongGiaTriTheoNam(target);
                    valueChiTieu = BusinessLogicLayer.Instance().TongChiTieuTheoNam(target);
                    chartThongKe.Series["Thu nhập"].Points.AddXY(target.Year, valueThuNhap);
                    chartThongKe.Series["Chi tiêu"].Points.AddXY(target.Year, valueChiTieu);
                    target = target.AddYears(1);
                }
            }
        }

        private void btnLichSuBanHang_Click(object sender, EventArgs e)
        {
            frmChiTietBanHang frm = new frmChiTietBanHang();
            frm.ShowDialog();
        }

        private void btnLichSuNhapHang_Click(object sender, EventArgs e)
        {
            frmLichSuNhapHang frm = new frmLichSuNhapHang();
            frm.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Wordbook | *.xlsx"})
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(bll.ThongTinToanBoHoaDon(), "Hóa đơn");
                            workbook.Worksheets.Add(bll.ThongTinToanBoPhieuNhap(), "Nhập hàng");
                            workbook.Worksheets.Add(bll.DanhSachNhanVienKhongHinhAnh(), "Nhân viên");
                            workbook.Worksheets.Add(bll.DanhSachSanPhamKhongHinhAnh(), "Sản phẩm");
                            workbook.Worksheets.Add(bll.DanhSachChiTietHoaDon(), "CTHĐ");
                            workbook.Worksheets.Add(bll.DanhSachChiTietPhieuNhapHang(), "CP phiếu nhập");
                            workbook.Worksheets.Add(bll.DanhSachNhaSanXuat(), "Nhà cung cấp");
                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("Xuất file thành công!", "Xuất Excel",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        }
    }
}
