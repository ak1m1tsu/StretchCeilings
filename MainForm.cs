using System;
using System.Windows.Forms;
using stretch_ceilings_app.Utility.CustomBtn;
using stretch_ceilings_app.Models;
using System.Collections.Generic;
using stretch_ceilings_app.Data;
using stretch_ceilings_app.Utility.Enums;
using System.Linq;

namespace stretch_ceilings_app
{
    public partial class MainForm : Form
    {
        private Form _activeForm;
        private Employee _user;
        private List<NavigationButton> btns;

        public MainForm(Employee user)
        {
            _user = user;
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelContent.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btns = new List<NavigationButton>();

            NavigationButton btnOrders = new NavigationButton("btnOrders", "Заказы");
            btnOrders.Click += btnOrders_Click;
            btns.Add(btnOrders);

            NavigationButton btnCustomers = new NavigationButton("btnCustomers", "Клиенты");
            btnCustomers.Click += btnCustomers_Click;
            btns.Add(btnCustomers);

            NavigationButton btnEmployes = new NavigationButton("btnEmployees", "Сотрудники");
            btnEmployes.Click += btnEmployees_Click;
            btns.Add(btnEmployes);

            btns.Reverse();
            panelNav.Controls.AddRange(btns.ToArray());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            OpenChildForm(ordersForm);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();
            OpenChildForm(customersForm);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm();
            OpenChildForm(employeesForm);
        }
    }
}
