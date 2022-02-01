using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Extensions.Controls;
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

            lblAddressValue.Text = _manufacturer?.Address;
            lblNameValue.Text = _manufacturer?.Name;
            lblCountryValue.Text = _manufacturer?.Country?.ParseString();
            dgvCeilings.CellDoubleClick += OpenCeilingForm;
        }

        private void SetupCeilingsGrid()
        {
            dgvCeilings.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvCeilings.AddDataGridViewTextBoxColumn("Название", DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.AddDataGridViewTextBoxColumn("Текстура", DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.AddDataGridViewTextBoxColumn("Цвет", DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.AddDataGridViewTextBoxColumn("Цена", DataGridViewAutoSizeColumnMode.DisplayedCells);
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

        private void OpenCeilingForm(object sender, EventArgs e)
        {
            var ceiling = _ceilings[(int)dgvCeilings.SelectedRows[0].Cells[0].Value - 1];
            new CeilingForm(ceiling).ShowDialog();
            FillCeilingsGrid();
        }

        private void OpenEditForm(object sender, EventArgs e)
        {
            Hide();
            var form = new ManufacturerEditForm(_manufacturer);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _manufacturer = form.GetManufacturer();
                SetupControls();
                FillCeilingsGrid();
            }
            Show();
        }

        private void ManufacturerForm_Load(object sender, EventArgs e)
        {
            SetupControls();
            SetupCeilingsGrid();
        }
    }
}
