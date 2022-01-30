using System.Windows.Forms;

namespace StretchCeilings.Helpers.Extensions.Controls
{
    public static class PanelExtensions
    {
        public static void AddButtons(this Panel panel, Button[] button)
        {
            panel.Controls.AddRange(button);
        }
    }
}
