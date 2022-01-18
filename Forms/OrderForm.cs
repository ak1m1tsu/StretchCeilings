using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.Enums;
using stretch_ceilings_app.Utility.Extensions;
using stretch_ceilings_app.Utility.Repositories;

namespace stretch_ceilings_app.Forms
{
    public partial class OrderForm : Form
    {
        private readonly Order _currentOrder;

        public OrderForm(Order order)
        {
            _currentOrder = order;
            InitializeComponent();
        }

        private void SetupEditButton()
        {
            btnEditOrder.Visible = CanUserEdit();
        }

        private void SetUpForm()
        {
            linkLblCustomer.Text = _currentOrder.Customer.FullName;

            lblDatePlacedValue.Text = _currentOrder.DatePlaced?.ToString();
            lblDateOfMeasurementsValue.Text = _currentOrder.DateOfMeasurements?.ToString();
            lblDatePaidValue.Text = _currentOrder.DatePaid?.ToString();
            lblStatusValue.Text = _currentOrder.Status.ParseString();
            
            if (_currentOrder.PaidByCash == true)
            {
                cbPaidByCash.CheckState = CheckState.Checked;
            }

            lblPriceValue.Text = _currentOrder.Total.ToString();
            
            SetUpWorkDaysGrid();
            SetUpServicesGrid();
            SetUpEmployeesGrid();
            SetUpLogsGrid();
        }

        private void SetUpServicesGrid()
        {
            var services = _currentOrder.GetServices();

            var idCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            var manufacturerCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Производитель", DataGridViewAutoSizeColumnMode.Fill);
            var ceilingCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Потолок", DataGridViewAutoSizeColumnMode.Fill);
            var priceCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Цена", DataGridViewAutoSizeColumnMode.DisplayedCells);

            dgvServices.Columns.AddRange(idCol, manufacturerCol, ceilingCol, priceCol);

            for (var i = 0; i < services?.Count; i++)
            {
                dgvServices.Rows.AddRange(new DataGridViewRow());

                dgvServices.Rows[i].Cells[0].Value = services[i].Id;
                dgvServices.Rows[i].Cells[1].Value = services[i].Manufacturer.Name;
                dgvServices.Rows[i].Cells[2].Value = services[i].Ceiling.Name;
                dgvServices.Rows[i].Cells[3].Value = services[i].Price;
            }
        }

        private void SetUpEmployeesGrid()
        {
            var employees = _currentOrder.GetEmployees();

            var idCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            var nameCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Имя", DataGridViewAutoSizeColumnMode.Fill);

            dgvEmployees.Columns.AddRange(idCol, nameCol);

            for (var i = 0; i < employees?.Count; i++)
            {
                dgvEmployees.Rows.Add(new DataGridViewRow());

                dgvEmployees.Rows[i].Cells[0].Value = employees[i].Id;
                dgvEmployees.Rows[i].Cells[1].Value = employees[i].FullName;
            }
        }

        private void SetUpLogsGrid()
        {
            var logs = _currentOrder.GetLogs();

            var idCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            var commentCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Событие", DataGridViewAutoSizeColumnMode.Fill);
            var dateCreatedCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Дата создания", DataGridViewAutoSizeColumnMode.DisplayedCells);

            dgvLogs.Columns.AddRange(idCol, dateCreatedCol, commentCol);

            for (var i = 0; i < logs?.Count; i++)
            {
                dgvLogs.Rows.Add(new DataGridViewRow());

                dgvLogs.Rows[i].Cells[0].Value = logs[i].Id;
                dgvLogs.Rows[i].Cells[1].Value = logs[i].DateCreated;
                dgvLogs.Rows[i].Cells[2].Value = logs[i].Comment;
            }
        }

        private void SetUpWorkDaysGrid()
        {
            var num = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            var date = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Дата", DataGridViewAutoSizeColumnMode.Fill);

            dgvWorkDates.Columns.AddRange(num, date);

            for (var i = 0; i < _currentOrder.DateOfWork?.Count; i++)
            {
                dgvWorkDates.Rows[i].Cells[0].Value = i;
                dgvWorkDates.Rows[i].Cells[1].Value = _currentOrder.DateOfWork;
            }
        }

        private void OpenEmployeeForm()
        {
            if (dgvEmployees.SelectedRows.Count <= 0) return;

            var employee = EmployeeRepository.GetById((int)dgvEmployees.SelectedRows[0].Cells[0].Value);
            new EmployeeForm(employee).ShowDialog();
        }

        private void ShowCustomerInfo()
        {
            new CustomerForm(_currentOrder.Customer).ShowDialog();
        }

        private static bool CanUserEdit()
        {
            return UserSession.Can(PermissionCode.EditOrder);
        }

        private void OrderForm_Load(object sender, System.EventArgs e)
        {
            SetUpForm();
            SetupEditButton();
        }

        private void btnEditOrder_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var orderFormEdit = new OrderFormEdit(_currentOrder);
            orderFormEdit.FormClosed += (o, args) => this.Show();
            orderFormEdit.ShowDialog();
        }

        private void linkLblCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowCustomerInfo();
        }
    }
}
