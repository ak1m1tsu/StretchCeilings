using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Helpers.Structs;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class ManufacturerEditForm : Form
    {
        private Manufacturer _manufacturer;
        private readonly List<Ceiling> _addedCeilings;
        private readonly List<Ceiling> _deletedCeilings;
        private readonly List<Ceiling> _updatedCeilings;

        private List<Ceiling> _ceilings;
        
        public ManufacturerEditForm(Manufacturer manufacturer = null)
        {
            _manufacturer = manufacturer;
            _addedCeilings = new List<Ceiling>();
            _deletedCeilings = new List<Ceiling>();
            _updatedCeilings = new List<Ceiling>();

            InitializeComponent();
        }

        public Manufacturer GetManufacturer() => _manufacturer;
        
        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void SetupControls()
        {
            btnClose.Click += CloseForm;
            btnSave.Click += SaveData;
            btnAddCeiling.Click += AddGridData;
            panelTop.MouseDown += DragMove;
            dgvCeilings.CellDoubleClick += OpenCeilingForm;
            dgvCeilings.CellClick += RemoveGridData;

            tbAddress.Text = _manufacturer?.Address;
            tbName.Text = _manufacturer?.Name;

            FillCountryComboBox();

            if (_manufacturer != null)
                return;

            _manufacturer = new Manufacturer();
            UpdateManufacturerData();
            _manufacturer.Add();
        }

        private void SetupCeilingsGrid()
        {
            dgvCeilings.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvCeilings.AddDataGridViewTextBoxColumn("Название", DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.AddDataGridViewTextBoxColumn("Текстура", DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.AddDataGridViewTextBoxColumn("Цвет", DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.AddDataGridViewTextBoxColumn("Цена", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvCeilings.AddDataGridViewButtonColumn(DraculaColor.Red);

            dgvCeilings.Font = GoogleFont.OpenSans;
            dgvCeilings.ForeColor = DraculaColor.Background;
            dgvCeilings.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvCeilings.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

            FillCeilingsGrid();
        }

        private void FillCeilingsGrid()
        {
            _ceilings = _manufacturer?.GetCeilings();

            dgvCeilings.Rows.Clear();

            for (var i = 0; i < _ceilings?.Count; i++)
            {
                dgvCeilings.Rows.Add(new DataGridViewRow());
                dgvCeilings.Rows[i].Cells["№"].Value = _ceilings[i].Id;
                dgvCeilings.Rows[i].Cells["Название"].Value = _ceilings[i].Name;
                dgvCeilings.Rows[i].Cells["Текстура"].Value = _ceilings[i].TextureType?.ParseString();
                dgvCeilings.Rows[i].Cells["Цвет"].Value = _ceilings[i].ColorType?.ParseString();
                dgvCeilings.Rows[i].Cells["Цена"].Value = _ceilings[i].Price;
            }
        }

        private void OpenCeilingForm(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCeilings.SelectedRows.Count <= 0 || e.RowIndex < 0 || e.RowIndex < 0)
                return;

            var ceiling = _ceilings[(int)dgvCeilings.SelectedRows[0].Cells[0].Value - 1];
            var form = new CeilingEditForm(ceiling);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            ceiling = form.GetCeiling();
            _updatedCeilings.Add(ceiling);

            dgvCeilings.Rows[e.RowIndex].Cells["Название"].Value = ceiling?.Name;
            dgvCeilings.Rows[e.RowIndex].Cells["Текстура"].Value = ceiling?.TextureType?.ParseString();
            dgvCeilings.Rows[e.RowIndex].Cells["Цвет"].Value = ceiling?.ColorType?.ParseString();
            dgvCeilings.Rows[e.RowIndex].Cells["Цена"].Value = ceiling?.Price;
        }

        private void FillCountryComboBox()
        {
            foreach (Country country in Enum.GetValues(typeof(Country)))
            {
                if (country == Country.Unknown)
                    continue;

                var item = new ComboBoxItem()
                {
                    Content = country.ParseString(),
                    Tag = country
                };

                cbCountry.Items.Add(item);
            }

            foreach (ComboBoxItem item in cbCountry.Items)
                if ((Country)item.Tag == _manufacturer?.Country)
                    cbCountry.SelectedItem = item;
            
            cbCountry.DisplayMember = "Content";
        }

        private void AddGridData(object sender, EventArgs e)
        {
            var form = new CeilingEditForm(_manufacturer);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            var ceiling = form.GetCeiling();
            var rows = dgvCeilings.Rows.Count;

            _addedCeilings.Add(ceiling);

            for (var i = rows; i < rows + 1; i++)
            {
                dgvCeilings.Rows.Add(new DataGridViewRow());
                dgvCeilings.Rows[i].Cells["№"].Value = dgvCeilings.Rows.Count;
                dgvCeilings.Rows[i].Cells["Название"].Value = ceiling.Name;
                dgvCeilings.Rows[i].Cells["Текстура"].Value = ceiling.TextureType?.ParseString();
                dgvCeilings.Rows[i].Cells["Цвет"].Value = ceiling.ColorType?.ParseString();
                dgvCeilings.Rows[i].Cells["Цена"].Value = ceiling.Price;
            }
        }

        private void RemoveGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvCeilings.Columns[" "]?.Index)
                return;

            var ceilingId = (int)dgvCeilings.SelectedRows[0].Cells["№"].Value;
            var ceiling = _updatedCeilings.FirstOrDefault(x => x.Id == ceilingId) ?? 
                          _ceilings.FirstOrDefault(x=>x.Id == ceilingId);

            _deletedCeilings.Add(ceiling);

            dgvCeilings.Rows.RemoveAt(e.RowIndex);
        }

        private bool AreControlsEmpty()
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                errorProvider.SetError(tbName, Resources.RequiredToFillOut);
                return true;
            }

            if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                errorProvider.SetError(tbAddress, Resources.RequiredToFillOut);
                return true;
            }

            if (cbCountry.SelectedItem == null)
            {
                errorProvider.SetError(cbCountry, Resources.RequiredToFillOut);
                return true;
            }

            return false;
        }

        private void UpdateManufacturerData()
        {
            foreach (ComboBoxItem item in cbCountry.Items)
                if (item == cbCountry.SelectedItem)
                    _manufacturer.Country = (Country)item.Tag;

            _manufacturer.Name = tbName.Text;
            _manufacturer.Address = tbAddress.Text;
        }

        private void SaveData(object sender, EventArgs e)
        {
            if (AreControlsEmpty())
            {
                CustomMessageBox.Show(Resources.ControlsEmpty, Caption.Error);
                return;
            }

            UpdateManufacturerData();

            _manufacturer.Update();

            _addedCeilings?.ForEach(x => x?.Add());
            _updatedCeilings?.ForEach(x => x?.Update());
            _deletedCeilings?.ForEach(x => x?.Delete());

            DialogResult = DialogResult.OK;
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetupControls();
            SetupCeilingsGrid();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            if(_manufacturer.AreFieldsNullOrWitherSpace())
                _manufacturer.Delete();
            DialogResult = DialogResult.Cancel;
        }
    }
}
