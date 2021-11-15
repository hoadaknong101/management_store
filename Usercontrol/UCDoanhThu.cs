using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
                if(_obj == null)
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
            lblChiTieu.Text = "Tổng chi tiêu : " + bll.TongChiTieu().ToString("N", CultureInfo.InvariantCulture) + " VNĐ";
            lblThuNhap.Text = "Tổng thu nhập : " + bll.TongThuNhap().ToString("N", CultureInfo.InvariantCulture) + " VNĐ";
            lbl_spDaBan.Text = bll.SoLuongSanPhamDaBan().ToString();
            lbl_spTrongKho.Text = bll.SoLuongSanPhamTrongKho().ToString();
        }

        public void LoadData()
        {
            dgvHoaDon.DataSource = bll.ThongTinToanBoHoaDon();
            dgvPhieuNhap.DataSource = bll.ThongTinToanBoPhieuNhap();
        }

        private void picVisible_Click(object sender, EventArgs e)
        {
            pnlInfor.Visible = !pnlInfor.Visible;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            chartThongKe.Series["Thu nhập"].Points.AddXY("8", 33);
            chartThongKe.Series["Thu nhập"].Points.AddXY("9", 45);
            chartThongKe.Series["Thu nhập"].Points.AddXY("10", 26);
            chartThongKe.Series["Thu nhập"].Points.AddXY("11", 77);
            chartThongKe.Series["Thu nhập"].Points.AddXY("12", 80);
            chartThongKe.Series["Chi tiêu"].Points.AddXY("8", 30);
            chartThongKe.Series["Chi tiêu"].Points.AddXY("9", 41);
            chartThongKe.Series["Chi tiêu"].Points.AddXY("10", 16);
            chartThongKe.Series["Chi tiêu"].Points.AddXY("11", 76);
            chartThongKe.Series["Chi tiêu"].Points.AddXY("12", 82);
        }
    }
}
