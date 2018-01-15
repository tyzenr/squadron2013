using System.Windows.Forms;
using Windows8LookNFeel;
namespace Squadron.Styling.Widgets
{
    partial class StylingForm
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
            Squadron.Styling.Themes.ThemePart themePart3 = new Squadron.Styling.Themes.ThemePart();
            Squadron.Styling.Themes.ThemePart themePart2 = new Squadron.Styling.Themes.ThemePart();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StylingForm));
            this.WorkareaPanel = new Squadron.Styling.Widgets.StylingWorkarea();
            this.FooterPanel = new Squadron.Styling.Widgets.StylingPanel();
            this.HeaderPanel = new Squadron.Styling.Widgets.StylingHeaderPanel();
            this.HelpButton = new Squadron.Styling.Widgets.BlinkingButton();
            this.CloseButton = new Squadron.Styling.Widgets.Windows8LookNFeel.Windows8Button();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WorkareaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkareaPanel.Location = new System.Drawing.Point(0, 45);
            this.WorkareaPanel.Name = "WorkareaPanel";
            this.WorkareaPanel.Size = new System.Drawing.Size(620, 353);
            this.WorkareaPanel.TabIndex = 9;
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FooterPanel.BackColor2 = System.Drawing.Color.Gray;
            this.FooterPanel.BackHighlightColor1 = System.Drawing.Color.Empty;
            this.FooterPanel.BackHighlightColor2 = System.Drawing.Color.Empty;
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FooterPanel.ForecolorHighlight = System.Drawing.Color.Empty;
            this.FooterPanel.Image = null;
            this.FooterPanel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FooterPanel.Location = new System.Drawing.Point(0, 398);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(620, 27);
            this.FooterPanel.StretchImage = false;
            this.FooterPanel.TabIndex = 8;
            this.FooterPanel.Tag = ";";
            this.FooterPanel.Text = null;
            this.FooterPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FooterPanel.TextPadding = new System.Windows.Forms.Padding(0);
            this.FooterPanel.ThemePart = themePart1;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.HeaderPanel.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.HeaderPanel.BackHighlightColor1 = System.Drawing.Color.Empty;
            this.HeaderPanel.BackHighlightColor2 = System.Drawing.Color.Empty;
            this.HeaderPanel.Controls.Add(this.HelpButton);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderPanel.ForecolorHighlight = System.Drawing.Color.Empty;
            this.HeaderPanel.Image = null;
            this.HeaderPanel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(620, 45);
            this.HeaderPanel.StretchImage = false;
            this.HeaderPanel.TabIndex = 7;
            this.HeaderPanel.Text = "Form Caption";
            this.HeaderPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HeaderPanel.TextPadding = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.ThemePart = themePart3;
            // 
            // HelpButton
            // 
            this.HelpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.HelpButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(123)))));
            this.HelpButton.BackHighlightColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.HelpButton.BackHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.HelpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.HelpButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HelpButton.ForeColor = System.Drawing.Color.White;
            this.HelpButton.ForecolorHighlight = System.Drawing.Color.White;
            this.HelpButton.Image = null;
            this.HelpButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HelpButton.LaunchUrl = "";
            this.HelpButton.Location = new System.Drawing.Point(508, 15);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(44, 17);
            this.HelpButton.StretchImage = false;
            this.HelpButton.TabIndex = 9;
            this.HelpButton.Text = "Help";
            this.HelpButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HelpButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.HelpButton.ThemePart = themePart2;
            this.HelpButton.Visible = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.CloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(123)))));
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackHighlightColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CloseButton.BackHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.ForecolorHighlight = System.Drawing.Color.White;
            this.CloseButton.Image = null;
            this.CloseButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CloseButton.Location = new System.Drawing.Point(589, 15);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(16, 17);
            this.CloseButton.StretchImage = true;
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = null;
            this.CloseButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CloseButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.CloseButton.ThemePart = themePart1;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // StylingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(620, 425);
            this.Controls.Add(this.WorkareaPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "StylingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StylingForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StylingForm_KeyDown);
            this.HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public StylingWorkarea WorkareaPanel;
        public StylingHeaderPanel HeaderPanel;
        public Windows8Panel FooterPanel;
        public Windows8Button CloseButton;
        public BlinkingButton HelpButton;
    }
}