namespace Squadron.Others
{
    partial class DisclaimerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisclaimerForm));
            this.NamePanel = new Windows8LookNFeel.Windows8Panel();
            this.stylingPanel1 = new Windows8LookNFeel.Windows8Panel();
            this.OkButton = new Windows8LookNFeel.Windows8Button();
            this.label3 = new System.Windows.Forms.Label();
            this.stylingPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.Color.Silver;
            this.NamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NamePanel.Caption = "Disclaimer";
            this.NamePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NamePanel.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.NamePanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamePanel.HasBorder = true;
            this.NamePanel.Image = null;
            this.NamePanel.IsImageTransparent = false;
            this.NamePanel.Location = new System.Drawing.Point(0, 0);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(506, 41);
            this.NamePanel.TabIndex = 20;
            this.NamePanel.Text = "Disclaimer";
            this.NamePanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stylingPanel1
            // 
            this.stylingPanel1.BackColor = System.Drawing.Color.White;
            this.stylingPanel1.Caption = null;
            this.stylingPanel1.Controls.Add(this.NamePanel);
            this.stylingPanel1.Controls.Add(this.OkButton);
            this.stylingPanel1.Controls.Add(this.label3);
            this.stylingPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingPanel1.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingPanel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stylingPanel1.HasBorder = true;
            this.stylingPanel1.Image = null;
            this.stylingPanel1.IsImageTransparent = false;
            this.stylingPanel1.Location = new System.Drawing.Point(0, 0);
            this.stylingPanel1.Name = "stylingPanel1";
            this.stylingPanel1.Size = new System.Drawing.Size(506, 346);
            this.stylingPanel1.TabIndex = 6;
            this.stylingPanel1.Tag = ";";
            this.stylingPanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.OkButton.Caption = "Ok";
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.Description = null;
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.OkButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OkButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OkButton.HasBorder = true;
            this.OkButton.HasRightSideBorder = false;
            this.OkButton.Image = null;
            this.OkButton.Is2PaneDrawing = false;
            this.OkButton.IsImageTransparent = false;
            this.OkButton.IsMouseOn = false;
            this.OkButton.IsRadio = false;
            this.OkButton.Location = new System.Drawing.Point(219, 307);
            this.OkButton.Name = "OkButton";
            this.OkButton.ShowDescriptionOnHover = true;
            this.OkButton.Size = new System.Drawing.Size(85, 26);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "Ok";
            this.OkButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(7, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(496, 246);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DisclaimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 346);
            this.Controls.Add(this.stylingPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisclaimerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Squadron";
            this.stylingPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Windows8LookNFeel.Windows8Panel NamePanel;
        private Windows8LookNFeel.Windows8Panel stylingPanel1;
        private Windows8LookNFeel.Windows8Button OkButton;
        private System.Windows.Forms.Label label3;
    }
}
