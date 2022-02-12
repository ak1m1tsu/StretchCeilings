using System;
using System.Windows.Forms;
using StretchCeilings.Extensions;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class CeilingForm : Form
    {
        private readonly Ceiling _ceiling;

        public CeilingForm(Ceiling ceiling)
        {
            _ceiling = ceiling;
            
            InitializeComponent();

            Load += SetupForm;
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void SetupForm(object sender, EventArgs e)
        {
            lblTextureValue.Text = _ceiling.TextureType?.ParseString();
            lblColorTypeValue.Text = _ceiling.ColorType?.ParseString();
            lblPriceValue.Text = _ceiling.Price.ToString();
            
            btnClose.DialogResult = DialogResult.Cancel;
            
            panelTop.MouseDown += DragMove;
        }
    }
}
