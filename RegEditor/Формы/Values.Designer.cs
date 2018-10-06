namespace RegEditor
{
    partial class ValuesForm
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
            this.KeyNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.KeyValueTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TypeKeyComboBox = new MetroFramework.Controls.MetroComboBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KeyNameTextBox
            // 
            this.KeyNameTextBox.BackColor = global::RegEditor.Theme.Default.TextBoxBackColor;
            // 
            // 
            // 
            this.KeyNameTextBox.CustomButton.Image = null;
            this.KeyNameTextBox.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.KeyNameTextBox.CustomButton.Name = "";
            this.KeyNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.KeyNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.KeyNameTextBox.CustomButton.TabIndex = 1;
            this.KeyNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.KeyNameTextBox.CustomButton.UseSelectable = true;
            this.KeyNameTextBox.CustomButton.Visible = false;
            this.KeyNameTextBox.ForeColor = global::RegEditor.Theme.Default.TextBoxForeColor;
            this.KeyNameTextBox.Lines = new string[0];
            this.KeyNameTextBox.Location = new System.Drawing.Point(16, 41);
            this.KeyNameTextBox.MaxLength = 30000;
            this.KeyNameTextBox.Name = "KeyNameTextBox";
            this.KeyNameTextBox.PasswordChar = '\0';
            this.KeyNameTextBox.PromptText = "Название ключа";
            this.KeyNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.KeyNameTextBox.SelectedText = "";
            this.KeyNameTextBox.SelectionLength = 0;
            this.KeyNameTextBox.SelectionStart = 0;
            this.KeyNameTextBox.ShortcutsEnabled = true;
            this.KeyNameTextBox.Size = new System.Drawing.Size(258, 23);
            this.KeyNameTextBox.Style = global::RegEditor.Theme.Default.TextBoxStyle;
            this.KeyNameTextBox.TabIndex = 33;
            this.KeyNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyNameTextBox.UseCustomBackColor = true;
            this.KeyNameTextBox.UseCustomForeColor = true;
            this.KeyNameTextBox.UseSelectable = true;
            this.KeyNameTextBox.UseStyleColors = true;
            this.KeyNameTextBox.WaterMark = "Название ключа";
            this.KeyNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.KeyNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.KeyNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddSection_KeyDown);
            // 
            // KeyValueTextBox
            // 
            this.KeyValueTextBox.BackColor = global::RegEditor.Theme.Default.TextBoxBackColor;
            // 
            // 
            // 
            this.KeyValueTextBox.CustomButton.Image = null;
            this.KeyValueTextBox.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.KeyValueTextBox.CustomButton.Name = "";
            this.KeyValueTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.KeyValueTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.KeyValueTextBox.CustomButton.TabIndex = 1;
            this.KeyValueTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.KeyValueTextBox.CustomButton.UseSelectable = true;
            this.KeyValueTextBox.CustomButton.Visible = false;
            this.KeyValueTextBox.ForeColor = global::RegEditor.Theme.Default.TextBoxForeColor;
            this.KeyValueTextBox.Lines = new string[0];
            this.KeyValueTextBox.Location = new System.Drawing.Point(16, 76);
            this.KeyValueTextBox.MaxLength = 30000;
            this.KeyValueTextBox.Name = "KeyValueTextBox";
            this.KeyValueTextBox.PasswordChar = '\0';
            this.KeyValueTextBox.PromptText = "Значение ключа";
            this.KeyValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.KeyValueTextBox.SelectedText = "";
            this.KeyValueTextBox.SelectionLength = 0;
            this.KeyValueTextBox.SelectionStart = 0;
            this.KeyValueTextBox.ShortcutsEnabled = true;
            this.KeyValueTextBox.Size = new System.Drawing.Size(258, 23);
            this.KeyValueTextBox.Style = global::RegEditor.Theme.Default.TextBoxStyle;
            this.KeyValueTextBox.TabIndex = 34;
            this.KeyValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyValueTextBox.UseCustomBackColor = true;
            this.KeyValueTextBox.UseCustomForeColor = true;
            this.KeyValueTextBox.UseSelectable = true;
            this.KeyValueTextBox.UseStyleColors = true;
            this.KeyValueTextBox.WaterMark = "Значение ключа";
            this.KeyValueTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.KeyValueTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.KeyValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddSection_KeyDown);
            // 
            // TypeKeyComboBox
            // 
            this.TypeKeyComboBox.BackColor = global::RegEditor.Theme.Default.combox_rgb_bg;
            this.TypeKeyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeKeyComboBox.ForeColor = global::RegEditor.Theme.Default.ComboboxForeColor;
            this.TypeKeyComboBox.FormattingEnabled = true;
            this.TypeKeyComboBox.ItemHeight = 23;
            this.TypeKeyComboBox.Items.AddRange(new object[] {
            "Binary",
            "DWord",
            "QWord",
            "String",
            "ExpandString",
            "MultiString"});
            this.TypeKeyComboBox.Location = new System.Drawing.Point(16, 113);
            this.TypeKeyComboBox.Name = "TypeKeyComboBox";
            this.TypeKeyComboBox.PromptText = "Тип ключа";
            this.TypeKeyComboBox.Size = new System.Drawing.Size(258, 29);
            this.TypeKeyComboBox.Style = global::RegEditor.Theme.Default.combox_style;
            this.TypeKeyComboBox.TabIndex = 35;
            this.TypeKeyComboBox.UseCustomBackColor = true;
            this.TypeKeyComboBox.UseCustomForeColor = true;
            this.TypeKeyComboBox.UseSelectable = true;
            this.TypeKeyComboBox.UseStyleColors = true;
            this.TypeKeyComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddSection_KeyDown);
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackgroundImage = global::RegEditor.Properties.Resources.Accept;
            this.AcceptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AcceptButton.FlatAppearance.BorderSize = 0;
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptButton.Location = new System.Drawing.Point(95, 155);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(53, 51);
            this.AcceptButton.TabIndex = 56;
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.Button1_Click);
            this.AcceptButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddSection_KeyDown);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = global::RegEditor.Properties.Resources.Cancel;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(146, 155);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(53, 51);
            this.CloseButton.TabIndex = 57;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddSection_KeyDown);
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
            // ValuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::RegEditor.Theme.Default.FormBackColor;
            this.ClientSize = new System.Drawing.Size(290, 214);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.TypeKeyComboBox);
            this.Controls.Add(this.KeyValueTextBox);
            this.Controls.Add(this.KeyNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.MaximumSize = new System.Drawing.Size(306, 230);
            this.MinimumSize = new System.Drawing.Size(306, 230);
            this.Name = "ValuesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddSection_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddSection_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Values_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox KeyNameTextBox;
        private MetroFramework.Controls.MetroTextBox KeyValueTextBox;
        private MetroFramework.Controls.MetroComboBox TypeKeyComboBox;
        private new System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
    }
}