using stretch_ceilings_app.Utility;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility.Extensions;
using stretch_ceilings_app.Utility.Repositories;

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

        private void LoadUsers()
        {
            _users = EmployeeRepository.GetEmployees();
        }

        private void LogIn()
        {
            if (UserSession.LogIn(_users, mtbLogin.Text, tbPassword.Text) == false)
            {
                MessageBox.Show("Неверный логин или пароль.", "Авторизация не пройдена.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            _mainForm = new MainForm();
            _mainForm.FormClosed += (o, args) => this.Close();
            _mainForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void PressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            tbPassword.PasswordChar = '*';
            btnCloseApp.FlatAppearance.MouseOverBackColor = Constants.DraculaRed;
        }

        private void mtbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            PressEnter(sender, e);
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            PressEnter(sender, e);
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            DllExtensions.ReleaseCapture();
            DllExtensions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
