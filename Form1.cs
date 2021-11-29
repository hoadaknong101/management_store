using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;
using ThuVienWinform.Report.AsposeWordExtension;
namespace management_store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document d = new Document("Template\\template.docx");

            d.MailMerge.Execute(new[] { "name" }, new[] { "Phạm Văn Thắng" });
            d.SaveAndOpenFile("test.docx");
        }
    }
}
