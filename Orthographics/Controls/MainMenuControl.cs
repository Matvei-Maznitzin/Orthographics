using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orthographics
{
    public partial class MainMenuControl : UserControl
    {
        private Control parent;
        public MainMenuControl(Control parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            parent.Controls.Clear();
            LoginControl lc = new LoginControl(parent);
            lc.Left = (parent.Width - lc.Width) / 2;
            lc.Top = (parent.Height - lc.Height) / 2;
            parent.Controls.Add(lc);
        }
    }
}
