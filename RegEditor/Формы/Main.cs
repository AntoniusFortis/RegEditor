using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace RegEditor
{
    public partial class MainForm : Form
    {
        // Константы и переменные для развертывания формы
        private bool _windowMaximized;
        private int _tempWidth, _tempHeight;
        private Point _tempLocation;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Restyler.WindowsReStyle(Handle);
            LoadMainHkey();
        }

        private void LoadMainHkey()
        {
            RootsTreeView.Nodes[0].Tag = RegistryHive.ClassesRoot;
            RootsTreeView.Nodes[1].Tag = RegistryHive.CurrentConfig;
            RootsTreeView.Nodes[2].Tag = RegistryHive.CurrentUser;
            RootsTreeView.Nodes[3].Tag = RegistryHive.LocalMachine;
            RootsTreeView.Nodes[4].Tag = RegistryHive.Users;
        }

        private void Main_Form_KeysDown(object sender, KeyEventArgs e)
        {
            ToolStripMenuItem button = null;
            switch (e.KeyCode)
            {
                case Keys.W:
                    button = NewKeyBtn;
                    break;
                case Keys.E:
                    button = EditKeyBtn;
                    break;
                case Keys.G:
                    button = RemoveKeyBtn;
                    break;
                case Keys.A:
                    button = NewRootBtn;
                    break;
                case Keys.R:
                    button = RenameRootBtn;
                    break;
                case Keys.Delete:
                    button = RemoveRootBtn;
                    break;
                case Keys.H:
                    button = AboutBtn;
                    break;
                case Keys.F:
                    if (e.Modifiers == Keys.Control)
                        button = SearchBtn;
                    break;
            }
            button?.PerformClick();
        }

        private void Main_Form_MouseDown(object sender, MouseEventArgs e)
        {
            this.MouseCapture();
        }

        private void MinimizeAppButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizeAppButton_Click(object sender, EventArgs e)
        {
            if (!_windowMaximized)
            {
                _tempWidth = Width;
                _tempHeight = Height;
                _tempLocation = Location;
                Width = Screen.PrimaryScreen.WorkingArea.Width + 14;
                Height = Screen.PrimaryScreen.WorkingArea.Height + 7;
                Location = new Point(-7, 0);
                _windowMaximized = true;
            }
            else
            {
                Width = _tempWidth;
                Height = _tempHeight;
                Location = _tempLocation;
                _windowMaximized = false;
            }
        }

        private void CloseAppButton_Click(object sender, EventArgs e) => Application.Exit();

        private void KeysView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => EditKeyBtn.PerformClick();

        private void RootsTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            RegistryHelpers.AddSubkeys(e.Node);
        }


        private void RootsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CurrentNode.SetNode(e.Node);

            ViewValues(CurrentNode.Regkey);
            PathRootTbox.Text = CurrentNode.Regkey.Name;
            CountsSubkeysLabel.Text = CurrentNode.Regkey.SubKeyCount.ToString();
        }

        private void RemoveTree()
        {
            var hive = (RegistryHive) CurrentNode.Node.Tag;
            var target = CurrentNode.Node.Text;

            if (CurrentNode.Node.Parent == null)
                return;

            var targetNode = CurrentNode.Node;

            CurrentNode.SetNode(CurrentNode.Node.Parent);
            try
            {
                using (var key = RegistryHelpers.OpenKey(CurrentNode.Node.FullPath, hive,
                    RegistryKeyPermissionCheck.ReadWriteSubTree))
                {
                    key?.DeleteSubKeyTree(target);
                }
            }
            catch (Exception ex)
            {
                this.Msg(ex.Message, "Удаление раздела", icon: MessageBoxIcon.Error);
            }
            finally
            {
                targetNode.Remove();
            }
        }

        private void RemoveValue()
        {
            var key = (RegistryKey)CurrentNode.Node.Parent.Tag;
            try
            {
                key = key.OpenSubKey(CurrentNode.Node.Text, true);
                if (KeysView.CurrentRow != null)
                    key?.DeleteValue((string) KeysView.CurrentRow?.Cells[1].Value);
            }
            catch (Exception ex)
            {
                this.Msg(ex.Message, "Удаление ключа", icon: MessageBoxIcon.Error);
            }
            finally
            {
                ViewValues(key);
            }
        }

        private void ViewValues(RegistryKey key)
        {
            KeysView.Rows.Clear(); // Очищаем список ключей
            string[] arrayValueNames;
            try // Проверяем, что есть доступ
            {
                arrayValueNames = key.GetValueNames();
            }
            catch
            {
                this.Msg("Нет доступа");
                return;
            }

            var collection = new DataGridViewRow[arrayValueNames.Length];
            for (var index = 0; index < arrayValueNames.Length; index++)
            {
                var value = arrayValueNames[index];
                var keyKind = key.GetValueKind(value);

                RegistryHelpers.ParseKeyValue(keyKind, key, value, out var keyValue, out var icon);
                collection[index] = new DataGridViewRow();
                collection[index].CreateCells(KeysView, new object[] {icon, value, keyKind, keyValue});
            }

            KeysView.Rows.AddRange(collection.ToArray());
        }

        private void NewRootBtn_Click(object sender, EventArgs e)
        {
            var roots = new Roots(false);
            var result = roots.ShowDialog();

            if (result == DialogResult.OK)
                RegistryHelpers.AddSubkeys(CurrentNode.Node);
        }

        private void RenameRootBtn_Click(object sender, EventArgs e)
        {
            var roots = new Roots(true);
            roots.ShowDialog();
        }


        private void ChangeAccessBtn_Click(object sender, EventArgs e)
        {
            using (var form = new Permissions())
            {
                form.ShowDialog();
            }
        }

        private void RemoveRootBtn_Click(object sender, EventArgs e)
        {
            var result = this.Msg("Вы уверены, что хотите удалить этот раздел?", "Удалить раздел", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                RemoveTree();
        }

        private void NewKeyBtn_Click(object sender, EventArgs e)
        {
            if (CurrentNode.IsEmpty())
            {
                this.Msg("Перед добавление ключа, вы должны выбрать раздел!", "Добавление ключа");
                return;
            }

            var values = new KeysDlg(false);
            var result = values.ShowDialog();

            values.Dispose();

            if (result == DialogResult.OK)
                ViewValues(CurrentNode.Regkey);
        }

        private void EditKeyBtn_Click(object sender, EventArgs e)
        {
            if (KeysView.CurrentRow == null)
            {
                this.Msg("Перед редактированием ключа, вы должны выбрать его!", "Редактирование параметра");
                return;
            }

            KeysBus.Name = KeysView.CurrentRow.Cells[1].Value.ToString();
            KeysBus.Type = KeysView.CurrentRow.Cells[2].Value.ToString();
            KeysBus.Value = KeysView.CurrentRow.Cells[3].Value.ToString();

            DialogResult result;
            using (var form = new KeysDlg(true))
            {
                result = form.ShowDialog();
            }

            if (result == DialogResult.OK)
                ViewValues(CurrentNode.Regkey);
        }

        private void RemoveKeyBtn_Click(object sender, EventArgs e)
        {
            if (KeysView.CurrentRow == null)
            {
                this.Msg("Перед удалением ключа, вы должны выбрать его!", "Редактирование ключа");
                return;
            }

            var result = this.Msg("Вы уверены, что хотите удалить этот ключ?", "Удалить ключ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                RemoveValue();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            using (var form = new AboutProduct())
            {
                form.ShowDialog();
            }
        }
    } 
} 
