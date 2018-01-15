namespace Squadron.Styling
{
    partial class MessageDialog
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
            Squadron.Styling.Themes.ThemePart themePart1 = new Squadron.Styling.Themes.ThemePart();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.OkButton = new Squadron.Styling.Widgets.Windows8LookNFeel.Windows8Button();
            this.SolutionLink = new System.Windows.Forms.LinkLabel();
            this.WorkareaPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.Controls.Add(this.MessageText);
            this.WorkareaPanel.Size = new System.Drawing.Size(509, 176);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanel.Size = new System.Drawing.Size(509, 45);
            this.HeaderPanel.Tag = ";";
            this.HeaderPanel.Text = "Message";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.SolutionLink);
            this.FooterPanel.Controls.Add(this.OkButton);
            this.FooterPanel.Location = new System.Drawing.Point(0, 221);
            this.FooterPanel.Size = new System.Drawing.Size(509, 36);
            // 
            // CloseButton
            // 
            this.CloseButton.Visible = false;
            // 
            // MessageText
            // 
            this.MessageText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MessageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MessageText.Location = new System.Drawing.Point(0, 0);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.ReadOnly = true;
            this.MessageText.Size = new System.Drawing.Size(509, 176);
            this.MessageText.TabIndex = 0;
            this.MessageText.Text = "Message here..";
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.OkButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(123)))));
            this.OkButton.BackHighlightColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.OkButton.BackHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OkButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OkButton.ForeColor = System.Drawing.Color.White;
            this.OkButton.ForecolorHighlight = System.Drawing.Color.White;
            this.OkButton.Image = null;
            this.OkButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OkButton.Location = new System.Drawing.Point(209, 5);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(89, 27);
            this.OkButton.StretchImage = false;
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ok";
            this.OkButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OkButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.OkButton.ThemePart = themePart1;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SolutionLink
            // 
            this.SolutionLink.AutoSize = true;
            this.SolutionLink.Location = new System.Drawing.Point(12, 8);
            this.SolutionLink.Name = "SolutionLink";
            this.SolutionLink.Size = new System.Drawing.Size(138, 19);
            this.SolutionLink.TabIndex = 1;
            this.SolutionLink.TabStop = true;
            this.SolutionLink.Text = "View Solution here..";
            this.SolutionLink.Visible = false;
            this.SolutionLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SolutionLink_LinkClicked);
            // 
            // MessageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 257);
            this.HeaderText = "Message";
            this.Name = "MessageDialog";
            this.ShowFooter = true;
            this.Text = "Message";
            this.Resize += new System.EventHandler(this.MessageDialog_Resize);
            this.WorkareaPanel.ResumeLayout(false);
            this.WorkareaPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Styling.Widgets.Windows8LookNFeel.Windows8Button OkButton;
        private System.Windows.Forms.LinkLabel SolutionLink;
        public System.Windows.Forms.TextBox MessageText;
    }
}