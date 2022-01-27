using System;
using System.Linq;
using System.Windows.Forms;
using stretch_ceilings_app.Forms;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.CustomControls;
using stretch_ceilings_app.Utility.Extensions;

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
            var btnManufacturers = new FlatButton("btnManufacturers", "Производители");
            btnManufacturers.Click += btnManufacturers_Click;

            var btnAdditionalService = new FlatButton("btnAdditionalService", "Дополнительный услуги");
            btnAdditionalService.Click += btnAdditionalService_Click;

            var btnServices = new FlatButton("btnServices", "Услуги");
            btnServices.Click += btnServices_Click;

            var btnEmployes = new FlatButton("btnEmployees", "Сотрудники");
            btnEmployes.Click += btnEmployees_Click;

            var btnCustomers = new FlatButton("btnCustomers", "Клиенты");
            btnCustomers.Click += btnCustomers_Click;

            var btnOrders = new FlatButton("btnOrders", "Заказы");
            btnOrders.Click += btnOrders_Click;

            var buttons = new Button[]
            {
                btnOrders, btnCustomers, btnEmployes, btnServices, btnAdditionalService, btnManufacturers
            }.Reverse().ToArray();

            panelNav.Controls.AddRange(buttons);
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
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTop_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            DllExtensions.ReleaseCapture();
            DllExtensions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
