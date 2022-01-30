using System;
using System.Windows.Forms;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Helpers.Extensions;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class CeilingFormEdit : Form
    {
        private readonly Ceiling _ceiling;

        public CeilingFormEdit(Ceiling ceiling) 
        {
            _ceiling = ceiling;
            InitializeComponent();
        }

        public CeilingFormEdit(Manufacturer manufacturer)
        {
            _ceiling = new Ceiling() { Manufacturer = manufacturer };
            InitializeComponent();
        }

        public Ceiling Ceiling => _ceiling;

        private void SetupForm()
        {
            btnClose.DialogResult = DialogResult.Cancel;
            btnSaveInfo.DialogResult = DialogResult.OK;

            nudPrice.Value = _ceiling?.Price ?? 0M;

            foreach (TextureType texture in Enum.GetValues(typeof(TextureType)))
                cbTexture.Items.Add(texture.ParseString());

            foreach (string item in cbTexture.Items)
                if (item == _ceiling?.TextureType?.ParseString())
                    cbTexture.SelectedItem = item;

            foreach (ColorType color in Enum.GetValues(typeof(ColorType)))
                cbTexture.Items.Add(color.ParseString());

            foreach (string item in cbColorType.Items)
                if (item == _ceiling?.ColorType?.ParseString())
                    cbTexture.SelectedItem = item;
        }

        private void SaveChanges()
        {
            _ceiling.ColorType = cbColorType.SelectedItem.ToString().ToColorType();
            _ceiling.TextureType = cbTexture.SelectedItem.ToString().ToTextureType();
            _ceiling.Price = nudPrice.Value;
            _ceiling.Name = $"{cbTexture.SelectedItem} {cbColorType.SelectedItem}";
            _ceiling.Update();
        }

        private void CeilingFormEdit_Load(object sender, System.EventArgs e)
        {
            SetupForm();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
    }
}
