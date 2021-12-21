using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace stretch_ceilings_app
{
    public partial class FactoryOrderForm : Form
    {
        public FactoryOrderForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FactoryForm().ShowDialog();
        }
    }
}
