namespace SquadronAddIns.Default.Permissions.Dialogs
{
    partial class DeleteDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteDialog));
            this.UrlText = new System.Windows.Forms.TextBox();
            this.WebUniqueCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.FindButton = new Windows8LookNFeel.Windows8Button();
            this.ItemsList = new System.Windows.Forms.CheckedListBox();
            this.DeleteButton = new Windows8LookNFeel.Windows8Button();
            this.ItemCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.ListCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.SiteCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FindDeadAccountsButton = new Windows8LookNFeel.Windows8Button();
            this.userPic = new System.Windows.Forms.PictureBox();
            this.UniquePermissionsCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.ADText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkareaPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.Controls.Add(this.userPic);
            this.WorkareaPanel.Controls.Add(this.UniquePermissionsCheck);
            this.WorkareaPanel.Controls.Add(this.ItemCheck);
            this.WorkareaPanel.Controls.Add(this.ListCheck);
            this.WorkareaPanel.Controls.Add(this.SiteCheck);
            this.WorkareaPanel.Controls.Add(this.DeleteButton);
            this.WorkareaPanel.Controls.Add(this.ItemsList);
            this.WorkareaPanel.Controls.Add(this.FindDeadAccountsButton);
            this.WorkareaPanel.Controls.Add(this.FindButton);
            this.WorkareaPanel.Controls.Add(this.label1);
            this.WorkareaPanel.Controls.Add(this.NameText);
            this.WorkareaPanel.Controls.Add(this.label2);
            this.WorkareaPanel.Controls.Add(this.WebUniqueCountLabel);
            this.WorkareaPanel.Controls.Add(this.ADText);
            this.WorkareaPanel.Controls.Add(this.UrlText);
            this.WorkareaPanel.Size = new System.Drawing.Size(721, 425);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HeaderPanel.Size = new System.Drawing.Size(721, 45);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.Text = "Delete Permissions";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FooterPanel.Location = new System.Drawing.Point(0, 470);
            this.FooterPanel.Size = new System.Drawing.Size(721, 27);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(690, 15);
            // 
            // UrlText
            // 
            this.UrlText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UrlText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlText.Location = new System.Drawing.Point(60, 15);
            this.UrlText.Name = "UrlText";
            this.UrlText.Size = new System.Drawing.Size(645, 25);
            this.UrlText.TabIndex = 0;
            this.UrlText.Text = "http://localhost";
            // 
            // WebUniqueCountLabel
            // 
            this.WebUniqueCountLabel.AutoSize = true;
            this.WebUniqueCountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebUniqueCountLabel.Location = new System.Drawing.Point(15, 17);
            this.WebUniqueCountLabel.Name = "WebUniqueCountLabel";
            this.WebUniqueCountLabel.Size = new System.Drawing.Size(39, 19);
            this.WebUniqueCountLabel.TabIndex = 24;
            this.WebUniqueCountLabel.Text = "URL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Name:";
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.Location = new System.Drawing.Point(106, 88);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(198, 25);
            this.NameText.TabIndex = 2;
            this.NameText.Text = "Group or Login Name";
            this.toolTip1.SetToolTip(this.NameText, "Enter the Group Name or Login Name you wanted to search for.  You can also enter " +
        "partial names");
            // 
            // FindButton
            // 
            this.FindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.FindButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FindButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.ForeColor = System.Drawing.Color.White;
            this.FindButton.Image = null;
            this.FindButton.Location = new System.Drawing.Point(13, 128);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(495, 33);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Find by Name";
            this.FindButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ItemsList
            // 
            this.ItemsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemsList.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.HorizontalScrollbar = true;
            this.ItemsList.Location = new System.Drawing.Point(12, 167);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(581, 242);
            this.ItemsList.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ItemsList, "Double click to examine the Securable Object (Site, List/Library, Item) or User d" +
        "etails");
            this.ItemsList.DoubleClick += new System.EventHandler(this.ItemsList_DoubleClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Image = null;
            this.DeleteButton.Location = new System.Drawing.Point(599, 167);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(107, 242);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ItemCheck
            // 
            this.ItemCheck.AutoSize = true;
            this.ItemCheck.Checked = true;
            this.ItemCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ItemCheck.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCheck.Location = new System.Drawing.Point(659, 92);
            this.ItemCheck.Name = "ItemCheck";
            this.ItemCheck.Size = new System.Drawing.Size(50, 19);
            this.ItemCheck.TabIndex = 6;
            this.ItemCheck.Text = "Item";
            this.ItemCheck.UseVisualStyleBackColor = true;
            // 
            // ListCheck
            // 
            this.ListCheck.AutoSize = true;
            this.ListCheck.Checked = true;
            this.ListCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ListCheck.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCheck.Location = new System.Drawing.Point(559, 92);
            this.ListCheck.Name = "ListCheck";
            this.ListCheck.Size = new System.Drawing.Size(99, 19);
            this.ListCheck.TabIndex = 5;
            this.ListCheck.Text = "List && Library";
            this.ListCheck.UseVisualStyleBackColor = true;
            // 
            // SiteCheck
            // 
            this.SiteCheck.AutoSize = true;
            this.SiteCheck.Checked = true;
            this.SiteCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SiteCheck.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteCheck.Location = new System.Drawing.Point(493, 92);
            this.SiteCheck.Name = "SiteCheck";
            this.SiteCheck.Size = new System.Drawing.Size(46, 19);
            this.SiteCheck.TabIndex = 4;
            this.SiteCheck.Text = "Site";
            this.SiteCheck.UseVisualStyleBackColor = true;
            // 
            // FindDeadAccountsButton
            // 
            this.FindDeadAccountsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindDeadAccountsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.FindDeadAccountsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FindDeadAccountsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindDeadAccountsButton.ForeColor = System.Drawing.Color.White;
            this.FindDeadAccountsButton.Image = null;
            this.FindDeadAccountsButton.Location = new System.Drawing.Point(511, 128);
            this.FindDeadAccountsButton.Name = "FindDeadAccountsButton";
            this.FindDeadAccountsButton.Size = new System.Drawing.Size(195, 33);
            this.FindDeadAccountsButton.TabIndex = 8;
            this.FindDeadAccountsButton.Text = "Find Dead Accounts";
            this.FindDeadAccountsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.FindDeadAccountsButton, "Find User Accounts that are Inactive in Active Directory");
            this.FindDeadAccountsButton.Click += new System.EventHandler(this.FindDeadAccountsButton_Click);
            // 
            // userPic
            // 
            this.userPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPic.Image = ((System.Drawing.Image)(resources.GetObject("userPic.Image")));
            this.userPic.Location = new System.Drawing.Point(70, 88);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(29, 29);
            this.userPic.TabIndex = 27;
            this.userPic.TabStop = false;
            this.toolTip1.SetToolTip(this.userPic, "Click here to select user");
            this.userPic.Click += new System.EventHandler(this.userPic_Click);
            // 
            // UniquePermissionsCheck
            // 
            this.UniquePermissionsCheck.BackColor = System.Drawing.Color.Transparent;
            this.UniquePermissionsCheck.Checked = true;
            this.UniquePermissionsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UniquePermissionsCheck.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniquePermissionsCheck.Location = new System.Drawing.Point(315, 92);
            this.UniquePermissionsCheck.Name = "UniquePermissionsCheck";
            this.UniquePermissionsCheck.Size = new System.Drawing.Size(160, 18);
            this.UniquePermissionsCheck.TabIndex = 3;
            this.UniquePermissionsCheck.Text = "Unique Permissions Only";
            this.UniquePermissionsCheck.UseVisualStyleBackColor = false;
            // 
            // ADText
            // 
            this.ADText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ADText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ADText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADText.Location = new System.Drawing.Point(137, 51);
            this.ADText.Name = "ADText";
            this.ADText.Size = new System.Drawing.Size(568, 25);
            this.ADText.TabIndex = 1;
            this.ADText.Text = "http://localhost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Active Directory:";
            // 
            // DeleteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 497);
            this.HeaderText = "Delete Permissions";
            this.Name = "DeleteDialog";
            this.ShowFooter = true;
            this.Text = "Delete Permissions";
            this.WorkareaPanel.ResumeLayout(false);
            this.WorkareaPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox UrlText;
        private System.Windows.Forms.Label WebUniqueCountLabel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox NameText;
        private Windows8LookNFeel.Windows8Button FindButton;
        private Windows8LookNFeel.Windows8Button DeleteButton;
        private System.Windows.Forms.CheckedListBox ItemsList;
        private Windows8LookNFeel.Windows8CheckBox ItemCheck;
        private Windows8LookNFeel.Windows8CheckBox ListCheck;
        private Windows8LookNFeel.Windows8CheckBox SiteCheck;
        private System.Windows.Forms.ToolTip toolTip1;
        private Windows8LookNFeel.Windows8CheckBox UniquePermissionsCheck;
        private Windows8LookNFeel.Windows8Button FindDeadAccountsButton;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ADText;
        private System.Windows.Forms.PictureBox userPic;
    }
}
