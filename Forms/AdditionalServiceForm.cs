using System;
using System.Windows.Forms;
using StretchCeilingsApp.Data.Models;
using StretchCeilingsApp.Utility;
using StretchCeilingsApp.Utility.Enums;
using StretchCeilingsApp.Utility.Repositories;

namespace StretchCeilingsApp.Forms
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
