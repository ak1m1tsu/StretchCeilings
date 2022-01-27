using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Forms
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
