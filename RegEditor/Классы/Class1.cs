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

            void RecurseCopyKey(RegistryKey sourceKey, RegistryKey destinationKey)
            {
                string[] values = sourceKey.GetValueNames();
                string[] subkeys = sourceKey.GetSubKeyNames();
                for (int i = 0; sourceKey.ValueCount > 0 & i < sourceKey.ValueCount; ++i)
                {
                    var objValue = sourceKey.GetValue(values[i]);
                    var valKind = sourceKey.GetValueKind(values[i]);
                    if (valKind == RegistryValueKind.ExpandString)
                        objValue = sourceKey.GetValue(values[i], "", RegistryValueOptions.DoNotExpandEnvironmentNames);
                    destinationKey.SetValue(values[i], objValue, valKind);
                }
                for (int i = 0; i < sourceKey.SubKeyCount; ++i)
                {
                    var sourceSubKey = sourceKey.OpenSubKey(subkeys[i]);
                    var destSubKey = destinationKey.CreateSubKey(subkeys[i]);
                    RecurseCopyKey(sourceSubKey, destSubKey);
                }
            }
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
