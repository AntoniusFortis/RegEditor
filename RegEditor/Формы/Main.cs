using Microsoft.Win32;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/*


    ПЕРЕДЕЛАТЬ ВСЁ

    
*/
namespace RegEditor
{
    public partial class MainForm : Form
    {
        // Константы и переменные для развертывания формы
        private bool _windowMaximized;
        private int _tempWidth, _tempHeight;
        private Point _tempLocation;
        //

        public MainForm() => InitializeComponent();

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Restyler.WindowsReStyle(Handle);

            // Отображаем базовые разделы
            LoadMainHkey();
        }

        private void LoadMainHkey()
        {
            RootsTreeView.Nodes[0].Tag = Registry.ClassesRoot;
            RootsTreeView.Nodes[1].Tag = Registry.CurrentConfig;
            RootsTreeView.Nodes[2].Tag = Registry.CurrentUser;
            RootsTreeView.Nodes[3].Tag = Registry.LocalMachine;
            RootsTreeView.Nodes[4].Tag = Registry.Users;
        }

        private void Main_Form_KeysDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case System.Windows.Forms.Keys.W: NewKeyBtn.PerformClick(); break;
                case System.Windows.Forms.Keys.E: EditKeyBtn.PerformClick(); break;
                case System.Windows.Forms.Keys.G: RemoveKeyBtn.PerformClick(); break;
                case System.Windows.Forms.Keys.A: NewRootBtn.PerformClick(); break;
                case System.Windows.Forms.Keys.R: RenameRootBtn.PerformClick(); break;
                case System.Windows.Forms.Keys.Delete: RemoveRootBtn.PerformClick(); break;
                case System.Windows.Forms.Keys.H: AboutBtn.PerformClick(); break;
                case System.Windows.Forms.Keys.F:
                    {
                        if (e.Modifiers == System.Windows.Forms.Keys.Control)
                            SearchBtn.PerformClick();
                        break;
                    }
            }
        }

        private void Main_Form_MouseDown(object sender, MouseEventArgs e) => Restyler.MouseCapture(Handle);

        private void MinimizeAppButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

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

        private void RootsTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e) => ShowRoots(e.Node);

        private void ShowRoots(TreeNode node)
        {
            var curnode = node;
            var currentKey = (RegistryKey)curnode.Tag;

            curnode.Nodes.Clear();

            string[] subkeys = currentKey.GetSubKeyNames();

            foreach (var subkey in subkeys)
            {
                var newNode = curnode.Nodes.Add(subkey, subkey);
                RegistryKey key = null;
                try
                {
                    key = currentKey.OpenSubKey(subkey);
                }
                catch (Exception)
                {
                    // ignored
                }

                if (key != null)
                {
                    newNode.Tag = key;
                    if (key.SubKeyCount > 0 && newNode.Nodes.Count == 0)
                        newNode.Nodes.Add("");
                }
            }
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
            RegistryKey key;
            string keyPath = "";
            if (CurrentNode.Node.Parent.Parent != null)
            {
                key = (RegistryKey)CurrentNode.Node.Parent.Parent.Tag;
                keyPath = CurrentNode.Node.Parent.Text;
            }
            else
            {
                key = (RegistryKey)CurrentNode.Node.Parent.Tag;
            }
            try
            {
                if (CurrentNode.Node.Parent.Parent != null)
                    key = key.OpenSubKey(keyPath, true);
                key?.DeleteSubKeyTree(CurrentNode.Node.Text);
            }
            catch (Exception ex)
            {
                Msg(ex.Message, "Удаление раздела", icon: MessageBoxIcon.Error);
            }
            finally
            {
                var tr = CurrentNode.Node;
                tr.Remove();
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
                Msg(ex.Message, "Удаление ключа", icon: MessageBoxIcon.Error);
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
                Msg("Нет доступа");
                return;
            }

            foreach (var value in arrayValueNames)
            {
                var keyKind = key.GetValueKind(value);
                object keyValue = ""; // Переменная для хранения значения ключа
                Bitmap keyKindPicture; // Переменная для хранения пикчи типа ключа
                switch (keyKind)
                {
                    case RegistryValueKind.Binary:
                    {
                        keyKindPicture = Properties.Resources.KeyBinary;
                        var array = (byte[]) key.GetValue(value);
                        keyValue = array.Aggregate(keyValue, (current, t) => current + $"{t:X2} ");
                        break;
                    }
                    case RegistryValueKind.MultiString:
                    {
                        keyKindPicture = Properties.Resources.KeyMultiString;
                        var array = (string[]) key.GetValue(value);
                        keyValue = array.Aggregate(keyValue, (current, t) => current + $"{t} ");
                        break;
                    }
                    case RegistryValueKind.DWord:
                    {
                        keyKindPicture = Properties.Resources.KeyDword;
                        keyValue = $"{key.GetValue(value):X}";
                        break;
                    }
                    case RegistryValueKind.QWord:
                    {
                        keyKindPicture = Properties.Resources.KeyQword;
                        keyValue = $"{key.GetValue(value):X}";
                        break;
                    }
                    case RegistryValueKind.ExpandString:
                    {
                        keyKindPicture = Properties.Resources.KeyExpandString;
                        keyValue = key.GetValue(value, "", RegistryValueOptions.DoNotExpandEnvironmentNames);
                        break;
                    }
                    case RegistryValueKind.String:
                    {
                        keyKindPicture = Properties.Resources.KeyString;
                        keyValue = key.GetValue(value);
                        break;
                    }
                    default:
                    {
                        return;
                    }
                }
                KeysView.Rows.Add(keyKindPicture, value, keyKind, keyValue); // Добавляем в список
            }
        }

        private void NewRootBtn_Click(object sender, EventArgs e)
        {
            if (CurrentNode.IsEmpty())
                return;

            var roots = new Roots();
            roots.ShowDialog(this);
            ShowRoots(CurrentNode.Node);
        }

        private void RenameRootBtn_Click(object sender, EventArgs e)
        {
            if (CurrentNode.IsEmpty())
            {
                Msg("Чтобы переименовать раздел, вы должны его выбрать.", "Переименовать раздел");
                return;
            }

            var roots = new Roots(true);
            roots.ShowDialog(this);
        }

        private void RemoveRootBtn_Click(object sender, EventArgs e)
        {
            if (CurrentNode.IsEmpty())
            {
                Msg("Чтобы удалить раздел, вы должны его выбрать.", "Переименовать раздел");
                return;
            }
            var result = Msg("Вы уверены, что хотите удалить этот раздел?", "Удалить раздел", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            RemoveTree();
        }

        private void ChangeAccessBtn_Click(object sender, EventArgs e)
        {
            if (CurrentNode.IsEmpty())
                return;

            var formAccess = new Permissions();
            formAccess.ShowDialog(this);
        }

        private void NewKeyBtn_Click(object sender, EventArgs e)
        {
            if (CurrentNode.IsEmpty())
            {
                Msg("Перед добавление ключа, вы должны выбрать его!", "Добавление ключа");
                return;
            }
            var values = new Keys();
            values.ShowDialog(this);
            ViewValues(CurrentNode.Regkey);
        }

        private void EditKeyBtn_Click(object sender, EventArgs e)
        {
            if (KeysView.CurrentCell == null)
            {
                Msg("Перед редактированием ключа, вы должны выбрать его!", "Редактирование параметра");
                return;
            }

            var values = new Keys
            (
                true,
                KeysView.CurrentRow?.Cells[1].Value,
                KeysView.CurrentRow?.Cells[2].Value,
                KeysView.CurrentRow?.Cells[3].Value
            );
            values.ShowDialog(this);
            ViewValues(CurrentNode.Regkey);
        }

        private void RemoveKeyBtn_Click(object sender, EventArgs e)
        {
            if (KeysView.CurrentRow == null)
            {
                Msg("Перед удалением ключа, вы должны выбрать его!", "Редактирование ключа");
                return;
            }
            var result = Msg("Вы уверены, что хотите удалить этот ключ?", "Удалить ключ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            RemoveValue();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //var searchForm = new SearchForm();
           //searchForm.Show(this);
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            var aboutProduct = new AboutProduct();
            aboutProduct.ShowDialog();
        }

        private DialogResult Msg(string msg, string title = "", MessageBoxButtons btns = MessageBoxButtons.OK, 
            MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            return MetroFramework.MetroMessageBox.Show(this, msg, title, btns, icon);
        }
    } 
} 
