using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StretchCeilings.DataAccess.Repositories;
using StretchCeilings.Domain.Extensions;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Repositories;
using StretchCeilings.UI.Extensions;
using StretchCeilings.UI.Structs;
using StretchCeilings.UI.Views.Enums;

namespace StretchCeilings.UI.Views
{
    public partial class ServiceForm : Form
    {
        private readonly IManufacturerRepository _repository;
        private Service _service;
        private readonly FormState _state;
        private List<ServiceAdditionalService> _additionalServices;

        public ServiceForm(Service service, FormState state = FormState.Default)
        {
            _repository = new ManufacturerRepository();
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
            linkLblRoom.Text = _service.Room?.Type?.ParseString();
            lblPriceValue.Text = PriceString;
            if (IsForView)
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

        private void ReSetupForm()
        {
            var manufacturer = _repository.FindById(_service.ManufacturerId.Value);
            linkLblManufaсturerValue.Text = manufacturer.Name ?? Resources.No;
            linkLblCeilingValue.Text = manufacturer.GetCeilings().First(x => x.Id == _service.CeilingId).Name ?? Resources.No;
            linkLblRoom.Text = Resources.Selected;
            lblPriceValue.Text = PriceString;

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            _additionalServices = _service?.GetAdditionalServices().ToList();

            dgvAdditServs.Rows.Clear();

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

        private void OpenEditForm(object sender, EventArgs e)
        {
            Hide();

            var form = new ServiceEditForm(_service);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            _service = form.GetService();
            ReSetupForm();
            Show();
        }
    }
}
