using System;
using System.Windows.Forms;

namespace stretch_ceilings_app.Forms
{
    public partial class ManufacturersForm : Form
    {
        public ManufacturersForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ManufacturerForm().ShowDialog();
        }
    }
}
