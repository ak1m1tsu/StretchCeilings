using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Controls;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Models;
using static StretchCeilings.Properties.Resources;

namespace StretchCeilings.Views
{
    public partial class ManufacturerEditForm : Form
    {
        private readonly Manufacturer _manufacturer;
        private List<Ceiling> _ceilings;
        private List<Ceiling> _tempCeilings;

        public ManufacturerEditForm(Manufacturer manufacturer)
        {
            _manufacturer = manufacturer;
            _tempCeilings = new List<Ceiling>();
            InitializeComponent();
        }

        public Manufacturer GetManufacturer() => _manufacturer;
        
        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void SetupControls()
        {
            btnClose.DialogResult = DialogResult.Cancel;
            btnSave.Click += SaveData;
            btnAddCeiling.Click += AddGridData;
            panelTop.MouseDown += DragMove;
            tbAddress.Text = _manufacturer?.Address;
            tbName.Text = _manufacturer?.Name;
            dgvCeilings.CellDoubleClick += OpenCeilingForm;
            dgvCeilings.CellClick += RemoveGridData;

            FillCountryComboBox();
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
            _ceilings = _manufacturer.GetCeilings();

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
            if (dgvCeilings.SelectedRows.Count <= 0 || e.RowIndex < 0 || e.RowIndex < 0) return;

            var ceiling = _ceilings[(int)dgvCeilings.SelectedRows[0].Cells[0].Value - 1];
            new CeilingForm(ceiling).ShowDialog();
            FillCeilingsGrid();
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

            foreach (ComboBoxItem item in cbCountry.Items)
            {
                if ((Country)item.Tag == _manufacturer?.Country)
                    cbCountry.SelectedItem = item;
            }
            cbCountry.DisplayMember = "Content";
        }

        private void AddGridData(object sender, EventArgs e)
        {
            var form = new CeilingEditForm(_manufacturer);
            if (form.ShowDialog() != DialogResult.OK) return;

            var ceiling = form.Ceiling;
            _tempCeilings.Add(ceiling);
            var rows = _ceilings.Count + _tempCeilings.Count;

            for (var i = rows; i < rows + 1; i++)
            {
                dgvCeilings.Rows.Add(new DataGridViewRow());
                dgvCeilings.Rows[i].Cells["№"].Value = ceiling.Id;
                dgvCeilings.Rows[i].Cells["Название"].Value = ceiling.Name;
                dgvCeilings.Rows[i].Cells["Текстура"].Value = ceiling.TextureType?.ParseString();
                dgvCeilings.Rows[i].Cells["Цвет"].Value = ceiling.ColorType?.ParseString();
                dgvCeilings.Rows[i].Cells["Цена"].Value = ceiling.Price;
            }
        }

        private void RemoveGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvCeilings.Columns[" "]?.Index) return;

            var ceilingId = (int)dgvCeilings.SelectedRows[0].Cells["№"].Value;
            var ceiling = _manufacturer.GetCeilings().FirstOrDefault(x => x.Id == ceilingId);
            ceiling?.Delete();
            FillCeilingsGrid();
        }

        private bool AreControlsEmpty()
        {
            var controlsAreEmpty = false;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                errorProvider.SetError(tbName, RequiredToFillOut);
                controlsAreEmpty = true;
            }

            if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                errorProvider.SetError(tbAddress, RequiredToFillOut);
                controlsAreEmpty = true;
            }

            if (cbCountry.SelectedItem == null)
            {
                errorProvider.SetError(cbCountry, RequiredToFillOut);
                controlsAreEmpty = true;
            }

            return controlsAreEmpty;
        }

        private void UpdateManufacturerData()
        {
            foreach (ComboBoxItem item in cbCountry.Items)
            {
                if (item == cbCountry.SelectedItem) _manufacturer.Country = (Country)item.Tag;
            }

            _manufacturer.Name = tbName.Text;
            _manufacturer.Address = tbAddress.Text;
        }

        private void SaveData(object sender, EventArgs e)
        {
            if (AreControlsEmpty())
            {
                CustomMessageBox.Show(RequiredControlsAreEmpty, CustomMessageBoxCaption.Error);
                return;
            }

            UpdateManufacturerData();
            _manufacturer.Update();
            _tempCeilings?.ForEach(x => x?.Add());
            DialogResult = DialogResult.OK;
        }

        private void ManufacturerEditForm_Load(object sender, EventArgs e)
        {
            SetupControls();
            SetupCeilingsGrid();
        }
    }
}
