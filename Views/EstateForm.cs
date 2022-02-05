using System.Collections.Generic;
using System.Windows.Forms;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Helpers.Extensions.Controls;
using StretchCeilings.Models;
using StretchCeilings.Repositories;

namespace StretchCeilings.Views
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
            this.Handle.DragMove(e);
        }

        private void CloseForm(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void LoadForm(object sender, System.EventArgs e)
        {
            lblAddressValue.Text = _estate.Address;

            _rooms = _estate?.GetRooms();

            dgvRooms.AddDataGridViewTextBoxColumn("№", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvRooms.AddDataGridViewTextBoxColumn("Площадь", DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvRooms.AddDataGridViewTextBoxColumn("Тип", DataGridViewAutoSizeColumnMode.Fill);
            dgvRooms.AddDataGridViewTextBoxColumn("Углов", DataGridViewAutoSizeColumnMode.DisplayedCells);

            for (var i = 0; i < _rooms?.Count; i++)
            {
                dgvRooms.Rows.Add(new DataGridViewRow());

                dgvRooms.Rows[i].Cells[0].Value = _rooms[i].Id;
                dgvRooms.Rows[i].Cells[1].Value = _rooms[i].Area;
                dgvRooms.Rows[i].Cells[2].Value = _rooms[i].Type?.ParseString();
                dgvRooms.Rows[i].Cells[3].Value = _rooms[i].Corners;
            }
        }

        private void ShowGridData(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 && dgvRooms.Rows[e.RowIndex].Index < 0)
                return;

            var id = (int)dgvRooms.Rows[e.RowIndex].Cells[0].Value;
            var room = RoomRepository.GetById(id);
            var form = new RoomForm(room);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
