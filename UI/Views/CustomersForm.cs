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
    public partial class CustomersForm : Form
    {
        private readonly ICustomerRepository _repository;
        private List<Customer> _customers;

        private Customer _filter;
        private Customer _customer;

        private readonly FormState _state;
        private SortOption _sortOption;
        private CustomerProperty _property;

        private int _rows;
        private int _count;
        private int _currentPage = 1;
        private int _lastPage = 1;

        public Customer GetCustomer() => _customer;

        /// <inheritdoc />
        public CustomersForm(FormState state = FormState.Default)
        {
            _repository = new CustomerRepository();
            _state = state;
            _sortOption = SortOption.Descending;
            InitializeComponent();
        }

        private static bool CanUserAdd => UserSession.IsAdmin ||
                                          UserSession.Can(PermissionCode.AddCustomer);

        private static bool CanUserDelete => UserSession.IsAdmin ||
                                               UserSession.Can(PermissionCode.DelCustomer);

        private bool IsForView => _state == FormState.ForView;

        private void SetupDataGrid()
        {
            dgvCustomers.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvCustomers.CreateTextBoxColumn(Resources.FullName, DataGridViewAutoSizeColumnMode.Fill);
            dgvCustomers.CreateTextBoxColumn(Resources.PhoneNumber, DataGridViewAutoSizeColumnMode.Fill);
            dgvCustomers.CreateButtonColumn();

            dgvCustomers.Font = GoogleFont.OpenSans;
            dgvCustomers.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvCustomers.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;
        }

        private void SetupControls()
        {
            foreach (var rowCountItem in Resources.RowCountItems)
                cbRows.Items.Add(rowCountItem);
            
            FillPropertyComboBox();

            cbRows.SelectedIndex = 0;
            _count = Convert.ToInt32(cbRows.SelectedItem);

            if (CanUserAdd && IsForView == false)
                DrawAddButton();

            if (CanUserDelete == false || IsForView)
                dgvCustomers.Columns[Resources.Space].Visible = false;

            if (IsForView)
            {
                dgvCustomers.CellDoubleClick += SelectCustomer;
                panelTopSide.Visible = true;
                return;
            }

            dgvCustomers.CellDoubleClick += ShowGridData;
        }

        private void FillDataGrid()
        {
            dgvCustomers.Rows.Clear();

            for (var i = 0; i < _customers?.Count; i++)
            {
                dgvCustomers.Rows.Add(new DataGridViewRow());

                dgvCustomers.Rows[i].Cells[0].Value = dgvCustomers.Rows.Count;
                dgvCustomers.Rows[i].Cells[1].Value = _customers[i].FullName;
                dgvCustomers.Rows[i].Cells[2].Value = _customers[i].PhoneNumber;
            }

            UpdateLastPageValue();
            UpdatePagesTextBox();
        }

        private void UpdateLastPageValue()
        {
            var result = Math.Ceiling(Convert.ToDouble(_rows) / _count);
            _lastPage = Convert.ToInt32(result);
        }

        private void FilterDataGrid()
        {
            _customers = _repository.GetAll(
                _filter,
                _count,
                _currentPage,
                _sortOption,
                _property).ToList();

            _rows = _customers.Count;

            FillDataGrid();
        }

        private void DrawAddButton()
        {
            var btnAddOrder = new FlatButton("btnAddOrder", "Добавить", AddGridData);
            panelUserButtons.Controls.Add(btnAddOrder);
        }

        private void SelectCustomer(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells[0].Value);
            _customer = _customers[index - 1];
            DialogResult = DialogResult.OK;
        }

        private void UpdatePagesTextBox()
        {
            if (_lastPage == 0)
                _currentPage = 0;
            tbPages.UpdatePagesValue(_currentPage, _lastPage);
        }

        private void LoadForm(object sender, EventArgs e)
        {
            _customers = _repository.GetAll().ToList();
            _rows = _customers.Count;
            _filter = new Customer();

            SetupDataGrid();
            SetupControls();
            FillDataGrid();
        }

        private void RemoveGridData(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex < 0 ||
                senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn == false)
                return;

            if (FlatMessageBox.ShowDialog("Вы уверены что хотите удалить клиента?", Caption.Warning, MessageBoxState.Question) != DialogResult.Yes)
                return;

            var index = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells[0].Value);
            var customer = _customers[index - 1];
            customer.Delete();
            _currentPage = 1;

            FilterDataGrid();
            FlatMessageBox.ShowDialog("Клиент успешно удален", Caption.Info);
        }

        private void ShowGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count <= 0 || e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells[0].Value);
            var customer = _customers[index - 1];
            new CustomerForm(customer).ShowDialog();
            FilterDataGrid();
        }

        private void AddGridData(object sender, EventArgs e)
        {
            var form = new CustomerEditForm();
            
            if (form.ShowDialog() != DialogResult.OK)
                return;

            FilterDataGrid();
            FlatMessageBox.ShowDialog("Клиент успешно добавлен", Caption.Info);
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

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void UpdateFilterValues()
        {
            if (string.IsNullOrWhiteSpace(tbFullName.Text) == false)
                _filter.FullName = tbFullName.Text;
            
            if (mtbPhoneNumber.Text != Resources.EmptyPhoneNumber &&
                mtbPhoneNumber.Text.Length == Resources.EmptyPhoneNumber.Length &&
                mtbPhoneNumber.Text.Contains(" ") == false)
                _filter.PhoneNumber = mtbPhoneNumber.Text;
        }

        private void UseFilters(object sender, EventArgs e)
        {
            UpdateFilterValues();
            FilterDataGrid();
        }

        private void ResetFilterValues()
        {
            _filter = new Customer();
            _currentPage = 1;
            _lastPage = 1;
            tbFullName.Text = null;
            mtbPhoneNumber.Text = Resources.EmptyPhoneNumber;
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            ResetFilterValues();
            FilterDataGrid();
            FlatMessageBox.ShowDialog("Значение фильтров сброшено до стандартных", Caption.Info);
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
                    _property = (CustomerProperty)item.Tag;
        }

        private void FillPropertyComboBox()
        {
            foreach (CustomerProperty property in Enum.GetValues(typeof(CustomerProperty)))
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
    }
}
