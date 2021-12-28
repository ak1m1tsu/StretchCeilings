using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace stretch_ceilings_app
{
    public partial class LoginForm : Form
    {
        private MainForm _mainForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            _mainForm = new MainForm();
            _mainForm.FormClosed += (object o, FormClosedEventArgs args) => this.Close();
            _mainForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }
    }
}
