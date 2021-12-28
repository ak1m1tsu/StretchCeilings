using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stretch_ceilings_app.Utility.CustomBtn
{
    public class NavigationButton : Button
    {
        public NavigationButton(string name, string text)
        {
            this.Name = name;
            this.Text = text;
            this.Size = new Size(160, 65);
            this.BackColor = Color.FromArgb(234, 134, 72);
            this.FlatStyle = FlatStyle.Flat;
            this.Dock = DockStyle.Top;
            this.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            this.TextAlign = ContentAlignment.MiddleLeft;
        }
    }
}
