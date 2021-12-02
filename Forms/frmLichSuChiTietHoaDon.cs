using System;
using System.Windows.Forms;

namespace management_store
{
    public partial class frmLichSuChiTietHoaDon : Form
    {
        private string maHoaDon;
        public frmLichSuChiTietHoaDon(string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            dgvChiTietHoaDon.DataSource = BusinessLogicLayer.Instance().ChiTietHoaDon(this.maHoaDon);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
