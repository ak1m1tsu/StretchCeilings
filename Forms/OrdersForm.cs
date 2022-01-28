using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FontAwesome.Sharp;
using StretchCeilingsApp.Data.Models;
using StretchCeilingsApp.Utility;
using StretchCeilingsApp.Utility.Controls;
using StretchCeilingsApp.Utility.Enums;
using StretchCeilingsApp.Utility.Extensions;
using StretchCeilingsApp.Utility.Extensions.Controls;
using StretchCeilingsApp.Utility.Repositories;

namespace StretchCeilingsApp.Forms
{
    public partial class OrdersForm : Form
    {
        private List<Order> _orders;
        
        private bool _forSearching;
        private int _count;
        private int _rowsCount;
        private int _currentPage = 1;
        private int _maxPage = 1;

        private Order _firstFilter;
        private Order _secondFilter;

        public OrdersForm(bool forSearching = false)
        {
            _forSearching = forSearching;
            InitializeComponent();
        }

        private void OpenDataGridRowForm()
        {
            if (dgvOrders.SelectedRows.Count <= 0) return;

            var order = OrderModelsRepository.GetById((int) dgvOrders.SelectedRows[0].Cells[0].Value);
            new OrderForm(order).ShowDialog();
        }

        private void SetUpDataGridView()
        {
            _orders = OrderModelsRepository.GetALl(out _rowsCount);

            dgvOrders.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvOrders.AddDataGridViewTextBoxColumn("Дата размещения", DataGridViewAutoSizeColumnMode.Fill);
            dgvOrders.AddDataGridViewTextBoxColumn("Клиент", DataGridViewAutoSizeColumnMode.Fill);
            dgvOrders.AddDataGridViewTextBoxColumn("Статус", DataGridViewAutoSizeColumnMode.Fill);
            dgvOrders.AddDataGridViewCheckBoxColumn("Оплачен наличными", DataGridViewAutoSizeColumnMode.Fill);
            dgvOrders.AddDataGridViewTextBoxColumn("Стоимость", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvOrders.AddDataGridViewButtonColumn(Constants.DraculaRed);

            dgvOrders.Font = Constants.DataGridViewFont;
            dgvOrders.DefaultCellStyle.SelectionBackColor = Constants.DraculaSelection;
            dgvOrders.DefaultCellStyle.SelectionForeColor = Constants.DraculaForeground;
            dgvOrders.CellClick += dgvOrdersButtonsColumn_CellClick;

            FillDataGrid();
        }

        private void dgvOrdersButtonsColumn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvOrders.Columns[" "]?.Index) return;

            var order = OrderModelsRepository.GetById((int)dgvOrders.SelectedRows[0].Cells["№"].Value);

            order.Delete();

            FilterDataGrid();
        }

        private void SetUpControls()
        {
            if (UserSession.IsAdmin || UserSession.Can(PermissionCode.AddOrder))
            {
                var btnAddOrder = new FlatButton("btnAddOrder", "Добавить", btnAddOrder_Click);
                paneUserButtons.Controls.Add(btnAddOrder);
            }

            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                if(status == OrderStatus.Unknown) continue;
                cbStatusValue.Items.Add(status.ParseString());
            }
            cbStatusValue.SelectedItem = null;

            foreach (var paidByCashItem in Constants.PaidByCashItems)
                cbPaidByCash.Items.Add(paidByCashItem);
            cbPaidByCash.SelectedItem = null;
            
            nudTotalFrom.Maximum = decimal.MaxValue;
            nudTotalTo.Maximum = decimal.MaxValue;
            

            foreach (var item in Constants.RowCountItems)
                cbRows.Items.Add(item);
            cbRows.SelectedItem = cbRows.Items[0];

            SetPages();

            btnResetFilters.BackColor = Constants.DraculaAlphaRed;
        }

        private void FilterDataGrid()
        {
            _orders = OrderModelsRepository.GetALl(
                _firstFilter,
                _secondFilter, 
                _count,
                _currentPage,
                out _rowsCount);

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            dgvOrders.Rows.Clear();

            for (var i = 0; i < _orders?.Count; i++)
            {
                dgvOrders.Rows.Add(new DataGridViewRow() { Resizable = DataGridViewTriState.False });

                dgvOrders.Rows[i].Cells[0].Value = _orders[i].Id;
                dgvOrders.Rows[i].Cells[1].Value = _orders[i].DatePlaced;
                dgvOrders.Rows[i].Cells[2].Value = _orders[i].Customer.FullName;
                dgvOrders.Rows[i].Cells[3].Value = _orders[i].Status?.ParseString();
                dgvOrders.Rows[i].Cells[4].Value = _orders[i].PaidByCash;
                dgvOrders.Rows[i].Cells[5].Value = _orders[i].Total;
            }

            _maxPage = (int)Math.Ceiling((double)_rowsCount / _count);
            SetPages();
        }

        private void ResetDataGridFilters()
        {
            _firstFilter = new Order()
            {
                Status = OrderStatus.Unknown
            };
            _secondFilter = new Order();

            nudTotalFrom.Value = Constants.DefaultNumericUpDownValue;
            nudTotalTo.Value = Constants.DefaultNumericUpDownValue;
            nudIdValue.Value = Constants.DefaultNumericUpDownValue;
            
            dtpDateFromValue.CustomFormat = Constants.DefaultDateTimePickerCustomFormat;
            dtpDateToValue.CustomFormat = Constants.DefaultDateTimePickerCustomFormat;
            
            ibtnCustomer.IconChar = Constants.SearchIcon;
            ibtnCustomer.Text = Constants.DefaultIconButtonText;
            ibtnEmployee.IconChar = Constants.SearchIcon;
            ibtnEmployee.Text = Constants.DefaultIconButtonText;

            cbPaidByCash.SelectedItem = null;
            cbStatusValue.SelectedItem = null;

            FilterDataGrid();
        }

        private void TakeEmployee()
        {
            var employeesForm = new EmployeesForm();

            employeesForm.ShowDialog();

            if (employeesForm.DialogResult == DialogResult.OK)
            {
                ibtnEmployee.Tag = employeesForm.Employee;
                ibtnEmployee.Text = employeesForm.Employee.FullName;
                ibtnEmployee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                ibtnCustomer.IconChar = IconChar.None;
            }
        }
        private void TakeCustomer()
        {
            var customersForm = new CustomersForm();

            customersForm.ShowDialog();

            if (customersForm.DialogResult == DialogResult.OK)
            {
                ibtnCustomer.Tag = customersForm.Customer;
                ibtnCustomer.Text = customersForm.Customer.FullName;
                ibtnCustomer.IconChar = IconChar.None;
            }
        }

        private void SetPages()
        {
            if (_maxPage == 0)
                _currentPage = 0;
            tbPage.Text = $"{_currentPage} / {_maxPage}";
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            _firstFilter = new Order() { Status = OrderStatus.Unknown };
            _secondFilter = new Order();

            SetUpDataGridView();
            SetUpControls();
        }

        private static void btnAddOrder_Click(object sender, EventArgs e)
        {
            new OrderFormEdit().ShowDialog();
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
            dateTimePicker.CustomFormat = Constants.FilterDateTimePickerCustomFormat;
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDataGridRowForm();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage < _maxPage)
            {
                _currentPage++;
                SetPages();
                FilterDataGrid();
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                SetPages();
                FilterDataGrid();
            }
        }

        private static void SetFilterDatePlacedValue(Order filter, DateTimePicker dateTimePicker)
        {
            if (dateTimePicker.CustomFormat != Constants.DefaultDateTimePickerCustomFormat)
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

        private void cbStatusValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatusValue.SelectedItem == null)
            {
                _firstFilter.Status = OrderStatus.Unknown;
                return;
            }
            _firstFilter.Status = cbStatusValue.SelectedItem.ToString().ToOrderStatus();
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

        private void ibtnCustomer_Click(object sender, EventArgs e)
        {
            TakeEmployee();
        }

        private void ibtnEmployee_Click(object sender, EventArgs e)
        {
            TakeCustomer();
        }
        private void nudIdValue_ValueChanged(object sender, EventArgs e)
        {
            if (nudIdValue.Value == 0) return;
            _firstFilter.Id = (int)nudIdValue.Value;
        }

        private void cbPaidByCash_SelectedIndexChanged(object sender, EventArgs e)
        {
            _firstFilter.PaidByCash = (string)cbPaidByCash.SelectedItem == Constants.PaidByCashItems[0] ? false : _firstFilter.PaidByCash;
            _firstFilter.PaidByCash = (string)cbPaidByCash.SelectedItem == Constants.PaidByCashItems[1] ? true : _firstFilter.PaidByCash;
        }
    }
}
