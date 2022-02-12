using System;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Extensions;
using StretchCeilings.Models;
using StretchCeilings.Models.Enums;
using StretchCeilings.Structs;

namespace StretchCeilings.Views
{
    public partial class CeilingEditForm : Form
    {
        private readonly Ceiling _ceiling;

        public CeilingEditForm(Ceiling ceiling) 
        {
            _ceiling = ceiling;
            InitializeComponent();
            Load += SetupForm;
        }

        public CeilingEditForm(Manufacturer manufacturer)
        {
            _ceiling = new Ceiling()
            {
                ManufacturerId = manufacturer.Id
            };
            _ceiling.Add();
            InitializeComponent();
            Load += SetupForm;
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }

        public Ceiling GetCeiling() => _ceiling;

        private void SetupForm(object sender, EventArgs e)
        {
            btnClose.DialogResult = DialogResult.Cancel;
            btnSaveInfo.Click += SaveChanges;
            panelTop.MouseDown += DragMove;

            nudPrice.Value = _ceiling?.Price ?? 0M;

            FillTextureComboBox();
            FillColorComboBox();
        }

        private void FillColorComboBox()
        {
            foreach (ColorType colorType in Enum.GetValues(typeof(ColorType)))
            {
                if(colorType == ColorType.Unknown)
                    continue;

                var item = new ComboBoxItem()
                {
                    Content = colorType.ParseString(),
                    Tag = colorType
                };

                cbColorType.Items.Add(item);
            }

            cbColorType.DisplayMember = Resources.DisplayMember;
            cbColorType.SelectedItem = null;

            foreach (ComboBoxItem item in cbColorType.Items)
                if ((ColorType)item.Tag == _ceiling?.ColorType)
                    cbColorType.SelectedItem = item;
        }

        private void FillTextureComboBox()
        {
            foreach (TextureType textureType in Enum.GetValues(typeof(TextureType)))
            {
                if (textureType == TextureType.Unknown)
                    continue;

                var item = new ComboBoxItem()
                {
                    Content = textureType.ParseString(),
                    Tag = textureType
                };

                cbTexture.Items.Add(item);
            }

            cbTexture.DisplayMember = Resources.DisplayMember;
            cbTexture.SelectedItem = null;

            foreach (ComboBoxItem item in cbTexture.Items)
                if ((TextureType)item.Tag == _ceiling?.TextureType)
                    cbTexture.SelectedItem = item;
        }

        private bool AreControlsEmpty()
        {
            return string.IsNullOrEmpty(cbColorType.SelectedItem?.ToString()) ||
                   string.IsNullOrEmpty(cbTexture.SelectedItem?.ToString()) ||
                   nudPrice.Value == 0M;
        }

        private void SetCeilingValues()
        {
            var color = ColorType.Unknown;
            var texture = TextureType.Unknown;

            foreach (ComboBoxItem item in cbColorType.Items)
            {
                if (item != cbColorType.SelectedItem)
                    continue;

                color = (ColorType)item.Tag;
                _ceiling.ColorType = color;
            }

            foreach (ComboBoxItem item in cbTexture.Items)
            {
                if (item != cbTexture.SelectedItem)
                    continue;

                texture = (TextureType)item.Tag;
                _ceiling.TextureType = texture;
            }

            _ceiling.Price = nudPrice.Value;
            _ceiling.Name = $"{texture.ParseString()} {color.ParseString().ToLower()}";
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            if (AreControlsEmpty() == false)
            {
                SetCeilingValues();
                _ceiling.Update();
                DialogResult = DialogResult.OK;
            }
            else
            {
                FlatMessageBox.ShowDialog(Resources.ControlsEmpty, Caption.Error);
            }
        }
    }
}
