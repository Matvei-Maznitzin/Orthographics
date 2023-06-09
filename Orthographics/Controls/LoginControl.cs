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
    public partial class LoginControl : UserControl
    {
        Control parent;
        public LoginControl(Control parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            long id = DataBaseController.Authorize(login, password);
            if (id == -1)
            {
                MessageBox.Show("Неправильно введена пара логин-пароль.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                parent.Controls.Clear();
                ProfileControl pc = new ProfileControl(parent, id);
                pc.Left = (parent.Width - pc.Width) / 2;
                pc.Top = (parent.Height - pc.Height) / 2;
                parent.Controls.Add(pc);
            }
        }
    }
}
