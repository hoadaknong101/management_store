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
    }
}
