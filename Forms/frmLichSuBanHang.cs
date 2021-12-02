using System;
using System.Windows.Forms;

namespace management_store
{
    public partial class frmLichSuaBanHang : Form
    {
        private string maHoaDon;
        private bool flag;
        public frmLichSuaBanHang(bool flag)
        {
            InitializeComponent();
            LoadData();
            this.flag = flag;
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
            if (flag)
            {
                try
                {
                    frmChiTietHoaDon frm = new frmChiTietHoaDon(dgvDanhSachHoaDon.CurrentRow.Cells[0].Value.ToString());
                    frm.ShowDialog();
                    LoadData();
                    UCDoanhThu.Instance.LoadData();
                    UCDoanhThu.Instance.TakeInfor();
                }
                catch
                {
                    return;
                }
            }
            else
            {
                try
                {
                    frmLichSuChiTietHoaDon frm = new frmLichSuChiTietHoaDon(dgvDanhSachHoaDon.CurrentRow.Cells[0].Value.ToString());
                    frm.ShowDialog();
                }
                catch
                {
                    return;
                }
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
