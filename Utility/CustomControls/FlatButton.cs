using System;
using System.Drawing;
using System.Windows.Forms;

namespace stretch_ceilings_app.Utility.CustomControls
{
    public class FlatButton : Button
    {
        public event EventHandler Event;

        public FlatButton(string name, string text)
        {
            this.Name = name;
            this.Text = text;
            this.Size = new Size(160, 65);
            this.FlatStyle = FlatStyle.Flat;
            this.Dock = DockStyle.Top;
            this.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            this.TextAlign = ContentAlignment.MiddleLeft;
        }

        protected virtual void OnEvent()
        {
            Event?.Invoke(this, EventArgs.Empty);
        }
    }
}
