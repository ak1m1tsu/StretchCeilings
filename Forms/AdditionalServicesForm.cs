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
    public partial class AdditionalServicesForm : Form
    {
        private List<AdditionalService> _additionalServices;

        private AdditionalService _firstFilter;
        private AdditionalService _secondsFilter;

        private int _rowsCount = 0;
        private int _currentPage = 1;
        private int _maxPage = 1;
        private int _count;
        
        private readonly bool _forSearching;

        public AdditionalServicesForm(bool forSearching = false)
        {
            _forSearching = forSearching;
            InitializeComponent();
        }

        private void UpdatePageTextBox()
        {
            tbPage.Text = $"{_currentPage} / {_maxPage}";
        }

        private void SetUpControls()
        {
            if (UserSession.Can(PermissionCode.AddAdditionalService) || UserSession.IsAdmin())
            {
                var btnAddService = new FlatButton("btnAddAdditionalService", "Добавить", Constants.DraculaAlphaGreen);
                btnAddService.Click += btnAddAdditionalService_Click;
                panelUserButtons.Controls.Add(btnAddService);
            }

            nudId.Maximum = decimal.MaxValue;
            nudTotalFrom.Maximum = decimal.MaxValue;
            nudTotalTo.Maximum = decimal.MaxValue;

            foreach (var item in Constants.RowCountItems)
                cbRows.Items.Add(item);
            cbRows.SelectedItem = cbRows.Items[0];

            UpdatePageTextBox();

            btnResetFilters.BackColor = Constants.DraculaAlphaRed;
        }

        private void SetUpDataGrid()
        {
            _additionalServices = AdditionalServiceRepository.GetAll(out _rowsCount);

            var idColumn = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            var nameColumn = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Название", DataGridViewAutoSizeColumnMode.Fill);
            var priceColumn = DataGridViewExtensions.CreateDataGridViewTextBoxColumn("Цена", DataGridViewAutoSizeColumnMode.Fill);
            var delColumn = DataGridViewExtensions.CreateDataGridViewButtonColumn(Constants.DraculaRed);

            dgvAdditionalServices.Font = Constants.DataGridViewFont;
            dgvAdditionalServices.DefaultCellStyle.SelectionBackColor = Constants.DraculaSelection;
            dgvAdditionalServices.DefaultCellStyle.SelectionForeColor = Constants.DraculaForeground;
            dgvAdditionalServices.CellClick += dgvAdditionalServices_CellClick;
            dgvAdditionalServices.Columns.AddRange(idColumn, nameColumn, priceColumn, delColumn);

            FillDataGrid();
        }

        private void OpenServiceForm()
        {
            if (dgvAdditionalServices.SelectedRows.Count <= 0) return;

            var service =
                AdditionalServiceRepository.GetById((int)dgvAdditionalServices.SelectedRows[0].Cells[0].Value);
            var form = new AdditionalServiceForm(service);
            if (form.ShowDialog() == DialogResult.OK)
                FillDataGrid();
        }

        private void DeleteRow(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex != dgvAdditionalServices.Columns[" "]?.Index) return;

            var service =
                AdditionalServiceRepository.GetById((int)dgvAdditionalServices.SelectedRows[0].Cells["№"].Value);

            service.Delete();

            FillDataGrid();
        }

        private void FilterDataGrid()
        {
            if (nudTotalFrom.Value > nudTotalTo.Value)
            {
                CustomMessageBox.Show("Неверно указан ценовой диапозон", Constants.ErrorCaption);
                return;
            }
            _additionalServices = AdditionalServiceRepository.GetAll(
                _firstFilter,
                _secondsFilter,
                _count,
                _currentPage,
                out _rowsCount);

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            dgvAdditionalServices.Rows.Clear();

            for (var i = 0; i < _additionalServices?.Count; i++)
            {
                dgvAdditionalServices.Rows.Add(new DataGridViewRow() { Resizable = DataGridViewTriState.False });

                dgvAdditionalServices.Rows[i].Cells[0].Value = _additionalServices[i].Id;
                dgvAdditionalServices.Rows[i].Cells[1].Value = _additionalServices[i].Name;
                dgvAdditionalServices.Rows[i].Cells[2].Value = _additionalServices[i].Price;
            }

            _maxPage = (int)Math.Ceiling((double)_rowsCount / _count);
            UpdatePageTextBox();
        }

        private void ResetFilters()
        {
            _firstFilter = new AdditionalService();
            _secondsFilter = new AdditionalService();

            nudTotalFrom.Value = Constants.DefaultNumericUpDownValue;
            nudTotalTo.Value = Constants.DefaultNumericUpDownValue;
            nudId.Value = Constants.DefaultNumericUpDownValue;
            tbName.Text = Constants.DefaultTextBoxText;
            
            _additionalServices = AdditionalServiceRepository.GetAll(out _rowsCount);

            FillDataGrid();
        }

        private void AddAdditionalService()
        {
            var service = new AdditionalServiceFormEdit(new AdditionalService());
            if (service.ShowDialog() != DialogResult.OK)
                return;
            FillDataGrid();
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

        private void AdditionalServicesForm_Load(object sender, EventArgs e)
        {
            _firstFilter = new AdditionalService();
            _secondsFilter = new AdditionalService();

            SetUpDataGrid();
            SetUpControls();
        }

        private void btnAddAdditionalService_Click(object sender, EventArgs e)
        {
            AddAdditionalService();
        }

        private void btnUseFilters_Click(object sender, EventArgs e)
        {
            FilterDataGrid();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            ResetFilters();
        }

        private void cbRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBoxRow();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            TakeNextPage();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            TakePreviousPage();
        }

        private void dgvAdditionalServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteRow(sender, e);
        }

        private void dgvAdditionalServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenServiceForm();
        }

        private void nudIdValue_ValueChanged(object sender, EventArgs e)
        {
            _firstFilter.Id = (int)nudId.Value;
        }

        private void tbNameValue_TextChanged(object sender, EventArgs e)
        {
            _firstFilter.Name = tbName.Text;
        }

        private void nudTotalFrom_ValueChanged(object sender, EventArgs e)
        {
            _firstFilter.Price = nudTotalFrom.Value;
        }

        private void nudTotalTo_ValueChanged(object sender, EventArgs e)
        {
            _secondsFilter.Price = nudTotalTo.Value;
        }
    }
}
