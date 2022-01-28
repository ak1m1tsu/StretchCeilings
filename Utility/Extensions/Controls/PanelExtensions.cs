using System.Windows.Forms;

namespace StretchCeilingsApp.Utility.Extensions.Controls
{
    public static class PanelExtensions
    {
        public static void AddButtons(this Panel panel, Button[] button)
        {
            panel.Controls.AddRange(button);
        }
    }
}
