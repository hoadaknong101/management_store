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
    public partial class frmCapNhatNhaSanXuat : Form
    {
        private int maNSX;
        public frmCapNhatNhaSanXuat(int maNSX, string tenNhaSanXuat, string diaChi,
            string lienHe, string website, string zipCode, string khuVuc)
        {
            InitializeComponent();
            txtTenNhaSanXuat.Text = tenNhaSanXuat;
            txtDiaChi.Text = diaChi;
            txtLienHe.Text = lienHe;
            txtWebsite.Text = website;
            txtZipCode.Text = zipCode;
            txtKhuVuc.Text = khuVuc;
            this.maNSX = maNSX;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLogicLayer.Instance().CapNhatNhaSanXuat(maNSX,
                                txtTenNhaSanXuat.Text,
                                txtDiaChi.Text,
                                txtLienHe.Text,
                                txtWebsite.Text,
                                txtZipCode.Text,
                                txtKhuVuc.Text);
            }
            catch
            {
                MessageBox.Show("Lỗi cập nhật thông tin nhà sản xuất", "Cập nhật thông tin NSX",
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
