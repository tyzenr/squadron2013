﻿using Windows8LookNFeel;
namespace Squadron.Styling.Widgets
{
    partial class StylingSection
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
            this.HeaderPanel = new Squadron.Styling.Widgets.StylingPanel();
            this.WorkareaPanel = new Squadron.Styling.Widgets.StylingWorkarea();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Font = new System.Drawing.Font("Calibri", 11F);
            this.HeaderPanel.Image = null;
            this.HeaderPanel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(250, 25);
            this.HeaderPanel.StretchImage = false;
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HeaderPanel.TextPadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            // 
            // WorkareaPanel
            // 
            this.WorkareaPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WorkareaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkareaPanel.Location = new System.Drawing.Point(0, 25);
            this.WorkareaPanel.Name = "WorkareaPanel";
            this.WorkareaPanel.Size = new System.Drawing.Size(250, 176);
            this.WorkareaPanel.TabIndex = 1;
            // 
            // StylingOutlookPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.WorkareaPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "StylingOutlookPanel";
            this.Size = new System.Drawing.Size(250, 201);
            this.ResumeLayout(false);

        }

        #endregion

        public Windows8Panel HeaderPanel;
        public StylingWorkarea WorkareaPanel;

    }
}
