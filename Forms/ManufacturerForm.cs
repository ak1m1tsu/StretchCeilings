using System;
using System.Windows.Forms;
using StretchCeilingsApp.Data.Models;

namespace StretchCeilingsApp.Forms
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
