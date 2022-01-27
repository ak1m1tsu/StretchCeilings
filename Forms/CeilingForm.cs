using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility.Extensions;

namespace stretch_ceilings_app.Forms
{
    public partial class CeilingForm : Form
    {
        private readonly Ceiling _ceiling;

        public CeilingForm(Ceiling ceiling)
        {
            _ceiling = ceiling;
            InitializeComponent();
        }

        private void SetUpForm()
        {
            lblTextureValue.Text = _ceiling.TextureType.ParseString();
            lblColorTypeValue.Text = _ceiling.ColorType.ParseString();
            lblPriceValue.Text = _ceiling.Price.ToString();
        }

        private void OpenEditForm()
        {
            new CeilingFormEdit(_ceiling).ShowDialog();
        }

        private void CeilingForm_Load(object sender, System.EventArgs e)
        {
            SetUpForm();
        }

        private void btnEditInfo_Click(object sender, System.EventArgs e)
        {

        }
    }
}
