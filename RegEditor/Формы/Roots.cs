using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RegEditor
{
    public partial class Roots : Form
    {
        private readonly bool _renameMode;

        public Roots(bool renameMode)
        {
            _renameMode = renameMode;
            InitializeComponent();
            Restyler.WindowsReStyle(Handle);
        }

        private void Roots_MouseDown(object sender, MouseEventArgs e) => this.MouseCapture();

        private void AddRoot()
        {
            var path = CurrentNode.Node.FullPath;
            var hive = (RegistryHive)CurrentNode.Node.Tag;
            try
            {
                using (var key = RegistryHelpers.OpenKey(path, hive, RegistryKeyPermissionCheck.ReadWriteSubTree))
                {
                    key?.CreateSubKey(NameTbox.Text, RegistryKeyPermissionCheck.ReadSubTree);
                }
            }
            catch (Exception ex)
            {
                this.Msg(ex.Message, "Ошибка", icon: MessageBoxIcon.Error);
                return;
            }
            int indexNewNode = CurrentNode.Node.Nodes.Add(NameTbox.Text, NameTbox.Text).Index;
            CurrentNode.Node.Nodes[indexNewNode].Tag = CurrentNode.Node.Tag;
            Close();
        }

        private void RenameRoot()
        {
            if (NameTbox.Text == "")
            {
                this.Msg("Введите новое название для раздела!", "Ошибка", icon: MessageBoxIcon.Error);
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
                key.RenameSubkey(CurrentNode.Node.Text, NameTbox.Text);
            }
            catch (Exception ex)
            {
                this.Msg(ex.Message, "Ошибка", icon: MessageBoxIcon.Error);
                return;
            }
            CurrentNode.Node.Text = NameTbox.Text;
            CurrentNode.ChangeRegkey(parentSelectedKey.OpenSubKey(CurrentNode.Node.Text));
            Close();
        }

        private void Roots_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AcceptBtn.PerformClick();
            if (e.KeyCode == Keys.Escape)
                CloseBtn.PerformClick();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (_renameMode)
                RenameRoot();
            else
                AddRoot();
        }

        private void CloseBtn_Click(object sender, EventArgs e) => Close();

        private void Roots_Load(object sender, EventArgs e)
        {
            if (!_renameMode)
                return;

            NameTbox.Text = CurrentNode.Node.Text;
            TitleLabel.Text = @"Переименовать раздел";
            TitleLabel.Location = new Point(TitleLabel.Location.X - 25, TitleLabel.Location.Y);
        }
    }
}
