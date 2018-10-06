namespace RegEditor
{
    partial class SearchOptionsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListRootsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameKeyTile = new System.Windows.Forms.Button();
            this.ValueKeyTile = new System.Windows.Forms.Button();
            this.UnitWordTile = new System.Windows.Forms.Button();
            this.CompTile = new System.Windows.Forms.Button();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListRootsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListRootsDataGridView
            // 
            this.ListRootsDataGridView.AllowUserToAddRows = false;
            this.ListRootsDataGridView.AllowUserToDeleteRows = false;
            this.ListRootsDataGridView.AllowUserToResizeColumns = false;
            this.ListRootsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.ListRootsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ListRootsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListRootsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ListRootsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListRootsDataGridView.ColumnHeadersVisible = false;
            this.ListRootsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListRootsDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.ListRootsDataGridView.Location = new System.Drawing.Point(12, 34);
            this.ListRootsDataGridView.Name = "ListRootsDataGridView";
            this.ListRootsDataGridView.RowHeadersVisible = false;
            this.ListRootsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListRootsDataGridView.ShowCellErrors = false;
            this.ListRootsDataGridView.ShowCellToolTips = false;
            this.ListRootsDataGridView.ShowEditingIcon = false;
            this.ListRootsDataGridView.ShowRowErrors = false;
            this.ListRootsDataGridView.Size = new System.Drawing.Size(218, 150);
            this.ListRootsDataGridView.TabIndex = 76;
            this.ListRootsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListRootsDataGridView_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 40.60914F;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column2.FillWeight = 159.3909F;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // NameKeyTile
            // 
            this.NameKeyTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.NameKeyTile.FlatAppearance.BorderSize = 0;
            this.NameKeyTile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameKeyTile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.NameKeyTile.ForeColor = System.Drawing.Color.Black;
            this.NameKeyTile.Location = new System.Drawing.Point(237, 34);
            this.NameKeyTile.Name = "NameKeyTile";
            this.NameKeyTile.Size = new System.Drawing.Size(158, 37);
            this.NameKeyTile.TabIndex = 78;
            this.NameKeyTile.Text = "Имя ключа";
            this.NameKeyTile.UseVisualStyleBackColor = false;
            this.NameKeyTile.Click += new System.EventHandler(this.NameKeyTile_Click);
            // 
            // ValueKeyTile
            // 
            this.ValueKeyTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ValueKeyTile.FlatAppearance.BorderSize = 0;
            this.ValueKeyTile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValueKeyTile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ValueKeyTile.ForeColor = System.Drawing.Color.Black;
            this.ValueKeyTile.Location = new System.Drawing.Point(237, 72);
            this.ValueKeyTile.Name = "ValueKeyTile";
            this.ValueKeyTile.Size = new System.Drawing.Size(158, 37);
            this.ValueKeyTile.TabIndex = 79;
            this.ValueKeyTile.Text = "Значение ключа";
            this.ValueKeyTile.UseVisualStyleBackColor = false;
            this.ValueKeyTile.Click += new System.EventHandler(this.Tile_ValKey_Flag_Click);
            // 
            // UnitWordTile
            // 
            this.UnitWordTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.UnitWordTile.FlatAppearance.BorderSize = 0;
            this.UnitWordTile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnitWordTile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.UnitWordTile.ForeColor = System.Drawing.Color.Black;
            this.UnitWordTile.Location = new System.Drawing.Point(237, 110);
            this.UnitWordTile.Name = "UnitWordTile";
            this.UnitWordTile.Size = new System.Drawing.Size(158, 37);
            this.UnitWordTile.TabIndex = 80;
            this.UnitWordTile.Text = "Целое предложение";
            this.UnitWordTile.UseVisualStyleBackColor = false;
            this.UnitWordTile.Click += new System.EventHandler(this.MetroTile8_Click);
            // 
            // CompTile
            // 
            this.CompTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.CompTile.FlatAppearance.BorderSize = 0;
            this.CompTile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompTile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompTile.ForeColor = System.Drawing.Color.Black;
            this.CompTile.Location = new System.Drawing.Point(237, 148);
            this.CompTile.Name = "CompTile";
            this.CompTile.Size = new System.Drawing.Size(158, 37);
            this.CompTile.TabIndex = 81;
            this.CompTile.Text = "Зависимость от регистра";
            this.CompTile.UseVisualStyleBackColor = false;
            this.CompTile.Click += new System.EventHandler(this.MetroTile1_Click);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CloseFormButton.FlatAppearance.BorderSize = 0;
            this.CloseFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CloseFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseFormButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.CloseFormButton.ForeColor = System.Drawing.Color.White;
            this.CloseFormButton.Location = new System.Drawing.Point(12, 193);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(383, 27);
            this.CloseFormButton.TabIndex = 82;
            this.CloseFormButton.Text = "Закрыть";
            this.CloseFormButton.UseVisualStyleBackColor = false;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(128, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 87;
            this.label1.Text = "Настройка поиска";
            // 
            // SearchOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::RegEditor.Theme.Default.FormBackColor;
            this.ClientSize = new System.Drawing.Size(407, 230);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.CompTile);
            this.Controls.Add(this.UnitWordTile);
            this.Controls.Add(this.ValueKeyTile);
            this.Controls.Add(this.NameKeyTile);
            this.Controls.Add(this.ListRootsDataGridView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(423, 248);
            this.MinimizeBox = false;
            this.Name = "SearchOptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SearchOptions_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchOptionsForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.ListRootsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ListRootsDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button NameKeyTile;
        private System.Windows.Forms.Button ValueKeyTile;
        private System.Windows.Forms.Button UnitWordTile;
        private System.Windows.Forms.Button CompTile;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.Label label1;
    }
}