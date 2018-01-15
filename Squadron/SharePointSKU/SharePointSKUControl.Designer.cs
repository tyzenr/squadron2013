namespace SquadronAddIns.Default.SharePointSKU
{
    partial class SharePointSKUControl
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
            this.FindButton = new Windows8LookNFeel.Windows8Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.FindButton.Caption = "Find";
            this.FindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindButton.Description = null;
            this.FindButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FindButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.FindButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.ForeColor = System.Drawing.Color.White;
            this.FindButton.HasBorder = true;
            this.FindButton.HasRightSideBorder = false;
            this.FindButton.Image = null;
            this.FindButton.Is2PaneDrawing = false;
            this.FindButton.IsImageTransparent = false;
            this.FindButton.IsMouseOn = false;
            this.FindButton.IsRadio = false;
            this.FindButton.Location = new System.Drawing.Point(28, 57);
            this.FindButton.Name = "FindButton";
            this.FindButton.ShowDescriptionOnHover = true;
            this.FindButton.Size = new System.Drawing.Size(148, 32);
            this.FindButton.TabIndex = 17;
            this.FindButton.Text = "Find";
            this.FindButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(22, 22);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(378, 30);
            this.TotalLabel.TabIndex = 18;
            this.TotalLabel.Text = "SharePoint SKU (Stock Keeping Unit)";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.Color.Coral;
            this.OutputLabel.Location = new System.Drawing.Point(23, 111);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 30);
            this.OutputLabel.TabIndex = 18;
            // 
            // SharePointSKUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.FindButton);
            this.Name = "SharePointSKUControl";
            this.Size = new System.Drawing.Size(706, 303);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows8LookNFeel.Windows8Button FindButton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label OutputLabel;
    }
}
