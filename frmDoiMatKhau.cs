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
    public partial class frmDoiMatKhau : Form
    {
        private BLL bll = new BLL();
        private DataTable ds = new DataTable();
        private int ID_NhanVien;
        public frmDoiMatKhau(int ID_NhanVien)
        {
            InitializeComponent();
            this.ID_NhanVien = ID_NhanVien;
            ds=bll.ThongTinNhanVien(this.ID_NhanVien);
            txtHoTen.Text = ds.Rows[0][1].ToString();
            txtMaNhanVien.Text = ID_NhanVien.ToString();
            txtHoTen.Enabled = false;
            txtMaNhanVien.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == ds.Rows[0][7].ToString())
            {
                if (txtMatKhauMoi.Text == txtXacNhanMatKhau.Text)
                {
                    bll.DoiMatKhau(ID_NhanVien,txtMatKhauMoi.Text);
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
