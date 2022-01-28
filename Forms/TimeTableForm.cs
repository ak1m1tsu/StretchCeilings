using System;
using System.Windows.Forms;
using StretchCeilingsApp.Data.Models;

namespace StretchCeilingsApp.Forms
{
    public partial class TimeTableForm : Form
    {
        private readonly Employee _currentEmployee;

        public TimeTableForm(Employee employee)
        {
            _currentEmployee = employee;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
