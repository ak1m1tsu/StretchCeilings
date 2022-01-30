using System;
using System.Runtime.InteropServices;

namespace StretchCeilings.Helpers.DLL
{
    public static class User32
    {
        private const int _wm_nclButtonDown = 0xA1;
        private const int _ht_caption = 0x2;

        public static int VM_NCLBUTTONDOWN => _wm_nclButtonDown;
        public static int HT_CAPTION => _ht_caption;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
