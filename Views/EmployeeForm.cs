using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Models;
using StretchCeilings.Repositories;

namespace StretchCeilings.Views
{
    public partial class EmployeeForm : Form
    {
        private readonly Employee _employee;
        private List<TimeTable> _tables;

        public EmployeeForm(Employee employee)
        {
            _employee = employee;
            InitializeComponent();
        }

        private void SetUpForm()
        {
            if (UserSession.IsAdmin)
            {
                lblLogin.Visible = true;
                lblLoginValue.Visible = true;
                lblPassword.Visible = true;
                lblPasswordValue.Visible = true;

                lblLoginValue.Text = _employee.Login;
                lblPasswordValue.Text = _employee.Password;
            }

            lblNameValue.Text = _employee?.FullName;
            lblRoleValue.Text = _employee?.Role?.Name;

            btnClose.DialogResult = DialogResult.Cancel;

            SetUpTimeTableGrid();
        }

        private void FillTimeTableGrid()
        {
            _tables = TimeTableModelsRepository.GetByEmployeeId(_employee.Id);

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

        private void SetUpTimeTableGrid()
        {
            dgvTimeTable.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn("Дата", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn("День недели", DataGridViewAutoSizeColumnMode.Fill);
            dgvTimeTable.AddDataGridViewTextBoxColumn("Начало", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn("Конец", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewButtonColumn(Constants.DraculaRed);

            dgvTimeTable.Font = Constants.DataGridViewFont;
            dgvTimeTable.ForeColor = Constants.DraculaBackground;
            dgvTimeTable.DefaultCellStyle.SelectionBackColor = Constants.DraculaSelection;
            dgvTimeTable.DefaultCellStyle.SelectionForeColor = Constants.DraculaForeground;

            FillTimeTableGrid();
        }

        private void RemoveGridRow(DataGridViewCellEventArgs @event)
        {
            if (@event.RowIndex < 0 || @event.ColumnIndex != dgvTimeTable.Columns[" "]?.Index) return;

            TimeTableModelsRepository.GetById((int)dgvTimeTable.SelectedRows[0].Cells["№"].Value).Delete();

            FillTimeTableGrid();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            SetUpForm();
        }

        private void dgvTimeTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RemoveGridRow(e);
        }
    }
}
