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
    public partial class frmNhaSanXuat : Form
    {
        private int maNSX;
        public frmNhaSanXuat()
        {
            InitializeComponent();
            LoadData();
            Setting(false);
        }

        private void LoadData()
        {
            dgvNhaSanXuat.DataSource = BusinessLogicLayer.Instance().DanhSachNhaSanXuat();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhaSanXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Setting(true);
            try
            {
                maNSX = int.Parse(dgvNhaSanXuat.CurrentRow.Cells[0].Value.ToString());
                txtTenNhaSanXuat.Text = dgvNhaSanXuat.CurrentRow.Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNhaSanXuat.CurrentRow.Cells[2].Value.ToString();
                txtLienHe.Text = dgvNhaSanXuat.CurrentRow.Cells[3].Value.ToString();
                txtWebsite.Text = dgvNhaSanXuat.CurrentRow.Cells[4].Value.ToString();
                txtZipCode.Text = dgvNhaSanXuat.CurrentRow.Cells[5].Value.ToString();
                txtKhuVuc.Text = dgvNhaSanXuat.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNhaSanXuat frm = new frmThemNhaSanXuat();
            frm.ShowDialog();
            LoadData();
            Setting(false);
            ClearText();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            maNSX = int.Parse(dgvNhaSanXuat.CurrentRow.Cells[0].Value.ToString());
            frmCapNhatNhaSanXuat frm = new frmCapNhatNhaSanXuat(maNSX, txtTenNhaSanXuat.Text, 
                txtDiaChi.Text, txtLienHe.Text, txtWebsite.Text, txtZipCode.Text, txtKhuVuc.Text);
            frm.ShowDialog();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa thông tin về \n" + 
                txtTenNhaSanXuat.Text + "?" + "\nĐồng nghĩa với việc tất cả sản phẩm \n" +
                "trong kho do nhà sản xuất này\n" +
                "cung cấp cũng sẽ đều bị xóa\n" +
                "khỏi cơ sở dữ liệu!","Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try 
                { 
                    BusinessLogicLayer.Instance().XoaNhaSanXuat(maNSX);
                    MessageBox.Show("Xóa thành công", "Xóa");
                }
                catch
                {
                    MessageBox.Show("Bạn không thể xóa nhà cung cấp này!", "Lỗi");
                }
                finally
                {
                    ClearText();
                    Setting(false);
                    LoadData();
                }                
            }
        }

        private void Setting(bool status)
        {
            btnCapNhat.Enabled = status;
            btnXoa.Enabled = status;
            dgvNhaSanXuat.ClearSelection();
        }

        private void ClearText()
        {
            txtTenNhaSanXuat.Clear();
            txtDiaChi.Clear();
            txtLienHe.Clear();
            txtWebsite.Clear();
            txtZipCode.Clear();
            txtKhuVuc.Clear();
        }
    }
}
