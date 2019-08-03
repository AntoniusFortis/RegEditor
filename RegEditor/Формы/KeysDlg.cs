using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RegEditor
{
    public partial class KeysDlg : Form
    {
        private readonly bool _editMode;

        public KeysDlg(bool editmode)
        {
            _editMode = editmode;
            InitializeComponent();
        }

        private void EditMode_Load()
        {
            TitleLable.Text = @"Изменить ключ";
            TitleLable.Location = new Point(TitleLable.Location.X - 6, TitleLable.Location.Y);

            NameTbox.Text = KeysBus.Name;
            ValueTBox.Text = KeysBus.Value;

            foreach (string item in TypeComboBox.Items)
            {
                if (item != KeysBus.Type) continue;
                TypeComboBox.Text = item;
                break;
            }

            switch (TypeComboBox.SelectedIndex)
            {
                case 0:
                    {
                        ValueTBox.Text = KeysBus.Value;
                        break;
                    }
                case 5:
                    {
                        if (ValueTBox.Text != string.Empty)
                            ValueTBox.Text = ValueTBox.Text.Replace(" ", "\\");
                        break;
                    }
            }
        }

        private void EditSection()
        {
            var selectedHive = (RegistryKey) CurrentNode.Node.Parent.Tag;
            if (KeysBus.Name != NameTbox.Text)
                selectedHive.OpenSubKey(CurrentNode.Node.Text, true)?.DeleteValue(KeysBus.Name);
            ProcessAction();
        }

        private void ProcessAction()
        {
            if (TypeComboBox.Text == "") return;
            var selectedHive = (RegistryKey) CurrentNode.Node.Parent.Tag;
            if (selectedHive == null)
                return;

            RegistryValueKind kind;
            object value;

            switch (TypeComboBox.SelectedIndex)
            {
                case 0: // Binary
                {
                    string[] hexValuesSplit = ValueTBox.Text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    byte[] array = new byte[hexValuesSplit.Length];
                    for (var index = 0; index < hexValuesSplit.Length; ++index)
                    {
                        var val = hexValuesSplit[index];
                        array[index] = byte.Parse(val, NumberStyles.AllowHexSpecifier);
                    }

                    kind = RegistryValueKind.Binary;
                    value = array;
                    break;
                }
                case 1: // Dword
                {
                    kind = RegistryValueKind.DWord;
                    value = Convert.ToInt32(ValueTBox.Text, 16);
                    break;
                }
                case 2: // Qword
                {
                    kind = RegistryValueKind.QWord;
                    value = Convert.ToInt64(ValueTBox.Text, 16);
                    break;
                }
                case 3: // String
                {
                    kind = RegistryValueKind.String;
                    value = ValueTBox.Text;
                    break;
                }
                case 4: // Expand string
                {
                    kind = RegistryValueKind.ExpandString;
                    value = ValueTBox.Text;
                    break;
                }
                case 5: // Multi string
                {
                    kind = RegistryValueKind.MultiString;
                    value = ValueTBox.Text.Split('\\');
                    break;
                }
                default:
                {
                    return;
                }
            }

            try
            {
                selectedHive = selectedHive.OpenSubKey(CurrentNode.Node.Text, true);
                selectedHive?.SetValue(NameTbox.Text, value, kind);
            }
            catch
            {
                this.Msg("Недопустимый ключ!", "Ошибка", icon: MessageBoxIcon.Error);
            }
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (_editMode)
                EditSection();
            else
                ProcessAction();
            Close();
        }

        private void Keys_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AcceptBtn.PerformClick();
            if (e.KeyCode == Keys.Escape)
                CloseBtn.PerformClick();
        }

        private void Keys_MouseDown(object sender, MouseEventArgs e) => this.MouseCapture();

        private void Keys_Load(object sender, EventArgs e)
        {
            Restyler.WindowsReStyle(Handle);

            if (_editMode)
                EditMode_Load();
        }

        private void CloseBtn_Click(object sender, EventArgs e) => Close();
    }
}
