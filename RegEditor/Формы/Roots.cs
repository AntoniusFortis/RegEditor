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
            Restyler.WindowsReStyle(Handle);
        }

        private void Roots_MouseDown(object sender, MouseEventArgs e) => Restyler.MouseCapture(Handle);

        private void AddRoot()
        {
            var key = CurrentNode.Regkey;
            try
            {
                if (CurrentNode.Node.Parent != null)
                {
                    key = (RegistryKey)CurrentNode.Node.Parent.Tag;
                    key = key.OpenSubKey(CurrentNode.Node.Text, true);
                }
                key = key?.CreateSubKey(NameTbox.Text);
            }
            catch (Exception ex)
            {
                this.Msg(ex.Message, "Ошибка", icon: MessageBoxIcon.Error);
                return;
            }
            int indexNewNode = CurrentNode.Node.Nodes.Add(NameTbox.Text, NameTbox.Text).Index;
            CurrentNode.Node.Nodes[indexNewNode].Tag = key;
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
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                AcceptBtn.PerformClick();
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
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
            TitleLabel.Location = new System.Drawing.Point(TitleLabel.Location.X - 25, TitleLabel.Location.Y);
        }
    }
}
