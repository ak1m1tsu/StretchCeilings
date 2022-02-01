using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Controls;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Models;
using StretchCeilings.Repositories;
using static StretchCeilings.Properties.Resources;

namespace StretchCeilings.Views
{
    public partial class EmployeeEditForm : Form
    {
        private Employee _employee;

        private List<TimeTable> _tempTables;
        private List<TimeTable> _tables;
        private List<ComboBoxItem> _roles;

        public EmployeeEditForm(Employee employee)
        {
            _employee = EmployeeModelsRepository.GetById(employee.Id);
            InitializeComponent();
        }

        public Employee GetEmployee() => _employee;

        private void SetUpForm()
        {
            _roles = new List<ComboBoxItem>();

            if (UserSession.IsAdmin)
            {
                lblLogin.Visible = true;
                lblPassword.Visible = true;

                tbLogin.Visible = true;
                tbLogin.Text = _employee?.Login;
                tbPassword.Visible = true;
                tbPassword.Text = _employee?.Password;
            }

            foreach (var role in RoleModelsRepository.GetAll().Select(role => new ComboBoxItem() { Name = role.Name, Tag = role }))
            {
                var item = new ComboBoxItem()
                {
                    Content = role.Name,
                    Tag = role
                };
                cbRole.Items.Add(item);
            }

            cbRole.SelectedItem = cbRole.Items[2];
            tbFullName.Text = _employee?.FullName;

            SetUpTimeTableGrid();

            if (_employee != null) return;
            
            UpdateEmployeeData();
            _employee = new Employee();
            _employee.Add();
        }

        private void SetUpTimeTableGrid()
        {
            dgvTimeTable.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn("Дата",DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn("День недели",DataGridViewAutoSizeColumnMode.Fill);
            dgvTimeTable.AddDataGridViewTextBoxColumn("Начало",DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn("Конец",DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewButtonColumn(DraculaColor.Red);

            dgvTimeTable.Font = GoogleFont.OpenSans;
            dgvTimeTable.ForeColor = DraculaColor.Background;
            dgvTimeTable.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvTimeTable.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

            FillTimeTableGrid();
        }

        private void FillTimeTableGrid()
        {
            _tables = TimeTableModelsRepository.GetByEmployeeId(_employee.Id);
            
            dgvTimeTable.Rows.Clear();

            for (var i = 0; i < _tables?.Count; i++)
            {
                dgvTimeTable.Rows.Add(new DataGridViewRow());

                dgvTimeTable.Rows[i].Cells["№"].Value = _tables[i].Id;
                dgvTimeTable.Rows[i].Cells["Дата"].Value = _tables[i].Date?.Date.ToString("d");
                dgvTimeTable.Rows[i].Cells["День недели"].Value = _tables[i].Date?.DayOfWeek;
                dgvTimeTable.Rows[i].Cells["Начало"].Value = _tables[i].TimeStart?.TimeOfDay;
                dgvTimeTable.Rows[i].Cells["Конец"].Value = _tables[i].TimeEnd?.TimeOfDay;
            }
        }

        private void RemoveGridRow(DataGridViewCellEventArgs @event)
        {
            if (@event.RowIndex < 0 || @event.ColumnIndex != dgvTimeTable.Columns[" "]?.Index) return;

            TimeTableModelsRepository.GetById((int)dgvTimeTable.SelectedRows[0].Cells["№"].Value).Delete();
            
            FillTimeTableGrid();
        }

        private void UpdateEmployeeData()
        {
            foreach (ComboBoxItem item in cbRole.Items)
            {
                if (item != cbRole.SelectedItem) continue;

                var role = (Role)item.Tag;;
                _employee.RoleId = role.Id;
                _employee.Role = role;
            }

            _employee.FullName = tbFullName.Text;
            _employee.Login = tbLogin.Text;
            _employee.Password = tbPassword.Text;
        }

        private bool CanUpdate()
        {
            var hasErrors = false;
            epControls.Clear();

            if (tbPassword.Text == "")
            {
                epControls.SetError(tbPassword, RequiredToFillOut);
                hasErrors = true;
            }

            if (tbFullName.Text == "")
            {
                epControls.SetError(tbFullName, RequiredToFillOut);
                hasErrors = true;
            }

            if (string.IsNullOrWhiteSpace(tbLogin.Text))
            {
                epControls.SetError(tbLogin, RequiredToFillOut);
                hasErrors = true;
            }

            return hasErrors;
        }

        private void UpdateEmployee()
        {
            if (CanUpdate())
            {
                CustomMessageBox.Show(RequiredControlsAreEmpty, CustomMessageBoxCaption.Error);
                return;
            }

            UpdateEmployeeData();
            _employee.Update();
            _tempTables?.ForEach(x => x?.Add());
            DialogResult = DialogResult.OK;
        }

        private void CloseForm()
        {
            if(_employee.Login.Contains(" ") || _employee.Password.Length <= 0 || _employee.FullName.Length <= 0) 
                _employee.Delete();
            DialogResult = DialogResult.Cancel;
        }

        private void AddTimeTable()
        {
            var form = new TimeTableForm(_employee);
            if (form.ShowDialog() != DialogResult.OK) return;

            _tempTables = form.TimeTables;

            var rows = dgvTimeTable.Rows.Count;
            var tablesToRemove = (from table in _tables 
                from formTimeTable in _tempTables 
                where table.Date == formTimeTable.Date 
                select formTimeTable).ToList();

            foreach (var table in tablesToRemove.Where(table => _tempTables.Contains(table)))
            {
                _tempTables.Remove(table);
            }
            
            for (int i = rows, j = 0; i < rows + _tempTables.Count; i++, j++)
            {
                dgvTimeTable.Rows.Add(new DataGridViewRow());

                dgvTimeTable.Rows[i].Cells["№"].Value = _tempTables[j].Id;
                dgvTimeTable.Rows[i].Cells["Дата"].Value = _tempTables[j].Date?.Date.ToString("d");
                dgvTimeTable.Rows[i].Cells["День недели"].Value = _tempTables[j].Date?.DayOfWeek;
                dgvTimeTable.Rows[i].Cells["Начало"].Value = _tempTables[j].TimeStart?.TimeOfDay;
                dgvTimeTable.Rows[i].Cells["Конец"].Value = _tempTables[j].TimeEnd?.TimeOfDay;
            }
        }

        private void btnAddTimeTable_Click(object sender, EventArgs e)
        {
            AddTimeTable();
        }

        private void EmployeeFormEdit_Load(object sender, EventArgs e)
        {
            SetUpForm();
        }

        private void dgvTimeTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RemoveGridRow(e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateEmployee();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void tbFullName_TextChanged(object sender, EventArgs e)
        {
            _employee.FullName = tbFullName.Text;
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            var role = (Role)_roles.First(x => x.Name == (string)cbRole.SelectedItem).Tag;
            _employee.RoleId = role.Id;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            _employee.Password = tbPassword.Text;
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            _employee.Login = tbLogin.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
    }
}
