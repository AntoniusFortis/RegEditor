namespace RegEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("HKEY_CLASSES_ROOT", new System.Windows.Forms.TreeNode[] {
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("HKEY_CURRENT_CONFIG", new System.Windows.Forms.TreeNode[] {
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("HKEY_CURRENT_USER", new System.Windows.Forms.TreeNode[] {
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("HKEY_LOCAL_MACHINE", new System.Windows.Forms.TreeNode[] {
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("HKEY_USERS", new System.Windows.Forms.TreeNode[] {
            treeNode39});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PathRootTbox = new System.Windows.Forms.TextBox();
            this.RootsTreeView = new System.Windows.Forms.TreeView();
            this.KeysView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RootBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.NewRootBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameRootBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveRootBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeAccessBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.NewKeyBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.EditKeyBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveKeyBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйРазделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьРазделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CountsSubkeysLabel = new System.Windows.Forms.Label();
            this.TextCountsSubkeysLabel = new System.Windows.Forms.Label();
            this.CloseAppButton = new System.Windows.Forms.Button();
            this.MaximizeAppButton = new System.Windows.Forms.Button();
            this.MinimizeAppButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KeysView)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathRootTbox
            // 
            this.PathRootTbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathRootTbox.BackColor = global::RegEditor.Theme.Default.TextBoxBackColor;
            this.PathRootTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathRootTbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathRootTbox.ForeColor = System.Drawing.Color.Black;
            this.PathRootTbox.Location = new System.Drawing.Point(10, 387);
            this.PathRootTbox.Name = "PathRootTbox";
            this.PathRootTbox.ReadOnly = true;
            this.PathRootTbox.Size = new System.Drawing.Size(797, 27);
            this.PathRootTbox.TabIndex = 41;
            this.PathRootTbox.TabStop = false;
            this.PathRootTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Form_KeysDown);
            // 
            // RootsTreeView
            // 
            this.RootsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RootsTreeView.BackColor = global::RegEditor.Theme.Default.RootsTreeViewBackColor;
            this.RootsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RootsTreeView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RootsTreeView.ForeColor = global::RegEditor.Theme.Default.RootsTreeViewForeColor;
            this.RootsTreeView.ItemHeight = 24;
            this.RootsTreeView.Location = new System.Drawing.Point(10, 33);
            this.RootsTreeView.Name = "RootsTreeView";
            treeNode31.Name = "";
            treeNode31.Text = "";
            treeNode32.Name = "HKEY_CLASSES_ROOT";
            treeNode32.NodeFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode32.Tag = "";
            treeNode32.Text = "HKEY_CLASSES_ROOT";
            treeNode33.Name = "";
            treeNode33.Text = "";
            treeNode34.Name = "HKEY_CURRENT_CONFIG";
            treeNode34.NodeFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            treeNode34.Text = "HKEY_CURRENT_CONFIG";
            treeNode35.Name = "";
            treeNode35.Text = "";
            treeNode36.Name = "HKEY_CURRENT_USER";
            treeNode36.NodeFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            treeNode36.Text = "HKEY_CURRENT_USER";
            treeNode37.Name = "";
            treeNode37.Text = "";
            treeNode38.Name = "HKEY_LOCAL_MACHINE";
            treeNode38.NodeFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            treeNode38.Text = "HKEY_LOCAL_MACHINE";
            treeNode39.Name = "";
            treeNode39.Text = "";
            treeNode40.Name = "HKEY_USERS";
            treeNode40.NodeFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            treeNode40.Text = "HKEY_USERS";
            this.RootsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode34,
            treeNode36,
            treeNode38,
            treeNode40});
            this.RootsTreeView.Size = new System.Drawing.Size(370, 330);
            this.RootsTreeView.TabIndex = 42;
            this.RootsTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.RootsTreeView_BeforeExpand);
            this.RootsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.RootsTreeView_AfterSelect);
            this.RootsTreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Form_KeysDown);
            // 
            // KeysView
            // 
            this.KeysView.AllowUserToAddRows = false;
            this.KeysView.AllowUserToDeleteRows = false;
            this.KeysView.AllowUserToResizeColumns = false;
            this.KeysView.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            this.KeysView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.KeysView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeysView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KeysView.BackgroundColor = global::RegEditor.Theme.Default.DataGridViewBackColor;
            this.KeysView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KeysView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.KeysView.ColumnHeadersHeight = 30;
            this.KeysView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.KeysView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KeysView.DefaultCellStyle = dataGridViewCellStyle22;
            this.KeysView.EnableHeadersVisualStyles = false;
            this.KeysView.GridColor = global::RegEditor.Theme.Default.datagrview_rgb_grid;
            this.KeysView.Location = new System.Drawing.Point(383, 33);
            this.KeysView.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.KeysView.MultiSelect = false;
            this.KeysView.Name = "KeysView";
            this.KeysView.ReadOnly = true;
            this.KeysView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KeysView.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.KeysView.RowHeadersVisible = false;
            this.KeysView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            this.KeysView.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.KeysView.ShowCellErrors = false;
            this.KeysView.ShowRowErrors = false;
            this.KeysView.Size = new System.Drawing.Size(424, 350);
            this.KeysView.TabIndex = 26;
            this.KeysView.TabStop = false;
            this.KeysView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KeysView_CellDoubleClick);
            this.KeysView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Form_KeysDown);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 15F;
            this.Column2.HeaderText = "";
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column2.MinimumWidth = 3;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 25;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.FillWeight = 118.0203F;
            this.dataGridViewTextBoxColumn17.HeaderText = "Название";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn18.FillWeight = 63.95939F;
            this.dataGridViewTextBoxColumn18.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.FillWeight = 118.0203F;
            this.dataGridViewTextBoxColumn19.HeaderText = "Значение";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // RootBtn
            // 
            this.RootBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewRootBtn,
            this.RenameRootBtn,
            this.RemoveRootBtn,
            this.ChangeAccessBtn});
            this.RootBtn.ForeColor = System.Drawing.Color.Black;
            this.RootBtn.Name = "RootBtn";
            this.RootBtn.Size = new System.Drawing.Size(63, 21);
            this.RootBtn.Text = "Раздел";
            // 
            // NewRootBtn
            // 
            this.NewRootBtn.Image = global::RegEditor.Properties.Resources.AddRoot;
            this.NewRootBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewRootBtn.Name = "NewRootBtn";
            this.NewRootBtn.Size = new System.Drawing.Size(338, 34);
            this.NewRootBtn.Text = "Новый раздел (A)";
            this.NewRootBtn.Click += new System.EventHandler(this.NewRootBtn_Click);
            // 
            // RenameRootBtn
            // 
            this.RenameRootBtn.ForeColor = System.Drawing.Color.Black;
            this.RenameRootBtn.Image = global::RegEditor.Properties.Resources.Edit;
            this.RenameRootBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RenameRootBtn.Name = "RenameRootBtn";
            this.RenameRootBtn.Size = new System.Drawing.Size(338, 34);
            this.RenameRootBtn.Text = "Переименовать выделенный раздел (R)";
            this.RenameRootBtn.Click += new System.EventHandler(this.RenameRootBtn_Click);
            // 
            // RemoveRootBtn
            // 
            this.RemoveRootBtn.ForeColor = System.Drawing.Color.Black;
            this.RemoveRootBtn.Image = global::RegEditor.Properties.Resources.Delete;
            this.RemoveRootBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RemoveRootBtn.Name = "RemoveRootBtn";
            this.RemoveRootBtn.Size = new System.Drawing.Size(338, 34);
            this.RemoveRootBtn.Text = "Удалить выделенный раздел (Delete)";
            this.RemoveRootBtn.Click += new System.EventHandler(this.RemoveRootBtn_Click);
            // 
            // ChangeAccessBtn
            // 
            this.ChangeAccessBtn.ForeColor = System.Drawing.Color.Black;
            this.ChangeAccessBtn.Image = global::RegEditor.Properties.Resources.GetPermissions;
            this.ChangeAccessBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ChangeAccessBtn.Name = "ChangeAccessBtn";
            this.ChangeAccessBtn.Size = new System.Drawing.Size(338, 34);
            this.ChangeAccessBtn.Text = "Разрешения";
            this.ChangeAccessBtn.Click += new System.EventHandler(this.ChangeAccessBtn_Click);
            // 
            // KeyButton
            // 
            this.KeyButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewKeyBtn,
            this.EditKeyBtn,
            this.RemoveKeyBtn});
            this.KeyButton.ForeColor = System.Drawing.Color.Black;
            this.KeyButton.Name = "KeyButton";
            this.KeyButton.Size = new System.Drawing.Size(55, 21);
            this.KeyButton.Text = "Ключ";
            // 
            // NewKeyBtn
            // 
            this.NewKeyBtn.ForeColor = System.Drawing.Color.Black;
            this.NewKeyBtn.Image = global::RegEditor.Properties.Resources.AddKey;
            this.NewKeyBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewKeyBtn.Name = "NewKeyBtn";
            this.NewKeyBtn.Size = new System.Drawing.Size(321, 34);
            this.NewKeyBtn.Text = "Новый ключ (W)";
            this.NewKeyBtn.Click += new System.EventHandler(this.NewKeyBtn_Click);
            // 
            // EditKeyBtn
            // 
            this.EditKeyBtn.ForeColor = System.Drawing.Color.Black;
            this.EditKeyBtn.Image = global::RegEditor.Properties.Resources.Edit;
            this.EditKeyBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditKeyBtn.Name = "EditKeyBtn";
            this.EditKeyBtn.Size = new System.Drawing.Size(321, 34);
            this.EditKeyBtn.Text = "Редактировать выделенный ключ (E)";
            this.EditKeyBtn.Click += new System.EventHandler(this.EditKeyBtn_Click);
            // 
            // RemoveKeyBtn
            // 
            this.RemoveKeyBtn.ForeColor = System.Drawing.Color.Black;
            this.RemoveKeyBtn.Image = global::RegEditor.Properties.Resources.Delete;
            this.RemoveKeyBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RemoveKeyBtn.Name = "RemoveKeyBtn";
            this.RemoveKeyBtn.Size = new System.Drawing.Size(321, 34);
            this.RemoveKeyBtn.Text = "Удалить выделенный ключ (G)";
            this.RemoveKeyBtn.Click += new System.EventHandler(this.RemoveKeyBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.ForeColor = System.Drawing.Color.Black;
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(108, 21);
            this.SearchBtn.Text = "Поиск (Ctrl+F)";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.ForeColor = System.Drawing.Color.Black;
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(127, 21);
            this.AboutBtn.Text = "О программе (H)";
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = global::RegEditor.Theme.Default.MenuStripBackColor;
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuStrip.ForeColor = System.Drawing.Color.Black;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RootBtn,
            this.KeyButton,
            this.SearchBtn,
            this.AboutBtn});
            this.MenuStrip.Location = new System.Drawing.Point(2, 4);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(481, 25);
            this.MenuStrip.TabIndex = 40;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 21);
            this.toolStripMenuItem1.Text = "Раздел";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(55, 21);
            this.toolStripMenuItem2.Text = "Ключ";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(108, 21);
            this.toolStripMenuItem3.Text = "Поиск (Ctrl+F)";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(105, 21);
            this.toolStripMenuItem4.Text = "О программе";
            // 
            // новыйРазделToolStripMenuItem
            // 
            this.новыйРазделToolStripMenuItem.Name = "новыйРазделToolStripMenuItem";
            this.новыйРазделToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.новыйРазделToolStripMenuItem.Text = "Новый раздел";
            // 
            // изменитьРазделToolStripMenuItem
            // 
            this.изменитьРазделToolStripMenuItem.Name = "изменитьРазделToolStripMenuItem";
            this.изменитьРазделToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.изменитьРазделToolStripMenuItem.Text = "Переименовать раздел";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(142, 21);
            this.toolStripMenuItem5.Text = "toolStripMenuItem5";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CountsSubkeysLabel);
            this.panel1.Controls.Add(this.TextCountsSubkeysLabel);
            this.panel1.Location = new System.Drawing.Point(10, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 22);
            this.panel1.TabIndex = 43;
            // 
            // CountsSubkeysLabel
            // 
            this.CountsSubkeysLabel.AutoSize = true;
            this.CountsSubkeysLabel.Location = new System.Drawing.Point(147, 4);
            this.CountsSubkeysLabel.Name = "CountsSubkeysLabel";
            this.CountsSubkeysLabel.Size = new System.Drawing.Size(32, 13);
            this.CountsSubkeysLabel.TabIndex = 1;
            this.CountsSubkeysLabel.Text = "nums";
            // 
            // TextCountsSubkeysLabel
            // 
            this.TextCountsSubkeysLabel.AutoSize = true;
            this.TextCountsSubkeysLabel.Location = new System.Drawing.Point(10, 3);
            this.TextCountsSubkeysLabel.Name = "TextCountsSubkeysLabel";
            this.TextCountsSubkeysLabel.Size = new System.Drawing.Size(138, 13);
            this.TextCountsSubkeysLabel.TabIndex = 0;
            this.TextCountsSubkeysLabel.Text = "Количество подразделов:";
            // 
            // CloseAppButton
            // 
            this.CloseAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseAppButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseAppButton.BackgroundImage")));
            this.CloseAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseAppButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAppButton.Location = new System.Drawing.Point(782, 4);
            this.CloseAppButton.Name = "CloseAppButton";
            this.CloseAppButton.Size = new System.Drawing.Size(25, 25);
            this.CloseAppButton.TabIndex = 51;
            this.CloseAppButton.UseVisualStyleBackColor = true;
            this.CloseAppButton.Click += new System.EventHandler(this.CloseAppButton_Click);
            // 
            // MaximizeAppButton
            // 
            this.MaximizeAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeAppButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MaximizeAppButton.BackgroundImage")));
            this.MaximizeAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaximizeAppButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.MaximizeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeAppButton.Location = new System.Drawing.Point(751, 4);
            this.MaximizeAppButton.Name = "MaximizeAppButton";
            this.MaximizeAppButton.Size = new System.Drawing.Size(25, 25);
            this.MaximizeAppButton.TabIndex = 52;
            this.MaximizeAppButton.UseVisualStyleBackColor = true;
            this.MaximizeAppButton.Click += new System.EventHandler(this.MaximizeAppButton_Click);
            // 
            // MinimizeAppButton
            // 
            this.MinimizeAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeAppButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeAppButton.BackgroundImage")));
            this.MinimizeAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeAppButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.MinimizeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeAppButton.Location = new System.Drawing.Point(720, 4);
            this.MinimizeAppButton.Name = "MinimizeAppButton";
            this.MinimizeAppButton.Size = new System.Drawing.Size(25, 25);
            this.MinimizeAppButton.TabIndex = 53;
            this.MinimizeAppButton.UseVisualStyleBackColor = true;
            this.MinimizeAppButton.Click += new System.EventHandler(this.MinimizeAppButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::RegEditor.Theme.Default.FormBackColor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 419);
            this.Controls.Add(this.MinimizeAppButton);
            this.Controls.Add(this.MaximizeAppButton);
            this.Controls.Add(this.CloseAppButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RootsTreeView);
            this.Controls.Add(this.KeysView);
            this.Controls.Add(this.PathRootTbox);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_Form_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.KeysView)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView RootsTreeView;
        private System.Windows.Forms.DataGridView KeysView;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.TextBox PathRootTbox;
        private System.Windows.Forms.ToolStripMenuItem RootBtn;
        private System.Windows.Forms.ToolStripMenuItem NewRootBtn;
        private System.Windows.Forms.ToolStripMenuItem RenameRootBtn;
        private System.Windows.Forms.ToolStripMenuItem RemoveRootBtn;
        private System.Windows.Forms.ToolStripMenuItem ChangeAccessBtn;
        private System.Windows.Forms.ToolStripMenuItem KeyButton;
        private System.Windows.Forms.ToolStripMenuItem NewKeyBtn;
        private System.Windows.Forms.ToolStripMenuItem EditKeyBtn;
        private System.Windows.Forms.ToolStripMenuItem RemoveKeyBtn;
        private System.Windows.Forms.ToolStripMenuItem SearchBtn;
        private System.Windows.Forms.ToolStripMenuItem AboutBtn;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem новыйРазделToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьРазделToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CountsSubkeysLabel;
        private System.Windows.Forms.Label TextCountsSubkeysLabel;
        private System.Windows.Forms.Button CloseAppButton;
        private System.Windows.Forms.Button MaximizeAppButton;
        private System.Windows.Forms.Button MinimizeAppButton;
    }
}

