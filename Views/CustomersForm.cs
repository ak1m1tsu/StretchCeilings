using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Controls;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Helpers.Structs;
using StretchCeilings.Models;
using StretchCeilings.Repositories;

namespace StretchCeilings.Views
{
    public partial class CustomersForm : Form
    {
        private List<Customer> _customers;

        private Customer _filter;
        private Customer _customer;

        private readonly FormState _state;

        private int _rows;
        private int _count;
        private int _currentPage = 1;
        private int _lastPage = 1;

        public Customer GetCustomer() => _customer;

        public CustomersForm(FormState state = FormState.Default)
        {
            _state = state;
            InitializeComponent();
        }

        private void SetUpDataGrid()
        {
            _customers = CustomerRepository.GetAll(out _rows);

            dgvCustomers.AddDataGridViewTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvCustomers.AddDataGridViewTextBoxColumn(Resources.FullName, DataGridViewAutoSizeColumnMode.Fill);
            dgvCustomers.AddDataGridViewTextBoxColumn(Resources.PhoneNumber, DataGridViewAutoSizeColumnMode.Fill);
            dgvCustomers.AddDataGridViewButtonColumn(DraculaColor.Red);

            dgvCustomers.Font = GoogleFont.OpenSans;
            dgvCustomers.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvCustomers.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

            FillDataGrid();
        }

        private void SetUpControls()
        {
            if (UserSession.IsAdmin || UserSession.Can(PermissionCode.AddCustomer))
            {
                var btnAddOrder = new FlatButton("btnAddOrder", "Добавить", AddNewCustomer);
                panelUserButtons.Controls.Add(btnAddOrder);
            }

            nudId.Maximum = decimal.MaxValue;
            foreach (var rowCountItem in Resources.RowCountItems)
            {
                cbRows.Items.Add(rowCountItem);
            }

            cbRows.SelectedItem = cbRows.Items[0];
        }

        private void FillDataGrid()
        {
            dgvCustomers.Rows.Clear();

            for (var i = 0; i < _customers?.Count; i++)
            {
                dgvCustomers.Rows.Add(new DataGridViewRow());

                dgvCustomers.Rows[i].Cells[0].Value = _customers[i].Id;
                dgvCustomers.Rows[i].Cells[1].Value = _customers[i].FullName;
                dgvCustomers.Rows[i].Cells[2].Value = _customers[i].PhoneNumber;
            }

            _lastPage = (int)Math.Ceiling((double)_rows / _count);
            UpdatePagesTextBox();
        }

        private void FilterDataGrid()
        {
            _customers = CustomerRepository.GetAll(
                _filter,
                _count,
                _currentPage,
                out _rows);
            
            FillDataGrid();
        }

        private void SelectEmployee(object sender,DataGridViewCellEventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count <= 0 || e.RowIndex < 0)
                return;

            var id = (int)dgvCustomers.Rows[e.RowIndex].Cells[0].Value;
            _customer = CustomerRepository.GetById(id);
            DialogResult = DialogResult.OK;
        }

        private void UpdatePagesTextBox()
        {
            if (_lastPage == 0)
                _currentPage = 0;
            tbPages.UpdatePagesValue(_currentPage, _lastPage);
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            _filter = new Customer();
            SetUpDataGrid();
            SetUpControls();
        }

        private void RemoveGridData(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex < 0 ||
                senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn == false)
                return;

            var index = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells[0].Value);
            var customer = _customers[index - 1];
            customer.Delete();

            FilterDataGrid();
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

        private void AddNewCustomer(object sender, EventArgs e)
        {
            var form = new CustomerEditForm(new Customer());
            
            if (form.ShowDialog() != DialogResult.OK)
                return;

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

        private void RowCountChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            _count = Convert.ToInt32(cbRows.SelectedItem);
            FilterDataGrid();
        }
    }
}
