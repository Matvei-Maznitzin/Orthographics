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

namespace Orthographics
{
    public partial class TheoryControl : UserControl
    {
        public TheoryControl(string path)
        {
            InitializeComponent();
            string url = $"file:///{Directory.GetCurrentDirectory()}/{path}";
            this.webBrowser.Url = new Uri(url);
        }
    }
}
