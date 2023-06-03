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
    public partial class GameControl : UserControl
    {
        Control parent;
        long userId;
        long theoryId;
        public GameControl(Control parent, long userId)
        {
            InitializeComponent();
            this.parent = parent;
            this.userId = userId;
            TheoryControl tc = new TheoryControl("../../Theory/page_1.html");
            tc.Dock = DockStyle.Fill;
            tc.Margin = new Padding(10);
            this.splitContainer.Panel1.Controls.Add(tc);
        }
    }
}
