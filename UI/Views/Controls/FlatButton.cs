using System;
using System.Drawing;
using System.Windows.Forms;
using StretchCeilings.UI.Structs;

namespace StretchCeilings.UI.Views.Controls
{
    public sealed class FlatButton : Button
    {
        public FlatButton(string name, string text, EventHandler eventHandler)
        {
            Size = new Size(160, 65);
            FlatStyle = FlatStyle.Flat;
            Dock = DockStyle.Top;
            Font = new Font("Open Sans", 12, FontStyle.Regular);
            TextAlign = ContentAlignment.MiddleLeft;
            FlatAppearance.BorderSize = 0;
            ForeColor = DraculaColor.Foreground;
            Click += eventHandler;

            Name = name;
            Text = text;
        }
    }
}
