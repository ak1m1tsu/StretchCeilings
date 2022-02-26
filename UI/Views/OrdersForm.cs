using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using FontAwesome.Sharp;
using StretchCeilings.App.Services;
using StretchCeilings.DataAccess.Repositories;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Extensions;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Models.Enums;
using StretchCeilings.Domain.Repositories;
using StretchCeilings.UI.Extensions;
using StretchCeilings.UI.Structs;
using StretchCeilings.UI.Views.Controls;
using StretchCeilings.UI.Views.Enums;

namespace StretchCeilings.UI.Views
{
    /// <inheritdoc />
    public partial class OrdersForm : Form
    {
        private readonly IOrderRepository _repository;
        private List<Order> _orders;
        
        private Order _firstFilter;
        private Order _secondFilter;
        private Employee _employee;
        private Customer _customer;
        
        private readonly FormState _state;
        private SortOption _sortOption;
        private OrderProperty _property;

        private int _count;
        private int _rows;
        private int _currentPage = 1;
        private int _lastPage = 1;

        /// <inheritdoc />
        public OrdersForm(FormState state = FormState.Default)
        {
            _state = state;
            _sortOption = SortOption.Descending;
            _repository = new OrderRepository();
            InitializeComponent();
        }

        private static bool CanUserAdd => UserSession.IsAdmin ||
                                          UserSession.Can(PermissionCode.AddOrder);
        private static bool CanUserDelete => UserSession.IsAdmin ||
                                             UserSession.Can(PermissionCode.DelOrder);

        private bool IsForView => _state == FormState.ForView;
        
        private void SetupForm()
        {
            _orders = _repository.GetAll().ToList();
            _firstFilter = new Order();
            _secondFilter = new Order();
            _rows = _orders.Count;

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

        private void FillPropertyComboBox()
        {
            foreach (OrderProperty property in Enum.GetValues(typeof(OrderProperty)))
            {
                var item = new ComboBoxItem()
                {
                    Content = property.ParseString(),
                    Tag = property
                };

                cbProperties.Items.Add(item);
            }

            cbProperties.DisplayMember = Resources.DisplayMember;
            cbProperties.SelectedIndex = 0;
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
        }

        private void SetupControls()
        {
            btnResetFilters.FlatAppearance.MouseOverBackColor = DraculaColor.Red;

            nudTotalFrom.Maximum = decimal.MaxValue;
            nudTotalTo.Maximum = decimal.MaxValue;

            FillStatusComboBox();
            FillPaidByCashComboBox();
            FillRowsComboBox();
            FillPropertyComboBox();

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

                dgvOrders.Rows[i].Cells[0].Value = _orders[i].Id;
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
            _orders = _repository.GetAll(
                _firstFilter,
                _secondFilter,
                _customer,
                _employee,
                _count,
                _currentPage,
                _sortOption,
                _property).ToList();

            _rows = _orders.Count;

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

            if (FlatMessageBox.ShowDialog("Вы уверены что хотите удалить заказ?", Caption.Warning, MessageBoxState.Question) != DialogResult.Yes)
                return;

            var id = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells[Resources.Number].Value);
            var order = _repository.FindById(id);
            order.Delete();
            _currentPage = 1;

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

            _currentPage = 1;
            _lastPage = 1;

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

            var id = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells[0].Value);
            var order = _repository.FindById(id);
            new OrderForm(order).ShowDialog();
            FilterDataGrid();
        }

        private void DatePlacedFromChanged(object sender, EventArgs e)
        {
            ChangeFormat(sender, e);
        }

        private void DatePlacedToChanged(object sender, EventArgs e)
        {
            ChangeFormat(sender, e);
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

        private void RowCountChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            _count = Convert.ToInt32(cbRows.SelectedItem);
            FilterDataGrid();
        }

        private void SortOptionChanged(object sender, EventArgs e)
        {
            if (_sortOption == SortOption.Ascending)
            {
                _sortOption = SortOption.Descending;
                iBtnSortOption.IconChar = IconChar.SortAmountDown;
            }
            else
            {
                _sortOption = SortOption.Ascending;
                iBtnSortOption.IconChar = IconChar.SortAmountDownAlt;
            }
        }

        private void PropertyChanged(object sender, EventArgs e)
        {
            foreach (ComboBoxItem item in cbProperties.Items)
                if (item == cbProperties.SelectedItem)
                    _property = (OrderProperty)item.Tag;
        }
    }
}
