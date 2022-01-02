using System;
using System.Runtime.InteropServices;

namespace stretch_ceilings_app.Utility.Extensions
{
    public static class DllExtensions
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
