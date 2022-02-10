using System;
using System.Collections.Generic;
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

        public AdditionalServicesForm(FormState state = FormState.Default)
        {
            _state = state;
            InitializeComponent();
        }

        public AdditionalService GetAdditionalService() => _additionalService;

        private bool IsForSearching => _state == FormState.ForView;

        private static bool CanUserAdd => UserSession.IsAdmin ||
                                            UserSession.Can(PermissionCode.EditAdditionalService);

        private static bool CanUserDelete => UserSession.IsAdmin ||
                                               UserSession.Can(PermissionCode.DelCustomer);

        private void SetupDataGrid()
        {
            dgvAdditionalServices.AddDataGridViewTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvAdditionalServices.AddDataGridViewTextBoxColumn(Resources.Name, DataGridViewAutoSizeColumnMode.Fill);
            dgvAdditionalServices.AddDataGridViewTextBoxColumn(Resources.Price, DataGridViewAutoSizeColumnMode.Fill);
            dgvAdditionalServices.AddDataGridViewButtonColumn(DraculaColor.Red);

            if (CanUserDelete == false)
                dgvAdditionalServices.Columns[Resources.Space].Visible = false;

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
            if (CanUserAdd)
                DrawAddButton();

            nudId.Maximum = decimal.MaxValue;
            nudTotalFrom.Maximum = decimal.MaxValue;
            nudTotalTo.Maximum = decimal.MaxValue;

            foreach (var item in Resources.RowCountItems)
                cbRows.Items.Add(item);

            cbRows.SelectedIndexChanged += RowCountChanged;
            cbRows.SelectedItem = cbRows.Items[0];

            if (IsForSearching)
            {
                dgvAdditionalServices.CellDoubleClick += SelectGridData;
                dgvAdditionalServices.Columns[Resources.Space].Visible = false;
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
                CustomMessageBox.ShowDialog(Resources.InvalidPriceRange, Caption.Error);
                return;
            }

            _currentPage = 1;
            _additionalServices = AdditionalServiceRepository.GetAll(
                _firstFilter,
                _secondsFilter,
                _count,
                _currentPage,
                out _rows);

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

        private void RowCountChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            _count = Convert.ToInt32(cbRows.SelectedItem);
            FilterDataGrid();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void AddGridData(object sender, EventArgs e)
        {
            var service = new AdditionalServiceEditForm(new AdditionalService(), true);
            if (service.ShowDialog() == DialogResult.OK)
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

            var index = Convert.ToInt32(dgvAdditionalServices.Rows[e.RowIndex].Cells[0].Value);
            var service = _additionalServices[index - 1];
            service.Delete();

            FilterDataGrid();
        }
        
        private void IdChanged(object sender, EventArgs e)
        {
            _firstFilter.Id = Convert.ToInt32(nudId.Value);
        }

        private void NameChanged(object sender, EventArgs e)
        {
            _firstFilter.Name = tbName.Text;
        }

        private void PriceFromChanged(object sender, EventArgs e)
        {
            _firstFilter.Price = nudTotalFrom.Value;
        }

        private void PriceToChanged(object sender, EventArgs e)
        {
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
            nudId.Value = Resources.DefaultNumericUpDownValue;
            tbName.Text = Resources.DefaultTextBoxText;

            _additionalServices = AdditionalServiceRepository.GetAll(out _rows);

            FillDataGrid();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            this.Handle.DragMove(e);
        }
    }
}
