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
using StretchCeilings.Properties;
using StretchCeilings.Repositories;

namespace StretchCeilings.Views
{
    public partial class EmployeeFormEdit : Form
    {
        private readonly Employee _employee;

        private List<TimeTable> _tables;
        private List<ComboBoxItem> _roles;

        public EmployeeFormEdit(Employee employee)
        {
            _employee = employee;
            InitializeComponent();
        }

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

            foreach (var item in RoleModelsRepository.GetAll().Select(role => new ComboBoxItem() { Name = role.Name, Tag = role }))
            {
                _roles.Add(item);
                cbRole.Items.Add(item.Name);
            }

            cbRole.SelectedItem = cbRole.Items[2];
            tbFullName.Text = _employee?.FullName;

            SetUpTimeTableGrid();
            UpdateEmployeeFields();

            _employee?.Add();
        }

        private void SetUpTimeTableGrid()
        {
            dgvTimeTable.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn("Дата",DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn("День недели",DataGridViewAutoSizeColumnMode.Fill);
            dgvTimeTable.AddDataGridViewTextBoxColumn("Начало",DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn("Конец",DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewButtonColumn(Constants.DraculaRed);

            dgvTimeTable.Font = Constants.DataGridViewFont;
            dgvTimeTable.ForeColor = Constants.DraculaBackground;
            dgvTimeTable.DefaultCellStyle.SelectionBackColor = Constants.DraculaSelection;
            dgvTimeTable.DefaultCellStyle.SelectionForeColor = Constants.DraculaForeground;

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

        private void UpdateEmployeeFields()
        {
            if (cbRole.SelectedItem != null)
            {
                var role = (Role)_roles.First(x => x.Name == (string)cbRole.SelectedItem).Tag;
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

            if (tbPassword.Text == "")
            {
                epControls.SetError(tbPassword, "Это поле обязательно к заполнению.");
                hasErrors = true;
            }

            if (tbFullName.Text == "")
            {
                epControls.SetError(tbFullName, "Это поле обязательно к заполнению.");
                hasErrors = true;
            }

            if (tbLogin.Text == Resources.defaultPhoneNumberText || tbLogin.Text.Contains(" "))
            {
                epControls.SetError(tbLogin, "Это поле обязательно к заполнению.");
                hasErrors = true;
            }

            return hasErrors;
        }

        private void UpdateEmployee()
        {
            if (CanUpdate())
            {
                CustomMessageBox.Show("Не все поля заполнены.", Constants.ErrorCaption);
                return;
            }

            UpdateEmployeeFields();
            _employee.Update();
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
            var timeTable = new TimeTableForm(_employee);
            if (timeTable.ShowDialog() == DialogResult.OK)
                FillTimeTableGrid();;
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
            this.Handle.DragMove(e);
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
