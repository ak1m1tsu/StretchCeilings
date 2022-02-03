using System;
using System.Linq;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Controls;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Extensions.Controls;

namespace StretchCeilings.Views
{
    public partial class MainForm : Form
    {
        private Form _activeForm;
        private readonly OrdersForm _ordersForm;
        private readonly CustomersForm _customersForm;
        private readonly EmployeesForm _employeesForm;
        private readonly ServicesForm _servicesForm;
        private readonly ManufacturersForm _manufacturersForm;
        private readonly AdditionalServicesForm _additionalServicesForm;

        public MainForm()
        {
            _servicesForm = new ServicesForm();
            _customersForm = new CustomersForm();
            _employeesForm = new EmployeesForm();
            _ordersForm = new OrdersForm();
            _additionalServicesForm = new AdditionalServicesForm();
            _manufacturersForm = new ManufacturersForm();
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (childForm == _activeForm) return;
            
            _activeForm = childForm;
            _activeForm.TopLevel = false;
            panelContent.Controls.Add(_activeForm);
            _activeForm.Dock = DockStyle.Fill;
            _activeForm.BringToFront();
            _activeForm.Show();
        }

        private void DrawNavigationButtons()
        {
            var buttons = new Button[]
            {
                new FlatButton("btnOrders", "Заказы", ShowOrdersForm),
                new FlatButton("btnCustomers", "Клиенты", ShowCustomersForm),
                new FlatButton("btnEmployees", "Сотрудники", ShowEmployeesForm),
                new FlatButton("btnServices", "Услуги", ShowServicesForm),
                new FlatButton("btnAdditionalService", "Дополнительный услуги", ShowAdditionalServicesForm),
                new FlatButton("btnManufacturers", "Производители", ShowManufacturersForm)
            }.Reverse();

            panelNav.AddButtons(buttons.ToArray());
        }

        private void SetUpForm()
        {
            btnCloseApp.FlatAppearance.MouseOverBackColor = DraculaColor.Red;
            DrawNavigationButtons();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetUpForm();
        }

        private void ShowOrdersForm(object sender, EventArgs e)
        {
            OpenChildForm(_ordersForm);
        }

        private void ShowCustomersForm(object sender, EventArgs e)
        {
            OpenChildForm(_customersForm);
        }

        private void ShowEmployeesForm(object sender, EventArgs e)
        {
            OpenChildForm(_employeesForm);
        }

        private void ShowServicesForm(object sender, EventArgs e)
        {
            OpenChildForm(_servicesForm);
        }

        private void ShowManufacturersForm(object sender, EventArgs e)
        {
            OpenChildForm(_manufacturersForm);
        }

        private void ShowAdditionalServicesForm(object sender, EventArgs e)
        {
            OpenChildForm(_additionalServicesForm);
        }

        private void MinimizeApp(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
                WindowState = FormWindowState.Minimized;
        }

        private void MaximizeApp(object sender, EventArgs e)
        {
            WindowState = WindowState != FormWindowState.Maximized ? FormWindowState.Maximized : FormWindowState.Normal;
            btnResiizeApp.IconChar = btnResiizeApp.IconChar == Constants.WindowMaximizeIcon
                ? Constants.WindowRestoreIcon
                : Constants.WindowMaximizeIcon;
        }

        private void CloseApp(object sender, EventArgs e)
        {
            Close();
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }
    }
}
