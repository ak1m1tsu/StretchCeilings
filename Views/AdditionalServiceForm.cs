using System;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Models;
using StretchCeilings.Repositories;

namespace StretchCeilings.Views
{
    public partial class AdditionalServiceForm : Form
    {
        private AdditionalService _currentService;

        public AdditionalServiceForm(AdditionalService service)
        {
            _currentService = service;
            InitializeComponent();
        }

        private void ReSetUpForm()
        {
            _currentService = AdditionalServiceModelsRepository.GetById(_currentService.Id);

            lblNameValue.Text = _currentService?.Name;
            lblPriceValue.Text = _currentService?.Price?.ToString();
        }

        private void SetUpForm()
        {
            if (UserSession.Can(PermissionCode.EditService) || UserSession.IsAdmin)
                btnChange.Visible = true;

            lblNameValue.Text = _currentService?.Name;
            lblPriceValue.Text = _currentService?.Price?.ToString();
        }

        private void Edit()
        {
            Hide();
            if (new AdditionalServiceEditForm(_currentService).ShowDialog() == DialogResult.OK)
                ReSetUpForm();
            Show();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void AdditionalServiceForm_Load(object sender, EventArgs e)
        {
            SetUpForm();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
