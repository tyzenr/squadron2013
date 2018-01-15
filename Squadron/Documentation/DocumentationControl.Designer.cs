namespace SquadronAddIns.Default.Documentation
{
    partial class DocumentationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentationControl));
            this.stylingWorkarea3 = new Windows8LookNFeel.Windows8Panel();
            this.ResultPanel = new Windows8LookNFeel.Windows8Panel();
            this.stylingWorkarea2 = new Windows8LookNFeel.Windows8Panel();
            this.ExportToHTMLButton = new System.Windows.Forms.Button();
            this.stylingWorkarea1 = new Windows8LookNFeel.Windows8Panel();
            this.OptionsList = new Windows8LookNFeel.Windows8CheckedListBox();
            this.ExecuteButton = new Windows8LookNFeel.Windows8Button();
            this.stylingWorkarea3.SuspendLayout();
            this.stylingWorkarea2.SuspendLayout();
            this.stylingWorkarea1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stylingWorkarea3
            // 
            this.stylingWorkarea3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea3.Caption = null;
            this.stylingWorkarea3.Controls.Add(this.ResultPanel);
            this.stylingWorkarea3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stylingWorkarea3.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingWorkarea3.HasBorder = true;
            this.stylingWorkarea3.Image = null;
            this.stylingWorkarea3.IsImageTransparent = false;
            this.stylingWorkarea3.Location = new System.Drawing.Point(200, 0);
            this.stylingWorkarea3.Name = "stylingWorkarea3";
            this.stylingWorkarea3.Size = new System.Drawing.Size(604, 483);
            this.stylingWorkarea3.TabIndex = 2;
            this.stylingWorkarea3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ResultPanel
            // 
            this.ResultPanel.AutoScroll = true;
            this.ResultPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResultPanel.Caption = null;
            this.ResultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultPanel.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.ResultPanel.HasBorder = true;
            this.ResultPanel.Image = null;
            this.ResultPanel.IsImageTransparent = false;
            this.ResultPanel.Location = new System.Drawing.Point(0, 0);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(604, 483);
            this.ResultPanel.TabIndex = 1;
            this.ResultPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stylingWorkarea2
            // 
            this.stylingWorkarea2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stylingWorkarea2.Caption = null;
            this.stylingWorkarea2.Controls.Add(this.ExportToHTMLButton);
            this.stylingWorkarea2.Dock = System.Windows.Forms.DockStyle.Right;
            this.stylingWorkarea2.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingWorkarea2.HasBorder = true;
            this.stylingWorkarea2.Image = null;
            this.stylingWorkarea2.IsImageTransparent = false;
            this.stylingWorkarea2.Location = new System.Drawing.Point(804, 0);
            this.stylingWorkarea2.Name = "stylingWorkarea2";
            this.stylingWorkarea2.Size = new System.Drawing.Size(64, 483);
            this.stylingWorkarea2.TabIndex = 1;
            this.stylingWorkarea2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ExportToHTMLButton
            // 
            this.ExportToHTMLButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportToHTMLButton.Image")));
            this.ExportToHTMLButton.Location = new System.Drawing.Point(2, 2);
            this.ExportToHTMLButton.Name = "ExportToHTMLButton";
            this.ExportToHTMLButton.Size = new System.Drawing.Size(59, 84);
            this.ExportToHTMLButton.TabIndex = 0;
            this.ExportToHTMLButton.UseVisualStyleBackColor = true;
            this.ExportToHTMLButton.Click += new System.EventHandler(this.ExportToHTMLButton_Click);
            // 
            // stylingWorkarea1
            // 
            this.stylingWorkarea1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stylingWorkarea1.Caption = null;
            this.stylingWorkarea1.Controls.Add(this.OptionsList);
            this.stylingWorkarea1.Controls.Add(this.ExecuteButton);
            this.stylingWorkarea1.Dock = System.Windows.Forms.DockStyle.Left;
            this.stylingWorkarea1.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.stylingWorkarea1.HasBorder = true;
            this.stylingWorkarea1.Image = null;
            this.stylingWorkarea1.IsImageTransparent = false;
            this.stylingWorkarea1.Location = new System.Drawing.Point(0, 0);
            this.stylingWorkarea1.Name = "stylingWorkarea1";
            this.stylingWorkarea1.Size = new System.Drawing.Size(200, 483);
            this.stylingWorkarea1.TabIndex = 0;
            this.stylingWorkarea1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // OptionsList
            // 
            this.OptionsList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OptionsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionsList.CheckOnClick = true;
            this.OptionsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsList.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.DefaultColor;
            this.OptionsList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsList.FormattingEnabled = true;
            this.OptionsList.Location = new System.Drawing.Point(0, 45);
            this.OptionsList.Name = "OptionsList";
            this.OptionsList.Size = new System.Drawing.Size(200, 438);
            this.OptionsList.TabIndex = 2;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(144)))), ((int)(((byte)(50)))));
            this.ExecuteButton.Caption = "Execute";
            this.ExecuteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExecuteButton.Description = null;
            this.ExecuteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExecuteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExecuteButton.DrawingColor = Windows8LookNFeel.Windows8DrawingColor.AlternativeColor;
            this.ExecuteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.ForeColor = System.Drawing.Color.White;
            this.ExecuteButton.HasBorder = true;
            this.ExecuteButton.HasRightSideBorder = false;
            this.ExecuteButton.Image = null;
            this.ExecuteButton.Is2PaneDrawing = false;
            this.ExecuteButton.IsImageTransparent = false;
            this.ExecuteButton.IsMouseOn = false;
            this.ExecuteButton.IsRadio = false;
            this.ExecuteButton.Location = new System.Drawing.Point(0, 0);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.ShowDescriptionOnHover = true;
            this.ExecuteButton.Size = new System.Drawing.Size(200, 45);
            this.ExecuteButton.TabIndex = 1;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // DocumentationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stylingWorkarea3);
            this.Controls.Add(this.stylingWorkarea2);
            this.Controls.Add(this.stylingWorkarea1);
            this.Name = "DocumentationControl";
            this.Size = new System.Drawing.Size(868, 483);
            this.stylingWorkarea3.ResumeLayout(false);
            this.stylingWorkarea2.ResumeLayout(false);
            this.stylingWorkarea1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Windows8LookNFeel.Windows8Panel stylingWorkarea1;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea2;
        private Windows8LookNFeel.Windows8Panel stylingWorkarea3;
        private Windows8LookNFeel.Windows8CheckedListBox OptionsList;
        private Windows8LookNFeel.Windows8Button ExecuteButton;
        private System.Windows.Forms.Button ExportToHTMLButton;
        private Windows8LookNFeel.Windows8Panel ResultPanel;
    }
}
