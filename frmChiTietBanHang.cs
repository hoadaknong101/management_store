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
    public partial class frmChiTietBanHang : Form
    {
        public frmChiTietBanHang()
        {
            InitializeComponent();
            dgvDanhSachHoaDon.DataSource = BusinessLogicLayer.Instance().DanhSachChiTietHoaDon();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch
            {
                return;
            }

        }
    }
}
