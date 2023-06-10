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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainMenuControl mmc = new MainMenuControl(MainPanel);
            mmc.Left = (this.ClientSize.Width - mmc.Width) / 2;
            mmc.Top = (this.ClientSize.Height - mmc.Height) / 2;
            MainPanel.Controls.Add(mmc);
        }
    }
}
