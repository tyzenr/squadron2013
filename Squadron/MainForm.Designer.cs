namespace Squadron
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuLog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DebugMessagesChecked = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BlogButton = new System.Windows.Forms.Button();
            this.TwitterButton = new System.Windows.Forms.Button();
            this.FacebookButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.LogBox = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Refresh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DomainText = new System.Windows.Forms.TextBox();
            this.stylingHeaderPanel1 = new Windows8LookNFeel.Windows8Panel();
            this.TitleLabel = new System.Windows.Forms.LinkLabel();
            this.UrlText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddinList = new Windows8LookNFeel.Windows8ListBox();
            this.FollowPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.stylingHeaderPanel2 = new Windows8LookNFeel.Windows8Panel();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddinControlContainer = new System.Windows.Forms.Panel();
            this.AddinTitleLabel = new Windows8LookNFeel.Windows8Panel();
            this.helpbox = new Windows8LookNFeel.Windows8Button();
            this.MenuLog.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            this.stylingHeaderPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.FollowPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.AddinTitleLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuLog
            // 
            this.MenuLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearMenu,
            this.copyToClipboardToolStripMenuItem,
            this.copyToClipboardAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.DebugMessagesChecked});
            this.MenuLog.Name = "MenuLog";
            this.MenuLog.Size = new System.Drawing.Size(197, 98);
            // 
            // clearMenu
            // 
            this.clearMenu.Name = "clearMenu";
            this.clearMenu.Size = new System.Drawing.Size(196, 22);
            this.clearMenu.Text = "Clear";
            this.clearMenu.Click += new System.EventHandler(this.clearMenu_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // copyToClipboardAllToolStripMenuItem
            // 
            this.copyToClipboardAllToolStripMenuItem.Name = "copyToClipboardAllToolStripMenuItem";
            this.copyToClipboardAllToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.copyToClipboardAllToolStripMenuItem.Text = "Copy to Clipboard (All)";
            this.copyToClipboardAllToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // DebugMessagesChecked
            // 
            this.DebugMessagesChecked.CheckOnClick = true;
            this.DebugMessagesChecked.Name = "DebugMessagesChecked";
            this.DebugMessagesChecked.Size = new System.Drawing.Size(196, 22);
            this.DebugMessagesChecked.Text = "Debug Messages";
            // 
            // BlogButton
            // 
            this.BlogButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BlogButton.BackgroundImage")));
            this.BlogButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BlogButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BlogButton.ForeColor = System.Drawing.Color.White;
            this.BlogButton.Location = new System.Drawing.Point(77, 2);
            this.BlogButton.Name = "BlogButton";
            this.BlogButton.Size = new System.Drawing.Size(36, 34);
            this.BlogButton.TabIndex = 2;
            this.toolTip1.SetToolTip(this.BlogButton, "Click here to open the Blog");
            this.BlogButton.Click += new System.EventHandler(this.BlogButton_Click);
            // 
            // TwitterButton
            // 
            this.TwitterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TwitterButton.BackgroundImage")));
            this.TwitterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TwitterButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TwitterButton.ForeColor = System.Drawing.Color.White;
            this.TwitterButton.Location = new System.Drawing.Point(40, 2);
            this.TwitterButton.Name = "TwitterButton";
            this.TwitterButton.Size = new System.Drawing.Size(36, 34);
            this.TwitterButton.TabIndex = 1;
            this.toolTip1.SetToolTip(this.TwitterButton, "Click here to open Twitter");
            this.TwitterButton.Click += new System.EventHandler(this.TwitterButton_Click);
            // 
            // FacebookButton
            // 
            this.FacebookButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FacebookButton.BackgroundImage")));
            this.FacebookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FacebookButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FacebookButton.ForeColor = System.Drawing.Color.White;
            this.FacebookButton.Location = new System.Drawing.Point(2, 2);
            this.FacebookButton.Name = "FacebookButton";
            this.FacebookButton.Size = new System.Drawing.Size(36, 34);
            this.FacebookButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.FacebookButton, "Click here to open Facebook, You are Welcome to follow our SharePoint group");
            this.FacebookButton.Click += new System.EventHandler(this.FacebookButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(5, 54);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(30, 17);
            this.TotalLabel.TabIndex = 16;
            this.TotalLabel.Text = "Url:";
            this.toolTip1.SetToolTip(this.TotalLabel, "Web Application Url");
            // 
            // LogBox
            // 
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogBox.ContextMenuStrip = this.MenuLog;
            this.LogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBox.ForeColor = System.Drawing.Color.Gray;
            this.LogBox.FormattingEnabled = true;
            this.LogBox.Location = new System.Drawing.Point(0, 0);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(644, 60);
            this.LogBox.TabIndex = 15;
            this.toolTip1.SetToolTip(this.LogBox, "Double click to view in window");
            this.LogBox.DoubleClick += new System.EventHandler(this.LogBox_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.Refresh);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.DomainText);
            this.panel4.Controls.Add(this.stylingHeaderPanel1);
            this.panel4.Controls.Add(this.TotalLabel);
            this.panel4.Controls.Add(this.UrlText);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(844, 82);
            this.panel4.TabIndex = 6;
            // 
            // Refresh
            // 
            this.Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Refresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.Image")));
            this.Refresh.Location = new System.Drawing.Point(490, 50);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(29, 28);
            this.Refresh.TabIndex = 24;
            this.Refresh.TabStop = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Domain:";
            // 
            // DomainText
            // 
            this.DomainText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DomainText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DomainText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DomainText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomainText.Location = new System.Drawing.Point(581, 51);
            this.DomainText.Name = "DomainText";
            this.DomainText.Size = new System.Drawing.Size(260, 25);
            this.DomainText.TabIndex = 19;
            // 
            // stylingHeaderPanel1
            // 
            this.stylingHeaderPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.stylingHeaderPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stylingHeaderPanel1.Caption = null;
            this.stylingHeaderPanel1.Controls.Add(this.TitleLabel);
            this.stylingHeaderPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stylingHeaderPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stylingHeaderPanel1.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.stylingHeaderPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stylingHeaderPanel1.HasBorder = true;
            this.stylingHeaderPanel1.Image = null;
            this.stylingHeaderPanel1.IsImageTransparent = false;
            this.stylingHeaderPanel1.Location = new System.Drawing.Point(0, 0);
            this.stylingHeaderPanel1.Name = "stylingHeaderPanel1";
            this.stylingHeaderPanel1.Size = new System.Drawing.Size(844, 45);
            this.stylingHeaderPanel1.TabIndex = 18;
            this.stylingHeaderPanel1.Text = " ";
            this.stylingHeaderPanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.LinkColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(6, 10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(124, 21);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.TabStop = true;
            this.TitleLabel.Tag = ";";
            this.TitleLabel.Text = "Squadron 2013";
            this.TitleLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HeadingLabel_LinkClicked);
            // 
            // UrlText
            // 
            this.UrlText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UrlText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlText.Location = new System.Drawing.Point(41, 51);
            this.UrlText.Name = "UrlText";
            this.UrlText.Size = new System.Drawing.Size(448, 25);
            this.UrlText.TabIndex = 1;
            this.UrlText.Text = "http://localhost";
            this.UrlText.TextChanged += new System.EventHandler(this.UrlText_TextChanged);
            this.UrlText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrlText_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.AddinList);
            this.panel1.Controls.Add(this.FollowPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 459);
            this.panel1.TabIndex = 9;
            // 
            // AddinList
            // 
            this.AddinList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddinList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddinList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddinList.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.AddinList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AddinList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddinList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddinList.FormattingEnabled = true;
            this.AddinList.ItemHeight = 35;
            this.AddinList.Location = new System.Drawing.Point(0, 0);
            this.AddinList.Name = "AddinList";
            this.AddinList.Size = new System.Drawing.Size(200, 422);
            this.AddinList.TabIndex = 6;
            this.AddinList.SelectedIndexChanged += new System.EventHandler(this.AddinList_SelectedIndexChanged);
            // 
            // FollowPanel
            // 
            this.FollowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FollowPanel.Controls.Add(this.BlogButton);
            this.FollowPanel.Controls.Add(this.TwitterButton);
            this.FollowPanel.Controls.Add(this.FacebookButton);
            this.FollowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FollowPanel.Location = new System.Drawing.Point(0, 422);
            this.FollowPanel.Name = "FollowPanel";
            this.FollowPanel.Size = new System.Drawing.Size(200, 37);
            this.FollowPanel.TabIndex = 4;
            this.FollowPanel.Tag = ";";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.browser);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(200, 343);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(644, 198);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.LogBox);
            this.panel6.Controls.Add(this.stylingHeaderPanel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(644, 78);
            this.panel6.TabIndex = 12;
            // 
            // stylingHeaderPanel2
            // 
            this.stylingHeaderPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.stylingHeaderPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stylingHeaderPanel2.Caption = null;
            this.stylingHeaderPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stylingHeaderPanel2.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingHeaderPanel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stylingHeaderPanel2.HasBorder = true;
            this.stylingHeaderPanel2.Image = null;
            this.stylingHeaderPanel2.IsImageTransparent = false;
            this.stylingHeaderPanel2.Location = new System.Drawing.Point(0, 60);
            this.stylingHeaderPanel2.Name = "stylingHeaderPanel2";
            this.stylingHeaderPanel2.Size = new System.Drawing.Size(644, 18);
            this.stylingHeaderPanel2.TabIndex = 14;
            this.stylingHeaderPanel2.Text = " ";
            this.stylingHeaderPanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.browser.Location = new System.Drawing.Point(0, 78);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(644, 120);
            this.browser.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AddinControlContainer);
            this.panel3.Controls.Add(this.AddinTitleLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(644, 261);
            this.panel3.TabIndex = 11;
            // 
            // AddinControlContainer
            // 
            this.AddinControlContainer.BackColor = System.Drawing.Color.White;
            this.AddinControlContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddinControlContainer.BackgroundImage")));
            this.AddinControlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddinControlContainer.Location = new System.Drawing.Point(0, 24);
            this.AddinControlContainer.Name = "AddinControlContainer";
            this.AddinControlContainer.Size = new System.Drawing.Size(644, 237);
            this.AddinControlContainer.TabIndex = 8;
            // 
            // AddinTitleLabel
            // 
            this.AddinTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddinTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddinTitleLabel.Caption = "";
            this.AddinTitleLabel.Controls.Add(this.helpbox);
            this.AddinTitleLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddinTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddinTitleLabel.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.AddinTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddinTitleLabel.HasBorder = true;
            this.AddinTitleLabel.Image = null;
            this.AddinTitleLabel.IsImageTransparent = false;
            this.AddinTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.AddinTitleLabel.Name = "AddinTitleLabel";
            this.AddinTitleLabel.Size = new System.Drawing.Size(644, 24);
            this.AddinTitleLabel.TabIndex = 6;
            this.AddinTitleLabel.Text = "Click on left pane..";
            this.AddinTitleLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddinTitleLabel.Click += new System.EventHandler(this.AddinTitleLabel_Click);
            // 
            // helpbox
            // 
            this.helpbox.BackColor = System.Drawing.Color.Yellow;
            this.helpbox.Caption = "Help";
            this.helpbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpbox.Description = null;
            this.helpbox.DialogResult = System.Windows.Forms.DialogResult.None;
            this.helpbox.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.helpbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.helpbox.HasBorder = true;
            this.helpbox.HasRightSideBorder = false;
            this.helpbox.Image = null;
            this.helpbox.Is2PaneDrawing = false;
            this.helpbox.IsImageTransparent = false;
            this.helpbox.IsMouseOn = false;
            this.helpbox.IsRadio = false;
            this.helpbox.Location = new System.Drawing.Point(2, 1);
            this.helpbox.Name = "helpbox";
            this.helpbox.ShowDescriptionOnHover = true;
            this.helpbox.Size = new System.Drawing.Size(35, 20);
            this.helpbox.TabIndex = 0;
            this.helpbox.Text = "Help";
            this.helpbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.helpbox.Visible = false;
            this.helpbox.Click += new System.EventHandler(this.helpbox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(844, 541);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "MainForm";
            this.Text = "Squadron for SharePoint 2013";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuLog.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            this.stylingHeaderPanel1.ResumeLayout(false);
            this.stylingHeaderPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.FollowPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.AddinTitleLabel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MenuLog;
        private System.Windows.Forms.ToolStripMenuItem clearMenu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox UrlText;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Panel panel1;
        private Windows8LookNFeel.Windows8ListBox AddinList;
        private System.Windows.Forms.Button BlogButton;
        private System.Windows.Forms.Button TwitterButton;
        private System.Windows.Forms.Button FacebookButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel AddinControlContainer;
        private Windows8LookNFeel.Windows8Panel AddinTitleLabel;
        private Windows8LookNFeel.Windows8Button helpbox;
        private Windows8LookNFeel.Windows8Panel stylingHeaderPanel1;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.ListBox LogBox;
        private Windows8LookNFeel.Windows8Panel stylingHeaderPanel2;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardAllToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox DomainText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem DebugMessagesChecked;
        public System.Windows.Forms.LinkLabel TitleLabel;
        public System.Windows.Forms.WebBrowser browser;
        public System.Windows.Forms.Panel FollowPanel;
        private System.Windows.Forms.PictureBox Refresh;
    }
}

