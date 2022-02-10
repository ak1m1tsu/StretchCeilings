﻿using System;
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
        private AdditionalService _additionalService;
        private readonly FormState _state;

        public AdditionalServiceForm(AdditionalService additionalService, FormState state = FormState.Default)
        {
            _additionalService = additionalService;
            _state = state;
            InitializeComponent();
        }

        private static bool CanUserEdit =>
            UserSession.IsAdmin ||
            UserSession.Can(PermissionCode.EditAdditionalService);

        private void ReSetupForm()
        {
            _additionalService = AdditionalServiceRepository.GetById(_additionalService.Id);

            lblNameValue.Text = _additionalService?.Name;
            lblPriceValue.Text = _additionalService?.Price?.ToString();
        }

        private void SetupForm()
        {
            if (_state == FormState.ForView)
                btnEdit.Visible = false;

            if (CanUserEdit)
                btnEdit.Enabled = true;

            lblNameValue.Text = _additionalService?.Name;
            lblPriceValue.Text = _additionalService?.Price?.ToString();
        }

        private void ShowEditForm(object sender, EventArgs e)
        {
            this.Hide();

            var form = new AdditionalServiceEditForm(_additionalService);

            if (form.ShowDialog() == DialogResult.OK)
                ReSetupForm();

            this.Show();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            this.Handle.DragMove(e);
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
