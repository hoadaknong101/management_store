using System;
using System.Data;
using System.Windows.Forms;

namespace management_store
{
    public partial class frmDoiMatKhau : Form
    {
        #region Properties
        private BusinessLogicLayer bll = new BusinessLogicLayer();
        private DataTable dt = new DataTable();
        private int ID_NhanVien;
        #endregion

        public frmDoiMatKhau(int ID_NhanVien)
        {
            InitializeComponent();

            this.ID_NhanVien = ID_NhanVien;
            dt = bll.ThongTinNhanVien(this.ID_NhanVien);
            txtHoTen.Text = dt.Rows[0][1].ToString();
            txtMaNhanVien.Text = ID_NhanVien.ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == dt.Rows[0][7].ToString())
            {
                if (txtMatKhauMoi.Text == txtXacNhanMatKhau.Text)
                {
                    bll.DoiMatKhau(ID_NhanVien, txtMatKhauMoi.Text);
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
