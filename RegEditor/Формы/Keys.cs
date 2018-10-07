using Microsoft.Win32;
using System;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace RegEditor
{
    public partial class Keys : Form
    {
        private readonly object _variableName;
        private readonly object _cell2;
        private readonly object _cell3;
        private readonly bool _editMode;

        public Keys(bool editMode = false, object cell1 = null, object cell2 = null, object cell3 = null)
        {
            _variableName = cell1;
            _cell2 = cell2;
            _cell3 = cell3;
            _editMode = editMode;
            InitializeComponent();
        }

        private void EditMode_Load()
        {
            Restyler.WindowsReStyle(Handle);

            label1.Text = @"Изменить ключ";
            label1.Location = new System.Drawing.Point(label1.Location.X - 6, label1.Location.Y);
            NameTbox.Text = (string)_variableName ?? "";
            s.Text = (string)_cell3 ?? "";
            foreach (object item in TypeComboBox.Items)
            {
                if (item.ToString() == _cell2.ToString())
                {
                    TypeComboBox.Text = item.ToString();
                }
            }
            switch (TypeComboBox.SelectedIndex)
            {
                case 0:
                    {
                        string hexValues = s.Text;
                        string[] hexValuesSplit = hexValues.Split(' ');
                        s.Text = string.Empty;
                        foreach (string hex in hexValuesSplit)
                        {
                            if (hex == string.Empty)
                                break;
                            int value = Convert.ToInt32(hex, 16);
                            string stringValue = char.ConvertFromUtf32(value);
                            s.Text += stringValue;
                        }
                        break;
                    }
                case 5:
                    {
                        if (s.Text != string.Empty)
                            s.Text = s.Text.Replace(" ", "\\");
                        break;
                    }
            }
        }

        private void EditSection()
        {
            var selectedHive = (RegistryKey) CurrentNode.Node.Parent.Tag;
            if (_variableName.ToString() != NameTbox.Text)
                selectedHive.OpenSubKey(
                    CurrentNode.Node.Text, 
                    RegistryKeyPermissionCheck.ReadWriteSubTree, 
                    RegistryRights.FullControl
                    )?.DeleteValue(_variableName.ToString());
            DoWork();
        }

        private void DoWork()
        {
            if (TypeComboBox.Text == "") return;
            var selectedHive = (RegistryKey)CurrentNode.Node.Parent.Tag;
            try
            {
                switch (TypeComboBox.SelectedIndex)
                {
                    case 0: // Binary
                        {
                            byte[] array = System.Text.Encoding.UTF8.GetBytes(s.Text);
                            selectedHive = selectedHive.OpenSubKey(CurrentNode.Node.Text, true);
                            selectedHive?.SetValue(NameTbox.Text, array, RegistryValueKind.Binary);
                            break;
                        }
                    case 1: // Dword
                        {
                            int value = Convert.ToInt32(s.Text, 16);
                            selectedHive = selectedHive.OpenSubKey(CurrentNode.Node.Text, true);
                            selectedHive?.SetValue(NameTbox.Text, value, RegistryValueKind.DWord);
                            break;
                        }
                    case 2: // Qword
                        {
                            long value = Convert.ToInt64(s.Text, 16);
                            selectedHive = selectedHive.OpenSubKey(CurrentNode.Node.Text, true);
                            selectedHive?.SetValue(NameTbox.Text, value, RegistryValueKind.QWord);
                            break;
                        }
                    case 3: // String
                        {
                            selectedHive = selectedHive.OpenSubKey(CurrentNode.Node.Text, true);
                            selectedHive?.SetValue(NameTbox.Text, s.Text, RegistryValueKind.String);
                            break;
                        }
                    case 4: // Expand string
                        {
                            selectedHive = selectedHive.OpenSubKey(CurrentNode.Node.Text, true);
                            selectedHive?.SetValue(NameTbox.Text, s.Text, RegistryValueKind.ExpandString);
                            break;
                        }
                    case 5:
                        {
                            string[] array = s.Text.Split('\\');
                            selectedHive = selectedHive.OpenSubKey(CurrentNode.Node.Text, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl);
                            selectedHive?.SetValue(NameTbox.Text, array, RegistryValueKind.MultiString);
                        }
                        break;
                }
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Введите новое название для раздела!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (_editMode)
                EditSection();
            else
                DoWork();
            Close();
        }

        private void Keys_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                AcceptBtn.PerformClick();
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
                CloseBtn.PerformClick();
        }

        private void Keys_MouseDown(object sender, MouseEventArgs e) => Restyler.MouseCapture(Handle);

        private void Keys_Load(object sender, EventArgs e)
        {
            if (_editMode)
                EditMode_Load();
        }

        private void CloseBtn_Click(object sender, EventArgs e) => Close();
    }
}
