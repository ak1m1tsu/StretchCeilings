using System;
using System.Linq;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Controls;
using StretchCeilings.Helpers.DLL;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Views;

namespace StretchCeilings
{
    public partial class MainForm : Form
    {
        private Form _activeForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            _activeForm?.Close();
            _activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelContent.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }

        private void DrawNavigationButtons()
        {
            var buttons = new Button[]
            {
                new FlatButton("btnOrders", "Заказы", btnOrders_Click),
                new FlatButton("btnCustomers", "Клиенты", btnCustomers_Click),
                new FlatButton("btnEmployees", "Сотрудники", btnEmployees_Click),
                new FlatButton("btnServices", "Услуги", btnServices_Click),
                new FlatButton("btnAdditionalService", "Дополнительный услуги", btnAdditionalService_Click),
                new FlatButton("btnManufacturers", "Производители", btnManufacturers_Click)
            }.Reverse();

            panelNav.AddButtons(buttons.ToArray());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetUpForm();
            DrawNavigationButtons();
        }

        private void SetUpForm()
        {
            btnCloseApp.FlatAppearance.MouseOverBackColor = Constants.DraculaRed;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrdersForm());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomersForm());
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeesForm());
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ServicesForm());
        }

        private void btnManufacturers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManufacturersForm());
        }

        private void btnAdditionalService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdditionalServicesForm());
        }

        private void btnMinimizeApp_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState != FormWindowState.Maximized ? FormWindowState.Maximized : FormWindowState.Normal;
            btnResiizeApp.IconChar = btnResiizeApp.IconChar == Constants.WindowMaximizeIcon
                ? Constants.WindowRestoreIcon
                : Constants.WindowMaximizeIcon;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTop_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            User32.ReleaseCapture();
            User32.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
