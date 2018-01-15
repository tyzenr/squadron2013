using Windows8LookNFeel;
namespace SquadronAddIns.Default.PermissionGroupsAD
{
    partial class ActiveDirectoryControl
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
            this.ExecuteButton = new Windows8LookNFeel.Windows8Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.pgrid = new System.Windows.Forms.PropertyGrid();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HighlightCheck);
            this.panel1.Controls.Add(this.ExecuteButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 32);
            this.panel1.TabIndex = 15;
            // 
            // HighlightCheck
            // 
            this.HighlightCheck.AutoSize = true;
            this.HighlightCheck.BackColor = System.Drawing.Color.Transparent;
            this.HighlightCheck.Checked = true;
            this.HighlightCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HighlightCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.HighlightCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighlightCheck.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.HighlightCheck.Location = new System.Drawing.Point(154, 7);
            this.HighlightCheck.Name = "HighlightCheck";
            this.HighlightCheck.Size = new System.Drawing.Size(124, 19);
            this.HighlightCheck.TabIndex = 16;
            this.HighlightCheck.Text = "Highlight Disabled";
            this.toolTip1.SetToolTip(this.HighlightCheck, "Highlight Disabled Accounts in Red");
            this.HighlightCheck.UseVisualStyleBackColor = false;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BackColor = System.Drawing.Color.White;
            this.ExecuteButton.Caption = "Execute";
            this.ExecuteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExecuteButton.Description = null;
            this.ExecuteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExecuteButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.ExecuteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExecuteButton.HasBorder = true;
            this.ExecuteButton.HasRightSideBorder = false;
            this.ExecuteButton.Image = null;
            this.ExecuteButton.Is2PaneDrawing = false;
            this.ExecuteButton.IsImageTransparent = false;
            this.ExecuteButton.IsMouseOn = false;
            this.ExecuteButton.IsRadio = false;
            this.ExecuteButton.Location = new System.Drawing.Point(0, 0);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.ShowDescriptionOnHover = true;
            this.ExecuteButton.Size = new System.Drawing.Size(148, 32);
            this.ExecuteButton.TabIndex = 13;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pgrid);
            this.splitContainer1.Size = new System.Drawing.Size(643, 278);
            this.splitContainer1.SplitterDistance = 462;
            this.splitContainer1.TabIndex = 21;
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.CustomBackColor1 = System.Drawing.Color.Empty;
            this.grid.CustomBackColor2 = System.Drawing.Color.Silver;
            this.grid.CustomForecolor = System.Drawing.Color.Empty;
            this.grid.CustomSelectedBackColor1 = System.Drawing.Color.Empty;
            this.grid.CustomSelectedBackColor2 = System.Drawing.Color.Empty;
            this.grid.CustomSelectedForecolor = System.Drawing.Color.Empty;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.grid.Font = new System.Drawing.Font("Verdana", 9F);
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.NoSelectedColor = false;
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 45;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(462, 278);
            this.grid.TabIndex = 19;
            // 
            // pgrid
            // 
            this.pgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgrid.Location = new System.Drawing.Point(0, 0);
            this.pgrid.Name = "pgrid";
            this.pgrid.Size = new System.Drawing.Size(177, 278);
            this.pgrid.TabIndex = 18;
            this.pgrid.Visible = false;
            // 
            // ActiveDirectoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "ActiveDirectoryControl";
            this.Size = new System.Drawing.Size(643, 310);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Windows8LookNFeel.Windows8Button ExecuteButton;
        private Windows8LookNFeel.Windows8CheckBox HighlightCheck;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Windows8LookNFeel.Windows8GridView grid;
        private System.Windows.Forms.PropertyGrid pgrid;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
