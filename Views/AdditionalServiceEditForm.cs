using System;
using System.Windows.Forms;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class AdditionalServiceEditForm : Form
    {
        private readonly AdditionalService _additionalService;
        private readonly bool _isNew;

        public AdditionalServiceEditForm(AdditionalService service, bool isNew = false)
        {
            _additionalService = service;
            _isNew = isNew;
            InitializeComponent();
        }

        private void SetUpForm()
        {
            nudPrice.Maximum = decimal.MaxValue;
            nudPrice.Value = Convert.ToDecimal(_additionalService.Price);

            tbName.Text = _additionalService.Name;
        }

        private void SaveChanges()
        {
            _additionalService.Name = tbName.Text;
            _additionalService.Price = nudPrice.Value;

            if (_isNew)
            {
                _additionalService.Add();
            }
            else
            {
                _additionalService.Update();
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
