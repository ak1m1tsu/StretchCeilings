using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.DataAccess.Repositories;
using StretchCeilings.Domain.Extensions;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Repositories;
using StretchCeilings.UI.Extensions;
using StretchCeilings.UI.Structs;
using StretchCeilings.UI.Views.Enums;

namespace StretchCeilings.UI.Views
{
    public partial class RoomsForm : Form
    {
        private IRoomRepository _repository;
        private List<Room> _rooms;

        private Room _room;
        private Customer _customer;
        private Estate _estate;

        private int _rows;
        private int _count;
        private int _currentPage = 1;
        private int _lastPage = 1;

        public RoomsForm()
        {
            _repository = new RoomRepository();
            InitializeComponent();
        }

        public Room GetRoom() => _room;

        private void SetupForm()
        {
            _rooms = _repository.GetAll().ToList();
            _rows = _rooms.Count;

            SetupGrid();
            SetupControls();
            FilterDataGrid();
        }

        private void SetupGrid()
        {
            dgvRooms.CreateTextBoxColumn(Resources.Number, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvRooms.CreateTextBoxColumn(Resources.FullName, DataGridViewAutoSizeColumnMode.Fill);
            dgvRooms.CreateTextBoxColumn("Адрес", DataGridViewAutoSizeColumnMode.Fill);
            dgvRooms.CreateTextBoxColumn(Resources.Type, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvRooms.CreateTextBoxColumn(Resources.Area, DataGridViewAutoSizeColumnMode.DisplayedCells);
            dgvRooms.CreateTextBoxColumn(Resources.Corners, DataGridViewAutoSizeColumnMode.DisplayedCells);

            dgvRooms.Font = GoogleFont.OpenSans;
            dgvRooms.ForeColor = DraculaColor.Background;
            dgvRooms.DefaultCellStyle.SelectionBackColor = DraculaColor.Selection;
            dgvRooms.DefaultCellStyle.SelectionForeColor = DraculaColor.Foreground;
        }

        private void SetupControls()
        {
            foreach (var item in Resources.RowCountItems)
                cbRows.Items.Add(item);

            cbRows.SelectedIndex = 0;
            _count = Convert.ToInt32(cbRows.SelectedItem);
            cbRows.SelectedIndexChanged += RowCountChanged;
        }

        private void FillDataGrid()
        {
            dgvRooms.Rows.Clear();

            for (var i = 0; i < _rooms?.Count; i++)
            {
                dgvRooms.Rows.Add(new DataGridViewRow());

                dgvRooms.Rows[i].Cells[0].Value = dgvRooms.Rows.Count;
                dgvRooms.Rows[i].Cells[1].Value = _rooms[i]?.Estate?.Customer?.FullName;
                dgvRooms.Rows[i].Cells[2].Value = _rooms[i]?.Estate?.Address;
                dgvRooms.Rows[i].Cells[3].Value = _rooms[i]?.Type?.ParseString();
                dgvRooms.Rows[i].Cells[4].Value = _rooms[i]?.Area;
                dgvRooms.Rows[i].Cells[5].Value = _rooms[i]?.Corners;
            }

            UpdateLastPageValue();
            UpdatePageTextBox();
        }

        private void UpdateLastPageValue()
        {
            var result = Math.Ceiling(Convert.ToDouble(_rows) / _count);
            _lastPage = Convert.ToInt32(result);
        }

        private void FilterDataGrid()
        {
            _rooms = _repository.GetAll(
                _customer,
                _estate,
                _count,
                _currentPage).ToList();

            _rows = _rooms.Count;

            FillDataGrid();
        }

        private void UpdatePageTextBox()
        {
            if (_lastPage == 0)
                _currentPage = 0;
            tbPages.UpdatePagesValue(_currentPage, _lastPage);
        }

        private void UseFilters(object sender, EventArgs e)
        { 
            FilterDataGrid();
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            _customer = null;
            _estate = null;
            _currentPage = 1;
            _lastPage = 1;

            lLblCustomer.Text = Resources.No;

            FilterDataGrid();
        }

        private void RowCountChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            _count = Convert.ToInt32(cbRows.SelectedItem);
            FilterDataGrid();
        }

        private void ShowPreviousPage(object sender, EventArgs e)
        {
            if (_currentPage <= 1)
                return;

            _currentPage--;
            FilterDataGrid();
        }

        private void ShowNextPage(object sender, EventArgs e)
        {
            if (_currentPage >= _lastPage)
                return;

            _currentPage++;
            FilterDataGrid();
        }

        private void SelectRoom(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var index = Convert.ToInt32(dgvRooms.Rows[e.RowIndex].Cells[0].Value);
            _room = _rooms[index - 1];

            DialogResult = DialogResult.OK;
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SelectEstate(object sender, EventArgs e)
        {
            foreach (ComboBoxItem item in cbEstate.Items)
                if (item == cbEstate.SelectedItem)
                    _estate = (Estate)item.Tag;
        }

        private void SelectCustomer(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new CustomersForm(FormState.ForView);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            _customer = form.GetCustomer();

            if (_customer == null)
                return;

            var estates = _customer.GetEstates();
            cbEstate.Items.Clear();

            foreach (var estate in estates)
            {
                cbEstate.Items.Add(new ComboBoxItem()
                {
                    Content = estate.Address,
                    Tag = estate,
                });
            }
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }
    }
}
