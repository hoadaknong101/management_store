using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace management_store
{
    public partial class frmTimSP : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        UCHoaDon.delThemSanPhamVaoHoaDon them;

        DataAccessLayer func = new DataAccessLayer();
        DataTable dtSP;

        private int maSP;
        private string tenSP;
        private float donGia ;
        private Image hinhAnh;

        public frmTimSP(UCHoaDon.delThemSanPhamVaoHoaDon them)
        {
            InitializeComponent();
            dtSP = func.GetDataToDataTable("select * from SanPham where SoLuongTrongKho > 0");
            this.them = them;
            LoadSP();
        }

        private void LoadSP()
        {
            for (int i = 0; i < dtSP.Rows.Count; i++)
            {
                maSP = int.Parse(dtSP.Rows[i][0].ToString());
                tenSP = dtSP.Rows[i][1].ToString();
                donGia = float.Parse(dtSP.Rows[i][3].ToString());
                hinhAnh = ByteArrayToImage((byte[])dtSP.Rows[i][4]);
                fpnlMain.Controls.Add(new UCSanPhamVuong(maSP, tenSP, donGia, hinhAnh, them));
            }
        }
        private Image ByteArrayToImage(byte[] b)
        {
            MemoryStream ms = new MemoryStream(b);
            Image img = Image.FromStream(ms, true);
            return img;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtTimKiem_TextChange(object sender, EventArgs e)
        {

        }

        private void picTim_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM SanPham WHERE TenSanPham LIKE N'%" + txtTimKiem.Text.Trim() + "%' and SoLuongTrongKho > 0";
            dtSP = func.GetDataToDataTable(sql);
            fpnlMain.Controls.Clear();
            LoadSP();
        }

        private void fpnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
