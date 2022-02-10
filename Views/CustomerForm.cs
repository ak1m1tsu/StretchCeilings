using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Helpers.Structs;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class CustomerForm : Form
    {
        private Customer _customer;
        private readonly FormState _state;
        private List<Estate> _estates;

        public CustomerForm(Customer customer, FormState state = FormState.Default)
        {
            _customer = customer;
            _state = state;
            InitializeComponent();
        }

        private void SetupForm()
        {
            lblFullNameValue.Text = _customer.FullName;
            lblPhoneNumberValue.Text = _customer.PhoneNumber;

            if (_state == FormState.ForView)
                btnEdit.Visible = false;

            if (CanUserEdit())
                btnEdit.Enabled = true;
            
            SetupGrid();
        }

        private void SetupGrid()
        {
            _estates = _customer.GetEstates();

            dgvEstates.AddDataGridViewTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEstates.AddDataGridViewTextBoxColumn("Адресс", DataGridViewAutoSizeColumnMode.Fill);

            dgvEstates.Font = GoogleFont.OpenSans;
            dgvEstates.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvEstates.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

            for (var i = 0; i < _estates?.Count; i++)
            {
                dgvEstates.Rows.Add(new DataGridViewRow());

                dgvEstates.Rows[i].Cells[0].Value = dgvEstates.Rows.Count;
                dgvEstates.Rows[i].Cells[1].Value = _estates[i].Address;
            }
        }

        private void ReSetupForm()
        {
            lblFullNameValue.Text = _customer.FullName;
            lblPhoneNumberValue.Text = _customer.PhoneNumber;

            _estates = _customer.GetEstates();

            dgvEstates.Rows.Clear();

            for (var i = 0; i < _estates?.Count; i++)
            {
                dgvEstates.Rows.Add(new DataGridViewRow());

                dgvEstates.Rows[i].Cells[0].Value = dgvEstates.Rows.Count;
                dgvEstates.Rows[i].Cells[1].Value = _estates[i].Address;
            }
        }

        private static bool CanUserEdit() => UserSession.IsAdmin || UserSession.Can(PermissionCode.EditCustomer);
        
        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            this.Handle.DragMove(e);
        }

        private void ShowGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = (int)dgvEstates.Rows[e.RowIndex].Cells[0].Value;
            var estate = _estates[index - 1];
            new EstateForm(estate).ShowDialog();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void OpenEditForm(object sender, EventArgs e)
        {
            var form = new CustomerEditForm(_customer);
            if (form.ShowDialog() != DialogResult.OK) 
                return;

            _customer = form.GetCustomer();
            ReSetupForm();
        }
    }
}
