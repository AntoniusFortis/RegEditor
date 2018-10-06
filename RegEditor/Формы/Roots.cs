using Microsoft.Win32;
using System;
using System.Windows.Forms;
namespace RegEditor
{
    public partial class Roots : Form
    {
        private readonly bool _renameMode;
        public Roots(bool renameMode = false)
        {
            _renameMode = renameMode;
            InitializeComponent();
        }
        void Form_AddRoot_Load(object sender, EventArgs e)
        {
            if (_renameMode)
            {
                RootNameTextBox.Text = CurrentNode.Node.Text;
                label1.Text = @"Переименовать раздел";
                label1.Location = new System.Drawing.Point(label1.Location.X - 25, label1.Location.Y);
            }
        }

        void Roots_MouseDown(object sender, MouseEventArgs e)
        {
            Restyler.MouseCapture(Handle);
        }

        void AcceptButton_Click(object sender, EventArgs e)
        {
            if (_renameMode)
                RenameRoot();
            else
                AddRoot();
        }
        void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        void AddRoot_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
                AcceptButton.PerformClick();
            if (e.KeyCode == Keys.Escape)
                CloseButton.PerformClick();
        }
        void AddRoot()
        {
            var key = CurrentNode.Regkey;
            try
            {
                if (CurrentNode.Node.Parent != null)
                {
                    key = (RegistryKey)CurrentNode.Node.Parent.Tag;
                    key = key.OpenSubKey(CurrentNode.Node.Text, true);
                }
                key = key?.CreateSubKey(RootNameTextBox.Text);
            }
            catch (Exception ex)
            {
                Msg(ex.Message, "Ошибка", MessageBoxIcon.Error, MessageBoxButtons.OK);
                return;
            }
            int indexNewNode = CurrentNode.Node.Nodes.Add(RootNameTextBox.Text, RootNameTextBox.Text).Index;
            CurrentNode.Node.Nodes[indexNewNode].Tag = key;
            Close();
        }
        void RenameRoot()
        {
            if (RootNameTextBox.Text == "")
            {
                Msg("Введите новое название для раздела!", "Ошибка", MessageBoxIcon.Error, MessageBoxButtons.OK);
                return;
            }
            RegistryKey key;
            var parentSelectedKey = (RegistryKey)CurrentNode.Node.Parent.Tag;
            if (CurrentNode.Node.Parent.Parent != null)
            {
                key = (RegistryKey)CurrentNode.Node.Parent.Parent.Tag;
                key = key.OpenSubKey(CurrentNode.Node.Parent.Text, true);
            }
            else
            {
                key = parentSelectedKey;
            }
            try
            {
                Rename_SubKey(key, CurrentNode.Node.Text, RootNameTextBox.Text);
            }
            catch (Exception ex)
            {
                Msg(ex.Message, "Ошибка", MessageBoxIcon.Error, MessageBoxButtons.OK);
                return;
            }
            CurrentNode.Node.Text = RootNameTextBox.Text;
            CurrentNode.ChangeRegkey(parentSelectedKey.OpenSubKey(CurrentNode.Node.Text));
            Close();
        }

        /// <summary>Переименование узла реестра</summary>
        /// <param name="parentKey">Родительский узел</param>
        /// <param name="subKeyName">Название выбранного для переименования узла</param>
        /// <param name="newSubKeyName">Новое название</param>
        void Rename_SubKey(RegistryKey parentKey, string subKeyName, string newSubKeyName)
        {
            CopyKey(parentKey, subKeyName, newSubKeyName);
            parentKey.DeleteSubKeyTree(subKeyName);
        }
        void CopyKey(RegistryKey parentKey, string keyNameToCopy, string newKeyName)
        {
            RegistryKey destinationKey = parentKey.CreateSubKey(newKeyName);
            RegistryKey sourceKey = parentKey.OpenSubKey(keyNameToCopy);
            RecurseCopyKey(sourceKey, destinationKey);
        }
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

        private void Msg(string msg, string title, MessageBoxIcon icon = MessageBoxIcon.Question,
            MessageBoxButtons btns = MessageBoxButtons.YesNo)
        {
            MetroFramework.MetroMessageBox.Show(this, msg, title, btns, icon);
        }

    }
}
