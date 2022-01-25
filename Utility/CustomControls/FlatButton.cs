using System.Drawing;
using System.Windows.Forms;

namespace stretch_ceilings_app.Utility.CustomControls
{
    public sealed class FlatButton : Button
    {
        public FlatButton(string name, string text)
        {
            this.Size = new Size(160, 65);
            this.FlatStyle = FlatStyle.Flat;
            this.Dock = DockStyle.Top;
            this.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.FlatAppearance.BorderSize = 0;
            this.ForeColor = Constants.DraculaForeground;

            this.Name = name;
            this.Text = text;
        }

        public FlatButton(string name, string text, Color color)
        {
            this.Size = new Size(160, 65);
            this.FlatStyle = FlatStyle.Flat;
            this.Dock = DockStyle.Top;
            this.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.FlatAppearance.BorderSize = 0;
            this.ForeColor = Constants.DraculaForeground;

            this.Name = name;
            this.Text = text;
            this.BackColor = color;
        }
    }
}
