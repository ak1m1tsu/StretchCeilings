using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace stretch_ceilings_app
{
    public partial class FactoryForm : Form
    {
        public FactoryForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ProductForm().ShowDialog();
        }
    }
}
