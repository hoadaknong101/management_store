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
    public partial class UCSanPhamVuong : UserControl
    {
        UCHoaDon.delThemSanPhamVaoHoaDon them;
        private int maSP;
        private string tenSP;
        private float donGia;
        private Image hinhAnh;
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
            them.Invoke(this.maSP, this.tenSP, this.donGia, this.hinhAnh);
        }
    }
}
