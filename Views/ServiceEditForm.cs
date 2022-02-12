using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Extensions;
using StretchCeilings.Extensions.Controls;
using StretchCeilings.Helpers;
using StretchCeilings.Models;
using StretchCeilings.Models.Enums;
using StretchCeilings.Repositories;
using StretchCeilings.Structs;

namespace StretchCeilings.Views
{
    public partial class ServiceEditForm : Form
    {
        private readonly Service _service;
        private List<ServiceAdditionalService> _additionalServices;

        public ServiceEditForm(Service service = null)
        {
            _service = service;
            if (_service == null)
            {
                _service = new Service();
                _service.Add();
            }
            InitializeComponent();
        }

        private bool AreFieldsEmpty()
        {
            var empty = false;

            if (string.IsNullOrWhiteSpace(linkLblManufacturer.Text))
            {
                errorProvider.SetError(linkLblManufacturer, Resources.RequiredToFill);
                empty = true;
            }

            if (cbCeiling.SelectedItem == null)
            {
                errorProvider.SetError(cbCeiling, Resources.RequiredToFill);
                empty = true;
            }

            return empty;
        }

        private void SetupGrid()
        {
            _additionalServices = _service?.GetAdditionalServices();

            dgvAdditServs.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvAdditServs.CreateTextBoxColumn(Resources.Name, DataGridViewAutoSizeColumnMode.Fill);
            dgvAdditServs.CreateTextBoxColumn(Resources.Price, DataGridViewAutoSizeColumnMode.Fill);
            dgvAdditServs.CreateTextBoxColumn("Кол-во", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvAdditServs.Columns["Кол-во"].ReadOnly = false;
            dgvAdditServs.CreateButtonColumn();

            dgvAdditServs.Font = GoogleFont.OpenSans;
            dgvAdditServs.ForeColor = DraculaColor.Background;
            dgvAdditServs.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvAdditServs.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

            FillDataGrid();
        }

        private void SetupControls()
        {
            cbCeiling.DisplayMember = Resources.DisplayMember;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (AreFieldsEmpty())
            {
                FlatMessageBox.ShowDialog(Resources.ControlsEmpty, Caption.Error);
                return;
            }

            _service.CalculatePrice();
            _service.Update();

            DialogResult = DialogResult.OK;
        }

        private void FillDataGrid()
        {
            dgvAdditServs.Rows.Clear();
            
            for (var i = 0; i < _additionalServices?.Count; i++)
            {
                dgvAdditServs.Rows.Add(new DataGridViewRow());
                dgvAdditServs.Rows[i].Cells[Resources.Number].Value = dgvAdditServs.Rows.Count;
                dgvAdditServs.Rows[i].Cells[Resources.Name].Value = _additionalServices[i].GetAdditionalService()?.Name;
                dgvAdditServs.Rows[i].Cells[Resources.Price].Value = _additionalServices[i].GetAdditionalService()?.Price;
                dgvAdditServs.Rows[i].Cells["Кол-во"].Value = _additionalServices[i]?.Count;
                dgvAdditServs.Rows[i].Cells["Кол-во"].ReadOnly = false;
            }
        }

        private void AddGridData(object sender, EventArgs e)
        {
            var form = new AdditionalServicesForm(FormState.ForView);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            var additionalService = new ServiceAdditionalService()
            {
                ServiceId = _service.Id,
                AdditionalServiceId = form.GetAdditionalService().Id,
                Count = 1
            };

            for (var i = 0; i < _additionalServices?.Count; i++)
            {
                if (_additionalServices[i].AdditionalServiceId != additionalService.AdditionalServiceId)
                    continue;

                _additionalServices[i].Count++;
                _additionalServices[i].Update();
                dgvAdditServs.Rows[i].Cells["Кол-во"].Value = _additionalServices[i].Count;
                return;
            }
            
            _additionalServices?.Add(additionalService);
            additionalService.Add();

            FillDataGrid();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetupGrid();
            SetupControls();
        }

        private void SelectRoom(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new RoomsForm();

            if (form.ShowDialog() != DialogResult.OK)
                return;

            var room = form.GetRoom();

            if (room == null)
                return;
            
            _service.RoomId = room.Id;
            linkLblRoom.Text = Resources.Selected;
        }

        private void SelectManufacturer(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new ManufacturersForm(FormState.ForView);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            var manufacturer = form.GetManufacturer();

            if (manufacturer == null)
                return;

            _service.ManufacturerId = manufacturer.Id;
            linkLblManufacturer.Text = manufacturer.Name;

            FillCeilingComboBox();
        }

        private void FillCeilingComboBox()
        {
            if (_service?.ManufacturerId == null)
                return;

            var ceilings = ManufacturerRepository.GetById(_service.ManufacturerId.Value).GetCeilings();

            if (ceilings == null)
                return;

            cbCeiling.Items.Clear();
            
            foreach (var ceiling in ceilings)
            {
                cbCeiling.Items.Add(new ComboBoxItem()
                {
                    Content = ceiling.Name,
                    Tag = ceiling
                });
            }
        }

        private void SetCount(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ||
                e.ColumnIndex != dgvAdditServs.Columns["Кол-во"]?.Index ||
                dgvAdditServs.SelectedRows[0].Cells["Кол-во"].Value == null)
                return;

            var index = (int)dgvAdditServs.Rows[e.RowIndex].Cells[0].Value;
            var value = dgvAdditServs.Rows[e.RowIndex].Cells["Кол-во"].Value.ToString();
            
            if(int.TryParse(value, out var count) == false)
                return;

            _additionalServices[index-1].Count = count;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            if (_service.HasNullField())
                _service.Delete();

            DialogResult = DialogResult.Cancel;
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void SelectCeiling(object sender, EventArgs e)
        {
            foreach (ComboBoxItem item in cbCeiling.Items)
            {
                if (item == cbCeiling.SelectedItem)
                    _service.CeilingId = ((Ceiling)item.Tag).Id;
            }
        }

        private void RemoveGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ||
                e.ColumnIndex != dgvAdditServs.Columns[Resources.Space].Index)
                return;

            var index = (int)dgvAdditServs.Rows[e.RowIndex].Cells[Resources.Number].Value;
            var service = _additionalServices[index-1];
            service.Delete();
            _additionalServices.Remove(service);
            FillDataGrid();
        }
    }
}
