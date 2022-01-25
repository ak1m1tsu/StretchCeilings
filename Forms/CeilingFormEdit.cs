using System;
using System.Windows.Forms;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility.Enums;
using stretch_ceilings_app.Utility.Extensions;

namespace stretch_ceilings_app.Forms
{
    public partial class CeilingFormEdit : Form
    {
        private readonly Ceiling _ceiling;

        public CeilingFormEdit(Ceiling ceiling) 
        {
            _ceiling = ceiling;
            InitializeComponent();
        }

        private void SetupForm()
        {
            nudPrice.Value = _ceiling?.Price ?? 0M;

            foreach (CeilingTexture texture in Enum.GetValues(typeof(CeilingTexture)))
                cbTexture.Items.Add(texture.ParseString());

            foreach (string item in cbTexture.Items)
            {
                if (item == _ceiling?.Texture.ParseString())
                    cbTexture.SelectedItem = item;
            }

            foreach (CeilingColor color in Enum.GetValues(typeof(CeilingColor)))
                cbTexture.Items.Add(color.ParseString());

            foreach (string item in cbColorType.Items)
            {
                if (item == _ceiling?.Color.ParseString())
                    cbTexture.SelectedItem = item;
            }
        }

        private void CeilingFormEdit_Load(object sender, System.EventArgs e)
        {
            SetupForm();
        }
    }
}
