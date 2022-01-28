using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilingsApp.Data.Models;
using StretchCeilingsApp.Utility;
using StretchCeilingsApp.Utility.Controls;
using StretchCeilingsApp.Utility.Enums;
using StretchCeilingsApp.Utility.Extensions.Controls;
using StretchCeilingsApp.Utility.Repositories;

namespace StretchCeilingsApp.Forms
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
            _services = ServiceModelsRepository.GetAll(out _rowsCount);

            dgvServices.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvServices.AddDataGridViewTextBoxColumn("Производитель", DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.AddDataGridViewTextBoxColumn("Потолок", DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.AddDataGridViewTextBoxColumn("Цена", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvServices.AddDataGridViewButtonColumn(Constants.DraculaRed);

            dgvServices.Font = Constants.DataGridViewFont;
            dgvServices.DefaultCellStyle.SelectionBackColor = Constants.DraculaSelection;
            dgvServices.DefaultCellStyle.SelectionForeColor = Constants.DraculaForeground;
        }

        private void SetUpControls()
        {
            if (UserSession.Can(PermissionCode.AddService) || UserSession.IsAdmin)
            {
                var btnAddService = new FlatButton("btnAddAdditionalService", "Добавить", AddService, Constants.DraculaAlphaGreen);
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

            _services = ServiceModelsRepository.GetAll(
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

            _services = ServiceModelsRepository.GetAll(out _rowsCount);

            FillDataGrid();
        }

        private void UpdatePageTextBox()
        {
            tbPages.UpdatePagesValue(_currentPage, _maxPage);
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
