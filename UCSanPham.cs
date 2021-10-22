using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management_store
{
    public partial class UCSanPham : UserControl
    {
        private Function func = new Function();
        private DataTable dtb;
        static UCSanPham _obj;
        BLL funcc = new BLL();
        public static UCSanPham Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCSanPham();
                }

                return _obj;
            }
        }

        public UCSanPham()
        {
            InitializeComponent();
            dtb = func.GetDataToDataTable("SELECT * FROM SanPham");
            dgvSanPham.DataSource = dtb;
            SettingSanPham();

            btnXoaSP.Enabled = false;
            btnLuuSP.Enabled = false;
            btnHuy.Enabled = false;

        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UCSanPham_Load(object sender, EventArgs e)
        {
        }

        private void SettingSanPham()
        {
            dgvSanPham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvSanPham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvSanPham.Columns[2].HeaderText = "Loại Sản Phẩm";
            dgvSanPham.Columns[3].HeaderText = "Đơn Giá";
            dgvSanPham.Columns[5].HeaderText = "Mã Nhà Sản Xuất";
            dgvSanPham.Columns[6].HeaderText = "Số Lượng";

            dgvSanPham.Columns[5].Width = 130;
            dgvSanPham.Columns[2].Width = 120;
            dgvSanPham.Columns[4].Visible = false;
            dgvSanPham.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            txtTenSanPham.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            txtDonGia.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
            txtLoaiSP.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgvSanPham.CurrentRow.Cells[6].Value.ToString();
            txtMaNSX.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
            picImage.Image = ByteArrayToImage((byte[])dgvSanPham.CurrentRow.Cells[4].Value);

            btnLuuSP.Enabled = true;
            btnXoaSP.Enabled = true;
            btnHuy.Enabled = true;
        }
        // Chuyển ảnh sang byte (Bảo mật thông tin)
        private byte[] ImageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        // Chuyển file ảnh sang byte
        private byte[] PathToByteArray(string path)
        {
            return File.ReadAllBytes(path);
        }

        // Chuyển byte sang ảnh
        private Image ByteArrayToImage(byte[] b)
        {
            MemoryStream ms = new MemoryStream(b);
            Image img = Image.FromStream(ms, true);
            return img;
        }

        private void ClearContent()
        {
            txtTenSanPham.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtLoaiSP.Clear();
            txtMaNSX.Clear();
            txtMaSP.Clear();            
            picImage.Image = null;
            dgvSanPham.ClearSelection();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            ClearContent();
            txtTenSanPham.Focus();
            btnThemSanPham.Enabled = false;
            btnLuuSP.Enabled = true;
            btnHuy.Enabled = true;
            btnXoaSP.Enabled = false;
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            if(btnThemSanPham.Enabled == true)
            {
                //Cập nhật sản phẩm

            }
            else
            {
                //Thêm sản phẩm
                funcc.insertSanPham(txtTenSanPham.Text,
                    txtLoaiSP.Text,
                    float.Parse(txtDonGia.Text),
                    picImage.Image,
                    int.Parse(txtMaNSX.Text),
                    int.Parse(txtSoLuong.Text));
                //try
                //{

                //}
                //catch
                //{
                //    MessageBox.Show("Lỗi vái lol");
                //    return;
                //}
            }
            ClearContent();

            btnThemSanPham.Enabled = true;
            btnXoaSP.Enabled = false;
            btnLuuSP.Enabled = false;
            btnThemSanPham.Enabled = true;
            btnHuy.Enabled = false;
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            //Xóa sản phẩm

            ClearContent();
            btnThemSanPham.Enabled = true;
            btnXoaSP.Enabled = false;
            btnLuuSP.Enabled = false; 
            btnHuy.Enabled = false;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearContent();
            btnThemSanPham.Enabled = true;
            btnXoaSP.Enabled = false;
            btnLuuSP.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnChonHinhAnh_Click(object sender, EventArgs e)
        {
            string pathImage;
            OpenFileDialog chonHinhAnh = new OpenFileDialog();
            
            if(chonHinhAnh.ShowDialog() == DialogResult.OK)
            {
                pathImage = chonHinhAnh.FileName;
                picImage.Image = Image.FromFile(pathImage);
            }
        }
    }
}
