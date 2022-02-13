using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Extensions;
using StretchCeilings.Extensions.Controls;
using StretchCeilings.Helpers;
using StretchCeilings.Models;
using StretchCeilings.Repositories;
using StretchCeilings.Sessions;
using StretchCeilings.Structs;
using StretchCeilings.Views.Enums;

namespace StretchCeilings.Views
{
    public partial class EmployeeEditForm : Form
    {
        private readonly Employee _employee;
        private readonly List<Role> _roles;

        private readonly List<TimeTable> _addedTables;
        private readonly List<TimeTable> _deletedTables;
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
            dgvTimeTable.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.CreateTextBoxColumn(Resources.Date,DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.CreateTextBoxColumn(Resources.DayOfWeek,DataGridViewAutoSizeColumnMode.Fill);
            dgvTimeTable.CreateTextBoxColumn(Resources.ShiftStart,DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.CreateTextBoxColumn(Resources.ShiftEnd,DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.CreateButtonColumn();

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
            var tablesToRemove = _tables
                .SelectMany(table => _addedTables, (table, formTimeTable) => new { table, formTimeTable })
                .Where(@t => @t.table.Date == @t.formTimeTable.Date)
                .Select(@t => @t.formTimeTable).ToList();

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
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex < 0 ||
                senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn == false)
                return;

            if (FlatMessageBox.ShowDialog("Вы уверены что хотите удалить этот рабочий день?", Caption.Warning, MessageBoxState.Question) != DialogResult.Yes)
                return;

            var index = Convert.ToInt32(dgvTimeTable.SelectedRows[0].Cells[Resources.Number].Value);
            var timeTable = _addedTables[index - 1] ?? _tables[index - 1];

            _deletedTables.Add(timeTable);
            dgvTimeTable.Rows.RemoveAt(e.RowIndex);
            FlatMessageBox.ShowDialog("Рабочий день успешно удален", Caption.Info);
        }

        private void UpdateEmployeeData(object sender, EventArgs e)
        {
            if (HasErrors())
            {
                FlatMessageBox.ShowDialog(Resources.ControlsEmpty, Caption.Error);
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
