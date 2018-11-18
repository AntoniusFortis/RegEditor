using System.Windows.Forms;
using Microsoft.Win32;

namespace RegEditor
{
    public static class RegistryEx
    {
        /// <summary>Переименование узла реестра</summary>
        /// <param name="registryKey">Родительский узел</param>
        /// <param name="keyNameToCopy">Название выбранного для переименования узла</param>
        /// <param name="newKeyName">Новое название</param>
        public static void RenameSubkey(this RegistryKey registryKey, string keyNameToCopy, string newKeyName)
        {
            RecurseCopyKey(registryKey.OpenSubKey(keyNameToCopy), registryKey.CreateSubKey(newKeyName));
            registryKey.DeleteSubKeyTree(keyNameToCopy);
        }

        private static void RecurseCopyKey(RegistryKey sourceKey, RegistryKey destinationKey)
        {
            string[] values = sourceKey.GetValueNames();
            string[] subkeys = sourceKey.GetSubKeyNames();

            int valueCount = sourceKey.ValueCount;

            for (int i = 0; valueCount > 0 & i < valueCount; ++i)
            {
                var objValue = sourceKey.GetValue(values[i]);
                var valKind = sourceKey.GetValueKind(values[i]);
                if (valKind == RegistryValueKind.ExpandString)
                    objValue = sourceKey.GetValue(values[i], "", RegistryValueOptions.DoNotExpandEnvironmentNames);
                destinationKey.SetValue(values[i], objValue, valKind);
            }

            int subKeyCount = sourceKey.SubKeyCount;

            for (int i = 0; i < subKeyCount; ++i)
            {
                var sourceSubKey = sourceKey.OpenSubKey(subkeys[i]);
                var destSubKey = destinationKey.CreateSubKey(subkeys[i]);
                RecurseCopyKey(sourceSubKey, destSubKey);
            }
        }
    }

    public static class FormEx
    {
        public static DialogResult Msg(this Form wnd, string msg, string title = "", MessageBoxButtons btns = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            return MetroFramework.MetroMessageBox.Show(wnd, msg, title, btns, icon);
        }

    }



    static class CurrentNode
    {
        public static TreeNode Node { get; private set; }
        public static RegistryKey Regkey { get; private set; }

        public static void SetNode(TreeNode tree)
        {
            Node = tree;
            Regkey = (RegistryKey)tree.Tag;
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
