using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;
#pragma warning disable RCS1018 // Add default access modifier.
#pragma warning disable RCS1057 // Add empty line between declarations.
namespace RegEditor
{
    public partial class SearchOptionsForm : Form
    {
        public SearchOptionsForm()
        {
            InitializeComponent();
        }
        Color Off_ColorBackground = Color.FromArgb(225, 225, 225);
        Color On_ColorBackground = Color.GreenYellow;
        void SearchOptions_Load(object sender, EventArgs e)
        {
            ListRootsDataGridView.Rows.Add(false, "HKEY_CLASSES_ROOT");
            ListRootsDataGridView.Rows.Add(false, "HKEY_CURRENT_CONFIG");
            ListRootsDataGridView.Rows.Add(false, "HKEY_CURRENT_USER");
            ListRootsDataGridView.Rows.Add(false, "HKEY_LOCAL_MACHINE");
            ListRootsDataGridView.Rows.Add(false, "HKEY_USERS");

            var SearchForm = Owner as SearchForm;
            if (SearchForm.RegistryKeys[0] != null)
                ListRootsDataGridView[0, 0].Value = true;
            if (SearchForm.RegistryKeys[1] != null)
                ListRootsDataGridView[0, 1].Value = true;
            if (SearchForm.RegistryKeys[2] != null)
                ListRootsDataGridView[0, 2].Value = true;
            if (SearchForm.RegistryKeys[3] != null)
                ListRootsDataGridView[0, 3].Value = true;
            if (SearchForm.RegistryKeys[4] != null)
                ListRootsDataGridView[0, 4].Value = true;

            UnitWordTile.BackColor = (SearchForm.UnitString) ? On_ColorBackground : Off_ColorBackground;

            CompTile.BackColor = (SearchForm.ComparisonType == StringComparison.Ordinal)
                ? On_ColorBackground
                : Off_ColorBackground;

            switch (SearchForm.SearchMode)
            {
                case SearchForm.SearchModes.VariablesMode:
                    {
                        NameKeyTile.BackColor = On_ColorBackground;
                        ValueKeyTile.Enabled = false;
                        break;
                    }
                case SearchForm.SearchModes.RootsMode:
                    {
                        break;
                    }
                case SearchForm.SearchModes.ValueMode:
                    {
                        ValueKeyTile.BackColor = On_ColorBackground;
                        NameKeyTile.Enabled = false;
                        break;
                    }
            }
        }
        void ListRootsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var SearchForm = Owner as SearchForm;
            switch (e.RowIndex)
            {
                case 0:
                    {
                        if (ListRootsDataGridView[0, 0].Value.Equals(true))
                            SearchForm.RegistryKeys[0] = Registry.ClassesRoot;
                        else
                            SearchForm.RegistryKeys[0] = null;
                        break;
                    }
                case 1:
                    {
                        if (ListRootsDataGridView[0, 1].Value.Equals(true))
                            SearchForm.RegistryKeys[1] = Registry.CurrentConfig;
                        else
                            SearchForm.RegistryKeys[1] = null;
                        break;
                    }
                case 2:
                    {
                        if (ListRootsDataGridView[0, 2].Value.Equals(true))
                            SearchForm.RegistryKeys[2] = Registry.CurrentUser;
                        else
                            SearchForm.RegistryKeys[2] = null;
                        break;
                    }
                case 3:
                    {
                        if (ListRootsDataGridView[0, 3].Value.Equals(true))
                            SearchForm.RegistryKeys[3] = Registry.LocalMachine;
                        else
                            SearchForm.RegistryKeys[3] = null;
                        break;
                    }
                case 4:
                    {
                        if (ListRootsDataGridView[0, 4].Value.Equals(true))
                            SearchForm.RegistryKeys[4] = Registry.Users;
                        else
                            SearchForm.RegistryKeys[4] = null;
                        break;
                    }
            }
        }
        void MetroTile1_Click(object sender, EventArgs e)
        {
            var SearchForm = Owner as SearchForm;
            CompTile.BackColor =
                (CompTile.BackColor == On_ColorBackground)
                ? Off_ColorBackground
                : On_ColorBackground;
            SearchForm.ComparisonType =
                (CompTile.BackColor == On_ColorBackground)
                ? StringComparison.Ordinal
                : StringComparison.OrdinalIgnoreCase;
        }
        void MetroTile8_Click(object sender, EventArgs e)
        {
            SearchForm SearchForm = Owner as SearchForm;
            UnitWordTile.BackColor = (UnitWordTile.BackColor == On_ColorBackground)
                ? Off_ColorBackground
                : On_ColorBackground;
            SearchForm.UnitString = UnitWordTile.BackColor == On_ColorBackground;
        }
        void NameKeyTile_Click(object sender, EventArgs e)
        {
            SearchForm SearchForm = Owner as SearchForm;
            NameKeyTile.BackColor =
                (NameKeyTile.BackColor == On_ColorBackground)
                ? Off_ColorBackground
                : On_ColorBackground;
            if (NameKeyTile.BackColor == On_ColorBackground)
            {
                SearchForm.SearchMode = 0; // Var
                ValueKeyTile.Enabled = false;
            }
            else
            {
                if (SearchForm.SearchMode != SearchForm.SearchModes.ValueMode)
                {
                    SearchForm.SearchMode = SearchForm.SearchModes.RootsMode;
                    ValueKeyTile.Enabled = true;
                }
            }
        }
        void Tile_ValKey_Flag_Click(object sender, EventArgs e)
        {
            var SearchForm = Owner as SearchForm;
            ValueKeyTile.BackColor =
                (ValueKeyTile.BackColor == On_ColorBackground)
                ? Off_ColorBackground
                : On_ColorBackground;
            if (ValueKeyTile.BackColor == On_ColorBackground)
            {
                SearchForm.SearchMode = SearchForm.SearchModes.ValueMode;
                NameKeyTile.Enabled = false;
            }
            else if (SearchForm.SearchMode != SearchForm.SearchModes.VariablesMode)
            {
                SearchForm.SearchMode = SearchForm.SearchModes.RootsMode;
                NameKeyTile.Enabled = true;
            }
        }
        void CloseFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        void SearchOptionsForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
