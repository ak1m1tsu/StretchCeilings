using System.Drawing;
using System.Windows.Forms;
using StretchCeilingsApp.Data.Models;
using StretchCeilingsApp.Utility;
using StretchCeilingsApp.Utility.Enums;
using StretchCeilingsApp.Utility.Extensions;
using StretchCeilingsApp.Utility.Extensions.Controls;
using StretchCeilingsApp.Utility.Repositories;

namespace StretchCeilingsApp.Forms
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
            if (UserSession.IsAdmin || UserSession.Can(PermissionCode.EditOrder))
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
            lblStatusValue.Text = _currentOrder.Status?.ParseString();
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

            dgvServices.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvServices.AddDataGridViewTextBoxColumn("Производитель", DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.AddDataGridViewTextBoxColumn("Потолок", DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.AddDataGridViewTextBoxColumn("Цена", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvServices.AddDataGridViewButtonColumn(Constants.DraculaRed);
            
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

            dgvEmployees.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEmployees.AddDataGridViewTextBoxColumn("Имя", DataGridViewAutoSizeColumnMode.Fill);
            dgvEmployees.AddDataGridViewButtonColumn(Constants.DraculaRed);

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

            dgvLogs.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvLogs.AddDataGridViewTextBoxColumn("Дата создания", DataGridViewAutoSizeColumnMode.Fill);
            dgvLogs.AddDataGridViewTextBoxColumn("Событие", DataGridViewAutoSizeColumnMode.Fill);
            dgvLogs.AddDataGridViewButtonColumn(Constants.DraculaRed);

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

            dgvWorkDates.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvWorkDates.AddDataGridViewTextBoxColumn("Дата", DataGridViewAutoSizeColumnMode.Fill);
            dgvWorkDates.AddDataGridViewButtonColumn(Constants.DraculaRed);
            
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
            new EmployeeForm(EmployeeModelsRepository.GetById((int)dgvEmployees.SelectedRows[0].Cells[0].Value)).ShowDialog();
        }

        private void ShowServiceInfo()
        {
            if (dgvEmployees.SelectedRows.Count <= 0) return;
            new ServiceForm(ServiceModelsRepository.GetById((int)dgvServices.SelectedRows[0].Cells[0].Value)).ShowDialog();
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
