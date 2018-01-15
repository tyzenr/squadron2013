namespace SquadronAddIns.Default.Documentation.Controls
{
    partial class GridPanel
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
            this.stylingWorkarea3 = new Windows8LookNFeel.Windows8Panel();
            this.grid = new Windows8LookNFeel.Windows8GridView();
            this.stylingWorkarea2 = new Windows8LookNFeel.Windows8Panel();
            this.stylingWorkarea1 = new Windows8LookNFeel.Windows8Panel();
            this.HeaderPanel = new Windows8LookNFeel.Windows8Panel();
            this.stylingWorkarea3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.stylingWorkarea1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stylingWorkarea3
            // 
            this.stylingWorkarea3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea3.Caption = null;
            this.stylingWorkarea3.Controls.Add(this.grid);
            this.stylingWorkarea3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea3.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingWorkarea3.HasBorder = true;
            this.stylingWorkarea3.Image = null;
            this.stylingWorkarea3.IsImageTransparent = false;
            this.stylingWorkarea3.Location = new System.Drawing.Point(0, 20);
            this.stylingWorkarea3.Name = "stylingWorkarea3";
            this.stylingWorkarea3.Size = new System.Drawing.Size(677, 96);
            this.stylingWorkarea3.TabIndex = 2;
            this.stylingWorkarea3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
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
            this.grid.NoSelectedColor = true;
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 30;
            this.grid.Size = new System.Drawing.Size(677, 96);
            this.grid.TabIndex = 1;
            // 
            // stylingWorkarea2
            // 
            this.stylingWorkarea2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea2.Caption = null;
            this.stylingWorkarea2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stylingWorkarea2.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingWorkarea2.HasBorder = true;
            this.stylingWorkarea2.Image = null;
            this.stylingWorkarea2.IsImageTransparent = false;
            this.stylingWorkarea2.Location = new System.Drawing.Point(0, 116);
            this.stylingWorkarea2.Name = "stylingWorkarea2";
            this.stylingWorkarea2.Size = new System.Drawing.Size(677, 17);
            this.stylingWorkarea2.TabIndex = 1;
            this.stylingWorkarea2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stylingWorkarea1
            // 
            this.stylingWorkarea1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea1.Caption = null;
            this.stylingWorkarea1.Controls.Add(this.HeaderPanel);
            this.stylingWorkarea1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stylingWorkarea1.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingWorkarea1.HasBorder = true;
            this.stylingWorkarea1.Image = null;
            this.stylingWorkarea1.IsImageTransparent = false;
            this.stylingWorkarea1.Location = new System.Drawing.Point(0, 0);
            this.stylingWorkarea1.Name = "stylingWorkarea1";
            this.stylingWorkarea1.Size = new System.Drawing.Size(677, 20);
            this.stylingWorkarea1.TabIndex = 0;
            this.stylingWorkarea1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.HeaderPanel.Caption = null;
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderPanel.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.HeaderPanel.ForeColor = System.Drawing.Color.Gray;
            this.HeaderPanel.HasBorder = true;
            this.HeaderPanel.Image = null;
            this.HeaderPanel.IsImageTransparent = false;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(677, 20);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.Text = "Title";
            this.HeaderPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // GridPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stylingWorkarea3);
            this.Controls.Add(this.stylingWorkarea2);
            this.Controls.Add(this.stylingWorkarea1);
            this.Name = "GridPanel";
            this.Size = new System.Drawing.Size(677, 133);
            this.stylingWorkarea3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.stylingWorkarea1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Windows8LookNFeel.Windows8Panel stylingWorkarea1;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea2;
        private Windows8LookNFeel.Windows8Panel HeaderPanel;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea3;
        private Windows8LookNFeel.Windows8GridView grid;

    }
}
