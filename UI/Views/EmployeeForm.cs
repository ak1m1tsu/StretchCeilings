using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StretchCeilings.App.Services;
using StretchCeilings.Domain.Models;
using StretchCeilings.UI.Extensions;
using StretchCeilings.UI.Structs;
using StretchCeilings.UI.Views.Enums;

namespace StretchCeilings.UI.Views
{
    public partial class EmployeeForm : Form
    {
        private readonly FormState _state;

        private Employee _employee;
        private List<TimeTable> _tables;

        public EmployeeForm(Employee employee, FormState state = FormState.Default)
        {
            _employee = employee;
            _state = state;
            InitializeComponent();
        }

        private void SetupForm()
        {
            btnClose.DialogResult = DialogResult.Cancel;

            SetupControls();
            SetupDataGrid();
        }

        private void SetupControls()
        {
            if (UserSession.IsAdmin)
            {
                lblLogin.Visible = true;
                lblLoginValue.Visible = true;
                lblPassword.Visible = true;
                lblPasswordValue.Visible = true;

                lblLoginValue.Text = _employee.Login;
                lblPasswordValue.Text = _employee.Password;

                btnEdit.Visible = true;
            }

            if (_state == FormState.ForView)
                btnEdit.Visible = false;

            lblNameValue.Text = _employee?.FullName;
            lblRoleValue.Text = _employee?.Role?.Name;
        }

        private void FillDataGrid()
        {
            _tables = _employee.GetSchedule().ToList();

            dgvTimeTable.Rows.Clear();

            for (var i = 0; i < _tables?.Count; i++)
            {
                dgvTimeTable.Rows.Add(new DataGridViewRow());

                dgvTimeTable.Rows[i].Cells[Resources.Number].Value = dgvTimeTable.Rows.Count;
                dgvTimeTable.Rows[i].Cells[Resources.Date].Value = _tables[i].Date?.Date.ToString("d");
                dgvTimeTable.Rows[i].Cells[Resources.DayOfWeek].Value = _tables[i].Date?.DayOfWeek;
                dgvTimeTable.Rows[i].Cells[Resources.ShiftStart].Value = _tables[i].TimeStart?.TimeOfDay;
                dgvTimeTable.Rows[i].Cells[Resources.ShiftEnd].Value = _tables[i].TimeEnd?.TimeOfDay;
            }
        }

        private void SetupDataGrid()
        {
            dgvTimeTable.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.CreateTextBoxColumn(Resources.Date, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.CreateTextBoxColumn(Resources.DayOfWeek, DataGridViewAutoSizeColumnMode.Fill);
            dgvTimeTable.CreateTextBoxColumn(Resources.ShiftStart, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.CreateTextBoxColumn(Resources.ShiftEnd, DataGridViewAutoSizeColumnMode.DisplayedCells);
            
            dgvTimeTable.Font = GoogleFont.OpenSans;
            dgvTimeTable.ForeColor = DraculaColor.Background;
            dgvTimeTable.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvTimeTable.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

            FillDataGrid();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void ShowEditForm(object sender, EventArgs e)
        {
            Hide();

            var form = new EmployeeEditForm(_employee);

            if (form.ShowDialog() == DialogResult.OK)
            {
                _employee = form.GetEmployee();
                SetupControls();
                FillDataGrid();
            }

            Show();
        }
    }
}
