using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using RegEditor.Properties;

namespace RegEditor
{
    public static class RegistryHelpers
    {
        private static RegistryView GetRegistry()
        {
            return Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
        }

        private static int GetCount(RegistryHive hive)
        {
            int result = 0;
            switch (hive)
            {
                case RegistryHive.ClassesRoot:
                    result = "HKEY_CLASSES_ROOT".Length;
                    break;
                case RegistryHive.CurrentUser:
                    result = "HKEY_CURRENT_USER".Length;
                    break;
                case RegistryHive.LocalMachine:
                    result = "HKEY_LOCAL_MACHINE".Length;
                    break;
                case RegistryHive.Users:
                    result = "HKEY_USERS".Length;
                    break;
                case RegistryHive.CurrentConfig:
                    result = "HKEY_CURRENT_CONFIG".Length;
                    break;
            }
            return result;
        }

        public static RegistryKey OpenKey(string path, RegistryHive hive, RegistryKeyPermissionCheck permission = RegistryKeyPermissionCheck.ReadSubTree)
        {
            path = path.Remove(0, GetCount(hive));

            RegistryKey rk = RegistryKey.OpenBaseKey(hive, GetRegistry());

            if (path.Length == 0)
            {
                return rk;
            }

            path = path.Remove(0, 1);

            RegistryKey rk2;
            try
            {

                rk2 = rk.OpenSubKey(path, permission);
            }
            catch (Exception)
            {
                rk2 = null;
            }

            rk.Close();

            return rk2;
        }

        public static void ParseKeyValue(RegistryValueKind type, RegistryKey key, string value, out object keyValue, out Bitmap icon)
        {
            keyValue = "";
            icon = null;

            switch (type)
            {
                case RegistryValueKind.Binary:
                {
                    icon = Resources.KeyBinary;
                    var array = (byte[]) key.GetValue(value);
                    keyValue = array.Aggregate(keyValue, (current, t) => current + $"{t:X2} ");
                    break;
                }
                case RegistryValueKind.MultiString:
                {
                    icon = Resources.KeyMultiString;
                    var array = (string[]) key.GetValue(value);
                    keyValue = array.Aggregate(keyValue, (current, t) => current + $"{t} ");
                    break;
                }
                case RegistryValueKind.DWord:
                {
                    icon = Resources.KeyDword;
                    keyValue = $"{key.GetValue(value):X}";
                    break;
                }
                case RegistryValueKind.QWord:
                {
                    icon = Resources.KeyQword;
                    keyValue = $"{key.GetValue(value):X}";
                    break;
                }
                case RegistryValueKind.ExpandString:
                {
                    icon = Resources.KeyExpandString;
                    keyValue = key.GetValue(value, "", RegistryValueOptions.DoNotExpandEnvironmentNames);
                    break;
                }
                case RegistryValueKind.String:
                {
                    icon = Resources.KeyString;
                    keyValue = key.GetValue(value);
                    break;
                }
            }
        }

        public static void AddSubkeys(TreeNode node)
        {
            var hive = (RegistryHive)node.Tag;
            var path = node.FullPath;

            string[] subkeys;

            using (var rk = OpenKey(path, hive))
            {
                subkeys = rk.GetSubKeyNames();
            }

            node.Nodes.Clear();

            var results = new ConcurrentBag<TreeNode>();
            Parallel.ForEach(subkeys, subkey =>
            {
                var newNode = new TreeNode(subkey);
                using (var key = OpenKey($@"{path}\{subkey}", hive))
                {
                    if (key != null)
                    {
                        newNode.Tag = hive;
                        if (key.SubKeyCount > 0 && newNode.Nodes.Count == 0)
                            newNode.Nodes.Add("");
                    }
                }
                results.Add(newNode);
            });

            node.Nodes.AddRange(results.ToArray());
        }
    }
}
