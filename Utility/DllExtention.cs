using System;
using System.Runtime.InteropServices;

namespace stretch_ceilings_app.Utility
{
    public static class DllExtention
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
