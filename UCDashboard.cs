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
    public partial class UCDashboard : UserControl
    {
        static UCDashboard _obj;
        public static UCDashboard Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new UCDashboard();
                }
                return _obj;
            }
        }
        public UCDashboard()
        {
            InitializeComponent();
        }
    }
}
