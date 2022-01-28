using System.Windows.Forms;
using StretchCeilingsApp.Data.Models;
using StretchCeilingsApp.Utility.Extensions;

namespace StretchCeilingsApp.Forms
{
    public partial class CeilingForm : Form
    {
        private Ceiling _ceiling;

        public CeilingForm(Ceiling ceiling)
        {
            _ceiling = ceiling;
            InitializeComponent();
        }

        private void SetUpForm()
        {
            lblTextureValue.Text = _ceiling.TextureType?.ParseString();
            lblColorTypeValue.Text = _ceiling.ColorType?.ParseString();
            lblPriceValue.Text = _ceiling.Price.ToString();
        }

        private void OpenEditForm()
        {
            var form = new CeilingFormEdit(_ceiling);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _ceiling = form.Ceiling;
                SetUpForm();
            }
        }

        private void CeilingForm_Load(object sender, System.EventArgs e)
        {
            SetUpForm();
        }

        private void btnEditInfo_Click(object sender, System.EventArgs e)
        {
            OpenEditForm();
        }
    }
}
