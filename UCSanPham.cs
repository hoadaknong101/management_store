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
        static UCSanPham _obj;
        public static UCSanPham Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new UCSanPham();
                }
                return _obj;
            }
        }

        public UCSanPham()
        {
            InitializeComponent();
        }
    }
}
