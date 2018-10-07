namespace RegEditor
{
    partial class Keys
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
            this.NameTbox = new MetroFramework.Controls.MetroTextBox();
            this.s = new MetroFramework.Controls.MetroTextBox();
            this.TypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTbox
            // 
            this.NameTbox.BackColor = global::RegEditor.Theme.Default.TextBoxBackColor;
            // 
            // 
            // 
            this.NameTbox.CustomButton.Image = null;
            this.NameTbox.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.NameTbox.CustomButton.Name = "";
            this.NameTbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NameTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameTbox.CustomButton.TabIndex = 1;
            this.NameTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameTbox.CustomButton.UseSelectable = true;
            this.NameTbox.CustomButton.Visible = false;
            this.NameTbox.ForeColor = global::RegEditor.Theme.Default.TextBoxForeColor;
            this.NameTbox.Lines = new string[0];
            this.NameTbox.Location = new System.Drawing.Point(16, 41);
            this.NameTbox.MaxLength = 30000;
            this.NameTbox.Name = "NameTbox";
            this.NameTbox.PasswordChar = '\0';
            this.NameTbox.PromptText = "Название ключа";
            this.NameTbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTbox.SelectedText = "";
            this.NameTbox.SelectionLength = 0;
            this.NameTbox.SelectionStart = 0;
            this.NameTbox.ShortcutsEnabled = true;
            this.NameTbox.Size = new System.Drawing.Size(258, 23);
            this.NameTbox.Style = global::RegEditor.Theme.Default.TextBoxStyle;
            this.NameTbox.TabIndex = 33;
            this.NameTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTbox.UseCustomBackColor = true;
            this.NameTbox.UseCustomForeColor = true;
            this.NameTbox.UseSelectable = true;
            this.NameTbox.UseStyleColors = true;
            this.NameTbox.WaterMark = "Название ключа";
            this.NameTbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NameTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keys_KeyDown);
            // 
            // s
            // 
            this.s.BackColor = global::RegEditor.Theme.Default.TextBoxBackColor;
            // 
            // 
            // 
            this.s.CustomButton.Image = null;
            this.s.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.s.CustomButton.Name = "";
            this.s.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.s.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.s.CustomButton.TabIndex = 1;
            this.s.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.s.CustomButton.UseSelectable = true;
            this.s.CustomButton.Visible = false;
            this.s.ForeColor = global::RegEditor.Theme.Default.TextBoxForeColor;
            this.s.Lines = new string[0];
            this.s.Location = new System.Drawing.Point(16, 76);
            this.s.MaxLength = 30000;
            this.s.Name = "s";
            this.s.PasswordChar = '\0';
            this.s.PromptText = "Значение ключа";
            this.s.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.s.SelectedText = "";
            this.s.SelectionLength = 0;
            this.s.SelectionStart = 0;
            this.s.ShortcutsEnabled = true;
            this.s.Size = new System.Drawing.Size(258, 23);
            this.s.Style = global::RegEditor.Theme.Default.TextBoxStyle;
            this.s.TabIndex = 34;
            this.s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.s.UseCustomBackColor = true;
            this.s.UseCustomForeColor = true;
            this.s.UseSelectable = true;
            this.s.UseStyleColors = true;
            this.s.WaterMark = "Значение ключа";
            this.s.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.s.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.s.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keys_KeyDown);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.BackColor = global::RegEditor.Theme.Default.combox_rgb_bg;
            this.TypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeComboBox.ForeColor = global::RegEditor.Theme.Default.ComboboxForeColor;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.ItemHeight = 23;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Binary",
            "DWord",
            "QWord",
            "String",
            "ExpandString",
            "MultiString"});
            this.TypeComboBox.Location = new System.Drawing.Point(16, 113);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.PromptText = "Тип ключа";
            this.TypeComboBox.Size = new System.Drawing.Size(258, 29);
            this.TypeComboBox.Style = global::RegEditor.Theme.Default.combox_style;
            this.TypeComboBox.TabIndex = 35;
            this.TypeComboBox.UseCustomBackColor = true;
            this.TypeComboBox.UseCustomForeColor = true;
            this.TypeComboBox.UseSelectable = true;
            this.TypeComboBox.UseStyleColors = true;
            this.TypeComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keys_KeyDown);
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.BackgroundImage = global::RegEditor.Properties.Resources.Accept;
            this.AcceptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AcceptBtn.FlatAppearance.BorderSize = 0;
            this.AcceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptBtn.Location = new System.Drawing.Point(95, 155);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(53, 51);
            this.AcceptBtn.TabIndex = 56;
            this.AcceptBtn.UseVisualStyleBackColor = false;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            this.AcceptBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keys_KeyDown);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackgroundImage = global::RegEditor.Properties.Resources.Cancel;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(146, 155);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(53, 51);
            this.CloseBtn.TabIndex = 57;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            this.CloseBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keys_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 82;
            this.label1.Text = "Изменить ключ";
            // 
            // Keys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::RegEditor.Theme.Default.FormBackColor;
            this.ClientSize = new System.Drawing.Size(290, 219);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.s);
            this.Controls.Add(this.NameTbox);
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.MaximumSize = new System.Drawing.Size(306, 258);
            this.MinimumSize = new System.Drawing.Size(306, 258);
            this.Name = "Keys";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Keys_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keys_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Keys_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox NameTbox;
        private MetroFramework.Controls.MetroTextBox s;
        private MetroFramework.Controls.MetroComboBox TypeComboBox;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label1;
    }
}