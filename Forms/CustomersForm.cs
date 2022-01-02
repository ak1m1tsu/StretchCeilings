using System;
using System.Windows.Forms;

namespace stretch_ceilings_app.Forms
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CustomerForm().ShowDialog();
        }
    }
}
