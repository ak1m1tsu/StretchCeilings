using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Extensions;
using StretchCeilings.Extensions.Controls;
using StretchCeilings.Models;
using StretchCeilings.Models.Enums;
using StretchCeilings.Structs;

namespace StretchCeilings.Views
{
    public partial class ServiceForm : Form
    {
        private readonly Service _service;
        private readonly FormState _state;
        private List<ServiceAdditionalService> _additionalServices;

        public ServiceForm(Service service, FormState state = FormState.Default)
        {
            _service = service;
            _state = state;
            InitializeComponent();
        }

        private string PriceString => $@"{_service.Price ?? 0} {Resources.Rubles}";

        private bool IsForView => _state == FormState.ForView;

        private void SetupForm()
        {
            linkLblManufaсturerValue.Text = _service.Manufacturer.Name ?? Resources.No;
            linkLblCeilingValue.Text = _service.Ceiling.Name ?? Resources.No;
            linkLblRoom.Text = Resources.Selected;
            lblPriceValue.Text = PriceString;
            if (_state == FormState.ForView)
                btnEdit.Visible = false;

            SetupDataGrid();
        }

        private void SetupDataGrid()
        {
            dgvAdditServs.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvAdditServs.CreateTextBoxColumn(Resources.Name, DataGridViewAutoSizeColumnMode.Fill);
            dgvAdditServs.CreateTextBoxColumn(Resources.Price, DataGridViewAutoSizeColumnMode.Fill);
            dgvAdditServs.CreateTextBoxColumn("Кол-во", DataGridViewAutoSizeColumnMode.DisplayedCells);

            dgvAdditServs.Font = GoogleFont.OpenSans;
            dgvAdditServs.ForeColor = DraculaColor.Background;
            dgvAdditServs.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvAdditServs.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            _additionalServices = _service?.GetAdditionalServices();

            for (var i = 0; i < _additionalServices?.Count; i++)
            {
                dgvAdditServs.Rows.Add(new DataGridViewRow());
                dgvAdditServs.Rows[i].Cells[Resources.Number].Value = dgvAdditServs.Rows.Count;
                dgvAdditServs.Rows[i].Cells[Resources.Name].Value = _additionalServices[i].AdditionalService?.Name;
                dgvAdditServs.Rows[i].Cells[Resources.Price].Value = _additionalServices[i].AdditionalService?.Price;
                dgvAdditServs.Rows[i].Cells["Кол-во"].Value = _additionalServices[i].Count;
            }
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();   
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void ShowManufacturer(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_service.Manufacturer == null)
                return;

            var form = new ManufacturerForm(_service.Manufacturer, FormState.ForView);
            form.ShowDialog();
        }

        private void ShowCeiling(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_service.Ceiling == null)
                return;

            var form = new CeilingForm(_service.Ceiling);
            form.ShowDialog();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ShowRoom(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_service.Room == null)
                return;

            var form = new RoomForm(_service.Room);
            form.ShowDialog();
        }
    }
}
