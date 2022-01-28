using System.Windows.Forms;
using StretchCeilingsApp.Data.Models;

namespace StretchCeilingsApp.Forms
{
    public partial class ManufacturerFormEdit : Form
    {
        private readonly Manufacturer _manufacturer;
        public ManufacturerFormEdit(Manufacturer manufacturer)
        {
            _manufacturer = manufacturer;
            InitializeComponent();
        }

        private void btnAddCeiling_Click(object sender, System.EventArgs e)
        {

        }
    }
}
