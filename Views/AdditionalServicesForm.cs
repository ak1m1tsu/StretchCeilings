using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Forms;
using FontAwesome.Sharp;
using StretchCeilings.Extensions;
using StretchCeilings.Extensions.Controls;
using StretchCeilings.Models;
using StretchCeilings.Models.Enums;
using StretchCeilings.Repositories;
using StretchCeilings.Repositories.Enums;
using StretchCeilings.Sessions;
using StretchCeilings.Structs;
using StretchCeilings.Views.Controls;
using StretchCeilings.Views.Enums;

namespace StretchCeilings.Views
{
    public partial class AdditionalServicesForm : Form
    {
        private List<AdditionalService> _additionalServices;

        private AdditionalService _additionalService;
        private AdditionalService _firstFilter;
        private AdditionalService _secondsFilter;

        private int _rows;
        private int _currentPage = 1;
        private int _lastPage = 1;
        private int _count;
        
        private readonly FormState _state;
        private SortOption _sortOption;
        private AdditionalServiceProperty _property;

        public AdditionalServicesForm(FormState state = FormState.Default)
        {
            _state = state;
            _sortOption = SortOption.Descending;
            InitializeComponent();
        }

        public AdditionalService GetAdditionalService() => _additionalService;

        private bool IsForView => _state == FormState.ForView;

        private static bool CanUserAdd => UserSession.IsAdmin ||
                                          UserSession.Can(PermissionCode.EditAdditionalService);

        private static bool CanUserDelete => UserSession.IsAdmin ||
                                             UserSession.Can(PermissionCode.DelCustomer);

        private void SetupDataGrid()
        {
            dgvAdditionalServices.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvAdditionalServices.CreateTextBoxColumn(Resources.Name, DataGridViewAutoSizeColumnMode.Fill);
            dgvAdditionalServices.CreateTextBoxColumn(Resources.Price, DataGridViewAutoSizeColumnMode.Fill);
            dgvAdditionalServices.CreateButtonColumn();

            dgvAdditionalServices.Font = GoogleFont.OpenSans;
            dgvAdditionalServices.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvAdditionalServices.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;
        }


        private void DrawAddButton()
        {
            var btnAddService = new FlatButton("btnAddAdditionalService", "Добавить", AddGridData);
            panelUserButtons.Controls.Add(btnAddService);
        }

        private void SetupControls()
        {
            nudTotalFrom.Maximum = decimal.MaxValue;
            nudTotalTo.Maximum = decimal.MaxValue;
            FillPropertyComboBox();

            foreach (var item in Resources.RowCountItems)
                cbRows.Items.Add(item);
            cbRows.SelectedItem = cbRows.Items[0];

            if (CanUserAdd)
                DrawAddButton();

            if (CanUserDelete == false || IsForView)
                dgvAdditionalServices.Columns[Resources.Space].Visible = false;

            if (IsForView)
            {
                dgvAdditionalServices.CellDoubleClick += SelectGridData;
                panelTopSide.Visible = true;
                return;
            }

            dgvAdditionalServices.CellDoubleClick += ShowGridData;
            dgvAdditionalServices.CellClick += RemoveGridData;
        }

        private void SetupForm()
        {            
            _firstFilter = new AdditionalService();
            _secondsFilter = new AdditionalService();
            
            SetupDataGrid();
            SetupControls();
            FillDataGrid();
        }

        private void SelectGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAdditionalServices.SelectedRows.Count <= 0 || e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvAdditionalServices.Rows[e.RowIndex].Cells[0].Value);
            _additionalService = _additionalServices[index - 1];

            DialogResult = DialogResult.OK;
        }

        private void ShowGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAdditionalServices.SelectedRows.Count <= 0 || e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvAdditionalServices.Rows[e.RowIndex].Cells[0].Value);
            var service = _additionalServices[index - 1];
            new AdditionalServiceForm(service).ShowDialog();

            FilterDataGrid();
        }

        private void FilterDataGrid()
        {
            if (nudTotalFrom.Value > nudTotalTo.Value)
            {
                FlatMessageBox.ShowDialog(Resources.InvalidPriceRange, Caption.Error);
                return;
            }
            
            _additionalServices = AdditionalServiceRepository.GetAll(
                _firstFilter,
                _secondsFilter,
                _count,
                _currentPage,
                _sortOption,
                _property);

            _rows = _additionalServices.Count;

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            dgvAdditionalServices.Rows.Clear();

            for (var i = 0; i < _additionalServices?.Count; i++)
            {
                dgvAdditionalServices.Rows.Add(new DataGridViewRow());
                dgvAdditionalServices.Rows[i].Cells[0].Value = dgvAdditionalServices.Rows.Count;
                dgvAdditionalServices.Rows[i].Cells[1].Value = _additionalServices[i].Name;
                dgvAdditionalServices.Rows[i].Cells[2].Value = _additionalServices[i].Price;
            }

            UpdateLastPageValue();
            UpdatePagesTextBox();
        }

        private void UpdateLastPageValue()
        {
            var result = Math.Ceiling(Convert.ToDouble(_rows) / _count);
            _lastPage = Convert.ToInt32(result);
        }

        private void UpdatePagesTextBox()
        {
            if (_lastPage == 0)
                _currentPage = 0;
            tbPage.UpdatePagesValue(_currentPage, _lastPage);
        }
        
        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void AddGridData(object sender, EventArgs e)
        {
            var service = new AdditionalServiceEditForm();
            if (service.ShowDialog() != DialogResult.OK)
                return;

            FilterDataGrid();
            FlatMessageBox.ShowDialog("Дополнительная услуга успешно добавлена.", Caption.Info);
        }

        private void RemoveGridData(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex < 0 ||
                senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn == false)
                return;

            if (FlatMessageBox.ShowDialog("Вы уверены что хотите удалить данную доп. услугу?", Caption.Warning, MessageBoxState.Question) != DialogResult.Yes)
                return;

            var index = Convert.ToInt32(dgvAdditionalServices.Rows[e.RowIndex].Cells[0].Value);
            var service = _additionalServices[index - 1];
            service.Delete();
            _currentPage = 1;

            FilterDataGrid();
            FlatMessageBox.ShowDialog("Доп. услуга успешно удалена", Caption.Info);
        }

        private void NameChanged(object sender, EventArgs e)
        {
            _firstFilter.Name = tbName.Text;
        }

        private void PriceFromChanged(object sender, EventArgs e)
        {
            if (nudTotalFrom.Value > 0)
                _firstFilter.Price = nudTotalFrom.Value;
        }

        private void PriceToChanged(object sender, EventArgs e)
        {
            if (nudTotalTo.Value > 0)
                _secondsFilter.Price = nudTotalTo.Value;
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
        
        private void UseFilters(object sender, EventArgs e)
        {
            _currentPage = 1;
            FilterDataGrid();
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            _currentPage = 1;
            _lastPage = 1;

            _firstFilter = new AdditionalService();
            _secondsFilter = new AdditionalService();

            nudTotalFrom.Value = Resources.DefaultNumericUpDownValue;
            nudTotalTo.Value = Resources.DefaultNumericUpDownValue;
            tbName.Text = Resources.DefaultTextBoxText;
            
            FilterDataGrid();
            FlatMessageBox.ShowDialog("Значение фильтров сброшено до стандартных", Caption.Info);
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
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
                    _property = (AdditionalServiceProperty)item.Tag;
        }

        private void FillPropertyComboBox()
        {
            foreach (AdditionalServiceProperty property in Enum.GetValues(typeof(AdditionalServiceProperty)))
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
