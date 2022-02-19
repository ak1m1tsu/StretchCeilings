using System;
using System.Windows.Controls;
using System.Windows.Forms;
using StretchCeilings.Domain.Extensions;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Models.Enums;
using StretchCeilings.UI.Extensions;
using StretchCeilings.UI.Structs;

namespace StretchCeilings.UI.Views
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

        private bool CanUpdate()
        {
            var can = true;

            if (cbColorType.SelectedItem == null)
            {
                errorProvider.SetError(cbColorType, Resources.RequiredToFill);
                can = false;
            }

            if (cbTexture.SelectedItem == null)
            {
                errorProvider.SetError(cbTexture, Resources.RequiredToFill);
                can = false;
            }

            if (nudPrice.Value <= 0)
            {
                errorProvider.SetError(nudPrice, Resources.RequiredToFill);
                can = false;
            }

            return can;
        }

        private void UpdateFields()
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
            if (CanUpdate() == false)
            {
                FlatMessageBox.ShowDialog(Resources.ControlsEmpty, Caption.Error);
                return;
            }

            UpdateFields();
            _ceiling.Update();
            DialogResult = DialogResult.OK;
        }
    }
}
