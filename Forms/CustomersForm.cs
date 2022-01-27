using System;
using System.Collections.Generic;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.CustomControls;
using stretch_ceilings_app.Utility.Enums;
using stretch_ceilings_app.Utility.Extensions;
using stretch_ceilings_app.Utility.Repositories;

namespace stretch_ceilings_app.Forms
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

        public Customer Customer => _customer;

        public CustomersForm(bool forSearching = false)
        {
            _forSearching = forSearching;
            InitializeComponent();
        }

        private void SetUpControls()
        {
            if (UserSession.IsAdmin || UserSession.Can(PermissionCode.AddCustomer))
            {
                var btnAddOrder = new FlatButton("btnAddOrder", "Добавить");
                btnAddOrder.Click += btnAddOrder_Click;
                panelUserButtons.Controls.Add(btnAddOrder);
            }

            nudId.Maximum = decimal.MaxValue;
            foreach (var rowCountItem in Constants.RowCountItems)
            {
                cbRows.Items.Add(rowCountItem);
            }

            cbRows.SelectedItem = cbRows.Items[0];
        }

        private void SetUpDataGrid()
        {
            _customers = CustomerRepository.GetAll(out _rows);

            var idColumn = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            var fullNameColumn = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("ФИО", DataGridViewAutoSizeColumnMode.Fill);
            var phoneNumberColumn = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Номер телефона", DataGridViewAutoSizeColumnMode.Fill);
            var delColumn = DataGridViewExtensions.CreateDataGridViewButtonColumn(Constants.DraculaRed);

            dgvCustomers.Font = Constants.DataGridViewFont;
            dgvCustomers.DefaultCellStyle.SelectionBackColor = Constants.DraculaSelection;
            dgvCustomers.DefaultCellStyle.SelectionForeColor = Constants.DraculaForeground;
            dgvCustomers.Columns.AddRange(idColumn,fullNameColumn,phoneNumberColumn,delColumn);

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            dgvCustomers.Rows.Clear();

            for (int i = 0; i < _customers?.Count; i++)
            {
                dgvCustomers.Rows.Add(new DataGridViewRow());

                dgvCustomers.Rows[i].Cells[0].Value = _customers[i].Id;
                dgvCustomers.Rows[i].Cells[1].Value = _customers[i].FullName;
                dgvCustomers.Rows[i].Cells[2].Value = _customers[i].PhoneNumber;
            }

            _maxPage = (int)Math.Ceiling((double)_rows / _count);
            SetPages();
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

        private void OpenDataGridRowForm()
        {
            if (dgvCustomers.SelectedRows.Count <= 0) return;

            var customer = CustomerRepository.GetById((int)dgvCustomers.SelectedRows[0].Cells[0].Value);
            new CustomerForm(customer).ShowDialog();
        }

        private void SetPages()
        {
            tbPages.Text = $"{_currentPage} / {_maxPage}";
        }

        private void CustomersForm_Load(object sender, System.EventArgs e)
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
            OpenDataGridRowForm();
        }

        private static void btnAddOrder_Click(object sender, EventArgs e)
        {
            new CustomerFormEdit(new Customer()).ShowDialog();
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

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage < _maxPage)
            {
                _currentPage++;
                SetPages();
                FilterDataGrid();
            }
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
    }
}
