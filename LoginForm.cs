using stretch_ceilings_app.Data;
using stretch_ceilings_app.Models;
using stretch_ceilings_app.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace stretch_ceilings_app
{
    public partial class LoginForm : Form
    {
        private MainForm _mainForm;
        private List<Employee> _users;
        public LoginForm()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserSession.LogIn(_users, tbLogin.Text, tbPassword.Text))
            {
                this.Hide();
                _mainForm = new MainForm(UserSession.User);
                _mainForm.FormClosed += (object o, FormClosedEventArgs args) => this.Close();
                _mainForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Авторизация не пройдена.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            using (StretchCeilingsContext db = new StretchCeilingsContext())
            {
                _users = db.Employees.Where(u => u.DateDeleted == null).ToList();
                foreach (var _ in _users)
                {
                    db.Entry(_).Reference("Role").Load();
                }
            }

            tbPassword.PasswordChar = '*';
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            DllExtention.ReleaseCapture();
            DllExtention.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
