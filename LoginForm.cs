using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Controls;
using StretchCeilings.Helpers.DLL;
using StretchCeilings.Models;
using StretchCeilings.Repositories;

namespace StretchCeilings
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
            _users = EmployeeModelsRepository.GetAll();
        }

        private void LogIn()
        {
            if (UserSession.LogIn(_users, mtbLogin.Text, tbPassword.Text) == false)
            {
                CustomMessageBox.Show("Неверный логин или пароль.", Constants.ErrorCaption);
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
            btnClose.FlatAppearance.MouseOverBackColor = Constants.DraculaRed;
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
            User32.ReleaseCapture();
            User32.SendMessage(this.Handle, User32.VM_NCLBUTTONDOWN, User32.HT_CAPTION, 0);
        }
    }
}
