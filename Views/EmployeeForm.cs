using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Helpers.Structs;
using StretchCeilings.Models;

namespace StretchCeilings.Views
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

        private void SetUpForm()
        {
            btnClose.DialogResult = DialogResult.Cancel;

            SetUpControls();
            SetUpTimeTableGrid();
        }

        private void SetUpControls()
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

        private void FillTimeTableGrid()
        {
            _tables = _employee.GetSchedule();

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

        private void SetUpTimeTableGrid()
        {
            dgvTimeTable.AddDataGridViewTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn(Resources.Date, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn(Resources.DayOfWeek, DataGridViewAutoSizeColumnMode.Fill);
            dgvTimeTable.AddDataGridViewTextBoxColumn(Resources.ShiftStart, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn(Resources.ShiftEnd, DataGridViewAutoSizeColumnMode.DisplayedCells);
            
            dgvTimeTable.Font = GoogleFont.OpenSans;
            dgvTimeTable.ForeColor = DraculaColor.Background;
            dgvTimeTable.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvTimeTable.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

            FillTimeTableGrid();
        }

        private void OpenEditForm()
        {
            this.Hide();
            
            var form = new EmployeeEditForm(_employee);
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                _employee = form.GetEmployee();
                SetUpControls();
                FillTimeTableGrid();
            }

            this.Show();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            SetUpForm();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }
    }
}
