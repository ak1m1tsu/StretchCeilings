using System;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Helpers.Structs;
using StretchCeilings.Models;
using StretchCeilings.Repositories;

namespace StretchCeilings.Views
{
    public partial class CustomerForm : Form
    {
        private readonly Customer _customer;

        public CustomerForm(Customer customer)
        {
            _customer = customer;
            InitializeComponent();
        }

        private void SetupForm()
        {
            lblFullNameValue.Text = _customer.FullName;
            lblPhoneNumberValue.Text = _customer.PhoneNumber;

            if(CanUserEdit())
                ShowEditButton();
            
            SetupGrid();
        }

        private void SetupGrid()
        {
            var estates = _customer.GetEstates();

            dgvEstates.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEstates.AddDataGridViewTextBoxColumn("Адресс", DataGridViewAutoSizeColumnMode.Fill);

            dgvEstates.Font = GoogleFont.OpenSans;
            dgvEstates.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvEstates.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

            for (var i = 0; i < estates?.Count; i++)
            {
                dgvEstates.Rows.Add(new DataGridViewRow());

                dgvEstates.Rows[i].Cells[0].Value = estates[i].Id;
                dgvEstates.Rows[i].Cells[1].Value = estates[i].Address;
            }
        }

        private static bool CanUserEdit() => UserSession.IsAdmin || UserSession.Can(PermissionCode.EditCustomer);

        private void ShowEditButton()
        {
            btnChangeInfo.Visible = false;
        }

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
            if (e.RowIndex < 0 && dgvEstates.SelectedRows.Count < 0)
                return;

            var id = (int)dgvEstates.Rows[e.RowIndex].Cells[0].Value;
            var estate = EstateRepository.GetById(id);
            var form = new EstateForm(estate);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
