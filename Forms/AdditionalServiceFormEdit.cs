using System;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Forms
{
    public partial class AdditionalServiceFormEdit : Form
    {
        private readonly AdditionalService _currentService;
        private readonly bool _isNew;

        public AdditionalServiceFormEdit(AdditionalService service, bool isNew = false)
        {
            _currentService = service;
            _isNew = isNew;
            InitializeComponent();
        }

        private void SetUpForm()
        {
            nudPrice.Maximum = decimal.MaxValue;
            nudPrice.Value = Convert.ToDecimal(_currentService.Price);

            tbName.Text = _currentService.Name;
        }

        private void SaveChanges()
        {
            _currentService.Name = tbName.Text;
            _currentService.Price = nudPrice.Value;
            if (_isNew)
            {
                _currentService.Add();
            }
            else
            {
                _currentService.Update();
            }
            DialogResult = DialogResult.OK;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void AdditionalServiceFormEdit_Load(object sender, EventArgs e)
        {
            SetUpForm();
        }
    }
}
