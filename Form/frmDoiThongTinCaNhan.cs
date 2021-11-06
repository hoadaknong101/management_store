using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace management_store
{
    public partial class frmDoiThongTinCaNhan : Form
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private int IDNhanVien;
        public frmDoiThongTinCaNhan(int IDNhanVien)
        {
            InitializeComponent();
            this.IDNhanVien = IDNhanVien;
            LoadData();
        }

        #region Convert_Image
        private byte[] ImageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
        private byte[] PathToByteArray(string path)
        {
            return File.ReadAllBytes(path);
        }
        private Image ByteArrayToImage(byte[] b)
        {
            MemoryStream ms = new MemoryStream(b);
            Image img = Image.FromStream(ms, true);
            return img;
        }
        #endregion

        private void LoadData()
        {
            DataTable dt = bll.ThongTinNhanVien(IDNhanVien);
            try
            {
                txtMaNV.Text = dt.Rows[0][0].ToString();
                txtHoTen.Text = dt.Rows[0][1].ToString();
                txtGioiTinh.Text = dt.Rows[0][5].ToString();
                txtDiaChi.Text = dt.Rows[0][3].ToString();
                txtCCCD.Text = dt.Rows[0][6].ToString();
                txtLienHe.Text =  dt.Rows[0][2].ToString();
                Image hinhAnh = ByteArrayToImage((byte[])dt.Rows[0][4]);
                picImage.Image = hinhAnh;
            }
            catch
            {
                MessageBox.Show("Không thể hiển thị thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChonHinhAnh_Click(object sender, System.EventArgs e)
        {
            string pathImage;
            OpenFileDialog chonHinhAnh = new OpenFileDialog();
            if (chonHinhAnh.ShowDialog() == DialogResult.OK)
            {
                pathImage = chonHinhAnh.FileName;
                picImage.Image = Image.FromFile(pathImage);
            }
        }

        private void btnLuu_Click(object sender, System.EventArgs e)
        {
            try
            {
                bll.CapNhatNhanVien(int.Parse(txtMaNV.Text), txtHoTen.Text, txtLienHe.Text, txtDiaChi.Text, picImage.Image, txtGioiTinh.Text, txtCCCD.Text);
                MessageBox.Show("Thay đổi thông tin thành công!", "Thông báo");
                LoadData();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể thay đổi thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
