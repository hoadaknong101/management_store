using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management_store.Forms
{
    public partial class frmLichSuNhapHang : Form
    {
        public frmLichSuNhapHang()
        {
            InitializeComponent();
        }

        private void frmLichSuNhapHang_Load(object sender, EventArgs e)
        {
            dgvPhieuNhapHang.DataSource = BusinessLogicLayer.Instance().ThongTinToanBoPhieuNhap();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPhieuNhapHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maPhieuNhapHang = dgvPhieuNhapHang.CurrentRow.Cells[0].Value.ToString();
            DataTable dt = BusinessLogicLayer.Instance().ChiTietPhieuNhap(maPhieuNhapHang);
            frmChiTietPhieuNhapHang frm = new frmChiTietPhieuNhapHang(dt);
            frm.ShowDialog();
        }
    }
}
