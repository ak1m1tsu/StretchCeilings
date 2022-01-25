using System;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Forms
{
    public partial class ManufacturerForm : Form
    {
        public ManufacturerForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CeilingForm(new Ceiling()).ShowDialog();
        }
    }
}
