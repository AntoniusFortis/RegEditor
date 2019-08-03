using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace RegEditor
{
    partial class Roots
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.CloseBtn = new System.Windows.Forms.Button();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTbox
            // 
            this.NameTbox.BackColor = global::RegEditor.Theme.Default.TextBoxBackColor;
            // 
            // 
            // 
            this.NameTbox.CustomButton.Image = null;
            this.NameTbox.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.NameTbox.CustomButton.Name = "";
            this.NameTbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NameTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameTbox.CustomButton.TabIndex = 1;
            this.NameTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameTbox.CustomButton.UseSelectable = true;
            this.NameTbox.CustomButton.Visible = false;
            this.NameTbox.ForeColor = global::RegEditor.Theme.Default.TextBoxForeColor;
            this.NameTbox.Lines = new string[0];
            this.NameTbox.Location = new System.Drawing.Point(12, 36);
            this.NameTbox.MaxLength = 30000;
            this.NameTbox.Name = "NameTbox";
            this.NameTbox.PasswordChar = '\0';
            this.NameTbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTbox.SelectedText = "";
            this.NameTbox.SelectionLength = 0;
            this.NameTbox.SelectionStart = 0;
            this.NameTbox.ShortcutsEnabled = true;
            this.NameTbox.Size = new System.Drawing.Size(281, 23);
            this.NameTbox.Style = global::RegEditor.Theme.Default.TextBoxStyle;
            this.NameTbox.TabIndex = 37;
            this.NameTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTbox.UseCustomBackColor = true;
            this.NameTbox.UseCustomForeColor = true;
            this.NameTbox.UseSelectable = true;
            this.NameTbox.UseStyleColors = true;
            this.NameTbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NameTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Roots_KeyDown);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackgroundImage = global::RegEditor.Properties.Resources.Cancel;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(157, 66);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(48, 46);
            this.CloseBtn.TabIndex = 57;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            this.CloseBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Roots_KeyDown);
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.BackgroundImage = global::RegEditor.Properties.Resources.Accept;
            this.AcceptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AcceptBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptBtn.FlatAppearance.BorderSize = 0;
            this.AcceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptBtn.Location = new System.Drawing.Point(110, 66);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(48, 46);
            this.AcceptBtn.TabIndex = 56;
            this.AcceptBtn.UseVisualStyleBackColor = false;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            this.AcceptBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Roots_KeyDown);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(89, 7);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(132, 21);
            this.TitleLabel.TabIndex = 83;
            this.TitleLabel.Text = "Добавить раздел";
            // 
            // Roots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::RegEditor.Theme.Default.FormBackColor;
            this.ClientSize = new System.Drawing.Size(305, 102);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.NameTbox);
            this.Controls.Add(this.TitleLabel);
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(321, 141);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(321, 141);
            this.Name = "Roots";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Roots_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Roots_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Roots_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroTextBox NameTbox;
        private Button AcceptBtn;
        private Button CloseBtn;
        private Label TitleLabel;
    }
}