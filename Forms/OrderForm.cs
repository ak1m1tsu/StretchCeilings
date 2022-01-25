using System.Drawing;
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
            if (UserSession.IsAdmin() || UserSession.Can(PermissionCode.EditOrder))
                btnEditOrder.Visible = true;
        }

        private void SetUpForm()
        {
            linkLblCustomer.Text = _currentOrder.Customer?.FullName;
            linkLblCustomer.ActiveLinkColor = Constants.DraculaPink;
            linkLblCustomer.VisitedLinkColor = Constants.DraculaPurple;

            lblDatePlacedValue.Text = _currentOrder.DatePlaced?.ToString();
            lblDateOfMeasurementsValue.Text = _currentOrder.DateOfMeasurements?.ToString();
            lblDatePaidValue.Text = _currentOrder.DatePaid?.ToString();
            lblStatusValue.Text = _currentOrder.Status.ParseString();
            lblPriceValue.Text = _currentOrder.Total?.ToString();

            if (_currentOrder.PaidByCash == true)
            {
                cbPaidByCash.CheckState = CheckState.Checked;
            }

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
            var delColumn = DataGridViewExtensions.CreateDataGridViewButtonColumn(Constants.DraculaRed);

            dgvServices.Columns.AddRange(idCol, manufacturerCol, ceilingCol, priceCol, delColumn);
            dgvServices.DefaultCellStyle.SelectionBackColor = Constants.DraculaSelection;
            dgvServices.DefaultCellStyle.SelectionForeColor = Constants.DraculaForeground;

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
            var delColumn = DataGridViewExtensions.CreateDataGridViewButtonColumn(Constants.DraculaRed);

            dgvEmployees.Columns.AddRange(idCol, nameCol, delColumn);
            dgvEmployees.DefaultCellStyle.SelectionBackColor = Constants.DraculaSelection;
            dgvEmployees.DefaultCellStyle.SelectionForeColor = Constants.DraculaForeground;

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
            var dateCreatedCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Дата создания", DataGridViewAutoSizeColumnMode.Fill);
            var commentCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Событие", DataGridViewAutoSizeColumnMode.Fill);
            var delColumn = DataGridViewExtensions.CreateDataGridViewButtonColumn(Constants.DraculaRed);

            dgvLogs.Columns.AddRange(idCol, dateCreatedCol, commentCol, delColumn);
            dgvLogs.DefaultCellStyle.SelectionBackColor = Constants.DraculaSelection;
            dgvLogs.DefaultCellStyle.SelectionForeColor = Constants.DraculaForeground;

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
            var workdays = _currentOrder.GetWorkdays();

            var num = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            var date = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Дата", DataGridViewAutoSizeColumnMode.Fill);
            var delColumn = DataGridViewExtensions.CreateDataGridViewButtonColumn(Constants.DraculaRed);

            dgvWorkDates.Columns.AddRange(num, date, delColumn);
            dgvWorkDates.DefaultCellStyle.SelectionBackColor = Constants.DraculaSelection;
            dgvWorkDates.DefaultCellStyle.SelectionForeColor = Constants.DraculaForeground;
            dgvWorkDates.DefaultCellStyle.ForeColor = Color.Black;

            for (var i = 0; i < workdays?.Count; i++)
            {
                dgvWorkDates.Rows.Add(new DataGridViewRow());

                dgvWorkDates.Rows[i].Cells[0].Value = i + 1;
                dgvWorkDates.Rows[i].Cells[1].Value = workdays[i];
            }
        }

        private void ShowCustomerInfo()
        {
            new CustomerForm(_currentOrder.Customer).ShowDialog();
        }

        private void ShowEmployeeInfo()
        {
            if (dgvEmployees.SelectedRows.Count <= 0) return;
            new EmployeeForm(EmployeeRepository.GetById((int)dgvEmployees.SelectedRows[0].Cells[0].Value)).ShowDialog();
        }

        private void ShowServiceInfo()
        {
            if (dgvEmployees.SelectedRows.Count <= 0) return;
            new ServiceForm(ServiceRepository.GetById((int)dgvServices.SelectedRows[0].Cells[0].Value)).ShowDialog();
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

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEmployeeInfo();
        }

        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowServiceInfo();
        }

        private void linkLblCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowCustomerInfo();
        }
    }
}
