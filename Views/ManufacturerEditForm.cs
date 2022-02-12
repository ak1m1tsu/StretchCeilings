using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Extensions;
using StretchCeilings.Extensions.Controls;
using StretchCeilings.Helpers;
using StretchCeilings.Models;
using StretchCeilings.Models.Enums;
using StretchCeilings.Structs;

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
            Handle.DragMove(e);
        }

        private void SetupControls()
        {
            btnSave.Click += UpdateData;
            btnClose.Click += CloseForm;
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
            UpdateManufacturerFields();
            _manufacturer.Add();
        }

        private void SetupCeilingsGrid()
        {
            dgvCeilings.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvCeilings.CreateTextBoxColumn(Resources.Name, DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.CreateTextBoxColumn(Resources.Texture, DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.CreateTextBoxColumn(Resources.Color, DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.CreateTextBoxColumn(Resources.Price, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvCeilings.CreateButtonColumn();

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

        private bool CanUpdate()
        {
            var can = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                errorProvider.SetError(tbName, Resources.RequiredToFill);
                can = false;
            }

            if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                errorProvider.SetError(tbAddress, Resources.RequiredToFill);
                can = false;
            }

            if (cbCountry.SelectedItem == null)
            {
                errorProvider.SetError(cbCountry, Resources.RequiredToFill);
                can = false;
            }

            return can;
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
            if (CanUpdate() == false)
            {
                FlatMessageBox.ShowDialog(Resources.ControlsEmpty, Caption.Error);
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
