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
    public partial class UCNhanVien : UserControl
    {
        private static UCNhanVien _obj;

        public static UCNhanVien Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCNhanVien();
                }
                return _obj;
            }
        }
        public UCNhanVien()
        {
            InitializeComponent();
        }

        private void UCNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
