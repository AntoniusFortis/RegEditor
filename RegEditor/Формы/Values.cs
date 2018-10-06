using Microsoft.Win32;
using System;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace RegEditor
{
    public partial class ValuesForm : Form
    {
        private readonly object _variableName;
        private readonly object _cell2;
        private readonly object _cell3;
        private readonly bool _editMode;

        public ValuesForm(bool editMode = false, object cell1 = null, object cell2 = null, object cell3 = null)
        {
            _variableName = cell1;
            _cell2 = cell2;
            _cell3 = cell3;
            _editMode = editMode;
            InitializeComponent();
        }

        private void AddSection_Load_1(object sender, EventArgs e)
        {
            if (_editMode)
                EditMode_Load();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (_editMode)
                EditSection();
            else
                DoWork();
            Close();
        }

        private void AddSection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AcceptButton.PerformClick();
            if (e.KeyCode == Keys.Escape)
                CloseButton.PerformClick();
        }

        private void EditMode_Load()
        {
            label1.Text = @"Изменить ключ";
            label1.Location = new System.Drawing.Point(label1.Location.X - 6, label1.Location.Y);
            KeyNameTextBox.Text = (string)_variableName ?? "";
            KeyValueTextBox.Text = (string)_cell3 ?? "";
            foreach (object item in TypeKeyComboBox.Items)
            {
                if (item.ToString() == _cell2.ToString())
                {
                    TypeKeyComboBox.Text = item.ToString();
                }
            }
            switch (TypeKeyComboBox.SelectedIndex)
            {
                case 0:
                    {
                        string hexValues = KeyValueTextBox.Text;
                        string[] hexValuesSplit = hexValues.Split(' ');
                        KeyValueTextBox.Text = string.Empty;
                        foreach (string hex in hexValuesSplit)
                        {
                            if (hex == string.Empty)
                                break;
                            int value = Convert.ToInt32(hex, 16);
                            string stringValue = char.ConvertFromUtf32(value);
                            KeyValueTextBox.Text += stringValue;
                        }
                        break;
                    }
                case 5:
                    {
                        if (KeyValueTextBox.Text != string.Empty)
                            KeyValueTextBox.Text = KeyValueTextBox.Text.Replace(" ", "\\");
                        break;
                    }
            }
        }

        private void EditSection()
        {
            var selectedHive = (RegistryKey) CurrentNode.Node.Parent.Tag;
            if (_variableName.ToString() != KeyNameTextBox.Text)
                selectedHive.OpenSubKey(
                    CurrentNode.Node.Text, 
                    RegistryKeyPermissionCheck.ReadWriteSubTree, 
                    RegistryRights.FullControl
                    )?.DeleteValue(_variableName.ToString());
            DoWork();
        }

        private void Values_MouseDown(object sender, MouseEventArgs e)
        {
            Restyler.MouseCapture(Handle);
        }

        private void DoWork()
        {
            if (TypeKeyComboBox.Text == "") return;
            var selectedHive = (RegistryKey)CurrentNode.Node.Parent.Tag;
            try
            {
                switch (TypeKeyComboBox.SelectedIndex)
                {
                    case 0: // Binary
                        {
                            byte[] array = System.Text.Encoding.UTF8.GetBytes(KeyValueTextBox.Text);
                            selectedHive = selectedHive.OpenSubKey(CurrentNode.Node.Text, true);
                            selectedHive?.SetValue(KeyNameTextBox.Text, array, RegistryValueKind.Binary);
                            break;
                        }
                    case 1: // Dword
                        {
                            int value = Convert.ToInt32(KeyValueTextBox.Text, 16);
                            selectedHive = selectedHive.OpenSubKey(CurrentNode.Node.Text, true);
                            selectedHive?.SetValue(KeyNameTextBox.Text, value, RegistryValueKind.DWord);
                            break;
                        }
                    case 2: // Qword
                        {
                            long value = Convert.ToInt64(KeyValueTextBox.Text, 16);
                            selectedHive = selectedHive.OpenSubKey(CurrentNode.Node.Text, true);
                            selectedHive?.SetValue(KeyNameTextBox.Text, value, RegistryValueKind.QWord);
                            break;
                        }
                    case 3: // String
                        {
                            selectedHive = selectedHive.OpenSubKey(CurrentNode.Node.Text, true);
                            selectedHive?.SetValue(KeyNameTextBox.Text, KeyValueTextBox.Text, RegistryValueKind.String);
                            break;
                        }
                    case 4: // Expand string
                        {
                            selectedHive = selectedHive.OpenSubKey(CurrentNode.Node.Text, true);
                            selectedHive?.SetValue(KeyNameTextBox.Text, KeyValueTextBox.Text, RegistryValueKind.ExpandString);
                            break;
                        }
                    case 5:
                        {
                            string[] array = KeyValueTextBox.Text.Split('\\');
                            selectedHive = selectedHive.OpenSubKey(CurrentNode.Node.Text, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl);
                            selectedHive?.SetValue(KeyNameTextBox.Text, array, RegistryValueKind.MultiString);
                        }
                        break;
                }
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Введите новое название для раздела!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
