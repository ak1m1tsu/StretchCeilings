using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using FontAwesome.Sharp;
using StretchCeilings.App.Services;
using StretchCeilings.DataAccess.Repositories;
using StretchCeilings.Domain.Enums;
using StretchCeilings.Domain.Extensions;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Models.Enums;
using StretchCeilings.Domain.Repositories;
using StretchCeilings.UI.Extensions;
using StretchCeilings.UI.Structs;
using StretchCeilings.UI.Views.Controls;
using StretchCeilings.UI.Views.Enums;

namespace StretchCeilings.UI.Views
{
    public partial class ServicesForm : Form
    {
        private readonly IServiceRepository _repository;
        private List<Service> _services;

        private Service _service;
        private Service _firstFilter;
        private Service _secondFilter;

        private readonly FormState _state;
        private SortOption _sortOption;
        private ServiceProperty _property;

        private int _rows;
        private int _count;
        private int _currentPage = 1;
        private int _lastPage = 1;
        
        public ServicesForm(FormState state = FormState.Default)
        {
            _repository = new ServiceRepository();
            _sortOption = SortOption.Descending;
            _state = state;
            InitializeComponent();
        }

        public Service GetService() => _service;

        private bool IsForView => _state == FormState.ForView;

        private static bool CanUserDelete => UserSession.IsAdmin ||
                                             UserSession.Can(PermissionCode.DelService);

        private static bool CanUserAdd => UserSession.IsAdmin ||
                                          UserSession.Can(PermissionCode.AddService);

        private void SetupForm()
        {
            _services = _repository.GetAll().ToList();
            _rows = _services.Count;
            _firstFilter = new Service();
            _secondFilter = new Service();

            SetupDataGrid();
            SetupControls();
            FillDataGrid();
        }

        private void SetupDataGrid()
        {
            dgvServices.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvServices.CreateTextBoxColumn(Resources.Manufacturer, DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.CreateTextBoxColumn(Resources.Ceiling, DataGridViewAutoSizeColumnMode.Fill);
            dgvServices.CreateTextBoxColumn(Resources.Price, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvServices.CreateButtonColumn();

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
            
            FillPropertyComboBox();
            nudTotalFrom.Maximum = decimal.MaxValue;
            nudTotalTo.Maximum = decimal.MaxValue;

            foreach (var item in Resources.RowCountItems)
                cbRows.Items.Add(item);
            cbRows.SelectedItem = cbRows.Items[0];

            if (CanUserAdd && IsForView == false)
                DrawAddServiceButton();

            if (CanUserDelete == false || IsForView)
                dgvServices.Columns[Resources.Space].Visible = false;

            if (IsForView)
            {
                dgvServices.CellDoubleClick += SelectService;
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
            _services = _repository.GetAll(
                _firstFilter,
                _secondFilter,
                _count,
                _currentPage,
                _sortOption,
                _property).ToList();

            _rows = _services.Count;

            FillDataGrid();
        }

        private void DrawAddServiceButton()
        {
            var btnAddService = new FlatButton("btnAddAdditionalService", "Добавить", AddGridData);
            panelUserButtons.Controls.Add(btnAddService);
        }

        private void SelectService(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
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

            if (service.ShowDialog() != DialogResult.OK)
                return;
            
            FilterDataGrid();
            FlatMessageBox.ShowDialog("Услуга успешно добавлена", Caption.Info);
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

            if (FlatMessageBox.ShowDialog("Вы уверены что хотите удалить данную услугу?", Caption.Warning, MessageBoxState.Question) != DialogResult.Yes)
                return;

            var index = Convert.ToInt32(dgvServices.Rows[e.RowIndex].Cells[0].Value);
            var service = _services[index - 1];
            service.Delete();
            _currentPage = 1;

            FilterDataGrid();
            FlatMessageBox.ShowDialog("Услуга успешно удалена.", Caption.Info);
        }

        private void ShowGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvServices.Rows[e.RowIndex].Cells[0].Value);
            var service = _services[index - 1];
            new ServiceForm(service).ShowDialog();

            FilterDataGrid();
        }

        private bool AreFilterControlsFilledCorrect()
        {
            if (nudTotalFrom.Value > nudTotalTo.Value)
            {
                FlatMessageBox.ShowDialog("Неверно указан диапозон цен.", Caption.Error);
                return false;
            }

            return true;
        }

        private void UseFilters(object sender, EventArgs e)
        {
            if (AreFilterControlsFilledCorrect() == false)
                return;
            FilterDataGrid();
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            _firstFilter = new Service();
            _secondFilter = new Service();
            _currentPage = 1;
            _lastPage = 1;

            nudTotalFrom.Value = Resources.DefaultNumericUpDownValue;
            nudTotalTo.Value = Resources.DefaultNumericUpDownValue;
            linkLblManufacturer.Text = Resources.No;
            cbCeiling.Items.Clear();

            FilterDataGrid();
            FlatMessageBox.ShowDialog("Значение фильтров сброшено до стандартных", Caption.Info);
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
            Handle.DragMove(e);
        }

        private void PriceFromChanged(object sender, EventArgs e)
        {
            _firstFilter.Price = nudTotalFrom.Value;
        }

        private void PriceToChanged(object sender, EventArgs e)
        {
            _secondFilter.Price = nudTotalTo.Value;
        }

        private void RowCountChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            _count = Convert.ToInt32(cbRows.SelectedItem);
            FilterDataGrid();
        }

        private void SortOptionChanged(object sender, EventArgs e)
        {
            if (_sortOption == SortOption.Ascending)
            {
                _sortOption = SortOption.Descending;
                iBtnSortOption.IconChar = IconChar.SortAmountDown;
            }
            else
            {
                _sortOption = SortOption.Ascending;
                iBtnSortOption.IconChar = IconChar.SortAmountDownAlt;
            }
        }

        private void PropertyChanged(object sender, EventArgs e)
        {
            foreach (ComboBoxItem item in cbProperties.Items)
                if (item == cbProperties.SelectedItem)
                    _property = (ServiceProperty)item.Tag;
        }

        private void FillPropertyComboBox()
        {
            foreach (ServiceProperty property in Enum.GetValues(typeof(ServiceProperty)))
            {
                var item = new ComboBoxItem()
                {
                    Content = property.ParseString(),
                    Tag = property
                };

                cbProperties.Items.Add(item);
            }

            cbProperties.DisplayMember = Resources.DisplayMember;
            cbProperties.SelectedIndex = 0;
        }
    }
}
