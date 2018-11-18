namespace RegEditor
{
    partial class Permissions
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
            this.components = new System.ComponentModel.Container();
            this.SelectUserComboBox = new MetroFramework.Controls.MetroComboBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.IsInheritedComboBox = new MetroFramework.Controls.MetroComboBox();
            this.InHeritanceFlagsComboBox = new MetroFramework.Controls.MetroComboBox();
            this.AccessControlTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.RegistryRightComboBox = new MetroFramework.Controls.MetroComboBox();
            this.PathRootTbox = new System.Windows.Forms.TextBox();
            this.DescrTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // SelectUserComboBox
            // 
            this.SelectUserComboBox.BackColor = global::RegEditor.Theme.Default.combox_rgb_bg;
            this.SelectUserComboBox.ForeColor = global::RegEditor.Theme.Default.ComboboxForeColor;
            this.SelectUserComboBox.FormattingEnabled = true;
            this.SelectUserComboBox.ItemHeight = 23;
            this.SelectUserComboBox.Location = new System.Drawing.Point(22, 55);
            this.SelectUserComboBox.Name = "SelectUserComboBox";
            this.SelectUserComboBox.Size = new System.Drawing.Size(353, 29);
            this.SelectUserComboBox.Style = global::RegEditor.Theme.Default.combox_style;
            this.SelectUserComboBox.TabIndex = 36;
            this.DescrTip.SetToolTip(this.SelectUserComboBox, "Пользователь");
            this.SelectUserComboBox.UseCustomBackColor = true;
            this.SelectUserComboBox.UseCustomForeColor = true;
            this.SelectUserComboBox.UseSelectable = true;
            this.SelectUserComboBox.UseStyleColors = true;
            this.SelectUserComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectUserComboBox_SelectedIndexChanged);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackgroundImage = global::RegEditor.Properties.Resources.Cancel;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(196, 248);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(60, 58);
            this.CloseBtn.TabIndex = 57;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.BackgroundImage = global::RegEditor.Properties.Resources.Accept;
            this.AcceptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AcceptBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.AcceptBtn.FlatAppearance.BorderSize = 0;
            this.AcceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptBtn.ForeColor = global::RegEditor.Theme.Default.DefaultButtonForeColor;
            this.AcceptBtn.Location = new System.Drawing.Point(137, 248);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(60, 58);
            this.AcceptBtn.TabIndex = 58;
            this.AcceptBtn.UseVisualStyleBackColor = false;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // IsInheritedComboBox
            // 
            this.IsInheritedComboBox.BackColor = global::RegEditor.Theme.Default.combox_rgb_bg;
            this.IsInheritedComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsInheritedComboBox.ForeColor = global::RegEditor.Theme.Default.ComboboxForeColor;
            this.IsInheritedComboBox.FormattingEnabled = true;
            this.IsInheritedComboBox.ItemHeight = 23;
            this.IsInheritedComboBox.Items.AddRange(new object[] {
            "Присутствует",
            "Отсутствует"});
            this.IsInheritedComboBox.Location = new System.Drawing.Point(22, 209);
            this.IsInheritedComboBox.Name = "IsInheritedComboBox";
            this.IsInheritedComboBox.PromptText = "Наследовательность";
            this.IsInheritedComboBox.Size = new System.Drawing.Size(353, 29);
            this.IsInheritedComboBox.Style = global::RegEditor.Theme.Default.combox_style;
            this.IsInheritedComboBox.TabIndex = 68;
            this.DescrTip.SetToolTip(this.IsInheritedComboBox, "Наследовательность");
            this.IsInheritedComboBox.UseCustomBackColor = true;
            this.IsInheritedComboBox.UseCustomForeColor = true;
            this.IsInheritedComboBox.UseSelectable = true;
            this.IsInheritedComboBox.UseStyleColors = true;
            // 
            // InHeritanceFlagsComboBox
            // 
            this.InHeritanceFlagsComboBox.BackColor = global::RegEditor.Theme.Default.combox_rgb_bg;
            this.InHeritanceFlagsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InHeritanceFlagsComboBox.ForeColor = global::RegEditor.Theme.Default.ComboboxForeColor;
            this.InHeritanceFlagsComboBox.FormattingEnabled = true;
            this.InHeritanceFlagsComboBox.ItemHeight = 23;
            this.InHeritanceFlagsComboBox.Items.AddRange(new object[] {
            "Не наследуется дочерними объектами",
            "Наследуется дочерними объектами-контейнерами",
            "Наследуется дочерними объектами"});
            this.InHeritanceFlagsComboBox.Location = new System.Drawing.Point(22, 174);
            this.InHeritanceFlagsComboBox.Name = "InHeritanceFlagsComboBox";
            this.InHeritanceFlagsComboBox.PromptText = "Управление доступом";
            this.InHeritanceFlagsComboBox.Size = new System.Drawing.Size(353, 29);
            this.InHeritanceFlagsComboBox.Style = global::RegEditor.Theme.Default.combox_style;
            this.InHeritanceFlagsComboBox.TabIndex = 67;
            this.DescrTip.SetToolTip(this.InHeritanceFlagsComboBox, "Управление доступом");
            this.InHeritanceFlagsComboBox.UseCustomBackColor = true;
            this.InHeritanceFlagsComboBox.UseCustomForeColor = true;
            this.InHeritanceFlagsComboBox.UseSelectable = true;
            this.InHeritanceFlagsComboBox.UseStyleColors = true;
            // 
            // AccessControlTypeComboBox
            // 
            this.AccessControlTypeComboBox.BackColor = global::RegEditor.Theme.Default.combox_rgb_bg;
            this.AccessControlTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccessControlTypeComboBox.ForeColor = global::RegEditor.Theme.Default.ComboboxForeColor;
            this.AccessControlTypeComboBox.FormattingEnabled = true;
            this.AccessControlTypeComboBox.ItemHeight = 23;
            this.AccessControlTypeComboBox.Items.AddRange(new object[] {
            "Разрешён",
            "Запрещён"});
            this.AccessControlTypeComboBox.Location = new System.Drawing.Point(22, 104);
            this.AccessControlTypeComboBox.Name = "AccessControlTypeComboBox";
            this.AccessControlTypeComboBox.PromptText = "Доступ";
            this.AccessControlTypeComboBox.Size = new System.Drawing.Size(353, 29);
            this.AccessControlTypeComboBox.Style = global::RegEditor.Theme.Default.combox_style;
            this.AccessControlTypeComboBox.TabIndex = 66;
            this.DescrTip.SetToolTip(this.AccessControlTypeComboBox, "Доступ к разделу");
            this.AccessControlTypeComboBox.UseCustomBackColor = true;
            this.AccessControlTypeComboBox.UseCustomForeColor = true;
            this.AccessControlTypeComboBox.UseSelectable = true;
            this.AccessControlTypeComboBox.UseStyleColors = true;
            // 
            // RegistryRightComboBox
            // 
            this.RegistryRightComboBox.BackColor = global::RegEditor.Theme.Default.combox_rgb_bg;
            this.RegistryRightComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistryRightComboBox.ForeColor = global::RegEditor.Theme.Default.ComboboxForeColor;
            this.RegistryRightComboBox.FormattingEnabled = true;
            this.RegistryRightComboBox.ItemHeight = 23;
            this.RegistryRightComboBox.Items.AddRange(new object[] {
            "Изменение доступа и аудита",
            "Создание подразделов",
            "Удаление раздела",
            "Создание списка подразделов",
            "Полный доступ",
            "Запрос уведовмления об изменении раздела",
            "Запрос пар \'имя-значение\' в разделе",
            "Только чтение",
            "Открытие и копирования правил доступа и аудита",
            "Доступ к паре \'имя-значение\' раздела",
            "Изменение владельца раздела",
            "Чтение и запись подразделов и пар \'имя-значение\'"});
            this.RegistryRightComboBox.Location = new System.Drawing.Point(22, 139);
            this.RegistryRightComboBox.Name = "RegistryRightComboBox";
            this.RegistryRightComboBox.PromptText = "Права";
            this.RegistryRightComboBox.Size = new System.Drawing.Size(353, 29);
            this.RegistryRightComboBox.Style = global::RegEditor.Theme.Default.combox_style;
            this.RegistryRightComboBox.TabIndex = 65;
            this.DescrTip.SetToolTip(this.RegistryRightComboBox, "Права доступа");
            this.RegistryRightComboBox.UseCustomBackColor = true;
            this.RegistryRightComboBox.UseCustomForeColor = true;
            this.RegistryRightComboBox.UseSelectable = true;
            this.RegistryRightComboBox.UseStyleColors = true;
            // 
            // PathRootTbox
            // 
            this.PathRootTbox.BackColor = global::RegEditor.Theme.Default.TextBoxBackColor;
            this.PathRootTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathRootTbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathRootTbox.ForeColor = System.Drawing.Color.Black;
            this.PathRootTbox.Location = new System.Drawing.Point(22, 19);
            this.PathRootTbox.Name = "PathRootTbox";
            this.PathRootTbox.ReadOnly = true;
            this.PathRootTbox.Size = new System.Drawing.Size(353, 27);
            this.PathRootTbox.TabIndex = 69;
            this.PathRootTbox.TabStop = false;
            // 
            // DescrTip
            // 
            this.DescrTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.DescrTip.ForeColor = System.Drawing.Color.RoyalBlue;
            this.DescrTip.OwnerDraw = true;
            this.DescrTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.DescrTip_Draw);
            // 
            // Permissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::RegEditor.Theme.Default.FormBackColor;
            this.ClientSize = new System.Drawing.Size(396, 298);
            this.Controls.Add(this.PathRootTbox);
            this.Controls.Add(this.IsInheritedComboBox);
            this.Controls.Add(this.InHeritanceFlagsComboBox);
            this.Controls.Add(this.AccessControlTypeComboBox);
            this.Controls.Add(this.RegistryRightComboBox);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SelectUserComboBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 423);
            this.MinimizeBox = false;
            this.Name = "Permissions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Permissions_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Permissions_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox SelectUserComboBox;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button AcceptBtn;
        private MetroFramework.Controls.MetroComboBox IsInheritedComboBox;
        private MetroFramework.Controls.MetroComboBox InHeritanceFlagsComboBox;
        private MetroFramework.Controls.MetroComboBox AccessControlTypeComboBox;
        private MetroFramework.Controls.MetroComboBox RegistryRightComboBox;
        private System.Windows.Forms.TextBox PathRootTbox;
        private System.Windows.Forms.ToolTip DescrTip;
    }
}