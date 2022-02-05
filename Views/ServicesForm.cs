using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Controls;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Helpers.Structs;
using StretchCeilings.Models;
using StretchCeilings.Repositories;

namespace StretchCeilings.Views
{
    public partial class ServicesForm : Form
    {
        private List<Service> _services;

        private Service _service;
        private Service _firstFilter;
        private Service _secondFilter;

        private readonly FormState _state;

        private int _rows;
        private int _count;
        private int _currentPage = 1;
        private int _maxPage = 1;
        
        public ServicesForm(FormState state = FormState.Default)
        {
            _state = state;
            InitializeComponent();
        }

        public Service GetService() => _service;

        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void SetupDataGrid()
        {
            _services = ServiceRepository.GetAll(out _rows);

            dgvServices.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvServices.AddDataGridViewTextBoxColumn("Производитель", DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.AddDataGridViewTextBoxColumn("Потолок", DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.AddDataGridViewTextBoxColumn("Цена", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvServices.AddDataGridViewButtonColumn(DraculaColor.Red);

            dgvServices.Font = GoogleFont.OpenSans;
            dgvServices.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvServices.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

            FillDataGrid();
        }

        private void SetupForm()
        {
            _firstFilter = new Service();
            _secondFilter = new Service();

            if (CanUserAdd())
                DrawAddServiceButton();

            nudTotalFrom.Maximum = decimal.MaxValue;
            nudTotalTo.Maximum = decimal.MaxValue;

            btnResetFilters.FlatAppearance.MouseDownBackColor = DraculaColor.Red;

            foreach (var item in Resources.RowCountItems)
                cbRows.Items.Add(item);
            cbRows.SelectedItem = cbRows.Items[0];
            cbRows.SelectedIndexChanged += UpdateRowCount;

            SetupDataGrid();

            if (IsForSearching())
            {
                dgvServices.CellDoubleClick += SelectService;
                dgvServices.Columns[dgvServices.Columns.Count].Visible = false;
                return;
            }

            dgvServices.CellDoubleClick += ShowGridData;
            dgvServices.CellClick += RemoveGridData;
        }

        private void UpdateRowCount(object sender, EventArgs e)
        {
            _currentPage = 1;
            _count = int.Parse(cbRows.Items?[cbRows.SelectedIndex].ToString());
            FilterDataGrid();
        }

        private void FilterDataGrid()
        {
            if (nudTotalFrom.Value > nudTotalTo.Value)
            {
                CustomMessageBox.Show("Неверно указан диапозон цен.", Caption.Error);
                return;
            }

            _services = ServiceRepository.GetAll(
                _firstFilter,
                _secondFilter,
                _count,
                _currentPage,
                out _rows);

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            dgvServices.Rows.Clear();

            for (var i = 0; i < _services?.Count; i++)
            {
                dgvServices.Rows.Add(new DataGridViewRow());

                dgvServices.Rows[i].Cells[0].Value = _services[i].Id;
                dgvServices.Rows[i].Cells[1].Value = _services[i].Manufacturer?.Name;
                dgvServices.Rows[i].Cells[2].Value = _services[i].Ceiling?.Name;
                dgvServices.Rows[i].Cells[3].Value = _services[i].Price;
            }

            _maxPage = (int)Math.Ceiling((double)_rows / _count);

            UpdatePageTextBox();
        }

        private static bool CanUserAdd() => UserSession.IsAdmin || 
                                            UserSession.Can(PermissionCode.AddService);

        private static bool CanUserDelete() => UserSession.IsAdmin ||
                                               UserSession.Can(PermissionCode.DelService);

        private bool IsForSearching() => _state == FormState.ForSearching;

        private void DrawAddServiceButton()
        {
            var btnAddService = new FlatButton("btnAddAdditionalService", "Добавить", AddService);
            panelUserButtons.Controls.Add(btnAddService);
        }

        private void SelectService(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServices.SelectedRows.Count <= 0 || e.RowIndex < 0)
                return;

            var serviceId = (int)dgvServices.SelectedRows[0].Cells[0].Value;
            _service = ServiceRepository.GetById(serviceId);

            DialogResult = DialogResult.OK;
        }

        private void UpdatePageTextBox()
        {
            if (_maxPage == 0) 
                _currentPage = 0;

            tbPages.UpdatePagesValue(_currentPage, _maxPage);
        }

        private void AddService(object sender, EventArgs e)
        {
            var service = new ServiceEditForm(new Service());

            if (service.ShowDialog() == DialogResult.OK)
                FilterDataGrid();
        }

        private void UserFilters(object sender, EventArgs e)
        {
            FilterDataGrid();
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            _firstFilter = new Service();
            _secondFilter = new Service();

            nudTotalFrom.Value = Resources.DefaultNumericUpDownValue;
            nudTotalTo.Value = Resources.DefaultNumericUpDownValue;
            linkLblManufacturer.Text = Resources.DefaultLinkLabelText;
            cbCeiling.Items.Clear();

            _services = ServiceRepository.GetAll(out _rows);

            FillDataGrid();
        }

        private void ShowPreviousPage(object sender, EventArgs e)
        {
            if (_currentPage <= 1)
                return;

            _currentPage--;
            UpdatePageTextBox();
            FilterDataGrid();
        }

        private void ShowNextPage(object sender, EventArgs e)
        {
            if (_currentPage >= _maxPage)
                return;

            _currentPage++;
            UpdatePageTextBox();
            FilterDataGrid();
        }

        private void SetServiceTotalTo(object sender, EventArgs e)
        {
            _secondFilter.Price = nudTotalTo.Value;
        }

        private void SetServiceTotalFrom(object sender, EventArgs e)
        {
            _firstFilter.Price = nudTotalFrom.Value;
        }

        private void SetServiceCeiling(object sender, EventArgs e)
        {
            foreach (ComboBoxItem item in cbCeiling.Items)
                if (item == cbCeiling.SelectedItem)
                    _firstFilter.Ceiling = (Ceiling)item.Tag;
        }

        private void SetServiceManufacturer(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new ManufacturersForm(FormState.ForSearching);
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

        private void RemoveGridData(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 && dgvServices.SelectedRows.Count < 0)
                return;

            var id = (int)dgvServices.Rows[e.RowIndex].Cells[0].Value;
            var service = ServiceRepository.GetById(id);
            var form = new ServiceForm(service);
            if(form.ShowDialog() == DialogResult.OK)
                FillDataGrid();
        }
    }
}
