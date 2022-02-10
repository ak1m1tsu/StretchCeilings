using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Helpers.Structs;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class ManufacturerForm : Form
    {
        private List<Ceiling> _ceilings;
        private Manufacturer _manufacturer;

        public ManufacturerForm(Manufacturer manufacturer)
        {
            _manufacturer = manufacturer;
            InitializeComponent();
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void SetupControls()
        {
            btnClose.DialogResult = DialogResult.Cancel;
            btnEdit.Click += OpenEditForm;
            panelTop.MouseDown += DragMove;

            FillFormControls();
            dgvCeilings.CellDoubleClick += OpenCeilingForm;
        }

        private void SetupCeilingsGrid()
        {
            dgvCeilings.AddDataGridViewTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvCeilings.AddDataGridViewTextBoxColumn(Resources.Name, DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.AddDataGridViewTextBoxColumn(Resources.Texture, DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.AddDataGridViewTextBoxColumn(Resources.Color, DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.AddDataGridViewTextBoxColumn(Resources.Price, DataGridViewAutoSizeColumnMode.DisplayedCells);
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
                dgvCeilings.Rows[i].Cells[Resources.Number].Value = dgvCeilings.Rows.Count;
                dgvCeilings.Rows[i].Cells[Resources.Name].Value = _ceilings[i].Name;
                dgvCeilings.Rows[i].Cells[Resources.Texture].Value = _ceilings[i].TextureType?.ParseString();
                dgvCeilings.Rows[i].Cells[Resources.Color].Value = _ceilings[i].ColorType?.ParseString();
                dgvCeilings.Rows[i].Cells[Resources.Price].Value = _ceilings[i].Price;
            }
        }

        private void OpenCeilingForm(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCeilings.SelectedRows.Count < 0 && e.RowIndex < 0)
                return;

            var id = (int)dgvCeilings.Rows[e.RowIndex].Cells[0].Value - 1;
            var ceiling = _ceilings[id];
            new CeilingForm(ceiling).ShowDialog();

            FillCeilingsGrid();
        }

        private void FillFormControls()
        {
            lblAddressValue.Text = _manufacturer?.Address;
            lblNameValue.Text = _manufacturer?.Name;
            lblCountryValue.Text = _manufacturer?.Country?.ParseString();
        }

        private void OpenEditForm(object sender, EventArgs e)
        {
            this.Hide();

            var form = new ManufacturerEditForm(_manufacturer);

            if (form.ShowDialog() == DialogResult.OK)
            {
                _manufacturer = form.GetManufacturer();
                FillFormControls();
                FillCeilingsGrid();
            }

            this.Show();
        }

        private void ManufacturerForm_Load(object sender, EventArgs e)
        {
            SetupControls();
            SetupCeilingsGrid();
        }
    }
}
