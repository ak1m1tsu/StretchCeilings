using System;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Domain.Extensions;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Models.Enums;
using StretchCeilings.UI.Structs;

namespace StretchCeilings.UI.Views
{
    public partial class RoomEditForm : Form
    {
        private readonly Room _room;

        public RoomEditForm(Estate estate)
        {
            _room = new Room()
            {
                EstateId = estate.Id
            };
            InitializeComponent();
        }

        public Room GetRoom() => _room;

        private void SetupForm()
        {
            nudArea.Maximum = decimal.MaxValue;
            nudCorners.Maximum = decimal.MaxValue;
            foreach (RoomType roomType in Enum.GetValues(typeof(RoomType)))
            {
                if (roomType == RoomType.Unknown)
                    continue;
                var item = new ComboBoxItem()
                {
                    Content = roomType.ParseString(),
                    Tag = roomType
                };

                cbType.Items.Add(item);
            }

            cbType.DisplayMember = Resources.DisplayMember;
            cbType.SelectedIndex = 0;
        }

        private void LoadForm(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void PlaneChanged(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog()
            {
                Filter = Resources.ImageFilter
            };
            fileDialog.ShowDialog();
            pbPlane.ImageLocation = fileDialog.FileName;
        }

        private bool CanUpdate()
        {
            var can = true;

            if (nudArea.Value < 0)
            {
                errorProvider.SetError(nudArea, Resources.RequiredToFill);
                can = false;
            }

            if (nudCorners.Value < 0)
            {
                errorProvider.SetError(nudCorners, Resources.RequiredToFill);
                can = false;
            }

            if (cbType.SelectedItem == null)
            {
                errorProvider.SetError(cbType, Resources.RequiredToFill);
                can = false;
            }

            return can;
        }

        private void UpdateFields()
        {
            _room.Area = Convert.ToInt32(nudArea.Value);
            _room.Corners = Convert.ToInt32(nudCorners.Value);
            _room.Plane = pbPlane.ImageLocation;

            foreach (ComboBoxItem item in cbType.Items)
                if (item == cbType.SelectedItem)
                    _room.Type = (RoomType)item.Tag;
        }

        private void UpdateRoom(object sender, EventArgs e)
        {
            if (CanUpdate())
            {
                FlatMessageBox.ShowDialog(Resources.ControlsEmpty, Caption.Error);
                return;
            }

            UpdateFields();
            DialogResult = DialogResult.OK;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
