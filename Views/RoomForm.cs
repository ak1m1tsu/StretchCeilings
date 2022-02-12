using System;
using System.Windows.Forms;
using StretchCeilings.Extensions;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class RoomForm : Form
    {
        private readonly Room _room;

        public RoomForm(Room room)
        {
            _room = room;
            InitializeComponent();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            lblTypeValue.Text = _room?.Type?.ParseString();
            lblAreaValue.Text = _room?.Area.ToString();
            lblCornersValue.Text = _room?.Corners.ToString();
            pbPlane.ImageLocation = _room?.Plane;
            panelTop.MouseDown += DragMove;
            btnClose.Click += CloseForm;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }
    }
}
