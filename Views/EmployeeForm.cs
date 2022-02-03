using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Models;
using StretchCeilings.Repositories;

namespace StretchCeilings.Views
{
    public partial class EmployeeForm : Form
    {
        private Employee _employee;
        private List<TimeTable> _tables;

        public EmployeeForm(Employee employee)
        {
            _employee = employee;
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

            lblNameValue.Text = _employee?.FullName;
            lblRoleValue.Text = _employee?.Role?.Name;
        }

        private void FillTimeTableGrid()
        {
            _tables = TimeTableRepository.GetByEmployeeId(_employee.Id);

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

        private void SetUpTimeTableGrid()
        {
            dgvTimeTable.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn("Дата", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn("День недели", DataGridViewAutoSizeColumnMode.Fill);
            dgvTimeTable.AddDataGridViewTextBoxColumn("Начало", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvTimeTable.AddDataGridViewTextBoxColumn("Конец", DataGridViewAutoSizeColumnMode.DisplayedCells);
            
            dgvTimeTable.Font = GoogleFont.OpenSans;
            dgvTimeTable.ForeColor = DraculaColor.Background;
            dgvTimeTable.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvTimeTable.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

            FillTimeTableGrid();
        }

        private void OpenEditForm()
        {
            Hide();
            var form = new EmployeeEditForm(_employee);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _employee = form.GetEmployee();
                SetUpControls();
                FillTimeTableGrid();
            }
            Show();
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
