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
    public partial class frmNhapHang : Form
    {
        DataTable dtNhaSanXuat;
        public frmNhapHang()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dtNhaSanXuat = BusinessLogicLayer.Instance().DanhSachNhaSanXuat();
            List<string> lstMaNSX = new List<string>();
            for(int i =0;i < dtNhaSanXuat.Rows.Count; i++)
            {
                lstMaNSX.Add(dtNhaSanXuat.Rows[i][0].ToString());
            }
            cbbMaNhaSanXuat.DataSource = lstMaNSX;
            txtTenNhaSanXuat.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text.ToString()), 1);
            txtDiaChi.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 2);
            txtLienHe.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 3);
            txtWebsite.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 4);
            txtZipCode.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 5);
            txtKhuVuc.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 6);
        }

        private void cbbMaNhaSanXuat_TextChanged(object sender, EventArgs e)
        {
            txtTenNhaSanXuat.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text.ToString()), 1);
            txtDiaChi.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 2);
            txtLienHe.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 3);
            txtWebsite.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 4);
            txtZipCode.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 5);
            txtKhuVuc.Text = BusinessLogicLayer.Instance().LayGiaTriTrongBangNhaSanXuat(int.Parse(cbbMaNhaSanXuat.Text), 6);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn tạo mới danh sách đã nhập?","Tạo mới danh sách",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvChiTietPhieuNhap.Rows.Clear();
            }
        }
    }
}
