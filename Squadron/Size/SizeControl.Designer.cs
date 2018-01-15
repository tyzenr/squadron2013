using Windows8LookNFeel;
namespace SquadronAddIns.Default.SizeInfo
{
    partial class SizeControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HighlightCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.FilterText = new System.Windows.Forms.TextBox();
            this.FilterCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.SiteCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.SiteCollectionCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.SizeList = new System.Windows.Forms.ComboBox();
            this.stylingHeaderPanel3 = new Windows8LookNFeel.Windows8Panel();
            this.stylingHeaderPanel1 = new Windows8LookNFeel.Windows8Panel();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ExecuteButton = new Windows8LookNFeel.Windows8Button();
            this.ListCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.IndentCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.stylingWorkarea1 = new Windows8LookNFeel.Windows8Panel();
            this.InfoPanel = new Windows8LookNFeel.Windows8Panel();
            this.stylingHeaderPanel2 = new Windows8LookNFeel.Windows8Panel();
            this.chart = new System.Drawing.PieChart.PieChartControl();
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.DbSizeButton = new Windows8LookNFeel.Windows8Button();
            this.panel1.SuspendLayout();
            this.stylingWorkarea1.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DbSizeButton);
            this.panel1.Controls.Add(this.HighlightCheck);
            this.panel1.Controls.Add(this.FilterText);
            this.panel1.Controls.Add(this.FilterCheck);
            this.panel1.Controls.Add(this.SiteCheck);
            this.panel1.Controls.Add(this.SiteCollectionCheck);
            this.panel1.Controls.Add(this.SizeList);
            this.panel1.Controls.Add(this.stylingHeaderPanel3);
            this.panel1.Controls.Add(this.stylingHeaderPanel1);
            this.panel1.Controls.Add(this.TotalLabel);
            this.panel1.Controls.Add(this.ExecuteButton);
            this.panel1.Controls.Add(this.ListCheck);
            this.panel1.Controls.Add(this.IndentCheck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 52);
            this.panel1.TabIndex = 15;
            // 
            // HighlightCheck
            // 
            this.HighlightCheck.BackColor = System.Drawing.Color.Transparent;
            this.HighlightCheck.Checked = true;
            this.HighlightCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HighlightCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighlightCheck.ForeColor = System.Drawing.Color.Black;
            this.HighlightCheck.Location = new System.Drawing.Point(671, 4);
            this.HighlightCheck.Name = "HighlightCheck";
            this.HighlightCheck.Size = new System.Drawing.Size(78, 18);
            this.HighlightCheck.TabIndex = 22;
            this.HighlightCheck.Text = "Highlight";
            this.toolTip1.SetToolTip(this.HighlightCheck, "Highlight in Red If Site Collection Size > 100 GB, Modified Date > 365 Days");
            this.HighlightCheck.UseVisualStyleBackColor = false;
            this.HighlightCheck.CheckedChanged += new System.EventHandler(this.HighlightCheck_CheckedChanged);
            // 
            // FilterText
            // 
            this.FilterText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FilterText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterText.Location = new System.Drawing.Point(318, 24);
            this.FilterText.Name = "FilterText";
            this.FilterText.Size = new System.Drawing.Size(195, 25);
            this.FilterText.TabIndex = 21;
            this.FilterText.Visible = false;
            // 
            // FilterCheck
            // 
            this.FilterCheck.BackColor = System.Drawing.Color.Transparent;
            this.FilterCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterCheck.ForeColor = System.Drawing.Color.Black;
            this.FilterCheck.Location = new System.Drawing.Point(318, 4);
            this.FilterCheck.Name = "FilterCheck";
            this.FilterCheck.Size = new System.Drawing.Size(100, 18);
            this.FilterCheck.TabIndex = 20;
            this.FilterCheck.Text = "Filter by URL";
            this.FilterCheck.UseVisualStyleBackColor = false;
            this.FilterCheck.CheckedChanged += new System.EventHandler(this.FilterCheck_CheckedChanged);
            // 
            // SiteCheck
            // 
            this.SiteCheck.BackColor = System.Drawing.Color.Transparent;
            this.SiteCheck.Checked = true;
            this.SiteCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SiteCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteCheck.ForeColor = System.Drawing.Color.Black;
            this.SiteCheck.Location = new System.Drawing.Point(144, 17);
            this.SiteCheck.Name = "SiteCheck";
            this.SiteCheck.Size = new System.Drawing.Size(61, 18);
            this.SiteCheck.TabIndex = 19;
            this.SiteCheck.Text = "Site";
            this.SiteCheck.UseVisualStyleBackColor = false;
            // 
            // SiteCollectionCheck
            // 
            this.SiteCollectionCheck.BackColor = System.Drawing.Color.Transparent;
            this.SiteCollectionCheck.Checked = true;
            this.SiteCollectionCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SiteCollectionCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteCollectionCheck.ForeColor = System.Drawing.Color.Black;
            this.SiteCollectionCheck.Location = new System.Drawing.Point(144, 1);
            this.SiteCollectionCheck.Name = "SiteCollectionCheck";
            this.SiteCollectionCheck.Size = new System.Drawing.Size(104, 18);
            this.SiteCollectionCheck.TabIndex = 19;
            this.SiteCollectionCheck.Text = "Site Collection";
            this.toolTip1.SetToolTip(this.SiteCollectionCheck, "Indents the Title of item based on Hierarchy");
            this.SiteCollectionCheck.UseVisualStyleBackColor = false;
            // 
            // SizeList
            // 
            this.SizeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizeList.FormattingEnabled = true;
            this.SizeList.Items.AddRange(new object[] {
            "MB",
            "GB"});
            this.SizeList.Location = new System.Drawing.Point(663, 23);
            this.SizeList.Name = "SizeList";
            this.SizeList.Size = new System.Drawing.Size(68, 21);
            this.SizeList.TabIndex = 14;
            // 
            // stylingHeaderPanel3
            // 
            this.stylingHeaderPanel3.BackColor = System.Drawing.Color.MediumPurple;
            this.stylingHeaderPanel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stylingHeaderPanel3.Image = null;
            this.stylingHeaderPanel3.Location = new System.Drawing.Point(256, 1);
            this.stylingHeaderPanel3.Name = "stylingHeaderPanel3";
            this.stylingHeaderPanel3.Size = new System.Drawing.Size(58, 50);
            this.stylingHeaderPanel3.TabIndex = 17;
            this.stylingHeaderPanel3.Text = "Filtering";
            this.stylingHeaderPanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stylingHeaderPanel1
            // 
            this.stylingHeaderPanel1.BackColor = System.Drawing.Color.MediumPurple;
            this.stylingHeaderPanel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stylingHeaderPanel1.Image = null;
            this.stylingHeaderPanel1.Location = new System.Drawing.Point(524, 1);
            this.stylingHeaderPanel1.Name = "stylingHeaderPanel1";
            this.stylingHeaderPanel1.Size = new System.Drawing.Size(76, 50);
            this.stylingHeaderPanel1.TabIndex = 17;
            this.stylingHeaderPanel1.Text = "Formatting";
            this.stylingHeaderPanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(605, 26);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(45, 15);
            this.TotalLabel.TabIndex = 16;
            this.TotalLabel.Text = "Size in:";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.ExecuteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExecuteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.ForeColor = System.Drawing.Color.White;
            this.ExecuteButton.Image = null;
            this.ExecuteButton.Location = new System.Drawing.Point(1, 1);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(139, 49);
            this.ExecuteButton.TabIndex = 13;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ListCheck
            // 
            this.ListCheck.BackColor = System.Drawing.Color.Transparent;
            this.ListCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCheck.ForeColor = System.Drawing.Color.Black;
            this.ListCheck.Location = new System.Drawing.Point(144, 33);
            this.ListCheck.Name = "ListCheck";
            this.ListCheck.Size = new System.Drawing.Size(100, 18);
            this.ListCheck.TabIndex = 19;
            this.ListCheck.Text = "List && Library";
            this.ListCheck.UseVisualStyleBackColor = false;
            // 
            // IndentCheck
            // 
            this.IndentCheck.BackColor = System.Drawing.Color.Transparent;
            this.IndentCheck.Checked = true;
            this.IndentCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IndentCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndentCheck.ForeColor = System.Drawing.Color.Black;
            this.IndentCheck.Location = new System.Drawing.Point(607, 4);
            this.IndentCheck.Name = "IndentCheck";
            this.IndentCheck.Size = new System.Drawing.Size(63, 18);
            this.IndentCheck.TabIndex = 18;
            this.IndentCheck.Text = "Indent";
            this.toolTip1.SetToolTip(this.IndentCheck, "Indents the Title of item based on Hierarchy");
            this.IndentCheck.UseVisualStyleBackColor = false;
            this.IndentCheck.CheckedChanged += new System.EventHandler(this.IndentCheck_CheckedChanged);
            // 
            // stylingWorkarea1
            // 
            this.stylingWorkarea1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea1.Controls.Add(this.InfoPanel);
            this.stylingWorkarea1.Dock = System.Windows.Forms.DockStyle.Right;
            this.stylingWorkarea1.Location = new System.Drawing.Point(586, 52);
            this.stylingWorkarea1.Name = "stylingWorkarea1";
            this.stylingWorkarea1.Size = new System.Drawing.Size(258, 264);
            this.stylingWorkarea1.TabIndex = 16;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InfoPanel.Controls.Add(this.stylingHeaderPanel2);
            this.InfoPanel.Controls.Add(this.chart);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(258, 264);
            this.InfoPanel.TabIndex = 17;
            this.InfoPanel.Visible = false;
            // 
            // stylingHeaderPanel2
            // 
            this.stylingHeaderPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.stylingHeaderPanel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stylingHeaderPanel2.Image = null;
            this.stylingHeaderPanel2.Location = new System.Drawing.Point(6, 6);
            this.stylingHeaderPanel2.Name = "stylingHeaderPanel2";
            this.stylingHeaderPanel2.Size = new System.Drawing.Size(246, 24);
            this.stylingHeaderPanel2.TabIndex = 1;
            this.stylingHeaderPanel2.Text = "Subsites Pie Chart";
            this.stylingHeaderPanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chart
            // 
            this.chart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart.ForeColor = System.Drawing.Color.Gray;
            this.chart.Location = new System.Drawing.Point(5, 35);
            this.chart.Margin = new System.Windows.Forms.Padding(10);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(248, 198);
            this.chart.TabIndex = 0;
            this.chart.ToolTips = null;
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Font = new System.Drawing.Font("Calibri", 10F);
            this.grid.Location = new System.Drawing.Point(0, 52);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 40;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(586, 264);
            this.grid.TabIndex = 21;
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // DbSizeButton
            // 
            this.DbSizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DbSizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.DbSizeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DbSizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DbSizeButton.ForeColor = System.Drawing.Color.White;
            this.DbSizeButton.Image = null;
            this.DbSizeButton.Location = new System.Drawing.Point(755, 2);
            this.DbSizeButton.Name = "DbSizeButton";
            this.DbSizeButton.Size = new System.Drawing.Size(84, 48);
            this.DbSizeButton.TabIndex = 23;
            this.DbSizeButton.Text = "Database Size";
            this.DbSizeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.DbSizeButton, "Content Database Size Information");
            this.DbSizeButton.Click += new System.EventHandler(this.DbSizeButton_Click);
            // 
            // SizeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.stylingWorkarea1);
            this.Controls.Add(this.panel1);
            this.Name = "SizeControl";
            this.Size = new System.Drawing.Size(844, 316);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.stylingWorkarea1.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Windows8LookNFeel.Windows8Button ExecuteButton;
        private System.Windows.Forms.ComboBox SizeList;
        private System.Windows.Forms.Label TotalLabel;
        private Windows8LookNFeel.Windows8Panel stylingHeaderPanel1;
        private System.Windows.Forms.ToolTip toolTip1;
        public Windows8LookNFeel.Windows8CheckBox IndentCheck;
        public Windows8LookNFeel.Windows8CheckBox SiteCheck;
        public Windows8LookNFeel.Windows8CheckBox ListCheck;
        public Windows8LookNFeel.Windows8CheckBox SiteCollectionCheck;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea1;
        private Windows8LookNFeel.Windows8GridView grid;
        private Windows8LookNFeel.Windows8Panel InfoPanel;
        private System.Drawing.PieChart.PieChartControl chart;
        private Windows8LookNFeel.Windows8Panel stylingHeaderPanel2;
        private Windows8LookNFeel.Windows8Panel stylingHeaderPanel3;
        public Windows8LookNFeel.Windows8CheckBox FilterCheck;
        public System.Windows.Forms.TextBox FilterText;
        public Windows8LookNFeel.Windows8CheckBox HighlightCheck;
        private Windows8LookNFeel.Windows8Button DbSizeButton;
    }
}
