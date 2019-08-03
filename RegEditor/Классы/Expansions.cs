namespace RegEditor
{
    using System.Windows.Forms;
    using Microsoft.Win32;
    using static Microsoft.Win32.RegistryValueOptions;

    public static class RegistryEx
    {
        /// <summary>Переименование узла реестра</summary>
        /// <param name="registryKey">Родительский узел</param>
        /// <param name="keyNameToCopy">Название выбранного для переименования узла</param>
        /// <param name="newKeyName">Новое название</param>
        public static void RenameSubkey(this RegistryKey registryKey, string keyNameToCopy, string newKeyName)
        {
            var srckey = registryKey.OpenSubKey(keyNameToCopy);
            var destkey = registryKey.CreateSubKey(newKeyName);

            RecurseCopyKey(srckey, destkey);
            registryKey.DeleteSubKeyTree(keyNameToCopy);
        }

        private static void RecurseCopyKey(RegistryKey sourceKey, RegistryKey destinationKey)
        {
            var values = sourceKey.GetValueNames();
            var subkeys = sourceKey.GetSubKeyNames();

            var valueCount = sourceKey.ValueCount;
            var subKeyCount = sourceKey.SubKeyCount;

            for (var i = 0; i < valueCount; ++i)
            {
                var value = values[i];
                var valKind = sourceKey.GetValueKind(value);
                var regvalopt = valKind == RegistryValueKind.ExpandString ? DoNotExpandEnvironmentNames : None;
                var objValue = sourceKey.GetValue(value, string.Empty, regvalopt); 

                destinationKey.SetValue(value, objValue, valKind);
            }

            for (var i = 0; i < subKeyCount; ++i)
            {
                var subkey = subkeys[i];
                var sourceSubKey = sourceKey.OpenSubKey(subkey);
                var destSubKey = destinationKey.CreateSubKey(subkey);

                RecurseCopyKey(sourceSubKey, destSubKey);
            }
        }
    }

    public static class FormEx
    {
        public static DialogResult Msg(this Form wnd, string msg, string title = "", 
            MessageBoxButtons btns = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            return MetroFramework.MetroMessageBox.Show(wnd, msg, title, btns, icon);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(System.IntPtr hWnd, int msg, int wParam, int lParam);

        public static void MouseCapture(this Form wnd)
        {
            ReleaseCapture();

            var hwnd = wnd.Handle;

            const int msg = 0xA1;
            const int wparam = 0x2;
            const int iparam = 0;

            SendMessage(hwnd, msg, wparam, iparam);
        }

    }

    internal static class CurrentNode
    {
        public static TreeNode Node { get; private set; }
        public static RegistryKey Regkey { get; private set; }

        public static void SetNode(TreeNode tree)
        {
            Node = tree;
            var hive = (RegistryHive) tree.Tag;
            var rk = RegistryHelpers.OpenKey(tree.FullPath, hive);
            Regkey = rk;
        }

        public static void ChangeRegkey(RegistryKey rk)
        {
            Node.Tag = rk;
        }

        public static bool IsEmpty()
        {
            return Node == null;
        }
    }
}
