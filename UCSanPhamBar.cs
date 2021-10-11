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
        public UCHoaDon.TinhTongTien tinhTongTien;
        public UCHoaDon.XoaItem xoa;
        public UCHoaDon.CapNhatTongTien capNhat;
        
        public int MaSP { get; set; }
        public Image HinhAnh { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public float TongGia { get; set; }
        public float DonGia { get; set; }
        public UCSanPhamBar(int maSP, Image hinhAnh, string tenSP, float donGia,int soLuong, UCHoaDon.TinhTongTien a, UCHoaDon.XoaItem xoa, UCHoaDon.CapNhatTongTien capNhat)
        {
            InitializeComponent();
            MaSP = maSP;
            HinhAnh = hinhAnh;
            DonGia = donGia;
            TenSP = tenSP;
            SoLuong = soLuong;

            lblMaSP.Text = maSP + "";
            lblTenSP.Text = tenSP;
            ptbImage.Image = hinhAnh;
            lblDonGia.Text = donGia + "";
            TongGia = DonGia * SoLuong;
            txtSoLuong.Text = 1 + "";
            tinhTongTien = a;
            this.xoa = xoa;
            this.capNhat = capNhat;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            this.Dispose();
            tinhTongTien.Invoke();
            xoa.Invoke(this);
            capNhat.Invoke();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TongGia = DonGia * int.Parse(txtSoLuong.Text.Trim());
                this.SoLuong = int.Parse(txtSoLuong.Text.Trim());
                capNhat.Invoke(TongGia);
            }
            catch
            {
                return;
            }
        }
    }
}
