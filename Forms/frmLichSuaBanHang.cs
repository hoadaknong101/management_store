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
    public partial class frmLichSuaBanHang : Form
    {
        private string maHoaDon;
        public frmLichSuaBanHang()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dgvDanhSachHoaDon.DataSource = BusinessLogicLayer.Instance().ThongTinToanBoHoaDon();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDanhSachHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmChiTietHoaDon frm = new frmChiTietHoaDon(dgvDanhSachHoaDon.CurrentRow.Cells[0].Value.ToString());
                frm.ShowDialog();
            }
            catch
            {
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa hóa đơn \n" + maHoaDon, "Xóa hóa đơn", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BusinessLogicLayer.Instance().XoaHoaDon(maHoaDon);
                MessageBox.Show("Xóa hóa đơn thành công", "Xóa hóa đơn");
                LoadData();
                btnXoa.Enabled = false;
                dgvDanhSachHoaDon.ClearSelection();
            } 
        }

        private void dgvDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            maHoaDon = dgvDanhSachHoaDon.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
