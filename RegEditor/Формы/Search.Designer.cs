namespace RegEditor
{
    partial class SearchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.SearchVariableFlow = new System.ComponentModel.BackgroundWorker();
            this.SearchValueFlow = new System.ComponentModel.BackgroundWorker();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SearchProgressBar = new MetroFramework.Controls.MetroProgressSpinner();
            this.SearchRootFlow = new System.ComponentModel.BackgroundWorker();
            this.StartSearchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UnMarkAllButton = new System.Windows.Forms.Button();
            this.MarkAllButton = new System.Windows.Forms.Button();
            this.RemoveElementButton = new System.Windows.Forms.Button();
            this.ListObjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchOptionsButton = new System.Windows.Forms.Button();
            this.MaximizeAppButton = new System.Windows.Forms.Button();
            this.CloseAppButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListObjectsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchVariableFlow
            // 
            this.SearchVariableFlow.WorkerReportsProgress = true;
            this.SearchVariableFlow.WorkerSupportsCancellation = true;
            this.SearchVariableFlow.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SearchVariableFlow_DoWork);
            this.SearchVariableFlow.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SearchFlow_Completed);
            // 
            // SearchValueFlow
            // 
            this.SearchValueFlow.WorkerReportsProgress = true;
            this.SearchValueFlow.WorkerSupportsCancellation = true;
            this.SearchValueFlow.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SearchValueFlow_DoWork);
            this.SearchValueFlow.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SearchFlow_Completed);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.BackColor = global::RegEditor.Theme.Default.TextBoxBackColor;
            // 
            // 
            // 
            this.NameTextBox.CustomButton.Image = null;
            this.NameTextBox.CustomButton.Location = new System.Drawing.Point(430, 1);
            this.NameTextBox.CustomButton.Name = "";
            this.NameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameTextBox.CustomButton.TabIndex = 1;
            this.NameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameTextBox.CustomButton.UseSelectable = true;
            this.NameTextBox.CustomButton.Visible = false;
            this.NameTextBox.ForeColor = global::RegEditor.Theme.Default.TextBoxForeColor;
            this.NameTextBox.Lines = new string[0];
            this.NameTextBox.Location = new System.Drawing.Point(162, 11);
            this.NameTextBox.MaxLength = 30000;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.PromptText = "Что вы ищите?";
            this.NameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.SelectionLength = 0;
            this.NameTextBox.SelectionStart = 0;
            this.NameTextBox.ShortcutsEnabled = true;
            this.NameTextBox.Size = new System.Drawing.Size(452, 23);
            this.NameTextBox.Style = MetroFramework.MetroColorStyle.Silver;
            this.NameTextBox.TabIndex = 23;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTextBox.UseCustomBackColor = true;
            this.NameTextBox.UseCustomForeColor = true;
            this.NameTextBox.UseSelectable = true;
            this.NameTextBox.UseStyleColors = true;
            this.NameTextBox.WaterMark = "Что вы ищите?";
            this.NameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchForm_KeyDown);
            // 
            // SearchProgressBar
            // 
            this.SearchProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.SearchProgressBar.CustomBackground = true;
            this.SearchProgressBar.Location = new System.Drawing.Point(588, 13);
            this.SearchProgressBar.Maximum = 100;
            this.SearchProgressBar.Name = "SearchProgressBar";
            this.SearchProgressBar.Size = new System.Drawing.Size(20, 20);
            this.SearchProgressBar.Speed = 4F;
            this.SearchProgressBar.Style = MetroFramework.MetroColorStyle.Orange;
            this.SearchProgressBar.TabIndex = 31;
            this.SearchProgressBar.UseCustomBackColor = true;
            this.SearchProgressBar.UseSelectable = true;
            this.SearchProgressBar.Value = 30;
            this.SearchProgressBar.Visible = false;
            // 
            // SearchRootFlow
            // 
            this.SearchRootFlow.WorkerReportsProgress = true;
            this.SearchRootFlow.WorkerSupportsCancellation = true;
            this.SearchRootFlow.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SearchRootFlow_DoWork);
            this.SearchRootFlow.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SearchFlow_Completed);
            // 
            // StartSearchButton
            // 
            this.StartSearchButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.StartSearchButton.FlatAppearance.BorderSize = 0;
            this.StartSearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.StartSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartSearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartSearchButton.ForeColor = System.Drawing.Color.White;
            this.StartSearchButton.Location = new System.Drawing.Point(42, 11);
            this.StartSearchButton.Name = "StartSearchButton";
            this.StartSearchButton.Size = new System.Drawing.Size(113, 23);
            this.StartSearchButton.TabIndex = 60;
            this.StartSearchButton.Text = "Поиск (Enter)";
            this.StartSearchButton.UseVisualStyleBackColor = false;
            this.StartSearchButton.Click += new System.EventHandler(this.StartSearchButton_Click);
            this.StartSearchButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchForm_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UnMarkAllButton);
            this.panel1.Controls.Add(this.MarkAllButton);
            this.panel1.Controls.Add(this.RemoveElementButton);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 31);
            this.panel1.TabIndex = 67;
            // 
            // UnMarkAllButton
            // 
            this.UnMarkAllButton.BackgroundImage = global::RegEditor.Properties.Resources.UnMarkAll;
            this.UnMarkAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UnMarkAllButton.FlatAppearance.BorderSize = 0;
            this.UnMarkAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnMarkAllButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnMarkAllButton.ForeColor = System.Drawing.Color.White;
            this.UnMarkAllButton.Location = new System.Drawing.Point(55, 5);
            this.UnMarkAllButton.Name = "UnMarkAllButton";
            this.UnMarkAllButton.Size = new System.Drawing.Size(19, 19);
            this.UnMarkAllButton.TabIndex = 61;
            this.UnMarkAllButton.UseVisualStyleBackColor = false;
            this.UnMarkAllButton.Click += new System.EventHandler(this.UnMarkAllButton_Click);
            // 
            // MarkAllButton
            // 
            this.MarkAllButton.BackgroundImage = global::RegEditor.Properties.Resources.MarkAll;
            this.MarkAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MarkAllButton.FlatAppearance.BorderSize = 0;
            this.MarkAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkAllButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarkAllButton.ForeColor = System.Drawing.Color.White;
            this.MarkAllButton.Location = new System.Drawing.Point(34, 5);
            this.MarkAllButton.Name = "MarkAllButton";
            this.MarkAllButton.Size = new System.Drawing.Size(19, 19);
            this.MarkAllButton.TabIndex = 60;
            this.MarkAllButton.UseVisualStyleBackColor = false;
            this.MarkAllButton.Click += new System.EventHandler(this.MarkAllButton_Click);
            // 
            // RemoveElementButton
            // 
            this.RemoveElementButton.BackgroundImage = global::RegEditor.Properties.Resources.RemoveMarked;
            this.RemoveElementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveElementButton.FlatAppearance.BorderSize = 0;
            this.RemoveElementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveElementButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveElementButton.ForeColor = System.Drawing.Color.White;
            this.RemoveElementButton.Location = new System.Drawing.Point(8, 2);
            this.RemoveElementButton.Name = "RemoveElementButton";
            this.RemoveElementButton.Size = new System.Drawing.Size(23, 23);
            this.RemoveElementButton.TabIndex = 59;
            this.RemoveElementButton.UseVisualStyleBackColor = false;
            this.RemoveElementButton.Click += new System.EventHandler(this.RemoveElementButton_Click);
            // 
            // ListObjectsDataGridView
            // 
            this.ListObjectsDataGridView.AllowUserToAddRows = false;
            this.ListObjectsDataGridView.AllowUserToDeleteRows = false;
            this.ListObjectsDataGridView.AllowUserToResizeColumns = false;
            this.ListObjectsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ListObjectsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListObjectsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListObjectsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListObjectsDataGridView.BackgroundColor = global::RegEditor.Theme.Default.DataGridViewBackColor;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListObjectsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListObjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListObjectsDataGridView.ColumnHeadersVisible = false;
            this.ListObjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListObjectsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListObjectsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ListObjectsDataGridView.Location = new System.Drawing.Point(12, 71);
            this.ListObjectsDataGridView.Name = "ListObjectsDataGridView";
            this.ListObjectsDataGridView.RowHeadersVisible = false;
            this.ListObjectsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListObjectsDataGridView.ShowCellErrors = false;
            this.ListObjectsDataGridView.ShowCellToolTips = false;
            this.ListObjectsDataGridView.ShowEditingIcon = false;
            this.ListObjectsDataGridView.ShowRowErrors = false;
            this.ListObjectsDataGridView.Size = new System.Drawing.Size(664, 417);
            this.ListObjectsDataGridView.TabIndex = 73;
            this.ListObjectsDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchForm_KeyDown);
            // 
            // Column2
            // 
            this.Column2.FillWeight = 20.30457F;
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 19;
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 179.6955F;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // SearchOptionsButton
            // 
            this.SearchOptionsButton.BackgroundImage = global::RegEditor.Properties.Resources.Settings;
            this.SearchOptionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchOptionsButton.FlatAppearance.BorderSize = 0;
            this.SearchOptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchOptionsButton.Location = new System.Drawing.Point(9, 8);
            this.SearchOptionsButton.Name = "SearchOptionsButton";
            this.SearchOptionsButton.Size = new System.Drawing.Size(28, 29);
            this.SearchOptionsButton.TabIndex = 72;
            this.SearchOptionsButton.UseVisualStyleBackColor = true;
            this.SearchOptionsButton.Click += new System.EventHandler(this.SearchOptionsButton_Click);
            // 
            // MaximizeAppButton
            // 
            this.MaximizeAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeAppButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MaximizeAppButton.BackgroundImage")));
            this.MaximizeAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaximizeAppButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.MaximizeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeAppButton.Location = new System.Drawing.Point(620, 10);
            this.MaximizeAppButton.Name = "MaximizeAppButton";
            this.MaximizeAppButton.Size = new System.Drawing.Size(25, 25);
            this.MaximizeAppButton.TabIndex = 75;
            this.MaximizeAppButton.UseVisualStyleBackColor = true;
            this.MaximizeAppButton.Click += new System.EventHandler(this.MaximizeAppButton_Click);
            // 
            // CloseAppButton
            // 
            this.CloseAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseAppButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseAppButton.BackgroundImage")));
            this.CloseAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseAppButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAppButton.Location = new System.Drawing.Point(651, 10);
            this.CloseAppButton.Name = "CloseAppButton";
            this.CloseAppButton.Size = new System.Drawing.Size(25, 25);
            this.CloseAppButton.TabIndex = 74;
            this.CloseAppButton.UseVisualStyleBackColor = true;
            this.CloseAppButton.Click += new System.EventHandler(this.CloseAppButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::RegEditor.Theme.Default.FormBackColor;
            this.ClientSize = new System.Drawing.Size(687, 500);
            this.ControlBox = false;
            this.Controls.Add(this.MaximizeAppButton);
            this.Controls.Add(this.CloseAppButton);
            this.Controls.Add(this.ListObjectsDataGridView);
            this.Controls.Add(this.SearchOptionsButton);
            this.Controls.Add(this.StartSearchButton);
            this.Controls.Add(this.SearchProgressBar);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchForm_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListObjectsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker SearchVariableFlow;
        private System.ComponentModel.BackgroundWorker SearchValueFlow;
        private MetroFramework.Controls.MetroTextBox NameTextBox;
        private MetroFramework.Controls.MetroProgressSpinner SearchProgressBar;
        private System.ComponentModel.BackgroundWorker SearchRootFlow;
        private System.Windows.Forms.Button RemoveElementButton;
        private System.Windows.Forms.Button StartSearchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchOptionsButton;
        private System.Windows.Forms.DataGridView ListObjectsDataGridView;
        private System.Windows.Forms.Button MarkAllButton;
        private System.Windows.Forms.Button UnMarkAllButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button MaximizeAppButton;
        private System.Windows.Forms.Button CloseAppButton;
    }
}