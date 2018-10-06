using System;

namespace RegEditor
{
    static class Restyler
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr GetMenu(IntPtr hWnd);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool DrawMenuBar(IntPtr hWnd);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        public static void MouseCapture(IntPtr handle)
        {
            ReleaseCapture();

            IntPtr hwnd = handle;

            const int msg = 0xA1;
            const int wparam = 0x2;
            const int iparam = 0;

            SendMessage(hwnd, msg, wparam, iparam);
        }

        public static void WindowsReStyle(IntPtr handle)
        {
            const int gwlStyle = -16;
            const int wsBorder = 0x00800000;
            const int wsCaption = wsBorder | 0x00400000;

            const uint uPosition = 0;
            const uint uFlags = 0x400 | 0x1000;

            IntPtr hwnd = handle;

            int style = GetWindowLong(hwnd, gwlStyle);
            RemoveMenu(GetMenu(hwnd), uPosition, uFlags);

            SetWindowLong(hwnd, gwlStyle, style & ~wsBorder);
            SetWindowLong(hwnd, gwlStyle, style & ~wsCaption);

            DrawMenuBar(hwnd);
        }
    }
}
