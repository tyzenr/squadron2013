namespace Squadron.Styling
{
    partial class ConfirmDialog
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
            Squadron.Styling.Themes.ThemePart themePart2 = new Squadron.Styling.Themes.ThemePart();
            Squadron.Styling.Themes.ThemePart themePart1 = new Squadron.Styling.Themes.ThemePart();
            this.YesButton = new Squadron.Styling.Widgets.Windows8LookNFeel.Windows8Button();
            this.NoButton = new Squadron.Styling.Widgets.Windows8LookNFeel.Windows8Button();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.WorkareaPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.Controls.Add(this.MessageText);
            this.WorkareaPanel.Size = new System.Drawing.Size(536, 168);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.HeaderPanel.BackColor2 = System.Drawing.Color.Olive;
            this.HeaderPanel.Size = new System.Drawing.Size(536, 45);
            this.HeaderPanel.Tag = ";";
            this.HeaderPanel.Text = "Confirm";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.NoButton);
            this.FooterPanel.Controls.Add(this.YesButton);
            this.FooterPanel.Location = new System.Drawing.Point(0, 213);
            this.FooterPanel.Size = new System.Drawing.Size(536, 41);
            this.FooterPanel.Tag = ";";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(505, 15);
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.YesButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(123)))));
            this.YesButton.BackHighlightColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.YesButton.BackHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.YesButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.YesButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.YesButton.ForeColor = System.Drawing.Color.White;
            this.YesButton.ForecolorHighlight = System.Drawing.Color.White;
            this.YesButton.Image = null;
            this.YesButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.YesButton.Location = new System.Drawing.Point(345, 7);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(89, 27);
            this.YesButton.StretchImage = false;
            this.YesButton.TabIndex = 1;
            this.YesButton.Text = "Yes";
            this.YesButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YesButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.YesButton.ThemePart = themePart2;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.NoButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(123)))));
            this.NoButton.BackHighlightColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.NoButton.BackHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.NoButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.NoButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NoButton.ForeColor = System.Drawing.Color.White;
            this.NoButton.ForecolorHighlight = System.Drawing.Color.White;
            this.NoButton.Image = null;
            this.NoButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NoButton.Location = new System.Drawing.Point(440, 7);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(89, 27);
            this.NoButton.StretchImage = false;
            this.NoButton.TabIndex = 1;
            this.NoButton.Text = "No";
            this.NoButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NoButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.NoButton.ThemePart = themePart1;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // MessageText
            // 
            this.MessageText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MessageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageText.ForeColor = System.Drawing.Color.Navy;
            this.MessageText.Location = new System.Drawing.Point(0, 0);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.ReadOnly = true;
            this.MessageText.Size = new System.Drawing.Size(536, 168);
            this.MessageText.TabIndex = 1;
            this.MessageText.Text = "Message here";
            // 
            // ConfirmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 254);
            this.HeaderText = "Confirm";
            this.Name = "ConfirmDialog";
            this.Text = "Confirm";
            this.WorkareaPanel.ResumeLayout(false);
            this.WorkareaPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Styling.Widgets.Windows8LookNFeel.Windows8Button NoButton;
        private Styling.Widgets.Windows8LookNFeel.Windows8Button YesButton;
        private System.Windows.Forms.TextBox MessageText;
    }
}