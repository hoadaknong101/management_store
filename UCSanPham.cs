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
    public partial class UCSanPham : UserControl
    {
        private Function func = new Function();
        private DataTable dtb;
        static UCSanPham _obj;

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
            settingdgvSanPham();
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UCSanPham_Load(object sender, EventArgs e)
        {
        }

        private void settingdgvSanPham()
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
        }

        private void dgvSanPham_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
