namespace SquadronAddIns.Default.Command.Dialogs
{
    partial class PowerShellCodeDialog
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
            this.components = new System.ComponentModel.Container();
            this.CodeText = new System.Windows.Forms.TextBox();
            this.LaunchPSButton = new Windows8LookNFeel.Windows8Button();
            this.LaunchPSISEButton = new Windows8LookNFeel.Windows8Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.WorkareaPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.Controls.Add(this.CodeText);
            this.WorkareaPanel.Size = new System.Drawing.Size(770, 373);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.DarkGray;
            this.HeaderPanel.Size = new System.Drawing.Size(770, 45);
            this.HeaderPanel.Text = "PowerShell Code";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.LaunchPSISEButton);
            this.FooterPanel.Controls.Add(this.LaunchPSButton);
            this.FooterPanel.Location = new System.Drawing.Point(0, 418);
            this.FooterPanel.Size = new System.Drawing.Size(770, 41);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(739, 15);
            // 
            // HelpButton
            // 
            this.HelpButton.LaunchUrl = "http://www.jeanpaulva.com/?p=4900";
            this.HelpButton.Location = new System.Drawing.Point(688, 15);
            // 
            // CodeText
            // 
            this.CodeText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CodeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CodeText.Location = new System.Drawing.Point(0, 0);
            this.CodeText.Multiline = true;
            this.CodeText.Name = "CodeText";
            this.CodeText.Size = new System.Drawing.Size(770, 373);
            this.CodeText.TabIndex = 1;
            this.CodeText.Text = "Message here..";
            // 
            // LaunchPSButton
            // 
            this.LaunchPSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.LaunchPSButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LaunchPSButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LaunchPSButton.ForeColor = System.Drawing.Color.White;
            this.LaunchPSButton.Image = null;
            this.LaunchPSButton.Location = new System.Drawing.Point(9, 9);
            this.LaunchPSButton.Name = "LaunchPSButton";
            this.LaunchPSButton.Size = new System.Drawing.Size(173, 24);
            this.LaunchPSButton.TabIndex = 0;
            this.LaunchPSButton.Text = "Launch PowerShell";
            this.LaunchPSButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.LaunchPSButton, "Launch PowerShell command window loaded with SharePoint snap-ins");
            this.LaunchPSButton.Click += new System.EventHandler(this.LaunchPSButton_Click);
            // 
            // LaunchPSISEButton
            // 
            this.LaunchPSISEButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.LaunchPSISEButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LaunchPSISEButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LaunchPSISEButton.ForeColor = System.Drawing.Color.White;
            this.LaunchPSISEButton.Image = null;
            this.LaunchPSISEButton.Location = new System.Drawing.Point(188, 9);
            this.LaunchPSISEButton.Name = "LaunchPSISEButton";
            this.LaunchPSISEButton.Size = new System.Drawing.Size(173, 24);
            this.LaunchPSISEButton.TabIndex = 0;
            this.LaunchPSISEButton.Text = "Launch PowerShell ISE";
            this.LaunchPSISEButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.LaunchPSISEButton, "Launch PowerShell ISE (Integrated Scripting Environment)");
            this.LaunchPSISEButton.Click += new System.EventHandler(this.LaunchPSISEButton_Click);
            // 
            // PowerShellCodeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 459);
            this.HeaderText = "PowerShell Code";
            this.Name = "PowerShellCodeDialog";
            this.ShowFooter = true;
            this.Text = "PowerShell Code";
            this.WorkareaPanel.ResumeLayout(false);
            this.WorkareaPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CodeText;
        private Windows8LookNFeel.Windows8Button LaunchPSButton;
        private Windows8LookNFeel.Windows8Button LaunchPSISEButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
