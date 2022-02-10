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

        private Order _order;
        private Order _firstFilter;
        private Order _secondFilter;
        
        private readonly FormState _state;

        private int _count;
        private int _rows;
        private int _currentPage = 1;
        private int _lastPage = 1;

        public OrdersForm(FormState state = FormState.Default)
        {
            _state = state;
            InitializeComponent();
        }

        public Order GetOrder() => _order;
        private static bool CanUserAdd() => UserSession.IsAdmin ||
                                            UserSession.Can(PermissionCode.AddOrder);
        private static bool CanUserDelete() => UserSession.IsAdmin ||
                                               UserSession.Can(PermissionCode.DelOrder);

        private void SetupForm()
        {
            _orders = OrderRepository.GetALl(out _rows);
            _firstFilter = new Order();
            _secondFilter = new Order();

            SetUpDataGrid();
            SetUpControls();
            FillDataGrid();
        }

        private void SetUpDataGrid()
        {
            dgvOrders.AddDataGridViewTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvOrders.AddDataGridViewTextBoxColumn("Дата размещения", DataGridViewAutoSizeColumnMode.Fill);
            dgvOrders.AddDataGridViewTextBoxColumn("Клиент", DataGridViewAutoSizeColumnMode.Fill);
            dgvOrders.AddDataGridViewTextBoxColumn("Статус", DataGridViewAutoSizeColumnMode.Fill);
            dgvOrders.AddDataGridViewCheckBoxColumn("Оплачен наличными", DataGridViewAutoSizeColumnMode.Fill);
            dgvOrders.AddDataGridViewTextBoxColumn("Стоимость", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvOrders.AddDataGridViewButtonColumn(DraculaColor.Red);

            if (CanUserDelete())
                dgvOrders.Columns[Resources.Space].Visible = false;

            dgvOrders.Font = GoogleFont.OpenSans;
            dgvOrders.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvOrders.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;
            dgvOrders.CellClick += RemoveGridRow;
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

            cbStatusValue.DisplayMember = Resources.DisplayMember;
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

            cbPaidByCash.DisplayMember = Resources.DisplayMember;
            cbPaidByCash.SelectedItem = null;
        }

        private void DrawAddOrderButton()
        {
            var btnAddOrder = new FlatButton("btnAddOrder", "Добавить", AddGridData);
            paneUserButtons.Controls.Add(btnAddOrder);
        }

        private void FillRowsComboBox()
        {
            foreach (var item in Resources.RowCountItems)
                cbRows.Items.Add(item);

            cbRows.SelectedIndex = 0;
            _count = Convert.ToInt32(cbRows.SelectedItem);
            cbRows.SelectedIndexChanged += RowCountChanged;
        }

        private void SetUpControls()
        {
            if (CanUserAdd())
                DrawAddOrderButton();
            
            btnResetFilters.FlatAppearance.MouseOverBackColor = DraculaColor.Red;

            nudTotalFrom.Maximum = decimal.MaxValue;
            nudTotalTo.Maximum = decimal.MaxValue;

            FillStatusComboBox();
            FillPaidByCashComboBox();
            FillRowsComboBox();
        }

        private void FillDataGrid()
        {
            dgvOrders.Rows.Clear();

            for (var i = 0; i < _orders?.Count; i++)
            {
                dgvOrders.Rows.Add(new DataGridViewRow());

                dgvOrders.Rows[i].Cells[0].Value = dgvOrders.Rows.Count;
                dgvOrders.Rows[i].Cells[1].Value = _orders[i].DatePlaced;
                dgvOrders.Rows[i].Cells[2].Value = _orders[i].Customer.FullName;
                dgvOrders.Rows[i].Cells[3].Value = _orders[i].Status?.ParseString();
                dgvOrders.Rows[i].Cells[4].Value = _orders[i].PaidByCash;
                dgvOrders.Rows[i].Cells[5].Value = _orders[i].Total;
            }

            UpdateLastPageValue();
            UpdatePageTextBox();
        }

        private void UpdateLastPageValue()
        {
            var result = Math.Ceiling(Convert.ToDouble(_rows) / _count);
            _lastPage = Convert.ToInt32(result);
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

        private void UpdatePageTextBox()
        {
            if (_lastPage == 0)
                _currentPage = 0;

            tbPage.UpdatePagesValue(_currentPage, _lastPage);
        }

        private void RemoveGridRow(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn == false ||
                e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells[Resources.Number].Value);
            var order = _orders[index - 1];
            order.Delete();

            FilterDataGrid();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void AddGridData(object sender, EventArgs e)
        {
            if (new OrderEditForm().ShowDialog() == DialogResult.OK)
                FilterDataGrid();
        }

        private void UseFilters(object sender, EventArgs e)
        {
            UpdateFilterValues();
            FilterDataGrid();
        }

        private void UpdateFilterValues()
        {
            foreach (ComboBoxItem item in cbStatusValue.Items)
                if (item == cbStatusValue.SelectedItem)
                    _firstFilter.Status = (OrderStatus)item.Tag;

            foreach (ComboBoxItem item in cbPaidByCash.Items)
                if (item == cbPaidByCash.SelectedItem)
                    _firstFilter.PaidByCash = Convert.ToBoolean(item.Tag);

            _firstFilter.Total = nudTotalFrom.Value;
            _secondFilter.Total = nudTotalTo.Value;
            _firstFilter.Id = Convert.ToInt32(nudIdValue.Value);
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            _firstFilter = new Order()
            {
                Status = OrderStatus.Unknown
            };
            _secondFilter = new Order();

            nudTotalFrom.Value = Resources.DefaultNumericUpDownValue;
            nudTotalTo.Value = Resources.DefaultNumericUpDownValue;
            nudIdValue.Value = Resources.DefaultNumericUpDownValue;

            dtpDateFromValue.CustomFormat = Resources.Space;
            dtpDateToValue.CustomFormat = Resources.Space;

            ibtnCustomer.IconChar = AwesomeIcon.Search;
            ibtnCustomer.Text = Resources.DefaultIconButtonText;
            ibtnEmployee.IconChar = AwesomeIcon.Search;
            ibtnEmployee.Text = Resources.DefaultIconButtonText;

            cbPaidByCash.SelectedItem = null;
            cbStatusValue.SelectedItem = null;

            FilterDataGrid();
        }

        private static void ChangeFormat(object sender, EventArgs e)
        {
            var dateTimePicker = (DateTimePicker)sender;
            dateTimePicker.Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day, 0, 0, 0);
            dateTimePicker.CustomFormat = Resources.FilterDateTimePickerCustomFormat;
        }

        private void ShowGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells[0].Value);
            var order = _orders[index - 1];
            var form = new OrderForm(order);
            form.ShowDialog();
        }

        private static void ChangeDatePlaced(Order filter, DateTimePicker dateTimePicker)
        {
            if (dateTimePicker.CustomFormat != Resources.Space)
                filter.DatePlaced = dateTimePicker.Value;
        }

        private void DatePlacedFromChanged(object sender, EventArgs e)
        {
            ChangeFormat(sender, e);
            ChangeDatePlaced(_firstFilter, dtpDateFromValue);
        }

        private void DatePlacedToChanged(object sender, EventArgs e)
        {
            ChangeFormat(sender, e);
            ChangeDatePlaced(_secondFilter, dtpDateToValue);
        }

        private void RowCountChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            _count = Convert.ToInt32(cbRows.SelectedItem);
            FilterDataGrid();
        }

        private void ShowPreviousPage(object sender, EventArgs e)
        {
            if (_currentPage <= 1)
                return;

            _currentPage--;
            FilterDataGrid();
        }

        private void ShowNextPage(object sender, EventArgs e)
        {
            if (_currentPage >= _lastPage)
                return;

            _currentPage++;
            FilterDataGrid();
        }

        private void SelectCustomer(object sender, EventArgs e)
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

        private void SelectEmployee(object sender, EventArgs e)
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
    }
}
