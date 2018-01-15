namespace SquadronAddIns.Default.Diagnostics
{
    partial class DiagnosticsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosticsControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RefreshButton = new Windows8LookNFeel.Windows8Button();
            this.SharePointObjectsButton = new SquadronAddIns.Default.Components.SharePointButton();
            this.ExecuteAllButton = new Windows8LookNFeel.Windows8Button();
            this.actionControl = new Squadron.Widgets.ActionControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Controls.Add(this.SharePointObjectsButton);
            this.panel1.Controls.Add(this.ExecuteAllButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 32);
            this.panel1.TabIndex = 14;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.Caption = null;
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.Description = null;
            this.RefreshButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RefreshButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.HasBorder = true;
            this.RefreshButton.HasRightSideBorder = false;
            this.RefreshButton.Image = null;
            this.RefreshButton.Is2PaneDrawing = false;
            this.RefreshButton.IsImageTransparent = false;
            this.RefreshButton.IsMouseOn = false;
            this.RefreshButton.IsRadio = false;
            this.RefreshButton.Location = new System.Drawing.Point(329, 1);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.ShowDescriptionOnHover = true;
            this.RefreshButton.Size = new System.Drawing.Size(27, 31);
            this.RefreshButton.TabIndex = 14;
            this.RefreshButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RefreshButton.Visible = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SharePointObjectsButton
            // 
            this.SharePointObjectsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.SharePointObjectsButton.Caption = "Select Items";
            this.SharePointObjectsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SharePointObjectsButton.Description = null;
            this.SharePointObjectsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SharePointObjectsButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.SharePointObjectsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SharePointObjectsButton.ForeColor = System.Drawing.Color.White;
            this.SharePointObjectsButton.HasBorder = true;
            this.SharePointObjectsButton.HasRightSideBorder = false;
            this.SharePointObjectsButton.Image = null;
            this.SharePointObjectsButton.Is2PaneDrawing = false;
            this.SharePointObjectsButton.IsImageTransparent = false;
            this.SharePointObjectsButton.IsMouseOn = false;
            this.SharePointObjectsButton.IsRadio = false;
            this.SharePointObjectsButton.Location = new System.Drawing.Point(162, 1);
            this.SharePointObjectsButton.Name = "SharePointObjectsButton";
            this.SharePointObjectsButton.ShowDescriptionOnHover = true;
            this.SharePointObjectsButton.Size = new System.Drawing.Size(165, 31);
            this.SharePointObjectsButton.TabIndex = 14;
            this.SharePointObjectsButton.Text = "SharePoint Objects: All";
            this.SharePointObjectsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SharePointObjectsButton.OnSelectionChanged += new SquadronAddIns.Default.Components.SharePointButton.SelectionChangedEventHandler(this.SelectionButton_OnSelectionChanged);
            // 
            // ExecuteAllButton
            // 
            this.ExecuteAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.ExecuteAllButton.Caption = "Execute";
            this.ExecuteAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExecuteAllButton.Description = null;
            this.ExecuteAllButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExecuteAllButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.ExecuteAllButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteAllButton.ForeColor = System.Drawing.Color.White;
            this.ExecuteAllButton.HasBorder = true;
            this.ExecuteAllButton.HasRightSideBorder = false;
            this.ExecuteAllButton.Image = null;
            this.ExecuteAllButton.Is2PaneDrawing = false;
            this.ExecuteAllButton.IsImageTransparent = false;
            this.ExecuteAllButton.IsMouseOn = false;
            this.ExecuteAllButton.IsRadio = false;
            this.ExecuteAllButton.Location = new System.Drawing.Point(1, 1);
            this.ExecuteAllButton.Name = "ExecuteAllButton";
            this.ExecuteAllButton.ShowDescriptionOnHover = true;
            this.ExecuteAllButton.Size = new System.Drawing.Size(160, 31);
            this.ExecuteAllButton.TabIndex = 13;
            this.ExecuteAllButton.Text = "Execute All";
            this.ExecuteAllButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExecuteAllButton.Click += new System.EventHandler(this.ExecuteAllButton_Click);
            // 
            // actionControl
            // 
            this.actionControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.actionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionControl.Location = new System.Drawing.Point(0, 32);
            this.actionControl.Name = "actionControl";
            this.actionControl.Size = new System.Drawing.Size(665, 248);
            this.actionControl.TabIndex = 15;
            this.actionControl.BeforeExecute += new Squadron.Widgets.ActionControl.BeforeExecuteEventHandler(this.actionControl_BeforeExecute);
            // 
            // DiagnosticsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.actionControl);
            this.Controls.Add(this.panel1);
            this.Name = "DiagnosticsControl";
            this.Size = new System.Drawing.Size(665, 280);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Squadron.Widgets.ActionControl actionControl;
        private Windows8LookNFeel.Windows8Button ExecuteAllButton;
        private System.Windows.Forms.Panel panel1;
        private Components.SharePointButton SharePointObjectsButton;
        private Windows8LookNFeel.Windows8Button RefreshButton;

    }
}
