using System;
using System.Windows.Forms;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Helpers.Structs;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class OrderEditForm : Form
    {
        private readonly Order _currentOrder;

        public OrderEditForm(Order order)
        {
            _currentOrder = order;
            InitializeComponent();
        }

        public OrderEditForm()
        {
            InitializeComponent();
        }
        private void SetUpForm()
        {
            linkLblCustomer.Text = _currentOrder?.Customer?.FullName;
            linkLblCustomer.ActiveLinkColor = DraculaColor.Pink;
            linkLblCustomer.VisitedLinkColor = DraculaColor.Purple;

            lblPriceValue.Text = _currentOrder?.Total.ToString();

            dtpDatePlaced.Text = _currentOrder?.DatePlaced?.ToString();
            dtpDateOfMeasurements.Text = _currentOrder?.DateOfMeasurements?.ToString();
            dtpDatePaid.Text = _currentOrder?.DatePaid?.ToString();

            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                if (status == OrderStatus.Unknown)
                    continue;
                cbStatusValue.Items.Add(status.ParseString());
            }

            foreach (string item in cbStatusValue.Items)
            {
                if (item == _currentOrder?.Status?.ParseString())
                    cbStatusValue.SelectedItem = item;
            }

            if (_currentOrder?.PaidByCash == true)
            {
                cbPaidByCash.CheckState = CheckState.Checked;
            }

            SetUpWorkDaysGrid();
            SetUpServicesGrid();
            SetUpEmployeesGrid();
            SetUpLogsGrid();
        }
        private void SetUpEmployeesGrid()
        {
            var employees = _currentOrder?.GetEmployees();
            
            dgvEmployees.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEmployees.AddDataGridViewTextBoxColumn("Имя", DataGridViewAutoSizeColumnMode.Fill);
            dgvEmployees.AddDataGridViewTextBoxColumn("Номер телефона", DataGridViewAutoSizeColumnMode.Fill);

            for (var i = 0; i < employees?.Count; i++)
            {
                dgvEmployees.Rows.Add(new DataGridViewRow());

                dgvEmployees.Rows[i].Cells[0].Value = employees[i].Id;
                dgvEmployees.Rows[i].Cells[1].Value = employees[i].FullName;
                dgvEmployees.Rows[i].Cells[2].Value = employees[i].Login;
            }
        }
        private void SetUpServicesGrid()
        {
            var services = _currentOrder?.GetServices();

            dgvServices.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvServices.AddDataGridViewTextBoxColumn("Производитель", DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.AddDataGridViewTextBoxColumn("Потолок", DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.AddDataGridViewTextBoxColumn("Цена", DataGridViewAutoSizeColumnMode.Fill);

            for (var i = 0; i < services?.Count; i++)
            {
                dgvServices.Rows.AddRange(new DataGridViewRow());

                dgvServices.Rows[i].Cells[0].Value = services[i].Id;
                dgvServices.Rows[i].Cells[1].Value = services[i].Manufacturer.Name;
                dgvServices.Rows[i].Cells[2].Value = services[i].Ceiling.Name;
                dgvServices.Rows[i].Cells[3].Value = services[i].Price;
            }
        }

        private void SetUpLogsGrid()
        {
            var logs = _currentOrder?.GetLogs();

            dgvLogs.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvLogs.AddDataGridViewTextBoxColumn("Дата создания", DataGridViewAutoSizeColumnMode.Fill);
            dgvLogs.AddDataGridViewTextBoxColumn("События", DataGridViewAutoSizeColumnMode.Fill);
            
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
            var days = _currentOrder?.GetWorkdays();

            dgvWorkDates.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvWorkDates.AddDataGridViewTextBoxColumn("Дата", DataGridViewAutoSizeColumnMode.Fill);
            
            for (var i = 0; i < days?.Count; i++)
            {
                dgvWorkDates.Rows.Add(new DataGridViewRow());

                dgvWorkDates.Rows[i].Cells[0].Value = i + 1;
                dgvWorkDates.Rows[i].Cells[1].Value = days[i];
            }
        }

        private void OrderFormEdit_Load(object sender, EventArgs e)
        {
            SetUpForm();
        }
    }
}
