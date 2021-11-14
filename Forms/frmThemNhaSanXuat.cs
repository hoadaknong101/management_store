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
    public partial class frmThemNhaSanXuat : Form
    {
        public frmThemNhaSanXuat()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLogicLayer.Instance().ThemNhaSanXuat(
                                txtTenNhaSanXuat.Text,
                                txtDiaChi.Text,
                                txtLienHe.Text,
                                txtWebsite.Text,
                                txtZipCode.Text,
                                txtKhuVuc.Text);
            }
            catch
            {
                MessageBox.Show("Lỗi thêm thông tin nhà sản xuất", "Thêm thông tin NSX",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
