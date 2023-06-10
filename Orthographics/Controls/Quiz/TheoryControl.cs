using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orthographics.Controls.Quiz
{
    public partial class TheoryControl : UserControl
    {
        string path;
        public TheoryControl(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void TheoryControl_Load(object sender, EventArgs e)
        {
            string cur = Directory.GetCurrentDirectory();
            string url_string = $"file:///{cur}/Theory/{path}";
            this.webBrowser.Url = new Uri(url_string);
        }
    }
}
