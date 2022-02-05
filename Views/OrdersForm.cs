using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Forms;
using FontAwesome.Sharp;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Controls;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Helpers.Structs;
using StretchCeilings.Models;
using StretchCeilings.Repositories;

namespace StretchCeilings.Views
{
    public partial class OrdersForm : Form
    {
        private List<Order> _orders;
        
        private readonly FormState _state;
        private int _count;
        private int _rows;
        private int _currentPage = 1;
        private int _maxPage = 1;

        private Order _firstFilter;
        private Order _secondFilter;

        public OrdersForm(FormState state = FormState.Default)
        {
            _state = state;
            InitializeComponent();
        }

        private void SetUpDataGrid()
        {
            _orders = OrderRepository.GetALl(out _rows);

            dgvOrders.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvOrders.AddDataGridViewTextBoxColumn("Дата размещения", DataGridViewAutoSizeColumnMode.Fill);
            dgvOrders.AddDataGridViewTextBoxColumn("Клиент", DataGridViewAutoSizeColumnMode.Fill);
            dgvOrders.AddDataGridViewTextBoxColumn("Статус", DataGridViewAutoSizeColumnMode.Fill);
            dgvOrders.AddDataGridViewCheckBoxColumn("Оплачен наличными", DataGridViewAutoSizeColumnMode.Fill);
            dgvOrders.AddDataGridViewTextBoxColumn("Стоимость", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvOrders.AddDataGridViewButtonColumn(DraculaColor.Red);
            dgvOrders.Font = GoogleFont.OpenSans;
            dgvOrders.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvOrders.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;
            dgvOrders.CellClick += RemoveGridRow;

            FillDataGrid();
        }

        private void FillStatusComboBox()
        {
            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                if (status == OrderStatus.Unknown) continue;
                var item = new ComboBoxItem()
                {
                    Content = status.ParseString(),
                    Tag = status,
                };
                cbStatusValue.Items.Add(item);
            }
            cbStatusValue.DisplayMember = "Content";
            cbStatusValue.SelectedItem = null;
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

            cbPaidByCash.DisplayMember = "Content";
            cbPaidByCash.SelectedItem = null;
        }

        private static bool HasUserPermissions() 
            => UserSession.IsAdmin || UserSession.Can(PermissionCode.AddOrder);

        private void DrawAddOrderButton()
        {
            var btnAddOrder = new FlatButton("btnAddOrder", "Добавить", btnAddOrder_Click);
            paneUserButtons.Controls.Add(btnAddOrder);
        }

        private void FillRowsComboBox()
        {
            foreach (var item in Resources.RowCountItems)
                cbRows.Items.Add(item);
            cbRows.SelectedItem = cbRows.Items[0];
        }

        private void SetUpControls()
        {
            if (HasUserPermissions())
                DrawAddOrderButton();

            btnNextPage.Click += ShowNextPage;
            btnPreviousPage.Click += ShowPreviousPage;
            ibtnCustomer.Click += TakeCustomer;
            ibtnEmployee.Click += TakeEmployee;
            cbPaidByCash.SelectedIndexChanged += SetPaidByCashValue;
            cbStatusValue.SelectedIndexChanged += SetStatusValue;
            btnResetFilters.FlatAppearance.MouseOverBackColor = DraculaColor.Red;

            nudTotalFrom.Maximum = decimal.MaxValue;
            nudTotalTo.Maximum = decimal.MaxValue;

            FillStatusComboBox();
            FillPaidByCashComboBox();
            FillRowsComboBox();
            UpdatePageTextBox();
        }

        private void FillDataGrid()
        {
            dgvOrders.Rows.Clear();

            for (var i = 0; i < _orders?.Count; i++)
            {
                dgvOrders.Rows.Add(new DataGridViewRow());

                dgvOrders.Rows[i].Cells[0].Value = _orders[i].Id;
                dgvOrders.Rows[i].Cells[1].Value = _orders[i].DatePlaced;
                dgvOrders.Rows[i].Cells[2].Value = _orders[i].Customer.FullName;
                dgvOrders.Rows[i].Cells[3].Value = _orders[i].Status?.ParseString();
                dgvOrders.Rows[i].Cells[4].Value = _orders[i].PaidByCash;
                dgvOrders.Rows[i].Cells[5].Value = _orders[i].Total;
            }

            _maxPage = (int)Math.Ceiling((double)_rows / _count);
            UpdatePageTextBox();
        }

        private void FilterDataGrid()
        {
            _orders = OrderRepository.GetALl(
                _firstFilter,
                _secondFilter,
                _count,
                _currentPage,
                out _rows);

            FillDataGrid();
        }

        private void ResetDataGridFilters()
        {
            _firstFilter = new Order()
            {
                Status = OrderStatus.Unknown
            };
            _secondFilter = new Order();

            nudTotalFrom.Value = Resources.DefaultNumericUpDownValue;
            nudTotalTo.Value = Resources.DefaultNumericUpDownValue;
            nudIdValue.Value = Resources.DefaultNumericUpDownValue;

            dtpDateFromValue.CustomFormat = Resources.DefaultDateTimePickerCustomFormat;
            dtpDateToValue.CustomFormat = Resources.DefaultDateTimePickerCustomFormat;

            ibtnCustomer.IconChar = AwesomeIcon.Search;
            ibtnCustomer.Text = Resources.DefaultIconButtonText;
            ibtnEmployee.IconChar = AwesomeIcon.Search;
            ibtnEmployee.Text = Resources.DefaultIconButtonText;

            cbPaidByCash.SelectedItem = null;
            cbStatusValue.SelectedItem = null;

            FilterDataGrid();
        }
        
        private void OpenDataGridRowForm(DataGridViewCellEventArgs e)
        {
            if (dgvOrders.SelectedRows.Count <= 0 || e.RowIndex < 0) return;

            var order = OrderRepository.GetById((int)dgvOrders.SelectedRows[0].Cells[0].Value);
            new OrderForm(order).ShowDialog();
        }

        private void UpdatePageTextBox()
        {
            if (_maxPage == 0)
                _currentPage = 0;
            tbPage.UpdatePagesValue(_currentPage, _maxPage);
        }

        private void TakeEmployee(object sender, EventArgs e)
        {
            var employeesForm = new EmployeesForm();

            employeesForm.ShowDialog();

            if (employeesForm.DialogResult != DialogResult.OK) return;

            var employee = employeesForm.GetEmployee();
            ibtnEmployee.Tag = employee;
            ibtnEmployee.Text = employee?.FullName;
            ibtnEmployee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ibtnCustomer.IconChar = IconChar.None;
        }

        private void TakeCustomer(object sender, EventArgs e)
        {
            var customersForm = new CustomersForm();

            customersForm.ShowDialog();

            if (customersForm.DialogResult != DialogResult.OK) return;

            var customer = customersForm.GetCustomer();
            ibtnCustomer.Tag = customer;
            ibtnCustomer.Text = customer?.FullName;
            ibtnCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ibtnCustomer.IconChar = IconChar.None;
        }

        private void ShowNextPage(object sender, EventArgs e)
        {
            if (_currentPage >= _maxPage) return;

            _currentPage++;
            UpdatePageTextBox();
            FilterDataGrid();
        }

        private void ShowPreviousPage(object sender, EventArgs e)
        {
            if (_currentPage <= 1) return;

            _currentPage--;
            UpdatePageTextBox();
            FilterDataGrid();
        }

        private void RemoveGridRow(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvOrders.Columns[" "]?.Index) return;

            var order = OrderRepository.GetById((int)dgvOrders.SelectedRows[0].Cells["№"].Value);

            order.Delete();

            FilterDataGrid();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            _firstFilter = new Order() { Status = OrderStatus.Unknown };
            _secondFilter = new Order();

            SetUpDataGrid();
            SetUpControls();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (new OrderEditForm().ShowDialog() == DialogResult.OK) FilterDataGrid();
        }

        private void btnUseFilters_Click(object sender, EventArgs e)
        {
            FilterDataGrid();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            ResetDataGridFilters();
        }

        private static void ChangeFormat(object sender, EventArgs e)
        {
            var dateTimePicker = (DateTimePicker) sender;
            dateTimePicker.Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 0, 0, 0);
            dateTimePicker.CustomFormat = Resources.FilterDateTimePickerCustomFormat;
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDataGridRowForm(e);
        }

        private static void SetFilterDatePlacedValue(Order filter, DateTimePicker dateTimePicker)
        {
            if (dateTimePicker.CustomFormat != Resources.DefaultDateTimePickerCustomFormat)
                filter.DatePlaced = dateTimePicker.Value;
        }

        private void dtpDateFromValue_ValueChanged(object sender, EventArgs e)
        {
            ChangeFormat(sender, e);
            SetFilterDatePlacedValue(_firstFilter, dtpDateFromValue);
        }

        private void dtpDateToValue_ValueChanged(object sender, EventArgs e)
        {
            ChangeFormat(sender, e);
            SetFilterDatePlacedValue(_secondFilter, dtpDateToValue);
        }

        private void cbRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            _count = int.Parse(cbRows.Items[cbRows.SelectedIndex].ToString());
            FilterDataGrid();
        }

        private void SetStatusValue(object sender, EventArgs e)
        {
            foreach (ComboBoxItem item in cbStatusValue.Items)
            {
                if (item == cbStatusValue.SelectedItem) _firstFilter.Status = (OrderStatus)item.Tag;
            }
        }

        private static void SetFilterTotalValue(Order filter, decimal value)
        {
            filter.Total = value;
        }

        private void nudTotalTo_ValueChanged(object sender, EventArgs e)
        {
            SetFilterTotalValue(_secondFilter, nudTotalTo.Value);
        }

        private void nudTotalFrom_ValueChanged(object sender, EventArgs e)
        {
            SetFilterTotalValue(_firstFilter, nudTotalFrom.Value);
        }

        private void nudIdValue_ValueChanged(object sender, EventArgs e)
        {
            if (nudIdValue.Value != 0) _firstFilter.Id = (int)nudIdValue.Value;
        }

        private void SetPaidByCashValue(object sender, EventArgs e)
        {
            foreach (ComboBoxItem item in cbPaidByCash.Items)
            {
                if (item == cbPaidByCash.SelectedItem) _firstFilter.PaidByCash = (bool)item.Tag;
            }
        }
    }
}
