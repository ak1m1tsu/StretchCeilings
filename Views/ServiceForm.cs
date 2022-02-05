using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Structs;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class ServiceForm : Form
    {
        private readonly Service _service;
        private List<ServiceAdditionalService> _additionalServices;

        public ServiceForm(Service service)
        {
            _service = service;
            InitializeComponent();
        }

        private string PriceString => $@"{_service.Price} {Resources.Rubles}";

        private void SetupForm()
        {
            linkLblManufaturerValue.Text = _service.Manufacturer.Name;
            linkLblManufaturerValue.Tag = _service.Manufacturer;
            linkLblCeilingValue.Text = _service.Ceiling.Name;
            linkLblCeilingValue.Tag = _service.Ceiling;
            lblPriceValue.Text = PriceString;
        }

        private void SetupDataGrid()
        {
             
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();   
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            this.Handle.DragMove(e);
        }
    }
}
