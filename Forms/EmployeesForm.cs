using System;
using System.Collections.Generic;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility.Repositories;

namespace stretch_ceilings_app.Forms
{
    public partial class EmployeesForm : Form
    {
        private List<Employee> _employees;
        private int _rowsCount;
        private int _currentPage = 1;
        private int _maxPage = 1;

        public Employee Employee;

        public EmployeesForm()
        {
            _employees = EmployeeRepository.GetEmployees();
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
