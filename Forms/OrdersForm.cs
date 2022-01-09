using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.CustomControls;
using stretch_ceilings_app.Utility.Enums;
using stretch_ceilings_app.Utility.Extensions;
using stretch_ceilings_app.Utility.Repositories;

namespace stretch_ceilings_app.Forms
{
    public partial class OrdersForm : Form
    {
        private List<Order> _orders;
        private readonly string _defaultDateTimePickerCustomFormat = string.Empty;
        private int _rowsCount;
        private int _currentPage = 1;
        private int _maxPage;

        private const string _defaultLinkLblText = "🔍";
        private const string _filterDateTimePickerCustomFormat = @"dd.MM.yyyy HH:mm";
        private const int _defaultNumericUpDownValue = 0;

        public OrdersForm()
        {
            InitializeComponent();
        }

        private void CheckUserPermissions()
        {
            if (UserSession.Can(PermissionCode.AddAdditionalService))
            {
                DrawAddServiceButton();
            }
        }

        private void OpenDataGridRowForm()
        {
            if (dgvOrders.SelectedRows.Count <= 0) return;

            var order = OrderRepository.GetById((int) dgvOrders.SelectedRows[0].Cells[0].Value);

            if (new OrderForm(order).ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void SetUpDataGridView()
        {
            _orders = OrderRepository.GetOrders(out _rowsCount);

            var idColumn = new DataGridViewTextBoxColumn() { Name = "Id", AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells };
            var datePlacedColumn = new DataGridViewTextBoxColumn() { Name = "Дата размещения", AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells};
            var customerColumn = new DataGridViewTextBoxColumn() { Name = "Клиент", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill };
            var statusColumn = new DataGridViewTextBoxColumn() { Name = "Статус", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill };
            var paidByCashColumn = new DataGridViewCheckBoxColumn() { Name = "Оплачен наличными", AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells };
            var totalColumn = new DataGridViewTextBoxColumn() { Name = "Стоимость", AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells };

            dgvOrders.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
            dgvOrders.Columns.AddRange(idColumn, datePlacedColumn, customerColumn, statusColumn, paidByCashColumn,
                totalColumn);

            for (var i = 0; i < _rowsCount; i++)
            {
                dgvOrders.Rows.Add(new DataGridViewRow());

                dgvOrders.Rows[i].Cells[0].Value = _orders[i].Id;
                dgvOrders.Rows[i].Cells[1].Value = _orders[i].DatePlaced;
                dgvOrders.Rows[i].Cells[2].Value = _orders[i].Customer.FullName;
                dgvOrders.Rows[i].Cells[3].Value = _orders[i].Status.ParseString();
                dgvOrders.Rows[i].Cells[4].Value = _orders[i].PaidByCash;
                dgvOrders.Rows[i].Cells[5].Value = _orders[i].Total;
            }

            _maxPage = (int)Math.Ceiling((double)_rowsCount / int.Parse(cbRows.SelectedItem.ToString()));
        }

        private void SetUpFilterControls()
        {
            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
                cbStatusValue.Items.Add(status.ParseString());
            cbStatusValue.SelectedItem = null;

            dtpDateFromValue.ValueChanged += DtpToValueChanged;
            dtpDateToValue.ValueChanged += DtpToValueChanged;
            
            cbRows.Items.AddRange(new string[4] {"5", "10", "15", "20"} );
            cbRows.SelectedItem = cbRows.Items[0];

            tbPage.Text = "1 / 1";
        }

        private void FilterDataGrid()
        {

        }

        private void ResetDataGridFilters()
        {
            dtpDateFromValue.CustomFormat = _defaultDateTimePickerCustomFormat;
            dtpDateToValue.CustomFormat = _defaultDateTimePickerCustomFormat;
            nudIdValue.Value = _defaultNumericUpDownValue;
            linkLblCustomerValue.Text = _defaultLinkLblText;
            linkLblEmployeeValue.Text = _defaultLinkLblText;
        }

        private void DrawAddServiceButton()
        {
            var btnAddOrder = new FlatButton("btnAddOrder", "Добавить");
            btnAddOrder.Click += btnAddOrder_Click;
            paneUserButtons.Controls.Add(btnAddOrder);
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            CheckUserPermissions();
            SetUpFilterControls();
            SetUpDataGridView();
        }

        private static void btnAddOrder_Click(object sender, EventArgs e)
        {
            new OrderFormEdit().ShowDialog();
        }

        private void btnUseFilters_Click(object sender, EventArgs e)
        {

        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            ResetDataGridFilters();
        }

        private static void DtpToValueChanged(object sender, EventArgs e)
        {
            var dateTimePicker = (DateTimePicker) sender;
            dateTimePicker.Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month,
                dateTimePicker.Value.Day, 0, 0, 0);
            dateTimePicker.CustomFormat = _filterDateTimePickerCustomFormat;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDataGridRowForm();
        }

        private void linkLblEmployeeValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new EmployeesForm().ShowDialog();
        }

        private void linkLblCustomerValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CustomersForm().ShowDialog();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage < _maxPage)
            {
                _currentPage++;
                tbPage.Text = $"{_currentPage} / {_maxPage}";
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                tbPage.Text = $"{_currentPage} / {_maxPage}";
            }
        }
    }
}
