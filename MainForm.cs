using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SQLite;

namespace stretch_ceilings_app
{
    public partial class MainForm : Form
    {
        private Form activeForm;
        private SQLiteConnection sqLiteConnection;

        public MainForm()
        {
            new LoginForm().ShowDialog();
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrdersForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomersForm());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FactoryOrdersForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeesForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ServicesForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FactoriesForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
