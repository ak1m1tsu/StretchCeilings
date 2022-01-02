using System;
using System.Windows.Forms;
using stretch_ceilings_app.Forms;
using stretch_ceilings_app.Utility.CustomControls;

namespace stretch_ceilings_app
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
            var btnOrders = new FlatButton("btnOrders", "Заказы");
            btnOrders.Click += btnOrders_Click;
            panelNav.Controls.Add(btnOrders);

            var btnCustomers = new FlatButton("btnCustomers", "Клиенты");
            btnCustomers.Click += btnCustomers_Click;
            panelNav.Controls.Add(btnCustomers);

            var btnEmployes = new FlatButton("btnEmployees", "Сотрудники");
            btnEmployes.Click += btnEmployees_Click;
            panelNav.Controls.Add(btnEmployes);

            var btnServices = new FlatButton("btnServices", "Услуги");
            btnServices.Click += btnServices_Click;
            panelNav.Controls.Add(btnServices);

            var btnManufacturers = new FlatButton("btnManufacturers", "Производители");
            btnManufacturers.Click += btnManufacturers_Click;
            panelNav.Controls.Add(btnManufacturers);

            var btnManufacturerOrders = new FlatButton("btnManufacturerOrders", "Заказы для производителей");
            btnManufacturerOrders.Click += btnManufacturerOrders_Click;
            panelNav.Controls.Add(btnManufacturerOrders);

            var btnAdditionalService = new FlatButton("btnAdditionalService", "Дополнительный услуги");
            btnAdditionalService.Click += btnAdditionalService_Click;
            panelNav.Controls.Add(btnAdditionalService);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DrawNavigationButtons();
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

        private void btnManufacturerOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManufacturerOrdersForm());
        }

        private void btnAdditionalService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdditionalServicesForm());
        }
    }
}
