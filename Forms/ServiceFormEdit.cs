using stretch_ceilings_app.Models;
using System;
using System.Windows.Forms;

namespace stretch_ceilings_app.Forms
{
    public partial class ServiceFormEdit : Form
    {
        private Service _currentService;
        public ServiceFormEdit(Service service)
        {
            _currentService = service;
            InitializeComponent();
        }

        private void UpdateServiceInfo()
        {
            _currentService.Manufacturer = (Manufacturer)cbManufacturerValue.SelectedItem;
            _currentService.Ceiling = (Ceiling)cbCeilingValue.SelectedItem;
            _currentService.Price = decimal.Parse(lblPriceValue.Text);
            _currentService.Update();
        }

        private void btnAddAdditServ_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateServiceInfo();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {

        }

        private void btnPerivousPage_Click(object sender, EventArgs e)
        {

        }
    }
}
