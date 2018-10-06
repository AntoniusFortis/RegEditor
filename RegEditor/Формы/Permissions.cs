using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

namespace RegEditor
{
    public partial class PermissionsForm : Form
    {
        public PermissionsForm()
        {
            InitializeComponent();
        }
        void PermissionsForm_Load(object sender, EventArgs e)
        {
            PathRootTbox.Text = CurrentNode.Node.FullPath;
            GetAccess();
        }
        void PermissionsForm_MouseDown(object sender, MouseEventArgs e)
        {
            Restyler.MouseCapture(Handle);
        }
        void GetAccess()
        {
            var listusers = new List<string>();
            var keyAccessControl = CurrentNode.Regkey.GetAccessControl();
            for (int i = 0; i < keyAccessControl.GetAccessRules(true, true, typeof(NTAccount)).Count; i++)
                listusers.Add(keyAccessControl.GetAccessRules(true, true, typeof(NTAccount))[i]?.IdentityReference.Value);
            object[] distinctArray = listusers.Distinct().ToArray();
            SelectUserComboBox.Items.AddRange(distinctArray);
            SelectUserComboBox.SelectedIndex = 0;
        }
        void SelectUserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistrySecurity keyAccessControl = CurrentNode.Regkey.GetAccessControl();
            foreach (RegistryAccessRule Rule in keyAccessControl.GetAccessRules(true, true, typeof(NTAccount)))
            {
                if (!Rule.IdentityReference.Value.Equals(SelectUserComboBox.SelectedItem))
                    continue;
                AccessControlTypeComboBox.SelectedIndex = (int)Rule.AccessControlType;
                RegistryRightComboBox.SelectedItem = GetDescriptionForRights(Rule.RegistryRights);
                var InHeritanceFlags = (int)Rule.InheritanceFlags;
                if (InHeritanceFlags < 3)
                    InHeritanceFlagsComboBox.SelectedIndex = InHeritanceFlags;
                if (Rule.IsInherited)
                    IsInheritedComboBox.SelectedIndex = 0;
                else
                    IsInheritedComboBox.SelectedIndex = 1;
                break;
            }
        }
        void EditButton_Click(object sender, EventArgs e)
        {
            RegistryRights[] ArrayRights =
            {
                RegistryRights.ChangePermissions, RegistryRights.CreateSubKey, RegistryRights.Delete,
                RegistryRights.EnumerateSubKeys, RegistryRights.FullControl, RegistryRights.Notify,
                RegistryRights.QueryValues, RegistryRights.ReadKey, RegistryRights.ReadPermissions,
                RegistryRights.SetValue, RegistryRights.TakeOwnership, RegistryRights.WriteKey
            };
            InheritanceFlags[] InheritanceFlags =
            {
                System.Security.AccessControl.InheritanceFlags.None,
                System.Security.AccessControl.InheritanceFlags.ContainerInherit,
                System.Security.AccessControl.InheritanceFlags.ObjectInherit
            };
            PropagationFlags[] PropagationFlag =
            {
                PropagationFlags.None,
                PropagationFlags.NoPropagateInherit,
                PropagationFlags.InheritOnly
            };
            AccessControlType[] _AccessControlType =
            {
                AccessControlType.Allow,
                AccessControlType.Deny
            };
            var key = (RegistryKey)CurrentNode.Node.Parent.Tag;
            key = key.OpenSubKey(CurrentNode.Node.Text, true);

            var newAccessRule = new RegistryAccessRule(SelectUserComboBox.Text,
                            ArrayRights[RegistryRightComboBox.SelectedIndex],
                            InheritanceFlags[InHeritanceFlagsComboBox.SelectedIndex],
                            PropagationFlag[IsInheritedComboBox.SelectedIndex],
                            _AccessControlType[AccessControlTypeComboBox.SelectedIndex]);

            var regSec = new RegistrySecurity();
            regSec.AddAccessRule(newAccessRule);
            key?.SetAccessControl(regSec);
        }
        void CloseButton_Click(object sender, EventArgs e) => Close();

        void DescrTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
        string GetDescriptionForRights(RegistryRights rights)
        {
            string rightsInfo;
            switch (rights)
            {
                case RegistryRights.ChangePermissions:
                    rightsInfo = "Изменение доступа и аудита"; break;
                case RegistryRights.CreateSubKey:
                    rightsInfo = "Создание подразделов"; break;
                case RegistryRights.Delete:
                    rightsInfo = "Удаление раздела"; break;
                case RegistryRights.EnumerateSubKeys:
                    rightsInfo = "Создание списка подразделов"; break;
                case RegistryRights.FullControl:
                    rightsInfo = "Полный доступ"; break;
                case RegistryRights.Notify:
                    rightsInfo = "Запрос уведовмления об изменении раздела"; break;
                case RegistryRights.QueryValues:
                    rightsInfo = "Запрос пар 'имя-значение' в разделе"; break;
                case RegistryRights.ReadKey:
                    rightsInfo = "Только чтение"; break;
                case RegistryRights.ReadPermissions:
                    rightsInfo = "Открытие и копирования правил доступа и аудита"; break;
                case RegistryRights.SetValue:
                    rightsInfo = "Доступ к паре 'имя-значение' раздела"; break;
                case RegistryRights.TakeOwnership:
                    rightsInfo = "Изменение владельца раздела"; break;
                case RegistryRights.WriteKey:
                    rightsInfo = "Чтение и запись подразделов и пар 'имя-значение'"; break;
                default:
                    rightsInfo = "Полный доступ"; break;
            }
            return rightsInfo;
        }
    }
}
