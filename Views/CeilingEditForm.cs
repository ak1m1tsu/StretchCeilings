using System;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Helpers;
using StretchCeilings.Helpers.Controls;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class CeilingEditForm : Form
    {
        private readonly Ceiling _ceiling;
        private readonly bool _isNew;

        public CeilingEditForm(Ceiling ceiling) 
        {
            _ceiling = ceiling;
            InitializeComponent();
            this.Load += SetupForm;
        }

        public Ceiling Ceiling { get; }

        public CeilingEditForm(Manufacturer manufacturer)
        {
            _isNew = true;
            Ceiling = new Ceiling() { ManufacturerId = manufacturer.Id };
            InitializeComponent();
            this.Load += SetupForm;
        }

        public Ceiling GetCeiling() => _ceiling;

        private void SetupForm(object sender, EventArgs e)
        {
            btnClose.DialogResult = DialogResult.Cancel;
            btnSaveInfo.Click += SaveChanges;

            nudPrice.Value = _ceiling?.Price ?? 0M;

            FillTextureComboBox();
            FillColorComboBox();
        }

        private void FillColorComboBox()
        {
            foreach (ColorType colorType in Enum.GetValues(typeof(ColorType)))
            {
                if(colorType == ColorType.Unknown) continue;
                var item = new ComboBoxItem()
                {
                    Content = colorType.ParseString(),
                    Tag = colorType
                };
                cbColorType.Items.Add(item);
            }

            cbColorType.DisplayMember = "Content";
            cbColorType.SelectedItem = null;

            foreach (ComboBoxItem item in cbColorType.Items)
            {
                if ((ColorType)item.Tag == _ceiling?.ColorType) 
                    cbColorType.SelectedItem = item;
            }
        }

        private void FillTextureComboBox()
        {
            foreach (TextureType textureType in Enum.GetValues(typeof(TextureType)))
            {
                if (textureType == TextureType.Unknown) continue;
                var item = new ComboBoxItem()
                {
                    Content = textureType.ParseString(),
                    Tag = textureType
                };
                cbTexture.Items.Add(item);
            }

            cbTexture.DisplayMember = "Content";
            cbTexture.SelectedItem = null;

            foreach (ComboBoxItem item in cbColorType.Items)
            {
                if ((TextureType)item.Tag == _ceiling?.TextureType)
                    cbTexture.SelectedItem = item;
            }
        }

        private bool AreControlsEmpty()
        {
            return string.IsNullOrEmpty(cbColorType.SelectedItem.ToString()) ||
                   string.IsNullOrEmpty(cbTexture.SelectedItem.ToString()) ||
                   nudPrice.Value == 0M;
        }

        private void SetCeilingValues(Ceiling ceiling)
        {
            var color = ColorType.Unknown;
            var texture = TextureType.Unknown;
            foreach (ComboBoxItem item in cbColorType.Items)
            {
                if (item != cbColorType.SelectedItem) continue;

                color = (ColorType)item.Tag;
                ceiling.ColorType = color;
            }

            foreach (ComboBoxItem item in cbTexture.Items)
            {
                if (item != cbTexture.SelectedItem) continue;

                texture = (TextureType)item.Tag;
                ceiling.TextureType = texture;
            }
            ceiling.Price = nudPrice.Value;
            ceiling.Name = $"{texture.ParseString()} {color.ParseString().ToLower()}";
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            if (AreControlsEmpty() == false)
            {
                if (_isNew)
                {
                    SetCeilingValues(Ceiling);
                }
                else
                {
                    SetCeilingValues(_ceiling);
                    _ceiling.Update();
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                CustomMessageBox.Show("Не все поля заполнены", CustomMessageBoxCaption.Error);
            }
        }
    }
}
