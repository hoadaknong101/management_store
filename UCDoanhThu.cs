using System;
using System.Data;
using System.Windows.Forms;

namespace management_store
{
    public partial class UCDoanhThu : UserControl
    {
        static UCDoanhThu _obj;
        private BLL func = new BLL();

        public static UCDoanhThu Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new UCDoanhThu();
                }
                return _obj;
            }
        }
        public UCDoanhThu()
        {
            InitializeComponent();
            LoadData();
            TakeInfor();
        }

        public void TakeInfor()
        {
            lblNhanVien.Text = UCNhanVien.Instance.dtb.Rows.Count.ToString();
            lblHoaDon.Text = dgvHoaDon.Rows.Count.ToString();
            //lblChiTieu.Text = "";
            //lblThuNhap.Text = "";
            //lbl_spDaBan.Text = "";
            //lbl_spTrongKho.Text = "";
        }

        public void LoadData()
        {
            dgvHoaDon.DataSource = func.ThongTinToanBoHoaDon();
            dgvPhieuNhap.DataSource = func.ThongTinToanBoPhieuNhap();
        }

        private void picVisible_Click(object sender, EventArgs e)
        {
            pnlInfor.Visible = !pnlInfor.Visible;
        }
    }
}
