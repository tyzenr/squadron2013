namespace SquadronAddIns.Default.SiteStructure
{
    partial class SiteStructureControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiteStructureControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.FilterText = new System.Windows.Forms.TextBox();
            this.FilterCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.ShowVersionCountCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.ShowItemsCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.ShowPropertyGridCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.ShowItemCountCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.ShowHiddenChecked = new Windows8LookNFeel.Windows8CheckBox();
            this.ShowListsChecked = new Windows8LookNFeel.Windows8CheckBox();
            this.ShowUrlsChecked = new Windows8LookNFeel.Windows8CheckBox();
            this.ShowFlatCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.GenerateButton = new Windows8LookNFeel.Windows8Button();
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tv = new System.Windows.Forms.TreeView();
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FilterText);
            this.panel1.Controls.Add(this.FilterCheck);
            this.panel1.Controls.Add(this.ShowVersionCountCheck);
            this.panel1.Controls.Add(this.ShowItemsCheck);
            this.panel1.Controls.Add(this.ShowPropertyGridCheck);
            this.panel1.Controls.Add(this.ShowItemCountCheck);
            this.panel1.Controls.Add(this.ShowHiddenChecked);
            this.panel1.Controls.Add(this.ShowListsChecked);
            this.panel1.Controls.Add(this.ShowUrlsChecked);
            this.panel1.Controls.Add(this.ShowFlatCheck);
            this.panel1.Controls.Add(this.GenerateButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 60);
            this.panel1.TabIndex = 13;
            // 
            // FilterText
            // 
            this.FilterText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FilterText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterText.Location = new System.Drawing.Point(554, 3);
            this.FilterText.Name = "FilterText";
            this.FilterText.Size = new System.Drawing.Size(241, 25);
            this.FilterText.TabIndex = 16;
            this.FilterText.Visible = false;
            // 
            // FilterCheck
            // 
            this.FilterCheck.BackColor = System.Drawing.Color.Transparent;
            this.FilterCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterCheck.Location = new System.Drawing.Point(468, 7);
            this.FilterCheck.Name = "FilterCheck";
            this.FilterCheck.Size = new System.Drawing.Size(91, 18);
            this.FilterCheck.TabIndex = 15;
            this.FilterCheck.Text = "Filter By Url";
            this.toolTip1.SetToolTip(this.FilterCheck, "Show only URLs starting with input URL");
            this.FilterCheck.UseVisualStyleBackColor = false;
            this.FilterCheck.CheckedChanged += new System.EventHandler(this.FilterCheck_CheckedChanged);
            // 
            // ShowVersionCountCheck
            // 
            this.ShowVersionCountCheck.AutoSize = true;
            this.ShowVersionCountCheck.BackColor = System.Drawing.Color.Transparent;
            this.ShowVersionCountCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowVersionCountCheck.Location = new System.Drawing.Point(457, 34);
            this.ShowVersionCountCheck.Name = "ShowVersionCountCheck";
            this.ShowVersionCountCheck.Size = new System.Drawing.Size(133, 19);
            this.ShowVersionCountCheck.TabIndex = 8;
            this.ShowVersionCountCheck.Text = "Show Version Count";
            this.toolTip1.SetToolTip(this.ShowVersionCountCheck, "Show Item Versions (applicable ony to Item rows)");
            this.ShowVersionCountCheck.UseVisualStyleBackColor = false;
            // 
            // ShowItemsCheck
            // 
            this.ShowItemsCheck.AutoSize = true;
            this.ShowItemsCheck.BackColor = System.Drawing.Color.Transparent;
            this.ShowItemsCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowItemsCheck.Location = new System.Drawing.Point(364, 34);
            this.ShowItemsCheck.Name = "ShowItemsCheck";
            this.ShowItemsCheck.Size = new System.Drawing.Size(87, 19);
            this.ShowItemsCheck.TabIndex = 7;
            this.ShowItemsCheck.Text = "Show Items";
            this.toolTip1.SetToolTip(this.ShowItemsCheck, "Show Items inside List / Library");
            this.ShowItemsCheck.UseVisualStyleBackColor = false;
            this.ShowItemsCheck.CheckedChanged += new System.EventHandler(this.ShowListsChecked_CheckedChanged);
            // 
            // ShowPropertyGridCheck
            // 
            this.ShowPropertyGridCheck.AutoSize = true;
            this.ShowPropertyGridCheck.BackColor = System.Drawing.Color.Transparent;
            this.ShowPropertyGridCheck.Checked = true;
            this.ShowPropertyGridCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowPropertyGridCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPropertyGridCheck.Location = new System.Drawing.Point(330, 7);
            this.ShowPropertyGridCheck.Name = "ShowPropertyGridCheck";
            this.ShowPropertyGridCheck.Size = new System.Drawing.Size(128, 19);
            this.ShowPropertyGridCheck.TabIndex = 6;
            this.ShowPropertyGridCheck.Text = "Show Property Grid";
            this.toolTip1.SetToolTip(this.ShowPropertyGridCheck, "Show the Property Grid for further examining each items");
            this.ShowPropertyGridCheck.UseVisualStyleBackColor = false;
            this.ShowPropertyGridCheck.CheckedChanged += new System.EventHandler(this.ShowPropertyGridCheck_CheckedChanged);
            // 
            // ShowItemCountCheck
            // 
            this.ShowItemCountCheck.AutoSize = true;
            this.ShowItemCountCheck.BackColor = System.Drawing.Color.Transparent;
            this.ShowItemCountCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowItemCountCheck.Location = new System.Drawing.Point(240, 34);
            this.ShowItemCountCheck.Name = "ShowItemCountCheck";
            this.ShowItemCountCheck.Size = new System.Drawing.Size(118, 19);
            this.ShowItemCountCheck.TabIndex = 4;
            this.ShowItemCountCheck.Text = "Show Item Count";
            this.toolTip1.SetToolTip(this.ShowItemCountCheck, "Show Item Count  (applicable only to List rows)");
            this.ShowItemCountCheck.UseVisualStyleBackColor = false;
            // 
            // ShowHiddenChecked
            // 
            this.ShowHiddenChecked.AutoSize = true;
            this.ShowHiddenChecked.BackColor = System.Drawing.Color.Transparent;
            this.ShowHiddenChecked.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowHiddenChecked.Location = new System.Drawing.Point(139, 34);
            this.ShowHiddenChecked.Name = "ShowHiddenChecked";
            this.ShowHiddenChecked.Size = new System.Drawing.Size(97, 19);
            this.ShowHiddenChecked.TabIndex = 3;
            this.ShowHiddenChecked.Text = "Show Hidden";
            this.toolTip1.SetToolTip(this.ShowHiddenChecked, "Show Hidden Lists & Libraries (include System lists as well)");
            this.ShowHiddenChecked.UseVisualStyleBackColor = false;
            // 
            // ShowListsChecked
            // 
            this.ShowListsChecked.AutoSize = true;
            this.ShowListsChecked.BackColor = System.Drawing.Color.Transparent;
            this.ShowListsChecked.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowListsChecked.Location = new System.Drawing.Point(5, 34);
            this.ShowListsChecked.Name = "ShowListsChecked";
            this.ShowListsChecked.Size = new System.Drawing.Size(131, 19);
            this.ShowListsChecked.TabIndex = 2;
            this.ShowListsChecked.Text = "Show Lists, Libraries";
            this.toolTip1.SetToolTip(this.ShowListsChecked, "Show Lists & Libraries");
            this.ShowListsChecked.UseVisualStyleBackColor = false;
            this.ShowListsChecked.CheckedChanged += new System.EventHandler(this.ShowListsChecked_CheckedChanged);
            // 
            // ShowUrlsChecked
            // 
            this.ShowUrlsChecked.AutoSize = true;
            this.ShowUrlsChecked.BackColor = System.Drawing.Color.Transparent;
            this.ShowUrlsChecked.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowUrlsChecked.Location = new System.Drawing.Point(152, 7);
            this.ShowUrlsChecked.Name = "ShowUrlsChecked";
            this.ShowUrlsChecked.Size = new System.Drawing.Size(78, 19);
            this.ShowUrlsChecked.TabIndex = 1;
            this.ShowUrlsChecked.Text = "Show Urls";
            this.ShowUrlsChecked.UseVisualStyleBackColor = false;
            // 
            // ShowFlatCheck
            // 
            this.ShowFlatCheck.AutoSize = true;
            this.ShowFlatCheck.BackColor = System.Drawing.Color.Transparent;
            this.ShowFlatCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowFlatCheck.Location = new System.Drawing.Point(240, 7);
            this.ShowFlatCheck.Name = "ShowFlatCheck";
            this.ShowFlatCheck.Size = new System.Drawing.Size(76, 19);
            this.ShowFlatCheck.TabIndex = 5;
            this.ShowFlatCheck.Text = "Grid Style";
            this.toolTip1.SetToolTip(this.ShowFlatCheck, "Show in grid so that exporting is possible");
            this.ShowFlatCheck.UseVisualStyleBackColor = false;
            this.ShowFlatCheck.CheckStateChanged += new System.EventHandler(this.ParentCheck_CheckStateChanged);
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.GenerateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GenerateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.ForeColor = System.Drawing.Color.White;
            this.GenerateButton.Image = null;
            this.GenerateButton.Location = new System.Drawing.Point(2, 2);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(144, 28);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Execute";
            this.GenerateButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
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
            // 
            // tv
            // 
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv.ImageIndex = 0;
            this.tv.ImageList = this.Images;
            this.tv.Location = new System.Drawing.Point(0, 0);
            this.tv.Name = "tv";
            this.tv.SelectedImageIndex = 0;
            this.tv.ShowNodeToolTips = true;
            this.tv.Size = new System.Drawing.Size(601, 350);
            this.tv.TabIndex = 25;
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(601, 350);
            this.grid.TabIndex = 26;
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 60);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grid);
            this.splitContainer2.Panel1.Controls.Add(this.tv);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.propertyGrid);
            this.splitContainer2.Size = new System.Drawing.Size(845, 350);
            this.splitContainer2.SplitterDistance = 601;
            this.splitContainer2.TabIndex = 14;
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(240, 350);
            this.propertyGrid.TabIndex = 25;
            // 
            // SiteStructureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.panel1);
            this.Name = "SiteStructureControl";
            this.Size = new System.Drawing.Size(845, 410);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Windows8LookNFeel.Windows8Button GenerateButton;
        private Windows8LookNFeel.Windows8CheckBox ShowFlatCheck;
        private System.Windows.Forms.ImageList Images;
        private Windows8LookNFeel.Windows8CheckBox ShowUrlsChecked;
        private Windows8LookNFeel.Windows8CheckBox ShowListsChecked;
        private Windows8LookNFeel.Windows8CheckBox ShowHiddenChecked;
        private Windows8LookNFeel.Windows8CheckBox ShowItemCountCheck;
        private System.Windows.Forms.ToolTip toolTip1;
        private Windows8LookNFeel.Windows8CheckBox ShowPropertyGridCheck;
        private Windows8LookNFeel.Windows8CheckBox ShowItemsCheck;
        private Windows8LookNFeel.Windows8CheckBox ShowVersionCountCheck;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        public System.Windows.Forms.TextBox FilterText;
        private Windows8LookNFeel.Windows8CheckBox FilterCheck;
    }
}
