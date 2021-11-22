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
    public partial class frmChiTietHoaDon : Form
    {
        private string maHoaDon;
        public frmChiTietHoaDon(string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            dgvChiTietHoaDon.DataSource = BusinessLogicLayer.Instance().ChiTietHoaDon(this.maHoaDon);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaHoaDon.Text = dgvChiTietHoaDon.CurrentRow.Cells[0].Value.ToString();
                txtMaSanPham.Text = dgvChiTietHoaDon.CurrentRow.Cells[1].Value.ToString();
                txtSoLuong.Text = dgvChiTietHoaDon.CurrentRow.Cells[3].Value.ToString();
                txtThanhTien.Text = dgvChiTietHoaDon.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
