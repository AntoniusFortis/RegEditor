namespace RegEditor
{
    partial class Roots
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
            this.RootNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RootNameTextBox
            // 
            this.RootNameTextBox.BackColor = global::RegEditor.Theme.Default.TextBoxBackColor;
            // 
            // 
            // 
            this.RootNameTextBox.CustomButton.Image = null;
            this.RootNameTextBox.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.RootNameTextBox.CustomButton.Name = "";
            this.RootNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RootNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RootNameTextBox.CustomButton.TabIndex = 1;
            this.RootNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RootNameTextBox.CustomButton.UseSelectable = true;
            this.RootNameTextBox.CustomButton.Visible = false;
            this.RootNameTextBox.ForeColor = global::RegEditor.Theme.Default.TextBoxForeColor;
            this.RootNameTextBox.Lines = new string[0];
            this.RootNameTextBox.Location = new System.Drawing.Point(12, 36);
            this.RootNameTextBox.MaxLength = 30000;
            this.RootNameTextBox.Name = "RootNameTextBox";
            this.RootNameTextBox.PasswordChar = '\0';
            this.RootNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RootNameTextBox.SelectedText = "";
            this.RootNameTextBox.SelectionLength = 0;
            this.RootNameTextBox.SelectionStart = 0;
            this.RootNameTextBox.ShortcutsEnabled = true;
            this.RootNameTextBox.Size = new System.Drawing.Size(281, 23);
            this.RootNameTextBox.Style = global::RegEditor.Theme.Default.TextBoxStyle;
            this.RootNameTextBox.TabIndex = 37;
            this.RootNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RootNameTextBox.UseCustomBackColor = true;
            this.RootNameTextBox.UseCustomForeColor = true;
            this.RootNameTextBox.UseSelectable = true;
            this.RootNameTextBox.UseStyleColors = true;
            this.RootNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RootNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.RootNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddRoot_KeyDown);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = global::RegEditor.Properties.Resources.Cancel;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(157, 66);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(48, 46);
            this.CloseButton.TabIndex = 57;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddRoot_KeyDown);
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackgroundImage = global::RegEditor.Properties.Resources.Accept;
            this.AcceptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AcceptButton.FlatAppearance.BorderSize = 0;
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptButton.Location = new System.Drawing.Point(110, 66);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(48, 46);
            this.AcceptButton.TabIndex = 56;
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            this.AcceptButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddRoot_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(89, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 83;
            this.label1.Text = "Добавить раздел";
            // 
            // Roots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::RegEditor.Theme.Default.FormBackColor;
            this.ClientSize = new System.Drawing.Size(305, 120);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.RootNameTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(321, 136);
            this.MinimizeBox = false;
            this.Name = "Roots";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_AddRoot_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddRoot_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Roots_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox RootNameTextBox;
        private new System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
    }
}