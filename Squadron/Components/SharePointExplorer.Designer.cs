namespace SquadronAddIns.Default.Components
{
    partial class SharePointExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharePointExplorer));
            this.tv = new System.Windows.Forms.TreeView();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.expandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.siteCollectionLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.HideSites = new System.Windows.Forms.ToolStripMenuItem();
            this.HideLists = new System.Windows.Forms.ToolStripMenuItem();
            this.HideItems = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkAll = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.line1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.includeSize = new System.Windows.Forms.ToolStripMenuItem();
            this.includeModifiedDate = new System.Windows.Forms.ToolStripMenuItem();
            this.excludeHiddenLists = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tv.ContextMenuStrip = this.menu;
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv.ImageIndex = 0;
            this.tv.ImageList = this.Images;
            this.tv.Location = new System.Drawing.Point(0, 0);
            this.tv.Name = "tv";
            this.tv.SelectedImageIndex = 0;
            this.tv.Size = new System.Drawing.Size(376, 329);
            this.tv.TabIndex = 0;
            this.tv.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterCheck);
            this.tv.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tv_BeforeExpand);
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
            this.tv.Click += new System.EventHandler(this.tv_Click);
            this.tv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tv_MouseDown);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshMenu,
            this.toolStripSeparator3,
            this.expandAll,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.checkAll,
            this.uncheckAll,
            this.line1,
            this.toolStripMenuItem3,
            this.excludeHiddenLists,
            this.propertiesMenuItem,
            this.toolStripSeparator4,
            this.SaveMenu});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(172, 248);
            // 
            // RefreshMenu
            // 
            this.RefreshMenu.Name = "RefreshMenu";
            this.RefreshMenu.Size = new System.Drawing.Size(171, 22);
            this.RefreshMenu.Text = "Refresh";
            this.RefreshMenu.Click += new System.EventHandler(this.RefreshMenu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // expandAll
            // 
            this.expandAll.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.siteCollectionLevelToolStripMenuItem,
            this.siteLevelToolStripMenuItem,
            this.listLevel,
            this.itemLevelToolStripMenuItem});
            this.expandAll.Name = "expandAll";
            this.expandAll.Size = new System.Drawing.Size(171, 22);
            this.expandAll.Text = "Expand";
            this.expandAll.ToolTipText = "Expands the current selected node recursively";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem1.Text = "All";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.expandAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // siteCollectionLevelToolStripMenuItem
            // 
            this.siteCollectionLevelToolStripMenuItem.Name = "siteCollectionLevelToolStripMenuItem";
            this.siteCollectionLevelToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.siteCollectionLevelToolStripMenuItem.Text = "Upto Site Collection";
            this.siteCollectionLevelToolStripMenuItem.Click += new System.EventHandler(this.siteCollectionLevelToolStripMenuItem_Click);
            // 
            // siteLevelToolStripMenuItem
            // 
            this.siteLevelToolStripMenuItem.Name = "siteLevelToolStripMenuItem";
            this.siteLevelToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.siteLevelToolStripMenuItem.Text = "Upto Site";
            this.siteLevelToolStripMenuItem.Click += new System.EventHandler(this.siteLevelToolStripMenuItem_Click);
            // 
            // listLevel
            // 
            this.listLevel.Name = "listLevel";
            this.listLevel.Size = new System.Drawing.Size(167, 22);
            this.listLevel.Text = "Upto List";
            this.listLevel.Click += new System.EventHandler(this.listLevel_Click);
            // 
            // itemLevelToolStripMenuItem
            // 
            this.itemLevelToolStripMenuItem.Name = "itemLevelToolStripMenuItem";
            this.itemLevelToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.itemLevelToolStripMenuItem.Text = "Upto Item";
            this.itemLevelToolStripMenuItem.Click += new System.EventHandler(this.itemLevelToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HideSites,
            this.HideLists,
            this.HideItems});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem2.Text = "Hide";
            // 
            // HideSites
            // 
            this.HideSites.Name = "HideSites";
            this.HideSites.Size = new System.Drawing.Size(152, 22);
            this.HideSites.Text = "Sites";
            this.HideSites.Click += new System.EventHandler(this.HideSites_Click);
            // 
            // HideLists
            // 
            this.HideLists.Name = "HideLists";
            this.HideLists.Size = new System.Drawing.Size(152, 22);
            this.HideLists.Text = "Lists";
            this.HideLists.Click += new System.EventHandler(this.HideLists_Click);
            // 
            // HideItems
            // 
            this.HideItems.Name = "HideItems";
            this.HideItems.Size = new System.Drawing.Size(152, 22);
            this.HideItems.Text = "Items";
            this.HideItems.Click += new System.EventHandler(this.HideItems_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // checkAll
            // 
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(171, 22);
            this.checkAll.Text = "Check All";
            this.checkAll.ToolTipText = "Check all the child nodes of selected node";
            this.checkAll.Click += new System.EventHandler(this.checkAll_Click);
            // 
            // uncheckAll
            // 
            this.uncheckAll.Name = "uncheckAll";
            this.uncheckAll.Size = new System.Drawing.Size(171, 22);
            this.uncheckAll.Text = "Uncheck All";
            this.uncheckAll.ToolTipText = "Unchek all the child nodes of selected node";
            this.uncheckAll.Click += new System.EventHandler(this.uncheckAll_Click);
            // 
            // line1
            // 
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(168, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.includeSize,
            this.includeModifiedDate});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItem3.Text = "Include";
            // 
            // includeSize
            // 
            this.includeSize.CheckOnClick = true;
            this.includeSize.Name = "includeSize";
            this.includeSize.Size = new System.Drawing.Size(140, 22);
            this.includeSize.Text = "Size";
            this.includeSize.Click += new System.EventHandler(this.includeSize_Click);
            // 
            // includeModifiedDate
            // 
            this.includeModifiedDate.CheckOnClick = true;
            this.includeModifiedDate.Name = "includeModifiedDate";
            this.includeModifiedDate.Size = new System.Drawing.Size(140, 22);
            this.includeModifiedDate.Text = "Modified Date";
            this.includeModifiedDate.Click += new System.EventHandler(this.modifiedDateToolStripMenuItem_Click);
            // 
            // excludeHiddenLists
            // 
            this.excludeHiddenLists.Checked = true;
            this.excludeHiddenLists.CheckOnClick = true;
            this.excludeHiddenLists.CheckState = System.Windows.Forms.CheckState.Checked;
            this.excludeHiddenLists.Name = "excludeHiddenLists";
            this.excludeHiddenLists.Size = new System.Drawing.Size(171, 22);
            this.excludeHiddenLists.Text = "Exclude Hidden Lists";
            this.excludeHiddenLists.CheckedChanged += new System.EventHandler(this.excludeHiddenLists_CheckedChanged);
            // 
            // propertiesMenuItem
            // 
            this.propertiesMenuItem.Name = "propertiesMenuItem";
            this.propertiesMenuItem.Size = new System.Drawing.Size(171, 22);
            this.propertiesMenuItem.Text = "Properties";
            this.propertiesMenuItem.Click += new System.EventHandler(this.propertiesMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(168, 6);
            // 
            // SaveMenu
            // 
            this.SaveMenu.Name = "SaveMenu";
            this.SaveMenu.Size = new System.Drawing.Size(171, 22);
            this.SaveMenu.Text = "Save as Picture";
            this.SaveMenu.Visible = false;
            this.SaveMenu.Click += new System.EventHandler(this.SaveMenu_Click);
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "IIS.png");
            this.Images.Images.SetKeyName(1, "Site Collection.png");
            this.Images.Images.SetKeyName(2, "Site.png");
            this.Images.Images.SetKeyName(3, "List icon.png");
            this.Images.Images.SetKeyName(4, "Document Library.png");
            this.Images.Images.SetKeyName(5, "List.png");
            this.Images.Images.SetKeyName(6, "Refresh.png");
            this.Images.Images.SetKeyName(7, "Folder.png");
            // 
            // SharePointExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tv);
            this.Name = "SharePointExplorer";
            this.Size = new System.Drawing.Size(376, 329);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem propertiesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAll;
        private System.Windows.Forms.ToolStripMenuItem uncheckAll;
        private System.Windows.Forms.ToolStripSeparator line1;
        private System.Windows.Forms.ToolStripMenuItem excludeHiddenLists;
        private System.Windows.Forms.ToolStripMenuItem expandAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem siteCollectionLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siteLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listLevel;
        private System.Windows.Forms.ToolStripMenuItem itemLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem RefreshMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem HideSites;
        private System.Windows.Forms.ToolStripMenuItem HideLists;
        private System.Windows.Forms.ToolStripMenuItem HideItems;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem SaveMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem includeSize;
        private System.Windows.Forms.ToolStripMenuItem includeModifiedDate;
    }
}
