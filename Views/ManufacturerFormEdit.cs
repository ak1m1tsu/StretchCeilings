using System.Windows.Forms;
using StretchCeilings.Models;

namespace StretchCeilings.Views
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
