using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StretchCeilings.Domain.Extensions;
using StretchCeilings.Domain.Helpers;
using StretchCeilings.Domain.Models;
using StretchCeilings.UI.Extensions;
using StretchCeilings.UI.Structs;

namespace StretchCeilings.UI.Views
{
    public partial class EstateEditForm : Form
    {
        private readonly Estate _estate;
        private List<Room> _rooms;

        public EstateEditForm(Estate estate)
        {
            _estate = estate;
            InitializeComponent();
        }

        public EstateEditForm(Customer customer)
        {
            _estate = new Estate()
            {
                CustomerId = customer.Id
            };
            _estate.Add();
            InitializeComponent();
        }

        public Estate GetEstate() => _estate;

        private void SetupDataGrid()
        {
            dgvRooms.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvRooms.CreateTextBoxColumn(Resources.Area, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvRooms.CreateTextBoxColumn(Resources.Type, DataGridViewAutoSizeColumnMode.Fill);
            dgvRooms.CreateTextBoxColumn(Resources.Corners, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvRooms.CreateButtonColumn();

            dgvRooms.Font = GoogleFont.OpenSans;
            dgvRooms.ForeColor = DraculaColor.Background;
            dgvRooms.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvRooms.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;
        }

        private void SetupControls()
        {
            tbAddress.Text = _estate?.Address;
        }

        private void FillDataGrid()
        {
            dgvRooms.Rows.Clear();

            for (var i = 0; i < _rooms.Count(x => x.DeletedDate == null); i++)
            {
                dgvRooms.Rows.Add(new DataGridViewRow());
                dgvRooms.Rows[i].Cells[0].Value = dgvRooms.Rows.Count;
                dgvRooms.Rows[i].Cells[1].Value = _rooms[i].Area;
                dgvRooms.Rows[i].Cells[2].Value = _rooms[i].Type?.ParseString();
                dgvRooms.Rows[i].Cells[3].Value = _rooms[i].Corners;
            }
        }

        private bool CanUpdate()
        {
            var can = true;

            if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                errorProvider.SetError(tbAddress, Resources.RequiredToFill);
                can = false;
            }

            return can;
        }

        private void UpdateFields()
        {
            _estate.Address = tbAddress.Text;
            _estate.Update();

            foreach (var room in _rooms.Where(room => room.Id == 0))
                room.Add();
            _rooms.ForEach(x => x?.Update());
        }

        private void UpdateEstate(object sender, EventArgs e)
        {
            if (CanUpdate() == false)
            {
                FlatMessageBox.ShowDialog(Resources.ControlsEmpty, Caption.Error);
                return;
            }

            UpdateFields();
            DialogResult = DialogResult.OK;
        }

        private void LoadForm(object sender, EventArgs e)
        {
            _rooms = _estate.GetRooms().ToList();

            SetupDataGrid();
            SetupControls();
            FillDataGrid();
        }

        private void AddGridData(object sender, EventArgs e)
        {
            var form = new RoomEditForm(_estate);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            _rooms.Add(form.GetRoom());
            FillDataGrid();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            if (_estate.HasNullField())
                _estate.Delete();

            DialogResult = DialogResult.Cancel;
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void Remove(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex < 0 ||
                senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn == false)
                return;

            var index = Convert.ToInt32(dgvRooms.Rows[e.RowIndex].Cells[0].Value);
            _rooms.Where(x => x.DeletedDate == null).ToList()[index - 1].DeletedDate = DateTime.Now;
            FillDataGrid();
        }
    }
}
