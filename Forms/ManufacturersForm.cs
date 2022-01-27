using System;
using System.Collections.Generic;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.CustomControls;
using stretch_ceilings_app.Utility.Enums;
using stretch_ceilings_app.Utility.Extensions;
using stretch_ceilings_app.Utility.Repositories;

namespace stretch_ceilings_app.Forms
{
    public partial class ManufacturersForm : Form
    {
        private List<Manufacturer> _manufacturers;

        private readonly bool _forSearching;
        private Manufacturer _manufacturer;
        private Manufacturer _filter;

        private int _rows;
        private int _count;
        private int _currentPage = 1;
        private int _maxPage = 1;

        public Manufacturer Manufacturer => _manufacturer;

        public ManufacturersForm(bool forSearching = false)
        {
            _forSearching = forSearching;
            InitializeComponent();
        }

        private void SetUpControls()
        {
            if (UserSession.IsAdmin || UserSession.Can(PermissionCode.AddCustomer))
            {
                var btnAddManufacturer = new FlatButton("btnAddOrder", "Добавить");
                btnAddManufacturer.Click += btnAddManufacturer_Click;
                panelUserButtons.Controls.Add(btnAddManufacturer);
            }

            foreach (Country country in Enum.GetValues(typeof(Country)))
            {
                if (country == Country.Unknown) continue;
               cbRows.Items.Add(country.ParseString());
            }
            cbCountry.SelectedItem = null;

            foreach (var rowCountItem in Constants.RowCountItems)
                cbRows.Items.Add(rowCountItem);
            cbRows.SelectedItem = cbRows.Items[0];
        }

        private void SetUpDataGrid()
        {
            _manufacturers = ManufacturerRepository.GetAll(out _rows);
            
            var idColumn = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            var nameColumn = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Производитель", DataGridViewAutoSizeColumnMode.Fill);
            var addressColumn = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Адрес", DataGridViewAutoSizeColumnMode.Fill);
            var countryColumn = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Страна", DataGridViewAutoSizeColumnMode.DisplayedCells);
            var delColumn = DataGridViewExtensions.CreateDataGridViewButtonColumn(Constants.DraculaRed);

            dgvManufacturers.Font = Constants.DataGridViewFont;
            dgvManufacturers.DefaultCellStyle.SelectionBackColor = Constants.DraculaSelection;
            dgvManufacturers.DefaultCellStyle.SelectionForeColor = Constants.DraculaForeground;
            dgvManufacturers.Columns.AddRange(idColumn, nameColumn, addressColumn, countryColumn, delColumn);

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            dgvManufacturers.Rows.Clear();

            for (int i = 0; i < _manufacturers?.Count; i++)
            {
                dgvManufacturers.Rows.Add(new DataGridViewRow());

                dgvManufacturers.Rows[i].Cells[0].Value = _manufacturers[i].Id;
                dgvManufacturers.Rows[i].Cells[1].Value = _manufacturers[i].Name;
                dgvManufacturers.Rows[i].Cells[2].Value = _manufacturers[i].Address;
                dgvManufacturers.Rows[i].Cells[3].Value = _manufacturers[i].Country;
            }

            _maxPage = (int)Math.Ceiling((double)_rows / _count);
            SetPages();
        }

        private void FilterDataGrid()
        {
            _manufacturers = ManufacturerRepository.GetAll(
                _filter,
                _count,
                _currentPage,
                out _rows);

            FillDataGrid();
        }
        private void OpenDataGridRowForm()
        {
            if (dgvManufacturers.SelectedRows.Count <= 0) return;

            var customer = CustomerRepository.GetById((int)dgvManufacturers.SelectedRows[0].Cells[0].Value);
            new CustomerForm(customer).ShowDialog();
        }

        private void SetPages()
        {
            tbPages.Text = $"{_currentPage} / {_maxPage}";
        }

        private static void btnAddManufacturer_Click(object sender, EventArgs e)
        {
            new ManufacturerFormEdit(new Manufacturer()).ShowDialog();
        }

        private void btnUserFilters_Click(object sender, EventArgs e)
        {

        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void ManufacturersForm_Load(object sender, EventArgs e)
        {
            _filter = new Manufacturer() { Country = Country.Unknown };
            SetUpDataGrid();
            SetUpControls();
        }

        private void cbRows_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
