using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
#pragma warning disable RCS1018 // Add default access modifier.
#pragma warning disable RCS1023 // Format empty block.
#pragma warning disable RCS1057 // Add empty line between declarations.
#pragma warning disable RCS1161 // Enum member should declare explicit value.
namespace RegEditor
{
    public partial class SearchForm : Form
    {
        readonly int WM_NCLBUTTONDOWN = 0xA1;
        readonly int HT_CAPTION = 0x2;

        bool WindowMaximized;
        int temp_width, temp_height;
        System.Drawing.Point temp_location;

        public enum SearchModes { VariablesMode, RootsMode, ValueMode }
        public SearchModes SearchMode = SearchModes.RootsMode; // Тип поиска
        public RegistryKey[] RegistryKeys = new RegistryKey[5]; // Массив разделов реестра, где будет идти поиск
        public StringComparison ComparisonType = StringComparison.OrdinalIgnoreCase; // Для зависимости от регистра
        public bool UnitString; // Целое слово
        //////////////////////////////////////////////////
        public SearchForm() => InitializeComponent();
        void SearchForm_Load(object sender, EventArgs e) => CheckForIllegalCrossThreadCalls = false;
        void SearchForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case System.Windows.Forms.Keys.Enter:
                    {
                        StartSearchButton.PerformClick();
                        break;
                    }
                //case Keys.Escape:
                //    {
                //        CloseFormButton.PerformClick();
                //        break;
                //    }
            }
        }
        //////////////////////////////////////////////////
        void StartSearchButton_Click(object sender, EventArgs e)
        {
            ListObjectsDataGridView.Rows.Clear();
            var SelectedRegistryHive = RegistryKeys.Where(d => d != null);
            if (!SelectedRegistryHive.Any())
            {
                CllShrtMsg("Вы не выбрали разделы, в которых будет произведён поиск!", "Поиск", MessageBoxIcon.Warning, MessageBoxButtons.OK);
                return;
            }
            switch (SearchMode)
            {
                case SearchModes.VariablesMode: // Variable 
                    {
                        if (SearchVariableFlow.IsBusy)
                        {
                            StartSearchButton.Text = "Поиск (Enter)";
                            SearchVariableFlow.CancelAsync();
                            ChangeEnabledControls(true);
                        }
                        else
                        {
                            StartSearchButton.Text = "Отмена (Enter)";
                            SearchVariableFlow.RunWorkerAsync(SelectedRegistryHive);
                            ChangeEnabledControls(false);
                        }
                        break;
                    }
                case SearchModes.RootsMode:
                    {
                        if (SearchValueFlow.IsBusy)
                        {
                            StartSearchButton.Text = "Поиск (Enter)";
                            SearchValueFlow.CancelAsync();
                            ChangeEnabledControls(true);
                        }
                        else
                        {
                            StartSearchButton.Text = "Отмена (Enter)";
                            SearchValueFlow.RunWorkerAsync(SelectedRegistryHive);
                            ChangeEnabledControls(false);
                        }
                        break;
                    }
                case SearchModes.ValueMode: // Value
                    {
                        if (SearchRootFlow.IsBusy)
                        {
                            StartSearchButton.Text = "Поиск (Enter)";
                            SearchRootFlow.CancelAsync();
                            ChangeEnabledControls(true);
                        }
                        else
                        {
                            StartSearchButton.Text = "Отмена (Enter)";
                            SearchRootFlow.RunWorkerAsync(SelectedRegistryHive);
                            ChangeEnabledControls(false);
                        }
                        break;
                    }
            }
        }
        //////////////////////////////////////////////////
        void SearchVariableFlow_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) => ((IEnumerable<RegistryKey>)e.Argument).AsParallel().ForAll(d => SearchVariables(d, NameTextBox.Text));
        void SearchValueFlow_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) => ((IEnumerable<RegistryKey>)e.Argument).AsParallel().ForAll(d => SearchRoots(d, NameTextBox.Text));
        void SearchRootFlow_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) => ((IEnumerable<RegistryKey>)e.Argument).AsParallel().ForAll(d => SearchValues(d, NameTextBox.Text));
        //////////////////////////////////////////////////
        void SearchFlow_Completed(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            StartSearchButton.Text = "Поиск (Enter)";
            ChangeEnabledControls(true);
            GC.Collect();
            CllShrtMsg("Поиск успешно завершён!", "Поиск завершён", MessageBoxIcon.Information, MessageBoxButtons.OK);
        }
        //
        void SearchOptionsButton_Click(object sender, EventArgs e)
        {
            var searchOptionsForm = new SearchOptionsForm();
            searchOptionsForm.Show(this);
        }
        //
        void RemoveElementButton_Click(object sender, EventArgs e)
        {
            var dialogResult = CllShrtMsg("Вы уверены, что хотите удалить выбранные элементы?", "Удалить");
            if (ListObjectsDataGridView.RowCount > 0 && dialogResult == DialogResult.Yes)
            {
                for (int a = 0; a <= ListObjectsDataGridView.RowCount; a++)
                {
                    if (ListObjectsDataGridView[0, a].Value.Equals(true))
                    {
                        --a;
                        if (ListObjectsDataGridView[1, a].Value.ToString().IndexOf("HKEY_CLASSES_ROOT", StringComparison.OrdinalIgnoreCase) != -1)
                        {
                            DoRemove(ListObjectsDataGridView[1, a].Value, "HKEY_CLASSES_ROOT", Registry.ClassesRoot, a);
                            continue;
                        }
                        else if (ListObjectsDataGridView[1, a].Value.ToString().IndexOf("HKEY_CURRENT_USER", StringComparison.OrdinalIgnoreCase) != -1)
                        {
                            DoRemove(ListObjectsDataGridView[1, a].Value, "HKEY_CURRENT_USER", Registry.CurrentUser, a);
                            continue;
                        }
                        else if (ListObjectsDataGridView[1, a].Value.ToString().IndexOf("HKEY_CURRENT_CONFIG", StringComparison.OrdinalIgnoreCase) != -1)
                        {
                            DoRemove(ListObjectsDataGridView[1, a].Value, "HKEY_CURRENT_CONFIG", Registry.CurrentConfig, a);
                            continue;
                        }
                        else if (ListObjectsDataGridView[1, a].Value.ToString().IndexOf("HKEY_LOCAL_MACHINE", StringComparison.OrdinalIgnoreCase) != -1)
                        {
                            DoRemove(ListObjectsDataGridView[1, a].Value, "HKEY_LOCAL_MACHINE", Registry.LocalMachine, a);
                            continue;
                        }
                        else if (ListObjectsDataGridView[1, a].Value.ToString().IndexOf("HKEY_USERS", StringComparison.OrdinalIgnoreCase) != -1)
                        {
                            DoRemove(ListObjectsDataGridView[1, a].Value, "HKEY_USERS", Registry.Users, a);
                            continue;
                        }
                    }
                }
                //var main = Owner as Main_Form;
                //main.MyUpdate();
            }
        }
        void MarkAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListObjectsDataGridView.RowCount; i++)
            {
                if (ListObjectsDataGridView[0, i].Value.Equals(false))
                    ListObjectsDataGridView[0, i].Value = true;
            }
        }
        void UnMarkAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListObjectsDataGridView.RowCount; i++)
            {
                if (ListObjectsDataGridView[0, i].Value.Equals(true))
                    ListObjectsDataGridView[0, i].Value = false;
            }
        }
        void ChangeEnabledControls(bool b)
        {
            //CloseFormButton.Enabled = b;
            RemoveElementButton.Enabled  = b;
            SearchOptionsButton.Enabled = b;
            MarkAllButton.Enabled = b;
            UnMarkAllButton.Enabled = b;
            NameTextBox.Enabled = b;
            SearchProgressBar.Visible = !b;
        }
        void DoRemove(object item, string Title, RegistryKey Key, int RowIndex)
        {
            // Удаляем название ветки
            string temp = item.ToString().Remove(0, Title.Length + 1);
            string val = temp.Remove(0, temp.LastIndexOf("\\") + 1);
            if (SearchMode == SearchModes.RootsMode)
            {
                try
                {
                    Key.DeleteSubKeyTree(temp);
                }
                catch { }
            }
            else
            {
                RegistryKey kk = null;
                string temp2 = temp.Remove(temp.LastIndexOf("\\"), temp.Length - temp.LastIndexOf("\\"));
                try
                {
                    kk = Key.OpenSubKey(temp2, true);
                }
                finally
                {
                    kk.DeleteValue(val);
                }
            }
            ListObjectsDataGridView.Rows.RemoveAt(RowIndex);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        void AddData(String value) => ListObjectsDataGridView.Invoke(new MethodInvoker(() => ListObjectsDataGridView.Rows.Add(false, value)));
        void SearchVariables(RegistryKey key, string var)
        {
            if (string.IsNullOrEmpty(var) || SearchVariableFlow.CancellationPending) return;
            string[] Variables = key.GetValueNames(), Subkeys = key.GetSubKeyNames();
            var SuitableVariables = (UnitString) ? Variables.Where(d => d == var) : Variables.Where(d => d.IndexOf(var, ComparisonType) != -1);
            SuitableVariables.AsParallel().WithDegreeOfParallelism(1).ForAll(d => AddData(string.Format("{0}\\{1}", key.Name, d)));
            Subkeys.AsParallel().WithDegreeOfParallelism(1).ForAll(d => SearchVariables(key.OpenSubKey(d), var));
        }
        void SearchRoots(RegistryKey key, string root)
        {
            if (string.IsNullOrEmpty(root) || SearchRootFlow.CancellationPending) return;
            string[] Subkeys = key.GetSubKeyNames();
            var SuitableRoots = (UnitString) ? Subkeys.Where(d => d == root) : Subkeys.Where(d => d.IndexOf(root, ComparisonType) != -1);
            SuitableRoots.AsParallel().WithDegreeOfParallelism(1).ForAll(d => AddData(string.Format("{0}\\{1}", key.Name, d)));
            Subkeys.AsParallel().WithDegreeOfParallelism(1).ForAll(d => SearchRoots(key.OpenSubKey(d), root));
        }
        void SearchValues(RegistryKey key, string value)
        {
            if (string.IsNullOrEmpty(value) || SearchRootFlow.CancellationPending) return;
            string[] Variables = key.GetValueNames(), Subkeys = key.GetSubKeyNames();
            var SuitableVariables = (UnitString) ? Variables.Where(d => key.GetValue(d).ToString() == value) : Variables.Where(d => key.GetValue(d).ToString().IndexOf(value, ComparisonType) != -1);
            SuitableVariables.AsParallel().WithDegreeOfParallelism(1).ForAll(d => AddData(key.Name));
            Subkeys.AsParallel().WithDegreeOfParallelism(1).ForAll(d => SearchValues(key.OpenSubKey(d), value));
        }
        DialogResult CllShrtMsg(string Msg, string Title, MessageBoxIcon Icon = MessageBoxIcon.Question, MessageBoxButtons Buttons = MessageBoxButtons.YesNo)
        {
            return MetroFramework.MetroMessageBox.Show(this, Msg, Title, Buttons, Icon);
        }
        void SearchForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        void CloseAppButton_Click(object sender, EventArgs e) => Close();
        void MaximizeAppButton_Click(object sender, EventArgs e)
        {
            if (!WindowMaximized)
            {
                temp_width = Width;
                temp_height = Height;
                temp_location = Location;
                Width = Screen.PrimaryScreen.WorkingArea.Width + 14;
                Height = Screen.PrimaryScreen.WorkingArea.Height + 7;
                Location = new System.Drawing.Point(-7, 0);
                WindowMaximized = true;
            }
            else
            {
                Width = temp_width;
                Height = temp_height;
                Location = temp_location;
                WindowMaximized = false;
            }
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
    }
}