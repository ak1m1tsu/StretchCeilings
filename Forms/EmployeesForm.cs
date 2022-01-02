using System;
using System.Windows.Forms;

namespace stretch_ceilings_app.Forms
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EmployeeForm().ShowDialog();
        }
    }
}
