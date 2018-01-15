namespace SquadronAddins.Default.Commands
{
    partial class CommandControl
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
            this.OutText = new System.Windows.Forms.TextBox();
            this.MenuLog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CommandPanel = new System.Windows.Forms.Panel();
            this.ExecuteButton = new Windows8LookNFeel.Windows8Button();
            this.CommandText = new System.Windows.Forms.TextBox();
            this.pbr = new System.Windows.Forms.ProgressBar();
            this.MenuLog.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutText
            // 
            this.OutText.BackColor = System.Drawing.Color.White;
            this.OutText.ContextMenuStrip = this.MenuLog;
            this.OutText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(231)))));
            this.OutText.Location = new System.Drawing.Point(0, 143);
            this.OutText.Multiline = true;
            this.OutText.Name = "OutText";
            this.OutText.ReadOnly = true;
            this.OutText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutText.Size = new System.Drawing.Size(664, 258);
            this.OutText.TabIndex = 5;
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CommandPanel);
            this.panel1.Controls.Add(this.ExecuteButton);
            this.panel1.Controls.Add(this.CommandText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 143);
            this.panel1.TabIndex = 3;
            // 
            // CommandPanel
            // 
            this.CommandPanel.Location = new System.Drawing.Point(4, 4);
            this.CommandPanel.Name = "CommandPanel";
            this.CommandPanel.Size = new System.Drawing.Size(585, 60);
            this.CommandPanel.TabIndex = 4;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteButton.Location = new System.Drawing.Point(591, 3);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(70, 134);
            this.ExecuteButton.TabIndex = 3;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // CommandText
            // 
            this.CommandText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CommandText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandText.Location = new System.Drawing.Point(3, 63);
            this.CommandText.Multiline = true;
            this.CommandText.Name = "CommandText";
            this.CommandText.Size = new System.Drawing.Size(586, 74);
            this.CommandText.TabIndex = 0;
            this.CommandText.Text = "HELP";
            this.CommandText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandText_KeyDown);
            // 
            // pbr
            // 
            this.pbr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbr.Location = new System.Drawing.Point(0, 401);
            this.pbr.Name = "pbr";
            this.pbr.Size = new System.Drawing.Size(664, 16);
            this.pbr.TabIndex = 4;
            this.pbr.Value = 99;
            this.pbr.Visible = false;
            // 
            // CommandControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OutText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbr);
            this.Name = "CommandControl";
            this.Size = new System.Drawing.Size(664, 417);
            this.Load += new System.EventHandler(this.CommandControl_Load);
            this.MenuLog.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutText;
        private System.Windows.Forms.ContextMenuStrip MenuLog;
        private System.Windows.Forms.ToolStripMenuItem clearMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel CommandPanel;
        private Windows8LookNFeel.Windows8Button ExecuteButton;
        private System.Windows.Forms.TextBox CommandText;
        private System.Windows.Forms.ProgressBar pbr;

    }
}
