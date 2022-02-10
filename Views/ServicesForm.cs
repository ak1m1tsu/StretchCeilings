using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Controls;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions;
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
        private int _lastPage = 1;
        
        public ServicesForm(FormState state = FormState.Default)
        {
            _state = state;
            InitializeComponent();
        }

        public Service GetService() => _service;

        private bool IsForSearching => _state == FormState.ForView;

        private static bool CanUserDelete => UserSession.IsAdmin ||
                                             UserSession.Can(PermissionCode.DelService);

        private static bool CanUserAdd => UserSession.IsAdmin ||
                                          UserSession.Can(PermissionCode.AddService);

        private void SetupForm()
        {
            _services = ServiceRepository.GetAll(out _rows);
            _firstFilter = new Service();
            _secondFilter = new Service();

            SetupDataGrid();
            SetupControls();
            FillDataGrid();
        }

        private void SetupDataGrid()
        {
            dgvServices.AddDataGridViewTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvServices.AddDataGridViewTextBoxColumn(Resources.Manufacturer, DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.AddDataGridViewTextBoxColumn(Resources.Ceiling, DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.AddDataGridViewTextBoxColumn(Resources.Price, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvServices.AddDataGridViewButtonColumn(DraculaColor.Red);

            if (CanUserDelete == false)
                dgvServices.Columns[Resources.Space].Visible = false;

            dgvServices.Font = GoogleFont.OpenSans;
            dgvServices.ForeColor = DraculaColor.Background;
            dgvServices.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvServices.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;
        }

        private void SetupControls()
        {
            btnNext.Click += ShowNextPage;
            btnPrevious.Click += ShowPreviousPage;
            btnResetFilters.FlatAppearance.MouseDownBackColor = DraculaColor.Red;
            
            if (CanUserAdd)
                DrawAddServiceButton();

            nudTotalFrom.Maximum = decimal.MaxValue;
            nudTotalTo.Maximum = decimal.MaxValue;

            foreach (var item in Resources.RowCountItems)
                cbRows.Items.Add(item);

            cbRows.SelectedItem = cbRows.Items[0];
            _count = Convert.ToInt32(cbRows.Items[0]);
            cbRows.SelectedIndexChanged += RowCountChanged;

            if (IsForSearching)
            {
                dgvServices.CellDoubleClick += SelectService;
                dgvServices.Columns[Resources.Space].Visible = false;
                panelTopSide.Visible = true;
                return;
            }

            dgvServices.CellDoubleClick += ShowGridData;
            dgvServices.CellClick += RemoveGridData;
        }
        
        private void FillDataGrid()
        {
            dgvServices.Rows.Clear();

            for (var i = 0; i < _services?.Count; i++)
            {
                dgvServices.Rows.Add(new DataGridViewRow());

                dgvServices.Rows[i].Cells[0].Value = dgvServices.Rows.Count;
                dgvServices.Rows[i].Cells[1].Value = _services[i].Manufacturer?.Name;
                dgvServices.Rows[i].Cells[2].Value = _services[i].Ceiling?.Name;
                dgvServices.Rows[i].Cells[3].Value = _services[i].Price;
            }

            UpdateLastPageValue();
            UpdatePageTextBox();
        }

        private void UpdateLastPageValue()
        {
            var result = Math.Ceiling(Convert.ToDouble(_rows) / _count);
            _lastPage = Convert.ToInt32(result);
        }

        private void FilterDataGrid()
        {
            //if (nudTotalFrom.Value > nudTotalTo.Value)
            //{
            //    CustomMessageBox.ShowDialog(Resources.InvalidPriceRange, Caption.Error);
            //    return;
            //}
            
            _services = ServiceRepository.GetAll(
                _firstFilter,
                _secondFilter,
                _count,
                _currentPage,
                out _rows);

            FillDataGrid();
        }

        private void RowCountChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            _count = Convert.ToInt32(cbRows.SelectedItem);
            FilterDataGrid();
        }

        private void DrawAddServiceButton()
        {
            var btnAddService = new FlatButton("btnAddAdditionalService", "Добавить", AddGridData);
            panelUserButtons.Controls.Add(btnAddService);
        }

        private void SelectService(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServices.SelectedRows.Count <= 0 || e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvServices.Rows[e.RowIndex].Cells[0].Value);
            _service = _services[index - 1];

            DialogResult = DialogResult.OK;
        }

        private void UpdatePageTextBox()
        {
            if (_lastPage == 0) 
                _currentPage = 0;

            tbPages.UpdatePagesValue(_currentPage, _lastPage);
        }

        private void AddGridData(object sender, EventArgs e)
        {
            var service = new ServiceEditForm();

            if (service.ShowDialog() == DialogResult.OK)
                FilterDataGrid();
        }
        
        private void ShowPreviousPage(object sender, EventArgs e)
        {
            if (_currentPage <= 1)
                return;

            _currentPage--;
            FilterDataGrid();
        }

        private void ShowNextPage(object sender, EventArgs e)
        {
            if (_currentPage >= _lastPage)
                return;

            _currentPage++;
            FilterDataGrid();
        }

        private void RemoveGridData(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex < 0 ||
                senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn == false)
                return;

            if (CustomMessageBox.ShowDialog("Вы точно хотите удалить данную услугу?", Caption.Warning) != DialogResult.OK)
                return;

            var index = Convert.ToInt32(dgvServices.Rows[e.RowIndex].Cells[0].Value);
            var service = _services[index - 1];
            service.Delete();
            
            FilterDataGrid();
        }

        private void ShowGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvServices.Rows[e.RowIndex].Cells[0].Value);
            var service = _services[index - 1];
            var form = new ServiceForm(service);

            if(form.ShowDialog() == DialogResult.OK)
                FillDataGrid();
        }

        private void UseFilters(object sender, EventArgs e)
        {
            FilterDataGrid();
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            _firstFilter = new Service();
            _secondFilter = new Service();

            nudTotalFrom.Value = Resources.DefaultNumericUpDownValue;
            nudTotalTo.Value = Resources.DefaultNumericUpDownValue;
            linkLblManufacturer.Text = Resources.No;
            cbCeiling.Items.Clear();

            _services = ServiceRepository.GetAll(out _rows);

            FillDataGrid();
        }

        private void SelectManufacturer(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new ManufacturersForm(FormState.ForView);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            var manufacturer = form.GetManufacturer();

            if (manufacturer == null)
                return;

            linkLblManufacturer.Text = manufacturer.Name;
            _firstFilter.ManufacturerId = manufacturer.Id;
            _firstFilter.Manufacturer = manufacturer;

            cbCeiling.Items.Clear();

            foreach (var ceiling in manufacturer.GetCeilings())
            {
                cbCeiling.Items.Add(new ComboBoxItem()
                {
                    Content = ceiling.Name,
                    Tag = ceiling
                });
            }
        }
        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void CeilingChanged(object sender, EventArgs e)
        {
            foreach (ComboBoxItem item in cbCeiling.Items)
                if (item == cbCeiling.SelectedItem)
                    _firstFilter.Ceiling = (Ceiling)item.Tag;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            this.Handle.DragMove(e);
        }

        private void PriceFromChanged(object sender, EventArgs e)
        {
            _firstFilter.Price = nudTotalFrom.Value;
        }

        private void PriceToChanged(object sender, EventArgs e)
        {
            _secondFilter.Price = nudTotalTo.Value;
        }
    }
}
