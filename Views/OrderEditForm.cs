using System;
using System.Windows.Controls;
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
        private readonly Order _order;

        public OrderEditForm(Order order)
        {
            _order = order;
            InitializeComponent();
        }

        public OrderEditForm()
        {
            InitializeComponent();
        }

        public Order GetOrder() => _order;

        private void SetUpForm()
        {
            linkLblCustomer.Text = _order?.Customer?.FullName;
            linkLblCustomer.ActiveLinkColor = DraculaColor.Pink;
            linkLblCustomer.VisitedLinkColor = DraculaColor.Purple;

            lblPriceValue.Text = _order?.Total.ToString();

            dtpDatePlaced.Text = _order?.DatePlaced?.ToString();
            dtpDateOfMeasurements.Text = _order?.DateOfMeasurements?.ToString();
            dtpDatePaid.Text = _order?.DatePaid?.ToString();

            FillStatusComboBox();
            FillPaidByCashComboBox();

            SetUpWorkDaysGrid();
            SetUpServicesGrid();
            SetUpEmployeesGrid();
            SetUpLogsGrid();
        }

        private void FillStatusComboBox()
        {
            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                if (status == OrderStatus.Unknown)
                    continue;

                var item = new ComboBoxItem()
                {
                    Content = status.ParseString(),
                    Tag = status,
                };

                cbStatus.Items.Add(item);
            }

            cbStatus.DisplayMember = Resources.DisplayMember;
            cbStatus.SelectedItem = null;

            foreach (ComboBoxItem item in cbStatus.Items)
            {
                if((OrderStatus)item.Tag == _order?.Status)
                    cbStatus.SelectedItem = item;
            }
        }

        private void FillPaidByCashComboBox()
        {
            foreach (var paidByCashItem in Resources.PaidByCashItems)
            {
                var item = new ComboBoxItem()
                {
                    Content = paidByCashItem.Key,
                    Tag = paidByCashItem.Value,
                };

                cbPaidByCash.Items.Add(item);
            }

            cbPaidByCash.DisplayMember = Resources.DisplayMember;
            cbPaidByCash.SelectedItem = cbPaidByCash.Items[0];
        }

        private void SetUpEmployeesGrid()
        {
            var employees = _order?.GetEmployees();
            
            dgvEmployees.AddDataGridViewTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEmployees.AddDataGridViewTextBoxColumn(Resources.PersonName, DataGridViewAutoSizeColumnMode.Fill);
            dgvEmployees.AddDataGridViewTextBoxColumn(Resources.PhoneNumber, DataGridViewAutoSizeColumnMode.Fill);

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
            var services = _order?.GetServices();

            dgvServices.AddDataGridViewTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvServices.AddDataGridViewTextBoxColumn(Resources.Manufacturer, DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.AddDataGridViewTextBoxColumn(Resources.Ceiling, DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.AddDataGridViewTextBoxColumn(Resources.Price, DataGridViewAutoSizeColumnMode.Fill);

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
            var logs = _order?.GetLogs();

            dgvLogs.AddDataGridViewTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvLogs.AddDataGridViewTextBoxColumn(Resources.DateCreated, DataGridViewAutoSizeColumnMode.Fill);
            dgvLogs.AddDataGridViewTextBoxColumn(Resources.Action, DataGridViewAutoSizeColumnMode.Fill);
            
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
            var days = _order?.GetWorkDates();

            dgvWorkDates.AddDataGridViewTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvWorkDates.AddDataGridViewTextBoxColumn(Resources.Date, DataGridViewAutoSizeColumnMode.Fill);
            
            for (var i = 0; i < days?.Count; i++)
            {
                dgvWorkDates.Rows.Add(new DataGridViewRow());

                dgvWorkDates.Rows[i].Cells[0].Value = i + 1;
                dgvWorkDates.Rows[i].Cells[1].Value = days[i];
            }
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetUpForm();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            this.Handle.DragMove(e);
        }
    }
}
