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
    public partial class EmployeesForm : Form
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IRoleRepository _roleRepository;
        private List<Employee> _employees;
        private List<ComboBoxItem> _roles;

        private readonly FormState _state;
        private SortOption _sortOption;
        private EmployeeProperty _property;

        private Employee _filter;
        private Employee _employee;
        
        private int _rows;
        private int _count;
        private int _currentPage = 1;
        private int _lastPage = 1;

        public Employee GetEmployee() => _employee;

        public EmployeesForm(FormState state = FormState.Default)
        {
            _employeeRepository = new EmployeeRepository();
            _roleRepository = new RoleRepository();
            _state = state;
            _sortOption = SortOption.Descending;
            InitializeComponent();
        }

        private static bool CanUserDelete => UserSession.IsAdmin ||
                                               UserSession.Can(PermissionCode.DelOrder);

        private static bool CanUserAdd => UserSession.IsAdmin ||
                                            UserSession.Can(PermissionCode.AddOrder);

        private bool IsForView => _state == FormState.ForView;

        private void SetupDataGrid()
        {
            _employees = _employeeRepository.GetAll().ToList();
            _rows = _employees.Count;

            dgvEmployees.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEmployees.CreateTextBoxColumn(Resources.FullName, DataGridViewAutoSizeColumnMode.Fill);
            dgvEmployees.CreateTextBoxColumn(Resources.PhoneNumber, DataGridViewAutoSizeColumnMode.Fill);
            dgvEmployees.CreateTextBoxColumn(Resources.Role, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEmployees.CreateButtonColumn();

            dgvEmployees.Font = GoogleFont.OpenSans;
            dgvEmployees.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvEmployees.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;
        }

        private void SetupControls()
        {
            _roles = new List<ComboBoxItem>();

            FillPropertyComboBox();
            
            foreach (var role in _roleRepository.GetAll())
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

            if (CanUserAdd && IsForView == false)
                DrawAddButton();

            if (CanUserDelete == false || IsForView)
                dgvEmployees.Columns[Resources.Space].Visible = false;

            if (IsForView)
            {
                dgvEmployees.CellDoubleClick += SelectEmployee;
                panelTopSide.Visible = true;
                return;
            }

            dgvEmployees.CellDoubleClick += ShowGridData;
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

        private void DrawAddButton()
        {
            var btnAddOrder = new FlatButton("btnAddOrder", "Добавить", AddGridData);
            panelUserButtons.Controls.Add(btnAddOrder);
        }

        private void UpdateLastPageValue()
        {
            var result = Math.Ceiling(Convert.ToDouble(_rows) / _count);
            _lastPage = Convert.ToInt32(result);
        }

        private void FilterDataGrid()
        {
            _employees = _employeeRepository.GetAll(
                _filter,
                _count,
                _currentPage,
                _sortOption,
                _property).ToList();

            _rows = _employees.Count;

            FillDataGrid();
        }

        private void UpdateTextBoxPagesText()
        {
            if (_lastPage == 0)
                _currentPage = 0;
            tbPages.UpdatePagesValue(_currentPage, _lastPage);
        }

        private void LoadForm(object sender, EventArgs e)
        {
            _filter = new Employee();

            SetupDataGrid();
            SetupControls();
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

            if (form.ShowDialog() != DialogResult.OK)
                return;

            FilterDataGrid();
            FlatMessageBox.ShowDialog("Сотрудник успешно добавлен", Caption.Info);
        }

        private void UseFilters(object sender, EventArgs e)
        {
            FilterDataGrid();
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            _filter = new Employee();
            
            tbFullName.Text = Resources.DefaultTextBoxText;
            cbRole.SelectedItem = null;

            _currentPage = 1;
            _lastPage = 1;
            
            FilterDataGrid();
            FlatMessageBox.ShowDialog("Значение фильтров сброшено до стандартных", Caption.Info);
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
        
        private void FullNameChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbFullName.Text) == false)
                _filter.FullName = tbFullName.Text;
        }

        private void RemoveGridData(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex < 0 ||
                senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn == false)
                return;

            if (FlatMessageBox.ShowDialog("Вы уверены что хотите удалить сотрудника?", Caption.Warning, MessageBoxState.Question) != DialogResult.Yes)
                return;

            var index = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells[0].Value);
            var employee = _employees[index - 1];
            employee.Delete();
            _currentPage = 1;

            FilterDataGrid();
            FlatMessageBox.ShowDialog("Сотрудник успешно удален.", Caption.Info);
        }

        private void SelectEmployee(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells[0].Value);
            _employee = _employees[index - 1];

            DialogResult = DialogResult.OK;
        }

        private void ShowGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells[0].Value);
            var employee = _employees[index - 1];
            new EmployeeForm(employee).ShowDialog();

            FilterDataGrid();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
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
                    _property = (EmployeeProperty)item.Tag;
        }

        private void FillPropertyComboBox()
        {
            foreach (EmployeeProperty property in Enum.GetValues(typeof(EmployeeProperty)))
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
