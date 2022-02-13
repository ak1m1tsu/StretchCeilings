using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Extensions;
using StretchCeilings.Extensions.Controls;
using StretchCeilings.Models;
using StretchCeilings.Models.Enums;
using StretchCeilings.Sessions;
using StretchCeilings.Structs;
using StretchCeilings.Views.Enums;

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

            dgvEstates.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEstates.CreateTextBoxColumn("Адресс", DataGridViewAutoSizeColumnMode.Fill);

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
            Handle.DragMove(e);
        }

        private void ShowGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvEstates.Rows[e.RowIndex].Cells[0].Value);
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
