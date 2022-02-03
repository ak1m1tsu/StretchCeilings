using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Controls;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Models;
using StretchCeilings.Repositories;

namespace StretchCeilings.Views
{
    public partial class CustomersForm : Form
    {
        private List<Customer> _customers;

        private Customer _filter;
        private Customer _customer;

        private readonly bool _forSearching;

        private int _rows;
        private int _count;
        private int _currentPage = 1;
        private int _maxPage = 1;

        public Customer GetCustomer() => _customer;

        public CustomersForm(bool forSearching = false)
        {
            _forSearching = forSearching;
            InitializeComponent();
        }

        private void SetUpDataGrid()
        {
            _customers = CustomerRepository.GetAll(out _rows);

            dgvCustomers.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvCustomers.AddDataGridViewTextBoxColumn("ФИО", DataGridViewAutoSizeColumnMode.Fill);
            dgvCustomers.AddDataGridViewTextBoxColumn("Номер телефона", DataGridViewAutoSizeColumnMode.Fill);
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
                var btnAddOrder = new FlatButton("btnAddOrder", "Добавить", btnAddOrder_Click);
                panelUserButtons.Controls.Add(btnAddOrder);
            }

            nudId.Maximum = decimal.MaxValue;
            foreach (var rowCountItem in Constants.RowCountItems)
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

            _maxPage = (int)Math.Ceiling((double)_rows / _count);
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

        private void OpenDataGridRowForm(DataGridViewCellEventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count <= 0 || e.RowIndex < 0) return;

            var customer = CustomerRepository.GetById((int)dgvCustomers.SelectedRows[0].Cells[0].Value);
            new CustomerForm(customer).ShowDialog();
        }

        private void ShowPreviousPage()
        {
            if (_currentPage <= 1) return;

            _currentPage--;
            UpdatePagesTextBox();
            FilterDataGrid();
        }

        private void ShowNextPage()
        {
            if (_currentPage >= _maxPage) return;

            _currentPage++;
            UpdatePagesTextBox();
            FilterDataGrid();
        }

        private void UpdatePagesTextBox()
        {
            if (_maxPage == 0)
                _currentPage = 0;
            tbPages.UpdatePagesValue(_currentPage, _maxPage);
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            _filter = new Customer();
            SetUpDataGrid();
            SetUpControls();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvCustomers.Columns[" "]?.Index) return;

            var customer = CustomerRepository.GetById((int)dgvCustomers.SelectedRows[0].Cells["№"].Value);
            customer.Delete();

            FilterDataGrid();
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDataGridRowForm(e);
        }

        private static void btnAddOrder_Click(object sender, EventArgs e)
        {
            new CustomerEditForm(new Customer()).ShowDialog();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            ShowPreviousPage();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            ShowNextPage();
        }

        private void cbRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            _count = int.Parse(cbRows.Items[cbRows.SelectedIndex].ToString());
            FilterDataGrid();
        }

        private void tbFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
}
