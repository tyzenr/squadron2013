namespace SquadronAddIns.Default.Command.Dialogs
{
    partial class SharePointDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.UrlText = new System.Windows.Forms.TextBox();
            this.stylingWorkarea1 = new Windows8LookNFeel.Windows8Panel();
            this.explorer = new SquadronAddIns.Default.Components.SharePointExplorer();
            this.stylingWorkarea2 = new Windows8LookNFeel.Windows8Panel();
            this.CancelButton = new Windows8LookNFeel.Windows8Button();
            this.OkButton = new Windows8LookNFeel.Windows8Button();
            this.WorkareaPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.stylingWorkarea1.SuspendLayout();
            this.stylingWorkarea2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.Controls.Add(this.stylingWorkarea1);
            this.WorkareaPanel.Controls.Add(this.panel1);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Text = "SelectSiteDialog";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalLabel);
            this.panel1.Controls.Add(this.UrlText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 37);
            this.panel1.TabIndex = 0;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(2, 9);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(30, 17);
            this.TotalLabel.TabIndex = 18;
            this.TotalLabel.Text = "Url:";
            // 
            // UrlText
            // 
            this.UrlText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UrlText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlText.Location = new System.Drawing.Point(32, 6);
            this.UrlText.Name = "UrlText";
            this.UrlText.Size = new System.Drawing.Size(584, 25);
            this.UrlText.TabIndex = 17;
            this.UrlText.Text = "http://localhost";
            this.UrlText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrlText_KeyDown);
            // 
            // stylingWorkarea1
            // 
            this.stylingWorkarea1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea1.Controls.Add(this.explorer);
            this.stylingWorkarea1.Controls.Add(this.stylingWorkarea2);
            this.stylingWorkarea1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea1.Location = new System.Drawing.Point(0, 37);
            this.stylingWorkarea1.Name = "stylingWorkarea1";
            this.stylingWorkarea1.Size = new System.Drawing.Size(620, 316);
            this.stylingWorkarea1.TabIndex = 1;
            // 
            // explorer
            // 
            this.explorer.Checkboxes = false;
            this.explorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorer.Location = new System.Drawing.Point(0, 0);
            this.explorer.Name = "explorer";
            this.explorer.Size = new System.Drawing.Size(620, 275);
            this.explorer.TabIndex = 3;
            this.explorer.Url = null;
            // 
            // stylingWorkarea2
            // 
            this.stylingWorkarea2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea2.Controls.Add(this.CancelButton);
            this.stylingWorkarea2.Controls.Add(this.OkButton);
            this.stylingWorkarea2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stylingWorkarea2.Location = new System.Drawing.Point(0, 275);
            this.stylingWorkarea2.Name = "stylingWorkarea2";
            this.stylingWorkarea2.Size = new System.Drawing.Size(620, 41);
            this.stylingWorkarea2.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Image = null;
            this.CancelButton.Location = new System.Drawing.Point(513, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 26);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OkButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OkButton.ForeColor = System.Drawing.Color.White;
            this.OkButton.Image = null;
            this.OkButton.Location = new System.Drawing.Point(411, 7);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(100, 26);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Ok";
            this.OkButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SharePointDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 425);
            this.HeaderText = "SelectSiteDialog";
            this.Name = "SharePointDialog";
            this.ShowFooter = true;
            this.Text = "SelectSiteDialog";
            this.WorkareaPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.stylingWorkarea1.ResumeLayout(false);
            this.stylingWorkarea2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalLabel;
        public System.Windows.Forms.TextBox UrlText;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea1;
        private Components.SharePointExplorer explorer;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea2;
        private Windows8LookNFeel.Windows8Button CancelButton;
        private Windows8LookNFeel.Windows8Button OkButton;
    }
}
