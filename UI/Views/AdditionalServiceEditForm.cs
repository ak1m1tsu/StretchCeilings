using System;
using System.Windows.Forms;
using StretchCeilings.Domain.Models;
using StretchCeilings.UI.Extensions;
using StretchCeilings.UI.Structs;

namespace StretchCeilings.UI.Views
{
    public partial class AdditionalServiceEditForm : Form
    {
        private readonly AdditionalService _additionalService;

        public AdditionalServiceEditForm(AdditionalService service = null)
        {
            _additionalService = service;

            if (_additionalService == null)
            {
                _additionalService = new AdditionalService();
                _additionalService.Add();
            }

            InitializeComponent();
        }

        private void SetUpForm()
        {
            nudPrice.Maximum = decimal.MaxValue;
            nudPrice.Value = Convert.ToDecimal(_additionalService.Price);

            tbName.Text = _additionalService.Name;
        }

        private bool CanUpdate()
        {
            var can = true;

            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                errorProvider.SetError(tbName, Resources.RequiredToFill);
                can = false;
            }

            if (nudPrice.Value < 0)
            {
                errorProvider.SetError(nudPrice, Resources.RequiredToFill);
                can = false;
            }

            return can;
        }

        private void UpdateFields()
        {
            _additionalService.Name = tbName.Text;
            _additionalService.Price = nudPrice.Value;
        }

        private void UpdateData(object sender, EventArgs e)
        {
            if (CanUpdate() == false)
            {
                FlatMessageBox.ShowDialog(Resources.ControlsEmpty, Caption.Error);
                return;
            }

            UpdateFields();
            _additionalService.Update();

            DialogResult = DialogResult.OK;
        }

        private void LoadForm(object sender, EventArgs e)
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
