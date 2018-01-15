namespace Squadron.Dialogs
{
    partial class InputDialog
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
            this.UserText = new System.Windows.Forms.TextBox();
            this.CancelButton = new Windows8LookNFeel.Windows8Button();
            this.OkButton = new Windows8LookNFeel.Windows8Button();
            this.WorkareaPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.Controls.Add(this.CancelButton);
            this.WorkareaPanel.Controls.Add(this.OkButton);
            this.WorkareaPanel.Controls.Add(this.UserText);
            this.WorkareaPanel.Size = new System.Drawing.Size(620, 74);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Caption = "InputDialog";
            this.HeaderPanel.Text = "InputDialog";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Location = new System.Drawing.Point(0, 119);
            // 
            // UserText
            // 
            this.UserText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserText.Location = new System.Drawing.Point(8, 7);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(605, 25);
            this.UserText.TabIndex = 10;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.CancelButton.Caption = "Cancel";
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Description = null;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.CancelButton.Location = new System.Drawing.Point(513, 38);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.ShowDescriptionOnHover = true;
            this.CancelButton.Size = new System.Drawing.Size(100, 26);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.OkButton.Caption = "Ok";
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.Description = null;
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.OkButton.Location = new System.Drawing.Point(411, 38);
            this.OkButton.Name = "OkButton";
            this.OkButton.ShowDescriptionOnHover = true;
            this.OkButton.Size = new System.Drawing.Size(100, 26);
            this.OkButton.TabIndex = 12;
            this.OkButton.Text = "Ok";
            this.OkButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // InputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 146);
            this.HeaderText = "InputDialog";
            this.Name = "InputDialog";
            this.ShowFooter = true;
            this.Text = "InputDialog";
            this.WorkareaPanel.ResumeLayout(false);
            this.WorkareaPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox UserText;
        private Windows8LookNFeel.Windows8Button CancelButton;
        private Windows8LookNFeel.Windows8Button OkButton;
    }
}
