using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.DLL;
using StretchCeilings.Helpers.Structs;
using StretchCeilings.Models;
using StretchCeilings.Repositories;

namespace StretchCeilings.Views
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
            _users = EmployeeRepository.GetAll();
        }

        private void LogIn()
        {
            if (UserSession.LogIn(mtbLogin.Text, tbPassword.Text) == false)
            {
                CustomMessageBox.ShowDialog("Неверный логин или пароль.", Caption.Error);
                return;
            }

            Hide();
            _mainForm = new MainForm();
            _mainForm.FormClosed += btnCloseApp_Click;
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
            btnClose.FlatAppearance.MouseOverBackColor = DraculaColor.Red;
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
            Application.Exit();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            User32Helper.ReleaseCapture();
            User32Helper.SendMessage(Handle, User32Helper.WmNclButtonDown, User32Helper.HtCaption, 0);
        }
    }
}
