using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RegEditor
{
    public partial class Permissions : Form
    {
        public Permissions() => InitializeComponent();

        private void GetAccess()
        {
            var keyAccessControl = CurrentNode.Regkey.GetAccessControl();

            var rules = keyAccessControl.GetAccessRules(true, true, typeof(NTAccount));

            var listusers = new List<string>(rules.Count);
            foreach (AuthorizationRule rule in rules)
            {
                listusers.Add(rule.IdentityReference.Value);
            }

            var disctincted = listusers.Distinct();

            foreach (var user in disctincted)
            {
                SelectUserComboBox.Items.Add(user);
            }

            SelectUserComboBox.SelectedIndex = 0;
        }

        private void SelectUserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var keyAccessControl = CurrentNode.Regkey.GetAccessControl();

            foreach (RegistryAccessRule rule in keyAccessControl.GetAccessRules(true, true, typeof(NTAccount)))
            {
                if (!rule.IdentityReference.Value.Equals(SelectUserComboBox.SelectedItem))
                    continue;

                AccessControlTypeComboBox.SelectedIndex = (int)rule.AccessControlType;
                RegistryRightComboBox.SelectedItem = GetDescriptionForRights(rule.RegistryRights);
                var inHeritanceFlags = (int)rule.InheritanceFlags;

                InHeritanceFlagsComboBox.SelectedIndex = inHeritanceFlags - 1;

                IsInheritedComboBox.SelectedIndex = rule.IsInherited ? 0 : 1;
                break;
            }
        }

        private void DescrTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private string GetDescriptionForRights(RegistryRights rights)
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

        private void Permissions_MouseDown(object sender, MouseEventArgs e) => this.MouseCapture();

        private void Permissions_Load(object sender, EventArgs e)
        {
            Restyler.WindowsReStyle(Handle);

            PathRootTbox.Text = CurrentNode.Node.FullPath;
            GetAccess();
        }

        private void CloseBtn_Click(object sender, EventArgs e) => Close();

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            RegistryRights[] arrayRights =
            {
                RegistryRights.ChangePermissions, RegistryRights.CreateSubKey, RegistryRights.Delete,
                RegistryRights.EnumerateSubKeys, RegistryRights.FullControl, RegistryRights.Notify,
                RegistryRights.QueryValues, RegistryRights.ReadKey, RegistryRights.ReadPermissions,
                RegistryRights.SetValue, RegistryRights.TakeOwnership, RegistryRights.WriteKey
            };

            InheritanceFlags[] inheritanceFlags =
            {
                InheritanceFlags.None,
                InheritanceFlags.ContainerInherit,
                InheritanceFlags.ObjectInherit
            };
            PropagationFlags[] propagationFlag =
            {
                PropagationFlags.None,
                PropagationFlags.NoPropagateInherit,
                PropagationFlags.InheritOnly
            };
            AccessControlType[] accessControlType =
            {
                AccessControlType.Allow,
                AccessControlType.Deny
            };
            var key = (RegistryKey)CurrentNode.Node.Parent.Tag;
            key = key.OpenSubKey(CurrentNode.Node.Text, true);

            var rights = arrayRights[RegistryRightComboBox.SelectedIndex];
            var inheritance = inheritanceFlags[InHeritanceFlagsComboBox.SelectedIndex];
            var propagation = propagationFlag[IsInheritedComboBox.SelectedIndex];
            var access = accessControlType[AccessControlTypeComboBox.SelectedIndex];

            var newAccessRule = new RegistryAccessRule(SelectUserComboBox.Text, rights, inheritance, propagation, access);

            var regSec = new RegistrySecurity();
            regSec.AddAccessRule(newAccessRule);
            key?.SetAccessControl(regSec);
            //Close();
        }
    }
}
