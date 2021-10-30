using System;
using System.Data;
using System.Windows.Forms;

namespace management_store
{
    public partial class UCDoanhThu : UserControl
    {
        static UCDoanhThu _obj;
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
            TakeInfor();
        }

        public void TakeInfor()
        {
            lblNhanVien.Text = "0";
        }

        private void picVisible_Click(object sender, EventArgs e)
        {
            pnlInfor.Visible = !pnlInfor.Visible;
        }
    }
}
