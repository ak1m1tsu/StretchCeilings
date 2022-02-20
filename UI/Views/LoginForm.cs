using System;
using System.Windows.Forms;
using StretchCeilings.App.Services;
using StretchCeilings.DataAccess.Repositories;
using StretchCeilings.Domain.Services;
using StretchCeilings.UI.Extensions;
using StretchCeilings.UI.Structs;

namespace StretchCeilings.UI.Views
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        private MainForm _mainForm;

        public LoginForm()
        {
            _authService = new AuthService(new EmployeeRepository());
            InitializeComponent();
        }

        private void LogIn(object sender, EventArgs e)
        {
            if (_authService.Login(mtbLogin.Text, tbPassword.Text) == false)
            {
                FlatMessageBox.ShowDialog("Неверный логин или пароль.", Caption.Error);
                return;
            }

            Hide();

            _mainForm = new MainForm();
            _mainForm.FormClosed += CloseApp;
            _mainForm.Show();
        }

        private void PressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LogIn(sender, e);
        }

        private void LoadForm(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
            btnClose.FlatAppearance.MouseOverBackColor = DraculaColor.Red;
        }

        private void EnterClicked(object sender, KeyEventArgs e)
        {
            PressEnter(sender, e);
        }

        private void CloseApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }
    }
}
