using System;
using System.Windows.Forms;

namespace stretch_ceilings_app.Forms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RoomForm().ShowDialog();
        }
    }
}
