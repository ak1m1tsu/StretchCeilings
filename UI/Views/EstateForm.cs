using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StretchCeilings.Domain.Extensions;
using StretchCeilings.Domain.Models;
using StretchCeilings.UI.Extensions;
using StretchCeilings.UI.Structs;

namespace StretchCeilings.UI.Views
{
    public partial class EstateForm : Form
    {
        private readonly Estate _estate;
        private List<Room> _rooms; 

        public EstateForm(Estate estate)
        {
            _estate = estate;
            InitializeComponent();
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void LoadForm(object sender, EventArgs e)
        {
            lblAddressValue.Text = _estate.Address;

            _rooms = _estate?.GetRooms().ToList();

            dgvRooms.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvRooms.CreateTextBoxColumn(Resources.Area, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvRooms.CreateTextBoxColumn(Resources.Type, DataGridViewAutoSizeColumnMode.Fill);
            dgvRooms.CreateTextBoxColumn(Resources.Corners, DataGridViewAutoSizeColumnMode.DisplayedCells);

            for (var i = 0; i < _rooms?.Count; i++)
            {
                dgvRooms.Rows.Add(new DataGridViewRow());

                dgvRooms.Rows[i].Cells[0].Value = dgvRooms.Rows.Count;
                dgvRooms.Rows[i].Cells[1].Value = _rooms[i].Area;
                dgvRooms.Rows[i].Cells[2].Value = _rooms[i].Type?.ParseString();
                dgvRooms.Rows[i].Cells[3].Value = _rooms[i].Corners;
            }
        }

        private void ShowGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvRooms.Rows[e.RowIndex].Cells[0].Value);
            var room = _rooms[index - 1];
            var form = new RoomForm(room);

            form.ShowDialog();
        }
    }
}
