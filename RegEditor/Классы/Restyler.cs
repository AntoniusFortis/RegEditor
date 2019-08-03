namespace RegEditor
{
    using System;

    internal static class Restyler
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

        public static void WindowsReStyle(IntPtr handle)
        {
            const int gwlStyle = -16;
            const int wsBorder = 0x00800000;
            const int wsCaption = wsBorder | 0x00400000;

            const uint uPosition = 0;
            const uint uFlags = 0x400 | 0x1000;

            var hwnd = handle;
            var style = GetWindowLong(hwnd, gwlStyle);

            RemoveMenu(GetMenu(hwnd), uPosition, uFlags);

            SetWindowLong(hwnd, gwlStyle, style & ~wsBorder & ~wsCaption);

            DrawMenuBar(hwnd);
        }
    }
}
