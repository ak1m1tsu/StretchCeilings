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
        private List<Ceiling> _ceilings;
        
        
        public ManufacturerEditForm(Manufacturer manufacturer = null)
        {
            _manufacturer = manufacturer;
            InitializeComponent();
        }

        public Manufacturer GetManufacturer() => _manufacturer;
        
        private void DragMove(object sender, MouseEventArgs e)
        {
            this.Handle.DragMove(e);
        }

        private void SetupControls()
        {
            this.btnSave.Click += UpdateData;
            this.btnClose.Click += CloseForm;
            this.btnAddCeiling.Click += AddGridData;
            this.panelTop.MouseDown += DragMove;
            this.dgvCeilings.CellDoubleClick += OpenCeilingForm;
            this.dgvCeilings.CellClick += RemoveGridData;

            this.tbAddress.Text = _manufacturer?.Address;
            this.tbName.Text = _manufacturer?.Name;

            FillCountryComboBox();

            if (_manufacturer != null)
                return;

            _manufacturer = new Manufacturer();
            UpdateManufacturerFields();
            _manufacturer.Add();
        }

        private void SetupCeilingsGrid()
        {
            dgvCeilings.AddDataGridViewTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvCeilings.AddDataGridViewTextBoxColumn(Resources.Name, DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.AddDataGridViewTextBoxColumn(Resources.Texture, DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.AddDataGridViewTextBoxColumn(Resources.Color, DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.AddDataGridViewTextBoxColumn(Resources.Price, DataGridViewAutoSizeColumnMode.DisplayedCells);
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
                dgvCeilings.Rows[i].Cells[Resources.Number].Value = i + 1;
                dgvCeilings.Rows[i].Cells[Resources.Name].Value = _ceilings[i].Name;
                dgvCeilings.Rows[i].Cells[Resources.Texture].Value = _ceilings[i].TextureType?.ParseString();
                dgvCeilings.Rows[i].Cells[Resources.Color].Value = _ceilings[i].ColorType?.ParseString();
                dgvCeilings.Rows[i].Cells[Resources.Price].Value = _ceilings[i].Price;
            }
        }

        private void OpenCeilingForm(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = (int)dgvCeilings.Rows[e.RowIndex].Cells[0].Value;
            var old = _ceilings?.FirstOrDefault(x => x.Id == index);
            var form = new CeilingEditForm(old);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            FillCeilingsGrid();
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
            
            cbCountry.DisplayMember = Resources.DisplayMember;
        }

        private void AddGridData(object sender, EventArgs e)
        {
            var form = new CeilingEditForm(_manufacturer);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            FillCeilingsGrid();
        }

        private void RemoveGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvCeilings.Columns[Resources.Space]?.Index)
                return;

            var id = (int)dgvCeilings.Rows[e.RowIndex].Cells[Resources.Number].Value - 1;

            var ceiling = _ceilings[id];

            if (ceiling == null)
                return;
            
            ceiling.Delete();
            FillCeilingsGrid();
        }

        private bool AreControlsEmpty()
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                errorProvider.SetError(tbName, Resources.RequiredToFill);
                return true;
            }

            if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                errorProvider.SetError(tbAddress, Resources.RequiredToFill);
                return true;
            }

            if (cbCountry.SelectedItem == null)
            {
                errorProvider.SetError(cbCountry, Resources.RequiredToFill);
                return true;
            }

            return false;
        }

        private void UpdateManufacturerFields()
        {
            foreach (ComboBoxItem item in cbCountry.Items)
                if (item == cbCountry.SelectedItem)
                    _manufacturer.Country = (Country)item.Tag;

            _manufacturer.Name = tbName.Text;
            _manufacturer.Address = tbAddress.Text;
        }

        private void UpdateData(object sender, EventArgs e)
        {
            if (AreControlsEmpty())
            {
                CustomMessageBox.ShowDialog(Resources.ControlsEmpty, Caption.Error);
                return;
            }

            UpdateManufacturerFields();
            _manufacturer.Update();

            DialogResult = DialogResult.OK;
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetupControls();
            SetupCeilingsGrid();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            if (_manufacturer.HasNullField())
            {
                _manufacturer.Delete();
                _ceilings?.ForEach(x => x?.Delete());
            }

            DialogResult = DialogResult.Cancel;
        }
    }
}
