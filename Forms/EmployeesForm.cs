using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.CustomControls;
using stretch_ceilings_app.Utility.Enums;
using stretch_ceilings_app.Utility.Extensions;
using stretch_ceilings_app.Utility.Repositories;

namespace stretch_ceilings_app.Forms
{
    public partial class EmployeesForm : Form
    {
        private List<Employee> _employees;
        private List<ComboBoxItem> _roles;

        private readonly bool _forSearching;

        private Employee _filter;
        private Employee _employee;
        
        private int _rows;
        private int _count;
        private int _currentPage = 1;
        private int _maxPage = 1;

        public Employee Employee => _employee;

        public EmployeesForm(bool forSearching = false)
        {
            _forSearching = forSearching;
            InitializeComponent();
        }

        private void SetUpControls()
        {
            _roles = new List<ComboBoxItem>();

            if (UserSession.IsAdmin || UserSession.Can(PermissionCode.AddCustomer))
            {
                var btnAddOrder = new FlatButton("btnAddOrder", "Добавить");
                btnAddOrder.Click += btnAddOrder_Click;
                panelUserButtons.Controls.Add(btnAddOrder);
            }

            nudId.Maximum = decimal.MaxValue;
            foreach (var role in RoleRepository.GetAll())
            {
                ComboBoxItem item = new ComboBoxItem()
                {
                    Name = role.Name,
                    Tag = role
                };
                _roles.Add(item);
                cbRole.Items.Add(item.Name);
            }

            foreach (var rowCountItem in Constants.RowCountItems)
                cbRows.Items.Add(rowCountItem);

            cbRows.SelectedItem = cbRows.Items[0];

            SetPages();
        }

        private void SetUpDataGrid()
        {
            _employees = EmployeeRepository.GetAll(out _rows);

            var idColumn = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            var fullNameColumn = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("ФИО", DataGridViewAutoSizeColumnMode.Fill);
            var phoneNumberColumn = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Номер телефона", DataGridViewAutoSizeColumnMode.Fill);
            var roleColumn = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Должность", DataGridViewAutoSizeColumnMode.DisplayedCells);
            var delColumn = DataGridViewExtensions.CreateDataGridViewButtonColumn(Constants.DraculaRed);

            dgvEmployees.Font = Constants.DataGridViewFont;
            dgvEmployees.DefaultCellStyle.SelectionBackColor = Constants.DraculaSelection;
            dgvEmployees.DefaultCellStyle.SelectionForeColor = Constants.DraculaForeground;
            dgvEmployees.Columns.AddRange(idColumn, fullNameColumn, phoneNumberColumn, roleColumn, delColumn);

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            dgvEmployees.Rows.Clear();

            for (var i = 0; i < _employees?.Count; i++)
            {
                dgvEmployees.Rows.Add(new DataGridViewRow());

                dgvEmployees.Rows[i].Cells[0].Value = _employees[i].Id;
                dgvEmployees.Rows[i].Cells[1].Value = _employees[i].FullName;
                dgvEmployees.Rows[i].Cells[2].Value = _employees[i].Login;
                dgvEmployees.Rows[i].Cells[3].Value = _employees[i].Role?.Name;
            }

            _maxPage = (int)Math.Ceiling((double)_rows / _count);

            SetPages();
        }

        private void FilterDataGrid()
        {
            _employees = EmployeeRepository.GetAll(
                _filter,
                _count,
                _currentPage,
                out _rows);

            FillDataGrid();
        }
        private void OpenDataGridRowForm()
        {
            if (dgvEmployees.SelectedRows.Count <= 0) return;

            var customer = CustomerRepository.GetById((int)dgvEmployees.SelectedRows[0].Cells[0].Value);
            new CustomerForm(customer).ShowDialog();
        }

        private void SetPages()
        {
            if (_maxPage == 0)
                _currentPage = 0;
            tbPages.Text = $"{_currentPage} / {_maxPage}";
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            _filter = new Employee();
            SetUpDataGrid();
            SetUpControls();
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRole.SelectedItem == null) return;

            _filter.Role = (Role)_roles.First(x => x.Name == (string)cbRole.Items[cbRole.SelectedIndex]).Tag;
        }

        private static void btnAddOrder_Click(object sender, EventArgs e)
        {
            new EmployeeForm(new Employee()).ShowDialog();
        }

        private void btnUseFilters_Click(object sender, EventArgs e)
        {
            FilterDataGrid();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            _filter = new Employee();

            nudId.Value = Constants.DefaultNumericUpDownValue;
            tbFullName.Text = Constants.DefaultTextBoxText;
            cbRole.SelectedItem = null;

            _currentPage = 1;

            FilterDataGrid();
        }

        private void cbRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            _count = int.Parse(cbRows.Items[cbRows.SelectedIndex].ToString());
            FilterDataGrid();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                SetPages();
                FilterDataGrid();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentPage < _maxPage)
            {
                _currentPage++;
                SetPages();
                FilterDataGrid();
            }
        }

        private void nudId_ValueChanged(object sender, EventArgs e)
        {
            _filter.Id = (int)nudId.Value;
        }

        private void tbFullName_TextChanged(object sender, EventArgs e)
        {
            if(tbFullName.Text != "") _filter.FullName = tbFullName.Text;
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvEmployees.Columns[" "]?.Index) return;

            var employee = EmployeeRepository.GetById((int)dgvEmployees.SelectedRows[0].Cells["№"].Value);

            employee.Delete();

            FilterDataGrid();
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDataGridRowForm();
        }
    }
}
