using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace management_store
{
    public partial class UCSanPhamBar : UserControl
    {
        #region Properties
        public UCHoaDon.delCapNhatTongTien capNhatTongTien;
        public UCHoaDon.delXoaSanPham xoaSanPham;
        public int MaSP { get; set; }
        public Image HinhAnh { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public float ThanhTien { get; set; }
        public float DonGia { get; set; }
        #endregion

        public UCSanPhamBar(int maSP, Image hinhAnh, string tenSP, 
            float donGia,int soLuong, UCHoaDon.delCapNhatTongTien capNhatTongTien, UCHoaDon.delXoaSanPham xoaSanPham)
        {
            InitializeComponent();

            this.MaSP = maSP;
            this.HinhAnh = hinhAnh;
            this.DonGia = donGia;
            this.TenSP = tenSP;
            this.SoLuong = soLuong;
            this.ThanhTien = DonGia * SoLuong;
            this.xoaSanPham = xoaSanPham;
            this.capNhatTongTien = capNhatTongTien;

            lblMaSP.Text = maSP + "";
            lblTenSP.Text = tenSP;
            ptbImage.Image = hinhAnh;
            lblDonGia.Text = donGia.ToString("N", CultureInfo.InvariantCulture); // comment?
            txtSoLuong.Text = SoLuong + "";
            lblThanhTien.Text = ThanhTien.ToString("N", CultureInfo.InvariantCulture);
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            this.xoaSanPham.Invoke(this);
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.ThanhTien = this.DonGia * int.Parse(txtSoLuong.Text.Trim());
                this.capNhatTongTien.Invoke();
                lblThanhTien.Text = ThanhTien.ToString("N", CultureInfo.InvariantCulture);
            }
            catch
            {
                return;
            }
        }
    }
}
