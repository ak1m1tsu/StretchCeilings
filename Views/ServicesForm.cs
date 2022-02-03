using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Controls;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Models;
using StretchCeilings.Repositories;

namespace StretchCeilings.Views
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

        private void SetupDataGrid()
        {
            _services = ServiceRepository.GetAll(out _rowsCount);

            dgvServices.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvServices.AddDataGridViewTextBoxColumn("Производитель", DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.AddDataGridViewTextBoxColumn("Потолок", DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.AddDataGridViewTextBoxColumn("Цена", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvServices.AddDataGridViewButtonColumn(DraculaColor.Red);

            dgvServices.Font = GoogleFont.OpenSans;
            dgvServices.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvServices.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;
        }

        private void SetupControls()
        {
            if (UserSession.Can(PermissionCode.AddService) || UserSession.IsAdmin)
            {
                var btnAddService = new FlatButton("btnAddAdditionalService", "Добавить", AddService);
                panelUserButtons.Controls.Add(btnAddService);
            }

            cbCeiling.DisplayMember = "Content";
        }

        private void FillDataGrid()
        {
            dgvServices.Rows.Clear();

            for (var i = 0; i < _services?.Count; i++)
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
                CustomMessageBox.Show("Неверно указан диапозон цен.", CustomMessageBoxCaption.Error);
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
            if (_maxPage == 0) 
                _currentPage = 0;
            tbPages.UpdatePagesValue(_currentPage, _maxPage);
        }

        private void UpdateComboBoxRow()
        {
            _currentPage = 1;
            _count = int.Parse(cbRows.Items?[cbRows.SelectedIndex].ToString());
            FilterDataGrid();
        }

        private void TakeManufacturer()
        {
            var form = new ManufacturersForm(forSearching: true);
            if (form.ShowDialog() != DialogResult.OK)
                return;
                
            var manufacturer = form.GetManufacturer();

            linkLblManufacturer.Text = manufacturer?.Name;
            _firstFilter.ManufacturerId = manufacturer?.Id;
            _firstFilter.Manufacturer = manufacturer;

            cbCeiling.Items.Clear();

            foreach (var ceiling in manufacturer?.GetCeilings())
            {
                var item = new ComboBoxItem()
                {
                    Content = ceiling.Name,
                    Tag = ceiling
                };
                cbCeiling.Items.Add(item);
            }
        }

        private void ShowNextPage()
        {
            if (_currentPage >= _maxPage)
                return;

            _currentPage++;
            UpdatePageTextBox();
            FilterDataGrid();
        }

        private void ShowPreviousPage()
        {
            if (_currentPage <= 1)
                return;

            _currentPage--;
            UpdatePageTextBox();
            FilterDataGrid();
        }

        private void AddService(object sender, EventArgs e)
        {
            var service = new ServiceEditForm(new Service(), true);
            if (service.DialogResult == DialogResult.OK)
                FilterDataGrid();
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            _firstFilter = new Service();
            _secondFilter = new Service();

            SetupDataGrid();
            SetupControls();
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
            ShowPreviousPage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ShowNextPage();
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
            TakeManufacturer();
        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
