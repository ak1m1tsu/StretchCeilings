using System;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility.Enums;
using stretch_ceilings_app.Utility.Extensions;
using DataGridViewTextBoxColumn = System.Windows.Forms.DataGridViewTextBoxColumn;

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

            lblPriceValue.Text = _currentOrder?.Total.ToString();

            SetUpWorkDaysGrid();
            SetUpServicesGrid();
            SetUpLogsGrid();
        }

        private void SetUpServicesGrid()
        {
            var services = _currentOrder?.GetServices();

            var idCol = new DataGridViewTextBoxColumn()
                { Name = "Id", AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells };
            var manufacturerCol = new DataGridViewTextBoxColumn()
                { Name = "Производитель", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill };
            var ceilingCol = new DataGridViewTextBoxColumn()
                { Name = "Потолок", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill };
            var priceCol = new DataGridViewTextBoxColumn()
                { Name = "Цена", AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells };

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

            var idCol = new DataGridViewTextBoxColumn()
                { Name = "Id", AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells };
            var commentCol = new DataGridViewTextBoxColumn()
                { Name = "Событие", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill };
            var dateCreatedCol = new DataGridViewTextBoxColumn()
                { Name = "Дата создания", AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells };

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
            var num = new DataGridViewTextBoxColumn()
                { Name = "№", AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells };
            var date = new DataGridViewTextBoxColumn() { Name = "Дата", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill };

            dgvWorkDates.Columns.AddRange(num, date);

            for (var i = 0; i < _currentOrder?.DateOfWork?.Count; i++)
            {
                dgvWorkDates.Rows[i].Cells[0].Value = i;
                dgvWorkDates.Rows[i].Cells[1].Value = _currentOrder.DateOfWork;
            }
        }

        private void OrderFormEdit_Load(object sender, EventArgs e)
        {
            SetUpForm();
        }
    }
}
