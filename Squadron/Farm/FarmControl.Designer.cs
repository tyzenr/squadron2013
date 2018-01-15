namespace SquadronAddIns.Default.Farm
{
    partial class FarmControl
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ExecuteButton = new Windows8LookNFeel.Windows8Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.pgrid = new System.Windows.Forms.PropertyGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BackColor = System.Drawing.Color.White;
            this.ExecuteButton.Caption = "Execute";
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
            this.ExecuteButton.Text = "Refresh";
            this.ExecuteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.ExecuteButton, "Retrieves the Farm Information");
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExecuteButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 32);
            this.panel1.TabIndex = 22;
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
            this.grid.Location = new System.Drawing.Point(0, 32);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.NoSelectedColor = false;
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 45;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(623, 362);
            this.grid.TabIndex = 23;
            // 
            // pgrid
            // 
            this.pgrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.pgrid.Location = new System.Drawing.Point(334, 32);
            this.pgrid.Name = "pgrid";
            this.pgrid.Size = new System.Drawing.Size(289, 362);
            this.pgrid.TabIndex = 24;
            // 
            // FarmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pgrid);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Name = "FarmControl";
            this.Size = new System.Drawing.Size(623, 394);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private Windows8LookNFeel.Windows8Button ExecuteButton;
        private System.Windows.Forms.Panel panel1;
        private Windows8LookNFeel.Windows8GridView grid;
        private System.Windows.Forms.PropertyGrid pgrid;
    }
}
