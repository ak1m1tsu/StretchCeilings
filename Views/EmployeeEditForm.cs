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
        private readonly Employee _employee;
        private readonly List<Role> _roles;

        private List<TimeTable> _tempTables;
        private List<TimeTable> _tables;

        public EmployeeEditForm(Employee employee)
        {
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

            foreach (var item in RoleRepository.GetAll()
                                                     .Select(role => new ComboBoxItem() { Content = role.Name, Tag = role                                                     }))
            {
                cbRole.Items.Add(item);
            }

            cbRole.DisplayMember = "Content";
            cbRole.SelectedItem = cbRole.Items[cbRole.Items.Count - 1];

            SetUpTimeTableGrid();

            if (_employee.Id != 0) return;

            UpdateEmployeeData();
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
            _tables = _employee?.GetSchedule();
            
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

        private void UpdateEmployeeData()
        {
            foreach (ComboBoxItem item in cbRole.Items)
            {
                if (item != cbRole.SelectedItem) continue;
                var role = _roles.First(x => x.Id == ((Role)item.Tag).Id);
                _employee.RoleId = role.Id;
            }

            _employee.FullName = tbFullName.Text;
            _employee.Login = tbLogin.Text;
            _employee.Password = tbPassword.Text;
        }

        private bool CanUpdate()
        {
            var hasErrors = false;
            epControls.Clear();

            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                epControls.SetError(tbPassword, RequiredToFillOut);
                hasErrors = true;
            }

            if (string.IsNullOrWhiteSpace(tbFullName.Text))
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
        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void AddGridData(object sender, EventArgs e)
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
                dgvTimeTable.Rows[i].Cells["№"].Value = dgvTimeTable.Rows.Count;
                dgvTimeTable.Rows[i].Cells["Дата"].Value = _tempTables[j].Date?.Date.ToString("d");
                dgvTimeTable.Rows[i].Cells["День недели"].Value = _tempTables[j].Date?.DayOfWeek;
                dgvTimeTable.Rows[i].Cells["Начало"].Value = _tempTables[j].TimeStart?.TimeOfDay;
                dgvTimeTable.Rows[i].Cells["Конец"].Value = _tempTables[j].TimeEnd?.TimeOfDay;
            }
        }

        private void RemoveGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvTimeTable.Columns[" "]?.Index) return;

            TimeTableRepository.GetById((int)dgvTimeTable.SelectedRows[0].Cells["№"].Value).Delete();

            FillTimeTableGrid();
        }

        private void UpdateEmployeeData(object sender, EventArgs e)
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

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void SetEmployeeFullName(object sender, EventArgs e)
        {
            _employee.FullName = tbFullName.Text;
        }

        private void SetEmployeeRole(object sender, EventArgs e)
        {
            foreach (ComboBoxItem item in cbRole.Items)
            {
                if (item == cbRole.SelectedItem) _employee.RoleId = ((Role)item.Tag).Id;
            }
        }

        private void SetEmployeePassword(object sender, EventArgs e)
        {
            _employee.Password = tbPassword.Text;
        }

        private void SetEmployeeLogin(object sender, EventArgs e)
        {
            _employee.Login = tbLogin.Text;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            if (_employee.Login.Contains(" ") || _employee.Password.Length <= 0 || _employee.FullName.Length <= 0)
                _employee.Delete();
            DialogResult = DialogResult.Cancel;
        }
    }
}
