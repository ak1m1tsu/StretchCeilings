using System;
using System.Windows.Forms;
using StretchCeilingsApp.Data.Models;
using StretchCeilingsApp.Utility;

namespace StretchCeilingsApp.Forms
{
    public partial class EmployeeForm : Form
    {
        private readonly Employee _employee;

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
            lblRoleValue.Text = _employee?.Role.Name;

            SetUpTimeTableGrid();
        }

        private static DataGridViewTextBoxColumn CreateDataGridViewTextBoxColumn(
            string name,
            DataGridViewAutoSizeColumnMode sizeColumnMode)
        {
            return new DataGridViewTextBoxColumn() { Name = name, AutoSizeMode = sizeColumnMode };
        }

        private void SetUpTimeTableGrid()
        {
            var timeTables = _employee.GetSchedule();

            var idCol = CreateDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            var dateCol = CreateDataGridViewTextBoxColumn("Дата", DataGridViewAutoSizeColumnMode.Fill);
            var startCol = CreateDataGridViewTextBoxColumn("Начало смены", DataGridViewAutoSizeColumnMode.Fill);
            var endCol = CreateDataGridViewTextBoxColumn("Конец смены", DataGridViewAutoSizeColumnMode.Fill);

            dgvTimeTable.Columns.AddRange(dateCol, startCol, endCol);

            for (var i = 0; i < timeTables?.Count; i++)
            {
                dgvTimeTable.Rows.Add(new DataGridViewRow());

                dgvTimeTable.Rows[i].Cells[0].Value = timeTables[i].Id;
                dgvTimeTable.Rows[i].Cells[1].Value = timeTables[i].Date;
                dgvTimeTable.Rows[i].Cells[2].Value = timeTables[i].TimeStart?.TimeOfDay;
                dgvTimeTable.Rows[i].Cells[3].Value = timeTables[i].TimeEnd?.TimeOfDay;
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            SetUpForm();
        }
    }
}
