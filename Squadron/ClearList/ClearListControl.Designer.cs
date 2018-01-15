namespace SquadronAddins.Default.EmptyList
{
    partial class ClearListControl
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
            this.NameList = new System.Windows.Forms.CheckedListBox();
            this.RefreshButton = new Windows8LookNFeel.Windows8Button();
            this.EmptyButton = new Windows8LookNFeel.Windows8Button();
            this.ShowHiddenCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.DeleteButton = new Windows8LookNFeel.Windows8Button();
            this.CountCheck = new Windows8LookNFeel.Windows8CheckBox();
            this.SuspendLayout();
            // 
            // NameList
            // 
            this.NameList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NameList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameList.FormattingEnabled = true;
            this.NameList.Location = new System.Drawing.Point(13, 47);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(458, 334);
            this.NameList.Sorted = true;
            this.NameList.TabIndex = 3;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.RefreshButton.Caption = "Refresh";
            this.RefreshButton.Description = null;
            this.RefreshButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RefreshButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.HasBorder = true;
            this.RefreshButton.HasRightSideBorder = false;
            this.RefreshButton.Image = null;
            this.RefreshButton.Is2PaneDrawing = false;
            this.RefreshButton.IsImageTransparent = false;
            this.RefreshButton.IsMouseOn = false;
            this.RefreshButton.IsRadio = false;
            this.RefreshButton.Location = new System.Drawing.Point(13, 9);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.ShowDescriptionOnHover = true;
            this.RefreshButton.Size = new System.Drawing.Size(138, 32);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // EmptyButton
            // 
            this.EmptyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.EmptyButton.Caption = "Clear";
            this.EmptyButton.Description = null;
            this.EmptyButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EmptyButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.EmptyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyButton.ForeColor = System.Drawing.Color.White;
            this.EmptyButton.HasBorder = true;
            this.EmptyButton.HasRightSideBorder = false;
            this.EmptyButton.Image = null;
            this.EmptyButton.Is2PaneDrawing = false;
            this.EmptyButton.IsImageTransparent = false;
            this.EmptyButton.IsMouseOn = false;
            this.EmptyButton.IsRadio = false;
            this.EmptyButton.Location = new System.Drawing.Point(477, 47);
            this.EmptyButton.Name = "EmptyButton";
            this.EmptyButton.ShowDescriptionOnHover = true;
            this.EmptyButton.Size = new System.Drawing.Size(145, 33);
            this.EmptyButton.TabIndex = 4;
            this.EmptyButton.Text = "Clear Selected";
            this.EmptyButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmptyButton.Click += new System.EventHandler(this.EmptyButton_Click);
            // 
            // ShowHiddenCheck
            // 
            this.ShowHiddenCheck.AutoSize = true;
            this.ShowHiddenCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.ShowHiddenCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowHiddenCheck.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.ShowHiddenCheck.Location = new System.Drawing.Point(252, 16);
            this.ShowHiddenCheck.Name = "ShowHiddenCheck";
            this.ShowHiddenCheck.Size = new System.Drawing.Size(97, 19);
            this.ShowHiddenCheck.TabIndex = 15;
            this.ShowHiddenCheck.Text = "Show Hidden";
            this.ShowHiddenCheck.UseVisualStyleBackColor = false;
            this.ShowHiddenCheck.CheckedChanged += new System.EventHandler(this.ShowHiddenCheck_CheckedChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.DeleteButton.Caption = "Delete";
            this.DeleteButton.Description = null;
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.HasBorder = true;
            this.DeleteButton.HasRightSideBorder = false;
            this.DeleteButton.Image = null;
            this.DeleteButton.Is2PaneDrawing = false;
            this.DeleteButton.IsImageTransparent = false;
            this.DeleteButton.IsMouseOn = false;
            this.DeleteButton.IsRadio = false;
            this.DeleteButton.Location = new System.Drawing.Point(477, 82);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ShowDescriptionOnHover = true;
            this.DeleteButton.Size = new System.Drawing.Size(145, 33);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete Selected";
            this.DeleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CountCheck
            // 
            this.CountCheck.AutoSize = true;
            this.CountCheck.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.CountCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountCheck.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.CountCheck.Location = new System.Drawing.Point(157, 16);
            this.CountCheck.Name = "CountCheck";
            this.CountCheck.Size = new System.Drawing.Size(91, 19);
            this.CountCheck.TabIndex = 16;
            this.CountCheck.Text = "Show Count";
            this.CountCheck.UseVisualStyleBackColor = false;
            this.CountCheck.CheckedChanged += new System.EventHandler(this.CountCheck_CheckedChanged);
            // 
            // ClearListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CountCheck);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EmptyButton);
            this.Controls.Add(this.NameList);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ShowHiddenCheck);
            this.Name = "ClearListControl";
            this.Size = new System.Drawing.Size(643, 391);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox NameList;
        private Windows8LookNFeel.Windows8Button RefreshButton;
        private Windows8LookNFeel.Windows8Button EmptyButton;
        private Windows8LookNFeel.Windows8CheckBox ShowHiddenCheck;
        private Windows8LookNFeel.Windows8Button DeleteButton;
        private Windows8LookNFeel.Windows8CheckBox CountCheck;

    }
}
