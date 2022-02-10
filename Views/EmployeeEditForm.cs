using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Helpers.Structs;
using StretchCeilings.Models;
using StretchCeilings.Repositories;

namespace StretchCeilings.Views
{
    public partial class EmployeeEditForm : Form
    {
        private readonly Employee _employee;
        private readonly List<Role> _roles;

        private List<TimeTable> _addedTables;
        private List<TimeTable> _deletedTables;
        private List<TimeTable> _tables;

        public EmployeeEditForm(Employee employee)
        {
            _addedTables = new List<TimeTable>();
            _deletedTables = new List<TimeTable>();
            _employee = employee;
            _roles = RoleRepository.GetAll();
            InitializeComponent();
        }

        public Employee GetEmployee() => _employee;

        private void SetupForm()
        {
            tbFullName.Text = _employee?.FullName;
            if (UserSession.IsAdmin)
            {
                lblLogin.Visible = true;
                lblPassword.Visible = true;

                tbLogin.Visible = true;
                tbLogin.Text = _employee?.Login;
                tbPassword.Visible = true;
                tbPassword.Text = _employee?.Password;
            }

            foreach (var item in RoleRepository.GetAll().Select(role => new ComboBoxItem()
                     {
                         Content = role.Name, Tag = role
                     }))
            {
                cbRole.Items.Add(item);
            }

            cbRole.DisplayMember = Resources.DisplayMember;
            foreach (ComboBoxItem item in cbRole.Items)
            {
                if (((Role)item.Tag).Id == _employee?.RoleId)
                    cbRole.SelectedItem = item;
            }

            SetUpTimeTableGrid();

            if (_employee?.Id != 0)
                return;

            cbRole.SelectedItem = cbRole.Items[cbRole.Items.Count - 1];

            UpdateEmployeeData();
            _employee.Add();
        }

        private void SetUpTimeTableGrid()
        {
            dgvTimeTable.AddDataGridViewTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn(Resources.Date,DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn(Resources.DayOfWeek,DataGridViewAutoSizeColumnMode.Fill);
            dgvTimeTable.AddDataGridViewTextBoxColumn(Resources.ShiftStart,DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn(Resources.ShiftEnd,DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewButtonColumn(DraculaColor.Red);

            dgvTimeTable.Font = GoogleFont.OpenSans;
            dgvTimeTable.ForeColor = DraculaColor.Background;
            dgvTimeTable.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvTimeTable.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

            FillTimeTableGrid();
        }

        private void FillTimeTableGrid()
        {
            _tables = _employee?.GetSchedule();
            
            dgvTimeTable.Rows.Clear();

            for (var i = 0; i < _tables?.Count; i++)
            {
                dgvTimeTable.Rows.Add(new DataGridViewRow());

                dgvTimeTable.Rows[i].Cells[Resources.Number].Value = _tables[i].Id;
                dgvTimeTable.Rows[i].Cells[Resources.Date].Value = _tables[i].Date?.Date.ToString("d");
                dgvTimeTable.Rows[i].Cells[Resources.DayOfWeek].Value = _tables[i].Date?.DayOfWeek;
                dgvTimeTable.Rows[i].Cells[Resources.ShiftStart].Value = _tables[i].TimeStart?.TimeOfDay;
                dgvTimeTable.Rows[i].Cells[Resources.ShiftEnd].Value = _tables[i].TimeEnd?.TimeOfDay;
            }
        }

        private void UpdateEmployeeData()
        {
            foreach (ComboBoxItem item in cbRole.Items)
            {
                if (item != cbRole.SelectedItem)
                    continue;

                var role = _roles.First(x => x.Id == ((Role)item.Tag).Id);
                _employee.RoleId = role.Id;
            }

            _employee.FullName = tbFullName.Text;
            _employee.Login = tbLogin.Text;
            _employee.Password = tbPassword.Text;
        }

        private bool HasErrors()
        {
            var has = false;
            epControls.Clear();

            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                epControls.SetError(tbPassword, Resources.RequiredToFill);
                has = true;
            }

            if (string.IsNullOrWhiteSpace(tbFullName.Text))
            {
                epControls.SetError(tbFullName, Resources.RequiredToFill);
                has = true;
            }

            if (tbLogin.Text.Contains(Resources.Space) || 
                tbLogin.Text.Length < Resources.EmptyPhoneNumber.Length)
            {
                epControls.SetError(tbLogin, Resources.RequiredToFill);
                has = true;
            }

            return has;
        }
        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void AddGridData(object sender, EventArgs e)
        {
            var form = new TimeTableForm(_employee);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            _addedTables.AddRange(form.TimeTables);

            var rows = dgvTimeTable.Rows.Count;
            var tablesToRemove = (from table in _tables
                from formTimeTable in _addedTables
                where table.Date == formTimeTable.Date
                select formTimeTable).ToList();

            foreach (var table in tablesToRemove.Where(table => _addedTables.Contains(table)))
            {
                _addedTables.Remove(table);
            }

            for (int i = rows, j = 0; i < rows + _addedTables.Count; i++, j++)
            {
                dgvTimeTable.Rows.Add(new DataGridViewRow());
                dgvTimeTable.Rows[i].Cells[Resources.Number].Value = dgvTimeTable.Rows.Count;
                dgvTimeTable.Rows[i].Cells[Resources.Date].Value = _addedTables[j].Date?.Date.ToString("d");
                dgvTimeTable.Rows[i].Cells[Resources.DayOfWeek].Value = _addedTables[j].Date?.DayOfWeek;
                dgvTimeTable.Rows[i].Cells[Resources.ShiftStart].Value = _addedTables[j].TimeStart?.TimeOfDay;
                dgvTimeTable.Rows[i].Cells[Resources.ShiftEnd].Value = _addedTables[j].TimeEnd?.TimeOfDay;
            }
        }

        private void RemoveGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvTimeTable.Columns[Resources.Space]?.Index) return;

            var tableId = (int)dgvTimeTable.SelectedRows[0].Cells[Resources.Number].Value;
            var timeTable = _addedTables?.FirstOrDefault(x => x.Id == tableId) ??
                            _tables.FirstOrDefault(x => x.Id == tableId);

            _deletedTables.Add(timeTable);
            dgvTimeTable.Rows.RemoveAt(e.RowIndex);
        }

        private void UpdateEmployeeData(object sender, EventArgs e)
        {
            if (HasErrors())
            {
                CustomMessageBox.ShowDialog(Resources.ControlsEmpty, Caption.Error);
                return;
            }

            UpdateEmployeeData();
            _employee.Update();
            _addedTables?.ForEach(x => x?.Add());
            _deletedTables?.ForEach(x => x?.Delete());
            DialogResult = DialogResult.OK;
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void CloseForm(object sender, EventArgs e)
        {
            if (_employee.HasNullField() ||
                _employee.Login.Contains(Resources.Space) ||
                _employee.Password.Length <= 0 ||
                _employee.FullName.Length <= 0)
                _employee.Delete();
            DialogResult = DialogResult.Cancel;
        }
    }
}
