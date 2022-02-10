using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
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
    public partial class EmployeesForm : Form
    {
        private List<Employee> _employees;
        private List<ComboBoxItem> _roles;

        private readonly FormState _state;

        private Employee _filter;
        private Employee _employee;
        
        private int _rows;
        private int _count;
        private int _currentPage = 1;
        private int _lastPage = 1;

        public Employee GetEmployee() => _employee;

        public EmployeesForm(FormState state = FormState.Default)
        {
            _state = state;
            InitializeComponent();
        }

        private void SetUpDataGrid()
        {
            _employees = EmployeeRepository.GetAll(out _rows);

            dgvEmployees.AddDataGridViewTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEmployees.AddDataGridViewTextBoxColumn(Resources.FullName, DataGridViewAutoSizeColumnMode.Fill);
            dgvEmployees.AddDataGridViewTextBoxColumn(Resources.PhoneNumber, DataGridViewAutoSizeColumnMode.Fill);
            dgvEmployees.AddDataGridViewTextBoxColumn(Resources.Role, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEmployees.AddDataGridViewButtonColumn(DraculaColor.Red);

            dgvEmployees.Font = GoogleFont.OpenSans;
            dgvEmployees.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvEmployees.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;
        }

        private void SetUpControls()
        {
            _roles = new List<ComboBoxItem>();

            if (UserSession.IsAdmin || UserSession.Can(PermissionCode.AddCustomer))
            {
                var btnAddOrder = new FlatButton("btnAddOrder", "Добавить", AddGridData);
                panelUserButtons.Controls.Add(btnAddOrder);
            }

            nudId.Maximum = decimal.MaxValue;
            foreach (var role in RoleRepository.GetAll())
            {
                var item = new ComboBoxItem()
                {
                    Name = role.Name,
                    Tag = role
                };
                _roles.Add(item);
                cbRole.Items.Add(item.Name);
            }

            foreach (var rowCountItem in Resources.RowCountItems)
                cbRows.Items.Add(rowCountItem);

            cbRows.SelectedItem = cbRows.Items[0];
            cbRows.SelectedIndexChanged += RowCountChanged;
            _count = Convert.ToInt32(cbRows.SelectedItem);

            UpdateTextBoxPagesText();
        }

        private void FillDataGrid()
        {
            dgvEmployees.Rows.Clear();

            for (var i = 0; i < _employees?.Count; i++)
            {
                dgvEmployees.Rows.Add(new DataGridViewRow());

                dgvEmployees.Rows[i].Cells[0].Value = dgvEmployees.Rows.Count;
                dgvEmployees.Rows[i].Cells[1].Value = _employees[i].FullName;
                dgvEmployees.Rows[i].Cells[2].Value = _employees[i].Login;
                dgvEmployees.Rows[i].Cells[3].Value = _employees[i].Role?.Name;
            }

            UpdateLastPageValue();
            UpdateTextBoxPagesText();
        }

        private void UpdateLastPageValue()
        {
            var result = Math.Ceiling(Convert.ToDouble(_rows) / _count);
            _lastPage = Convert.ToInt32(result);
        }

        private void FilterEmployeesGrid()
        {
            _employees = EmployeeRepository.GetAll(
                _filter,
                _count,
                _currentPage,
                out _rows);

            FillDataGrid();
        }

        private void UpdateTextBoxPagesText()
        {
            if (_lastPage == 0)
                _currentPage = 0;
            tbPages.UpdatePagesValue(_currentPage, _lastPage);
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            _filter = new Employee();

            SetUpDataGrid();
            SetUpControls();
            FillDataGrid();
        }

        private void RoleChanged(object sender, EventArgs e)
        {
            if (cbRole.SelectedItem == null)
                return;

            var item = (ComboBoxItem)cbRows.SelectedItem;
            var role = _roles.First(x => x.Content == item.Content).Tag as Role;
            _filter.Role = role;
        }

        private void AddGridData(object sender, EventArgs e)
        {
            var form = new EmployeeEditForm(new Employee());
            if (form.ShowDialog() == DialogResult.OK)
                FilterEmployeesGrid();
        }

        private void UseFilters(object sender, EventArgs e)
        {
            FilterEmployeesGrid();
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            _filter = new Employee();

            nudId.Value = Resources.DefaultNumericUpDownValue;
            tbFullName.Text = Resources.DefaultTextBoxText;
            cbRole.SelectedItem = null;

            _currentPage = 1;

            FilterEmployeesGrid();
        }

        private void RowCountChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            _count = Convert.ToInt32(cbRows.SelectedItem);
            FilterEmployeesGrid();
        }

        private void SHowPreviousPage(object sender, EventArgs e)
        {
            if (_currentPage <= 1)
                return;

            _currentPage--;
            FilterEmployeesGrid();
        }

        private void ShowNextPage(object sender, EventArgs e)
        {
            if (_currentPage >= _lastPage)
                return;

            _currentPage++;
            FilterEmployeesGrid();
        }

        private void IdChanged(object sender, EventArgs e)
        {
            _filter.Id = Convert.ToInt32(nudId.Value);
        }

        private void FullNameChanged(object sender, EventArgs e)
        {
            if(tbFullName.Text != "")
                _filter.FullName = tbFullName.Text;
        }

        private void RemoveGridData(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex < 0 ||
                senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn == false)
                return;

            var index = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells[0].Value);
            var employee = _employees[index - 1];

            employee.Delete();

            FilterEmployeesGrid();
        }

        private void ShowGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells[0].Value);
            var employee = _employees[index - 1];
            new EmployeeForm(employee).ShowDialog();

            FilterEmployeesGrid();
        }
    }
}
