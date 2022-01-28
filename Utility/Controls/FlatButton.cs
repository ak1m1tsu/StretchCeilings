using System;
using System.Drawing;
using System.Windows.Forms;

namespace StretchCeilingsApp.Utility.Controls
{
    public sealed class FlatButton : Button
    {
        public FlatButton(string name, string text, EventHandler eventHandler)
        {
            this.Size = new Size(160, 65);
            this.FlatStyle = FlatStyle.Flat;
            this.Dock = DockStyle.Top;
            this.Font = new Font("Open Sans", 12, FontStyle.Regular);
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.FlatAppearance.BorderSize = 0;
            this.ForeColor = Constants.DraculaForeground;
            this.Click += eventHandler;

            this.Name = name;
            this.Text = text;
        }

        public FlatButton(string name, string text, EventHandler eventHandler, Color color)
        {
            this.Size = new Size(160, 65);
            this.FlatStyle = FlatStyle.Flat;
            this.Dock = DockStyle.Top;
            this.Font = new Font("Open Sans", 12, FontStyle.Regular);
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.FlatAppearance.BorderSize = 0;
            this.ForeColor = Constants.DraculaForeground;
            this.Click += eventHandler;

            this.Name = name;
            this.Text = text;
            this.BackColor = color;
        }
    }
}
