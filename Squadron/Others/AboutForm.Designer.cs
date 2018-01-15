namespace Squadron.Misc
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.stylingPanel1 = new Windows8LookNFeel.Windows8Panel();
            this.DisclaimerButton = new Windows8LookNFeel.Windows8Button();
            this.SystemInfoText = new System.Windows.Forms.TextBox();
            this.NamePanel = new Windows8LookNFeel.Windows8Panel();
            this.OkButton = new Windows8LookNFeel.Windows8Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.JeanPaulVAlink = new System.Windows.Forms.LinkLabel();
            this.stylingPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stylingPanel1
            // 
            this.stylingPanel1.BackColor = System.Drawing.Color.White;
            this.stylingPanel1.Caption = null;
            this.stylingPanel1.Controls.Add(this.DisclaimerButton);
            this.stylingPanel1.Controls.Add(this.SystemInfoText);
            this.stylingPanel1.Controls.Add(this.NamePanel);
            this.stylingPanel1.Controls.Add(this.OkButton);
            this.stylingPanel1.Controls.Add(this.label3);
            this.stylingPanel1.Controls.Add(this.linkLabel1);
            this.stylingPanel1.Controls.Add(this.JeanPaulVAlink);
            this.stylingPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingPanel1.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingPanel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stylingPanel1.HasBorder = true;
            this.stylingPanel1.Image = null;
            this.stylingPanel1.IsImageTransparent = false;
            this.stylingPanel1.Location = new System.Drawing.Point(0, 0);
            this.stylingPanel1.Name = "stylingPanel1";
            this.stylingPanel1.Size = new System.Drawing.Size(617, 358);
            this.stylingPanel1.TabIndex = 5;
            this.stylingPanel1.Tag = ";";
            this.stylingPanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DisclaimerButton
            // 
            this.DisclaimerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.DisclaimerButton.Caption = "Disclaimer";
            this.DisclaimerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisclaimerButton.Description = null;
            this.DisclaimerButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DisclaimerButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.DisclaimerButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DisclaimerButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DisclaimerButton.HasBorder = true;
            this.DisclaimerButton.HasRightSideBorder = false;
            this.DisclaimerButton.Image = null;
            this.DisclaimerButton.Is2PaneDrawing = false;
            this.DisclaimerButton.IsImageTransparent = false;
            this.DisclaimerButton.IsMouseOn = false;
            this.DisclaimerButton.IsRadio = false;
            this.DisclaimerButton.Location = new System.Drawing.Point(519, 253);
            this.DisclaimerButton.Name = "DisclaimerButton";
            this.DisclaimerButton.ShowDescriptionOnHover = true;
            this.DisclaimerButton.Size = new System.Drawing.Size(85, 26);
            this.DisclaimerButton.TabIndex = 23;
            this.DisclaimerButton.Text = "Disclaimer";
            this.DisclaimerButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DisclaimerButton.Click += new System.EventHandler(this.DisclaimerButton_Click);
            // 
            // SystemInfoText
            // 
            this.SystemInfoText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SystemInfoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SystemInfoText.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemInfoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SystemInfoText.Location = new System.Drawing.Point(12, 305);
            this.SystemInfoText.Multiline = true;
            this.SystemInfoText.Name = "SystemInfoText";
            this.SystemInfoText.ReadOnly = true;
            this.SystemInfoText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SystemInfoText.Size = new System.Drawing.Size(594, 42);
            this.SystemInfoText.TabIndex = 22;
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NamePanel.Caption = "Squadron";
            this.NamePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NamePanel.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.NamePanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamePanel.HasBorder = true;
            this.NamePanel.Image = null;
            this.NamePanel.IsImageTransparent = false;
            this.NamePanel.Location = new System.Drawing.Point(0, 0);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(617, 41);
            this.NamePanel.TabIndex = 20;
            this.NamePanel.Text = "Squadron";
            this.NamePanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.OkButton.Caption = "Ok";
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.Description = null;
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.OkButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OkButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OkButton.HasBorder = true;
            this.OkButton.HasRightSideBorder = false;
            this.OkButton.Image = null;
            this.OkButton.Is2PaneDrawing = false;
            this.OkButton.IsImageTransparent = false;
            this.OkButton.IsMouseOn = false;
            this.OkButton.IsRadio = false;
            this.OkButton.Location = new System.Drawing.Point(13, 253);
            this.OkButton.Name = "OkButton";
            this.OkButton.ShowDescriptionOnHover = true;
            this.OkButton.Size = new System.Drawing.Size(85, 26);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "Ok";
            this.OkButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(593, 149);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Navy;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(198, 211);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(407, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "jeanpaulva@gmail.com                                     Redmond, WA";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JeanPaulVAlink
            // 
            this.JeanPaulVAlink.BackColor = System.Drawing.Color.Transparent;
            this.JeanPaulVAlink.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JeanPaulVAlink.ForeColor = System.Drawing.Color.Navy;
            this.JeanPaulVAlink.LinkColor = System.Drawing.Color.Navy;
            this.JeanPaulVAlink.Location = new System.Drawing.Point(12, 210);
            this.JeanPaulVAlink.Name = "JeanPaulVAlink";
            this.JeanPaulVAlink.Size = new System.Drawing.Size(150, 15);
            this.JeanPaulVAlink.TabIndex = 5;
            this.JeanPaulVAlink.TabStop = true;
            this.JeanPaulVAlink.Text = "www.jeanpaulva.com";
            this.JeanPaulVAlink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JeanPaulVAlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.JeanPaulVAlink_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(617, 358);
            this.Controls.Add(this.stylingPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.stylingPanel1.ResumeLayout(false);
            this.stylingPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows8LookNFeel.Windows8Panel stylingPanel1;
        private Windows8LookNFeel.Windows8Button OkButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel JeanPaulVAlink;
        private Windows8LookNFeel.Windows8Panel NamePanel;
        public System.Windows.Forms.TextBox SystemInfoText;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Windows8LookNFeel.Windows8Button DisclaimerButton;
    }
}
