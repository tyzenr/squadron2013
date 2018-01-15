namespace Squadron.Styling
{
    partial class PropertyDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new System.Windows.Forms.PropertyGrid();
            this.WorkareaPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.Controls.Add(this.grid);
            this.WorkareaPanel.Location = new System.Drawing.Point(0, 33);
            this.WorkareaPanel.Size = new System.Drawing.Size(292, 337);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Magenta;
            this.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.HeaderPanel.Size = new System.Drawing.Size(292, 33);
            this.HeaderPanel.Text = "Properties";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Location = new System.Drawing.Point(0, 370);
            this.FooterPanel.Size = new System.Drawing.Size(292, 21);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(268, 8);
            // 
            // grid
            // 
            this.grid.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.HelpBackColor = System.Drawing.Color.WhiteSmoke;
            this.grid.HelpVisible = false;
            this.grid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(292, 337);
            this.grid.TabIndex = 1;
            // 
            // PropertyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 391);
            this.HeaderText = "Properties";
            this.Name = "PropertyDialog";
            this.ShowFooter = true;
            this.Text = "Properties";
            this.WorkareaPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid grid;

    }
}