using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class TimeTableForm : Form
    {
        private readonly Employee _employee;
        private List<CheckBox> _days;

        public List<TimeTable> TimeTables { get; } 

        public TimeTableForm(Employee employee)
        {
            _employee = employee;
            TimeTables = new List<TimeTable>();
            InitializeComponent();
        }

        private void SetUpForm()
        {
            panelRepeatBody.Enabled = false;
            dtpDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dtpStartTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            dtpEndTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 0, 0);

            cbMonday.Tag = DayOfWeek.Monday;
            cbTuesday.Tag = DayOfWeek.Tuesday;
            cbWednesday.Tag = DayOfWeek.Wednesday;
            cbThursday.Tag = DayOfWeek.Thursday;
            cbFriday.Tag = DayOfWeek.Friday;
            cbSaturday.Tag = DayOfWeek.Saturday;
            cbSunday.Tag = DayOfWeek.Sunday;

            _days = new List<CheckBox>()
            {
                cbMonday,
                cbTuesday,
                cbWednesday,
                cbThursday,
                cbFriday,
                cbSaturday,
                cbSunday
            };
        }

        private bool IsComboBoxRepeatChecked()
        {
            return cbRepeat.Checked;
        }

        private void EnablePanel()
        {
            panelRepeatBody.Enabled = true;
        }

        private void DisablePanel()
        {
            panelRepeatBody.Enabled = false;
        }

        private void AddSingleTimeTable()
        {
            TimeTables.Add(new TimeTable()
            {
                Date = dtpDate.Value,
                TimeStart = dtpStartTime.Value,
                TimeEnd = dtpEndTime.Value,
                EmployeeId = _employee.Id
            });
        }

        private void AddSomeTimeTables()
        {
            var weeks = Convert.ToInt32(numericUpDownWeeks.Value);
            var currentDate = dtpDate.Value;
            var lastDate = dtpDate.Value.AddDays(weeks * 7);
            var selectedDays = (from checkBox in _days where checkBox.Checked select (DayOfWeek)checkBox.Tag).ToList();
            while (currentDate < lastDate)
            {
                if (selectedDays.Contains(currentDate.DayOfWeek))
                {
                    TimeTables.Add(new TimeTable()
                    {
                        EmployeeId = _employee.Id,
                        Date = currentDate,
                        TimeStart = dtpStartTime.Value,
                        TimeEnd = dtpEndTime.Value
                    });
                }

                currentDate = currentDate.AddDays(1);
            }
        }

        private void SaveData(object sender, EventArgs e)
        {
            if(IsComboBoxRepeatChecked() == false)
                AddSingleTimeTable();
            else
                AddSomeTimeTables();
            
            DialogResult = DialogResult.OK;
        }

        private void SwitchRepeatPanelEnable(object sender, EventArgs e)
        {
            if (cbRepeat.Checked)
                EnablePanel();
            else
                DisablePanel();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetUpForm();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }
    }
}
