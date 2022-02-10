using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Helpers.Structs;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class CustomerEditForm : Form
    {
        private readonly Customer _customer;
        private List<Estate> _estates;
        private List<Estate> _updatedEstates;
        private List<Estate> _addedEstates;
        private List<Estate> _deletedEstates;

        public CustomerEditForm(Customer customer)
        {
            _customer = customer;
            InitializeComponent();
        }

        public Customer GetCustomer() => _customer;

        private void SetupForm()
        {
            tbFullName.Text = _customer?.FullName;
            mtbPhoneNumber.Text = _customer?.PhoneNumber;

            _updatedEstates = new List<Estate>();
            _addedEstates = new List<Estate>();
            _deletedEstates = new List<Estate>();
            _estates = _customer?.GetEstates();

            dgvEstates.AddDataGridViewTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEstates.AddDataGridViewTextBoxColumn("Адресс", DataGridViewAutoSizeColumnMode.Fill);

            dgvEstates.Font = GoogleFont.OpenSans;
            dgvEstates.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvEstates.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

            for (var i = 0; i < _estates?.Count; i++)
            {
                dgvEstates.Rows.Add(new DataGridViewRow());

                dgvEstates.Rows[i].Cells[0].Value = _estates[i].Id;
                dgvEstates.Rows[i].Cells[1].Value = _estates[i].Address;
            }
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (HasErrors())
            {
                CustomMessageBox.ShowDialog(Resources.ControlsEmpty, Caption.Error);
                return;
            }

            _customer.FullName = tbFullName.Text;
            _customer.PhoneNumber = mtbPhoneNumber.Text;
            _customer.Update();
            _addedEstates?.ForEach(x => x?.Add());
            _updatedEstates?.ForEach(x => x?.Add());
            _deletedEstates?.ForEach(x => x.Delete());
            DialogResult = DialogResult.OK;
        }

        private bool HasErrors()
        {
            var has = false;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(tbFullName.Text))
            {
                errorProvider.SetError(tbFullName, Resources.RequiredToFill);
                has = true;
            }

            if (mtbPhoneNumber.Text.Contains(Resources.Space) ||
                mtbPhoneNumber.Text.Length < Resources.EmptyPhoneNumber.Length)
            {
                errorProvider.SetError(mtbPhoneNumber, Resources.RequiredToFill);
                has = true;
            }

            return has;
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
