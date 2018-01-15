namespace SquadronAddIns.Default.Permissions.Dialogs
{
    partial class CopyDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyDialog));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.stylingWorkarea2 = new Windows8LookNFeel.Windows8Panel();
            this.stylingWorkarea4 = new Windows8LookNFeel.Windows8Panel();
            this.CopyButton = new Windows8LookNFeel.Windows8Button();
            this.Find2Button = new Windows8LookNFeel.Windows8Button();
            this.DestUserText = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stylingHeaderPanel2 = new Windows8LookNFeel.Windows8Panel();
            this.stylingWorkarea1 = new Windows8LookNFeel.Windows8Panel();
            this.stylingWorkarea3 = new Windows8LookNFeel.Windows8Panel();
            this.FindButton = new Windows8LookNFeel.Windows8Button();
            this.SourceUserText = new System.Windows.Forms.TextBox();
            this.userPicture1 = new System.Windows.Forms.PictureBox();
            this.stylingHeaderPanel1 = new Windows8LookNFeel.Windows8Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DestinationPermissions = new SquadronAddIns.Default.Permissions.Components.PermissionComponent();
            this.SourcePermissions = new SquadronAddIns.Default.Permissions.Components.PermissionComponent();
            this.WorkareaPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.stylingWorkarea2.SuspendLayout();
            this.stylingWorkarea4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.stylingWorkarea1.SuspendLayout();
            this.stylingWorkarea3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.Controls.Add(this.tableLayoutPanel1);
            this.WorkareaPanel.Size = new System.Drawing.Size(942, 485);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.SlateBlue;
            this.HeaderPanel.Size = new System.Drawing.Size(942, 45);
            this.HeaderPanel.Text = "Copy Permissions";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Location = new System.Drawing.Point(0, 530);
            this.FooterPanel.Size = new System.Drawing.Size(942, 27);
            this.FooterPanel.Text = "Enter user name to search for.  Exact domain\\name format required.";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(906, 12);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.stylingWorkarea2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.stylingWorkarea1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 485);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // stylingWorkarea2
            // 
            this.stylingWorkarea2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea2.Controls.Add(this.DestinationPermissions);
            this.stylingWorkarea2.Controls.Add(this.stylingWorkarea4);
            this.stylingWorkarea2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea2.Location = new System.Drawing.Point(474, 3);
            this.stylingWorkarea2.Name = "stylingWorkarea2";
            this.stylingWorkarea2.Size = new System.Drawing.Size(465, 479);
            this.stylingWorkarea2.TabIndex = 3;
            // 
            // stylingWorkarea4
            // 
            this.stylingWorkarea4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea4.Controls.Add(this.CopyButton);
            this.stylingWorkarea4.Controls.Add(this.Find2Button);
            this.stylingWorkarea4.Controls.Add(this.DestUserText);
            this.stylingWorkarea4.Controls.Add(this.pictureBox2);
            this.stylingWorkarea4.Controls.Add(this.stylingHeaderPanel2);
            this.stylingWorkarea4.Dock = System.Windows.Forms.DockStyle.Top;
            this.stylingWorkarea4.Location = new System.Drawing.Point(0, 0);
            this.stylingWorkarea4.Name = "stylingWorkarea4";
            this.stylingWorkarea4.Size = new System.Drawing.Size(465, 71);
            this.stylingWorkarea4.TabIndex = 0;
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.CopyButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CopyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.ForeColor = System.Drawing.Color.White;
            this.CopyButton.Image = null;
            this.CopyButton.Location = new System.Drawing.Point(380, 29);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(77, 32);
            this.CopyButton.TabIndex = 16;
            this.CopyButton.Text = "Copy";
            this.CopyButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // Find2Button
            // 
            this.Find2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.Find2Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Find2Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find2Button.ForeColor = System.Drawing.Color.White;
            this.Find2Button.Image = null;
            this.Find2Button.Location = new System.Drawing.Point(303, 29);
            this.Find2Button.Name = "Find2Button";
            this.Find2Button.Size = new System.Drawing.Size(74, 32);
            this.Find2Button.TabIndex = 16;
            this.Find2Button.Text = "Find";
            this.Find2Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Find2Button.Click += new System.EventHandler(this.Find2Button_Click);
            // 
            // DestUserText
            // 
            this.DestUserText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DestUserText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestUserText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestUserText.Location = new System.Drawing.Point(45, 30);
            this.DestUserText.Name = "DestUserText";
            this.DestUserText.Size = new System.Drawing.Size(253, 25);
            this.DestUserText.TabIndex = 15;
            this.toolTip1.SetToolTip(this.DestUserText, "Enter user name in the format DOMAIN\\User");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Click here to select user");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // stylingHeaderPanel2
            // 
            this.stylingHeaderPanel2.BackColor = System.Drawing.Color.Silver;
            this.stylingHeaderPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.stylingHeaderPanel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stylingHeaderPanel2.Image = null;
            this.stylingHeaderPanel2.Location = new System.Drawing.Point(0, 0);
            this.stylingHeaderPanel2.Name = "stylingHeaderPanel2";
            this.stylingHeaderPanel2.Size = new System.Drawing.Size(465, 24);
            this.stylingHeaderPanel2.TabIndex = 2;
            this.stylingHeaderPanel2.Tag = ";";
            this.stylingHeaderPanel2.Text = "Copy To";
            this.stylingHeaderPanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stylingWorkarea1
            // 
            this.stylingWorkarea1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea1.Controls.Add(this.SourcePermissions);
            this.stylingWorkarea1.Controls.Add(this.stylingWorkarea3);
            this.stylingWorkarea1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea1.Location = new System.Drawing.Point(3, 3);
            this.stylingWorkarea1.Name = "stylingWorkarea1";
            this.stylingWorkarea1.Size = new System.Drawing.Size(465, 479);
            this.stylingWorkarea1.TabIndex = 2;
            // 
            // stylingWorkarea3
            // 
            this.stylingWorkarea3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea3.Controls.Add(this.FindButton);
            this.stylingWorkarea3.Controls.Add(this.SourceUserText);
            this.stylingWorkarea3.Controls.Add(this.userPicture1);
            this.stylingWorkarea3.Controls.Add(this.stylingHeaderPanel1);
            this.stylingWorkarea3.Dock = System.Windows.Forms.DockStyle.Top;
            this.stylingWorkarea3.Location = new System.Drawing.Point(0, 0);
            this.stylingWorkarea3.Name = "stylingWorkarea3";
            this.stylingWorkarea3.Size = new System.Drawing.Size(465, 71);
            this.stylingWorkarea3.TabIndex = 0;
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.FindButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FindButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.ForeColor = System.Drawing.Color.White;
            this.FindButton.Image = null;
            this.FindButton.Location = new System.Drawing.Point(370, 29);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(87, 32);
            this.FindButton.TabIndex = 16;
            this.FindButton.Text = "Find";
            this.FindButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // SourceUserText
            // 
            this.SourceUserText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SourceUserText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SourceUserText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceUserText.Location = new System.Drawing.Point(45, 30);
            this.SourceUserText.Name = "SourceUserText";
            this.SourceUserText.Size = new System.Drawing.Size(319, 25);
            this.SourceUserText.TabIndex = 15;
            this.toolTip1.SetToolTip(this.SourceUserText, "Enter user name in the format DOMAIN\\User");
            // 
            // userPicture1
            // 
            this.userPicture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPicture1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPicture1.Image = ((System.Drawing.Image)(resources.GetObject("userPicture1.Image")));
            this.userPicture1.Location = new System.Drawing.Point(7, 30);
            this.userPicture1.Name = "userPicture1";
            this.userPicture1.Size = new System.Drawing.Size(29, 29);
            this.userPicture1.TabIndex = 3;
            this.userPicture1.TabStop = false;
            this.toolTip1.SetToolTip(this.userPicture1, "Click here to select user");
            this.userPicture1.Click += new System.EventHandler(this.userPicture1_Click);
            // 
            // stylingHeaderPanel1
            // 
            this.stylingHeaderPanel1.BackColor = System.Drawing.Color.Silver;
            this.stylingHeaderPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stylingHeaderPanel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stylingHeaderPanel1.Image = null;
            this.stylingHeaderPanel1.Location = new System.Drawing.Point(0, 0);
            this.stylingHeaderPanel1.Name = "stylingHeaderPanel1";
            this.stylingHeaderPanel1.Size = new System.Drawing.Size(465, 24);
            this.stylingHeaderPanel1.TabIndex = 2;
            this.stylingHeaderPanel1.Tag = ";";
            this.stylingHeaderPanel1.Text = "Copy From";
            this.stylingHeaderPanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DestinationPermissions
            // 
            this.DestinationPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DestinationPermissions.Location = new System.Drawing.Point(0, 71);
            this.DestinationPermissions.Name = "DestinationPermissions";
            this.DestinationPermissions.Size = new System.Drawing.Size(465, 408);
            this.DestinationPermissions.TabIndex = 1;
            // 
            // SourcePermissions
            // 
            this.SourcePermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourcePermissions.Location = new System.Drawing.Point(0, 71);
            this.SourcePermissions.Name = "SourcePermissions";
            this.SourcePermissions.Size = new System.Drawing.Size(465, 408);
            this.SourcePermissions.TabIndex = 1;
            // 
            // CopyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 557);
            this.HeaderText = "Copy Permissions";
            this.Name = "CopyDialog";
            this.ShowFooter = true;
            this.Text = "Copy Permissions";
            this.WorkareaPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.stylingWorkarea2.ResumeLayout(false);
            this.stylingWorkarea4.ResumeLayout(false);
            this.stylingWorkarea4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.stylingWorkarea1.ResumeLayout(false);
            this.stylingWorkarea3.ResumeLayout(false);
            this.stylingWorkarea3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea1;
        private Components.PermissionComponent SourcePermissions;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea3;
        private Windows8LookNFeel.Windows8Panel stylingHeaderPanel1;
        private System.Windows.Forms.PictureBox userPicture1;
        public System.Windows.Forms.TextBox SourceUserText;
        private Windows8LookNFeel.Windows8Button FindButton;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea2;
        private Components.PermissionComponent DestinationPermissions;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea4;
        private Windows8LookNFeel.Windows8Button CopyButton;
        private Windows8LookNFeel.Windows8Button Find2Button;
        public System.Windows.Forms.TextBox DestUserText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Windows8LookNFeel.Windows8Panel stylingHeaderPanel2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
