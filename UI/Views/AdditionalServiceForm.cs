using System;
using System.Windows.Forms;
using StretchCeilings.App.Services;
using StretchCeilings.DataAccess.Repositories;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Models.Enums;
using StretchCeilings.Domain.Repositories;
using StretchCeilings.UI.Extensions;
using StretchCeilings.UI.Views.Enums;

namespace StretchCeilings.UI.Views
{
    /// <inheritdoc />
    public partial class AdditionalServiceForm : Form
    {
        private readonly IAdditionalServiceRepository _repository;
        private AdditionalService _additionalService;
        private readonly FormState _state;

        /// <inheritdoc />
        public AdditionalServiceForm(AdditionalService additionalService, FormState state = FormState.Default)
        {
            _additionalService = additionalService;
            _repository = new AdditionalServiceRepository();
            _state = state;
            InitializeComponent();
        }

        private static bool CanUserEdit =>
            UserSession.IsAdmin ||
            UserSession.Can(PermissionCode.EditAdditionalService);

        private string PriceString => $"{_additionalService?.Price ?? 0} руб.";

        private void ReSetupForm()
        {
            _additionalService = _repository.FindById(_additionalService.Id);

            lblNameValue.Text = _additionalService?.Name;
            lblPriceValue.Text = PriceString;
        }

        private void SetupForm()
        {
            if (_state == FormState.ForView)
                btnEdit.Visible = false;

            if (CanUserEdit)
                btnEdit.Enabled = true;

            lblNameValue.Text = _additionalService?.Name;
            lblPriceValue.Text = PriceString;
        }

        private void ShowEditForm(object sender, EventArgs e)
        {
            Hide();

            var form = new AdditionalServiceEditForm(_additionalService);

            if (form.ShowDialog() == DialogResult.OK)
                ReSetupForm();

            Show();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
