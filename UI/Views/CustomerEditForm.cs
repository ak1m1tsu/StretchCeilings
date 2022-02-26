using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StretchCeilings.Domain.Helpers;
using StretchCeilings.Domain.Models;
using StretchCeilings.UI.Extensions;
using StretchCeilings.UI.Structs;
using StretchCeilings.UI.Views.Enums;

namespace StretchCeilings.UI.Views
{
    /// <inheritdoc />
    public partial class CustomerEditForm : Form
    {
        private readonly Customer _customer;
        private List<Estate> _estates;

        /// <inheritdoc />
        public CustomerEditForm(Customer customer = null)
        {
            _customer = customer;
            if (_customer == null)
            {
                _customer = new Customer();
                _customer.Add();
            }
            InitializeComponent();
        }

        public Customer GetCustomer() => _customer;

        private void SetupDataGrid()
        {
            dgvEstates.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvEstates.CreateTextBoxColumn("Адрес", DataGridViewAutoSizeColumnMode.Fill);
            dgvEstates.CreateButtonColumn();

            dgvEstates.Font = GoogleFont.OpenSans;
            dgvEstates.ForeColor = DraculaColor.Background;
            dgvEstates.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvEstates.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;
        }

        private void SetupControls()
        {
            tbFullName.Text = _customer?.FullName;
            mtbPhoneNumber.Text = _customer?.PhoneNumber;
        }

        private void FillDataGrid()
        {
            dgvEstates.Rows.Clear();
            
            for (var i = 0; i < _estates.Count(x => x.DeletedDate == null); i++)
            {
                dgvEstates.Rows.Add(new DataGridViewRow());
                dgvEstates.Rows[i].Cells[0].Value = dgvEstates.Rows.Count;
                dgvEstates.Rows[i].Cells[1].Value = _estates[i].Address;
            }
        }

        private void LoadForm(object sender, EventArgs e)
        {
            _estates = _customer?.GetEstates().ToList();
            
            SetupDataGrid();
            SetupControls();
            FillDataGrid();
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (HasErrors())
            {
                FlatMessageBox.ShowDialog(Resources.ControlsEmpty, Caption.Error);
                return;
            }

            _customer.FullName = tbFullName.Text;
            _customer.PhoneNumber = mtbPhoneNumber.Text;
            _customer.Update();
            _estates.ForEach(x => x?.Update());
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
            Handle.DragMove(e);
        }

        private void CloseForm(object sender, EventArgs e)
        {
            if (_customer.HasNullField())
                _customer.Delete();


            DialogResult = DialogResult.Cancel;
        }

        private void AddGridData(object sender, EventArgs e)
        {
            var form = new EstateEditForm(_customer);
            
            if (form.ShowDialog() != DialogResult.OK)
                return;

            _estates = _customer.GetEstates().ToList();
            FillDataGrid();
        }

        private void RemoveGridData(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex < 0 ||
                senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn == false)
                return;

            if (FlatMessageBox.ShowDialog("Вы уверены что хотите удалить данную недвижимость?", Caption.Warning, MessageBoxState.Question) != DialogResult.Yes)
                return;

            var index = Convert.ToInt32(dgvEstates.Rows[e.RowIndex].Cells[0].Value);
            var estate = _estates[index - 1];
            
            estate.DeletedDate = DateTime.Now;
            FillDataGrid();
        }

        private void ShowGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvEstates.Rows[e.RowIndex].Cells[0].Value);
            var estate = _estates[index - 1];
            var form = new EstateEditForm(estate);

            if (form.ShowDialog() == DialogResult.OK)
                _estates[index - 1] = form.GetEstate();
            
            FillDataGrid();
        }
    }
}
