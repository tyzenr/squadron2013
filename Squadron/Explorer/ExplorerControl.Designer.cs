namespace SquadronAddIns.Default.Explorer
{
    partial class ExplorerControl
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
            this.grid = new System.Windows.Forms.PropertyGrid();
            this.explorer = new SquadronAddIns.Default.Components.SharePointExplorer();
            this.CommandPanel = new Windows8LookNFeel.Windows8Panel();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.CommandPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.grid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.explorer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CommandPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(893, 348);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(672, 3);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(218, 307);
            this.grid.TabIndex = 26;
            // 
            // explorer
            // 
            this.explorer.Checkboxes = false;
            this.explorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorer.Location = new System.Drawing.Point(3, 3);
            this.explorer.Name = "explorer";
            this.explorer.Size = new System.Drawing.Size(663, 307);
            this.explorer.TabIndex = 0;
            this.explorer.Url = null;
            this.explorer.OnSelect += new SquadronAddIns.Default.Components.SharePointExplorer.SelectionEventHandler(this.browser_OnSelect);
            // 
            // CommandPanel
            // 
            this.CommandPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CommandPanel.Controls.Add(this.flowPanel);
            this.CommandPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommandPanel.Location = new System.Drawing.Point(3, 316);
            this.CommandPanel.Name = "CommandPanel";
            this.CommandPanel.Size = new System.Drawing.Size(663, 29);
            this.CommandPanel.TabIndex = 27;
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(663, 29);
            this.flowPanel.TabIndex = 0;
            // 
            // ExplorerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ExplorerControl";
            this.Size = new System.Drawing.Size(893, 348);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.CommandPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PropertyGrid grid;
        private Components.SharePointExplorer explorer;
        private Windows8LookNFeel.Windows8Panel CommandPanel;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.ToolTip tooltip;
    }
}
