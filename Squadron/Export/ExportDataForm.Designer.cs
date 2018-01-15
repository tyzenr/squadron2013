namespace Squadron.ExportData
{
    partial class ExportDataForm
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
            this.SelectedColumns = new System.Windows.Forms.CheckedListBox();
            this.SelectedColumnsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportButton = new Windows8LookNFeel.Windows8Button();
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddinList = new System.Windows.Forms.ComboBox();
            this.LaunchCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.CancelButton = new Windows8LookNFeel.Windows8Button();
            this.SelectedColumnsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedColumns
            // 
            this.SelectedColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedColumns.ContextMenuStrip = this.SelectedColumnsMenu;
            this.SelectedColumns.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedColumns.FormattingEnabled = true;
            this.SelectedColumns.Location = new System.Drawing.Point(12, 88);
            this.SelectedColumns.Name = "SelectedColumns";
            this.SelectedColumns.Size = new System.Drawing.Size(151, 346);
            this.SelectedColumns.TabIndex = 10;
            // 
            // SelectedColumnsMenu
            // 
            this.SelectedColumnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.SelectedColumnsMenu.Name = "contextMenuStrip1";
            this.SelectedColumnsMenu.Size = new System.Drawing.Size(138, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItem1.Text = "Check All";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.checkAll);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItem2.Text = "Uncheck All";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.uncheckAll);
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.ExportButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExportButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ExportButton.ForeColor = System.Drawing.Color.White;
            this.ExportButton.Image = null;
            this.ExportButton.Location = new System.Drawing.Point(632, 30);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(95, 27);
            this.ExportButton.TabIndex = 9;
            this.ExportButton.Text = "Ok";
            this.ExportButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(168, 88);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(559, 349);
            this.grid.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "The Export Data form allows you to Export data from Grid, List Box or the Log Box" +
    ".  For exporting please select the Data Container from the list below && click t" +
    "he Ok button export.\r\n";
            // 
            // AddinList
            // 
            this.AddinList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddinList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddinList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddinList.FormattingEnabled = true;
            this.AddinList.Location = new System.Drawing.Point(12, 48);
            this.AddinList.Name = "AddinList";
            this.AddinList.Size = new System.Drawing.Size(614, 25);
            this.AddinList.TabIndex = 6;
            this.AddinList.SelectedIndexChanged += new System.EventHandler(this.AddinList_SelectedIndexChanged);
            // 
            // LaunchCheck
            // 
            this.LaunchCheck.AutoSize = true;
            this.LaunchCheck.Checked = true;
            this.LaunchCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LaunchCheck.Location = new System.Drawing.Point(577, 9);
            this.LaunchCheck.Name = "LaunchCheck";
            this.LaunchCheck.Size = new System.Drawing.Size(128, 17);
            this.LaunchCheck.TabIndex = 11;
            this.LaunchCheck.Text = "Launch file after save";
            this.LaunchCheck.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Image = null;
            this.CancelButton.Location = new System.Drawing.Point(632, 59);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(95, 27);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ExportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 444);
            this.Controls.Add(this.LaunchCheck);
            this.Controls.Add(this.SelectedColumns);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddinList);
            this.Name = "ExportDataForm";
            this.Text = "Export Data";
            this.Load += new System.EventHandler(this.ExportDataForm_Load);
            this.SelectedColumnsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckedListBox SelectedColumns;
        private Windows8LookNFeel.Windows8Button ExportButton;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AddinList;
        private Windows8LookNFeel.Windows8CheckBox LaunchCheck;
        private System.Windows.Forms.ContextMenuStrip SelectedColumnsMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private Windows8LookNFeel.Windows8Button CancelButton;
    }
}
