using System;
using System.Windows.Forms;
using StretchCeilings.Helpers.DLL;

namespace StretchCeilings.Helpers.Extensions
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
            User32.ReleaseCapture();
            User32.SendMessage(handle, User32.VM_NCLBUTTONDOWN, User32.HT_CAPTION, 0);
        }
    }
}
