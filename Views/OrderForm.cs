using System.Drawing;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Models;
using StretchCeilings.Repositories;

namespace StretchCeilings.Views
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
            linkLblCustomer.ActiveLinkColor = DraculaColor.Pink;
            linkLblCustomer.VisitedLinkColor = DraculaColor.Purple;

            lblDatePlacedValue.Text = _currentOrder.DatePlaced?.ToString();
            lblDateOfMeasurementsValue.Text = _currentOrder?.DateOfMeasurements?.ToString();
            lblDatePaidValue.Text = _currentOrder?.DatePaid?.ToString();
            lblStatusValue.Text = _currentOrder?.Status?.ParseString();
            lblPriceValue.Text = _currentOrder?.Total?.ToString();

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
            dgvServices.AddDataGridViewButtonColumn(DraculaColor.Red);
            
            dgvServices.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvServices.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

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
            dgvEmployees.AddDataGridViewButtonColumn(DraculaColor.Red);

            dgvEmployees.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvEmployees.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

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
            dgvLogs.AddDataGridViewButtonColumn(DraculaColor.Red);

            dgvLogs.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvLogs.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

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
            dgvWorkDates.AddDataGridViewButtonColumn(DraculaColor.Red);
            
            dgvWorkDates.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvWorkDates.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;
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

        private void ShowEmployeeInfo(DataGridViewCellEventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count <= 0 || e.RowIndex < 0) return;
            new EmployeeForm(EmployeeModelsRepository.GetById((int)dgvEmployees.SelectedRows[0].Cells[0].Value)).ShowDialog();
        }

        private void ShowServiceInfo(DataGridViewCellEventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count <= 0 || e.RowIndex < 0) return;
            new ServiceForm(ServiceModelsRepository.GetById((int)dgvServices.SelectedRows[0].Cells[0].Value)).ShowDialog();
        }

        private void OrderForm_Load(object sender, System.EventArgs e)
        {
            SetUpForm();
            SetupEditButton();
        }

        private void btnEditOrder_Click(object sender, System.EventArgs e)
        {
            Hide();
            var orderFormEdit = new OrderEditForm(_currentOrder);
            orderFormEdit.FormClosed += (o, args) => Show();
            orderFormEdit.ShowDialog();
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEmployeeInfo(e);
        }

        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowServiceInfo(e);
        }

        private void linkLblCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowCustomerInfo();
        }
    }
}
