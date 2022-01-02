using System;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Forms
{
    public partial class TimeTableForm : Form
    {
        private readonly Employee _currentEmployee;

        public TimeTableForm(Employee employee)
        {
            _currentEmployee = employee;
            InitializeComponent();
        }

        private void SaveTimeTable()
        {
            if (cbRepeat.Checked)
            {

            }
            else
            {
                new TimeTable()
                {
                    Date = dtpDateValue.Value,
                    TimeStart = dtpStartValue.Value,
                    TimeEnd = dtpEndValue.Value,
                    Employee = _currentEmployee,
                    EmployeeId = _currentEmployee.Id,
                }.Add();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
