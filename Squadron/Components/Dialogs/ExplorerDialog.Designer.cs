namespace SquadronAddIns.Default.Components.Dialogs
{
    partial class ExplorerDialog
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
            this.stylingWorkarea1 = new Windows8LookNFeel.Windows8Panel();
            this.CancelButton = new Windows8LookNFeel.Windows8Button();
            this.OkButton = new Windows8LookNFeel.Windows8Button();
            this.explorer = new SquadronAddIns.Default.Components.SharePointExplorer();
            this.WorkareaPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.stylingWorkarea1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.Controls.Add(this.explorer);
            this.WorkareaPanel.Controls.Add(this.stylingWorkarea1);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Caption = "SharePoint Objects";
            this.HeaderPanel.Text = "SharePoint Objects";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FooterPanel.Text = "Select SharePoint objects.  Right click for more options..";
            // 
            // stylingWorkarea1
            // 
            this.stylingWorkarea1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea1.Caption = null;
            this.stylingWorkarea1.Controls.Add(this.CancelButton);
            this.stylingWorkarea1.Controls.Add(this.OkButton);
            this.stylingWorkarea1.Dock = System.Windows.Forms.DockStyle.Right;
            this.stylingWorkarea1.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingWorkarea1.HasBorder = true;
            this.stylingWorkarea1.Image = null;
            this.stylingWorkarea1.IsImageTransparent = false;
            this.stylingWorkarea1.Location = new System.Drawing.Point(494, 0);
            this.stylingWorkarea1.Name = "stylingWorkarea1";
            this.stylingWorkarea1.Size = new System.Drawing.Size(126, 353);
            this.stylingWorkarea1.TabIndex = 0;
            this.stylingWorkarea1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.CancelButton.Caption = "Cancel";
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Description = null;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CancelButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.HasBorder = true;
            this.CancelButton.HasRightSideBorder = false;
            this.CancelButton.Image = null;
            this.CancelButton.Is2PaneDrawing = false;
            this.CancelButton.IsImageTransparent = false;
            this.CancelButton.IsMouseOn = false;
            this.CancelButton.IsRadio = false;
            this.CancelButton.Location = new System.Drawing.Point(0, 34);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.ShowDescriptionOnHover = true;
            this.CancelButton.Size = new System.Drawing.Size(126, 34);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.OkButton.Caption = "Ok";
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.Description = null;
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OkButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OkButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.OkButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OkButton.ForeColor = System.Drawing.Color.White;
            this.OkButton.HasBorder = true;
            this.OkButton.HasRightSideBorder = false;
            this.OkButton.Image = null;
            this.OkButton.Is2PaneDrawing = false;
            this.OkButton.IsImageTransparent = false;
            this.OkButton.IsMouseOn = false;
            this.OkButton.IsRadio = false;
            this.OkButton.Location = new System.Drawing.Point(0, 0);
            this.OkButton.Name = "OkButton";
            this.OkButton.ShowDescriptionOnHover = true;
            this.OkButton.Size = new System.Drawing.Size(126, 34);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ok";
            this.OkButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // explorer
            // 
            this.explorer.Checkboxes = true;
            this.explorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorer.Location = new System.Drawing.Point(0, 0);
            this.explorer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.explorer.Name = "explorer";
            this.explorer.Size = new System.Drawing.Size(494, 353);
            this.explorer.TabIndex = 1;
            this.explorer.Url = null;
            // 
            // ExplorerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 425);
            this.HeaderText = "SharePoint Objects";
            this.Name = "ExplorerDialog";
            this.ShowFooter = true;
            this.Text = "SharePoint Objects";
            this.WorkareaPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.stylingWorkarea1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public SharePointExplorer explorer;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea1;
        private Windows8LookNFeel.Windows8Button CancelButton;
        private Windows8LookNFeel.Windows8Button OkButton;


    }
}
