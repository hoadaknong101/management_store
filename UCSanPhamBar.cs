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
    public partial class UCSanPhamBar : UserControl
    {
        public UCHoaDon.XoaSanPham XoaSanPham;
        public UCSanPhamBar(int maSP, Image hinhAnh,string tenSP, float donGia, UCHoaDon.XoaSanPham xoaSanPham)
        {
            InitializeComponent();
            lblMaSP.Text = maSP + "";
            lblTenSP.Text = tenSP;
            ptbImage.Image = hinhAnh;
            lblDonGia.Text = donGia + "";
            txtSoLuong.Text = "1";
            this.XoaSanPham = xoaSanPham;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            XoaSanPham.Invoke();
        }
    }
}
