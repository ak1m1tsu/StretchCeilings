using System;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.Enums;
using stretch_ceilings_app.Utility.Extensions;

namespace stretch_ceilings_app.Forms
{
    public partial class OrderFormEdit : Form
    {
        private readonly Order _currentOrder;

        public OrderFormEdit(Order order)
        {
            _currentOrder = order;
            InitializeComponent();
        }

        public OrderFormEdit()
        {
            InitializeComponent();
        }
        private void SetUpForm()
        {
            linkLblCustomer.Text = _currentOrder?.Customer?.FullName;
            linkLblCustomer.ActiveLinkColor = Constants.DraculaPink;
            linkLblCustomer.VisitedLinkColor = Constants.DraculaPurple;

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
                if (item == _currentOrder?.Status.ParseString())
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
        private void SetUpServicesGrid()
        {
            var services = _currentOrder?.GetServices();

            var idCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            var manufacturerCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Производитель", DataGridViewAutoSizeColumnMode.Fill);
            var ceilingCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Потолок", DataGridViewAutoSizeColumnMode.Fill);
            var priceCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Цена", DataGridViewAutoSizeColumnMode.Fill);


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

        private void SetUpLogsGrid()
        {
            var logs = _currentOrder?.GetLogs();

            var idCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            var dateCreatedCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Дата создания", DataGridViewAutoSizeColumnMode.Fill);
            var commentCol = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("События", DataGridViewAutoSizeColumnMode.Fill);

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
            var days = _currentOrder?.GetWorkdays();

            var num = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            var date = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Дата", DataGridViewAutoSizeColumnMode.Fill);

            dgvWorkDates.Columns.AddRange(num, date);

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
