namespace SquadronAddins.Default.Stsadm
{
    partial class StsadmControl
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
            this.ExecuteButton = new Windows8LookNFeel.Windows8Button();
            this.CommandText = new System.Windows.Forms.TextBox();
            this.MenuLog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pbr = new System.Windows.Forms.ProgressBar();
            this.OutText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.MenuLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExecuteButton);
            this.panel1.Controls.Add(this.CommandText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 37);
            this.panel1.TabIndex = 0;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteButton.Caption = "Execute";
            this.ExecuteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExecuteButton.Description = null;
            this.ExecuteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExecuteButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.ExecuteButton.HasBorder = true;
            this.ExecuteButton.HasRightSideBorder = false;
            this.ExecuteButton.Image = null;
            this.ExecuteButton.Is2PaneDrawing = false;
            this.ExecuteButton.IsImageTransparent = false;
            this.ExecuteButton.IsMouseOn = false;
            this.ExecuteButton.IsRadio = false;
            this.ExecuteButton.Location = new System.Drawing.Point(490, 3);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.ShowDescriptionOnHover = true;
            this.ExecuteButton.Size = new System.Drawing.Size(70, 32);
            this.ExecuteButton.TabIndex = 3;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // CommandText
            // 
            this.CommandText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandText.BackColor = System.Drawing.Color.GreenYellow;
            this.CommandText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandText.Location = new System.Drawing.Point(3, 6);
            this.CommandText.Name = "CommandText";
            this.CommandText.Size = new System.Drawing.Size(485, 29);
            this.CommandText.TabIndex = 0;
            this.CommandText.Text = "STSADM -HELP";
            this.CommandText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandText_KeyDown);
            // 
            // MenuLog
            // 
            this.MenuLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearMenu});
            this.MenuLog.Name = "MenuLog";
            this.MenuLog.Size = new System.Drawing.Size(102, 26);
            // 
            // clearMenu
            // 
            this.clearMenu.Name = "clearMenu";
            this.clearMenu.Size = new System.Drawing.Size(101, 22);
            this.clearMenu.Text = "Clear";
            this.clearMenu.Click += new System.EventHandler(this.clearMenu_Click);
            // 
            // pbr
            // 
            this.pbr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbr.Location = new System.Drawing.Point(0, 340);
            this.pbr.Name = "pbr";
            this.pbr.Size = new System.Drawing.Size(563, 16);
            this.pbr.TabIndex = 1;
            this.pbr.Value = 99;
            this.pbr.Visible = false;
            // 
            // OutText
            // 
            this.OutText.BackColor = System.Drawing.Color.White;
            this.OutText.ContextMenuStrip = this.MenuLog;
            this.OutText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(231)))));
            this.OutText.Location = new System.Drawing.Point(0, 37);
            this.OutText.Multiline = true;
            this.OutText.Name = "OutText";
            this.OutText.ReadOnly = true;
            this.OutText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutText.Size = new System.Drawing.Size(563, 303);
            this.OutText.TabIndex = 2;
            // 
            // StsadmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OutText);
            this.Controls.Add(this.pbr);
            this.Controls.Add(this.panel1);
            this.Name = "StsadmControl";
            this.Size = new System.Drawing.Size(563, 356);
            this.Load += new System.EventHandler(this.StsadmControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CommandText;
        private Windows8LookNFeel.Windows8Button ExecuteButton;
        private System.Windows.Forms.ContextMenuStrip MenuLog;
        private System.Windows.Forms.ToolStripMenuItem clearMenu;
        private System.Windows.Forms.ProgressBar pbr;
        private System.Windows.Forms.TextBox OutText;
    }
}
