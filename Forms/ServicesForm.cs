using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility;
using stretch_ceilings_app.Utility.CustomControls;
using stretch_ceilings_app.Utility.Enums;
using stretch_ceilings_app.Utility.Extensions;
using stretch_ceilings_app.Utility.Repositories;

namespace stretch_ceilings_app.Forms
{
    public partial class ServicesForm : Form
    {
        private List<Service> _services;

        private Service _firstFilter;
        private Service _secondFilter;

        private int _rowsCount = 0;
        private int _currentPage = 1;
        private int _maxPage = 1;
        private int _count;

        private readonly bool _forSearching;

        public ServicesForm(bool forSearching = false)
        {
            _forSearching = forSearching;
            InitializeComponent();
        }

        private void SetUpDataGrid()
        {
            _services = ServiceRepository.GetAll(out _rowsCount);

            var idColumn =
                DataGridViewExtensions.CreateDataGridViewTextBoxColumn("№",
                    DataGridViewAutoSizeColumnMode.DisplayedCells);
            var manufacturerColumn =
                DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Производитель",
                    DataGridViewAutoSizeColumnMode.Fill);
            var ceilingColumn =
                DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Потолок", DataGridViewAutoSizeColumnMode.Fill);
            var priceColumn =
                DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Цена",
                    DataGridViewAutoSizeColumnMode.DisplayedCells);
            var delColumn = DataGridViewExtensions.CreateDataGridViewButtonColumn(Constants.DraculaRed);

            dgvServices.Font = Constants.DataGridViewFont;
            dgvServices.DefaultCellStyle.SelectionBackColor = Constants.DraculaSelection;
            dgvServices.DefaultCellStyle.SelectionForeColor = Constants.DraculaForeground;
            dgvServices.Columns.AddRange(idColumn, manufacturerColumn, ceilingColumn, priceColumn, delColumn);
        }

        private void SetUpControls()
        {
            if (UserSession.Can(PermissionCode.AddService) || UserSession.IsAdmin)
            {
                var btnAddService = new FlatButton("btnAddAdditionalService", "Добавить", Constants.DraculaAlphaGreen);
                btnAddService.Click += AddService;
                panelUserButtons.Controls.Add(btnAddService);
            }
        }

        private void FillDataGrid()
        {
            dgvServices.Rows.Clear();

            for (int i = 0; i < _services?.Count; i++)
            {
                dgvServices.Rows.Add(new DataGridViewRow() { Resizable = DataGridViewTriState.False });

                dgvServices.Rows[i].Cells[0].Value = _services[i].Id;
                dgvServices.Rows[i].Cells[1].Value = _services[i].Manufacturer?.Name;
                dgvServices.Rows[i].Cells[2].Value = _services[i].Ceiling?.Name;
                dgvServices.Rows[i].Cells[3].Value = _services[i].Price;
            }

            _maxPage = (int)Math.Ceiling((double)_rowsCount / _count);
            UpdatePageTextBox();
        }

        private void FilterDataGrid()
        {
            if (nudTotalFrom.Value > nudTotalTo.Value)
            {
                CustomMessageBox.Show("Неверно указан диапозон цен.", Constants.ErrorCaption);
                return;
            }

            _services = ServiceRepository.GetAll(
                _firstFilter, 
                _secondFilter, 
                _count, 
                _currentPage, 
                out _rowsCount);

            FillDataGrid();
        }

        private void ResetFilters()
        {
            _firstFilter = new Service();
            _secondFilter = new Service();

            nudTotalFrom.Value = Constants.DefaultNumericUpDownValue;
            nudTotalTo.Value = Constants.DefaultNumericUpDownValue;
            linkLblManufacturer.Text = Constants.DefaultLinkLabelText;
            cbCeiling.Items.Clear();

            _services = ServiceRepository.GetAll(out _rowsCount);

            FillDataGrid();
        }

        private void UpdatePageTextBox()
        {
            tbPages.Text = $"{_currentPage} / {_maxPage}";
        }

        private void UpdateComboBoxRow()
        {
            _currentPage = 1;
            _count = int.Parse(cbRows.Items?[cbRows.SelectedIndex].ToString());
            FilterDataGrid();
        }

        private void TakeNextPage()
        {
            if (_currentPage < _maxPage)
            {
                _currentPage++;
                UpdatePageTextBox();
                FilterDataGrid();
            }
        }

        private void TakePreviousPage()
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                UpdatePageTextBox();
                FilterDataGrid();
            }
        }

        private void AddService(object sender, EventArgs e)
        {
            var service = new ServiceFormEdit(new Service(), true);
            if (service.DialogResult == DialogResult.OK)
                FilterDataGrid();
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            _firstFilter = new Service();
            _secondFilter = new Service();

            SetUpDataGrid();
            SetUpControls();
        }

        private void btnUseFilters_Click(object sender, EventArgs e)
        {
            FilterDataGrid();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            ResetFilters();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            TakePreviousPage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            TakeNextPage();
        }

        private void cbRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBoxRow();
        }

        private void nudTotalTo_ValueChanged(object sender, EventArgs e)
        {
            _secondFilter.Price = nudTotalTo.Value;
        }

        private void nudTotalFrom_ValueChanged(object sender, EventArgs e)
        {
            _firstFilter.Price = nudTotalFrom.Value;
        }

        private void cbCeiling_SelectedIndexChanged(object sender, EventArgs e)
        {
            _firstFilter.Ceiling = (Ceiling)cbCeiling.Items[cbCeiling.SelectedIndex];
        }

        private void linkLblManufacturer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new ManufacturersForm(true);
            if (form.ShowDialog() == DialogResult.OK)
            {
                linkLblManufacturer.Text = form.Manufacturer?.Name;
                _firstFilter.ManufacturerId = form.Manufacturer?.Id;
                _firstFilter.Manufacturer = form.Manufacturer;

                cbCeiling.Items.Clear();

                foreach (var ceiling in form.Manufacturer?.GetCeilings())
                {
                    cbCeiling.Items.Add(new ComboBoxItem(){Tag = ceiling, Name = ceiling.Name});
                }
            }
        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
