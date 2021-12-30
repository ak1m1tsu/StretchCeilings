using System;
using System.Windows.Forms;

namespace stretch_ceilings_app.Models
{
    public partial class SheduleForm : Form
    {
        private Employee _currentEmployee;

        public SheduleForm(Employee employee)
        {
            _currentEmployee = employee;
            InitializeComponent();
        }

        private void SaveShedule()
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
