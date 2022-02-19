using System.Windows.Forms;

namespace StretchCeilings.UI.Extensions
{
    public static class PanelExtensions
    {
        public static void AddButtons(this Panel panel, Button[] button)
        {
            panel.Controls.AddRange(button);
        }
    }
}
