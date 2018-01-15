namespace SquadronAddins.Default.MySiteInfo
{
    partial class MySiteControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FilterValue = new System.Windows.Forms.TextBox();
            this.FilterColumn = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new Windows8LookNFeel.Windows8Button();
            this.LastModifiedDateCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.SizeCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FilterValue);
            this.panel1.Controls.Add(this.FilterColumn);
            this.panel1.Controls.Add(this.ExecuteButton);
            this.panel1.Controls.Add(this.LastModifiedDateCheck);
            this.panel1.Controls.Add(this.SizeCheck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 38);
            this.panel1.TabIndex = 10;
            // 
            // FilterValue
            // 
            this.FilterValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FilterValue.Location = new System.Drawing.Point(466, 3);
            this.FilterValue.Name = "FilterValue";
            this.FilterValue.Size = new System.Drawing.Size(138, 20);
            this.FilterValue.TabIndex = 17;
            this.FilterValue.Text = "(filter value)";
            // 
            // FilterColumn
            // 
            this.FilterColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FilterColumn.Location = new System.Drawing.Point(322, 3);
            this.FilterColumn.Name = "FilterColumn";
            this.FilterColumn.Size = new System.Drawing.Size(138, 20);
            this.FilterColumn.TabIndex = 17;
            this.FilterColumn.Text = "(filter column)";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Caption = "Execute";
            this.ExecuteButton.Description = null;
            this.ExecuteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExecuteButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.ExecuteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.HasBorder = true;
            this.ExecuteButton.HasRightSideBorder = false;
            this.ExecuteButton.Image = null;
            this.ExecuteButton.Is2PaneDrawing = false;
            this.ExecuteButton.IsImageTransparent = false;
            this.ExecuteButton.IsMouseOn = false;
            this.ExecuteButton.IsRadio = false;
            this.ExecuteButton.Location = new System.Drawing.Point(2, 3);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.ShowDescriptionOnHover = true;
            this.ExecuteButton.Size = new System.Drawing.Size(148, 32);
            this.ExecuteButton.TabIndex = 16;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // LastModifiedDateCheck
            // 
            this.LastModifiedDateCheck.AutoSize = true;
            this.LastModifiedDateCheck.BackColor = System.Drawing.Color.Transparent;
            this.LastModifiedDateCheck.Checked = true;
            this.LastModifiedDateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LastModifiedDateCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.LastModifiedDateCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastModifiedDateCheck.ForeColor = System.Drawing.Color.Black;
            this.LastModifiedDateCheck.Location = new System.Drawing.Point(156, 17);
            this.LastModifiedDateCheck.Name = "LastModifiedDateCheck";
            this.LastModifiedDateCheck.Size = new System.Drawing.Size(125, 19);
            this.LastModifiedDateCheck.TabIndex = 15;
            this.LastModifiedDateCheck.Text = "Last Modified Date";
            this.LastModifiedDateCheck.UseVisualStyleBackColor = false;
            this.LastModifiedDateCheck.Visible = false;
            // 
            // SizeCheck
            // 
            this.SizeCheck.AutoSize = true;
            this.SizeCheck.BackColor = System.Drawing.Color.Transparent;
            this.SizeCheck.Checked = true;
            this.SizeCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SizeCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.SizeCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeCheck.ForeColor = System.Drawing.Color.Black;
            this.SizeCheck.Location = new System.Drawing.Point(156, 0);
            this.SizeCheck.Name = "SizeCheck";
            this.SizeCheck.Size = new System.Drawing.Size(46, 19);
            this.SizeCheck.TabIndex = 15;
            this.SizeCheck.Text = "Size";
            this.SizeCheck.UseVisualStyleBackColor = false;
            this.SizeCheck.Visible = false;
            // 
            // grid
            // 
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
            this.grid.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.grid.Location = new System.Drawing.Point(0, 38);
            this.grid.Name = "grid";
            this.grid.NoSelectedColor = false;
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(776, 379);
            this.grid.TabIndex = 15;
            // 
            // MySiteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Name = "MySiteControl";
            this.Size = new System.Drawing.Size(776, 417);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Windows8LookNFeel.Windows8CheckBox LastModifiedDateCheck;
        private Windows8LookNFeel.Windows8CheckBox SizeCheck;
        private Windows8LookNFeel.Windows8Button ExecuteButton;
        private System.Windows.Forms.TextBox FilterValue;
        private System.Windows.Forms.TextBox FilterColumn;
        private Windows8LookNFeel.Windows8GridView grid;
    }
}
