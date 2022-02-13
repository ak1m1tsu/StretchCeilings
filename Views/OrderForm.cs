using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Extensions;
using StretchCeilings.Extensions.Controls;
using StretchCeilings.Models;
using StretchCeilings.Models.Enums;
using StretchCeilings.Repositories;
using StretchCeilings.Sessions;
using StretchCeilings.Structs;
using StretchCeilings.Views.Enums;

namespace StretchCeilings.Views
{
    public partial class OrderForm : Form
    {
        private readonly FormState _state;

        private Order _order;
        private List<Log> _logs;
        private List<Employee> _employees;
        private List<Service> _services;
        private List<OrderWorkDate> _workDates;

        public OrderForm(Order order, FormState state = FormState.Default)
        {
            _order = order;
            _state = state;
            InitializeComponent();
        }

        private static bool CanUserEdit => UserSession.IsAdmin || 
                                           UserSession.Can(PermissionCode.EditOrder);

        private string TotalToString => $"{_order.Total ?? 0} руб.";


        private void SetupForm()
        {
            linkCustomer.Text = _order.Customer?.FullName;
            linkCustomer.ActiveLinkColor = DraculaColor.Pink;
            linkCustomer.VisitedLinkColor = DraculaColor.Purple;

            lblDatePlacedValue.Text = _order.DatePlaced?.ToString();
            lblDateOfMeasurementsValue.Text = _order?.DateOfMeasurements?.ToString();
            lblDatePaidValue.Text = _order?.DatePaid?.ToString();
            lblStatusValue.Text = _order?.Status?.ParseString();
            lblPriceValue.Text = TotalToString;

            if (_order.PaidByCash == true)
                lblPaidByCashValue.Text = Resources.Yes;

            if (CanUserEdit)
                btnEdit.Enabled = true;

            if (_state == FormState.ForView)
                btnEdit.Visible = false;

            SetupDataGrids();
        }

        private void ReSetupForm()
        {
            if (_order.CustomerId != null)
            {
                var customer = CustomerRepository.GetById(_order.CustomerId.Value);
                linkCustomer.Text = customer?.FullName;
            }

            lblDatePlacedValue.Text = _order?.DatePlaced?.ToString();
            lblDateOfMeasurementsValue.Text = _order?.DateOfMeasurements?.ToString();
            lblDatePaidValue.Text = _order?.DatePaid?.ToString();
            lblStatusValue.Text = _order?.Status?.ParseString();
            lblPriceValue.Text = _order?.Total?.ToString();
            lblPaidByCashValue.Text = _order?.PaidByCash == true ? Resources.Yes : Resources.No;


            FillServicesGrid();
            FillEmployeesGrid();
            FillWorkDatesGrid();
            FillLogsGrid();
        }

        private void FillServicesGrid()
        {
            _services = _order.GetServices();
            dgvServices.Rows.Clear();

            for (var i = 0; i < _services?.Count; i++)
            {
                dgvServices.Rows.AddRange(new DataGridViewRow());

                dgvServices.Rows[i].Cells[0].Value = dgvServices.Rows.Count;
                dgvServices.Rows[i].Cells[1].Value = _services[i].Manufacturer.Name;
                dgvServices.Rows[i].Cells[2].Value = _services[i].Ceiling.Name;
                dgvServices.Rows[i].Cells[3].Value = _services[i].Price;
            }
        }

        private void FillEmployeesGrid()
        {
            _employees = _order.GetEmployees();
            dgvEmployees.Rows.Clear();

            for (var i = 0; i < _employees?.Count; i++)
            {
                dgvEmployees.Rows.Add(new DataGridViewRow());

                dgvEmployees.Rows[i].Cells[0].Value = dgvEmployees.Rows.Count;
                dgvEmployees.Rows[i].Cells[1].Value = _employees[i].FullName;
            }
        }

        private void FillWorkDatesGrid()
        {
            _workDates = _order.GetWorkDates();
            dgvWorkDates.Rows.Clear();

            for (var i = 0; i < _workDates?.Count; i++)
            {
                dgvWorkDates.Rows.Add(new DataGridViewRow());

                dgvWorkDates.Rows[i].Cells[0].Value = dgvWorkDates.Rows.Count;
                dgvWorkDates.Rows[i].Cells[1].Value = _workDates[i].DateOfWork;
            }
        }

        private void FillLogsGrid()
        {
            _logs = _order.GetLogs();
            dgvLogs.Rows.Clear();

            for (var i = 0; i < _logs?.Count; i++)
            {
                dgvLogs.Rows.Add(new DataGridViewRow());

                dgvLogs.Rows[i].Cells[0].Value = dgvLogs.Rows.Count;
                dgvLogs.Rows[i].Cells[1].Value = _logs[i].DateCreated;
                dgvLogs.Rows[i].Cells[2].Value = _logs[i].Comment;
            }
        }

        private void SetupDataGrids()
        {
            SetupWorkDaysGrid();
            SetupServicesGrid();
            SetupEmployeesGrid();
            SetupLogsGrid();
        }

        private void SetupServicesGrid()
        {
            dgvServices.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvServices.CreateTextBoxColumn(Resources.Manufacturer, DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.CreateTextBoxColumn(Resources.Ceiling, DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.CreateTextBoxColumn(Resources.Price, DataGridViewAutoSizeColumnMode.DisplayedCells);
            FillServicesGrid();
        }

        private void SetupEmployeesGrid()
        {
            dgvEmployees.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEmployees.CreateTextBoxColumn(Resources.PersonName, DataGridViewAutoSizeColumnMode.Fill);
            FillEmployeesGrid();
        }

        private void SetupLogsGrid()
        {
            dgvLogs.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvLogs.CreateTextBoxColumn(Resources.DateCreated, DataGridViewAutoSizeColumnMode.Fill);
            dgvLogs.CreateTextBoxColumn(Resources.Action, DataGridViewAutoSizeColumnMode.Fill);
            FillLogsGrid();
        }

        private void SetupWorkDaysGrid()
        {
            dgvWorkDates.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvWorkDates.CreateTextBoxColumn(Resources.Date, DataGridViewAutoSizeColumnMode.Fill);
            FillWorkDatesGrid();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ShowService(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvServices.Rows[e.RowIndex].Cells[0].Value);
            var service = _services[index - 1];
            var form = new ServiceForm(service, FormState.ForView);
            form.ShowDialog();
        }

        private void ShowEmployee(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells[0].Value);
            var employee = _employees[index - 1];
            var form = new EmployeeForm(employee, FormState.ForView);
            form.ShowDialog();
        }

        private void ShowCustomer(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var customer = _order.Customer;
            var form = new CustomerForm(customer, FormState.ForView);
            form.ShowDialog();
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void ShowEditForm(object sender, EventArgs e)
        {
            this.Hide();

            var form = new OrderEditForm(_order);
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                _order = form.GetOrder();
                ReSetupForm();
            }

            this.Show();
        }
    }
}
