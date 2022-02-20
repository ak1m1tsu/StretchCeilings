using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StretchCeilings.Domain.Extensions;
using StretchCeilings.Domain.Models;
using StretchCeilings.UI.Extensions;
using StretchCeilings.UI.Structs;
using StretchCeilings.UI.Views.Enums;

namespace StretchCeilings.UI.Views
{
    public partial class ManufacturerForm : Form
    {
        private List<Ceiling> _ceilings;
        private Manufacturer _manufacturer;
        private readonly FormState _state;

        public ManufacturerForm(Manufacturer manufacturer, FormState state = FormState.Default)
        {
            _manufacturer = manufacturer;
            _state = state;
            InitializeComponent();
        }

        private bool IsForView => _state == FormState.ForView;

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void SetupControls()
        {
            btnClose.DialogResult = DialogResult.Cancel;
            btnEdit.Click += OpenEditForm;
            if (IsForView)
                btnEdit.Visible = false;

            panelTop.MouseDown += DragMove;

            FillFormControls();
            dgvCeilings.CellDoubleClick += OpenCeilingForm;
        }

        private void SetupCeilingsGrid()
        {
            dgvCeilings.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvCeilings.CreateTextBoxColumn(Resources.Name, DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.CreateTextBoxColumn(Resources.Texture, DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.CreateTextBoxColumn(Resources.Color, DataGridViewAutoSizeColumnMode.Fill);
            dgvCeilings.CreateTextBoxColumn(Resources.Price, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvCeilings.Font = GoogleFont.OpenSans;
            dgvCeilings.ForeColor = DraculaColor.Background;
            dgvCeilings.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvCeilings.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;

            FillCeilingsGrid();
        }

        private void FillCeilingsGrid()
        {
            _ceilings = _manufacturer?.GetCeilings().ToList();

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
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvCeilings.Rows[e.RowIndex].Cells[0].Value);
            var ceiling = _ceilings[index - 1];
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
            Hide();

            var form = new ManufacturerEditForm(_manufacturer);

            if (form.ShowDialog() == DialogResult.OK)
            {
                _manufacturer = form.GetManufacturer();
                FillFormControls();
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
