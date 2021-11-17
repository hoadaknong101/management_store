using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management_store.Forms
{
    public partial class frmChiTietPhieuNhapHang : Form
    {
        public frmChiTietPhieuNhapHang(DataTable dt)
        {
            InitializeComponent();
            dgvChiTietPhieuNhapHang.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
