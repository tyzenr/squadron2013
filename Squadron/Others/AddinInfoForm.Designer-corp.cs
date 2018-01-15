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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddinInfoForm));
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescLabel = new System.Windows.Forms.Label();
            this.OkButton = new Squadron.Styling.Widgets.StylingButton();
            this.AuthorInfoLabel = new System.Windows.Forms.LinkLabel();
            this.AboutButton = new Squadron.Styling.Widgets.StylingButton();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NameLabel.Location = new System.Drawing.Point(12, 22);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(427, 33);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescLabel
            // 
            this.DescLabel.BackColor = System.Drawing.Color.Transparent;
            this.DescLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DescLabel.Location = new System.Drawing.Point(12, 67);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(427, 112);
            this.DescLabel.TabIndex = 1;
            this.DescLabel.Text = "Description";
            this.DescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.Transparent;
            this.OkButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.ForeColor = System.Drawing.Color.White;
            this.OkButton.Image = null;
            this.OkButton.Location = new System.Drawing.Point(82, 236);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(104, 31);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AuthorInfoLabel
            // 
            this.AuthorInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthorInfoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorInfoLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AuthorInfoLabel.Location = new System.Drawing.Point(18, 188);
            this.AuthorInfoLabel.Name = "AuthorInfoLabel";
            this.AuthorInfoLabel.Size = new System.Drawing.Size(421, 23);
            this.AuthorInfoLabel.TabIndex = 3;
            this.AuthorInfoLabel.TabStop = true;
            this.AuthorInfoLabel.Text = "Author Info";
            this.AuthorInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AuthorInfoLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AuthorInfoLabel_LinkClicked);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.AboutButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AboutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Image = null;
            this.AboutButton.Location = new System.Drawing.Point(277, 236);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(104, 31);
            this.AboutButton.TabIndex = 2;
            this.AboutButton.Text = "About";
            this.AboutButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // AddinInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(451, 288);
            this.Controls.Add(this.AuthorInfoLabel);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddinInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Addin Info";
            this.Load += new System.EventHandler(this.AddinInfoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescLabel;
        private Squadron.Styling.Widgets.StylingButton OkButton;
        private System.Windows.Forms.LinkLabel AuthorInfoLabel;
        private Squadron.Styling.Widgets.StylingButton AboutButton;
    }
}
