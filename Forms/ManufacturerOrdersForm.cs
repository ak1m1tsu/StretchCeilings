using System;
using System.Windows.Forms;

namespace stretch_ceilings_app.Forms
{
    public partial class ManufacturerOrdersForm : Form
    {
        public ManufacturerOrdersForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ManufacturerOrderForm().ShowDialog();
        }
    }
}
