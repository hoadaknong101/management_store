using System;
using System.Drawing;
using System.Windows.Forms;

namespace management_store
{
    public partial class UCSanPhamVuong : UserControl
    {
        #region Properties
        UCHoaDon.delThemSanPhamVaoHoaDon them;
        private int maSP;
        private string tenSP;
        private float donGia;
        private Image hinhAnh;
        #endregion

        public UCSanPhamVuong()
        {
            InitializeComponent();
        }

        public UCSanPhamVuong(int maSP, string tenSP, float donGia, Image hinhAnh, UCHoaDon.delThemSanPhamVaoHoaDon sender)
        {
            InitializeComponent();
            lblMaSP.Text = "Mã SP: " + maSP;
            lblTenSanPham.Text = "Tên SP: " + tenSP;
            lblGia.Text =  "Giá : " + donGia + " VNĐ";
            picHinhAnh.Image = hinhAnh;
            this.them = sender;
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.donGia = donGia;
            this.hinhAnh = hinhAnh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them.Invoke(maSP, tenSP, donGia, hinhAnh);
        }
    }
}
