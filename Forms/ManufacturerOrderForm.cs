using System.Windows.Forms;

namespace stretch_ceilings_app.Forms
{
    public partial class ManufacturerOrderForm : Form
    {
        public ManufacturerOrderForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ManufacturerForm().ShowDialog();
        }
    }
}
