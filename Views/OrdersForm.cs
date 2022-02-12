using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Extensions;
using StretchCeilings.Extensions.Controls;
using StretchCeilings.Models;
using StretchCeilings.Models.Enums;
using StretchCeilings.Repositories;
using StretchCeilings.Sessions;
using StretchCeilings.Structs;
using StretchCeilings.Views.Controls;

namespace StretchCeilings.Views
{
    public partial class OrdersForm : Form
    {
        private List<Order> _orders;
        
        private Order _firstFilter;
        private Order _secondFilter;
        private Employee _employee;
        private Customer _customer;
        
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

        private static bool CanUserAdd => UserSession.IsAdmin ||
                                          UserSession.Can(PermissionCode.AddOrder);
        private static bool CanUserDelete => UserSession.IsAdmin ||
                                             UserSession.Can(PermissionCode.DelOrder);

        private bool IsForView => _state == FormState.ForView;
        
        private void SetupForm()
        {
            _orders = OrderRepository.GetALl(out _rows);
            _firstFilter = new Order();
            _secondFilter = new Order();

            SetupDataGrid();
            SetupControls();
            FillDataGrid();
        }

        private void SetupDataGrid()
        {
            dgvOrders.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvOrders.CreateTextBoxColumn("Дата размещения", DataGridViewAutoSizeColumnMode.Fill);
            dgvOrders.CreateTextBoxColumn("Клиент", DataGridViewAutoSizeColumnMode.Fill);
            dgvOrders.CreateTextBoxColumn("Статус", DataGridViewAutoSizeColumnMode.Fill);
            dgvOrders.CreateCheckBoxColumn("Оплачен наличными", DataGridViewAutoSizeColumnMode.Fill);
            dgvOrders.CreateTextBoxColumn("Стоимость", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvOrders.CreateButtonColumn();

            dgvOrders.Font = GoogleFont.OpenSans;
            dgvOrders.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvOrders.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;
            dgvOrders.CellClick += RemoveGridRow;
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

        private void SetupControls()
        {
            btnResetFilters.FlatAppearance.MouseOverBackColor = DraculaColor.Red;

            nudTotalFrom.Maximum = decimal.MaxValue;
            nudTotalTo.Maximum = decimal.MaxValue;

            FillStatusComboBox();
            FillPaidByCashComboBox();
            FillRowsComboBox();

            if (CanUserAdd && IsForView == false)
                DrawAddOrderButton();

            if (CanUserDelete == false || IsForView)
                dgvOrders.Columns[Resources.Space].Visible = false;
        }

        private void FillDataGrid()
        {
            dgvOrders.Rows.Clear();

            for (var i = 0; i < _orders?.Count; i++)
            {
                dgvOrders.Rows.Add(new DataGridViewRow());

                dgvOrders.Rows[i].Cells[0].Value = dgvOrders.Rows.Count;
                dgvOrders.Rows[i].Cells[1].Value = _orders[i].DatePlaced;
                dgvOrders.Rows[i].Cells[2].Value = _orders[i].Customer?.FullName;
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
                _customer,
                _employee,
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

            if (FlatMessageBox.ShowDialog("Вы уверены что хотите удалить заказ?", Caption.Warning) != DialogResult.OK)
                return;

            var index = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells[Resources.Number].Value);
            var order = _orders[index - 1];
            order.Delete();

            FilterDataGrid();
            FlatMessageBox.ShowDialog("Заказ успешно удален", Caption.Info);
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void AddGridData(object sender, EventArgs e)
        {
            var form = new OrderEditForm();

            if (form.ShowDialog() != DialogResult.OK)
                return;

            FilterDataGrid();
            FlatMessageBox.ShowDialog("Заказ успешно добавлен", Caption.Info);
        }

        private void UseFilters(object sender, EventArgs e)
        {
            UpdateFilterValues();
            FilterDataGrid();
        }

        private bool AreFilterControlsFilledCorrect()
        {
            if (nudTotalFrom.Value > nudTotalTo.Value)
            {
                FlatMessageBox.ShowDialog("Неверно указан диапозон цен", Caption.Error);
                return false;
            }

            var dateFrom = dtpDateFrom.Value.Date;
            var dateTo = dtpDateTo.Value.Date;
            var dateFromTime = new TimeSpan(dateFrom.Day, dateFrom.Hour, dateFrom.Minute);
            var dateToTime = new TimeSpan(dateTo.Day, dateTo.Hour, dateTo.Minute);

            if (dateFrom <= dateTo || dateFromTime <= dateToTime)
                return true;

            FlatMessageBox.ShowDialog("Неверно указан диапозон дат", Caption.Error);
            return false;

        }

        private void UpdateFilterValues()
        {
            if (AreFilterControlsFilledCorrect() == false)
                return;

            foreach (ComboBoxItem item in cbStatusValue.Items)
                if (item == cbStatusValue.SelectedItem)
                    _firstFilter.Status = (OrderStatus)item.Tag;

            foreach (ComboBoxItem item in cbPaidByCash.Items)
                if (item == cbPaidByCash.SelectedItem)
                    _firstFilter.PaidByCash = Convert.ToBoolean(item.Tag);

            if (nudTotalFrom.Value > 0)
                _firstFilter.Total = nudTotalFrom.Value;
            if (nudTotalTo.Value > 0)
                _secondFilter.Total = nudTotalTo.Value;

            if (dtpDateFrom.CustomFormat != Resources.Space)
                _firstFilter.DatePlaced = dtpDateFrom.Value;

            if (dtpDateTo.CustomFormat != Resources.Space)
                _secondFilter.DatePlaced = dtpDateTo.Value;

            _firstFilter.Id = Convert.ToInt32(nudId.Value);
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            _firstFilter = new Order()
            {
                Status = OrderStatus.Unknown
            };
            _secondFilter = new Order();
            _employee = null;
            _customer = null;

            nudTotalFrom.Value = Resources.DefaultNumericUpDownValue;
            nudTotalTo.Value = Resources.DefaultNumericUpDownValue;
            nudId.Value = Resources.DefaultNumericUpDownValue;

            dtpDateFrom.CustomFormat = Resources.Space;
            dtpDateTo.CustomFormat = Resources.Space;

            cbPaidByCash.SelectedItem = null;
            cbStatusValue.SelectedItem = null;

            linkCustomer.Text = Resources.No;
            linkEmployee.Text = Resources.No;

            FilterDataGrid();

            FlatMessageBox.ShowDialog("Значение фильтров сброшено до стандартных", Caption.Info);
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

        private void DatePlacedFromChanged(object sender, EventArgs e)
        {
            ChangeFormat(sender, e);
        }

        private void DatePlacedToChanged(object sender, EventArgs e)
        {
            ChangeFormat(sender, e);
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

        private void SelectCustomer(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new CustomersForm(FormState.ForView);
            
            if (form.ShowDialog() != DialogResult.OK)
                return;

            var customer = form.GetCustomer();

            if (customer == null)
                return;

            _customer = customer;
            linkCustomer.Text = customer.FullName;
        }

        private void SelectEmployee(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new EmployeesForm(FormState.ForView);
            
            if (form.ShowDialog() != DialogResult.OK)
                return;

            var employee = form.GetEmployee();

            if (employee == null)
                return;

            _employee = employee;
            linkEmployee.Text = employee.FullName;
        }
    }
}
