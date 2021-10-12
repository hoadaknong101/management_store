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

        private void picFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/hoaffffff/");

        }

        private void picInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/hoaffffffffff/");
            
        }

        private void picYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/quochoaeditor");
        }

        private void picPinterest_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pinterest.com/hoadaknong101/");
        }
    }
}
