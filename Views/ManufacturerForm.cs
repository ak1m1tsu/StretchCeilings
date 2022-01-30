using System;
using System.Windows.Forms;
using StretchCeilings.Models;

namespace StretchCeilings.Views
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
