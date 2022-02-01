using System;
using System.Windows.Forms;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class CeilingForm : Form
    {
        private Ceiling _ceiling;

        public CeilingForm(Ceiling ceiling)
        {
            _ceiling = ceiling;
            InitializeComponent();
            this.Load += SetupForm;
        }

        private void SetupForm(object sender, EventArgs e)
        {
            lblTextureValue.Text = _ceiling.TextureType?.ParseString();
            lblColorTypeValue.Text = _ceiling.ColorType?.ParseString();
            lblPriceValue.Text = _ceiling.Price.ToString();
            btnEditInfo.Click += OpenEditForm;
        }

        private void OpenEditForm(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CeilingEditForm(_ceiling);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _ceiling = form.GetCeiling();
                SetupForm(sender, e);
            }
            this.Show();
        }
    }
}
