﻿using System;
using System.Windows.Forms;
using StretchCeilingsApp.Data.Models;

namespace StretchCeilingsApp.Forms
{
    public partial class ServiceFormEdit : Form
    {
        private readonly Service _currentService;
        private readonly bool _isNew;

        public ServiceFormEdit(Service service, bool isNew = false)
        {
            _currentService = service;
            _isNew = isNew;
            InitializeComponent();
        }

        private void UpdateServiceInfo()
        {
            _currentService.Manufacturer = (Manufacturer)cbManufacturerValue.SelectedItem;
            _currentService.Ceiling = (Ceiling)cbCeilingValue.SelectedItem;
            _currentService.Price = decimal.Parse(lblPriceValue.Text);
            _currentService.Update();
        }

        private void btnAddAdditionalService_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateServiceInfo();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {

        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {

        }

        private void cbCeilingValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
