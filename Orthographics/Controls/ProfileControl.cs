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
    public partial class ProfileControl : UserControl
    {
        Control parent;
        public ProfileControl(Control parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            parent.Controls.Clear();
            GameControl gc = new GameControl(parent);
            gc.Left = (parent.Width - gc.Width) / 2;
            gc.Top = (parent.Height - gc.Height) / 2;
            parent.Controls.Add(gc);
        }
    }
}
