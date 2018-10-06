namespace RegEditor
{
    partial class AboutProduct
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
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.NameAppLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.ForeColor = System.Drawing.Color.White;
            this.AuthorLabel.Location = new System.Drawing.Point(88, 153);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(146, 21);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "by Anton Drugalev";
            this.AuthorLabel.Click += new System.EventHandler(this.AboutProduct_Click);
            // 
            // NameAppLabel
            // 
            this.NameAppLabel.AutoSize = true;
            this.NameAppLabel.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameAppLabel.ForeColor = System.Drawing.Color.White;
            this.NameAppLabel.Location = new System.Drawing.Point(49, 46);
            this.NameAppLabel.Name = "NameAppLabel";
            this.NameAppLabel.Size = new System.Drawing.Size(249, 81);
            this.NameAppLabel.TabIndex = 3;
            this.NameAppLabel.Text = "RegEdit";
            this.NameAppLabel.Click += new System.EventHandler(this.AboutProduct_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VersionLabel.ForeColor = System.Drawing.Color.White;
            this.VersionLabel.Location = new System.Drawing.Point(289, 10);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(40, 23);
            this.VersionLabel.TabIndex = 4;
            this.VersionLabel.Text = "ver";
            this.VersionLabel.Click += new System.EventHandler(this.AboutProduct_Click);
            // 
            // AboutProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(331, 199);
            this.ControlBox = false;
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.NameAppLabel);
            this.Controls.Add(this.AuthorLabel);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(347, 215);
            this.MinimumSize = new System.Drawing.Size(347, 215);
            this.Name = "AboutProduct";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AboutProduct_Load);
            this.Click += new System.EventHandler(this.AboutProduct_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label NameAppLabel;
        private System.Windows.Forms.Label VersionLabel;
    }
}