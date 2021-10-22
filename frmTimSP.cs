using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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

        Function func = new Function();
        DataTable dtSP;

        private int maSP;
        private string tenSP;
        private float donGia ;
        private Image hinhAnh;

        public frmTimSP(UCHoaDon.delThemSanPhamVaoHoaDon them)
        {
            InitializeComponent();
            dtSP = func.GetDataToDataTable("Select * from SanPham");
            this.them = them;
            LoadSP();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
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
        private void frmTimSP_Load(object sender, EventArgs e)
        {
            
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
            if(txtTimKiem.Text.Trim() == "")
            {
                string sql = "SELECT * FROM SanPham";
                dtSP = func.GetDataToDataTable(sql);
                fpnlMain.Controls.Clear();
                LoadSP();
            }
        }

        private void picTim_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM SanPham WHERE TenSanPham LIKE N'%" + txtTimKiem.Text.Trim() + "%'";
            dtSP = func.GetDataToDataTable(sql);
            fpnlMain.Controls.Clear();
            LoadSP();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fpnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
