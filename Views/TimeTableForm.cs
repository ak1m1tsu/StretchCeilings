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
        private List<CheckBox> _cbDays;

        public List<TimeTable> TimeTables { get; } 

        public TimeTableForm(Employee employee)
        {
            _employee = employee;
            TimeTables = new List<TimeTable>();
            InitializeComponent();
        }

        private void SetUpForm()
        {
            panelRepeat.Enabled = false;
            dtpDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dtpStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            dtpEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 0, 0);

            cbMo.Tag = DayOfWeek.Monday;
            cbTu.Tag = DayOfWeek.Tuesday;
            cbWe.Tag = DayOfWeek.Wednesday;
            cbTh.Tag = DayOfWeek.Thursday;
            cbFr.Tag = DayOfWeek.Friday;
            cbSa.Tag = DayOfWeek.Saturday;
            cbSu.Tag = DayOfWeek.Sunday;

            _cbDays = new List<CheckBox>() { cbMo, cbTu,cbWe, cbTh, cbFr, cbSa,cbSu };
        }

        private bool IsRepeated()
        {
            return cbRepeat.Checked;
        }

        private void EnablePanel()
        {
            panelRepeat.Enabled = true;
        }

        private void DisablePanel()
        {
            panelRepeat.Enabled = false;
        }

        private void AddSingleTimeTable()
        {
            TimeTables.Add(new TimeTable()
            {
                Date = dtpDate.Value,
                TimeStart = dtpStart.Value,
                TimeEnd = dtpEnd.Value,
                EmployeeId = _employee.Id
            });
        }

        private void AddSomeTimeTables()
        {
            var weeks = Convert.ToInt32(nudWeeksValue.Value);
            var currentDate = dtpDate.Value;
            var lastDate = dtpDate.Value.AddDays(weeks * 7);
            var selectedDays = (from checkBox in _cbDays where checkBox.Checked select (DayOfWeek)checkBox.Tag).ToList();
            while (currentDate < lastDate)
            {
                if (selectedDays.Contains(currentDate.DayOfWeek))
                {
                    TimeTables.Add(new TimeTable()
                    {
                        EmployeeId = _employee.Id,
                        Date = currentDate,
                        TimeStart = dtpStart.Value,
                        TimeEnd = dtpEnd.Value
                    });
                }
                currentDate = currentDate.AddDays(1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(IsRepeated() == false)
                AddSingleTimeTable();
            else
                AddSomeTimeTables();
            
            DialogResult = DialogResult.OK;
        }

        private void cbRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRepeat.Checked)
                EnablePanel();
            else
                DisablePanel();
        }

        private void TimeTableForm_Load(object sender, EventArgs e)
        {
            SetUpForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }
    }
}
