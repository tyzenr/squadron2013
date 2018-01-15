namespace Squadron.Misc
{
    partial class AddinInfoForm
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
            this.stylingPanel1 = new Windows8LookNFeel.Windows8Panel();
            this.NamePanel = new Windows8LookNFeel.Windows8Panel();
            this.AuthorInfoLabel = new System.Windows.Forms.LinkLabel();
            this.AboutButton = new Windows8LookNFeel.Windows8Button();
            this.OkButton = new Windows8LookNFeel.Windows8Button();
            this.DescLabel = new System.Windows.Forms.Label();
            this.stylingPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stylingPanel1
            // 
            this.stylingPanel1.BackColor = System.Drawing.Color.White;
            this.stylingPanel1.Controls.Add(this.NamePanel);
            this.stylingPanel1.Controls.Add(this.AuthorInfoLabel);
            this.stylingPanel1.Controls.Add(this.AboutButton);
            this.stylingPanel1.Controls.Add(this.OkButton);
            this.stylingPanel1.Controls.Add(this.DescLabel);
            this.stylingPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingPanel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stylingPanel1.Location = new System.Drawing.Point(0, 0);
            this.stylingPanel1.Name = "stylingPanel1";
            this.stylingPanel1.Size = new System.Drawing.Size(451, 288);
            this.stylingPanel1.TabIndex = 6;
            this.stylingPanel1.Tag = ";";
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NamePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NamePanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamePanel.Image = null;
            this.NamePanel.Location = new System.Drawing.Point(0, 0);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(451, 41);
            this.NamePanel.TabIndex = 19;
            this.NamePanel.Text = " Test";
            // 
            // AuthorInfoLabel
            // 
            this.AuthorInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthorInfoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorInfoLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.AuthorInfoLabel.LinkColor = System.Drawing.Color.Navy;
            this.AuthorInfoLabel.Location = new System.Drawing.Point(18, 188);
            this.AuthorInfoLabel.Name = "AuthorInfoLabel";
            this.AuthorInfoLabel.Size = new System.Drawing.Size(421, 23);
            this.AuthorInfoLabel.TabIndex = 8;
            this.AuthorInfoLabel.TabStop = true;
            this.AuthorInfoLabel.Text = "Author Info";
            this.AuthorInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AuthorInfoLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AuthorInfoLabel_LinkClicked);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.AboutButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AboutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Image = null;
            this.AboutButton.Location = new System.Drawing.Point(270, 236);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(100, 27);
            this.AboutButton.TabIndex = 7;
            this.AboutButton.Text = "About";
            this.AboutButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.ForeColor = System.Drawing.Color.White;
            this.OkButton.Image = null;
            this.OkButton.Location = new System.Drawing.Point(83, 236);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(100, 27);
            this.OkButton.TabIndex = 6;
            this.OkButton.Text = "Ok";
            this.OkButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // DescLabel
            // 
            this.DescLabel.BackColor = System.Drawing.Color.Transparent;
            this.DescLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.DescLabel.Location = new System.Drawing.Point(12, 44);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(427, 135);
            this.DescLabel.TabIndex = 5;
            this.DescLabel.Text = "Description";
            this.DescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddinInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 288);
            this.Controls.Add(this.stylingPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddinInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Addin Info";
            this.Load += new System.EventHandler(this.AddinInfoForm_Load);
            this.stylingPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Windows8LookNFeel.Windows8Panel stylingPanel1;
        private System.Windows.Forms.LinkLabel AuthorInfoLabel;
        private Windows8LookNFeel.Windows8Button AboutButton;
        private Windows8LookNFeel.Windows8Button OkButton;
        private System.Windows.Forms.Label DescLabel;
        private Windows8LookNFeel.Windows8Panel NamePanel;
    }
}
