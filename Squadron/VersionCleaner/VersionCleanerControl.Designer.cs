namespace SquadronAddIns.Default.VersionCleaner
{
    partial class VersionCleanerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.stylingWorkarea3 = new Windows8LookNFeel.Windows8Panel();
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.ListColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stylingPanel2 = new Windows8LookNFeel.Windows8Panel();
            this.stylingWorkarea4 = new Windows8LookNFeel.Windows8Panel();
            this.DeleteButton = new Windows8LookNFeel.Windows8Button();
            this.MoveToRecycleBinButton = new Windows8LookNFeel.Windows8Button();
            this.stylingWorkarea1 = new Windows8LookNFeel.Windows8Panel();
            this.list = new System.Windows.Forms.CheckedListBox();
            this.stylingPanel1 = new Windows8LookNFeel.Windows8Panel();
            this.stylingWorkarea2 = new Windows8LookNFeel.Windows8Panel();
            this.CountText = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FindButton = new Windows8LookNFeel.Windows8Button();
            this.stylingWorkarea7 = new Windows8LookNFeel.Windows8Panel();
            this.explorer = new SquadronAddIns.Default.Components.SharePointExplorer();
            this.stylingPanel4 = new Windows8LookNFeel.Windows8Panel();
            this.stylingWorkarea8 = new Windows8LookNFeel.Windows8Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.stylingWorkarea3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.stylingWorkarea4.SuspendLayout();
            this.stylingWorkarea1.SuspendLayout();
            this.stylingWorkarea2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountText)).BeginInit();
            this.stylingWorkarea7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.stylingWorkarea3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.stylingWorkarea1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.stylingWorkarea7, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 380);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // stylingWorkarea3
            // 
            this.stylingWorkarea3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea3.Caption = null;
            this.stylingWorkarea3.Controls.Add(this.grid);
            this.stylingWorkarea3.Controls.Add(this.stylingPanel2);
            this.stylingWorkarea3.Controls.Add(this.stylingWorkarea4);
            this.stylingWorkarea3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea3.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingWorkarea3.HasBorder = true;
            this.stylingWorkarea3.Image = null;
            this.stylingWorkarea3.IsImageTransparent = false;
            this.stylingWorkarea3.Location = new System.Drawing.Point(253, 3);
            this.stylingWorkarea3.Name = "stylingWorkarea3";
            this.stylingWorkarea3.Size = new System.Drawing.Size(306, 374);
            this.stylingWorkarea3.TabIndex = 5;
            this.stylingWorkarea3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // grid
            // 
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ListColumn,
            this.ItemColumn,
            this.VersionsColumn});
            this.grid.CustomBackColor1 = System.Drawing.Color.Empty;
            this.grid.CustomBackColor2 = System.Drawing.Color.Empty;
            this.grid.CustomForecolor = System.Drawing.Color.Empty;
            this.grid.CustomSelectedBackColor1 = System.Drawing.Color.Empty;
            this.grid.CustomSelectedBackColor2 = System.Drawing.Color.Empty;
            this.grid.CustomSelectedForecolor = System.Drawing.Color.Empty;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.grid.Font = new System.Drawing.Font("Verdana", 9F);
            this.grid.Location = new System.Drawing.Point(0, 27);
            this.grid.Name = "grid";
            this.grid.NoSelectedColor = false;
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 45;
            this.grid.Size = new System.Drawing.Size(306, 302);
            this.grid.TabIndex = 7;
            this.toolTip1.SetToolTip(this.grid, "Displays list item(s) with search criteria (excludes currrent-version items)");
            // 
            // ListColumn
            // 
            this.ListColumn.DataPropertyName = "ListTitle";
            this.ListColumn.HeaderText = "List";
            this.ListColumn.Name = "ListColumn";
            this.ListColumn.ReadOnly = true;
            // 
            // ItemColumn
            // 
            this.ItemColumn.DataPropertyName = "ItemTitle";
            this.ItemColumn.HeaderText = "Item";
            this.ItemColumn.Name = "ItemColumn";
            this.ItemColumn.ReadOnly = true;
            // 
            // VersionsColumn
            // 
            this.VersionsColumn.DataPropertyName = "VersionCount";
            this.VersionsColumn.HeaderText = "Versions";
            this.VersionsColumn.Name = "VersionsColumn";
            this.VersionsColumn.ReadOnly = true;
            // 
            // stylingPanel2
            // 
            this.stylingPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.stylingPanel2.Caption = "Step 3";
            this.stylingPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.stylingPanel2.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.stylingPanel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.stylingPanel2.ForeColor = System.Drawing.Color.White;
            this.stylingPanel2.HasBorder = true;
            this.stylingPanel2.Image = null;
            this.stylingPanel2.IsImageTransparent = false;
            this.stylingPanel2.Location = new System.Drawing.Point(0, 0);
            this.stylingPanel2.Name = "stylingPanel2";
            this.stylingPanel2.Size = new System.Drawing.Size(306, 27);
            this.stylingPanel2.TabIndex = 6;
            this.stylingPanel2.Text = "Step 3";
            this.stylingPanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stylingWorkarea4
            // 
            this.stylingWorkarea4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea4.Caption = null;
            this.stylingWorkarea4.Controls.Add(this.DeleteButton);
            this.stylingWorkarea4.Controls.Add(this.MoveToRecycleBinButton);
            this.stylingWorkarea4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stylingWorkarea4.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingWorkarea4.HasBorder = true;
            this.stylingWorkarea4.Image = null;
            this.stylingWorkarea4.IsImageTransparent = false;
            this.stylingWorkarea4.Location = new System.Drawing.Point(0, 329);
            this.stylingWorkarea4.Name = "stylingWorkarea4";
            this.stylingWorkarea4.Size = new System.Drawing.Size(306, 45);
            this.stylingWorkarea4.TabIndex = 0;
            this.stylingWorkarea4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.DeleteButton.Caption = "Delete";
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Description = null;
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.HasBorder = true;
            this.DeleteButton.HasRightSideBorder = false;
            this.DeleteButton.Image = null;
            this.DeleteButton.Is2PaneDrawing = false;
            this.DeleteButton.IsImageTransparent = false;
            this.DeleteButton.IsMouseOn = false;
            this.DeleteButton.IsRadio = false;
            this.DeleteButton.Location = new System.Drawing.Point(229, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ShowDescriptionOnHover = true;
            this.DeleteButton.Size = new System.Drawing.Size(123, 45);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.DeleteButton, "Deletes Version(s) listed above (Except latest version)");
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MoveToRecycleBinButton
            // 
            this.MoveToRecycleBinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.MoveToRecycleBinButton.Caption = "Move to Recycle Bin";
            this.MoveToRecycleBinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveToRecycleBinButton.Description = null;
            this.MoveToRecycleBinButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MoveToRecycleBinButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MoveToRecycleBinButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.MoveToRecycleBinButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveToRecycleBinButton.ForeColor = System.Drawing.Color.White;
            this.MoveToRecycleBinButton.HasBorder = true;
            this.MoveToRecycleBinButton.HasRightSideBorder = false;
            this.MoveToRecycleBinButton.Image = null;
            this.MoveToRecycleBinButton.Is2PaneDrawing = false;
            this.MoveToRecycleBinButton.IsImageTransparent = false;
            this.MoveToRecycleBinButton.IsMouseOn = false;
            this.MoveToRecycleBinButton.IsRadio = false;
            this.MoveToRecycleBinButton.Location = new System.Drawing.Point(0, 0);
            this.MoveToRecycleBinButton.Name = "MoveToRecycleBinButton";
            this.MoveToRecycleBinButton.ShowDescriptionOnHover = true;
            this.MoveToRecycleBinButton.Size = new System.Drawing.Size(229, 45);
            this.MoveToRecycleBinButton.TabIndex = 17;
            this.MoveToRecycleBinButton.Text = "Move to Recycle Bin";
            this.MoveToRecycleBinButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.MoveToRecycleBinButton, "Moves Version(s) listed above to Recycle Bin (Except latest version)");
            this.MoveToRecycleBinButton.Click += new System.EventHandler(this.MoveToRecycleBinButton_Click);
            // 
            // stylingWorkarea1
            // 
            this.stylingWorkarea1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea1.Caption = null;
            this.stylingWorkarea1.Controls.Add(this.list);
            this.stylingWorkarea1.Controls.Add(this.stylingPanel1);
            this.stylingWorkarea1.Controls.Add(this.stylingWorkarea2);
            this.stylingWorkarea1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea1.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingWorkarea1.HasBorder = true;
            this.stylingWorkarea1.Image = null;
            this.stylingWorkarea1.IsImageTransparent = false;
            this.stylingWorkarea1.Location = new System.Drawing.Point(128, 3);
            this.stylingWorkarea1.Name = "stylingWorkarea1";
            this.stylingWorkarea1.Size = new System.Drawing.Size(119, 374);
            this.stylingWorkarea1.TabIndex = 4;
            this.stylingWorkarea1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // list
            // 
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(0, 27);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(119, 220);
            this.list.TabIndex = 7;
            this.toolTip1.SetToolTip(this.list, "Right click to check/uncheck list(s)");
            // 
            // stylingPanel1
            // 
            this.stylingPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.stylingPanel1.Caption = "Step 2";
            this.stylingPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stylingPanel1.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.stylingPanel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.stylingPanel1.ForeColor = System.Drawing.Color.White;
            this.stylingPanel1.HasBorder = true;
            this.stylingPanel1.Image = null;
            this.stylingPanel1.IsImageTransparent = false;
            this.stylingPanel1.Location = new System.Drawing.Point(0, 0);
            this.stylingPanel1.Name = "stylingPanel1";
            this.stylingPanel1.Size = new System.Drawing.Size(119, 27);
            this.stylingPanel1.TabIndex = 6;
            this.stylingPanel1.Text = "Step 2";
            this.stylingPanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stylingWorkarea2
            // 
            this.stylingWorkarea2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea2.Caption = null;
            this.stylingWorkarea2.Controls.Add(this.CountText);
            this.stylingWorkarea2.Controls.Add(this.label2);
            this.stylingWorkarea2.Controls.Add(this.label1);
            this.stylingWorkarea2.Controls.Add(this.FindButton);
            this.stylingWorkarea2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stylingWorkarea2.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingWorkarea2.HasBorder = true;
            this.stylingWorkarea2.Image = null;
            this.stylingWorkarea2.IsImageTransparent = false;
            this.stylingWorkarea2.Location = new System.Drawing.Point(0, 247);
            this.stylingWorkarea2.Name = "stylingWorkarea2";
            this.stylingWorkarea2.Size = new System.Drawing.Size(119, 127);
            this.stylingWorkarea2.TabIndex = 0;
            this.stylingWorkarea2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CountText
            // 
            this.CountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountText.Location = new System.Drawing.Point(104, 4);
            this.CountText.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CountText.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.CountText.Name = "CountText";
            this.CountText.Size = new System.Drawing.Size(50, 21);
            this.CountText.TabIndex = 18;
            this.CountText.Value = new decimal(new int[] {
            365,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "days before";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Versions Created:";
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.FindButton.Caption = "Find";
            this.FindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindButton.Description = null;
            this.FindButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FindButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FindButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.FindButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.ForeColor = System.Drawing.Color.White;
            this.FindButton.HasBorder = true;
            this.FindButton.HasRightSideBorder = false;
            this.FindButton.Image = null;
            this.FindButton.Is2PaneDrawing = false;
            this.FindButton.IsImageTransparent = false;
            this.FindButton.IsMouseOn = false;
            this.FindButton.IsRadio = false;
            this.FindButton.Location = new System.Drawing.Point(0, 100);
            this.FindButton.Name = "FindButton";
            this.FindButton.ShowDescriptionOnHover = true;
            this.FindButton.Size = new System.Drawing.Size(119, 27);
            this.FindButton.TabIndex = 15;
            this.FindButton.Text = "Find";
            this.FindButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.FindButton, "Find Version(s) based on above Search Criteria on selected list(s)");
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // stylingWorkarea7
            // 
            this.stylingWorkarea7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea7.Caption = null;
            this.stylingWorkarea7.Controls.Add(this.explorer);
            this.stylingWorkarea7.Controls.Add(this.stylingPanel4);
            this.stylingWorkarea7.Controls.Add(this.stylingWorkarea8);
            this.stylingWorkarea7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea7.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingWorkarea7.HasBorder = true;
            this.stylingWorkarea7.Image = null;
            this.stylingWorkarea7.IsImageTransparent = false;
            this.stylingWorkarea7.Location = new System.Drawing.Point(3, 3);
            this.stylingWorkarea7.Name = "stylingWorkarea7";
            this.stylingWorkarea7.Size = new System.Drawing.Size(119, 374);
            this.stylingWorkarea7.TabIndex = 3;
            this.stylingWorkarea7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // explorer
            // 
            this.explorer.Checkboxes = false;
            this.explorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorer.Location = new System.Drawing.Point(0, 27);
            this.explorer.Name = "explorer";
            this.explorer.Size = new System.Drawing.Size(119, 302);
            this.explorer.TabIndex = 7;
            this.toolTip1.SetToolTip(this.explorer, "Expand & Select a Site object to refresh the List pane");
            this.explorer.Url = null;
            this.explorer.OnSelect += new SquadronAddIns.Default.Components.SharePointExplorer.SelectionEventHandler(this.explorer_OnSelect);
            // 
            // stylingPanel4
            // 
            this.stylingPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.stylingPanel4.Caption = "Step 1";
            this.stylingPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.stylingPanel4.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.stylingPanel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.stylingPanel4.ForeColor = System.Drawing.Color.White;
            this.stylingPanel4.HasBorder = true;
            this.stylingPanel4.Image = null;
            this.stylingPanel4.IsImageTransparent = false;
            this.stylingPanel4.Location = new System.Drawing.Point(0, 0);
            this.stylingPanel4.Name = "stylingPanel4";
            this.stylingPanel4.Size = new System.Drawing.Size(119, 27);
            this.stylingPanel4.TabIndex = 6;
            this.stylingPanel4.Text = "Step 1";
            this.stylingPanel4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stylingWorkarea8
            // 
            this.stylingWorkarea8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea8.Caption = null;
            this.stylingWorkarea8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stylingWorkarea8.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingWorkarea8.HasBorder = true;
            this.stylingWorkarea8.Image = null;
            this.stylingWorkarea8.IsImageTransparent = false;
            this.stylingWorkarea8.Location = new System.Drawing.Point(0, 329);
            this.stylingWorkarea8.Name = "stylingWorkarea8";
            this.stylingWorkarea8.Size = new System.Drawing.Size(119, 45);
            this.stylingWorkarea8.TabIndex = 0;
            this.stylingWorkarea8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // VersionCleanerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VersionCleanerControl";
            this.Size = new System.Drawing.Size(625, 380);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.stylingWorkarea3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.stylingWorkarea4.ResumeLayout(false);
            this.stylingWorkarea1.ResumeLayout(false);
            this.stylingWorkarea2.ResumeLayout(false);
            this.stylingWorkarea2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountText)).EndInit();
            this.stylingWorkarea7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea7;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea8;
        private Windows8LookNFeel.Windows8Panel stylingPanel4;
        private Components.SharePointExplorer explorer;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea3;
        private Windows8LookNFeel.Windows8Panel stylingPanel2;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea4;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea1;
        private Windows8LookNFeel.Windows8Panel stylingPanel1;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea2;
        private System.Windows.Forms.CheckedListBox list;
        private Windows8LookNFeel.Windows8GridView grid;
        private Windows8LookNFeel.Windows8Button FindButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionsColumn;
        private Windows8LookNFeel.Windows8Button DeleteButton;
        private Windows8LookNFeel.Windows8Button MoveToRecycleBinButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CountText;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
