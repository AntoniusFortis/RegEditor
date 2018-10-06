using System.Windows.Forms;
using Microsoft.Win32;

namespace RegEditor
{
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
