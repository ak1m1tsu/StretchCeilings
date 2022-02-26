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
    /// <inheritdoc />
    public partial class ManufacturersForm : Form
    {
        private readonly IManufacturerRepository _repository;
        private List<Manufacturer> _manufacturers;

        private Manufacturer _manufacturer;
        private Manufacturer _filter;

        private readonly FormState _state;
        private SortOption _sortOption;
        private ManufacturerProperty _property;

        private int _rows;
        private int _count;
        private int _currentPage = 1;
        private int _lastPage = 1;

        /// <inheritdoc />
        public ManufacturersForm(FormState state = FormState.Default)
        {
            _state = state;
            _repository = new ManufacturerRepository();
            _sortOption = SortOption.Descending;
            InitializeComponent();
        }

        public Manufacturer GetManufacturer() => _manufacturer;

        private static bool CanUserAdd => UserSession.IsAdmin ||
                                          UserSession.Can(PermissionCode.AddCustomer);

        private static bool CanUserDelete => UserSession.IsAdmin ||
                                             UserSession.Can(PermissionCode.DelCustomer);

        private bool IsForView => _state == FormState.ForView;

        private void SetupDataGrid()
        {
            _manufacturers = _repository.GetAll().ToList();
            _rows = _manufacturers.Count;

            dgvManufacturers.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvManufacturers.CreateTextBoxColumn(Resources.Manufacturer, DataGridViewAutoSizeColumnMode.Fill);
            dgvManufacturers.CreateTextBoxColumn("Адрес", DataGridViewAutoSizeColumnMode.Fill);
            dgvManufacturers.CreateTextBoxColumn("Страна", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvManufacturers.CreateButtonColumn();

            dgvManufacturers.Font = GoogleFont.OpenSans;
            dgvManufacturers.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvManufacturers.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;
        }

        private void DrawAddCustomerButton()
        {
            var btnAddManufacturer = new FlatButton("btnAddManufacturer", "Добавить", AddGridData);
            panelUserButtons.Controls.Add(btnAddManufacturer);
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void SelectManufacturer(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvManufacturers.Rows[e.RowIndex].Cells[0].Value);
            _manufacturer = _manufacturers[index-1];

            DialogResult = DialogResult.OK;
        }

        private void FillCountryComboBox()
        {
            foreach (Country country in Enum.GetValues(typeof(Country)))
            {
                if (country == Country.Unknown) continue;
                var item = new ComboBoxItem()
                {
                    Content = country.ParseString(),
                    Tag = country
                };
                cbCountry.Items.Add(item);
            }
            cbCountry.DisplayMember = Resources.DisplayMember;
            cbCountry.SelectedItem = null;
        }

        private void FillRowsComboBox()
        {
            foreach (var rowCountItem in Resources.RowCountItems)
                cbRows.Items.Add(rowCountItem);
            cbRows.SelectedItem = cbRows.Items[0];
        }

        private void SetupControls()
        {
            btnResetFilters.FlatAppearance.MouseOverBackColor = DraculaColor.Red;
            btnNext.Click += ShowNextPage;
            btnPrevious.Click += ShowPreviousPage;

            FillCountryComboBox();
            FillRowsComboBox();
            FillPropertyComboBox();

            if (CanUserAdd && IsForView == false)
                DrawAddCustomerButton();

            if (CanUserDelete == false || IsForView)
                dgvManufacturers.Columns[Resources.Space].Visible = false;

            if (IsForView)
            {
                panelTopSide.Visible = true;
                panelTopSide.MouseDown += DragMove;
                dgvManufacturers.CellDoubleClick += SelectManufacturer;
                return;
            }

            dgvManufacturers.CellClick += RemoveGridData;
            dgvManufacturers.CellDoubleClick += ShowGridData;
        }
        
        private void FillDataGrid()
        {
            dgvManufacturers.Rows.Clear();

            for (var i = 0; i < _manufacturers?.Count; i++)
            {
                dgvManufacturers.Rows.Add(new DataGridViewRow());
                dgvManufacturers.Rows[i].Cells[0].Value = dgvManufacturers.Rows.Count;
                dgvManufacturers.Rows[i].Cells[1].Value = _manufacturers[i].Name;
                dgvManufacturers.Rows[i].Cells[2].Value = _manufacturers[i].Address;
                dgvManufacturers.Rows[i].Cells[3].Value = _manufacturers[i].Country?.ParseString();
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
            _manufacturers = _repository.GetAll(
                _filter,
                _count,
                _currentPage,
                _sortOption,
                _property).ToList();

            _rows = _manufacturers.Count;

            FillDataGrid();
        }

        private void RemoveGridData(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex < 0 ||
                senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn == false)
                return;

            if (FlatMessageBox.ShowDialog("Вы уверены что хотите удалить производителя?", Caption.Warning, MessageBoxState.Question) != DialogResult.Yes)
                return;

            var index = Convert.ToInt32(dgvManufacturers.Rows[e.RowIndex].Cells[0].Value);
            var manufacturer = _manufacturers[index - 1];

            manufacturer.Delete();
            _currentPage = 1;

            FilterDataGrid();
            FlatMessageBox.ShowDialog("Производитель успешно удален", Caption.Info);
        }

        private void ShowGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvManufacturers.Rows[e.RowIndex].Cells[0].Value);
            var manufacturer = _manufacturers[index - 1];
            new ManufacturerForm(manufacturer).ShowDialog();

            FilterDataGrid();
        }

        private void UpdatePageTextBox()
        {
            if (_lastPage == 0)
                _currentPage = 0;

            tbPages.UpdatePagesValue(_currentPage, _lastPage);
        }

        private void ShowNextPage(object sender, EventArgs e)
        {
            if (_currentPage >= _lastPage)
                return;

            _currentPage++;
            FilterDataGrid();
        }

        private void ShowPreviousPage(object sender, EventArgs e)
        {
            if (_currentPage <= 1)
                return;

            _currentPage--;
            FilterDataGrid();
        }

        private void AddGridData(object sender, EventArgs e)
        {
            var form = new ManufacturerEditForm();
            if (form.ShowDialog() != DialogResult.OK)
                return;
            
            FilterDataGrid();
            FlatMessageBox.ShowDialog("Производитель успешно добавлен", Caption.Info);
        }

        private void LoadForm(object sender, EventArgs e)
        {
            _filter = new Manufacturer()
            {
                Country = Country.Unknown
            };

            SetupDataGrid();
            SetupControls();
            FillDataGrid();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void UseFilters(object sender, EventArgs e)
        {
            FilterDataGrid();
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            _currentPage = 1;
            _lastPage = 1;
            _filter = new Manufacturer()
            {
                Country = Country.Unknown
            };

            tbAddress.Text = Resources.DefaultTextBoxText;
            tbName.Text = Resources.DefaultTextBoxText;

            cbCountry.SelectedItem = null;

            FilterDataGrid();
            FlatMessageBox.ShowDialog("Значение фильтров сброшено до стандартных", Caption.Info);
        }

        private void SetManufacturerAddress(object sender, EventArgs e)
        {
            if (tbAddress.Text.Length > 0)
                _filter.Address = tbAddress.Text;
        }

        private void SetManufacturerName(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 0)
                _filter.Name = tbName.Text;
        }

        private void SetManufacturerCountry(object sender, EventArgs e)
        {
            foreach (ComboBoxItem item in cbCountry.Items)
                if (item == cbCountry.SelectedItem)
                    _filter.Country = (Country)item.Tag;
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
                    _property = (ManufacturerProperty)item.Tag;
        }

        private void FillPropertyComboBox()
        {
            foreach (ManufacturerProperty property in Enum.GetValues(typeof(ManufacturerProperty)))
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
