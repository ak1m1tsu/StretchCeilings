using System;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Extensions;
using StretchCeilings.Models;
using StretchCeilings.Models.Enums;
using StretchCeilings.Structs;

namespace StretchCeilings.Views
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
                Filter = "Image files(*.png)|*.png"
            };
            fileDialog.ShowDialog();
            pbPlane.ImageLocation = fileDialog.FileName;
        }

        private void UpdateRoom(object sender, EventArgs e)
        {
            _room.Area = Convert.ToInt32(nudArea.Value);
            _room.Corners = Convert.ToInt32(nudCorners.Value);
            foreach (ComboBoxItem item in cbType.Items)
            {
                if (item != cbType.SelectedItem)
                    continue;

                _room.Type = (RoomType)item.Tag;
            }

            _room.Plane = pbPlane.ImageLocation;
            DialogResult = DialogResult.OK;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
