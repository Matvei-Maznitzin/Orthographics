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
        long userId;
        public ProfileControl(Control parent, long userId)
        {
            InitializeComponent();
            this.parent = parent;
            this.userId = userId;
            userNameLabel.Text = DataBaseController.GetUserLogin(userId);
            scoreLabel.Text = $"Счёт: {DataBaseController.GetRate(userId)}";
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            parent.Controls.Clear();
            GameControl gc = new GameControl(parent, userId);
            //gc.Left = (parent.Width - gc.Width) / 2;
            //gc.Top = (parent.Height - gc.Height) / 2;
            parent.Controls.Add(gc);
        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
