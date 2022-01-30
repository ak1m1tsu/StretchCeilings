using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Helpers.DLL;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class TimeTableForm : Form
    {
        private readonly Employee _employee;
        private List<CheckBox> _cbDays;

        public TimeTableForm(Employee employee)
        {
            _employee = employee;
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
            new TimeTable()
            {
                Date = dtpDate.Value,
                TimeStart = dtpStart.Value,
                TimeEnd = dtpEnd.Value,
                EmployeeId = _employee.Id
            }.Add();
        }

        private void AddSomeTimeTables()
        {
            var weeks = Convert.ToInt32(nudWeeksValue.Value);
            var currentDate = dtpDate.Value;
            var lastDate = dtpDate.Value.AddDays(weeks * 7);
            var selectedDays = new List<DayOfWeek>();
            foreach (CheckBox checkBox in _cbDays)
            {
                if (checkBox.Checked)
                    selectedDays.Add((DayOfWeek)checkBox.Tag);
            }
            while (currentDate < lastDate)
            {
                if (selectedDays.Contains(currentDate.DayOfWeek))
                {
                    new TimeTable()
                    {
                        EmployeeId = _employee.Id,
                        Date = currentDate,
                        TimeStart = dtpStart.Value,
                        TimeEnd = dtpEnd.Value
                    }.Add();
                }
                currentDate = currentDate.AddDays(1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(IsRepeated() == false)
            {
                AddSingleTimeTable();
                return;
            }
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
            User32.ReleaseCapture();
            User32.SendMessage(Handle, User32.VM_NCLBUTTONDOWN, User32.HT_CAPTION, 0);
        }
    }
}
