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
        private Employee _getEmployee;
        
        private int _rows;
        private int _count;
        private int _currentPage = 1;
        private int _maxPage = 1;

        public Employee GetEmployee() => _getEmployee;

        public EmployeesForm(FormState state = FormState.Default)
        {
            _state = state;
            InitializeComponent();
        }

        private void SetUpDataGrid()
        {
            _employees = EmployeeRepository.GetAll(out _rows);

            dgvEmployees.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEmployees.AddDataGridViewTextBoxColumn("ФИО", DataGridViewAutoSizeColumnMode.Fill);
            dgvEmployees.AddDataGridViewTextBoxColumn("Номер телефона", DataGridViewAutoSizeColumnMode.Fill);
            dgvEmployees.AddDataGridViewTextBoxColumn("Должность", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEmployees.AddDataGridViewButtonColumn(DraculaColor.Red);

            dgvEmployees.Font = GoogleFont.OpenSans;
            dgvEmployees.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvEmployees.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

            FillEmployeesGrid();
        }

        private void SetUpControls()
        {
            _roles = new List<ComboBoxItem>();

            if (UserSession.IsAdmin || UserSession.Can(PermissionCode.AddCustomer))
            {
                var btnAddOrder = new FlatButton("btnAddOrder", "Добавить", btnAddEmployee_Click);
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

            UpdateTextBoxPagesText();
        }

        private void FillEmployeesGrid()
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

            UpdateTextBoxPagesText();
        }

        private void ResetFilters()
        {
            _filter = new Employee();

            nudId.Value = Resources.DefaultNumericUpDownValue;
            tbFullName.Text = Resources.DefaultTextBoxText;
            cbRole.SelectedItem = null;

            _currentPage = 1;

            FilterEmployeesGrid();
        }

        private void FilterEmployeesGrid()
        {
            _employees = EmployeeRepository.GetAll(
                _filter,
                _count,
                _currentPage,
                out _rows);

            FillEmployeesGrid();
        }
        private void OpenDataGridRowForm(DataGridViewCellEventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count <= 0 || e.RowIndex < 0) return;

            var employee = EmployeeRepository.GetById((int)dgvEmployees.SelectedRows[0].Cells[0].Value);
            new EmployeeForm(employee).ShowDialog();
            FilterEmployeesGrid();
        }

        private void UpdateTextBoxPagesText()
        {
            if (_maxPage == 0)
                _currentPage = 0;
            tbPages.UpdatePagesValue(_currentPage, _maxPage);
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

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var form = new EmployeeEditForm(new Employee());
            if (form.ShowDialog() == DialogResult.OK)
                FilterEmployeesGrid();
        }

        private void btnUseFilters_Click(object sender, EventArgs e)
        {
            FilterEmployeesGrid();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            ResetFilters();
        }

        private void cbRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            _count = int.Parse(cbRows.Items[cbRows.SelectedIndex].ToString());
            FilterEmployeesGrid();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                UpdateTextBoxPagesText();
                FilterEmployeesGrid();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentPage < _maxPage)
            {
                _currentPage++;
                UpdateTextBoxPagesText();
                FilterEmployeesGrid();
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

            FilterEmployeesGrid();
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDataGridRowForm(e);
        }
    }
}
