using System;
using System.Runtime.InteropServices;

namespace StretchCeilings.UI.Helpers
{
    public static class User32Helper
    {
        public const int WmNclButtonDown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
