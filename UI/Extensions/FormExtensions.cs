using System;
using System.Windows.Forms;
using StretchCeilings.UI.Helpers;

namespace StretchCeilings.UI.Extensions
{
    public static class FormExtensions
    {
        public static void Normalize(this FormWindowState state)
        {
            state = FormWindowState.Normal;
        }

        public static void Maximize(this FormWindowState state)
        {
            state = FormWindowState.Maximized;
        }
        public static void Minimize(this FormWindowState state)
        {
            state = FormWindowState.Minimized;
        }

        public static void DragMove(this IntPtr handle, MouseEventArgs eventArgs)
        {
            if (eventArgs.Button != MouseButtons.Left) return;
            User32Helper.ReleaseCapture();
            User32Helper.SendMessage(handle, User32Helper.WmNclButtonDown, User32Helper.HtCaption, 0);
        }
    }
}
