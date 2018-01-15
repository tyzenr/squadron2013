namespace SquadronAddIns.Default.Permission
{
    partial class PermissionsControl
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.IncludeInheritUrlChecked = new Windows8LookNFeel.Windows8CheckBox();
            this.FindButton = new Windows8LookNFeel.Windows8Button();
            this.RestorButton = new Windows8LookNFeel.Windows8Button();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inputURLsFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupButton = new Windows8LookNFeel.Windows8Button();
            this.CopyButton = new Windows8LookNFeel.Windows8Button();
            this.ResetButton = new Windows8LookNFeel.Windows8Button();
            this.DeleteButton = new Windows8LookNFeel.Windows8Button();
            this.HighlightUniqueCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.FilterText = new System.Windows.Forms.TextBox();
            this.ExpandInheritedCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.FilterCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.ShowUserName = new Windows8LookNFeel.Windows8CheckBox();
            this.ItemCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.ListCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.SiteCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.IncludeHiddenCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.UniquePermissionsCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.ShowUsersInGroup = new Windows8LookNFeel.Windows8CheckBox();
            this.ExecuteButton = new Windows8LookNFeel.Windows8Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.split = new System.Windows.Forms.SplitContainer();
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.TopPanel.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.IncludeInheritUrlChecked);
            this.TopPanel.Controls.Add(this.FindButton);
            this.TopPanel.Controls.Add(this.RestorButton);
            this.TopPanel.Controls.Add(this.BackupButton);
            this.TopPanel.Controls.Add(this.CopyButton);
            this.TopPanel.Controls.Add(this.ResetButton);
            this.TopPanel.Controls.Add(this.DeleteButton);
            this.TopPanel.Controls.Add(this.HighlightUniqueCheck);
            this.TopPanel.Controls.Add(this.FilterText);
            this.TopPanel.Controls.Add(this.ExpandInheritedCheck);
            this.TopPanel.Controls.Add(this.FilterCheck);
            this.TopPanel.Controls.Add(this.ShowUserName);
            this.TopPanel.Controls.Add(this.ItemCheck);
            this.TopPanel.Controls.Add(this.ListCheck);
            this.TopPanel.Controls.Add(this.SiteCheck);
            this.TopPanel.Controls.Add(this.IncludeHiddenCheck);
            this.TopPanel.Controls.Add(this.UniquePermissionsCheck);
            this.TopPanel.Controls.Add(this.ShowUsersInGroup);
            this.TopPanel.Controls.Add(this.ExecuteButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1348, 76);
            this.TopPanel.TabIndex = 13;
            // 
            // IncludeInheritUrlChecked
            // 
            this.IncludeInheritUrlChecked.AutoSize = true;
            this.IncludeInheritUrlChecked.BackColor = System.Drawing.Color.Transparent;
            this.IncludeInheritUrlChecked.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.IncludeInheritUrlChecked.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncludeInheritUrlChecked.ForeColor = System.Drawing.Color.Gray;
            this.IncludeInheritUrlChecked.Location = new System.Drawing.Point(542, 29);
            this.IncludeInheritUrlChecked.Name = "IncludeInheritUrlChecked";
            this.IncludeInheritUrlChecked.Size = new System.Drawing.Size(126, 19);
            this.IncludeInheritUrlChecked.TabIndex = 20;
            this.IncludeInheritUrlChecked.Text = "Include Inherit URL";
            this.toolTip1.SetToolTip(this.IncludeInheritUrlChecked, "Include Inherited Parent URL");
            this.IncludeInheritUrlChecked.UseVisualStyleBackColor = false;
            // 
            // FindButton
            // 
            this.FindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.FindButton.Caption = "Find";
            this.FindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindButton.Description = null;
            this.FindButton.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.FindButton.Location = new System.Drawing.Point(1036, 2);
            this.FindButton.Name = "FindButton";
            this.FindButton.ShowDescriptionOnHover = true;
            this.FindButton.Size = new System.Drawing.Size(107, 71);
            this.FindButton.TabIndex = 19;
            this.FindButton.Text = "Find";
            this.FindButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.FindButton, "Find Permissions for Users, Groups");
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // RestorButton
            // 
            this.RestorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.RestorButton.Caption = "Restore";
            this.RestorButton.ContextMenuStrip = this.MenuStrip;
            this.RestorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestorButton.Description = null;
            this.RestorButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RestorButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.RestorButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestorButton.ForeColor = System.Drawing.Color.White;
            this.RestorButton.HasBorder = true;
            this.RestorButton.HasRightSideBorder = false;
            this.RestorButton.Image = null;
            this.RestorButton.Is2PaneDrawing = false;
            this.RestorButton.IsImageTransparent = false;
            this.RestorButton.IsMouseOn = false;
            this.RestorButton.IsRadio = false;
            this.RestorButton.Location = new System.Drawing.Point(1244, 37);
            this.RestorButton.Name = "RestorButton";
            this.RestorButton.ShowDescriptionOnHover = true;
            this.RestorButton.Size = new System.Drawing.Size(101, 36);
            this.RestorButton.TabIndex = 16;
            this.RestorButton.Text = "Restore";
            this.RestorButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.RestorButton, "Launch Restore Permissions wizard");
            this.RestorButton.Click += new System.EventHandler(this.RestorButton_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputURLsFromFileToolStripMenuItem});
            this.MenuStrip.Name = "contextMenuStrip1";
            this.MenuStrip.Size = new System.Drawing.Size(151, 26);
            // 
            // inputURLsFromFileToolStripMenuItem
            // 
            this.inputURLsFromFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromTextFileToolStripMenuItem,
            this.fromClipboardToolStripMenuItem});
            this.inputURLsFromFileToolStripMenuItem.Name = "inputURLsFromFileToolStripMenuItem";
            this.inputURLsFromFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.inputURLsFromFileToolStripMenuItem.Text = "Load List URLs";
            // 
            // fromTextFileToolStripMenuItem
            // 
            this.fromTextFileToolStripMenuItem.Name = "fromTextFileToolStripMenuItem";
            this.fromTextFileToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.fromTextFileToolStripMenuItem.Text = "From Text File";
            this.fromTextFileToolStripMenuItem.Click += new System.EventHandler(this.fromTextFileToolStripMenuItem_Click);
            // 
            // fromClipboardToolStripMenuItem
            // 
            this.fromClipboardToolStripMenuItem.Name = "fromClipboardToolStripMenuItem";
            this.fromClipboardToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.fromClipboardToolStripMenuItem.Text = "From Clipboard";
            this.fromClipboardToolStripMenuItem.Click += new System.EventHandler(this.fromClipboardToolStripMenuItem_Click);
            // 
            // BackupButton
            // 
            this.BackupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.BackupButton.Caption = "Backup";
            this.BackupButton.ContextMenuStrip = this.MenuStrip;
            this.BackupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackupButton.Description = null;
            this.BackupButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BackupButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.BackupButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupButton.ForeColor = System.Drawing.Color.White;
            this.BackupButton.HasBorder = true;
            this.BackupButton.HasRightSideBorder = false;
            this.BackupButton.Image = null;
            this.BackupButton.Is2PaneDrawing = false;
            this.BackupButton.IsImageTransparent = false;
            this.BackupButton.IsMouseOn = false;
            this.BackupButton.IsRadio = false;
            this.BackupButton.Location = new System.Drawing.Point(1244, 2);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.ShowDescriptionOnHover = true;
            this.BackupButton.Size = new System.Drawing.Size(101, 34);
            this.BackupButton.TabIndex = 17;
            this.BackupButton.Text = "Backup";
            this.BackupButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.BackupButton, "Launch Backup Permissions wizard");
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.CopyButton.Caption = "Copy";
            this.CopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyButton.Description = null;
            this.CopyButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CopyButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.CopyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.ForeColor = System.Drawing.Color.White;
            this.CopyButton.HasBorder = true;
            this.CopyButton.HasRightSideBorder = false;
            this.CopyButton.Image = null;
            this.CopyButton.Is2PaneDrawing = false;
            this.CopyButton.IsImageTransparent = false;
            this.CopyButton.IsMouseOn = false;
            this.CopyButton.IsRadio = false;
            this.CopyButton.Location = new System.Drawing.Point(1145, 2);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.ShowDescriptionOnHover = true;
            this.CopyButton.Size = new System.Drawing.Size(97, 23);
            this.CopyButton.TabIndex = 18;
            this.CopyButton.Text = "Copy";
            this.CopyButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.CopyButton, "Copy Permissions from one user to another");
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.ResetButton.Caption = "Reset";
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Description = null;
            this.ResetButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ResetButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.HasBorder = true;
            this.ResetButton.HasRightSideBorder = false;
            this.ResetButton.Image = null;
            this.ResetButton.Is2PaneDrawing = false;
            this.ResetButton.IsImageTransparent = false;
            this.ResetButton.IsMouseOn = false;
            this.ResetButton.IsRadio = false;
            this.ResetButton.Location = new System.Drawing.Point(1145, 50);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.ShowDescriptionOnHover = true;
            this.ResetButton.Size = new System.Drawing.Size(97, 23);
            this.ResetButton.TabIndex = 18;
            this.ResetButton.Text = "Reset";
            this.ResetButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.ResetButton, "Reset to Inherit Permissions");
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.DeleteButton.Caption = "Delete";
            this.DeleteButton.ContextMenuStrip = this.MenuStrip;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Description = null;
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.DeleteButton.Location = new System.Drawing.Point(1145, 26);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ShowDescriptionOnHover = true;
            this.DeleteButton.Size = new System.Drawing.Size(97, 23);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.DeleteButton, "Delete Permissions by SharePoing Group / User");
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // HighlightUniqueCheck
            // 
            this.HighlightUniqueCheck.AutoSize = true;
            this.HighlightUniqueCheck.BackColor = System.Drawing.Color.Transparent;
            this.HighlightUniqueCheck.Checked = true;
            this.HighlightUniqueCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HighlightUniqueCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.HighlightUniqueCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighlightUniqueCheck.ForeColor = System.Drawing.Color.Gray;
            this.HighlightUniqueCheck.Location = new System.Drawing.Point(542, 7);
            this.HighlightUniqueCheck.Name = "HighlightUniqueCheck";
            this.HighlightUniqueCheck.Size = new System.Drawing.Size(76, 19);
            this.HighlightUniqueCheck.TabIndex = 15;
            this.HighlightUniqueCheck.Text = "Highlight";
            this.toolTip1.SetToolTip(this.HighlightUniqueCheck, "Highlight Unique Permission Items");
            this.HighlightUniqueCheck.UseVisualStyleBackColor = false;
            // 
            // FilterText
            // 
            this.FilterText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FilterText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterText.Location = new System.Drawing.Point(466, 49);
            this.FilterText.Name = "FilterText";
            this.FilterText.Size = new System.Drawing.Size(242, 25);
            this.FilterText.TabIndex = 14;
            this.FilterText.Visible = false;
            // 
            // ExpandInheritedCheck
            // 
            this.ExpandInheritedCheck.BackColor = System.Drawing.Color.Transparent;
            this.ExpandInheritedCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.ExpandInheritedCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpandInheritedCheck.ForeColor = System.Drawing.Color.Gray;
            this.ExpandInheritedCheck.Location = new System.Drawing.Point(376, 30);
            this.ExpandInheritedCheck.Name = "ExpandInheritedCheck";
            this.ExpandInheritedCheck.Size = new System.Drawing.Size(160, 18);
            this.ExpandInheritedCheck.TabIndex = 10;
            this.ExpandInheritedCheck.Text = "Expand Inherited Groups";
            this.toolTip1.SetToolTip(this.ExpandInheritedCheck, "Expands the Inherited Permission Objects by showing the Groups & Users in it");
            this.ExpandInheritedCheck.UseVisualStyleBackColor = false;
            // 
            // FilterCheck
            // 
            this.FilterCheck.BackColor = System.Drawing.Color.Transparent;
            this.FilterCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.FilterCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterCheck.ForeColor = System.Drawing.Color.Gray;
            this.FilterCheck.Location = new System.Drawing.Point(376, 53);
            this.FilterCheck.Name = "FilterCheck";
            this.FilterCheck.Size = new System.Drawing.Size(84, 18);
            this.FilterCheck.TabIndex = 9;
            this.FilterCheck.Text = "Filter By Url";
            this.toolTip1.SetToolTip(this.FilterCheck, "Show only URLs starting with input URL");
            this.FilterCheck.UseVisualStyleBackColor = false;
            this.FilterCheck.CheckedChanged += new System.EventHandler(this.FilterCheck_CheckedChanged);
            // 
            // ShowUserName
            // 
            this.ShowUserName.AutoSize = true;
            this.ShowUserName.BackColor = System.Drawing.Color.Transparent;
            this.ShowUserName.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.ShowUserName.Enabled = false;
            this.ShowUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowUserName.ForeColor = System.Drawing.Color.Gray;
            this.ShowUserName.Location = new System.Drawing.Point(254, 30);
            this.ShowUserName.Name = "ShowUserName";
            this.ShowUserName.Size = new System.Drawing.Size(116, 19);
            this.ShowUserName.TabIndex = 3;
            this.ShowUserName.Text = "Show User Name";
            this.toolTip1.SetToolTip(this.ShowUserName, "Show User Name instead of Login Name");
            this.ShowUserName.UseVisualStyleBackColor = false;
            // 
            // ItemCheck
            // 
            this.ItemCheck.BackColor = System.Drawing.Color.Transparent;
            this.ItemCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.ItemCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCheck.ForeColor = System.Drawing.Color.Gray;
            this.ItemCheck.Location = new System.Drawing.Point(151, 53);
            this.ItemCheck.Name = "ItemCheck";
            this.ItemCheck.Size = new System.Drawing.Size(57, 18);
            this.ItemCheck.TabIndex = 6;
            this.ItemCheck.Text = "Item";
            this.ItemCheck.UseVisualStyleBackColor = false;
            // 
            // ListCheck
            // 
            this.ListCheck.BackColor = System.Drawing.Color.Transparent;
            this.ListCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.ListCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCheck.ForeColor = System.Drawing.Color.Gray;
            this.ListCheck.Location = new System.Drawing.Point(151, 30);
            this.ListCheck.Name = "ListCheck";
            this.ListCheck.Size = new System.Drawing.Size(100, 18);
            this.ListCheck.TabIndex = 5;
            this.ListCheck.Text = "List && Library";
            this.ListCheck.UseVisualStyleBackColor = false;
            // 
            // SiteCheck
            // 
            this.SiteCheck.BackColor = System.Drawing.Color.Transparent;
            this.SiteCheck.Checked = true;
            this.SiteCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SiteCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.SiteCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteCheck.ForeColor = System.Drawing.Color.Gray;
            this.SiteCheck.Location = new System.Drawing.Point(151, 7);
            this.SiteCheck.Name = "SiteCheck";
            this.SiteCheck.Size = new System.Drawing.Size(57, 18);
            this.SiteCheck.TabIndex = 4;
            this.SiteCheck.Text = "Site";
            this.SiteCheck.UseVisualStyleBackColor = false;
            // 
            // IncludeHiddenCheck
            // 
            this.IncludeHiddenCheck.BackColor = System.Drawing.Color.Transparent;
            this.IncludeHiddenCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.IncludeHiddenCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncludeHiddenCheck.ForeColor = System.Drawing.Color.Gray;
            this.IncludeHiddenCheck.Location = new System.Drawing.Point(254, 53);
            this.IncludeHiddenCheck.Name = "IncludeHiddenCheck";
            this.IncludeHiddenCheck.Size = new System.Drawing.Size(116, 18);
            this.IncludeHiddenCheck.TabIndex = 8;
            this.IncludeHiddenCheck.Text = "Include Hidden";
            this.toolTip1.SetToolTip(this.IncludeHiddenCheck, "Include Hidden Lists & Libraries");
            this.IncludeHiddenCheck.UseVisualStyleBackColor = false;
            // 
            // UniquePermissionsCheck
            // 
            this.UniquePermissionsCheck.BackColor = System.Drawing.Color.Transparent;
            this.UniquePermissionsCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.UniquePermissionsCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniquePermissionsCheck.ForeColor = System.Drawing.Color.Gray;
            this.UniquePermissionsCheck.Location = new System.Drawing.Point(376, 7);
            this.UniquePermissionsCheck.Name = "UniquePermissionsCheck";
            this.UniquePermissionsCheck.Size = new System.Drawing.Size(160, 18);
            this.UniquePermissionsCheck.TabIndex = 7;
            this.UniquePermissionsCheck.Text = "Unique Permissions Only";
            this.UniquePermissionsCheck.UseVisualStyleBackColor = false;
            // 
            // ShowUsersInGroup
            // 
            this.ShowUsersInGroup.BackColor = System.Drawing.Color.Transparent;
            this.ShowUsersInGroup.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.ShowUsersInGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowUsersInGroup.ForeColor = System.Drawing.Color.Gray;
            this.ShowUsersInGroup.Location = new System.Drawing.Point(254, 7);
            this.ShowUsersInGroup.Name = "ShowUsersInGroup";
            this.ShowUsersInGroup.Size = new System.Drawing.Size(116, 18);
            this.ShowUsersInGroup.TabIndex = 2;
            this.ShowUsersInGroup.Text = "Expand Groups";
            this.toolTip1.SetToolTip(this.ShowUsersInGroup, "Incude User Names in Group");
            this.ShowUsersInGroup.UseVisualStyleBackColor = false;
            this.ShowUsersInGroup.CheckedChanged += new System.EventHandler(this.ShowUsersInGroup_CheckedChanged);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.ExecuteButton.Caption = "Execute";
            this.ExecuteButton.ContextMenuStrip = this.MenuStrip;
            this.ExecuteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExecuteButton.Description = null;
            this.ExecuteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExecuteButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.ExecuteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.ForeColor = System.Drawing.Color.White;
            this.ExecuteButton.HasBorder = true;
            this.ExecuteButton.HasRightSideBorder = false;
            this.ExecuteButton.Image = null;
            this.ExecuteButton.Is2PaneDrawing = false;
            this.ExecuteButton.IsImageTransparent = false;
            this.ExecuteButton.IsMouseOn = false;
            this.ExecuteButton.IsRadio = false;
            this.ExecuteButton.Location = new System.Drawing.Point(3, 2);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.ShowDescriptionOnHover = true;
            this.ExecuteButton.Size = new System.Drawing.Size(142, 70);
            this.ExecuteButton.TabIndex = 0;
            this.ExecuteButton.Text = "View Permissions";
            this.ExecuteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // OpenDialog
            // 
            this.OpenDialog.FileName = "openFileDialog1";
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(0, 76);
            this.split.Name = "split";
            // 
            // split.Panel1
            // 
            this.split.Panel1.Controls.Add(this.grid);
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.propertyGrid);
            this.split.Size = new System.Drawing.Size(1348, 272);
            this.split.SplitterDistance = 956;
            this.split.TabIndex = 15;
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.CustomBackColor1 = System.Drawing.Color.Empty;
            this.grid.CustomBackColor2 = System.Drawing.Color.Empty;
            this.grid.CustomForecolor = System.Drawing.Color.Empty;
            this.grid.CustomSelectedBackColor1 = System.Drawing.Color.Empty;
            this.grid.CustomSelectedBackColor2 = System.Drawing.Color.Empty;
            this.grid.CustomSelectedForecolor = System.Drawing.Color.Empty;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.grid.Font = new System.Drawing.Font("Verdana", 9F);
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.NoSelectedColor = false;
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 45;
            this.grid.Size = new System.Drawing.Size(956, 272);
            this.grid.TabIndex = 1;
            this.grid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grid_CellPainting);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(388, 272);
            this.propertyGrid.TabIndex = 25;
            // 
            // PermissionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.split);
            this.Controls.Add(this.TopPanel);
            this.Name = "PermissionsControl";
            this.Size = new System.Drawing.Size(1348, 348);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows8LookNFeel.Windows8Button ExecuteButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem inputURLsFromFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.ToolStripMenuItem fromTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromClipboardToolStripMenuItem;
        private Windows8LookNFeel.Windows8CheckBox ShowUserName;
        private Windows8LookNFeel.Windows8CheckBox ExpandInheritedCheck;
        public System.Windows.Forms.TextBox FilterText;
        private Windows8LookNFeel.Windows8CheckBox HighlightUniqueCheck;
        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private Windows8LookNFeel.Windows8Button BackupButton;
        private Windows8LookNFeel.Windows8Button RestorButton;
        public Windows8LookNFeel.Windows8CheckBox ItemCheck;
        public Windows8LookNFeel.Windows8CheckBox ListCheck;
        public Windows8LookNFeel.Windows8CheckBox SiteCheck;
        public System.Windows.Forms.Panel TopPanel;
        public Windows8LookNFeel.Windows8CheckBox ShowUsersInGroup;
        private Windows8LookNFeel.Windows8Button CopyButton;
        private Windows8LookNFeel.Windows8Button DeleteButton;
        private Windows8LookNFeel.Windows8Button ResetButton;
        public Windows8LookNFeel.Windows8CheckBox FilterCheck;
        public Windows8LookNFeel.Windows8CheckBox IncludeHiddenCheck;
        private Windows8LookNFeel.Windows8Button FindButton;
        private Windows8LookNFeel.Windows8CheckBox IncludeInheritUrlChecked;
        public Windows8LookNFeel.Windows8CheckBox UniquePermissionsCheck;
        public Windows8LookNFeel.Windows8GridView grid;
    }
}
