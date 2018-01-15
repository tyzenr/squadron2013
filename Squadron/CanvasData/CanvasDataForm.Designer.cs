namespace Squadron.CanvasData
{
    partial class CanvasDataForm
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
            this.AddinList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.OkButton = new Windows8LookNFeel.Windows8Button();
            this.SelectedColumns = new System.Windows.Forms.CheckedListBox();
            this.SelectedColumnsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterButton = new Windows8LookNFeel.Windows8Button();
            this.FilterList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterText = new System.Windows.Forms.TextBox();
            this.LoadFromFileButton = new Windows8LookNFeel.Windows8Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SelectedColumnsMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.AddinList.Size = new System.Drawing.Size(559, 25);
            this.AddinList.TabIndex = 1;
            this.AddinList.SelectedIndexChanged += new System.EventHandler(this.AddinList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(721, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Canvas Data allows to capture the data from Addin Result, External Files.  These " +
                "data can be filtered or reformatted to provde as input for another Addin.";
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(169, 79);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(559, 323);
            this.grid.TabIndex = 3;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.OkButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(577, 46);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(151, 27);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "Ok";
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SelectedColumns
            // 
            this.SelectedColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedColumns.ContextMenuStrip = this.SelectedColumnsMenu;
            this.SelectedColumns.FormattingEnabled = true;
            this.SelectedColumns.Location = new System.Drawing.Point(12, 79);
            this.SelectedColumns.Name = "SelectedColumns";
            this.SelectedColumns.Size = new System.Drawing.Size(151, 327);
            this.SelectedColumns.TabIndex = 5;
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
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(169, 6);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(205, 25);
            this.FilterButton.TabIndex = 6;
            this.FilterButton.Text = "Apply Filter";
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // FilterList
            // 
            this.FilterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterList.FormattingEnabled = true;
            this.FilterList.Location = new System.Drawing.Point(169, 32);
            this.FilterList.Name = "FilterList";
            this.FilterList.Size = new System.Drawing.Size(203, 21);
            this.FilterList.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(378, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "contains";
            // 
            // FilterText
            // 
            this.FilterText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterText.BackColor = System.Drawing.Color.White;
            this.FilterText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterText.Location = new System.Drawing.Point(435, 6);
            this.FilterText.MaxLength = 0;
            this.FilterText.Multiline = true;
            this.FilterText.Name = "FilterText";
            this.FilterText.Size = new System.Drawing.Size(293, 47);
            this.FilterText.TabIndex = 9;
            this.FilterText.Text = "Filter Value 1\r\nFilter Value 2";
            // 
            // LoadFromFileButton
            // 
            this.LoadFromFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LoadFromFileButton.Location = new System.Drawing.Point(381, 28);
            this.LoadFromFileButton.Name = "LoadFromFileButton";
            this.LoadFromFileButton.Size = new System.Drawing.Size(48, 25);
            this.LoadFromFileButton.TabIndex = 11;
            this.LoadFromFileButton.Text = "Load";
            this.LoadFromFileButton.Click += new System.EventHandler(this.LoadFromFileButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InfoLabel);
            this.panel1.Controls.Add(this.FilterList);
            this.panel1.Controls.Add(this.FilterButton);
            this.panel1.Controls.Add(this.LoadFromFileButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FilterText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 56);
            this.panel1.TabIndex = 12;
            // 
            // InfoLabel
            // 
            this.InfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.InfoLabel.Location = new System.Drawing.Point(12, 6);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(151, 41);
            this.InfoLabel.TabIndex = 12;
            this.InfoLabel.Text = "Info";
            // 
            // CanvasDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SelectedColumns);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddinList);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CanvasDataForm";
            this.Text = "Canvas Data";
            this.Load += new System.EventHandler(this.CanvasDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.SelectedColumnsMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox AddinList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid;
        private Windows8LookNFeel.Windows8Button OkButton;
        public System.Windows.Forms.CheckedListBox SelectedColumns;
        private Windows8LookNFeel.Windows8Button FilterButton;
        private System.Windows.Forms.ComboBox FilterList;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox FilterText;
        private Windows8LookNFeel.Windows8Button LoadFromFileButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.ContextMenuStrip SelectedColumnsMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}
