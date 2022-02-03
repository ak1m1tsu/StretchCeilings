using System;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Enums;
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

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void SetupForm(object sender, EventArgs e)
        {
            if (HasUserPermissions() == false)
                btnEditInfo.Visible = false;
            
            lblTextureValue.Text = _ceiling.TextureType?.ParseString();
            lblColorTypeValue.Text = _ceiling.ColorType?.ParseString();
            lblPriceValue.Text = _ceiling.Price.ToString();
            
            btnClose.DialogResult = DialogResult.Cancel;
            btnEditInfo.Click += OpenEditForm;
            
            panelTop.MouseDown += DragMove;
        }

        private bool HasUserPermissions()
        {
            return UserSession.IsAdmin || UserSession.Can(PermissionCode.EditManufacturer);
        }

        private void OpenEditForm(object sender, EventArgs e)
        {
            this.Hide();

            var form = new CeilingEditForm(_ceiling);

            if (form.ShowDialog() == DialogResult.OK)
            {
                _ceiling = form.GetCeiling();
                _ceiling.Update();
                SetupForm(sender, e);
            }

            this.Show();
        }
    }
}
