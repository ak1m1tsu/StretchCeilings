using System;
using System.Windows.Forms;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.Enums;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility.Repositories;

namespace stretch_ceilings_app.Forms
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
            _currentService = AdditionalServiceRepository.GetById(_currentService.Id);

            lblNameValue.Text = _currentService?.Name;
            lblPriceValue.Text = _currentService?.Price?.ToString();
        }

        private void SetUpForm()
        {
            if (UserSession.Can(PermissionCode.EditService) || UserSession.IsAdmin())
                btnChange.Visible = true;

            lblNameValue.Text = _currentService?.Name;
            lblPriceValue.Text = _currentService?.Price?.ToString();
        }

        private void Edit()
        {
            if (new AdditionalServiceFormEdit(_currentService).ShowDialog() == DialogResult.OK)
                ReSetUpForm();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void AdditionalServiceForm_Load(object sender, EventArgs e)
        {
            SetUpForm();
        }
    }
}
