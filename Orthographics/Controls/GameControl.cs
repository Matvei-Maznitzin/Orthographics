﻿using System;
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
        public GameControl(Control parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
    }
}